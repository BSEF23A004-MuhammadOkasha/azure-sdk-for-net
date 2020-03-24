// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Storage.Models
{
    public partial class BlobRestoreParameters : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("timeToRestore");
            writer.WriteStringValue(TimeToRestore, "S");
            writer.WritePropertyName("blobRanges");
            writer.WriteStartArray();
            foreach (var item in BlobRanges)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static BlobRestoreParameters DeserializeBlobRestoreParameters(JsonElement element)
        {
            DateTimeOffset timeToRestore = default;
            IList<BlobRestoreRange> blobRanges = new List<BlobRestoreRange>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("timeToRestore"))
                {
                    timeToRestore = property.Value.GetDateTimeOffset("S");
                    continue;
                }
                if (property.NameEquals("blobRanges"))
                {
                    List<BlobRestoreRange> array = new List<BlobRestoreRange>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BlobRestoreRange.DeserializeBlobRestoreRange(item));
                    }
                    blobRanges = array;
                    continue;
                }
            }
            return new BlobRestoreParameters(timeToRestore, blobRanges);
        }
    }
}
