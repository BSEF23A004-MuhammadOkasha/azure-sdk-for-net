// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    internal partial class UnknownAwsOrganizationalData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("organizationMembershipType");
            writer.WriteStringValue(OrganizationMembershipType.ToString());
            writer.WriteEndObject();
        }

        internal static UnknownAwsOrganizationalData DeserializeUnknownAwsOrganizationalData(JsonElement element)
        {
            OrganizationMembershipType organizationMembershipType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("organizationMembershipType"))
                {
                    organizationMembershipType = new OrganizationMembershipType(property.Value.GetString());
                    continue;
                }
            }
            return new UnknownAwsOrganizationalData(organizationMembershipType);
        }
    }
}
