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
using Azure.ResourceManager.Communication.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Communication
{
    public partial class CommunicationDomainResourceData : IUtf8JsonSerializable, IJsonModel<CommunicationDomainResourceData>, IPersistableModel<CommunicationDomainResourceData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CommunicationDomainResourceData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CommunicationDomainResourceData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CommunicationDomainResourceData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CommunicationDomainResourceData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(DataLocation))
            {
                writer.WritePropertyName("dataLocation"u8);
                writer.WriteStringValue(DataLocation);
            }
            if (options.Format != "W" && Optional.IsDefined(FromSenderDomain))
            {
                writer.WritePropertyName("fromSenderDomain"u8);
                writer.WriteStringValue(FromSenderDomain);
            }
            if (options.Format != "W" && Optional.IsDefined(MailFromSenderDomain))
            {
                writer.WritePropertyName("mailFromSenderDomain"u8);
                writer.WriteStringValue(MailFromSenderDomain);
            }
            if (Optional.IsDefined(DomainManagement))
            {
                writer.WritePropertyName("domainManagement"u8);
                writer.WriteStringValue(DomainManagement.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(VerificationStates))
            {
                writer.WritePropertyName("verificationStates"u8);
                writer.WriteObjectValue(VerificationStates);
            }
            if (options.Format != "W" && Optional.IsDefined(VerificationRecords))
            {
                writer.WritePropertyName("verificationRecords"u8);
                writer.WriteObjectValue(VerificationRecords);
            }
            if (Optional.IsDefined(UserEngagementTracking))
            {
                writer.WritePropertyName("userEngagementTracking"u8);
                writer.WriteStringValue(UserEngagementTracking.Value.ToString());
            }
            writer.WriteEndObject();
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

        CommunicationDomainResourceData IJsonModel<CommunicationDomainResourceData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CommunicationDomainResourceData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CommunicationDomainResourceData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCommunicationDomainResourceData(document.RootElement, options);
        }

        internal static CommunicationDomainResourceData DeserializeCommunicationDomainResourceData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<DomainProvisioningState> provisioningState = default;
            Optional<string> dataLocation = default;
            Optional<string> fromSenderDomain = default;
            Optional<string> mailFromSenderDomain = default;
            Optional<DomainManagement> domainManagement = default;
            Optional<DomainPropertiesVerificationStates> verificationStates = default;
            Optional<DomainPropertiesVerificationRecords> verificationRecords = default;
            Optional<UserEngagementTracking> userEngagementTracking = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new DomainProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("dataLocation"u8))
                        {
                            dataLocation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("fromSenderDomain"u8))
                        {
                            fromSenderDomain = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("mailFromSenderDomain"u8))
                        {
                            mailFromSenderDomain = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("domainManagement"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            domainManagement = new DomainManagement(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("verificationStates"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            verificationStates = DomainPropertiesVerificationStates.DeserializeDomainPropertiesVerificationStates(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("verificationRecords"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            verificationRecords = DomainPropertiesVerificationRecords.DeserializeDomainPropertiesVerificationRecords(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("userEngagementTracking"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            userEngagementTracking = new UserEngagementTracking(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CommunicationDomainResourceData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, Optional.ToNullable(provisioningState), dataLocation.Value, fromSenderDomain.Value, mailFromSenderDomain.Value, Optional.ToNullable(domainManagement), verificationStates.Value, verificationRecords.Value, Optional.ToNullable(userEngagementTracking), serializedAdditionalRawData);
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

            if (Optional.IsDefined(DataLocation))
            {
                builder.Append("  dataLocation:");
                builder.AppendLine($" '{DataLocation}'");
            }

            if (Optional.IsDefined(FromSenderDomain))
            {
                builder.Append("  fromSenderDomain:");
                builder.AppendLine($" '{FromSenderDomain}'");
            }

            if (Optional.IsDefined(MailFromSenderDomain))
            {
                builder.Append("  mailFromSenderDomain:");
                builder.AppendLine($" '{MailFromSenderDomain}'");
            }

            if (Optional.IsDefined(DomainManagement))
            {
                builder.Append("  domainManagement:");
                builder.AppendLine($" '{DomainManagement.ToString()}'");
            }

            if (Optional.IsDefined(VerificationStates))
            {
                builder.Append("  verificationStates:");
                AppendChildObject(builder, VerificationStates, options, 2);
            }

            if (Optional.IsDefined(VerificationRecords))
            {
                builder.Append("  verificationRecords:");
                AppendChildObject(builder, VerificationRecords, options, 2);
            }

            if (Optional.IsDefined(UserEngagementTracking))
            {
                builder.Append("  userEngagementTracking:");
                builder.AppendLine($" '{UserEngagementTracking.ToString()}'");
            }

            if (Optional.IsCollectionDefined(Tags))
            {
                builder.Append("  tags:");
                builder.AppendLine(" {");
                foreach (var item in Tags)
                {
                    builder.Append($"    {item.Key}: ");
                    if (item.Value == null)
                    {
                        builder.Append("null");
                        continue;
                    }
                    builder.AppendLine($" '{item.Value}'");
                }
                builder.AppendLine("  }");
            }

            if (Optional.IsDefined(Location))
            {
                builder.Append("  location:");
                builder.AppendLine($" '{Location.ToString()}'");
            }

            if (Optional.IsDefined(Id))
            {
                builder.Append("  id:");
                builder.AppendLine($" '{Id.ToString()}'");
            }

            if (Optional.IsDefined(Name))
            {
                builder.Append("  name:");
                builder.AppendLine($" '{Name}'");
            }

            if (Optional.IsDefined(ResourceType))
            {
                builder.Append("  type:");
                builder.AppendLine($" '{ResourceType.ToString()}'");
            }

            if (Optional.IsDefined(SystemData))
            {
                builder.Append("  systemData:");
                builder.AppendLine($" '{SystemData.ToString()}'");
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

        BinaryData IPersistableModel<CommunicationDomainResourceData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CommunicationDomainResourceData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(CommunicationDomainResourceData)} does not support '{options.Format}' format.");
            }
        }

        CommunicationDomainResourceData IPersistableModel<CommunicationDomainResourceData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CommunicationDomainResourceData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCommunicationDomainResourceData(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(CommunicationDomainResourceData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CommunicationDomainResourceData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
