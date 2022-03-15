// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> Enum for setting log verbosity. </summary>
    public readonly partial struct LogVerbosity : IEquatable<LogVerbosity>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="LogVerbosity"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public LogVerbosity(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotSetValue = "NotSet";
        private const string DebugValue = "Debug";
        private const string InfoValue = "Info";
        private const string WarningValue = "Warning";
        private const string ErrorValue = "Error";
        private const string CriticalValue = "Critical";

        /// <summary> No logs emmitted. </summary>
        public static LogVerbosity NotSet { get; } = new LogVerbosity(NotSetValue);
        /// <summary> Debug and above log statements logged. </summary>
        public static LogVerbosity Debug { get; } = new LogVerbosity(DebugValue);
        /// <summary> Info and above log statements logged. </summary>
        public static LogVerbosity Info { get; } = new LogVerbosity(InfoValue);
        /// <summary> Warning and above log statements logged. </summary>
        public static LogVerbosity Warning { get; } = new LogVerbosity(WarningValue);
        /// <summary> Error and above log statements logged. </summary>
        public static LogVerbosity Error { get; } = new LogVerbosity(ErrorValue);
        /// <summary> Only critical statements logged. </summary>
        public static LogVerbosity Critical { get; } = new LogVerbosity(CriticalValue);
        /// <summary> Determines if two <see cref="LogVerbosity"/> values are the same. </summary>
        public static bool operator ==(LogVerbosity left, LogVerbosity right) => left.Equals(right);
        /// <summary> Determines if two <see cref="LogVerbosity"/> values are not the same. </summary>
        public static bool operator !=(LogVerbosity left, LogVerbosity right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="LogVerbosity"/>. </summary>
        public static implicit operator LogVerbosity(string value) => new LogVerbosity(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is LogVerbosity other && Equals(other);
        /// <inheritdoc />
        public bool Equals(LogVerbosity other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
