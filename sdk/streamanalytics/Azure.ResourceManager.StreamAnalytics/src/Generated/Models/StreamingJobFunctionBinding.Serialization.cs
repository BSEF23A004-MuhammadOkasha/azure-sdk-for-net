// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    public partial class StreamingJobFunctionBinding : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type");
            writer.WriteStringValue(FunctionBindingType);
            writer.WriteEndObject();
        }

        internal static StreamingJobFunctionBinding DeserializeStreamingJobFunctionBinding(JsonElement element)
        {
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Microsoft.MachineLearning/WebService": return EMachineLearningStudioFunctionBinding.DeserializeEMachineLearningStudioFunctionBinding(element);
                    case "Microsoft.MachineLearningServices": return MachineLearningServiceFunctionBinding.DeserializeMachineLearningServiceFunctionBinding(element);
                    case "Microsoft.StreamAnalytics/CLRUdf": return CSharpFunctionBinding.DeserializeCSharpFunctionBinding(element);
                    case "Microsoft.StreamAnalytics/JavascriptUdf": return JavaScriptFunctionBinding.DeserializeJavaScriptFunctionBinding(element);
                }
            }
            string type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
            }
            return new StreamingJobFunctionBinding(type);
        }
    }
}
