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

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class DataBoxContactDetails : IUtf8JsonSerializable, IJsonModel<DataBoxContactDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataBoxContactDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataBoxContactDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxContactDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataBoxContactDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("contactName"u8);
            writer.WriteStringValue(ContactName);
            writer.WritePropertyName("phone"u8);
            writer.WriteStringValue(Phone);
            if (Optional.IsDefined(PhoneExtension))
            {
                writer.WritePropertyName("phoneExtension"u8);
                writer.WriteStringValue(PhoneExtension);
            }
            if (Optional.IsDefined(Mobile))
            {
                writer.WritePropertyName("mobile"u8);
                writer.WriteStringValue(Mobile);
            }
            writer.WritePropertyName("emailList"u8);
            writer.WriteStartArray();
            foreach (var item in EmailList)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsCollectionDefined(NotificationPreference))
            {
                writer.WritePropertyName("notificationPreference"u8);
                writer.WriteStartArray();
                foreach (var item in NotificationPreference)
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

        DataBoxContactDetails IJsonModel<DataBoxContactDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxContactDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataBoxContactDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataBoxContactDetails(document.RootElement, options);
        }

        internal static DataBoxContactDetails DeserializeDataBoxContactDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string contactName = default;
            string phone = default;
            Optional<string> phoneExtension = default;
            Optional<string> mobile = default;
            IList<string> emailList = default;
            Optional<IList<NotificationPreference>> notificationPreference = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("contactName"u8))
                {
                    contactName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("phone"u8))
                {
                    phone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("phoneExtension"u8))
                {
                    phoneExtension = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("mobile"u8))
                {
                    mobile = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("emailList"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    emailList = array;
                    continue;
                }
                if (property.NameEquals("notificationPreference"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NotificationPreference> array = new List<NotificationPreference>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Models.NotificationPreference.DeserializeNotificationPreference(item));
                    }
                    notificationPreference = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DataBoxContactDetails(contactName, phone, phoneExtension.Value, mobile.Value, emailList, Optional.ToList(notificationPreference), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(ContactName))
            {
                builder.Append("  contactName:");
                builder.AppendLine($" '{ContactName}'");
            }

            if (Optional.IsDefined(Phone))
            {
                builder.Append("  phone:");
                builder.AppendLine($" '{Phone}'");
            }

            if (Optional.IsDefined(PhoneExtension))
            {
                builder.Append("  phoneExtension:");
                builder.AppendLine($" '{PhoneExtension}'");
            }

            if (Optional.IsDefined(Mobile))
            {
                builder.Append("  mobile:");
                builder.AppendLine($" '{Mobile}'");
            }

            if (Optional.IsCollectionDefined(EmailList))
            {
                if (EmailList.Any())
                {
                    builder.Append("  emailList:");
                    builder.AppendLine(" [");
                    foreach (var item in EmailList)
                    {
                        if (item == null)
                        {
                            builder.Append("null");
                            continue;
                        }
                        builder.AppendLine($"    '{item}'");
                    }
                    builder.AppendLine("  ]");
                }
            }

            if (Optional.IsCollectionDefined(NotificationPreference))
            {
                if (NotificationPreference.Any())
                {
                    builder.Append("  notificationPreference:");
                    builder.AppendLine(" [");
                    foreach (var item in NotificationPreference)
                    {
                        AppendChildObject(builder, item, options, 4, true);
                    }
                    builder.AppendLine("  ]");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void AppendChildObject(StringBuilder stringBuilder, object childObject, ModelReaderWriterOptions options, int spaces, bool indentFirstLine)
        {
            string indent = new string(' ', spaces);
            BinaryData data = ModelReaderWriter.Write(childObject, options);
            string[] lines = data.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                if (i == 0 && !indentFirstLine)
                {
                    stringBuilder.AppendLine($" {line}");
                }
                else
                {
                    stringBuilder.AppendLine($"{indent}{line}");
                }
            }
        }

        BinaryData IPersistableModel<DataBoxContactDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxContactDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(DataBoxContactDetails)} does not support '{options.Format}' format.");
            }
        }

        DataBoxContactDetails IPersistableModel<DataBoxContactDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxContactDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataBoxContactDetails(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(DataBoxContactDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataBoxContactDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
