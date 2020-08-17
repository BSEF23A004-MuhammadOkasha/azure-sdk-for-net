// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class VirtualMachineExtensionHandlerInstanceView
    {
        internal static VirtualMachineExtensionHandlerInstanceView DeserializeVirtualMachineExtensionHandlerInstanceView(JsonElement element)
        {
            Optional<string> type = default;
            Optional<string> typeHandlerVersion = default;
            Optional<InstanceViewStatus> status = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("typeHandlerVersion"))
                {
                    typeHandlerVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    status = InstanceViewStatus.DeserializeInstanceViewStatus(property.Value);
                    continue;
                }
            }
            return new VirtualMachineExtensionHandlerInstanceView(type.Value, typeHandlerVersion.Value, status.Value);
        }
    }
}
