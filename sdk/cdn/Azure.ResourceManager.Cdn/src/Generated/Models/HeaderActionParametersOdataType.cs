// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> The HeaderActionParametersOdataType. </summary>
    public readonly partial struct HeaderActionParametersOdataType : IEquatable<HeaderActionParametersOdataType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="HeaderActionParametersOdataType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public HeaderActionParametersOdataType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MicrosoftAzureCdnModelsDeliveryRuleHeaderActionParametersValue = "#Microsoft.Azure.Cdn.Models.DeliveryRuleHeaderActionParameters";

        /// <summary> #Microsoft.Azure.Cdn.Models.DeliveryRuleHeaderActionParameters. </summary>
        public static HeaderActionParametersOdataType MicrosoftAzureCdnModelsDeliveryRuleHeaderActionParameters { get; } = new HeaderActionParametersOdataType(MicrosoftAzureCdnModelsDeliveryRuleHeaderActionParametersValue);
        /// <summary> Determines if two <see cref="HeaderActionParametersOdataType"/> values are the same. </summary>
        public static bool operator ==(HeaderActionParametersOdataType left, HeaderActionParametersOdataType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="HeaderActionParametersOdataType"/> values are not the same. </summary>
        public static bool operator !=(HeaderActionParametersOdataType left, HeaderActionParametersOdataType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="HeaderActionParametersOdataType"/>. </summary>
        public static implicit operator HeaderActionParametersOdataType(string value) => new HeaderActionParametersOdataType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is HeaderActionParametersOdataType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(HeaderActionParametersOdataType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
