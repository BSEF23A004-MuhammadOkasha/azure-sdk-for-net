// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> NumberGreaterThanOrEquals Advanced Filter. </summary>
    public partial class NumberGreaterThanOrEqualsAdvancedFilter : AdvancedFilter
    {
        /// <summary> Initializes a new instance of NumberGreaterThanOrEqualsAdvancedFilter. </summary>
        public NumberGreaterThanOrEqualsAdvancedFilter()
        {
            OperatorType = AdvancedFilterOperatorType.NumberGreaterThanOrEquals;
        }

        /// <summary> Initializes a new instance of NumberGreaterThanOrEqualsAdvancedFilter. </summary>
        /// <param name="operatorType"> The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others. </param>
        /// <param name="key"> The field/property in the event based on which you want to filter. </param>
        /// <param name="value"> The filter value. </param>
        internal NumberGreaterThanOrEqualsAdvancedFilter(AdvancedFilterOperatorType operatorType, string key, double? value) : base(operatorType, key)
        {
            Value = value;
            OperatorType = operatorType;
        }

        /// <summary> The filter value. </summary>
        public double? Value { get; set; }
    }
}
