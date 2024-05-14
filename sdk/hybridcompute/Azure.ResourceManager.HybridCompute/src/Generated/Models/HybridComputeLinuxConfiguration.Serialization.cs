// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridCompute.Models
{
    public partial class HybridComputeLinuxConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("patchSettings"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(AssessmentMode))
            {
                writer.WritePropertyName("assessmentMode"u8);
                writer.WriteStringValue(AssessmentMode.Value.ToString());
            }
            if (Optional.IsDefined(PatchMode))
            {
                writer.WritePropertyName("patchMode"u8);
                writer.WriteStringValue(PatchMode.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static HybridComputeLinuxConfiguration DeserializeHybridComputeLinuxConfiguration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AssessmentModeType> assessmentMode = default;
            Optional<PatchModeType> patchMode = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("patchSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("assessmentMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            assessmentMode = new AssessmentModeType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("patchMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            patchMode = new PatchModeType(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new HybridComputeLinuxConfiguration(Optional.ToNullable(assessmentMode), Optional.ToNullable(patchMode));
        }
    }
}
