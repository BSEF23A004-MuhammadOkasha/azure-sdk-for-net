// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DeploymentManager.Models
{
    public partial class RestHealthCheckStepAttributes : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type");
            writer.WriteStringValue(HealthCheckStepAttributesType);
            if (Optional.IsDefined(WaitDuration))
            {
                writer.WritePropertyName("waitDuration");
                writer.WriteStringValue(WaitDuration.Value, "P");
            }
            if (Optional.IsDefined(MaxElasticDuration))
            {
                writer.WritePropertyName("maxElasticDuration");
                writer.WriteStringValue(MaxElasticDuration.Value, "P");
            }
            writer.WritePropertyName("healthyStateDuration");
            writer.WriteStringValue(HealthyStateDuration, "P");
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(HealthChecks))
            {
                writer.WritePropertyName("healthChecks");
                writer.WriteStartArray();
                foreach (var item in HealthChecks)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static RestHealthCheckStepAttributes DeserializeRestHealthCheckStepAttributes(JsonElement element)
        {
            string type = default;
            Optional<TimeSpan> waitDuration = default;
            Optional<TimeSpan> maxElasticDuration = default;
            TimeSpan healthyStateDuration = default;
            Optional<IList<RestHealthCheck>> healthChecks = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("waitDuration"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    waitDuration = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("maxElasticDuration"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    maxElasticDuration = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("healthyStateDuration"))
                {
                    healthyStateDuration = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("healthChecks"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<RestHealthCheck> array = new List<RestHealthCheck>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(RestHealthCheck.DeserializeRestHealthCheck(item));
                            }
                            healthChecks = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new RestHealthCheckStepAttributes(type, Optional.ToNullable(waitDuration), Optional.ToNullable(maxElasticDuration), healthyStateDuration, Optional.ToList(healthChecks));
        }
    }
}
