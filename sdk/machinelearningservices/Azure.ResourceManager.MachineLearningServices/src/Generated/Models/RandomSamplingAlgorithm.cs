// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> Defines a Sampling Algorithm that generates values randomly. </summary>
    public partial class RandomSamplingAlgorithm : SamplingAlgorithm
    {
        /// <summary> Initializes a new instance of RandomSamplingAlgorithm. </summary>
        public RandomSamplingAlgorithm()
        {
            SamplingAlgorithmType = SamplingAlgorithmType.Random;
        }

        /// <summary> Initializes a new instance of RandomSamplingAlgorithm. </summary>
        /// <param name="samplingAlgorithmType"> The algorithm used for generating hyperparameter values, along with configuration properties. </param>
        /// <param name="rule"> The specific type of random algorithm. </param>
        /// <param name="seed"> An optional integer to use as the seed for random number generation. </param>
        internal RandomSamplingAlgorithm(SamplingAlgorithmType samplingAlgorithmType, RandomSamplingAlgorithmRule? rule, int? seed) : base(samplingAlgorithmType)
        {
            Rule = rule;
            Seed = seed;
            SamplingAlgorithmType = samplingAlgorithmType;
        }

        /// <summary> The specific type of random algorithm. </summary>
        public RandomSamplingAlgorithmRule? Rule { get; set; }
        /// <summary> An optional integer to use as the seed for random number generation. </summary>
        public int? Seed { get; set; }
    }
}
