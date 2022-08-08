// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    /// <summary> The SKU of the GPU resource. </summary>
    public readonly partial struct ContainerGpuSku : IEquatable<ContainerGpuSku>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ContainerGpuSku"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ContainerGpuSku(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string K80Value = "K80";
        private const string P100Value = "P100";
        private const string V100Value = "V100";

        /// <summary> K80. </summary>
        public static ContainerGpuSku K80 { get; } = new ContainerGpuSku(K80Value);
        /// <summary> P100. </summary>
        public static ContainerGpuSku P100 { get; } = new ContainerGpuSku(P100Value);
        /// <summary> V100. </summary>
        public static ContainerGpuSku V100 { get; } = new ContainerGpuSku(V100Value);
        /// <summary> Determines if two <see cref="ContainerGpuSku"/> values are the same. </summary>
        public static bool operator ==(ContainerGpuSku left, ContainerGpuSku right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ContainerGpuSku"/> values are not the same. </summary>
        public static bool operator !=(ContainerGpuSku left, ContainerGpuSku right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ContainerGpuSku"/>. </summary>
        public static implicit operator ContainerGpuSku(string value) => new ContainerGpuSku(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ContainerGpuSku other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ContainerGpuSku other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
