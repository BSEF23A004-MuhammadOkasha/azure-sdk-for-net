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
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Redis.Models
{
    public partial class RedisPatch : IUtf8JsonSerializable, IJsonModel<RedisPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RedisPatch>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<RedisPatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                JsonSerializer.Serialize(writer, Identity);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(RedisConfiguration))
            {
                writer.WritePropertyName("redisConfiguration"u8);
                writer.WriteObjectValue(RedisConfiguration);
            }
            if (Optional.IsDefined(RedisVersion))
            {
                writer.WritePropertyName("redisVersion"u8);
                writer.WriteStringValue(RedisVersion);
            }
            if (Optional.IsDefined(EnableNonSslPort))
            {
                writer.WritePropertyName("enableNonSslPort"u8);
                writer.WriteBooleanValue(EnableNonSslPort.Value);
            }
            if (Optional.IsDefined(ReplicasPerMaster))
            {
                writer.WritePropertyName("replicasPerMaster"u8);
                writer.WriteNumberValue(ReplicasPerMaster.Value);
            }
            if (Optional.IsDefined(ReplicasPerPrimary))
            {
                writer.WritePropertyName("replicasPerPrimary"u8);
                writer.WriteNumberValue(ReplicasPerPrimary.Value);
            }
            if (Optional.IsCollectionDefined(TenantSettings))
            {
                writer.WritePropertyName("tenantSettings"u8);
                writer.WriteStartObject();
                foreach (var item in TenantSettings)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(ShardCount))
            {
                writer.WritePropertyName("shardCount"u8);
                writer.WriteNumberValue(ShardCount.Value);
            }
            if (Optional.IsDefined(MinimumTlsVersion))
            {
                writer.WritePropertyName("minimumTlsVersion"u8);
                writer.WriteStringValue(MinimumTlsVersion.Value.ToString());
            }
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess"u8);
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
            }
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteObjectValue(Sku);
            }
            writer.WriteEndObject();
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

        RedisPatch IJsonModel<RedisPatch>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RedisPatch)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRedisPatch(document.RootElement, options);
        }

        internal static RedisPatch DeserializeRedisPatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> tags = default;
            Optional<ManagedServiceIdentity> identity = default;
            Optional<RedisCommonConfiguration> redisConfiguration = default;
            Optional<string> redisVersion = default;
            Optional<bool> enableNonSslPort = default;
            Optional<int> replicasPerMaster = default;
            Optional<int> replicasPerPrimary = default;
            Optional<IDictionary<string, string>> tenantSettings = default;
            Optional<int> shardCount = default;
            Optional<RedisTlsVersion> minimumTlsVersion = default;
            Optional<RedisPublicNetworkAccess> publicNetworkAccess = default;
            Optional<RedisSku> sku = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("redisConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            redisConfiguration = RedisCommonConfiguration.DeserializeRedisCommonConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("redisVersion"u8))
                        {
                            redisVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("enableNonSslPort"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableNonSslPort = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("replicasPerMaster"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            replicasPerMaster = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("replicasPerPrimary"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            replicasPerPrimary = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("tenantSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            tenantSettings = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("shardCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            shardCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("minimumTlsVersion"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            minimumTlsVersion = new RedisTlsVersion(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("publicNetworkAccess"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            publicNetworkAccess = new RedisPublicNetworkAccess(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("sku"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sku = RedisSku.DeserializeRedisSku(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RedisPatch(Optional.ToDictionary(tags), identity, redisConfiguration.Value, redisVersion.Value, Optional.ToNullable(enableNonSslPort), Optional.ToNullable(replicasPerMaster), Optional.ToNullable(replicasPerPrimary), Optional.ToDictionary(tenantSettings), Optional.ToNullable(shardCount), Optional.ToNullable(minimumTlsVersion), Optional.ToNullable(publicNetworkAccess), sku.Value, serializedAdditionalRawData);
        }

        BinaryData IModel<RedisPatch>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RedisPatch)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        RedisPatch IModel<RedisPatch>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RedisPatch)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeRedisPatch(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<RedisPatch>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
