// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Workloads.Models
{
    public partial class ProviderSpecificProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("providerType");
            writer.WriteStringValue(ProviderType);
            writer.WriteEndObject();
        }

        internal static ProviderSpecificProperties DeserializeProviderSpecificProperties(JsonElement element)
        {
            if (element.TryGetProperty("providerType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Db2": return Db2ProviderInstanceProperties.DeserializeDb2ProviderInstanceProperties(element);
                    case "MsSqlServer": return MsSqlServerProviderInstanceProperties.DeserializeMsSqlServerProviderInstanceProperties(element);
                    case "PrometheusHaCluster": return PrometheusHaClusterProviderInstanceProperties.DeserializePrometheusHaClusterProviderInstanceProperties(element);
                    case "PrometheusOS": return PrometheusOSProviderInstanceProperties.DeserializePrometheusOSProviderInstanceProperties(element);
                    case "SapHana": return HanaDbProviderInstanceProperties.DeserializeHanaDbProviderInstanceProperties(element);
                    case "SapNetWeaver": return SapNetWeaverProviderInstanceProperties.DeserializeSapNetWeaverProviderInstanceProperties(element);
                }
            }
            string providerType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("providerType"))
                {
                    providerType = property.Value.GetString();
                    continue;
                }
            }
            return new ProviderSpecificProperties(providerType);
        }
    }
}
