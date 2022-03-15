// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> Abstract class for AutoML tasks that use table dataset as input - such as Classification/Regression/Forecasting. </summary>
    internal partial class TableVertical
    {
        /// <summary> Initializes a new instance of TableVertical. </summary>
        public TableVertical()
        {
        }

        /// <summary> Initializes a new instance of TableVertical. </summary>
        /// <param name="dataSettings"> Data inputs for AutoMLJob. </param>
        /// <param name="featurizationSettings"> Featurization inputs needed for AutoML job. </param>
        /// <param name="limitSettings"> Execution constraints for AutoMLJob. </param>
        /// <param name="trainingSettings"> Inputs for training phase for an AutoML Job. </param>
        internal TableVertical(TableVerticalDataSettings dataSettings, TableVerticalFeaturizationSettings featurizationSettings, TableVerticalLimitSettings limitSettings, TrainingSettings trainingSettings)
        {
            DataSettings = dataSettings;
            FeaturizationSettings = featurizationSettings;
            LimitSettings = limitSettings;
            TrainingSettings = trainingSettings;
        }

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
