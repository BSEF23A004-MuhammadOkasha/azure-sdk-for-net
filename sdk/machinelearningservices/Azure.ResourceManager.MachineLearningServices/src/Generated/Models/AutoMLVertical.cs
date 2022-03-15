// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary>
    /// AutoML vertical class.
    /// Base class for AutoML verticals - TableVertical/ImageVertical/NLPVertical
    /// </summary>
    public partial class AutoMLVertical
    {
        /// <summary> Initializes a new instance of AutoMLVertical. </summary>
        public AutoMLVertical()
        {
        }

        /// <summary> Initializes a new instance of AutoMLVertical. </summary>
        /// <param name="logVerbosity"> Log verbosity for the job. </param>
        /// <param name="taskType"> Task type for AutoMLJob. </param>
        internal AutoMLVertical(LogVerbosity? logVerbosity, TaskType taskType)
        {
            LogVerbosity = logVerbosity;
            TaskType = taskType;
        }

        /// <summary> Log verbosity for the job. </summary>
        public LogVerbosity? LogVerbosity { get; set; }
        /// <summary> Task type for AutoMLJob. </summary>
        internal TaskType TaskType { get; set; }
    }
}
