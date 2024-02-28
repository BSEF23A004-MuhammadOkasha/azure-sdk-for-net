// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class ManagedInstanceOperationParametersPair : IUtf8JsonSerializable, IJsonModel<ManagedInstanceOperationParametersPair>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedInstanceOperationParametersPair>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ManagedInstanceOperationParametersPair>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedInstanceOperationParametersPair>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedInstanceOperationParametersPair)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && CurrentParameters != null)
            {
                writer.WritePropertyName("currentParameters"u8);
                writer.WriteObjectValue(CurrentParameters);
            }
            if (options.Format != "W" && RequestedParameters != null)
            {
                writer.WritePropertyName("requestedParameters"u8);
                writer.WriteObjectValue(RequestedParameters);
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

        ManagedInstanceOperationParametersPair IJsonModel<ManagedInstanceOperationParametersPair>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedInstanceOperationParametersPair>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedInstanceOperationParametersPair)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedInstanceOperationParametersPair(document.RootElement, options);
        }

        internal static ManagedInstanceOperationParametersPair DeserializeManagedInstanceOperationParametersPair(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            UpsertManagedServerOperationParameters currentParameters = default;
            UpsertManagedServerOperationParameters requestedParameters = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("currentParameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    currentParameters = UpsertManagedServerOperationParameters.DeserializeUpsertManagedServerOperationParameters(property.Value, options);
                    continue;
                }
                if (property.NameEquals("requestedParameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    requestedParameters = UpsertManagedServerOperationParameters.DeserializeUpsertManagedServerOperationParameters(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ManagedInstanceOperationParametersPair(currentParameters, requestedParameters, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ManagedInstanceOperationParametersPair>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedInstanceOperationParametersPair>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ManagedInstanceOperationParametersPair)} does not support '{options.Format}' format.");
            }
        }

        ManagedInstanceOperationParametersPair IPersistableModel<ManagedInstanceOperationParametersPair>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedInstanceOperationParametersPair>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManagedInstanceOperationParametersPair(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagedInstanceOperationParametersPair)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedInstanceOperationParametersPair>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
