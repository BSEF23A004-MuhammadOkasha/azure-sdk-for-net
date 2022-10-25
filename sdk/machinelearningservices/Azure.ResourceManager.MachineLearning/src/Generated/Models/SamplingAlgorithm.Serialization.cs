// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class SamplingAlgorithm : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("samplingAlgorithmType");
            writer.WriteStringValue(SamplingAlgorithmType.ToString());
            writer.WriteEndObject();
        }

        internal static SamplingAlgorithm DeserializeSamplingAlgorithm(JsonElement element)
        {
            if (element.TryGetProperty("samplingAlgorithmType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Bayesian": return BayesianSamplingAlgorithm.DeserializeBayesianSamplingAlgorithm(element);
                    case "Grid": return GridSamplingAlgorithm.DeserializeGridSamplingAlgorithm(element);
                    case "Random": return RandomSamplingAlgorithm.DeserializeRandomSamplingAlgorithm(element);
                }
            }
            SamplingAlgorithmType samplingAlgorithmType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("samplingAlgorithmType"))
                {
                    samplingAlgorithmType = new SamplingAlgorithmType(property.Value.GetString());
                    continue;
                }
            }
            return new UnknownSamplingAlgorithm(samplingAlgorithmType);
        }
    }
}
