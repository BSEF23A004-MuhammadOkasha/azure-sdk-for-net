// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class PendingUploadRequestDto : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(PendingUploadId))
            {
                if (PendingUploadId != null)
                {
                    writer.WritePropertyName("pendingUploadId"u8);
                    writer.WriteStringValue(PendingUploadId);
                }
                else
                {
                    writer.WriteNull("pendingUploadId");
                }
            }
            if (Optional.IsDefined(PendingUploadType))
            {
                writer.WritePropertyName("pendingUploadType"u8);
                writer.WriteStringValue(PendingUploadType.Value.ToString());
            }
            writer.WriteEndObject();
        }
    }
}
