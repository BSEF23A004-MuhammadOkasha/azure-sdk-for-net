// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Messaging.EventGrid;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(StorageBlobRenamedEventDataConverter))]
    public partial class StorageBlobRenamedEventData
    {
        internal static StorageBlobRenamedEventData DeserializeStorageBlobRenamedEventData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string api = default;
            string clientRequestId = default;
            string requestId = default;
            string sourceUrl = default;
            string destinationUrl = default;
            string sequencer = default;
            string identity = default;
            object storageDiagnostics = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("api"u8))
                {
                    api = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientRequestId"u8))
                {
                    clientRequestId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("requestId"u8))
                {
                    requestId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceUrl"u8))
                {
                    sourceUrl = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("destinationUrl"u8))
                {
                    destinationUrl = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sequencer"u8))
                {
                    sequencer = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    identity = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("storageDiagnostics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageDiagnostics = property.Value.GetObject();
                    continue;
                }
            }
            return new StorageBlobRenamedEventData(
                api,
                clientRequestId,
                requestId,
                sourceUrl,
                destinationUrl,
                sequencer,
                identity,
                storageDiagnostics);
        }

        internal partial class StorageBlobRenamedEventDataConverter : JsonConverter<StorageBlobRenamedEventData>
        {
            public override void Write(Utf8JsonWriter writer, StorageBlobRenamedEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override StorageBlobRenamedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeStorageBlobRenamedEventData(document.RootElement);
            }
        }
    }
}
