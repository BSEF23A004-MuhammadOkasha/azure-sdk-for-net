// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class ApplicationGatewayAvailableSslOptions : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location");
                writer.WriteStringValue(Location);
            }
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
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(PredefinedPolicies))
            {
                writer.WritePropertyName("predefinedPolicies");
                writer.WriteStartArray();
                foreach (var item in PredefinedPolicies)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DefaultPolicy))
            {
                writer.WritePropertyName("defaultPolicy");
                writer.WriteStringValue(DefaultPolicy.Value.ToString());
            }
            if (Optional.IsCollectionDefined(AvailableCipherSuites))
            {
                writer.WritePropertyName("availableCipherSuites");
                writer.WriteStartArray();
                foreach (var item in AvailableCipherSuites)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(AvailableProtocols))
            {
                writer.WritePropertyName("availableProtocols");
                writer.WriteStartArray();
                foreach (var item in AvailableProtocols)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ApplicationGatewayAvailableSslOptions DeserializeApplicationGatewayAvailableSslOptions(JsonElement element)
        {
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> type = default;
            Optional<string> location = default;
            Optional<IDictionary<string, string>> tags = default;
            Optional<IList<SubResource>> predefinedPolicies = default;
            Optional<ApplicationGatewaySslPolicyName> defaultPolicy = default;
            Optional<IList<ApplicationGatewaySslCipherSuite>> availableCipherSuites = default;
            Optional<IList<ApplicationGatewaySslProtocol>> availableProtocols = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("predefinedPolicies"))
                        {
                            List<SubResource> array = new List<SubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SubResource.DeserializeSubResource(item));
                            }
                            predefinedPolicies = array;
                            continue;
                        }
                        if (property0.NameEquals("defaultPolicy"))
                        {
                            defaultPolicy = new ApplicationGatewaySslPolicyName(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("availableCipherSuites"))
                        {
                            List<ApplicationGatewaySslCipherSuite> array = new List<ApplicationGatewaySslCipherSuite>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new ApplicationGatewaySslCipherSuite(item.GetString()));
                            }
                            availableCipherSuites = array;
                            continue;
                        }
                        if (property0.NameEquals("availableProtocols"))
                        {
                            List<ApplicationGatewaySslProtocol> array = new List<ApplicationGatewaySslProtocol>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new ApplicationGatewaySslProtocol(item.GetString()));
                            }
                            availableProtocols = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ApplicationGatewayAvailableSslOptions(id.Value, name.Value, type.Value, location.Value, Optional.ToDictionary(tags), Optional.ToList(predefinedPolicies), Optional.ToNullable(defaultPolicy), Optional.ToList(availableCipherSuites), Optional.ToList(availableProtocols));
        }
    }
}
