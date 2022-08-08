// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Authorization.Models
{
    public partial class RoleManagementPolicyExpirationRule : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(IsExpirationRequired))
            {
                writer.WritePropertyName("isExpirationRequired");
                writer.WriteBooleanValue(IsExpirationRequired.Value);
            }
            if (Optional.IsDefined(MaximumDuration))
            {
                writer.WritePropertyName("maximumDuration");
                writer.WriteStringValue(MaximumDuration.Value, "P");
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("ruleType");
            writer.WriteStringValue(RuleType.ToString());
            if (Optional.IsDefined(Target))
            {
                writer.WritePropertyName("target");
                writer.WriteObjectValue(Target);
            }
            writer.WriteEndObject();
        }

        internal static RoleManagementPolicyExpirationRule DeserializeRoleManagementPolicyExpirationRule(JsonElement element)
        {
            Optional<bool> isExpirationRequired = default;
            Optional<TimeSpan> maximumDuration = default;
            Optional<string> id = default;
            RoleManagementPolicyRuleType ruleType = default;
            Optional<RoleManagementPolicyRuleTarget> target = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("isExpirationRequired"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isExpirationRequired = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("maximumDuration"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    maximumDuration = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ruleType"))
                {
                    ruleType = new RoleManagementPolicyRuleType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("target"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    target = RoleManagementPolicyRuleTarget.DeserializeRoleManagementPolicyRuleTarget(property.Value);
                    continue;
                }
            }
            return new RoleManagementPolicyExpirationRule(id.Value, ruleType, target.Value, Optional.ToNullable(isExpirationRequired), Optional.ToNullable(maximumDuration));
        }
    }
}
