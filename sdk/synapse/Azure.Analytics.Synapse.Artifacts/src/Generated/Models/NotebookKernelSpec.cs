// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Kernel information. </summary>
    public partial class NotebookKernelSpec : IDictionary<string, object>
    {
        /// <summary> Initializes a new instance of NotebookKernelSpec. </summary>
        /// <param name="name"> Name of the kernel specification. </param>
        /// <param name="displayName"> Name to display in UI. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="displayName"/> is null. </exception>
        public NotebookKernelSpec(string name, string displayName)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (displayName == null)
            {
                throw new ArgumentNullException(nameof(displayName));
            }

            Name = name;
            DisplayName = displayName;
            AdditionalProperties = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of NotebookKernelSpec. </summary>
        /// <param name="name"> Name of the kernel specification. </param>
        /// <param name="displayName"> Name to display in UI. </param>
        /// <param name="additionalProperties"> . </param>
        internal NotebookKernelSpec(string name, string displayName, IDictionary<string, object> additionalProperties)
        {
            Name = name;
            DisplayName = displayName;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> Name of the kernel specification. </summary>
        public string Name { get; set; }
        /// <summary> Name to display in UI. </summary>
        public string DisplayName { get; set; }
        internal IDictionary<string, object> AdditionalProperties { get; }
        /// <inheritdoc />
        public IEnumerator<KeyValuePair<string, object>> GetEnumerator() => AdditionalProperties.GetEnumerator();
        /// <inheritdoc />
        IEnumerator IEnumerable.GetEnumerator() => AdditionalProperties.GetEnumerator();
        /// <inheritdoc />
        public bool TryGetValue(string key, out object value) => AdditionalProperties.TryGetValue(key, out value);
        /// <inheritdoc />
        public bool ContainsKey(string key) => AdditionalProperties.ContainsKey(key);
        /// <inheritdoc />
        public ICollection<string> Keys => AdditionalProperties.Keys;
        /// <inheritdoc />
        public ICollection<object> Values => AdditionalProperties.Values;
        /// <inheritdoc />
        int ICollection<KeyValuePair<string, object>>.Count => AdditionalProperties.Count;
        /// <inheritdoc />
        public void Add(string key, object value) => AdditionalProperties.Add(key, value);
        /// <inheritdoc />
        public bool Remove(string key) => AdditionalProperties.Remove(key);
        /// <inheritdoc />
        bool ICollection<KeyValuePair<string, object>>.IsReadOnly => AdditionalProperties.IsReadOnly;
        /// <inheritdoc />
        void ICollection<KeyValuePair<string, object>>.Add(KeyValuePair<string, object> value) => AdditionalProperties.Add(value);
        /// <inheritdoc />
        bool ICollection<KeyValuePair<string, object>>.Remove(KeyValuePair<string, object> value) => AdditionalProperties.Remove(value);
        /// <inheritdoc />
        bool ICollection<KeyValuePair<string, object>>.Contains(KeyValuePair<string, object> value) => AdditionalProperties.Contains(value);
        /// <inheritdoc />
        void ICollection<KeyValuePair<string, object>>.CopyTo(KeyValuePair<string, object>[] destination, int offset) => AdditionalProperties.CopyTo(destination, offset);
        /// <inheritdoc />
        void ICollection<KeyValuePair<string, object>>.Clear() => AdditionalProperties.Clear();
        /// <inheritdoc />
        public object this[string key]
        {
            get => AdditionalProperties[key];
            set => AdditionalProperties[key] = value;
        }
    }
}
