// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class SalesforceV2LinkedService : IUtf8JsonSerializable, IJsonModel<SalesforceV2LinkedService>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SalesforceV2LinkedService>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SalesforceV2LinkedService>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SalesforceV2LinkedService>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SalesforceV2LinkedService)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(LinkedServiceType);
            if (ConnectVia != null)
            {
                writer.WritePropertyName("connectVia"u8);
                writer.WriteObjectValue(ConnectVia);
            }
            if (Description != null)
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (!(Parameters is ChangeTrackingDictionary<string, EntityParameterSpecification> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteStartObject();
                foreach (var item in Parameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (!(Annotations is ChangeTrackingList<BinaryData> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("annotations"u8);
                writer.WriteStartArray();
                foreach (var item in Annotations)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item);
#else
                    using (JsonDocument document = JsonDocument.Parse(item))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("typeProperties"u8);
            writer.WriteStartObject();
            if (EnvironmentUri != null)
            {
                writer.WritePropertyName("environmentUrl"u8);
                JsonSerializer.Serialize(writer, EnvironmentUri);
            }
            if (AuthenticationType != null)
            {
                writer.WritePropertyName("authenticationType"u8);
                JsonSerializer.Serialize(writer, AuthenticationType);
            }
            if (ClientId != null)
            {
                writer.WritePropertyName("clientId"u8);
                JsonSerializer.Serialize(writer, ClientId);
            }
            if (ClientSecret != null)
            {
                writer.WritePropertyName("clientSecret"u8);
                JsonSerializer.Serialize(writer, ClientSecret);
            }
            if (ApiVersion != null)
            {
                writer.WritePropertyName("apiVersion"u8);
                JsonSerializer.Serialize(writer, ApiVersion);
            }
            if (EncryptedCredential != null)
            {
                writer.WritePropertyName("encryptedCredential"u8);
                writer.WriteStringValue(EncryptedCredential);
            }
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
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
            writer.WriteEndObject();
        }

        SalesforceV2LinkedService IJsonModel<SalesforceV2LinkedService>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SalesforceV2LinkedService>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SalesforceV2LinkedService)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSalesforceV2LinkedService(document.RootElement, options);
        }

        internal static SalesforceV2LinkedService DeserializeSalesforceV2LinkedService(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = default;
            Optional<IntegrationRuntimeReference> connectVia = default;
            Optional<string> description = default;
            Optional<IDictionary<string, EntityParameterSpecification>> parameters = default;
            IList<BinaryData> annotations = default;
            Optional<DataFactoryElement<string>> environmentUrl = default;
            Optional<DataFactoryElement<string>> authenticationType = default;
            Optional<DataFactoryElement<string>> clientId = default;
            Optional<DataFactorySecretBaseDefinition> clientSecret = default;
            Optional<DataFactoryElement<string>> apiVersion = default;
            Optional<string> encryptedCredential = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("connectVia"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    connectVia = IntegrationRuntimeReference.DeserializeIntegrationRuntimeReference(property.Value, options);
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, EntityParameterSpecification> dictionary = new Dictionary<string, EntityParameterSpecification>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, EntityParameterSpecification.DeserializeEntityParameterSpecification(property0.Value, options));
                    }
                    parameters = dictionary;
                    continue;
                }
                if (property.NameEquals("annotations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BinaryData> array = new List<BinaryData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(BinaryData.FromString(item.GetRawText()));
                        }
                    }
                    annotations = array;
                    continue;
                }
                if (property.NameEquals("typeProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("environmentUrl"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            environmentUrl = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("authenticationType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            authenticationType = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("clientId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clientId = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("clientSecret"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clientSecret = JsonSerializer.Deserialize<DataFactorySecretBaseDefinition>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("apiVersion"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            apiVersion = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("encryptedCredential"u8))
                        {
                            encryptedCredential = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new SalesforceV2LinkedService(type, connectVia.Value, description.Value, Optional.ToDictionary(parameters), annotations ?? new ChangeTrackingList<BinaryData>(), additionalProperties, environmentUrl.Value, authenticationType.Value, clientId.Value, clientSecret, apiVersion.Value, encryptedCredential.Value);
        }

        BinaryData IPersistableModel<SalesforceV2LinkedService>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SalesforceV2LinkedService>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SalesforceV2LinkedService)} does not support '{options.Format}' format.");
            }
        }

        SalesforceV2LinkedService IPersistableModel<SalesforceV2LinkedService>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SalesforceV2LinkedService>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSalesforceV2LinkedService(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SalesforceV2LinkedService)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SalesforceV2LinkedService>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
