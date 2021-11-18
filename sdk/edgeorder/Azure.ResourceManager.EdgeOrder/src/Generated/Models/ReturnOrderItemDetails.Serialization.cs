// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    public partial class ReturnOrderItemDetails : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ReturnAddress))
            {
                writer.WritePropertyName("returnAddress");
                writer.WriteObjectValue(ReturnAddress);
            }
            writer.WritePropertyName("returnReason");
            writer.WriteStringValue(ReturnReason);
            if (Optional.IsDefined(ServiceTag))
            {
                writer.WritePropertyName("serviceTag");
                writer.WriteStringValue(ServiceTag);
            }
            if (Optional.IsDefined(ShippingBoxRequired))
            {
                writer.WritePropertyName("shippingBoxRequired");
                writer.WriteBooleanValue(ShippingBoxRequired.Value);
            }
            writer.WriteEndObject();
        }
    }
}
