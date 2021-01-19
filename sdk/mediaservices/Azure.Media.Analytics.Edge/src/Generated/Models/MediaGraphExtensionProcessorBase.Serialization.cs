// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Media.Analytics.Edge.Models
{
    public partial class MediaGraphExtensionProcessorBase : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("endpoint");
            writer.WriteObjectValue(Endpoint);
            writer.WritePropertyName("image");
            writer.WriteObjectValue(Image);
            if (Optional.IsDefined(SamplingOptions))
            {
                writer.WritePropertyName("samplingOptions");
                writer.WriteObjectValue(SamplingOptions);
            }
            writer.WritePropertyName("@type");
            writer.WriteStringValue(Type);
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WritePropertyName("inputs");
            writer.WriteStartArray();
            foreach (var item in Inputs)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static MediaGraphExtensionProcessorBase DeserializeMediaGraphExtensionProcessorBase(JsonElement element)
        {
            if (element.TryGetProperty("@type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "#Microsoft.Media.MediaGraphCognitiveServicesVisionExtension": return MediaGraphCognitiveServicesVisionExtension.DeserializeMediaGraphCognitiveServicesVisionExtension(element);
                    case "#Microsoft.Media.MediaGraphGrpcExtension": return MediaGraphGrpcExtension.DeserializeMediaGraphGrpcExtension(element);
                    case "#Microsoft.Media.MediaGraphHttpExtension": return MediaGraphHttpExtension.DeserializeMediaGraphHttpExtension(element);
                }
            }
            MediaGraphEndpoint endpoint = default;
            MediaGraphImage image = default;
            Optional<MediaGraphSamplingOptions> samplingOptions = default;
            string type = default;
            string name = default;
            IList<MediaGraphNodeInput> inputs = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("endpoint"))
                {
                    endpoint = MediaGraphEndpoint.DeserializeMediaGraphEndpoint(property.Value);
                    continue;
                }
                if (property.NameEquals("image"))
                {
                    image = MediaGraphImage.DeserializeMediaGraphImage(property.Value);
                    continue;
                }
                if (property.NameEquals("samplingOptions"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    samplingOptions = MediaGraphSamplingOptions.DeserializeMediaGraphSamplingOptions(property.Value);
                    continue;
                }
                if (property.NameEquals("@type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("inputs"))
                {
                    List<MediaGraphNodeInput> array = new List<MediaGraphNodeInput>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MediaGraphNodeInput.DeserializeMediaGraphNodeInput(item));
                    }
                    inputs = array;
                    continue;
                }
            }
            return new MediaGraphExtensionProcessorBase(type, name, inputs, endpoint, image, samplingOptions.Value);
        }
    }
}
