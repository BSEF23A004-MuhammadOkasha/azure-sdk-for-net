// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IotHub.Models
{
    public partial class ExportDevicesContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("exportBlobContainerUri");
            writer.WriteStringValue(ExportBlobContainerUri.AbsoluteUri);
            writer.WritePropertyName("excludeKeys");
            writer.WriteBooleanValue(ExcludeKeys);
            if (Optional.IsDefined(ExportBlobName))
            {
                writer.WritePropertyName("exportBlobName");
                writer.WriteStringValue(ExportBlobName);
            }
            if (Optional.IsDefined(AuthenticationType))
            {
                writer.WritePropertyName("authenticationType");
                writer.WriteStringValue(AuthenticationType.Value.ToString());
            }
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity");
                writer.WriteObjectValue(Identity);
            }
            if (Optional.IsDefined(IncludeConfigurations))
            {
                writer.WritePropertyName("includeConfigurations");
                writer.WriteBooleanValue(IncludeConfigurations.Value);
            }
            if (Optional.IsDefined(ConfigurationsBlobName))
            {
                writer.WritePropertyName("configurationsBlobName");
                writer.WriteStringValue(ConfigurationsBlobName);
            }
            writer.WriteEndObject();
        }
    }
}
