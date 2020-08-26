// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class Probe : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(Protocol))
            {
                writer.WritePropertyName("protocol");
                writer.WriteStringValue(Protocol.Value.ToString());
            }
            if (Optional.IsDefined(Port))
            {
                writer.WritePropertyName("port");
                writer.WriteNumberValue(Port.Value);
            }
            if (Optional.IsDefined(IntervalInSeconds))
            {
                writer.WritePropertyName("intervalInSeconds");
                writer.WriteNumberValue(IntervalInSeconds.Value);
            }
            if (Optional.IsDefined(NumberOfProbes))
            {
                writer.WritePropertyName("numberOfProbes");
                writer.WriteNumberValue(NumberOfProbes.Value);
            }
            if (Optional.IsDefined(RequestPath))
            {
                writer.WritePropertyName("requestPath");
                writer.WriteStringValue(RequestPath);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static Probe DeserializeProbe(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> etag = default;
            Optional<string> type = default;
            Optional<string> id = default;
            Optional<IReadOnlyList<SubResource>> loadBalancingRules = default;
            Optional<ProbeProtocol> protocol = default;
            Optional<int> port = default;
            Optional<int> intervalInSeconds = default;
            Optional<int> numberOfProbes = default;
            Optional<string> requestPath = default;
            Optional<ProvisioningState> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("etag"))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("loadBalancingRules"))
                        {
                            List<SubResource> array = new List<SubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DeserializeSubResource(item));
                            }
                            loadBalancingRules = array;
                            continue;
                        }
                        if (property0.NameEquals("protocol"))
                        {
                            protocol = new ProbeProtocol(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("port"))
                        {
                            port = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("intervalInSeconds"))
                        {
                            intervalInSeconds = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("numberOfProbes"))
                        {
                            numberOfProbes = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("requestPath"))
                        {
                            requestPath = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new Probe(id.Value, name.Value, etag.Value, type.Value, Optional.ToList(loadBalancingRules), Optional.ToNullable(protocol), Optional.ToNullable(port), Optional.ToNullable(intervalInSeconds), Optional.ToNullable(numberOfProbes), requestPath.Value, Optional.ToNullable(provisioningState));
        }
    }
}
