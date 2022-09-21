// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> The state of the command. This is ignored if submitted. </summary>
    public readonly partial struct CommandState : IEquatable<CommandState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CommandState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CommandState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnknownValue = "Unknown";
        private const string AcceptedValue = "Accepted";
        private const string RunningValue = "Running";
        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";

        /// <summary> Unknown. </summary>
        public static CommandState Unknown { get; } = new CommandState(UnknownValue);
        /// <summary> Accepted. </summary>
        public static CommandState Accepted { get; } = new CommandState(AcceptedValue);
        /// <summary> Running. </summary>
        public static CommandState Running { get; } = new CommandState(RunningValue);
        /// <summary> Succeeded. </summary>
        public static CommandState Succeeded { get; } = new CommandState(SucceededValue);
        /// <summary> Failed. </summary>
        public static CommandState Failed { get; } = new CommandState(FailedValue);
        /// <summary> Determines if two <see cref="CommandState"/> values are the same. </summary>
        public static bool operator ==(CommandState left, CommandState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CommandState"/> values are not the same. </summary>
        public static bool operator !=(CommandState left, CommandState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CommandState"/>. </summary>
        public static implicit operator CommandState(string value) => new CommandState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CommandState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CommandState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
