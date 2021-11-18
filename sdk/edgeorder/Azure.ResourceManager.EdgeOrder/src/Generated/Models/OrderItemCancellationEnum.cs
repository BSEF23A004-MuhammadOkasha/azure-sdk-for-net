// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    /// <summary> Describes whether the order item is cancellable or not. </summary>
    public readonly partial struct OrderItemCancellationEnum : IEquatable<OrderItemCancellationEnum>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="OrderItemCancellationEnum"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public OrderItemCancellationEnum(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CancellableValue = "Cancellable";
        private const string CancellableWithFeeValue = "CancellableWithFee";
        private const string NotCancellableValue = "NotCancellable";

        /// <summary> Order item can be cancelled without fee. </summary>
        public static OrderItemCancellationEnum Cancellable { get; } = new OrderItemCancellationEnum(CancellableValue);
        /// <summary> Order item can be cancelled with fee. </summary>
        public static OrderItemCancellationEnum CancellableWithFee { get; } = new OrderItemCancellationEnum(CancellableWithFeeValue);
        /// <summary> Order item not cancellable. </summary>
        public static OrderItemCancellationEnum NotCancellable { get; } = new OrderItemCancellationEnum(NotCancellableValue);
        /// <summary> Determines if two <see cref="OrderItemCancellationEnum"/> values are the same. </summary>
        public static bool operator ==(OrderItemCancellationEnum left, OrderItemCancellationEnum right) => left.Equals(right);
        /// <summary> Determines if two <see cref="OrderItemCancellationEnum"/> values are not the same. </summary>
        public static bool operator !=(OrderItemCancellationEnum left, OrderItemCancellationEnum right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="OrderItemCancellationEnum"/>. </summary>
        public static implicit operator OrderItemCancellationEnum(string value) => new OrderItemCancellationEnum(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is OrderItemCancellationEnum other && Equals(other);
        /// <inheritdoc />
        public bool Equals(OrderItemCancellationEnum other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
