// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> Target lags rolling window determined automatically. </summary>
    internal partial class AutoTargetRollingWindowSize : TargetRollingWindowSize
    {
        /// <summary> Initializes a new instance of AutoTargetRollingWindowSize. </summary>
        public AutoTargetRollingWindowSize()
        {
            Mode = TargetRollingWindowSizeMode.Auto;
        }

        /// <summary> Initializes a new instance of AutoTargetRollingWindowSize. </summary>
        /// <param name="mode"> TargetRollingWindowSiz detection mode. </param>
        internal AutoTargetRollingWindowSize(TargetRollingWindowSizeMode mode) : base(mode)
        {
            Mode = mode;
        }
    }
}
