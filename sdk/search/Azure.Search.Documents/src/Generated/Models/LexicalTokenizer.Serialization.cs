// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class LexicalTokenizer : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(ODataType);
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WriteEndObject();
        }

        internal static LexicalTokenizer DeserializeLexicalTokenizer(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("@odata.type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "#Microsoft.Azure.Search.ClassicTokenizer": return ClassicTokenizer.DeserializeClassicTokenizer(element);
                    case "#Microsoft.Azure.Search.EdgeNGramTokenizer": return EdgeNGramTokenizer.DeserializeEdgeNGramTokenizer(element);
                    case "#Microsoft.Azure.Search.KeywordTokenizer": return KeywordTokenizer.DeserializeKeywordTokenizer(element);
                    case "#Microsoft.Azure.Search.KeywordTokenizerV2": return KeywordTokenizer.DeserializeKeywordTokenizer(element);
                    case "#Microsoft.Azure.Search.MicrosoftLanguageStemmingTokenizer": return MicrosoftLanguageStemmingTokenizer.DeserializeMicrosoftLanguageStemmingTokenizer(element);
                    case "#Microsoft.Azure.Search.MicrosoftLanguageTokenizer": return MicrosoftLanguageTokenizer.DeserializeMicrosoftLanguageTokenizer(element);
                    case "#Microsoft.Azure.Search.NGramTokenizer": return NGramTokenizer.DeserializeNGramTokenizer(element);
                    case "#Microsoft.Azure.Search.PathHierarchyTokenizerV2": return PathHierarchyTokenizer.DeserializePathHierarchyTokenizer(element);
                    case "#Microsoft.Azure.Search.PatternTokenizer": return PatternTokenizer.DeserializePatternTokenizer(element);
                    case "#Microsoft.Azure.Search.StandardTokenizer": return LuceneStandardTokenizer.DeserializeLuceneStandardTokenizer(element);
                    case "#Microsoft.Azure.Search.StandardTokenizerV2": return LuceneStandardTokenizer.DeserializeLuceneStandardTokenizer(element);
                    case "#Microsoft.Azure.Search.UaxUrlEmailTokenizer": return UaxUrlEmailTokenizer.DeserializeUaxUrlEmailTokenizer(element);
                }
            }
            return UnknownLexicalTokenizer.DeserializeUnknownLexicalTokenizer(element);
        }
    }
}
