// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class DataAccountDetails : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("dataAccountType");
            writer.WriteStringValue(DataAccountType.ToSerialString());
            if (Optional.IsDefined(SharePassword))
            {
                writer.WritePropertyName("sharePassword");
                writer.WriteStringValue(SharePassword);
            }
            writer.WriteEndObject();
        }

        internal static DataAccountDetails DeserializeDataAccountDetails(JsonElement element)
        {
            if (element.TryGetProperty("dataAccountType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "ManagedDisk": return ManagedDiskDetails.DeserializeManagedDiskDetails(element);
                    case "StorageAccount": return StorageAccountDetails.DeserializeStorageAccountDetails(element);
                }
            }
            DataAccountType dataAccountType = default;
            Optional<string> sharePassword = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dataAccountType"))
                {
                    dataAccountType = property.Value.GetString().ToDataAccountType();
                    continue;
                }
                if (property.NameEquals("sharePassword"))
                {
                    sharePassword = property.Value.GetString();
                    continue;
                }
            }
            return new DataAccountDetails(dataAccountType, sharePassword.Value);
        }
    }
}
