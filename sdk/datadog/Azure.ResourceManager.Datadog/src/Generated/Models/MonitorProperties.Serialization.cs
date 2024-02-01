// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Datadog.Models
{
    public partial class MonitorProperties : IUtf8JsonSerializable, IJsonModel<MonitorProperties>, IPersistableModel<MonitorProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MonitorProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MonitorProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MonitorProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(MonitoringStatus))
            {
                writer.WritePropertyName("monitoringStatus"u8);
                writer.WriteStringValue(MonitoringStatus.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(MarketplaceSubscriptionStatus))
            {
                writer.WritePropertyName("marketplaceSubscriptionStatus"u8);
                writer.WriteStringValue(MarketplaceSubscriptionStatus.Value.ToString());
            }
            if (Optional.IsDefined(DatadogOrganizationProperties))
            {
                writer.WritePropertyName("datadogOrganizationProperties"u8);
                writer.WriteObjectValue(DatadogOrganizationProperties);
            }
            if (Optional.IsDefined(UserInfo))
            {
                writer.WritePropertyName("userInfo"u8);
                writer.WriteObjectValue(UserInfo);
            }
            if (options.Format != "W" && Optional.IsDefined(LiftrResourceCategory))
            {
                writer.WritePropertyName("liftrResourceCategory"u8);
                writer.WriteStringValue(LiftrResourceCategory.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(LiftrResourcePreference))
            {
                writer.WritePropertyName("liftrResourcePreference"u8);
                writer.WriteNumberValue(LiftrResourcePreference.Value);
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
            writer.WriteEndObject();
        }

        MonitorProperties IJsonModel<MonitorProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MonitorProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMonitorProperties(document.RootElement, options);
        }

        internal static MonitorProperties DeserializeMonitorProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ProvisioningState> provisioningState = default;
            Optional<MonitoringStatus> monitoringStatus = default;
            Optional<MarketplaceSubscriptionStatus> marketplaceSubscriptionStatus = default;
            Optional<DatadogOrganizationProperties> datadogOrganizationProperties = default;
            Optional<UserInfo> userInfo = default;
            Optional<LiftrResourceCategory> liftrResourceCategory = default;
            Optional<int> liftrResourcePreference = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new ProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("monitoringStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    monitoringStatus = new MonitoringStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("marketplaceSubscriptionStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    marketplaceSubscriptionStatus = new MarketplaceSubscriptionStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("datadogOrganizationProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    datadogOrganizationProperties = DatadogOrganizationProperties.DeserializeDatadogOrganizationProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("userInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    userInfo = UserInfo.DeserializeUserInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("liftrResourceCategory"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    liftrResourceCategory = new LiftrResourceCategory(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("liftrResourcePreference"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    liftrResourcePreference = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MonitorProperties(Optional.ToNullable(provisioningState), Optional.ToNullable(monitoringStatus), Optional.ToNullable(marketplaceSubscriptionStatus), datadogOrganizationProperties.Value, userInfo.Value, Optional.ToNullable(liftrResourceCategory), Optional.ToNullable(liftrResourcePreference), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(ProvisioningState))
            {
                builder.Append("  provisioningState:");
                builder.AppendLine($" '{ProvisioningState.ToString()}'");
            }

            if (Optional.IsDefined(MonitoringStatus))
            {
                builder.Append("  monitoringStatus:");
                builder.AppendLine($" '{MonitoringStatus.ToString()}'");
            }

            if (Optional.IsDefined(MarketplaceSubscriptionStatus))
            {
                builder.Append("  marketplaceSubscriptionStatus:");
                builder.AppendLine($" '{MarketplaceSubscriptionStatus.ToString()}'");
            }

            if (Optional.IsDefined(DatadogOrganizationProperties))
            {
                builder.Append("  datadogOrganizationProperties:");
                AppendChildObject(builder, DatadogOrganizationProperties, options, 2);
            }

            if (Optional.IsDefined(UserInfo))
            {
                builder.Append("  userInfo:");
                AppendChildObject(builder, UserInfo, options, 2);
            }

            if (Optional.IsDefined(LiftrResourceCategory))
            {
                builder.Append("  liftrResourceCategory:");
                builder.AppendLine($" '{LiftrResourceCategory.ToString()}'");
            }

            if (Optional.IsDefined(LiftrResourcePreference))
            {
                builder.Append("  liftrResourcePreference:");
                builder.AppendLine($" '{LiftrResourcePreference.Value.ToString()}'");
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void AppendChildObject(StringBuilder stringBuilder, object childObject, ModelReaderWriterOptions options, int spaces)
        {
            string indent = new string(' ', spaces);
            BinaryData data = ModelReaderWriter.Write(childObject, options);
            string[] lines = data.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in lines)
            {
                stringBuilder.AppendLine($"{indent}{line}");
            }
        }

        BinaryData IPersistableModel<MonitorProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(MonitorProperties)} does not support '{options.Format}' format.");
            }
        }

        MonitorProperties IPersistableModel<MonitorProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMonitorProperties(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(MonitorProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MonitorProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
