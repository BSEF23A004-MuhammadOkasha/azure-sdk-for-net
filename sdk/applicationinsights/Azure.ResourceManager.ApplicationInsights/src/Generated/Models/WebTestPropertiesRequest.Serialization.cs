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
using Azure.ResourceManager;
using Azure.ResourceManager.ApplicationInsights;

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    public partial class WebTestPropertiesRequest : IUtf8JsonSerializable, IJsonModel<WebTestPropertiesRequest>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WebTestPropertiesRequest>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<WebTestPropertiesRequest>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebTestPropertiesRequest>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WebTestPropertiesRequest)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(RequestUri))
            {
                writer.WritePropertyName("RequestUrl"u8);
                writer.WriteStringValue(RequestUri.AbsoluteUri);
            }
            if (Optional.IsCollectionDefined(Headers))
            {
                writer.WritePropertyName("Headers"u8);
                writer.WriteStartArray();
                foreach (var item in Headers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(HttpVerb))
            {
                writer.WritePropertyName("HttpVerb"u8);
                writer.WriteStringValue(HttpVerb);
            }
            if (Optional.IsDefined(RequestBody))
            {
                writer.WritePropertyName("RequestBody"u8);
                writer.WriteStringValue(RequestBody);
            }
            if (Optional.IsDefined(ParseDependentRequests))
            {
                writer.WritePropertyName("ParseDependentRequests"u8);
                writer.WriteBooleanValue(ParseDependentRequests.Value);
            }
            if (Optional.IsDefined(FollowRedirects))
            {
                writer.WritePropertyName("FollowRedirects"u8);
                writer.WriteBooleanValue(FollowRedirects.Value);
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

        WebTestPropertiesRequest IJsonModel<WebTestPropertiesRequest>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebTestPropertiesRequest>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WebTestPropertiesRequest)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWebTestPropertiesRequest(document.RootElement, options);
        }

        internal static WebTestPropertiesRequest DeserializeWebTestPropertiesRequest(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Uri requestUrl = default;
            IList<HeaderField> headers = default;
            string httpVerb = default;
            string requestBody = default;
            bool? parseDependentRequests = default;
            bool? followRedirects = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("RequestUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    requestUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("Headers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<HeaderField> array = new List<HeaderField>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HeaderField.DeserializeHeaderField(item, options));
                    }
                    headers = array;
                    continue;
                }
                if (property.NameEquals("HttpVerb"u8))
                {
                    httpVerb = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("RequestBody"u8))
                {
                    requestBody = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ParseDependentRequests"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    parseDependentRequests = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("FollowRedirects"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    followRedirects = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new WebTestPropertiesRequest(
                requestUrl,
                headers ?? new ChangeTrackingList<HeaderField>(),
                httpVerb,
                requestBody,
                parseDependentRequests,
                followRedirects,
                serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.ParameterOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RequestUri), out propertyOverride);
            if (Optional.IsDefined(RequestUri) || hasPropertyOverride)
            {
                builder.Append("  RequestUrl: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    builder.AppendLine($"'{RequestUri.AbsoluteUri}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Headers), out propertyOverride);
            if (Optional.IsCollectionDefined(Headers) || hasPropertyOverride)
            {
                if (Headers.Any() || hasPropertyOverride)
                {
                    builder.Append("  Headers: ");
                    if (hasPropertyOverride)
                    {
                        builder.AppendLine($"{propertyOverride}");
                    }
                    else
                    {
                        builder.AppendLine("[");
                        foreach (var item in Headers)
                        {
                            AppendChildObject(builder, item, options, 4, true, "  Headers: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(HttpVerb), out propertyOverride);
            if (Optional.IsDefined(HttpVerb) || hasPropertyOverride)
            {
                builder.Append("  HttpVerb: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    if (HttpVerb.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{HttpVerb}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{HttpVerb}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RequestBody), out propertyOverride);
            if (Optional.IsDefined(RequestBody) || hasPropertyOverride)
            {
                builder.Append("  RequestBody: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    if (RequestBody.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{RequestBody}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{RequestBody}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ParseDependentRequests), out propertyOverride);
            if (Optional.IsDefined(ParseDependentRequests) || hasPropertyOverride)
            {
                builder.Append("  ParseDependentRequests: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    var boolValue = ParseDependentRequests.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(FollowRedirects), out propertyOverride);
            if (Optional.IsDefined(FollowRedirects) || hasPropertyOverride)
            {
                builder.Append("  FollowRedirects: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    var boolValue = FollowRedirects.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void AppendChildObject(StringBuilder stringBuilder, object childObject, ModelReaderWriterOptions options, int spaces, bool indentFirstLine, string formattedPropertyName)
        {
            string indent = new string(' ', spaces);
            int emptyObjectLength = 2 + spaces + Environment.NewLine.Length + Environment.NewLine.Length;
            int length = stringBuilder.Length;
            bool inMultilineString = false;

            BinaryData data = ModelReaderWriter.Write(childObject, options);
            string[] lines = data.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                if (inMultilineString)
                {
                    if (line.Contains("'''"))
                    {
                        inMultilineString = false;
                    }
                    stringBuilder.AppendLine(line);
                    continue;
                }
                if (line.Contains("'''"))
                {
                    inMultilineString = true;
                    stringBuilder.AppendLine($"{indent}{line}");
                    continue;
                }
                if (i == 0 && !indentFirstLine)
                {
                    stringBuilder.AppendLine($"{line}");
                }
                else
                {
                    stringBuilder.AppendLine($"{indent}{line}");
                }
            }
            if (stringBuilder.Length == length + emptyObjectLength)
            {
                stringBuilder.Length = stringBuilder.Length - emptyObjectLength - formattedPropertyName.Length;
            }
        }

        BinaryData IPersistableModel<WebTestPropertiesRequest>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebTestPropertiesRequest>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(WebTestPropertiesRequest)} does not support '{options.Format}' format.");
            }
        }

        WebTestPropertiesRequest IPersistableModel<WebTestPropertiesRequest>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebTestPropertiesRequest>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeWebTestPropertiesRequest(document.RootElement, options);
                    }
                case "bicep":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(WebTestPropertiesRequest)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<WebTestPropertiesRequest>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
