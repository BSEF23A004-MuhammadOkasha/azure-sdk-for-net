// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Consumption.Models
{
    /// <summary> Details of the estimated savings. </summary>
    public partial class ConsumptionSavingsProperties
    {
        /// <summary> Initializes a new instance of ConsumptionSavingsProperties. </summary>
        internal ConsumptionSavingsProperties()
        {
            CalculatedSavings = new ChangeTrackingList<ConsumptionCalculatedSavingsProperties>();
        }

        /// <summary> Initializes a new instance of ConsumptionSavingsProperties. </summary>
        /// <param name="calculatedSavings"> List of calculated savings. </param>
        /// <param name="lookBackPeriod"> Number of days of usage to look back used for computing the recommendation. </param>
        /// <param name="recommendedQuantity"> Number of recommended units of the resource. </param>
        /// <param name="reservationOrderTerm"> Term period of the reservation, ex: P1Y or P3Y. </param>
        /// <param name="savingsType"> Type of savings, ex: instance. </param>
        /// <param name="unitOfMeasure"> Measurement unit ex: hour etc. </param>
        internal ConsumptionSavingsProperties(IReadOnlyList<ConsumptionCalculatedSavingsProperties> calculatedSavings, int? lookBackPeriod, float? recommendedQuantity, string reservationOrderTerm, string savingsType, string unitOfMeasure)
        {
            CalculatedSavings = calculatedSavings;
            LookBackPeriod = lookBackPeriod;
            RecommendedQuantity = recommendedQuantity;
            ReservationOrderTerm = reservationOrderTerm;
            SavingsType = savingsType;
            UnitOfMeasure = unitOfMeasure;
        }

        /// <summary> List of calculated savings. </summary>
        public IReadOnlyList<ConsumptionCalculatedSavingsProperties> CalculatedSavings { get; }
        /// <summary> Number of days of usage to look back used for computing the recommendation. </summary>
        public int? LookBackPeriod { get; }
        /// <summary> Number of recommended units of the resource. </summary>
        public float? RecommendedQuantity { get; }
        /// <summary> Term period of the reservation, ex: P1Y or P3Y. </summary>
        public string ReservationOrderTerm { get; }
        /// <summary> Type of savings, ex: instance. </summary>
        public string SavingsType { get; }
        /// <summary> Measurement unit ex: hour etc. </summary>
        public string UnitOfMeasure { get; }
    }
}
