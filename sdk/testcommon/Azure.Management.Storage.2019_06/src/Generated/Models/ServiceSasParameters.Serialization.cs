// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Storage.Models
{
    public partial class ServiceSasParameters : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("canonicalizedResource");
            writer.WriteStringValue(CanonicalizedResource);
            if (Optional.IsDefined(Resource))
            {
                writer.WritePropertyName("signedResource");
                writer.WriteStringValue(Resource.Value.ToString());
            }
            if (Optional.IsDefined(Permissions))
            {
                writer.WritePropertyName("signedPermission");
                writer.WriteStringValue(Permissions.Value.ToString());
            }
            if (Optional.IsDefined(IPAddressOrRange))
            {
                writer.WritePropertyName("signedIp");
                writer.WriteStringValue(IPAddressOrRange);
            }
            if (Optional.IsDefined(Protocols))
            {
                writer.WritePropertyName("signedProtocol");
                writer.WriteStringValue(Protocols.Value.ToSerialString());
            }
            if (Optional.IsDefined(SharedAccessStartTime))
            {
                writer.WritePropertyName("signedStart");
                writer.WriteStringValue(SharedAccessStartTime.Value, "O");
            }
            if (Optional.IsDefined(SharedAccessExpiryTime))
            {
                writer.WritePropertyName("signedExpiry");
                writer.WriteStringValue(SharedAccessExpiryTime.Value, "O");
            }
            if (Optional.IsDefined(Identifier))
            {
                writer.WritePropertyName("signedIdentifier");
                writer.WriteStringValue(Identifier);
            }
            if (Optional.IsDefined(PartitionKeyStart))
            {
                writer.WritePropertyName("startPk");
                writer.WriteStringValue(PartitionKeyStart);
            }
            if (Optional.IsDefined(PartitionKeyEnd))
            {
                writer.WritePropertyName("endPk");
                writer.WriteStringValue(PartitionKeyEnd);
            }
            if (Optional.IsDefined(RowKeyStart))
            {
                writer.WritePropertyName("startRk");
                writer.WriteStringValue(RowKeyStart);
            }
            if (Optional.IsDefined(RowKeyEnd))
            {
                writer.WritePropertyName("endRk");
                writer.WriteStringValue(RowKeyEnd);
            }
            if (Optional.IsDefined(KeyToSign))
            {
                writer.WritePropertyName("keyToSign");
                writer.WriteStringValue(KeyToSign);
            }
            if (Optional.IsDefined(CacheControl))
            {
                writer.WritePropertyName("rscc");
                writer.WriteStringValue(CacheControl);
            }
            if (Optional.IsDefined(ContentDisposition))
            {
                writer.WritePropertyName("rscd");
                writer.WriteStringValue(ContentDisposition);
            }
            if (Optional.IsDefined(ContentEncoding))
            {
                writer.WritePropertyName("rsce");
                writer.WriteStringValue(ContentEncoding);
            }
            if (Optional.IsDefined(ContentLanguage))
            {
                writer.WritePropertyName("rscl");
                writer.WriteStringValue(ContentLanguage);
            }
            if (Optional.IsDefined(ContentType))
            {
                writer.WritePropertyName("rsct");
                writer.WriteStringValue(ContentType);
            }
            writer.WriteEndObject();
        }
    }
}
