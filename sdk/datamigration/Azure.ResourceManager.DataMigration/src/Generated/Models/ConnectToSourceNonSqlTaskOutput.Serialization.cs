// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class ConnectToSourceNonSqlTaskOutput : IUtf8JsonSerializable, IModelJsonSerializable<ConnectToSourceNonSqlTaskOutput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ConnectToSourceNonSqlTaskOutput>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ConnectToSourceNonSqlTaskOutput>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ConnectToSourceNonSqlTaskOutput>(this, options.Format);

            writer.WriteStartObject();
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static ConnectToSourceNonSqlTaskOutput DeserializeConnectToSourceNonSqlTaskOutput(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> id = default;
            Optional<string> sourceServerBrandVersion = default;
            Optional<ServerProperties> serverProperties = default;
            Optional<IReadOnlyList<string>> databases = default;
            Optional<IReadOnlyList<ReportableException>> validationErrors = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceServerBrandVersion"u8))
                {
                    sourceServerBrandVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serverProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    serverProperties = ServerProperties.DeserializeServerProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("databases"u8))
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
                    databases = array;
                    continue;
                }
                if (property.NameEquals("validationErrors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ReportableException> array = new List<ReportableException>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ReportableException.DeserializeReportableException(item));
                    }
                    validationErrors = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ConnectToSourceNonSqlTaskOutput(id.Value, sourceServerBrandVersion.Value, serverProperties.Value, Optional.ToList(databases), Optional.ToList(validationErrors), rawData);
        }

        ConnectToSourceNonSqlTaskOutput IModelJsonSerializable<ConnectToSourceNonSqlTaskOutput>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ConnectToSourceNonSqlTaskOutput>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeConnectToSourceNonSqlTaskOutput(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ConnectToSourceNonSqlTaskOutput>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ConnectToSourceNonSqlTaskOutput>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ConnectToSourceNonSqlTaskOutput IModelSerializable<ConnectToSourceNonSqlTaskOutput>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ConnectToSourceNonSqlTaskOutput>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeConnectToSourceNonSqlTaskOutput(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ConnectToSourceNonSqlTaskOutput"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ConnectToSourceNonSqlTaskOutput"/> to convert. </param>
        public static implicit operator RequestContent(ConnectToSourceNonSqlTaskOutput model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ConnectToSourceNonSqlTaskOutput"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ConnectToSourceNonSqlTaskOutput(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeConnectToSourceNonSqlTaskOutput(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
