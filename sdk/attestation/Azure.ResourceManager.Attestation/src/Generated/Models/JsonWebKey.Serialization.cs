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

namespace Azure.ResourceManager.Attestation.Models
{
    public partial class JsonWebKey : IUtf8JsonSerializable, IJsonModel<JsonWebKey>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<JsonWebKey>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<JsonWebKey>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JsonWebKey>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(JsonWebKey)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Alg))
            {
                writer.WritePropertyName("alg"u8);
                writer.WriteStringValue(Alg);
            }
            if (Optional.IsDefined(Crv))
            {
                writer.WritePropertyName("crv"u8);
                writer.WriteStringValue(Crv);
            }
            if (Optional.IsDefined(D))
            {
                writer.WritePropertyName("d"u8);
                writer.WriteStringValue(D);
            }
            if (Optional.IsDefined(Dp))
            {
                writer.WritePropertyName("dp"u8);
                writer.WriteStringValue(Dp);
            }
            if (Optional.IsDefined(Dq))
            {
                writer.WritePropertyName("dq"u8);
                writer.WriteStringValue(Dq);
            }
            if (Optional.IsDefined(E))
            {
                writer.WritePropertyName("e"u8);
                writer.WriteStringValue(E);
            }
            if (Optional.IsDefined(K))
            {
                writer.WritePropertyName("k"u8);
                writer.WriteStringValue(K);
            }
            if (Optional.IsDefined(Kid))
            {
                writer.WritePropertyName("kid"u8);
                writer.WriteStringValue(Kid);
            }
            writer.WritePropertyName("kty"u8);
            writer.WriteStringValue(Kty);
            if (Optional.IsDefined(N))
            {
                writer.WritePropertyName("n"u8);
                writer.WriteStringValue(N);
            }
            if (Optional.IsDefined(P))
            {
                writer.WritePropertyName("p"u8);
                writer.WriteStringValue(P);
            }
            if (Optional.IsDefined(Q))
            {
                writer.WritePropertyName("q"u8);
                writer.WriteStringValue(Q);
            }
            if (Optional.IsDefined(Qi))
            {
                writer.WritePropertyName("qi"u8);
                writer.WriteStringValue(Qi);
            }
            if (Optional.IsDefined(Use))
            {
                writer.WritePropertyName("use"u8);
                writer.WriteStringValue(Use);
            }
            if (Optional.IsDefined(X))
            {
                writer.WritePropertyName("x"u8);
                writer.WriteStringValue(X);
            }
            if (Optional.IsCollectionDefined(X5C))
            {
                writer.WritePropertyName("x5c"u8);
                writer.WriteStartArray();
                foreach (var item in X5C)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Y))
            {
                writer.WritePropertyName("y"u8);
                writer.WriteStringValue(Y);
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

        JsonWebKey IJsonModel<JsonWebKey>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JsonWebKey>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(JsonWebKey)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeJsonWebKey(document.RootElement, options);
        }

        internal static JsonWebKey DeserializeJsonWebKey(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> alg = default;
            Optional<string> crv = default;
            Optional<string> d = default;
            Optional<string> dp = default;
            Optional<string> dq = default;
            Optional<string> e = default;
            Optional<string> k = default;
            Optional<string> kid = default;
            string kty = default;
            Optional<string> n = default;
            Optional<string> p = default;
            Optional<string> q = default;
            Optional<string> qi = default;
            Optional<string> use = default;
            Optional<string> x = default;
            Optional<IList<string>> x5c = default;
            Optional<string> y = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("alg"u8))
                {
                    alg = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("crv"u8))
                {
                    crv = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("d"u8))
                {
                    d = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dp"u8))
                {
                    dp = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dq"u8))
                {
                    dq = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("e"u8))
                {
                    e = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("k"u8))
                {
                    k = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kid"u8))
                {
                    kid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kty"u8))
                {
                    kty = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("n"u8))
                {
                    n = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("p"u8))
                {
                    p = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("q"u8))
                {
                    q = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("qi"u8))
                {
                    qi = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("use"u8))
                {
                    use = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("x"u8))
                {
                    x = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("x5c"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    x5c = array;
                    continue;
                }
                if (property.NameEquals("y"u8))
                {
                    y = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new JsonWebKey(alg.Value, crv.Value, d.Value, dp.Value, dq.Value, e.Value, k.Value, kid.Value, kty, n.Value, p.Value, q.Value, qi.Value, use.Value, x.Value, Optional.ToList(x5c), y.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<JsonWebKey>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JsonWebKey>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(JsonWebKey)} does not support '{options.Format}' format.");
            }
        }

        JsonWebKey IPersistableModel<JsonWebKey>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JsonWebKey>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeJsonWebKey(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(JsonWebKey)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<JsonWebKey>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
