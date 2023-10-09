// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    public partial class MsixPackageApplications : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(AppId))
            {
                writer.WritePropertyName("appId"u8);
                writer.WriteStringValue(AppId);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(AppUserModelId))
            {
                writer.WritePropertyName("appUserModelID"u8);
                writer.WriteStringValue(AppUserModelId);
            }
            if (Optional.IsDefined(FriendlyName))
            {
                writer.WritePropertyName("friendlyName"u8);
                writer.WriteStringValue(FriendlyName);
            }
            if (Optional.IsDefined(IconImageName))
            {
                writer.WritePropertyName("iconImageName"u8);
                writer.WriteStringValue(IconImageName);
            }
            if (Optional.IsDefined(RawIcon))
            {
                writer.WritePropertyName("rawIcon"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(RawIcon);
#else
                using (JsonDocument document = JsonDocument.Parse(RawIcon.ToString()))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(RawPng))
            {
                writer.WritePropertyName("rawPng"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(RawPng);
#else
                using (JsonDocument document = JsonDocument.Parse(RawPng.ToString()))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            writer.WriteEndObject();
        }

        internal static MsixPackageApplications DeserializeMsixPackageApplications(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> appId = default;
            Optional<string> description = default;
            Optional<string> appUserModelId = default;
            Optional<string> friendlyName = default;
            Optional<string> iconImageName = default;
            Optional<BinaryData> rawIcon = default;
            Optional<BinaryData> rawPng = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("appId"u8))
                {
                    appId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("appUserModelID"u8))
                {
                    appUserModelId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("friendlyName"u8))
                {
                    friendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("iconImageName"u8))
                {
                    iconImageName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rawIcon"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rawIcon = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("rawPng"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rawPng = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
            }
            return new MsixPackageApplications(appId.Value, description.Value, appUserModelId.Value, friendlyName.Value, iconImageName.Value, rawIcon.Value, rawPng.Value);
        }
    }
}
