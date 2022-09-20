// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PolicyInsights.Models
{
    public partial class ExpressionEvaluationDetails
    {
        internal static ExpressionEvaluationDetails DeserializeExpressionEvaluationDetails(JsonElement element)
        {
            Optional<string> result = default;
            Optional<string> expression = default;
            Optional<string> expressionKind = default;
            Optional<string> path = default;
            Optional<BinaryData> expressionValue = default;
            Optional<BinaryData> targetValue = default;
            Optional<string> @operator = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("result"))
                {
                    result = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("expression"))
                {
                    expression = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("expressionKind"))
                {
                    expressionKind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("path"))
                {
                    path = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("expressionValue"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    expressionValue = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("targetValue"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    targetValue = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("operator"))
                {
                    @operator = property.Value.GetString();
                    continue;
                }
            }
            return new ExpressionEvaluationDetails(result.Value, expression.Value, expressionKind.Value, path.Value, expressionValue.Value, targetValue.Value, @operator.Value);
        }
    }
}
