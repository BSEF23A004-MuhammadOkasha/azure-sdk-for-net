// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.HybridCompute.Models
{
    /// <summary> The product type of the license. </summary>
    public readonly partial struct LicenseProfileProductType : IEquatable<LicenseProfileProductType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="LicenseProfileProductType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public LicenseProfileProductType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string WindowsServerValue = "WindowsServer";
        private const string WindowsIotEnterpriseValue = "WindowsIoTEnterprise";

        /// <summary> WindowsServer. </summary>
        public static LicenseProfileProductType WindowsServer { get; } = new LicenseProfileProductType(WindowsServerValue);
        /// <summary> WindowsIoTEnterprise. </summary>
        public static LicenseProfileProductType WindowsIotEnterprise { get; } = new LicenseProfileProductType(WindowsIotEnterpriseValue);
        /// <summary> Determines if two <see cref="LicenseProfileProductType"/> values are the same. </summary>
        public static bool operator ==(LicenseProfileProductType left, LicenseProfileProductType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="LicenseProfileProductType"/> values are not the same. </summary>
        public static bool operator !=(LicenseProfileProductType left, LicenseProfileProductType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="LicenseProfileProductType"/>. </summary>
        public static implicit operator LicenseProfileProductType(string value) => new LicenseProfileProductType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is LicenseProfileProductType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(LicenseProfileProductType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
