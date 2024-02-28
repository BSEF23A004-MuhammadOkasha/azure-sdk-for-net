// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(ResourceNotificationsResourceDeletedEventDataConverter))]
    public partial class ResourceNotificationsResourceDeletedEventData
    {
        internal static ResourceNotificationsResourceDeletedEventData DeserializeResourceNotificationsResourceDeletedEventData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceNotificationsResourceDeletedDetails resourceInfo = default;
            ResourceNotificationsOperationalDetails operationalInfo = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceInfo = ResourceNotificationsResourceDeletedDetails.DeserializeResourceNotificationsResourceDeletedDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("operationalInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    operationalInfo = ResourceNotificationsOperationalDetails.DeserializeResourceNotificationsOperationalDetails(property.Value);
                    continue;
                }
            }
            return new ResourceNotificationsResourceDeletedEventData(resourceInfo, operationalInfo);
        }

        internal partial class ResourceNotificationsResourceDeletedEventDataConverter : JsonConverter<ResourceNotificationsResourceDeletedEventData>
        {
            public override void Write(Utf8JsonWriter writer, ResourceNotificationsResourceDeletedEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override ResourceNotificationsResourceDeletedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeResourceNotificationsResourceDeletedEventData(document.RootElement);
            }
        }
    }
}
