// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid.Models
{
    public partial class PartnerTopicInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(AzureSubscriptionId))
            {
                writer.WritePropertyName("azureSubscriptionId");
                writer.WriteStringValue(AzureSubscriptionId.Value);
            }
            if (Optional.IsDefined(ResourceGroupName))
            {
                writer.WritePropertyName("resourceGroupName");
                writer.WriteStringValue(ResourceGroupName);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(EventTypeInfo))
            {
                writer.WritePropertyName("eventTypeInfo");
                writer.WriteObjectValue(EventTypeInfo);
            }
            if (Optional.IsDefined(Source))
            {
                writer.WritePropertyName("source");
                writer.WriteStringValue(Source);
            }
            writer.WriteEndObject();
        }

        internal static PartnerTopicInfo DeserializePartnerTopicInfo(JsonElement element)
        {
            Optional<Guid> azureSubscriptionId = default;
            Optional<string> resourceGroupName = default;
            Optional<string> name = default;
            Optional<PartnerTopicEventTypeInfo> eventTypeInfo = default;
            Optional<string> source = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("azureSubscriptionId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    azureSubscriptionId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("resourceGroupName"))
                {
                    resourceGroupName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("eventTypeInfo"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    eventTypeInfo = PartnerTopicEventTypeInfo.DeserializePartnerTopicEventTypeInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("source"))
                {
                    source = property.Value.GetString();
                    continue;
                }
            }
            return new PartnerTopicInfo(Optional.ToNullable(azureSubscriptionId), resourceGroupName.Value, name.Value, eventTypeInfo.Value, source.Value);
        }
    }
}
