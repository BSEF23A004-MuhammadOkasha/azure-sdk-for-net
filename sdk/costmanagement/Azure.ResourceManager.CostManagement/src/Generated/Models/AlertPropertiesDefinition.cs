// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.CostManagement.Models
{
    /// <summary> defines the type of alert. </summary>
    public partial class AlertPropertiesDefinition
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AlertPropertiesDefinition"/>. </summary>
        public AlertPropertiesDefinition()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AlertPropertiesDefinition"/>. </summary>
        /// <param name="alertType"> type of alert. </param>
        /// <param name="category"> Alert category. </param>
        /// <param name="criteria"> Criteria that triggered alert. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AlertPropertiesDefinition(CostManagementAlertType? alertType, CostManagementAlertCategory? category, AlertCriterion? criteria, Dictionary<string, BinaryData> rawData)
        {
            AlertType = alertType;
            Category = category;
            Criteria = criteria;
            _rawData = rawData;
        }

        /// <summary> type of alert. </summary>
        public CostManagementAlertType? AlertType { get; set; }
        /// <summary> Alert category. </summary>
        public CostManagementAlertCategory? Category { get; set; }
        /// <summary> Criteria that triggered alert. </summary>
        public AlertCriterion? Criteria { get; set; }
    }
}
