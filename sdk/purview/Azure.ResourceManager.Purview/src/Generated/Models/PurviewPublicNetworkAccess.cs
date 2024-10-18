// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Purview.Models
{
    /// <summary> Gets or sets the public network access. </summary>
    public readonly partial struct PurviewPublicNetworkAccess : IEquatable<PurviewPublicNetworkAccess>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PurviewPublicNetworkAccess"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PurviewPublicNetworkAccess(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotSpecifiedValue = "NotSpecified";
        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> NotSpecified. </summary>
        public static PurviewPublicNetworkAccess NotSpecified { get; } = new PurviewPublicNetworkAccess(NotSpecifiedValue);
        /// <summary> Enabled. </summary>
        public static PurviewPublicNetworkAccess Enabled { get; } = new PurviewPublicNetworkAccess(EnabledValue);
        /// <summary> Disabled. </summary>
        public static PurviewPublicNetworkAccess Disabled { get; } = new PurviewPublicNetworkAccess(DisabledValue);
        /// <summary> Determines if two <see cref="PurviewPublicNetworkAccess"/> values are the same. </summary>
        public static bool operator ==(PurviewPublicNetworkAccess left, PurviewPublicNetworkAccess right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PurviewPublicNetworkAccess"/> values are not the same. </summary>
        public static bool operator !=(PurviewPublicNetworkAccess left, PurviewPublicNetworkAccess right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="PurviewPublicNetworkAccess"/>. </summary>
        public static implicit operator PurviewPublicNetworkAccess(string value) => new PurviewPublicNetworkAccess(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PurviewPublicNetworkAccess other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PurviewPublicNetworkAccess other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
