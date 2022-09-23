// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Maps.Routing.Models
{
    public partial class RouteInstruction
    {
        internal static RouteInstruction DeserializeRouteInstruction(JsonElement element)
        {
            Optional<int> routeOffsetInMeters = default;
            Optional<int> travelTimeInSeconds = default;
            Optional<LatLongPair> point = default;
            Optional<int> pointIndex = default;
            Optional<GuidanceInstructionType> instructionType = default;
            Optional<IReadOnlyList<string>> roadNumbers = default;
            Optional<string> exitNumber = default;
            Optional<string> street = default;
            Optional<string> signpostText = default;
            Optional<string> countryCode = default;
            Optional<string> stateCode = default;
            Optional<JunctionType> junctionType = default;
            Optional<int> turnAngleInDecimalDegrees = default;
            Optional<string> roundaboutExitNumber = default;
            Optional<bool> possibleCombineWithNext = default;
            Optional<DrivingSide> drivingSide = default;
            Optional<GuidanceManeuver> maneuver = default;
            Optional<string> message = default;
            Optional<string> combinedMessage = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("routeOffsetInMeters"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    routeOffsetInMeters = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("travelTimeInSeconds"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    travelTimeInSeconds = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("point"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    point = LatLongPair.DeserializeLatLongPair(property.Value);
                    continue;
                }
                if (property.NameEquals("pointIndex"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    pointIndex = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("instructionType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    instructionType = new GuidanceInstructionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("roadNumbers"))
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
                    roadNumbers = array;
                    continue;
                }
                if (property.NameEquals("exitNumber"))
                {
                    exitNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("street"))
                {
                    street = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("signpostText"))
                {
                    signpostText = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("countryCode"))
                {
                    countryCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("stateCode"))
                {
                    stateCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("junctionType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    junctionType = new JunctionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("turnAngleInDecimalDegrees"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    turnAngleInDecimalDegrees = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("roundaboutExitNumber"))
                {
                    roundaboutExitNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("possibleCombineWithNext"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    possibleCombineWithNext = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("drivingSide"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    drivingSide = new DrivingSide(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("maneuver"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    maneuver = new GuidanceManeuver(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("message"))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("combinedMessage"))
                {
                    combinedMessage = property.Value.GetString();
                    continue;
                }
            }
            return new RouteInstruction(Optional.ToNullable(routeOffsetInMeters), Optional.ToNullable(travelTimeInSeconds), point.Value, Optional.ToNullable(pointIndex), Optional.ToNullable(instructionType), Optional.ToList(roadNumbers), exitNumber.Value, street.Value, signpostText.Value, countryCode.Value, stateCode.Value, Optional.ToNullable(junctionType), Optional.ToNullable(turnAngleInDecimalDegrees), roundaboutExitNumber.Value, Optional.ToNullable(possibleCombineWithNext), Optional.ToNullable(drivingSide), Optional.ToNullable(maneuver), message.Value, combinedMessage.Value);
        }
    }
}
