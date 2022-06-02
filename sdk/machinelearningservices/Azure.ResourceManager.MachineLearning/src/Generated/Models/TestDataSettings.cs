// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Test data inputs. </summary>
    public partial class TestDataSettings
    {
        /// <summary> Initializes a new instance of TestDataSettings. </summary>
        public TestDataSettings()
        {
        }

        /// <summary> Initializes a new instance of TestDataSettings. </summary>
        /// <param name="data"> Test data MLTable. </param>
        /// <param name="testDataSize">
        /// The fraction of test dataset that needs to be set aside for validation purpose.
        /// Values between (0.0 , 1.0)
        /// Applied when validation dataset is not provided.
        /// </param>
        internal TestDataSettings(MLTableJobInput data, double? testDataSize)
        {
            Data = data;
            TestDataSize = testDataSize;
        }

        /// <summary> Test data MLTable. </summary>
        public MLTableJobInput Data { get; set; }
        /// <summary>
        /// The fraction of test dataset that needs to be set aside for validation purpose.
        /// Values between (0.0 , 1.0)
        /// Applied when validation dataset is not provided.
        /// </summary>
        public double? TestDataSize { get; set; }
    }
}
