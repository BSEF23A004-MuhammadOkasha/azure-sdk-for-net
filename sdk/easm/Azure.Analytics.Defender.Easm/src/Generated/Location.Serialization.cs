// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.Analytics.Defender.Easm
{
    public partial class Location : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(CountryCode))
            {
                writer.WritePropertyName("countryCode"u8);
                writer.WriteStringValue(CountryCode);
            }
            if (Optional.IsDefined(CountryName))
            {
                writer.WritePropertyName("countryName"u8);
                writer.WriteStringValue(CountryName);
            }
            if (Optional.IsDefined(Region))
            {
                writer.WritePropertyName("region"u8);
                writer.WriteStringValue(Region);
            }
            if (Optional.IsDefined(RegionName))
            {
                writer.WritePropertyName("regionName"u8);
                writer.WriteStringValue(RegionName);
            }
            if (Optional.IsDefined(City))
            {
                writer.WritePropertyName("city"u8);
                writer.WriteStringValue(City);
            }
            if (Optional.IsDefined(AreaCode))
            {
                writer.WritePropertyName("areaCode"u8);
                writer.WriteNumberValue(AreaCode.Value);
            }
            if (Optional.IsDefined(PostalCode))
            {
                writer.WritePropertyName("postalCode"u8);
                writer.WriteStringValue(PostalCode);
            }
            if (Optional.IsDefined(Latitude))
            {
                writer.WritePropertyName("latitude"u8);
                writer.WriteNumberValue(Latitude.Value);
            }
            if (Optional.IsDefined(Longitude))
            {
                writer.WritePropertyName("longitude"u8);
                writer.WriteNumberValue(Longitude.Value);
            }
            if (Optional.IsDefined(DmaCode))
            {
                writer.WritePropertyName("dmaCode"u8);
                writer.WriteNumberValue(DmaCode.Value);
            }
            if (Optional.IsDefined(MetroCodeId))
            {
                writer.WritePropertyName("metroCodeId"u8);
                writer.WriteNumberValue(MetroCodeId.Value);
            }
            writer.WriteEndObject();
        }

        internal static Location DeserializeLocation(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> countryCode = default;
            Optional<string> countryName = default;
            Optional<string> region = default;
            Optional<string> regionName = default;
            Optional<string> city = default;
            Optional<int> areaCode = default;
            Optional<string> postalCode = default;
            Optional<float> latitude = default;
            Optional<float> longitude = default;
            Optional<int> dmaCode = default;
            Optional<int> metroCodeId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("countryCode"u8))
                {
                    countryCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("countryName"u8))
                {
                    countryName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("region"u8))
                {
                    region = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("regionName"u8))
                {
                    regionName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("city"u8))
                {
                    city = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("areaCode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    areaCode = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("postalCode"u8))
                {
                    postalCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("latitude"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    latitude = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("longitude"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    longitude = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("dmaCode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dmaCode = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("metroCodeId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    metroCodeId = property.Value.GetInt32();
                    continue;
                }
            }
            return new Location(countryCode.Value, countryName.Value, region.Value, regionName.Value, city.Value, Optional.ToNullable(areaCode), postalCode.Value, Optional.ToNullable(latitude), Optional.ToNullable(longitude), Optional.ToNullable(dmaCode), Optional.ToNullable(metroCodeId));
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static Location FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeLocation(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
