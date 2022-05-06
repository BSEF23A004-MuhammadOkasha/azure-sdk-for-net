// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class ClientPortMatchConditionDefinition : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("typeName");
            writer.WriteStringValue(TypeDefinition.ToString());
            writer.WritePropertyName("operator");
            writer.WriteStringValue(Operator.ToString());
            if (Optional.IsDefined(NegateCondition))
            {
                writer.WritePropertyName("negateCondition");
                writer.WriteBooleanValue(NegateCondition.Value);
            }
            if (Optional.IsCollectionDefined(MatchValues))
            {
                writer.WritePropertyName("matchValues");
                writer.WriteStartArray();
                foreach (var item in MatchValues)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Transforms))
            {
                writer.WritePropertyName("transforms");
                writer.WriteStartArray();
                foreach (var item in Transforms)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static ClientPortMatchConditionDefinition DeserializeClientPortMatchConditionDefinition(JsonElement element)
        {
            ClientPortMatchConditionType typeName = default;
            ClientPortOperator @operator = default;
            Optional<bool> negateCondition = default;
            Optional<IList<string>> matchValues = default;
            Optional<IList<TransformCategory>> transforms = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("typeName"))
                {
                    typeName = new ClientPortMatchConditionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("operator"))
                {
                    @operator = new ClientPortOperator(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("negateCondition"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    negateCondition = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("matchValues"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    matchValues = array;
                    continue;
                }
                if (property.NameEquals("transforms"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<TransformCategory> array = new List<TransformCategory>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new TransformCategory(item.GetString()));
                    }
                    transforms = array;
                    continue;
                }
            }
            return new ClientPortMatchConditionDefinition(typeName, @operator, Optional.ToNullable(negateCondition), Optional.ToList(matchValues), Optional.ToList(transforms));
        }
    }
}
