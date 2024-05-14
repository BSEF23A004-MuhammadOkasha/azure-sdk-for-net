// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> Different support tiers for AKS managed clusters. </summary>
    public readonly partial struct KubernetesSupportPlan : IEquatable<KubernetesSupportPlan>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="KubernetesSupportPlan"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public KubernetesSupportPlan(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string KubernetesOfficialValue = "KubernetesOfficial";
        private const string AKSLongTermSupportValue = "AKSLongTermSupport";

        /// <summary> Support for the version is the same as for the open source Kubernetes offering. Official Kubernetes open source community support versions for 1 year after release. </summary>
        public static KubernetesSupportPlan KubernetesOfficial { get; } = new KubernetesSupportPlan(KubernetesOfficialValue);
        /// <summary> Support for the version extended past the KubernetesOfficial support of 1 year. AKS continues to patch CVEs for another 1 year, for a total of 2 years of support. </summary>
        public static KubernetesSupportPlan AKSLongTermSupport { get; } = new KubernetesSupportPlan(AKSLongTermSupportValue);
        /// <summary> Determines if two <see cref="KubernetesSupportPlan"/> values are the same. </summary>
        public static bool operator ==(KubernetesSupportPlan left, KubernetesSupportPlan right) => left.Equals(right);
        /// <summary> Determines if two <see cref="KubernetesSupportPlan"/> values are not the same. </summary>
        public static bool operator !=(KubernetesSupportPlan left, KubernetesSupportPlan right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="KubernetesSupportPlan"/>. </summary>
        public static implicit operator KubernetesSupportPlan(string value) => new KubernetesSupportPlan(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is KubernetesSupportPlan other && Equals(other);
        /// <inheritdoc />
        public bool Equals(KubernetesSupportPlan other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
