// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class RequestRateByIntervalInput : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("intervalLength");
            writer.WriteStringValue(IntervalLength.ToSerialString());
            writer.WritePropertyName("blobContainerSasUri");
            writer.WriteStringValue(BlobContainerSasUri);
            writer.WritePropertyName("fromTime");
            writer.WriteStringValue(FromTime, "O");
            writer.WritePropertyName("toTime");
            writer.WriteStringValue(ToTime, "O");
            if (Optional.IsDefined(GroupByThrottlePolicy))
            {
                writer.WritePropertyName("groupByThrottlePolicy");
                writer.WriteBooleanValue(GroupByThrottlePolicy.Value);
            }
            if (Optional.IsDefined(GroupByOperationName))
            {
                writer.WritePropertyName("groupByOperationName");
                writer.WriteBooleanValue(GroupByOperationName.Value);
            }
            if (Optional.IsDefined(GroupByResourceName))
            {
                writer.WritePropertyName("groupByResourceName");
                writer.WriteBooleanValue(GroupByResourceName.Value);
            }
            if (Optional.IsDefined(GroupByClientApplicationId))
            {
                writer.WritePropertyName("groupByClientApplicationId");
                writer.WriteBooleanValue(GroupByClientApplicationId.Value);
            }
            if (Optional.IsDefined(GroupByUserAgent))
            {
                writer.WritePropertyName("groupByUserAgent");
                writer.WriteBooleanValue(GroupByUserAgent.Value);
            }
            writer.WriteEndObject();
        }
    }
}
