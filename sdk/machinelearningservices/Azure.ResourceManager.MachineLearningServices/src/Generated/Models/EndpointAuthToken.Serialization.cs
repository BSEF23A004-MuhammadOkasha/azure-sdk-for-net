// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    public partial class EndpointAuthToken
    {
        internal static EndpointAuthToken DeserializeEndpointAuthToken(JsonElement element)
        {
            Optional<string> accessToken = default;
            Optional<long> expiryTimeUtc = default;
            Optional<long> refreshAfterTimeUtc = default;
            Optional<string> tokenType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("accessToken"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        accessToken = null;
                        continue;
                    }
                    accessToken = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("expiryTimeUtc"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    expiryTimeUtc = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("refreshAfterTimeUtc"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    refreshAfterTimeUtc = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("tokenType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        tokenType = null;
                        continue;
                    }
                    tokenType = property.Value.GetString();
                    continue;
                }
            }
            return new EndpointAuthToken(accessToken.Value, Optional.ToNullable(expiryTimeUtc), Optional.ToNullable(refreshAfterTimeUtc), tokenType.Value);
        }
    }
}
