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

namespace Azure.Search.Documents.Models
{
    internal partial class SearchResult : IUtf8JsonSerializable, IJsonModel<SearchResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SearchResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SearchResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SearchResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(SearchResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("@search.score"u8);
                writer.WriteNumberValue(Score);
            }
            if (options.Format != "W" && Optional.IsDefined(RerankerScore))
            {
                if (RerankerScore != null)
                {
                    writer.WritePropertyName("@search.rerankerScore"u8);
                    writer.WriteNumberValue(RerankerScore.Value);
                }
                else
                {
                    writer.WriteNull("@search.rerankerScore");
                }
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Highlights))
            {
                writer.WritePropertyName("@search.highlights"u8);
                writer.WriteStartObject();
                foreach (var item in Highlights)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStartArray();
                    foreach (var item0 in item.Value)
                    {
                        writer.WriteStringValue(item0);
                    }
                    writer.WriteEndArray();
                }
                writer.WriteEndObject();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Captions))
            {
                if (Captions != null)
                {
                    writer.WritePropertyName("@search.captions"u8);
                    writer.WriteStartArray();
                    foreach (var item in Captions)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("@search.captions");
                }
            }
            if (AdditionalProperties != null)
            {
                foreach (var item in AdditionalProperties)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
            }
            writer.WriteEndObject();
        }

        SearchResult IJsonModel<SearchResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SearchResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(SearchResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSearchResult(document.RootElement, options);
        }

        internal static SearchResult DeserializeSearchResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            double searchScore = default;
            Optional<double?> searchRerankerScore = default;
            Optional<IReadOnlyDictionary<string, IList<string>>> searchHighlights = default;
            Optional<IReadOnlyList<QueryCaptionResult>> searchCaptions = default;
            IReadOnlyDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("@search.score"u8))
                {
                    searchScore = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("@search.rerankerScore"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        searchRerankerScore = null;
                        continue;
                    }
                    searchRerankerScore = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("@search.highlights"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, IList<string>> dictionary = new Dictionary<string, IList<string>>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            dictionary.Add(property0.Name, array);
                        }
                    }
                    searchHighlights = dictionary;
                    continue;
                }
                if (property.NameEquals("@search.captions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        searchCaptions = null;
                        continue;
                    }
                    List<QueryCaptionResult> array = new List<QueryCaptionResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(QueryCaptionResult.DeserializeQueryCaptionResult(item));
                    }
                    searchCaptions = array;
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new SearchResult(searchScore, Optional.ToNullable(searchRerankerScore), Optional.ToDictionary(searchHighlights), Optional.ToList(searchCaptions), additionalProperties);
        }

        BinaryData IPersistableModel<SearchResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SearchResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(SearchResult)} does not support '{options.Format}' format.");
            }
        }

        SearchResult IPersistableModel<SearchResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SearchResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSearchResult(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(SearchResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SearchResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
