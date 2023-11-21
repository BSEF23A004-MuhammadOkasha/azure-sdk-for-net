// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class RestorableSqlDatabasePropertiesResourceDatabase : IUtf8JsonSerializable, IJsonModel<RestorableSqlDatabasePropertiesResourceDatabase>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RestorableSqlDatabasePropertiesResourceDatabase>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RestorableSqlDatabasePropertiesResourceDatabase>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RestorableSqlDatabasePropertiesResourceDatabase>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(RestorableSqlDatabasePropertiesResourceDatabase)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Colls))
            {
                writer.WritePropertyName("_colls"u8);
                writer.WriteStringValue(Colls);
            }
            if (options.Format != "W" && Optional.IsDefined(Users))
            {
                writer.WritePropertyName("_users"u8);
                writer.WriteStringValue(Users);
            }
            if (options.Format != "W" && Optional.IsDefined(Self))
            {
                writer.WritePropertyName("_self"u8);
                writer.WriteStringValue(Self);
            }
            if (options.Format != "W" && Optional.IsDefined(Rid))
            {
                writer.WritePropertyName("_rid"u8);
                writer.WriteStringValue(Rid);
            }
            if (options.Format != "W" && Optional.IsDefined(Timestamp))
            {
                writer.WritePropertyName("_ts"u8);
                writer.WriteNumberValue(Timestamp.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("_etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(DatabaseName);
            if (Optional.IsDefined(RestoreParameters))
            {
                writer.WritePropertyName("restoreParameters"u8);
                writer.WriteObjectValue(RestoreParameters);
            }
            if (Optional.IsDefined(CreateMode))
            {
                writer.WritePropertyName("createMode"u8);
                writer.WriteStringValue(CreateMode.Value.ToString());
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

        RestorableSqlDatabasePropertiesResourceDatabase IJsonModel<RestorableSqlDatabasePropertiesResourceDatabase>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RestorableSqlDatabasePropertiesResourceDatabase>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(RestorableSqlDatabasePropertiesResourceDatabase)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRestorableSqlDatabasePropertiesResourceDatabase(document.RootElement, options);
        }

        internal static RestorableSqlDatabasePropertiesResourceDatabase DeserializeRestorableSqlDatabasePropertiesResourceDatabase(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> colls = default;
            Optional<string> users = default;
            Optional<string> self = default;
            Optional<string> rid = default;
            Optional<float> ts = default;
            Optional<ETag> etag = default;
            string id = default;
            Optional<ResourceRestoreParameters> restoreParameters = default;
            Optional<CosmosDBAccountCreateMode> createMode = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("_colls"u8))
                {
                    colls = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("_users"u8))
                {
                    users = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("_self"u8))
                {
                    self = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("_rid"u8))
                {
                    rid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("_ts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ts = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("_etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("restoreParameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    restoreParameters = ResourceRestoreParameters.DeserializeResourceRestoreParameters(property.Value);
                    continue;
                }
                if (property.NameEquals("createMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createMode = new CosmosDBAccountCreateMode(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RestorableSqlDatabasePropertiesResourceDatabase(id, restoreParameters.Value, Optional.ToNullable(createMode), serializedAdditionalRawData, colls.Value, users.Value, self.Value, rid.Value, Optional.ToNullable(ts), Optional.ToNullable(etag));
        }

        BinaryData IPersistableModel<RestorableSqlDatabasePropertiesResourceDatabase>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RestorableSqlDatabasePropertiesResourceDatabase>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(RestorableSqlDatabasePropertiesResourceDatabase)} does not support '{options.Format}' format.");
            }
        }

        RestorableSqlDatabasePropertiesResourceDatabase IPersistableModel<RestorableSqlDatabasePropertiesResourceDatabase>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RestorableSqlDatabasePropertiesResourceDatabase>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRestorableSqlDatabasePropertiesResourceDatabase(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(RestorableSqlDatabasePropertiesResourceDatabase)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RestorableSqlDatabasePropertiesResourceDatabase>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
