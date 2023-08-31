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

namespace Azure.ResourceManager.DevTestLabs.Models
{
    public partial class DevTestLabArtifactInstallInfo : IUtf8JsonSerializable, IModelJsonSerializable<DevTestLabArtifactInstallInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DevTestLabArtifactInstallInfo>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DevTestLabArtifactInstallInfo>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ArtifactId))
            {
                writer.WritePropertyName("artifactId"u8);
                writer.WriteStringValue(ArtifactId);
            }
            if (Optional.IsDefined(ArtifactTitle))
            {
                writer.WritePropertyName("artifactTitle"u8);
                writer.WriteStringValue(ArtifactTitle);
            }
            if (Optional.IsCollectionDefined(Parameters))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteStartArray();
                foreach (var item in Parameters)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<DevTestLabArtifactParameter>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status);
            }
            if (Optional.IsDefined(DeploymentStatusMessage))
            {
                writer.WritePropertyName("deploymentStatusMessage"u8);
                writer.WriteStringValue(DeploymentStatusMessage);
            }
            if (Optional.IsDefined(VmExtensionStatusMessage))
            {
                writer.WritePropertyName("vmExtensionStatusMessage"u8);
                writer.WriteStringValue(VmExtensionStatusMessage);
            }
            if (Optional.IsDefined(InstallOn))
            {
                writer.WritePropertyName("installTime"u8);
                writer.WriteStringValue(InstallOn.Value, "O");
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

        internal static DevTestLabArtifactInstallInfo DeserializeDevTestLabArtifactInstallInfo(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> artifactId = default;
            Optional<string> artifactTitle = default;
            Optional<IList<DevTestLabArtifactParameter>> parameters = default;
            Optional<string> status = default;
            Optional<string> deploymentStatusMessage = default;
            Optional<string> vmExtensionStatusMessage = default;
            Optional<DateTimeOffset> installTime = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("artifactId"u8))
                {
                    artifactId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("artifactTitle"u8))
                {
                    artifactTitle = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DevTestLabArtifactParameter> array = new List<DevTestLabArtifactParameter>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DevTestLabArtifactParameter.DeserializeDevTestLabArtifactParameter(item));
                    }
                    parameters = array;
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deploymentStatusMessage"u8))
                {
                    deploymentStatusMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vmExtensionStatusMessage"u8))
                {
                    vmExtensionStatusMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("installTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    installTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DevTestLabArtifactInstallInfo(artifactId.Value, artifactTitle.Value, Optional.ToList(parameters), status.Value, deploymentStatusMessage.Value, vmExtensionStatusMessage.Value, Optional.ToNullable(installTime), rawData);
        }

        DevTestLabArtifactInstallInfo IModelJsonSerializable<DevTestLabArtifactInstallInfo>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDevTestLabArtifactInstallInfo(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DevTestLabArtifactInstallInfo>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DevTestLabArtifactInstallInfo IModelSerializable<DevTestLabArtifactInstallInfo>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDevTestLabArtifactInstallInfo(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DevTestLabArtifactInstallInfo"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DevTestLabArtifactInstallInfo"/> to convert. </param>
        public static implicit operator RequestContent(DevTestLabArtifactInstallInfo model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DevTestLabArtifactInstallInfo"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DevTestLabArtifactInstallInfo(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDevTestLabArtifactInstallInfo(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
