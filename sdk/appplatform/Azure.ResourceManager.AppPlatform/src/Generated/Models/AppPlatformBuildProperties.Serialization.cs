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
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class AppPlatformBuildProperties : IUtf8JsonSerializable, IJsonModel<AppPlatformBuildProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppPlatformBuildProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AppPlatformBuildProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformBuildProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(AppPlatformBuildProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(RelativePath))
            {
                writer.WritePropertyName("relativePath"u8);
                writer.WriteStringValue(RelativePath);
            }
            if (Optional.IsDefined(Builder))
            {
                writer.WritePropertyName("builder"u8);
                writer.WriteStringValue(Builder);
            }
            if (Optional.IsDefined(AgentPool))
            {
                writer.WritePropertyName("agentPool"u8);
                writer.WriteStringValue(AgentPool);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Env))
            {
                writer.WritePropertyName("env"u8);
                writer.WriteStartObject();
                foreach (var item in Env)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (options.Format != "W" && Optional.IsDefined(TriggeredBuildResult))
            {
                writer.WritePropertyName("triggeredBuildResult"u8);
                JsonSerializer.Serialize(writer, TriggeredBuildResult);
            }
            if (Optional.IsDefined(ResourceRequests))
            {
                writer.WritePropertyName("resourceRequests"u8);
                writer.WriteObjectValue(ResourceRequests);
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

        AppPlatformBuildProperties IJsonModel<AppPlatformBuildProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformBuildProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(AppPlatformBuildProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppPlatformBuildProperties(document.RootElement, options);
        }

        internal static AppPlatformBuildProperties DeserializeAppPlatformBuildProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> relativePath = default;
            Optional<string> builder = default;
            Optional<string> agentPool = default;
            Optional<AppPlatformBuildProvisioningState> provisioningState = default;
            Optional<IDictionary<string, string>> env = default;
            Optional<SubResource> triggeredBuildResult = default;
            Optional<AppPlatformBuildResourceRequirements> resourceRequests = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("relativePath"u8))
                {
                    relativePath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("builder"u8))
                {
                    builder = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("agentPool"u8))
                {
                    agentPool = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new AppPlatformBuildProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("env"u8))
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
                    env = dictionary;
                    continue;
                }
                if (property.NameEquals("triggeredBuildResult"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    triggeredBuildResult = JsonSerializer.Deserialize<SubResource>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("resourceRequests"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceRequests = AppPlatformBuildResourceRequirements.DeserializeAppPlatformBuildResourceRequirements(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AppPlatformBuildProperties(relativePath.Value, builder.Value, agentPool.Value, Optional.ToNullable(provisioningState), Optional.ToDictionary(env), triggeredBuildResult, resourceRequests.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AppPlatformBuildProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformBuildProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(AppPlatformBuildProperties)} does not support '{options.Format}' format.");
            }
        }

        AppPlatformBuildProperties IPersistableModel<AppPlatformBuildProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformBuildProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAppPlatformBuildProperties(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(AppPlatformBuildProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AppPlatformBuildProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
