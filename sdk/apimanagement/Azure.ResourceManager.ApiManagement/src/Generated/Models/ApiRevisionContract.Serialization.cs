// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class ApiRevisionContract : IUtf8JsonSerializable, IJsonModel<ApiRevisionContract>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ApiRevisionContract>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ApiRevisionContract>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiRevisionContract>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ApiRevisionContract)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ApiId))
            {
                writer.WritePropertyName("apiId"u8);
                writer.WriteStringValue(ApiId);
            }
            if (options.Format != "W" && Optional.IsDefined(ApiRevision))
            {
                writer.WritePropertyName("apiRevision"u8);
                writer.WriteStringValue(ApiRevision);
            }
            if (options.Format != "W" && Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("createdDateTime"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(UpdatedOn))
            {
                writer.WritePropertyName("updatedDateTime"u8);
                writer.WriteStringValue(UpdatedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (options.Format != "W" && Optional.IsDefined(PrivateUriString))
            {
                writer.WritePropertyName("privateUrl"u8);
                writer.WriteStringValue(PrivateUriString);
            }
            if (options.Format != "W" && Optional.IsDefined(IsOnline))
            {
                writer.WritePropertyName("isOnline"u8);
                writer.WriteBooleanValue(IsOnline.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(IsCurrent))
            {
                writer.WritePropertyName("isCurrent"u8);
                writer.WriteBooleanValue(IsCurrent.Value);
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

        ApiRevisionContract IJsonModel<ApiRevisionContract>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiRevisionContract>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ApiRevisionContract)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeApiRevisionContract(document.RootElement, options);
        }

        internal static ApiRevisionContract DeserializeApiRevisionContract(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> apiId = default;
            Optional<string> apiRevision = default;
            Optional<DateTimeOffset> createdDateTime = default;
            Optional<DateTimeOffset> updatedDateTime = default;
            Optional<string> description = default;
            Optional<string> privateUri = default;
            Optional<bool> isOnline = default;
            Optional<bool> isCurrent = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("apiId"u8))
                {
                    apiId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("apiRevision"u8))
                {
                    apiRevision = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createdDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createdDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("updatedDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    updatedDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("privateUrl"u8))
                {
                    privateUri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isOnline"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isOnline = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isCurrent"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isCurrent = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ApiRevisionContract(apiId.Value, apiRevision.Value, Optional.ToNullable(createdDateTime), Optional.ToNullable(updatedDateTime), description.Value, privateUri.Value, Optional.ToNullable(isOnline), Optional.ToNullable(isCurrent), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ApiRevisionContract>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiRevisionContract>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(ApiRevisionContract)} does not support '{options.Format}' format.");
            }
        }

        ApiRevisionContract IPersistableModel<ApiRevisionContract>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiRevisionContract>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeApiRevisionContract(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(ApiRevisionContract)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ApiRevisionContract>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
