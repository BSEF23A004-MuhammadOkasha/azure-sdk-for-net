// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> The Virtual Machine Scale Set priority. </summary>
    public readonly partial struct ScaleSetPriority : IEquatable<ScaleSetPriority>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ScaleSetPriority"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ScaleSetPriority(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SpotValue = "Spot";
        private const string RegularValue = "Regular";

        /// <summary> Spot priority VMs will be used. There is no SLA for spot nodes. See [spot on AKS](https://docs.microsoft.com/azure/aks/spot-node-pool) for more information. </summary>
        public static ScaleSetPriority Spot { get; } = new ScaleSetPriority(SpotValue);
        /// <summary> Regular VMs will be used. </summary>
        public static ScaleSetPriority Regular { get; } = new ScaleSetPriority(RegularValue);
        /// <summary> Determines if two <see cref="ScaleSetPriority"/> values are the same. </summary>
        public static bool operator ==(ScaleSetPriority left, ScaleSetPriority right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ScaleSetPriority"/> values are not the same. </summary>
        public static bool operator !=(ScaleSetPriority left, ScaleSetPriority right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ScaleSetPriority"/>. </summary>
        public static implicit operator ScaleSetPriority(string value) => new ScaleSetPriority(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ScaleSetPriority other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ScaleSetPriority other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
