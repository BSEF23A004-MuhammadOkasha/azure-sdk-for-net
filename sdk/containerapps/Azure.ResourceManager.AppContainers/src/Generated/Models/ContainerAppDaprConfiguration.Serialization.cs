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

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class ContainerAppDaprConfiguration : IUtf8JsonSerializable, IModelJsonSerializable<ContainerAppDaprConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ContainerAppDaprConfiguration>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ContainerAppDaprConfiguration>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContainerAppDaprConfiguration>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (Optional.IsDefined(AppId))
            {
                writer.WritePropertyName("appId"u8);
                writer.WriteStringValue(AppId);
            }
            if (Optional.IsDefined(AppProtocol))
            {
                writer.WritePropertyName("appProtocol"u8);
                writer.WriteStringValue(AppProtocol.Value.ToString());
            }
            if (Optional.IsDefined(AppPort))
            {
                writer.WritePropertyName("appPort"u8);
                writer.WriteNumberValue(AppPort.Value);
            }
            if (Optional.IsDefined(HttpReadBufferSize))
            {
                writer.WritePropertyName("httpReadBufferSize"u8);
                writer.WriteNumberValue(HttpReadBufferSize.Value);
            }
            if (Optional.IsDefined(HttpMaxRequestSize))
            {
                writer.WritePropertyName("httpMaxRequestSize"u8);
                writer.WriteNumberValue(HttpMaxRequestSize.Value);
            }
            if (Optional.IsDefined(LogLevel))
            {
                writer.WritePropertyName("logLevel"u8);
                writer.WriteStringValue(LogLevel.Value.ToString());
            }
            if (Optional.IsDefined(IsApiLoggingEnabled))
            {
                writer.WritePropertyName("enableApiLogging"u8);
                writer.WriteBooleanValue(IsApiLoggingEnabled.Value);
            }
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

        internal static ContainerAppDaprConfiguration DeserializeContainerAppDaprConfiguration(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> enabled = default;
            Optional<string> appId = default;
            Optional<ContainerAppProtocol> appProtocol = default;
            Optional<int> appPort = default;
            Optional<int> httpReadBufferSize = default;
            Optional<int> httpMaxRequestSize = default;
            Optional<ContainerAppDaprLogLevel> logLevel = default;
            Optional<bool> enableApiLogging = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("appId"u8))
                {
                    appId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("appProtocol"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    appProtocol = new ContainerAppProtocol(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("appPort"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    appPort = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("httpReadBufferSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    httpReadBufferSize = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("httpMaxRequestSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    httpMaxRequestSize = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("logLevel"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    logLevel = new ContainerAppDaprLogLevel(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("enableApiLogging"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableApiLogging = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ContainerAppDaprConfiguration(Optional.ToNullable(enabled), appId.Value, Optional.ToNullable(appProtocol), Optional.ToNullable(appPort), Optional.ToNullable(httpReadBufferSize), Optional.ToNullable(httpMaxRequestSize), Optional.ToNullable(logLevel), Optional.ToNullable(enableApiLogging), rawData);
        }

        ContainerAppDaprConfiguration IModelJsonSerializable<ContainerAppDaprConfiguration>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContainerAppDaprConfiguration>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerAppDaprConfiguration(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ContainerAppDaprConfiguration>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContainerAppDaprConfiguration>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ContainerAppDaprConfiguration IModelSerializable<ContainerAppDaprConfiguration>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContainerAppDaprConfiguration>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeContainerAppDaprConfiguration(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ContainerAppDaprConfiguration"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ContainerAppDaprConfiguration"/> to convert. </param>
        public static implicit operator RequestContent(ContainerAppDaprConfiguration model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ContainerAppDaprConfiguration"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ContainerAppDaprConfiguration(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeContainerAppDaprConfiguration(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
