// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningWorkspacePatch : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku");
                writer.WriteObjectValue(Sku);
            }
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity");
                var serializeOptions = new JsonSerializerOptions { Converters = { new ManagedServiceIdentityTypeV3Converter() } };
                JsonSerializer.Serialize(writer, Identity, serializeOptions);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(FriendlyName))
            {
                writer.WritePropertyName("friendlyName");
                writer.WriteStringValue(FriendlyName);
            }
            if (Optional.IsDefined(ImageBuildCompute))
            {
                writer.WritePropertyName("imageBuildCompute");
                writer.WriteStringValue(ImageBuildCompute);
            }
            if (Optional.IsDefined(ServiceManagedResourcesSettings))
            {
                writer.WritePropertyName("serviceManagedResourcesSettings");
                writer.WriteObjectValue(ServiceManagedResourcesSettings);
            }
            if (Optional.IsDefined(PrimaryUserAssignedIdentity))
            {
                writer.WritePropertyName("primaryUserAssignedIdentity");
                writer.WriteStringValue(PrimaryUserAssignedIdentity);
            }
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess");
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
            }
            if (Optional.IsDefined(ApplicationInsights))
            {
                writer.WritePropertyName("applicationInsights");
                writer.WriteStringValue(ApplicationInsights);
            }
            if (Optional.IsDefined(ContainerRegistry))
            {
                writer.WritePropertyName("containerRegistry");
                writer.WriteStringValue(ContainerRegistry);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}
