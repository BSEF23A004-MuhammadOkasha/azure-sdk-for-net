// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.CallingServer
{
    public partial class AddParticipantResultEvent
    {
        internal static AddParticipantResultEvent DeserializeAddParticipantResultEvent(JsonElement element)
        {
            Optional<CallingOperationResultDetails> resultInfo = default;
            Optional<string> operationContext = default;
            CallingOperationStatus status = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resultInfo"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    resultInfo = CallingOperationResultDetails.DeserializeCallingOperationResultDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("operationContext"))
                {
                    operationContext = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    status = new CallingOperationStatus(property.Value.GetString());
                    continue;
                }
            }
            return new AddParticipantResultEvent(resultInfo.Value, operationContext.Value, status);
        }
    }
}
