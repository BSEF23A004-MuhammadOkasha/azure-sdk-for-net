// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    public partial class BatchAutoUserSpecification : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Scope))
            {
                writer.WritePropertyName("scope");
                writer.WriteStringValue(Scope.Value.ToSerialString());
            }
            if (Optional.IsDefined(ElevationLevel))
            {
                writer.WritePropertyName("elevationLevel");
                writer.WriteStringValue(ElevationLevel.Value.ToSerialString());
            }
            writer.WriteEndObject();
        }

        internal static BatchAutoUserSpecification DeserializeBatchAutoUserSpecification(JsonElement element)
        {
            Optional<BatchAutoUserScope> scope = default;
            Optional<BatchUserAccountElevationLevel> elevationLevel = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("scope"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    scope = property.Value.GetString().ToBatchAutoUserScope();
                    continue;
                }
                if (property.NameEquals("elevationLevel"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    elevationLevel = property.Value.GetString().ToBatchUserAccountElevationLevel();
                    continue;
                }
            }
            return new BatchAutoUserSpecification(Optional.ToNullable(scope), Optional.ToNullable(elevationLevel));
        }
    }
}
