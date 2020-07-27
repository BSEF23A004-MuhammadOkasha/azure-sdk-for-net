// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Data.Tables.Models
{
    /// <summary> The OdataMetadataFormat. </summary>
    internal readonly partial struct OdataMetadataFormat : IEquatable<OdataMetadataFormat>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="OdataMetadataFormat"/> values are the same. </summary>
        public OdataMetadataFormat(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ApplicationJsonOdataNometadataValue = "application/json;odata=nometadata";
        private const string ApplicationJsonOdataMinimalmetadataValue = "application/json;odata=minimalmetadata";
        private const string ApplicationJsonOdataFullmetadataValue = "application/json;odata=fullmetadata";

        /// <summary> application/json;odata=nometadata. </summary>
        public static OdataMetadataFormat ApplicationJsonOdataNometadata { get; } = new OdataMetadataFormat(ApplicationJsonOdataNometadataValue);
        /// <summary> application/json;odata=minimalmetadata. </summary>
        public static OdataMetadataFormat ApplicationJsonOdataMinimalmetadata { get; } = new OdataMetadataFormat(ApplicationJsonOdataMinimalmetadataValue);
        /// <summary> application/json;odata=fullmetadata. </summary>
        public static OdataMetadataFormat ApplicationJsonOdataFullmetadata { get; } = new OdataMetadataFormat(ApplicationJsonOdataFullmetadataValue);
        /// <summary> Determines if two <see cref="OdataMetadataFormat"/> values are the same. </summary>
        public static bool operator ==(OdataMetadataFormat left, OdataMetadataFormat right) => left.Equals(right);
        /// <summary> Determines if two <see cref="OdataMetadataFormat"/> values are not the same. </summary>
        public static bool operator !=(OdataMetadataFormat left, OdataMetadataFormat right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="OdataMetadataFormat"/>. </summary>
        public static implicit operator OdataMetadataFormat(string value) => new OdataMetadataFormat(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is OdataMetadataFormat other && Equals(other);
        /// <inheritdoc />
        public bool Equals(OdataMetadataFormat other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
