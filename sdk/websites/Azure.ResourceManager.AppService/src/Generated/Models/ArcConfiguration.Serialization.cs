// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class ArcConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ArtifactsStorageType))
            {
                writer.WritePropertyName("artifactsStorageType");
                writer.WriteStringValue(ArtifactsStorageType.Value.ToSerialString());
            }
            if (Optional.IsDefined(ArtifactStorageClassName))
            {
                writer.WritePropertyName("artifactStorageClassName");
                writer.WriteStringValue(ArtifactStorageClassName);
            }
            if (Optional.IsDefined(ArtifactStorageMountPath))
            {
                writer.WritePropertyName("artifactStorageMountPath");
                writer.WriteStringValue(ArtifactStorageMountPath);
            }
            if (Optional.IsDefined(ArtifactStorageNodeName))
            {
                writer.WritePropertyName("artifactStorageNodeName");
                writer.WriteStringValue(ArtifactStorageNodeName);
            }
            if (Optional.IsDefined(ArtifactStorageAccessMode))
            {
                writer.WritePropertyName("artifactStorageAccessMode");
                writer.WriteStringValue(ArtifactStorageAccessMode);
            }
            if (Optional.IsDefined(FrontEndServiceConfiguration))
            {
                writer.WritePropertyName("frontEndServiceConfiguration");
                writer.WriteObjectValue(FrontEndServiceConfiguration);
            }
            if (Optional.IsDefined(KubeConfig))
            {
                writer.WritePropertyName("kubeConfig");
                writer.WriteStringValue(KubeConfig);
            }
            writer.WriteEndObject();
        }

        internal static ArcConfiguration DeserializeArcConfiguration(JsonElement element)
        {
            Optional<ArtifactStorageType> artifactsStorageType = default;
            Optional<string> artifactStorageClassName = default;
            Optional<string> artifactStorageMountPath = default;
            Optional<string> artifactStorageNodeName = default;
            Optional<string> artifactStorageAccessMode = default;
            Optional<FrontEndConfiguration> frontEndServiceConfiguration = default;
            Optional<string> kubeConfig = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("artifactsStorageType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    artifactsStorageType = property.Value.GetString().ToArtifactStorageType();
                    continue;
                }
                if (property.NameEquals("artifactStorageClassName"))
                {
                    artifactStorageClassName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("artifactStorageMountPath"))
                {
                    artifactStorageMountPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("artifactStorageNodeName"))
                {
                    artifactStorageNodeName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("artifactStorageAccessMode"))
                {
                    artifactStorageAccessMode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("frontEndServiceConfiguration"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    frontEndServiceConfiguration = FrontEndConfiguration.DeserializeFrontEndConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("kubeConfig"))
                {
                    kubeConfig = property.Value.GetString();
                    continue;
                }
            }
            return new ArcConfiguration(Optional.ToNullable(artifactsStorageType), artifactStorageClassName.Value, artifactStorageMountPath.Value, artifactStorageNodeName.Value, artifactStorageAccessMode.Value, frontEndServiceConfiguration.Value, kubeConfig.Value);
        }
    }
}
