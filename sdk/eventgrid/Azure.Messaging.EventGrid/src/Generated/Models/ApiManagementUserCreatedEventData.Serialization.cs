// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(ApiManagementUserCreatedEventDataConverter))]
    public partial class ApiManagementUserCreatedEventData
    {
        internal static ApiManagementUserCreatedEventData DeserializeApiManagementUserCreatedEventData(JsonElement element)
        {
            Optional<string> resourceUri = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceUri"))
                {
                    resourceUri = property.Value.GetString();
                    continue;
                }
            }
            return new ApiManagementUserCreatedEventData(resourceUri.Value);
        }

        internal partial class ApiManagementUserCreatedEventDataConverter : JsonConverter<ApiManagementUserCreatedEventData>
        {
            public override void Write(Utf8JsonWriter writer, ApiManagementUserCreatedEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override ApiManagementUserCreatedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeApiManagementUserCreatedEventData(document.RootElement);
            }
        }
    }
}
