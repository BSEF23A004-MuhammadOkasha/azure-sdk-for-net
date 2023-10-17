// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The MonitorDefinition. </summary>
    public partial class MonitorDefinition
    {
        /// <summary> Initializes a new instance of MonitorDefinition. </summary>
        /// <param name="computeConfiguration">
        /// [Required] The ARM resource ID of the compute resource to run the monitoring job on.
        /// Please note <see cref="MonitorComputeConfigurationBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MonitorServerlessSparkCompute"/>.
        /// </param>
        /// <param name="signals">
        /// [Required] The signals to monitor.
        /// Please note <see cref="MonitoringSignalBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="CustomMonitoringSignal"/>, <see cref="DataDriftMonitoringSignal"/>, <see cref="DataQualityMonitoringSignal"/>, <see cref="FeatureAttributionDriftMonitoringSignal"/>, <see cref="GenerationSafetyQualityMonitoringSignal"/>, <see cref="GenerationTokenStatisticsSignal"/>, <see cref="ModelPerformanceSignal"/> and <see cref="PredictionDriftMonitoringSignal"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="computeConfiguration"/> or <paramref name="signals"/> is null. </exception>
        public MonitorDefinition(MonitorComputeConfigurationBase computeConfiguration, IDictionary<string, MonitoringSignalBase> signals)
        {
            Argument.AssertNotNull(computeConfiguration, nameof(computeConfiguration));
            Argument.AssertNotNull(signals, nameof(signals));

            ComputeConfiguration = computeConfiguration;
            Signals = signals;
        }

        /// <summary> Initializes a new instance of MonitorDefinition. </summary>
        /// <param name="alertNotificationSetting">
        /// The monitor's notification settings.
        /// Please note <see cref="MonitoringAlertNotificationSettingsBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzMonMonitoringAlertNotificationSettings"/> and <see cref="EmailMonitoringAlertNotificationSettings"/>.
        /// </param>
        /// <param name="computeConfiguration">
        /// [Required] The ARM resource ID of the compute resource to run the monitoring job on.
        /// Please note <see cref="MonitorComputeConfigurationBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MonitorServerlessSparkCompute"/>.
        /// </param>
        /// <param name="monitoringTarget"> The ARM resource ID of either the model or deployment targeted by this monitor. </param>
        /// <param name="signals">
        /// [Required] The signals to monitor.
        /// Please note <see cref="MonitoringSignalBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="CustomMonitoringSignal"/>, <see cref="DataDriftMonitoringSignal"/>, <see cref="DataQualityMonitoringSignal"/>, <see cref="FeatureAttributionDriftMonitoringSignal"/>, <see cref="GenerationSafetyQualityMonitoringSignal"/>, <see cref="GenerationTokenStatisticsSignal"/>, <see cref="ModelPerformanceSignal"/> and <see cref="PredictionDriftMonitoringSignal"/>.
        /// </param>
        internal MonitorDefinition(MonitoringAlertNotificationSettingsBase alertNotificationSetting, MonitorComputeConfigurationBase computeConfiguration, MonitoringTarget monitoringTarget, IDictionary<string, MonitoringSignalBase> signals)
        {
            AlertNotificationSetting = alertNotificationSetting;
            ComputeConfiguration = computeConfiguration;
            MonitoringTarget = monitoringTarget;
            Signals = signals;
        }

        /// <summary>
        /// The monitor's notification settings.
        /// Please note <see cref="MonitoringAlertNotificationSettingsBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzMonMonitoringAlertNotificationSettings"/> and <see cref="EmailMonitoringAlertNotificationSettings"/>.
        /// </summary>
        public MonitoringAlertNotificationSettingsBase AlertNotificationSetting { get; set; }
        /// <summary>
        /// [Required] The ARM resource ID of the compute resource to run the monitoring job on.
        /// Please note <see cref="MonitorComputeConfigurationBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MonitorServerlessSparkCompute"/>.
        /// </summary>
        public MonitorComputeConfigurationBase ComputeConfiguration { get; set; }
        /// <summary> The ARM resource ID of either the model or deployment targeted by this monitor. </summary>
        public MonitoringTarget MonitoringTarget { get; set; }
        /// <summary>
        /// [Required] The signals to monitor.
        /// Please note <see cref="MonitoringSignalBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="CustomMonitoringSignal"/>, <see cref="DataDriftMonitoringSignal"/>, <see cref="DataQualityMonitoringSignal"/>, <see cref="FeatureAttributionDriftMonitoringSignal"/>, <see cref="GenerationSafetyQualityMonitoringSignal"/>, <see cref="GenerationTokenStatisticsSignal"/>, <see cref="ModelPerformanceSignal"/> and <see cref="PredictionDriftMonitoringSignal"/>.
        /// </summary>
        public IDictionary<string, MonitoringSignalBase> Signals { get; }
    }
}
