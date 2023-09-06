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

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class SelfHostedIntegrationRuntimeStatus : IUtf8JsonSerializable, IModelJsonSerializable<SelfHostedIntegrationRuntimeStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SelfHostedIntegrationRuntimeStatus>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SelfHostedIntegrationRuntimeStatus>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SelfHostedIntegrationRuntimeStatus>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(RuntimeType.ToString());
            writer.WritePropertyName("typeProperties"u8);
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Nodes))
            {
                writer.WritePropertyName("nodes"u8);
                writer.WriteStartArray();
                foreach (var item in Nodes)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<SelfHostedIntegrationRuntimeNode>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Links))
            {
                writer.WritePropertyName("links"u8);
                writer.WriteStartArray();
                foreach (var item in Links)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<LinkedIntegrationRuntime>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(item.Value.ToString()).RootElement);
#endif
            }
            writer.WriteEndObject();
        }

        internal static SelfHostedIntegrationRuntimeStatus DeserializeSelfHostedIntegrationRuntimeStatus(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IntegrationRuntimeType type = default;
            Optional<string> dataFactoryName = default;
            Optional<IntegrationRuntimeState> state = default;
            Optional<DateTimeOffset> createTime = default;
            Optional<Guid> taskQueueId = default;
            Optional<IntegrationRuntimeInternalChannelEncryptionMode> internalChannelEncryption = default;
            Optional<string> version = default;
            Optional<IReadOnlyList<SelfHostedIntegrationRuntimeNode>> nodes = default;
            Optional<DateTimeOffset> scheduledUpdateDate = default;
            Optional<TimeSpan> updateDelayOffset = default;
            Optional<TimeSpan> localTimeZoneOffset = default;
            Optional<IReadOnlyDictionary<string, string>> capabilities = default;
            Optional<IReadOnlyList<string>> serviceUrls = default;
            Optional<IntegrationRuntimeAutoUpdateState> autoUpdate = default;
            Optional<string> versionStatus = default;
            Optional<IReadOnlyList<LinkedIntegrationRuntime>> links = default;
            Optional<string> pushedVersion = default;
            Optional<string> latestVersion = default;
            Optional<DateTimeOffset> autoUpdateEta = default;
            IReadOnlyDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = new IntegrationRuntimeType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dataFactoryName"u8))
                {
                    dataFactoryName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new IntegrationRuntimeState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("typeProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("createTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("taskQueueId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            taskQueueId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("internalChannelEncryption"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            internalChannelEncryption = new IntegrationRuntimeInternalChannelEncryptionMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("version"u8))
                        {
                            version = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("nodes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SelfHostedIntegrationRuntimeNode> array = new List<SelfHostedIntegrationRuntimeNode>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SelfHostedIntegrationRuntimeNode.DeserializeSelfHostedIntegrationRuntimeNode(item));
                            }
                            nodes = array;
                            continue;
                        }
                        if (property0.NameEquals("scheduledUpdateDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            scheduledUpdateDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("updateDelayOffset"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            updateDelayOffset = property0.Value.GetTimeSpan("P");
                            continue;
                        }
                        if (property0.NameEquals("localTimeZoneOffset"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            localTimeZoneOffset = property0.Value.GetTimeSpan("P");
                            continue;
                        }
                        if (property0.NameEquals("capabilities"u8))
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
                            capabilities = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("serviceUrls"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            serviceUrls = array;
                            continue;
                        }
                        if (property0.NameEquals("autoUpdate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            autoUpdate = new IntegrationRuntimeAutoUpdateState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("versionStatus"u8))
                        {
                            versionStatus = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("links"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<LinkedIntegrationRuntime> array = new List<LinkedIntegrationRuntime>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(LinkedIntegrationRuntime.DeserializeLinkedIntegrationRuntime(item));
                            }
                            links = array;
                            continue;
                        }
                        if (property0.NameEquals("pushedVersion"u8))
                        {
                            pushedVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("latestVersion"u8))
                        {
                            latestVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("autoUpdateETA"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            autoUpdateEta = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new SelfHostedIntegrationRuntimeStatus(type, dataFactoryName.Value, Optional.ToNullable(state), additionalProperties, Optional.ToNullable(createTime), Optional.ToNullable(taskQueueId), Optional.ToNullable(internalChannelEncryption), version.Value, Optional.ToList(nodes), Optional.ToNullable(scheduledUpdateDate), Optional.ToNullable(updateDelayOffset), Optional.ToNullable(localTimeZoneOffset), Optional.ToDictionary(capabilities), Optional.ToList(serviceUrls), Optional.ToNullable(autoUpdate), versionStatus.Value, Optional.ToList(links), pushedVersion.Value, latestVersion.Value, Optional.ToNullable(autoUpdateEta));
        }

        SelfHostedIntegrationRuntimeStatus IModelJsonSerializable<SelfHostedIntegrationRuntimeStatus>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SelfHostedIntegrationRuntimeStatus>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSelfHostedIntegrationRuntimeStatus(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SelfHostedIntegrationRuntimeStatus>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SelfHostedIntegrationRuntimeStatus>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SelfHostedIntegrationRuntimeStatus IModelSerializable<SelfHostedIntegrationRuntimeStatus>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SelfHostedIntegrationRuntimeStatus>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSelfHostedIntegrationRuntimeStatus(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SelfHostedIntegrationRuntimeStatus"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SelfHostedIntegrationRuntimeStatus"/> to convert. </param>
        public static implicit operator RequestContent(SelfHostedIntegrationRuntimeStatus model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SelfHostedIntegrationRuntimeStatus"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SelfHostedIntegrationRuntimeStatus(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSelfHostedIntegrationRuntimeStatus(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
