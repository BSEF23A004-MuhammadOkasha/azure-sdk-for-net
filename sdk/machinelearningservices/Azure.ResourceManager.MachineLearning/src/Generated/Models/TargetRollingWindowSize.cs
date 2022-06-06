// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// Forecasting target rolling window size.
    /// Please note <see cref="TargetRollingWindowSize"/> is the base class. In order to more specifically assign or retrieve the value of this property, the derived class is needed.
    /// The available derived classes include <see cref="AutoTargetRollingWindowSize"/>, <see cref="CustomTargetRollingWindowSize"/>.
    /// </summary>
    public partial class TargetRollingWindowSize
    {
        /// <summary> Initializes a new instance of TargetRollingWindowSize. </summary>
        public TargetRollingWindowSize()
        {
        }

        /// <summary> Initializes a new instance of TargetRollingWindowSize. </summary>
        /// <param name="mode"> [Required] TargetRollingWindowSiz detection mode. </param>
        internal TargetRollingWindowSize(TargetRollingWindowSizeMode mode)
        {
            Mode = mode;
        }

        /// <summary> [Required] TargetRollingWindowSiz detection mode. </summary>
        internal TargetRollingWindowSizeMode Mode { get; set; }
    }
}
