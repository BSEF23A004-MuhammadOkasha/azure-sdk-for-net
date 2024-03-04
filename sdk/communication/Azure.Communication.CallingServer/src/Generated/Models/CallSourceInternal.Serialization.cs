// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Communication;
using Azure.Core;

namespace Azure.Communication.CallingServer
{
    internal partial class CallSourceInternal : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(CallerId))
            {
                writer.WritePropertyName("callerId"u8);
                writer.WriteObjectValue(CallerId);
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            writer.WritePropertyName("identifier"u8);
            writer.WriteObjectValue(Identifier);
            writer.WriteEndObject();
        }

        internal static CallSourceInternal DeserializeCallSourceInternal(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            PhoneNumberIdentifierModel callerId = default;
            string displayName = default;
            CommunicationIdentifierModel identifier = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("callerId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    callerId = PhoneNumberIdentifierModel.DeserializePhoneNumberIdentifierModel(property.Value);
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("identifier"u8))
                {
                    identifier = CommunicationIdentifierModel.DeserializeCommunicationIdentifierModel(property.Value);
                    continue;
                }
            }
            return new CallSourceInternal(callerId, displayName, identifier);
        }
    }
}
