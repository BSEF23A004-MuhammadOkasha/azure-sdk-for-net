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

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class RerunTumblingWindowTrigger : IUtf8JsonSerializable, IJsonModel<RerunTumblingWindowTrigger>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RerunTumblingWindowTrigger>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RerunTumblingWindowTrigger>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RerunTumblingWindowTrigger>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(RerunTumblingWindowTrigger)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(TriggerType);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (options.Format != "W" && Optional.IsDefined(RuntimeState))
            {
                writer.WritePropertyName("runtimeState"u8);
                writer.WriteStringValue(RuntimeState.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Annotations))
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
            writer.WritePropertyName("parentTrigger"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(ParentTrigger);
#else
            using (JsonDocument document = JsonDocument.Parse(ParentTrigger))
            {
                JsonSerializer.Serialize(writer, document.RootElement);
            }
#endif
            writer.WritePropertyName("requestedStartTime"u8);
            writer.WriteStringValue(RequestedStartOn, "O");
            writer.WritePropertyName("requestedEndTime"u8);
            writer.WriteStringValue(RequestedEndOn, "O");
            writer.WritePropertyName("rerunConcurrency"u8);
            writer.WriteNumberValue(RerunConcurrency);
            writer.WriteEndObject();
            if (AdditionalProperties != null)
            {
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
            }
            writer.WriteEndObject();
        }

        RerunTumblingWindowTrigger IJsonModel<RerunTumblingWindowTrigger>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RerunTumblingWindowTrigger>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(RerunTumblingWindowTrigger)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRerunTumblingWindowTrigger(document.RootElement, options);
        }

        internal static RerunTumblingWindowTrigger DeserializeRerunTumblingWindowTrigger(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = default;
            Optional<string> description = default;
            Optional<DataFactoryTriggerRuntimeState> runtimeState = default;
            Optional<IList<BinaryData>> annotations = default;
            BinaryData parentTrigger = default;
            DateTimeOffset requestedStartTime = default;
            DateTimeOffset requestedEndTime = default;
            int rerunConcurrency = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("runtimeState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    runtimeState = new DataFactoryTriggerRuntimeState(property.Value.GetString());
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
                        if (property0.NameEquals("parentTrigger"u8))
                        {
                            parentTrigger = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("requestedStartTime"u8))
                        {
                            requestedStartTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("requestedEndTime"u8))
                        {
                            requestedEndTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("rerunConcurrency"u8))
                        {
                            rerunConcurrency = property0.Value.GetInt32();
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new RerunTumblingWindowTrigger(type, description.Value, Optional.ToNullable(runtimeState), Optional.ToList(annotations), additionalProperties, parentTrigger, requestedStartTime, requestedEndTime, rerunConcurrency);
        }

        BinaryData IPersistableModel<RerunTumblingWindowTrigger>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RerunTumblingWindowTrigger>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(RerunTumblingWindowTrigger)} does not support '{options.Format}' format.");
            }
        }

        RerunTumblingWindowTrigger IPersistableModel<RerunTumblingWindowTrigger>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RerunTumblingWindowTrigger>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRerunTumblingWindowTrigger(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(RerunTumblingWindowTrigger)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RerunTumblingWindowTrigger>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
