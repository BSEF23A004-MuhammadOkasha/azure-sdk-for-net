// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class UrlSigningActionParameters : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("typeName");
            writer.WriteStringValue(TypeName.ToString());
            if (Optional.IsDefined(Algorithm))
            {
                writer.WritePropertyName("algorithm");
                writer.WriteStringValue(Algorithm.Value.ToString());
            }
            if (Optional.IsCollectionDefined(ParameterNameOverride))
            {
                writer.WritePropertyName("parameterNameOverride");
                writer.WriteStartArray();
                foreach (var item in ParameterNameOverride)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static UrlSigningActionParameters DeserializeUrlSigningActionParameters(JsonElement element)
        {
            UrlSigningActionParametersTypeName typeName = default;
            Optional<UrlSigningAlgorithm> algorithm = default;
            Optional<IList<UrlSigningParamIdentifier>> parameterNameOverride = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("typeName"))
                {
                    typeName = new UrlSigningActionParametersTypeName(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("algorithm"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    algorithm = new UrlSigningAlgorithm(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("parameterNameOverride"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<UrlSigningParamIdentifier> array = new List<UrlSigningParamIdentifier>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(UrlSigningParamIdentifier.DeserializeUrlSigningParamIdentifier(item));
                    }
                    parameterNameOverride = array;
                    continue;
                }
            }
            return new UrlSigningActionParameters(typeName, Optional.ToNullable(algorithm), Optional.ToList(parameterNameOverride));
        }
    }
}
