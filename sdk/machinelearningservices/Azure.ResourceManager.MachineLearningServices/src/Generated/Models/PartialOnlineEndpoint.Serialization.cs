// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    public partial class PartialOnlineEndpoint : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(MirrorTraffic))
            {
                if (MirrorTraffic != null)
                {
                    writer.WritePropertyName("mirrorTraffic");
                    writer.WriteStartObject();
                    foreach (var item in MirrorTraffic)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteNumberValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("mirrorTraffic");
                }
            }
            if (Optional.IsCollectionDefined(Traffic))
            {
                if (Traffic != null)
                {
                    writer.WritePropertyName("traffic");
                    writer.WriteStartObject();
                    foreach (var item in Traffic)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteNumberValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("traffic");
                }
            }
            writer.WriteEndObject();
        }
    }
}
