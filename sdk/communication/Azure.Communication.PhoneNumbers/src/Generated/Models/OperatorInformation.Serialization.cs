// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.PhoneNumbers
{
    public partial class OperatorInformation
    {
        internal static OperatorInformation DeserializeOperatorInformation(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> phoneNumber = default;
            Optional<OperatorNumberType> numberType = default;
            Optional<string> isoCountryCode = default;
            Optional<OperatorDetails> operatorDetails = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("phoneNumber"u8))
                {
                    phoneNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("numberType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    numberType = new OperatorNumberType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("isoCountryCode"u8))
                {
                    isoCountryCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("operatorDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    operatorDetails = OperatorDetails.DeserializeOperatorDetails(property.Value);
                    continue;
                }
            }
            return new OperatorInformation(phoneNumber.Value, Optional.ToNullable(numberType), isoCountryCode.Value, operatorDetails.Value);
        }
    }
}
