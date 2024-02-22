// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    public partial class RemoteDeviceAdapterCollection : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (!(Value is ChangeTrackingList<RemoteDeviceAdapter> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStartArray();
                foreach (var item in Value)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ContinuationToken))
            {
                writer.WritePropertyName("@continuationToken"u8);
                writer.WriteStringValue(ContinuationToken);
            }
            writer.WriteEndObject();
        }

        internal static RemoteDeviceAdapterCollection DeserializeRemoteDeviceAdapterCollection(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<RemoteDeviceAdapter>> value = default;
            Optional<string> continuationToken = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RemoteDeviceAdapter> array = new List<RemoteDeviceAdapter>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RemoteDeviceAdapter.DeserializeRemoteDeviceAdapter(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("@continuationToken"u8))
                {
                    continuationToken = property.Value.GetString();
                    continue;
                }
            }
            return new RemoteDeviceAdapterCollection(Optional.ToList(value), continuationToken.Value);
        }
    }
}
