// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Graph.Rbac.Models
{
    public partial class OptionalClaims : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(IdToken))
            {
                writer.WritePropertyName("idToken");
                writer.WriteStartArray();
                foreach (var item in IdToken)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(AccessToken))
            {
                writer.WritePropertyName("accessToken");
                writer.WriteStartArray();
                foreach (var item in AccessToken)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(SamlToken))
            {
                writer.WritePropertyName("samlToken");
                writer.WriteStartArray();
                foreach (var item in SamlToken)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static OptionalClaims DeserializeOptionalClaims(JsonElement element)
        {
            Optional<IList<OptionalClaim>> idToken = default;
            Optional<IList<OptionalClaim>> accessToken = default;
            Optional<IList<OptionalClaim>> samlToken = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("idToken"))
                {
                    List<OptionalClaim> array = new List<OptionalClaim>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(OptionalClaim.DeserializeOptionalClaim(item));
                    }
                    idToken = array;
                    continue;
                }
                if (property.NameEquals("accessToken"))
                {
                    List<OptionalClaim> array = new List<OptionalClaim>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(OptionalClaim.DeserializeOptionalClaim(item));
                    }
                    accessToken = array;
                    continue;
                }
                if (property.NameEquals("samlToken"))
                {
                    List<OptionalClaim> array = new List<OptionalClaim>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(OptionalClaim.DeserializeOptionalClaim(item));
                    }
                    samlToken = array;
                    continue;
                }
            }
            return new OptionalClaims(Optional.ToList(idToken), Optional.ToList(accessToken), Optional.ToList(samlToken));
        }
    }
}
