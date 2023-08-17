// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Hci.Models
{
    /// <summary> The HciVirtualMachineSize. </summary>
    public readonly partial struct HciVirtualMachineSize : IEquatable<HciVirtualMachineSize>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="HciVirtualMachineSize"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public HciVirtualMachineSize(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DefaultValue = "Default";
        private const string StandardA2V2Value = "Standard_A2_v2";
        private const string StandardA4V2Value = "Standard_A4_v2";
        private const string StandardD2SV3Value = "Standard_D2s_v3";
        private const string StandardD4SV3Value = "Standard_D4s_v3";
        private const string StandardD8SV3Value = "Standard_D8s_v3";
        private const string StandardD16SV3Value = "Standard_D16s_v3";
        private const string StandardD32SV3Value = "Standard_D32s_v3";
        private const string StandardDS2V2Value = "Standard_DS2_v2";
        private const string StandardDS3V2Value = "Standard_DS3_v2";
        private const string StandardDS4V2Value = "Standard_DS4_v2";
        private const string StandardDS5V2Value = "Standard_DS5_v2";
        private const string StandardDS13V2Value = "Standard_DS13_v2";
        private const string StandardK8SV1Value = "Standard_K8S_v1";
        private const string StandardK8S2V1Value = "Standard_K8S2_v1";
        private const string StandardK8S3V1Value = "Standard_K8S3_v1";
        private const string StandardK8S4V1Value = "Standard_K8S4_v1";
        private const string StandardNK6Value = "Standard_NK6";
        private const string StandardNK12Value = "Standard_NK12";
        private const string StandardNV6Value = "Standard_NV6";
        private const string StandardNV12Value = "Standard_NV12";
        private const string StandardK8S5V1Value = "Standard_K8S5_v1";
        private const string CustomValue = "Custom";

        /// <summary> Default. </summary>
        public static HciVirtualMachineSize Default { get; } = new HciVirtualMachineSize(DefaultValue);
        /// <summary> Standard_A2_v2. </summary>
        public static HciVirtualMachineSize StandardA2V2 { get; } = new HciVirtualMachineSize(StandardA2V2Value);
        /// <summary> Standard_A4_v2. </summary>
        public static HciVirtualMachineSize StandardA4V2 { get; } = new HciVirtualMachineSize(StandardA4V2Value);
        /// <summary> Standard_D2s_v3. </summary>
        public static HciVirtualMachineSize StandardD2SV3 { get; } = new HciVirtualMachineSize(StandardD2SV3Value);
        /// <summary> Standard_D4s_v3. </summary>
        public static HciVirtualMachineSize StandardD4SV3 { get; } = new HciVirtualMachineSize(StandardD4SV3Value);
        /// <summary> Standard_D8s_v3. </summary>
        public static HciVirtualMachineSize StandardD8SV3 { get; } = new HciVirtualMachineSize(StandardD8SV3Value);
        /// <summary> Standard_D16s_v3. </summary>
        public static HciVirtualMachineSize StandardD16SV3 { get; } = new HciVirtualMachineSize(StandardD16SV3Value);
        /// <summary> Standard_D32s_v3. </summary>
        public static HciVirtualMachineSize StandardD32SV3 { get; } = new HciVirtualMachineSize(StandardD32SV3Value);
        /// <summary> Standard_DS2_v2. </summary>
        public static HciVirtualMachineSize StandardDS2V2 { get; } = new HciVirtualMachineSize(StandardDS2V2Value);
        /// <summary> Standard_DS3_v2. </summary>
        public static HciVirtualMachineSize StandardDS3V2 { get; } = new HciVirtualMachineSize(StandardDS3V2Value);
        /// <summary> Standard_DS4_v2. </summary>
        public static HciVirtualMachineSize StandardDS4V2 { get; } = new HciVirtualMachineSize(StandardDS4V2Value);
        /// <summary> Standard_DS5_v2. </summary>
        public static HciVirtualMachineSize StandardDS5V2 { get; } = new HciVirtualMachineSize(StandardDS5V2Value);
        /// <summary> Standard_DS13_v2. </summary>
        public static HciVirtualMachineSize StandardDS13V2 { get; } = new HciVirtualMachineSize(StandardDS13V2Value);
        /// <summary> Standard_K8S_v1. </summary>
        public static HciVirtualMachineSize StandardK8SV1 { get; } = new HciVirtualMachineSize(StandardK8SV1Value);
        /// <summary> Standard_K8S2_v1. </summary>
        public static HciVirtualMachineSize StandardK8S2V1 { get; } = new HciVirtualMachineSize(StandardK8S2V1Value);
        /// <summary> Standard_K8S3_v1. </summary>
        public static HciVirtualMachineSize StandardK8S3V1 { get; } = new HciVirtualMachineSize(StandardK8S3V1Value);
        /// <summary> Standard_K8S4_v1. </summary>
        public static HciVirtualMachineSize StandardK8S4V1 { get; } = new HciVirtualMachineSize(StandardK8S4V1Value);
        /// <summary> Standard_NK6. </summary>
        public static HciVirtualMachineSize StandardNK6 { get; } = new HciVirtualMachineSize(StandardNK6Value);
        /// <summary> Standard_NK12. </summary>
        public static HciVirtualMachineSize StandardNK12 { get; } = new HciVirtualMachineSize(StandardNK12Value);
        /// <summary> Standard_NV6. </summary>
        public static HciVirtualMachineSize StandardNV6 { get; } = new HciVirtualMachineSize(StandardNV6Value);
        /// <summary> Standard_NV12. </summary>
        public static HciVirtualMachineSize StandardNV12 { get; } = new HciVirtualMachineSize(StandardNV12Value);
        /// <summary> Standard_K8S5_v1. </summary>
        public static HciVirtualMachineSize StandardK8S5V1 { get; } = new HciVirtualMachineSize(StandardK8S5V1Value);
        /// <summary> Custom. </summary>
        public static HciVirtualMachineSize Custom { get; } = new HciVirtualMachineSize(CustomValue);
        /// <summary> Determines if two <see cref="HciVirtualMachineSize"/> values are the same. </summary>
        public static bool operator ==(HciVirtualMachineSize left, HciVirtualMachineSize right) => left.Equals(right);
        /// <summary> Determines if two <see cref="HciVirtualMachineSize"/> values are not the same. </summary>
        public static bool operator !=(HciVirtualMachineSize left, HciVirtualMachineSize right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="HciVirtualMachineSize"/>. </summary>
        public static implicit operator HciVirtualMachineSize(string value) => new HciVirtualMachineSize(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is HciVirtualMachineSize other && Equals(other);
        /// <inheritdoc />
        public bool Equals(HciVirtualMachineSize other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
