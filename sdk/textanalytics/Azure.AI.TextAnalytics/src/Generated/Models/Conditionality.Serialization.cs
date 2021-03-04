// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.TextAnalytics
{
    internal static partial class ConditionalityExtensions
    {
        public static string ToSerialString(this EntityConditionality value) => value switch
        {
            EntityConditionality.Hypothetical => "Hypothetical",
            EntityConditionality.Conditional => "Conditional",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown Conditionality value.")
        };

        public static EntityConditionality ToConditionality(this string value)
        {
            if (string.Equals(value, "Hypothetical", StringComparison.InvariantCultureIgnoreCase)) return EntityConditionality.Hypothetical;
            if (string.Equals(value, "Conditional", StringComparison.InvariantCultureIgnoreCase)) return EntityConditionality.Conditional;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown Conditionality value.");
        }
    }
}
