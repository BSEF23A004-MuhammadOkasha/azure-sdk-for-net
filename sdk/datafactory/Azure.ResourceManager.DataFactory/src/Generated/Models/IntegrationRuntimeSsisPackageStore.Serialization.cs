// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class IntegrationRuntimeSsisPackageStore : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WritePropertyName("packageStoreLinkedService");
            writer.WriteObjectValue(PackageStoreLinkedService);
            writer.WriteEndObject();
        }

        internal static IntegrationRuntimeSsisPackageStore DeserializeIntegrationRuntimeSsisPackageStore(JsonElement element)
        {
            string name = default;
            EntityReference packageStoreLinkedService = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("packageStoreLinkedService"))
                {
                    packageStoreLinkedService = EntityReference.DeserializeEntityReference(property.Value);
                    continue;
                }
            }
            return new IntegrationRuntimeSsisPackageStore(name, packageStoreLinkedService);
        }
    }
}
