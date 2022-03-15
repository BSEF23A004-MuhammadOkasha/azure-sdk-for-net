// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    public partial class TritonModelJobInput : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Mode))
            {
                writer.WritePropertyName("mode");
                writer.WriteStringValue(Mode.Value.ToString());
            }
            writer.WritePropertyName("uri");
            writer.WriteStringValue(Uri.AbsoluteUri);
            if (Optional.IsDefined(Description))
            {
                if (Description != null)
                {
                    writer.WritePropertyName("description");
                    writer.WriteStringValue(Description);
                }
                else
                {
                    writer.WriteNull("description");
                }
            }
            writer.WritePropertyName("jobInputType");
            writer.WriteStringValue(JobInputType.ToString());
            writer.WriteEndObject();
        }

        internal static TritonModelJobInput DeserializeTritonModelJobInput(JsonElement element)
        {
            Optional<InputDeliveryMode> mode = default;
            Uri uri = default;
            Optional<string> description = default;
            JobInputType jobInputType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("mode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    mode = new InputDeliveryMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("uri"))
                {
                    uri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        description = null;
                        continue;
                    }
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("jobInputType"))
                {
                    jobInputType = new JobInputType(property.Value.GetString());
                    continue;
                }
            }
            return new TritonModelJobInput(description.Value, jobInputType, Optional.ToNullable(mode), uri);
        }
    }
}
