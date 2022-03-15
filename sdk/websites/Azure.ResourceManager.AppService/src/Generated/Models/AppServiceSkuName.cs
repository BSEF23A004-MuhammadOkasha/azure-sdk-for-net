// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> The AppServiceSkuName. </summary>
    public readonly partial struct AppServiceSkuName : IEquatable<AppServiceSkuName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AppServiceSkuName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AppServiceSkuName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string FreeValue = "Free";
        private const string SharedValue = "Shared";
        private const string BasicValue = "Basic";
        private const string StandardValue = "Standard";
        private const string PremiumValue = "Premium";
        private const string DynamicValue = "Dynamic";
        private const string IsolatedValue = "Isolated";
        private const string IsolatedV2Value = "IsolatedV2";
        private const string PremiumV2Value = "PremiumV2";
        private const string PremiumV3Value = "PremiumV3";
        private const string PremiumContainerValue = "PremiumContainer";
        private const string ElasticPremiumValue = "ElasticPremium";
        private const string ElasticIsolatedValue = "ElasticIsolated";

        /// <summary> Free. </summary>
        public static AppServiceSkuName Free { get; } = new AppServiceSkuName(FreeValue);
        /// <summary> Shared. </summary>
        public static AppServiceSkuName Shared { get; } = new AppServiceSkuName(SharedValue);
        /// <summary> Basic. </summary>
        public static AppServiceSkuName Basic { get; } = new AppServiceSkuName(BasicValue);
        /// <summary> Standard. </summary>
        public static AppServiceSkuName Standard { get; } = new AppServiceSkuName(StandardValue);
        /// <summary> Premium. </summary>
        public static AppServiceSkuName Premium { get; } = new AppServiceSkuName(PremiumValue);
        /// <summary> Dynamic. </summary>
        public static AppServiceSkuName Dynamic { get; } = new AppServiceSkuName(DynamicValue);
        /// <summary> Isolated. </summary>
        public static AppServiceSkuName Isolated { get; } = new AppServiceSkuName(IsolatedValue);
        /// <summary> IsolatedV2. </summary>
        public static AppServiceSkuName IsolatedV2 { get; } = new AppServiceSkuName(IsolatedV2Value);
        /// <summary> PremiumV2. </summary>
        public static AppServiceSkuName PremiumV2 { get; } = new AppServiceSkuName(PremiumV2Value);
        /// <summary> PremiumV3. </summary>
        public static AppServiceSkuName PremiumV3 { get; } = new AppServiceSkuName(PremiumV3Value);
        /// <summary> PremiumContainer. </summary>
        public static AppServiceSkuName PremiumContainer { get; } = new AppServiceSkuName(PremiumContainerValue);
        /// <summary> ElasticPremium. </summary>
        public static AppServiceSkuName ElasticPremium { get; } = new AppServiceSkuName(ElasticPremiumValue);
        /// <summary> ElasticIsolated. </summary>
        public static AppServiceSkuName ElasticIsolated { get; } = new AppServiceSkuName(ElasticIsolatedValue);
        /// <summary> Determines if two <see cref="AppServiceSkuName"/> values are the same. </summary>
        public static bool operator ==(AppServiceSkuName left, AppServiceSkuName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AppServiceSkuName"/> values are not the same. </summary>
        public static bool operator !=(AppServiceSkuName left, AppServiceSkuName right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AppServiceSkuName"/>. </summary>
        public static implicit operator AppServiceSkuName(string value) => new AppServiceSkuName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AppServiceSkuName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AppServiceSkuName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
