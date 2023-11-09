// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class MicrosoftLanguageStemmingTokenizer : IUtf8JsonSerializable, IJsonModel<MicrosoftLanguageStemmingTokenizer>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MicrosoftLanguageStemmingTokenizer>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<MicrosoftLanguageStemmingTokenizer>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(MaxTokenLength))
            {
                writer.WritePropertyName("maxTokenLength"u8);
                writer.WriteNumberValue(MaxTokenLength.Value);
            }
            if (Optional.IsDefined(IsSearchTokenizer))
            {
                writer.WritePropertyName("isSearchTokenizer"u8);
                writer.WriteBooleanValue(IsSearchTokenizer.Value);
            }
            if (Optional.IsDefined(Language))
            {
                writer.WritePropertyName("language"u8);
                writer.WriteStringValue(Language.Value.ToSerialString());
            }
            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(ODataType);
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
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

        MicrosoftLanguageStemmingTokenizer IJsonModel<MicrosoftLanguageStemmingTokenizer>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MicrosoftLanguageStemmingTokenizer)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMicrosoftLanguageStemmingTokenizer(document.RootElement, options);
        }

        internal static MicrosoftLanguageStemmingTokenizer DeserializeMicrosoftLanguageStemmingTokenizer(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> maxTokenLength = default;
            Optional<bool> isSearchTokenizer = default;
            Optional<MicrosoftStemmingTokenizerLanguage> language = default;
            string odataType = default;
            string name = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("maxTokenLength"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxTokenLength = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("isSearchTokenizer"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isSearchTokenizer = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("language"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    language = property.Value.GetString().ToMicrosoftStemmingTokenizerLanguage();
                    continue;
                }
                if (property.NameEquals("@odata.type"u8))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MicrosoftLanguageStemmingTokenizer(odataType, name, serializedAdditionalRawData, Optional.ToNullable(maxTokenLength), Optional.ToNullable(isSearchTokenizer), Optional.ToNullable(language));
        }

        BinaryData IModel<MicrosoftLanguageStemmingTokenizer>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MicrosoftLanguageStemmingTokenizer)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        MicrosoftLanguageStemmingTokenizer IModel<MicrosoftLanguageStemmingTokenizer>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MicrosoftLanguageStemmingTokenizer)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeMicrosoftLanguageStemmingTokenizer(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<MicrosoftLanguageStemmingTokenizer>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
