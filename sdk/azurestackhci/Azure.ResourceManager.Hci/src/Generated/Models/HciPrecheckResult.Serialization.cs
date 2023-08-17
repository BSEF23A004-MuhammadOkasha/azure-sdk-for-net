// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Hci.Models
{
    public partial class HciPrecheckResult : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteObjectValue(Tags);
            }
            if (Optional.IsDefined(HealthCheckTags))
            {
                writer.WritePropertyName("healthCheckTags"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(HealthCheckTags);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(HealthCheckTags.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(Title))
            {
                writer.WritePropertyName("title"u8);
                writer.WriteStringValue(Title);
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (Optional.IsDefined(Severity))
            {
                writer.WritePropertyName("severity"u8);
                writer.WriteStringValue(Severity.Value.ToString());
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(Remediation))
            {
                writer.WritePropertyName("remediation"u8);
                writer.WriteStringValue(Remediation);
            }
            if (Optional.IsDefined(TargetResourceId))
            {
                writer.WritePropertyName("targetResourceID"u8);
                writer.WriteStringValue(TargetResourceId);
            }
            if (Optional.IsDefined(TargetResourceName))
            {
                writer.WritePropertyName("targetResourceName"u8);
                writer.WriteStringValue(TargetResourceName);
            }
            if (Optional.IsDefined(TargetResourceType))
            {
                writer.WritePropertyName("targetResourceType"u8);
                writer.WriteStringValue(TargetResourceType);
            }
            if (Optional.IsDefined(Timestamp))
            {
                writer.WritePropertyName("timestamp"u8);
                writer.WriteStringValue(Timestamp.Value, "O");
            }
            if (Optional.IsDefined(AdditionalData))
            {
                writer.WritePropertyName("additionalData"u8);
                writer.WriteStringValue(AdditionalData);
            }
            if (Optional.IsDefined(HealthCheckSource))
            {
                writer.WritePropertyName("healthCheckSource"u8);
                writer.WriteStringValue(HealthCheckSource);
            }
            writer.WriteEndObject();
        }

        internal static HciPrecheckResult DeserializeHciPrecheckResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<HciPrecheckResultTags> tags = default;
            Optional<BinaryData> healthCheckTags = default;
            Optional<string> title = default;
            Optional<HciClusterStatus> status = default;
            Optional<UpdateSeverity> severity = default;
            Optional<string> description = default;
            Optional<string> remediation = default;
            Optional<string> targetResourceId = default;
            Optional<string> targetResourceName = default;
            Optional<string> targetResourceType = default;
            Optional<DateTimeOffset> timestamp = default;
            Optional<string> additionalData = default;
            Optional<string> healthCheckSource = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tags = HciPrecheckResultTags.DeserializeHciPrecheckResultTags(property.Value);
                    continue;
                }
                if (property.NameEquals("healthCheckTags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    healthCheckTags = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("title"u8))
                {
                    title = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new HciClusterStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("severity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    severity = new UpdateSeverity(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("remediation"u8))
                {
                    remediation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetResourceID"u8))
                {
                    targetResourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetResourceName"u8))
                {
                    targetResourceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetResourceType"u8))
                {
                    targetResourceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("additionalData"u8))
                {
                    additionalData = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("healthCheckSource"u8))
                {
                    healthCheckSource = property.Value.GetString();
                    continue;
                }
            }
            return new HciPrecheckResult(name.Value, tags.Value, healthCheckTags.Value, title.Value, Optional.ToNullable(status), Optional.ToNullable(severity), description.Value, remediation.Value, targetResourceId.Value, targetResourceName.Value, targetResourceType.Value, Optional.ToNullable(timestamp), additionalData.Value, healthCheckSource.Value);
        }
    }
}
