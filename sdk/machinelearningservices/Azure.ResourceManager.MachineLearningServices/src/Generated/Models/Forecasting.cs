// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> Forecasting task in AutoML Table vertical. </summary>
    public partial class Forecasting : AutoMLVertical
    {
        /// <summary> Initializes a new instance of Forecasting. </summary>
        public Forecasting()
        {
            AllowedModels = new ChangeTrackingList<ForecastingModels>();
            BlockedModels = new ChangeTrackingList<ForecastingModels>();
            TaskType = TaskType.Forecasting;
        }

        /// <summary> Initializes a new instance of Forecasting. </summary>
        /// <param name="logVerbosity"> Log verbosity for the job. </param>
        /// <param name="taskType"> Task type for AutoMLJob. </param>
        /// <param name="allowedModels"> Allowed models for forecasting task. </param>
        /// <param name="blockedModels"> Blocked models for forecasting task. </param>
        /// <param name="forecastingSettings"> Forecasting task specific inputs. </param>
        /// <param name="primaryMetric"> Primary metric for forecasting task. </param>
        /// <param name="dataSettings"> Data inputs for AutoMLJob. </param>
        /// <param name="featurizationSettings"> Featurization inputs needed for AutoML job. </param>
        /// <param name="limitSettings"> Execution constraints for AutoMLJob. </param>
        /// <param name="trainingSettings"> Inputs for training phase for an AutoML Job. </param>
        internal Forecasting(LogVerbosity? logVerbosity, TaskType taskType, IList<ForecastingModels> allowedModels, IList<ForecastingModels> blockedModels, ForecastingSettings forecastingSettings, ForecastingPrimaryMetrics? primaryMetric, TableVerticalDataSettings dataSettings, TableVerticalFeaturizationSettings featurizationSettings, TableVerticalLimitSettings limitSettings, TrainingSettings trainingSettings) : base(logVerbosity, taskType)
        {
            AllowedModels = allowedModels;
            BlockedModels = blockedModels;
            ForecastingSettings = forecastingSettings;
            PrimaryMetric = primaryMetric;
            DataSettings = dataSettings;
            FeaturizationSettings = featurizationSettings;
            LimitSettings = limitSettings;
            TrainingSettings = trainingSettings;
            TaskType = taskType;
        }

        /// <summary> Allowed models for forecasting task. </summary>
        public IList<ForecastingModels> AllowedModels { get; set; }
        /// <summary> Blocked models for forecasting task. </summary>
        public IList<ForecastingModels> BlockedModels { get; set; }
        /// <summary> Forecasting task specific inputs. </summary>
        public ForecastingSettings ForecastingSettings { get; set; }
        /// <summary> Primary metric for forecasting task. </summary>
        public ForecastingPrimaryMetrics? PrimaryMetric { get; set; }
        /// <summary> Data inputs for AutoMLJob. </summary>
        public TableVerticalDataSettings DataSettings { get; set; }
        /// <summary> Featurization inputs needed for AutoML job. </summary>
        public TableVerticalFeaturizationSettings FeaturizationSettings { get; set; }
        /// <summary> Execution constraints for AutoMLJob. </summary>
        public TableVerticalLimitSettings LimitSettings { get; set; }
        /// <summary> Inputs for training phase for an AutoML Job. </summary>
        public TrainingSettings TrainingSettings { get; set; }
    }
}
