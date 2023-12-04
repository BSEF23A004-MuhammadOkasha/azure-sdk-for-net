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

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class SearchIndex : IUtf8JsonSerializable, IJsonModel<SearchIndex>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SearchIndex>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SearchIndex>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SearchIndex>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(SearchIndex)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("fields"u8);
            writer.WriteStartArray();
            foreach (var item in _fields)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsCollectionDefined(ScoringProfiles))
            {
                writer.WritePropertyName("scoringProfiles"u8);
                writer.WriteStartArray();
                foreach (var item in ScoringProfiles)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DefaultScoringProfile))
            {
                writer.WritePropertyName("defaultScoringProfile"u8);
                writer.WriteStringValue(DefaultScoringProfile);
            }
            if (Optional.IsDefined(CorsOptions))
            {
                if (CorsOptions != null)
                {
                    writer.WritePropertyName("corsOptions"u8);
                    writer.WriteObjectValue(CorsOptions);
                }
                else
                {
                    writer.WriteNull("corsOptions");
                }
            }
            if (Optional.IsCollectionDefined(Suggesters))
            {
                writer.WritePropertyName("suggesters"u8);
                writer.WriteStartArray();
                foreach (var item in Suggesters)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Analyzers))
            {
                writer.WritePropertyName("analyzers"u8);
                writer.WriteStartArray();
                foreach (var item in Analyzers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Tokenizers))
            {
                writer.WritePropertyName("tokenizers"u8);
                writer.WriteStartArray();
                foreach (var item in Tokenizers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(TokenFilters))
            {
                writer.WritePropertyName("tokenFilters"u8);
                writer.WriteStartArray();
                foreach (var item in TokenFilters)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(CharFilters))
            {
                writer.WritePropertyName("charFilters"u8);
                writer.WriteStartArray();
                foreach (var item in CharFilters)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(EncryptionKey))
            {
                if (EncryptionKey != null)
                {
                    writer.WritePropertyName("encryptionKey"u8);
                    writer.WriteObjectValue(EncryptionKey);
                }
                else
                {
                    writer.WriteNull("encryptionKey");
                }
            }
            if (Optional.IsDefined(Similarity))
            {
                writer.WritePropertyName("similarity"u8);
                writer.WriteObjectValue(Similarity);
            }
            if (Optional.IsDefined(SemanticSearch))
            {
                if (SemanticSearch != null)
                {
                    writer.WritePropertyName("semantic"u8);
                    writer.WriteObjectValue(SemanticSearch);
                }
                else
                {
                    writer.WriteNull("semantic");
                }
            }
            if (Optional.IsDefined(VectorSearch))
            {
                if (VectorSearch != null)
                {
                    writer.WritePropertyName("vectorSearch"u8);
                    writer.WriteObjectValue(VectorSearch);
                }
                else
                {
                    writer.WriteNull("vectorSearch");
                }
            }
            if (Optional.IsDefined(_etag))
            {
                writer.WritePropertyName("@odata.etag"u8);
                writer.WriteStringValue(_etag);
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

        SearchIndex IJsonModel<SearchIndex>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SearchIndex>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(SearchIndex)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSearchIndex(document.RootElement, options);
        }

        internal static SearchIndex DeserializeSearchIndex(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            IList<SearchField> fields = default;
            Optional<IList<ScoringProfile>> scoringProfiles = default;
            Optional<string> defaultScoringProfile = default;
            Optional<CorsOptions> corsOptions = default;
            Optional<IList<SearchSuggester>> suggesters = default;
            Optional<IList<LexicalAnalyzer>> analyzers = default;
            Optional<IList<LexicalTokenizer>> tokenizers = default;
            Optional<IList<TokenFilter>> tokenFilters = default;
            Optional<IList<CharFilter>> charFilters = default;
            Optional<SearchResourceEncryptionKey> encryptionKey = default;
            Optional<SimilarityAlgorithm> similarity = default;
            Optional<SemanticSearch> semantic = default;
            Optional<VectorSearch> vectorSearch = default;
            Optional<string> odataEtag = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fields"u8))
                {
                    List<SearchField> array = new List<SearchField>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SearchField.DeserializeSearchField(item));
                    }
                    fields = array;
                    continue;
                }
                if (property.NameEquals("scoringProfiles"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ScoringProfile> array = new List<ScoringProfile>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ScoringProfile.DeserializeScoringProfile(item));
                    }
                    scoringProfiles = array;
                    continue;
                }
                if (property.NameEquals("defaultScoringProfile"u8))
                {
                    defaultScoringProfile = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("corsOptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        corsOptions = null;
                        continue;
                    }
                    corsOptions = CorsOptions.DeserializeCorsOptions(property.Value);
                    continue;
                }
                if (property.NameEquals("suggesters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SearchSuggester> array = new List<SearchSuggester>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SearchSuggester.DeserializeSearchSuggester(item));
                    }
                    suggesters = array;
                    continue;
                }
                if (property.NameEquals("analyzers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<LexicalAnalyzer> array = new List<LexicalAnalyzer>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LexicalAnalyzer.DeserializeLexicalAnalyzer(item));
                    }
                    analyzers = array;
                    continue;
                }
                if (property.NameEquals("tokenizers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<LexicalTokenizer> array = new List<LexicalTokenizer>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LexicalTokenizer.DeserializeLexicalTokenizer(item));
                    }
                    tokenizers = array;
                    continue;
                }
                if (property.NameEquals("tokenFilters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<TokenFilter> array = new List<TokenFilter>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TokenFilter.DeserializeTokenFilter(item));
                    }
                    tokenFilters = array;
                    continue;
                }
                if (property.NameEquals("charFilters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CharFilter> array = new List<CharFilter>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CharFilter.DeserializeCharFilter(item));
                    }
                    charFilters = array;
                    continue;
                }
                if (property.NameEquals("encryptionKey"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        encryptionKey = null;
                        continue;
                    }
                    encryptionKey = SearchResourceEncryptionKey.DeserializeSearchResourceEncryptionKey(property.Value);
                    continue;
                }
                if (property.NameEquals("similarity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    similarity = SimilarityAlgorithm.DeserializeSimilarityAlgorithm(property.Value);
                    continue;
                }
                if (property.NameEquals("semantic"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        semantic = null;
                        continue;
                    }
                    semantic = SemanticSearch.DeserializeSemanticSearch(property.Value);
                    continue;
                }
                if (property.NameEquals("vectorSearch"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        vectorSearch = null;
                        continue;
                    }
                    vectorSearch = VectorSearch.DeserializeVectorSearch(property.Value);
                    continue;
                }
                if (property.NameEquals("@odata.etag"u8))
                {
                    odataEtag = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SearchIndex(name, fields, Optional.ToList(scoringProfiles), defaultScoringProfile.Value, corsOptions.Value, Optional.ToList(suggesters), Optional.ToList(analyzers), Optional.ToList(tokenizers), Optional.ToList(tokenFilters), Optional.ToList(charFilters), encryptionKey.Value, similarity.Value, semantic.Value, vectorSearch.Value, odataEtag.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SearchIndex>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SearchIndex>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(SearchIndex)} does not support '{options.Format}' format.");
            }
        }

        SearchIndex IPersistableModel<SearchIndex>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SearchIndex>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSearchIndex(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(SearchIndex)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SearchIndex>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
