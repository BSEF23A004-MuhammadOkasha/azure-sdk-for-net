// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class EvaluatedNetworkSecurityGroup
    {
        internal static EvaluatedNetworkSecurityGroup DeserializeEvaluatedNetworkSecurityGroup(JsonElement element)
        {
            Optional<ResourceIdentifier> networkSecurityGroupId = default;
            Optional<string> appliedTo = default;
            Optional<MatchedRule> matchedRule = default;
            Optional<IReadOnlyList<NetworkSecurityRulesEvaluationResult>> rulesEvaluationResult = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("networkSecurityGroupId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    networkSecurityGroupId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("appliedTo"))
                {
                    appliedTo = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("matchedRule"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    matchedRule = MatchedRule.DeserializeMatchedRule(property.Value);
                    continue;
                }
                if (property.NameEquals("rulesEvaluationResult"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<NetworkSecurityRulesEvaluationResult> array = new List<NetworkSecurityRulesEvaluationResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NetworkSecurityRulesEvaluationResult.DeserializeNetworkSecurityRulesEvaluationResult(item));
                    }
                    rulesEvaluationResult = array;
                    continue;
                }
            }
            return new EvaluatedNetworkSecurityGroup(networkSecurityGroupId.Value, appliedTo.Value, matchedRule.Value, Optional.ToList(rulesEvaluationResult));
        }
    }
}
