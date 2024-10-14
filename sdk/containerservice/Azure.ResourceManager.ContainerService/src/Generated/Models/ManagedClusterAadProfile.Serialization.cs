// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class ManagedClusterAadProfile : IUtf8JsonSerializable, IJsonModel<ManagedClusterAadProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedClusterAadProfile>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ManagedClusterAadProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterAadProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedClusterAadProfile)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(IsManagedAadEnabled))
            {
                writer.WritePropertyName("managed"u8);
                writer.WriteBooleanValue(IsManagedAadEnabled.Value);
            }
            if (Optional.IsDefined(IsAzureRbacEnabled))
            {
                writer.WritePropertyName("enableAzureRBAC"u8);
                writer.WriteBooleanValue(IsAzureRbacEnabled.Value);
            }
            if (Optional.IsCollectionDefined(AdminGroupObjectIds))
            {
                writer.WritePropertyName("adminGroupObjectIDs"u8);
                writer.WriteStartArray();
                foreach (var item in AdminGroupObjectIds)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ClientAppId))
            {
                writer.WritePropertyName("clientAppID"u8);
                writer.WriteStringValue(ClientAppId.Value);
            }
            if (Optional.IsDefined(ServerAppId))
            {
                writer.WritePropertyName("serverAppID"u8);
                writer.WriteStringValue(ServerAppId.Value);
            }
            if (Optional.IsDefined(ServerAppSecret))
            {
                writer.WritePropertyName("serverAppSecret"u8);
                writer.WriteStringValue(ServerAppSecret);
            }
            if (Optional.IsDefined(TenantId))
            {
                writer.WritePropertyName("tenantID"u8);
                writer.WriteStringValue(TenantId.Value);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        ManagedClusterAadProfile IJsonModel<ManagedClusterAadProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterAadProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedClusterAadProfile)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedClusterAadProfile(document.RootElement, options);
        }

        internal static ManagedClusterAadProfile DeserializeManagedClusterAadProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? managed = default;
            bool? enableAzureRBAC = default;
            IList<Guid> adminGroupObjectIds = default;
            Guid? clientAppId = default;
            Guid? serverAppId = default;
            string serverAppSecret = default;
            Guid? tenantId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("managed"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    managed = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("enableAzureRBAC"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableAzureRBAC = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("adminGroupObjectIDs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<Guid> array = new List<Guid>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetGuid());
                    }
                    adminGroupObjectIds = array;
                    continue;
                }
                if (property.NameEquals("clientAppID"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    clientAppId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("serverAppID"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    serverAppId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("serverAppSecret"u8))
                {
                    serverAppSecret = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tenantID"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tenantId = property.Value.GetGuid();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ManagedClusterAadProfile(
                managed,
                enableAzureRBAC,
                adminGroupObjectIds ?? new ChangeTrackingList<Guid>(),
                clientAppId,
                serverAppId,
                serverAppSecret,
                tenantId,
                serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsManagedAadEnabled), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  managed: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsManagedAadEnabled))
                {
                    builder.Append("  managed: ");
                    var boolValue = IsManagedAadEnabled.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsAzureRbacEnabled), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  enableAzureRBAC: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsAzureRbacEnabled))
                {
                    builder.Append("  enableAzureRBAC: ");
                    var boolValue = IsAzureRbacEnabled.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AdminGroupObjectIds), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  adminGroupObjectIDs: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(AdminGroupObjectIds))
                {
                    if (AdminGroupObjectIds.Any())
                    {
                        builder.Append("  adminGroupObjectIDs: ");
                        builder.AppendLine("[");
                        foreach (var item in AdminGroupObjectIds)
                        {
                            builder.AppendLine($"    '{item.ToString()}'");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ClientAppId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  clientAppID: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ClientAppId))
                {
                    builder.Append("  clientAppID: ");
                    builder.AppendLine($"'{ClientAppId.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ServerAppId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  serverAppID: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ServerAppId))
                {
                    builder.Append("  serverAppID: ");
                    builder.AppendLine($"'{ServerAppId.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ServerAppSecret), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  serverAppSecret: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ServerAppSecret))
                {
                    builder.Append("  serverAppSecret: ");
                    if (ServerAppSecret.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ServerAppSecret}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ServerAppSecret}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TenantId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  tenantID: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(TenantId))
                {
                    builder.Append("  tenantID: ");
                    builder.AppendLine($"'{TenantId.Value.ToString()}'");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ManagedClusterAadProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterAadProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ManagedClusterAadProfile)} does not support writing '{options.Format}' format.");
            }
        }

        ManagedClusterAadProfile IPersistableModel<ManagedClusterAadProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterAadProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManagedClusterAadProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagedClusterAadProfile)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedClusterAadProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
