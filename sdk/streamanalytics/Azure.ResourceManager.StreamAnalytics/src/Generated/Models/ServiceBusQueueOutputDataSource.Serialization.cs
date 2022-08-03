// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    public partial class ServiceBusQueueOutputDataSource : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type");
            writer.WriteStringValue(OutputDataSourceType);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(ServiceBusNamespace))
            {
                writer.WritePropertyName("serviceBusNamespace");
                writer.WriteStringValue(ServiceBusNamespace);
            }
            if (Optional.IsDefined(SharedAccessPolicyName))
            {
                writer.WritePropertyName("sharedAccessPolicyName");
                writer.WriteStringValue(SharedAccessPolicyName);
            }
            if (Optional.IsDefined(SharedAccessPolicyKey))
            {
                writer.WritePropertyName("sharedAccessPolicyKey");
                writer.WriteStringValue(SharedAccessPolicyKey);
            }
            if (Optional.IsDefined(AuthenticationMode))
            {
                writer.WritePropertyName("authenticationMode");
                writer.WriteStringValue(AuthenticationMode.Value.ToString());
            }
            if (Optional.IsDefined(QueueName))
            {
                writer.WritePropertyName("queueName");
                writer.WriteStringValue(QueueName);
            }
            if (Optional.IsCollectionDefined(PropertyColumns))
            {
                writer.WritePropertyName("propertyColumns");
                writer.WriteStartArray();
                foreach (var item in PropertyColumns)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(SystemPropertyColumns))
            {
                writer.WritePropertyName("systemPropertyColumns");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(SystemPropertyColumns);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(SystemPropertyColumns.ToString()).RootElement);
#endif
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ServiceBusQueueOutputDataSource DeserializeServiceBusQueueOutputDataSource(JsonElement element)
        {
            string type = default;
            Optional<string> serviceBusNamespace = default;
            Optional<string> sharedAccessPolicyName = default;
            Optional<string> sharedAccessPolicyKey = default;
            Optional<StreamAnalyticsAuthenticationMode> authenticationMode = default;
            Optional<string> queueName = default;
            Optional<IList<string>> propertyColumns = default;
            Optional<BinaryData> systemPropertyColumns = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("serviceBusNamespace"))
                        {
                            serviceBusNamespace = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sharedAccessPolicyName"))
                        {
                            sharedAccessPolicyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sharedAccessPolicyKey"))
                        {
                            sharedAccessPolicyKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("authenticationMode"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            authenticationMode = new StreamAnalyticsAuthenticationMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("queueName"))
                        {
                            queueName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("propertyColumns"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            propertyColumns = array;
                            continue;
                        }
                        if (property0.NameEquals("systemPropertyColumns"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            systemPropertyColumns = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ServiceBusQueueOutputDataSource(type, serviceBusNamespace.Value, sharedAccessPolicyName.Value, sharedAccessPolicyKey.Value, Optional.ToNullable(authenticationMode), queueName.Value, Optional.ToList(propertyColumns), systemPropertyColumns.Value);
        }
    }
}
