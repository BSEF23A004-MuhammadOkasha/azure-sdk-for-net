// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Consumption.Models
{
    /// <summary> The forecasted cost which is being tracked for a budget. </summary>
    public partial class BudgetForecastSpend
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="BudgetForecastSpend"/>. </summary>
        internal BudgetForecastSpend()
        {
        }

        /// <summary> Initializes a new instance of <see cref="BudgetForecastSpend"/>. </summary>
        /// <param name="amount"> The forecasted cost for the total time period which is being tracked by the budget. This value is only provided if the budget contains a forecast alert type. </param>
        /// <param name="unit"> The unit of measure for the budget amount. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal BudgetForecastSpend(decimal? amount, string unit, Dictionary<string, BinaryData> rawData)
        {
            Amount = amount;
            Unit = unit;
            _rawData = rawData;
        }

        /// <summary> The forecasted cost for the total time period which is being tracked by the budget. This value is only provided if the budget contains a forecast alert type. </summary>
        public decimal? Amount { get; }
        /// <summary> The unit of measure for the budget amount. </summary>
        public string Unit { get; }
    }
}
