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

namespace Azure.ResourceManager.Compute.Models
{
    public partial class UefiKeySignatures : IUtf8JsonSerializable, IJsonModel<UefiKeySignatures>, IPersistableModel<UefiKeySignatures>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<UefiKeySignatures>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<UefiKeySignatures>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UefiKeySignatures>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UefiKeySignatures)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Pk))
            {
                writer.WritePropertyName("pk"u8);
                writer.WriteObjectValue(Pk);
            }
            if (Optional.IsCollectionDefined(Kek))
            {
                writer.WritePropertyName("kek"u8);
                writer.WriteStartArray();
                foreach (var item in Kek)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Db))
            {
                writer.WritePropertyName("db"u8);
                writer.WriteStartArray();
                foreach (var item in Db)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Dbx))
            {
                writer.WritePropertyName("dbx"u8);
                writer.WriteStartArray();
                foreach (var item in Dbx)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        UefiKeySignatures IJsonModel<UefiKeySignatures>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UefiKeySignatures>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UefiKeySignatures)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUefiKeySignatures(document.RootElement, options);
        }

        internal static UefiKeySignatures DeserializeUefiKeySignatures(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<UefiKey> pk = default;
            Optional<IList<UefiKey>> kek = default;
            Optional<IList<UefiKey>> db = default;
            Optional<IList<UefiKey>> dbx = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("pk"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    pk = UefiKey.DeserializeUefiKey(property.Value);
                    continue;
                }
                if (property.NameEquals("kek"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<UefiKey> array = new List<UefiKey>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(UefiKey.DeserializeUefiKey(item));
                    }
                    kek = array;
                    continue;
                }
                if (property.NameEquals("db"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<UefiKey> array = new List<UefiKey>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(UefiKey.DeserializeUefiKey(item));
                    }
                    db = array;
                    continue;
                }
                if (property.NameEquals("dbx"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<UefiKey> array = new List<UefiKey>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(UefiKey.DeserializeUefiKey(item));
                    }
                    dbx = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new UefiKeySignatures(pk.Value, Optional.ToList(kek), Optional.ToList(db), Optional.ToList(dbx), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(Pk))
            {
                builder.Append("  pk:");
                AppendChildObject(builder, Pk, options, 2);
            }

            if (Optional.IsCollectionDefined(Kek))
            {
                builder.Append("  kek:");
                builder.AppendLine(" [");
                foreach (var item in Kek)
                {
                    AppendChildObject(builder, item, options, 4);
                }
                builder.AppendLine("  ]");
            }

            if (Optional.IsCollectionDefined(Db))
            {
                builder.Append("  db:");
                builder.AppendLine(" [");
                foreach (var item in Db)
                {
                    AppendChildObject(builder, item, options, 4);
                }
                builder.AppendLine("  ]");
            }

            if (Optional.IsCollectionDefined(Dbx))
            {
                builder.Append("  dbx:");
                builder.AppendLine(" [");
                foreach (var item in Dbx)
                {
                    AppendChildObject(builder, item, options, 4);
                }
                builder.AppendLine("  ]");
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

        BinaryData IPersistableModel<UefiKeySignatures>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UefiKeySignatures>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(UefiKeySignatures)} does not support '{options.Format}' format.");
            }
        }

        UefiKeySignatures IPersistableModel<UefiKeySignatures>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UefiKeySignatures>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeUefiKeySignatures(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(UefiKeySignatures)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<UefiKeySignatures>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
