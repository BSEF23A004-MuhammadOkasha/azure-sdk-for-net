// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The IncidentProperty. </summary>
    internal partial class IncidentProperty
    {
        /// <summary> Initializes a new instance of IncidentProperty. </summary>
        /// <param name="maxSeverity"> max severity of latest anomalies in the incident. </param>
        internal IncidentProperty(AnomalySeverity maxSeverity)
        {
            MaxSeverity = maxSeverity;
        }

        /// <summary> Initializes a new instance of IncidentProperty. </summary>
        /// <param name="maxSeverity"> max severity of latest anomalies in the incident. </param>
        /// <param name="incidentStatus">
        /// incident status
        /// 
        /// 
        /// 
        /// only return for alerting incident result.
        /// </param>
        internal IncidentProperty(AnomalySeverity maxSeverity, IncidentStatus? incidentStatus)
        {
            MaxSeverity = maxSeverity;
            IncidentStatus = incidentStatus;
        }

        /// <summary> max severity of latest anomalies in the incident. </summary>
        public AnomalySeverity MaxSeverity { get; }
        /// <summary>
        /// incident status
        /// 
        /// 
        /// 
        /// only return for alerting incident result.
        /// </summary>
        public IncidentStatus? IncidentStatus { get; }
    }
}
