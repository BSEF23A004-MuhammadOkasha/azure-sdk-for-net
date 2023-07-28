﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable enable

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.Json;

namespace Azure.Core.Json
{
    internal partial class MutableJsonDocument
    {
        internal class ChangeTracker
        {
            public ChangeTracker(JsonSerializerOptions options)
            {
                _options = options;
            }

            private List<MutableJsonChange>? _changes;
            private JsonSerializerOptions _options;

            internal const char Delimiter = (char)1;

            internal bool HasChanges => _changes != null && _changes.Count > 0;

            internal bool AncestorChanged(string path, int highWaterMark)
            {
                if (_changes == null)
                {
                    return false;
                }

                bool changed = false;

                // Check for changes to ancestor elements
                while (!changed && path.Length > 0)
                {
                    path = PopProperty(path);
                    changed = TryGetChange(path, highWaterMark, out MutableJsonChange change);
                }

                return changed;
            }

            internal bool DescendantChanged(string path, int highWaterMark)
            {
                if (_changes == null)
                {
                    return false;
                }

                bool changed = false;

                for (int i = _changes!.Count - 1; i > highWaterMark; i--)
                {
                    MutableJsonChange c = _changes[i];
                    if (c.IsDescendant(path))
                    {
                        return true;
                    }
                }

                return changed;
            }

            internal bool TryGetChange(string path, in int lastAppliedChange, out MutableJsonChange change)
            {
                return TryGetChange(path.AsSpan(), lastAppliedChange, out change);
            }

            internal bool TryGetChange(ReadOnlySpan<char> path, in int lastAppliedChange, out MutableJsonChange change)
            {
                if (_changes == null)
                {
                    change = default;
                    return false;
                }

                for (int i = _changes!.Count - 1; i > lastAppliedChange; i--)
                {
                    MutableJsonChange c = _changes[i];
                    if (c.Path.AsSpan().SequenceEqual(path))
                    {
                        change = c;
                        return true;
                    }
                }

                change = default;
                return false;
            }

            internal int AddChange(string path, object? value, MutableJsonChangeKind changeKind = MutableJsonChangeKind.PropertyValue, string? addedPropertyName = null)
            {
                if (_changes == null)
                {
                    _changes = new List<MutableJsonChange>();
                }

                int index = _changes.Count;

                _changes.Add(new MutableJsonChange(path, index, value, _options, changeKind, addedPropertyName));

                return index;
            }

            internal IEnumerable<MutableJsonChange> GetAddedProperties(string path, int highWaterMark)
            {
                if (_changes == null)
                {
                    yield break;
                }

                for (int i = _changes!.Count - 1; i > highWaterMark; i--)
                {
                    MutableJsonChange c = _changes[i];
                    if (c.IsDirectDescendant(path) &&
                        c.ChangeKind == MutableJsonChangeKind.PropertyAddition)
                    {
                        yield return c;
                    }
                }
            }

            internal IEnumerable<MutableJsonChange> GetRemovedProperties(string path, int highWaterMark)
            {
                if (_changes == null)
                {
                    yield break;
                }

                for (int i = _changes!.Count - 1; i > highWaterMark; i--)
                {
                    MutableJsonChange c = _changes[i];
                    if (c.IsDirectDescendant(path) &&
                        c.ChangeKind == MutableJsonChangeKind.PropertyRemoval)
                    {
                        yield return c;
                    }
                }
            }

            internal MutableJsonChange? GetNextChange(MutableJsonChange? lastChange, out int maxPathLength)
            {
                maxPathLength = -1;
                if (_changes == null)
                {
                    // null means there's no next change, we can exit a loop
                    return null;
                }

                MutableJsonChange? min = null;

                // This implementation is based on the assumption that iterating through
                // list elements is fast.
                // Iterating backwards means we get the latest change for a given path.
                for (int i = _changes!.Count - 1; i >= 0; i--)
                {
                    MutableJsonChange c = _changes[i];

                    if (c.IsGreaterThan(lastChange) && c.IsLessThan(min))
                    {
                        min = c;
                    }

                    if (c.Path.Length > maxPathLength)
                    {
                        maxPathLength = c.Path.Length;
                    }
                }

                return min;
            }

            internal IEnumerable<string> GetChangedProperties(out int maxPathLength)
            {
                maxPathLength = 0;

                HashSet<string> unique = new();
                if (_changes == null)
                {
                    return unique;
                }

                // Get unique properties
                for (int i = _changes!.Count - 1; i >= 0; i--)
                {
                    MutableJsonChange c = _changes[i];
                    unique.Add(c.Path);

                    if (c.Path.Length > maxPathLength)
                    {
                        maxPathLength = c.Path.Length;
                    }
                }

                // Sort them
                List<string> list = new(unique);
                list.Sort();

                // Remove descendants if their ancestors changed.
                if (list.Count > 1)
                {
                    // Make a copy we won't mutate
                    List<string> copy = new(list);

                    string current = copy[0];
                    for (int i = 1; i < copy.Count; i++)
                    {
                        string next = copy[i];
                        TryGetChange(next, -1, out MutableJsonChange change);

                        if (change.IsDescendant(current))
                        {
                            list.Remove(next);
                        }
                        else
                        {
                            current = next;
                        }
                    }
                }

                return list;
            }

            internal bool WasRemoved(string path, int highWaterMark)
            {
                if (_changes == null)
                {
                    return false;
                }

                for (int i = _changes!.Count - 1; i > highWaterMark; i--)
                {
                    MutableJsonChange c = _changes[i];
                    if (c.Path == path &&
                        c.ChangeKind == MutableJsonChangeKind.PropertyRemoval)
                    {
                        return true;
                    }
                }

                return false;
            }

            internal static string PushIndex(string path, int index)
            {
                return PushProperty(path, $"{index}");
            }

            internal static string PopIndex(string path)
            {
                return PopProperty(path);
            }

            internal static string PushProperty(string path, string value)
            {
                if (path.Length == 0)
                {
                    return value;
                }

                return string.Concat(path, Delimiter, value);
            }

            internal static void PushProperty(Span<char> path, ref int pathLength, ReadOnlySpan<char> value, int valueLength)
            {
                // Validate that path is large enough to write value into
                Debug.Assert(path.Length - pathLength >= valueLength);

                if (pathLength == 0)
                {
                    value.Slice(0, valueLength).CopyTo(path);
                    pathLength = valueLength;
                    return;
                }

                path[pathLength] = Delimiter;
                value.Slice(0, valueLength).CopyTo(path.Slice(pathLength + 1));
                pathLength += valueLength + 1;
            }

            internal static string PopProperty(string path)
            {
                int lastDelimiter = path.LastIndexOf(Delimiter);

                if (lastDelimiter == -1)
                {
                    return string.Empty;
                }

                return path.Substring(0, lastDelimiter);
            }

            internal static void PopProperty(Span<char> path, ref int pathLength)
            {
                int lastDelimiter = path.Slice(0, pathLength).LastIndexOf(Delimiter);
                pathLength = lastDelimiter == -1 ? 0 : lastDelimiter;
            }
        }
    }
}
