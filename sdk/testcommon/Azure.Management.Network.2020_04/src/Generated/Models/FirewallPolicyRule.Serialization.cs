// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class FirewallPolicyRule : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("ruleType");
            writer.WriteStringValue(RuleType.ToString());
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Priority))
            {
                writer.WritePropertyName("priority");
                writer.WriteNumberValue(Priority.Value);
            }
            writer.WriteEndObject();
        }

        internal static FirewallPolicyRule DeserializeFirewallPolicyRule(JsonElement element)
        {
            if (element.TryGetProperty("ruleType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "FirewallPolicyFilterRule": return FirewallPolicyFilterRule.DeserializeFirewallPolicyFilterRule(element);
                    case "FirewallPolicyNatRule": return FirewallPolicyNatRule.DeserializeFirewallPolicyNatRule(element);
                }
            }
            FirewallPolicyRuleType ruleType = default;
            Optional<string> name = default;
            Optional<int> priority = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ruleType"))
                {
                    ruleType = new FirewallPolicyRuleType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("priority"))
                {
                    priority = property.Value.GetInt32();
                    continue;
                }
            }
            return new FirewallPolicyRule(ruleType, name.Value, Optional.ToNullable(priority));
        }
    }
}
