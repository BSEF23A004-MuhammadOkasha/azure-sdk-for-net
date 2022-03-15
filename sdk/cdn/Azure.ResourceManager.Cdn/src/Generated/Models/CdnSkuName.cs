// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Name of the pricing tier. </summary>
    public readonly partial struct CdnSkuName : IEquatable<CdnSkuName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CdnSkuName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CdnSkuName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string StandardVerizonValue = "Standard_Verizon";
        private const string PremiumVerizonValue = "Premium_Verizon";
        private const string CustomVerizonValue = "Custom_Verizon";
        private const string StandardAkamaiValue = "Standard_Akamai";
        private const string StandardChinaCdnValue = "Standard_ChinaCdn";
        private const string StandardMicrosoftValue = "Standard_Microsoft";
        private const string PremiumChinaCdnValue = "Premium_ChinaCdn";
        private const string StandardAzureFrontDoorValue = "Standard_AzureFrontDoor";
        private const string PremiumAzureFrontDoorValue = "Premium_AzureFrontDoor";
        private const string Standard955BandWidthChinaCdnValue = "Standard_955BandWidth_ChinaCdn";
        private const string StandardAvgBandWidthChinaCdnValue = "Standard_AvgBandWidth_ChinaCdn";
        private const string StandardPlusChinaCdnValue = "StandardPlus_ChinaCdn";
        private const string StandardPlus955BandWidthChinaCdnValue = "StandardPlus_955BandWidth_ChinaCdn";
        private const string StandardPlusAvgBandWidthChinaCdnValue = "StandardPlus_AvgBandWidth_ChinaCdn";

        /// <summary> Standard_Verizon. </summary>
        public static CdnSkuName StandardVerizon { get; } = new CdnSkuName(StandardVerizonValue);
        /// <summary> Premium_Verizon. </summary>
        public static CdnSkuName PremiumVerizon { get; } = new CdnSkuName(PremiumVerizonValue);
        /// <summary> Custom_Verizon. </summary>
        public static CdnSkuName CustomVerizon { get; } = new CdnSkuName(CustomVerizonValue);
        /// <summary> Standard_Akamai. </summary>
        public static CdnSkuName StandardAkamai { get; } = new CdnSkuName(StandardAkamaiValue);
        /// <summary> Standard_ChinaCdn. </summary>
        public static CdnSkuName StandardChinaCdn { get; } = new CdnSkuName(StandardChinaCdnValue);
        /// <summary> Standard_Microsoft. </summary>
        public static CdnSkuName StandardMicrosoft { get; } = new CdnSkuName(StandardMicrosoftValue);
        /// <summary> Premium_ChinaCdn. </summary>
        public static CdnSkuName PremiumChinaCdn { get; } = new CdnSkuName(PremiumChinaCdnValue);
        /// <summary> Standard_AzureFrontDoor. </summary>
        public static CdnSkuName StandardAzureFrontDoor { get; } = new CdnSkuName(StandardAzureFrontDoorValue);
        /// <summary> Premium_AzureFrontDoor. </summary>
        public static CdnSkuName PremiumAzureFrontDoor { get; } = new CdnSkuName(PremiumAzureFrontDoorValue);
        /// <summary> Standard_955BandWidth_ChinaCdn. </summary>
        public static CdnSkuName Standard955BandWidthChinaCdn { get; } = new CdnSkuName(Standard955BandWidthChinaCdnValue);
        /// <summary> Standard_AvgBandWidth_ChinaCdn. </summary>
        public static CdnSkuName StandardAvgBandWidthChinaCdn { get; } = new CdnSkuName(StandardAvgBandWidthChinaCdnValue);
        /// <summary> StandardPlus_ChinaCdn. </summary>
        public static CdnSkuName StandardPlusChinaCdn { get; } = new CdnSkuName(StandardPlusChinaCdnValue);
        /// <summary> StandardPlus_955BandWidth_ChinaCdn. </summary>
        public static CdnSkuName StandardPlus955BandWidthChinaCdn { get; } = new CdnSkuName(StandardPlus955BandWidthChinaCdnValue);
        /// <summary> StandardPlus_AvgBandWidth_ChinaCdn. </summary>
        public static CdnSkuName StandardPlusAvgBandWidthChinaCdn { get; } = new CdnSkuName(StandardPlusAvgBandWidthChinaCdnValue);
        /// <summary> Determines if two <see cref="CdnSkuName"/> values are the same. </summary>
        public static bool operator ==(CdnSkuName left, CdnSkuName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CdnSkuName"/> values are not the same. </summary>
        public static bool operator !=(CdnSkuName left, CdnSkuName right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CdnSkuName"/>. </summary>
        public static implicit operator CdnSkuName(string value) => new CdnSkuName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CdnSkuName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CdnSkuName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
