// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class VpnClientConnectionHealthDetailListResult
    {
        internal static VpnClientConnectionHealthDetailListResult DeserializeVpnClientConnectionHealthDetailListResult(JsonElement element)
        {
            IReadOnlyList<VpnClientConnectionHealthDetail> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<VpnClientConnectionHealthDetail> array = new List<VpnClientConnectionHealthDetail>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(VpnClientConnectionHealthDetail.DeserializeVpnClientConnectionHealthDetail(item));
                        }
                    }
                    value = array;
                    continue;
                }
            }
            return new VpnClientConnectionHealthDetailListResult(value);
        }
    }
}
