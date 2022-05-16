// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Communication.MediaComposition.Models;
using Azure.Core;

namespace Azure.Communication.MediaComposition
{
    public partial class MediaInput : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(GroupCall))
            {
                writer.WritePropertyName("groupCall");
                writer.WriteObjectValue(GroupCall);
            }
            if (Optional.IsDefined(Room))
            {
                writer.WritePropertyName("room");
                writer.WriteObjectValue(Room);
            }
            if (Optional.IsDefined(TeamsMeeting))
            {
                writer.WritePropertyName("teamsMeeting");
                writer.WriteObjectValue(TeamsMeeting);
            }
            if (Optional.IsDefined(Rtmp))
            {
                writer.WritePropertyName("rtmp");
                writer.WriteObjectValue(Rtmp);
            }
            if (Optional.IsDefined(Srt))
            {
                writer.WritePropertyName("srt");
                writer.WriteObjectValue(Srt);
            }
            if (Optional.IsDefined(Participant))
            {
                writer.WritePropertyName("participant");
                writer.WriteObjectValue(Participant);
            }
            if (Optional.IsDefined(ActivePresenter))
            {
                writer.WritePropertyName("activePresenter");
                writer.WriteObjectValue(ActivePresenter);
            }
            if (Optional.IsDefined(DominantSpeaker))
            {
                writer.WritePropertyName("dominantSpeaker");
                writer.WriteObjectValue(DominantSpeaker);
            }
            if (Optional.IsDefined(ScreenShare))
            {
                writer.WritePropertyName("screenShare");
                writer.WriteObjectValue(ScreenShare);
            }
            if (Optional.IsDefined(Image))
            {
                writer.WritePropertyName("image");
                writer.WriteObjectValue(Image);
            }
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind");
                writer.WriteStringValue(Kind.Value.ToSerialString());
            }
            writer.WriteEndObject();
        }

        internal static MediaInput DeserializeMediaInput(JsonElement element)
        {
            Optional<GroupCall> groupCall = default;
            Optional<GroupCall> room = default;
            Optional<TeamsMeeting> teamsMeeting = default;
            Optional<RtmpStream> rtmp = default;
            Optional<SrtStream> srt = default;
            Optional<ParticipantInput> participant = default;
            Optional<CommunicationCallIdentifierModel> activePresenter = default;
            Optional<CommunicationCallIdentifierModel> dominantSpeaker = default;
            Optional<CommunicationCallIdentifierModel> screenShare = default;
            Optional<ImageInput> image = default;
            Optional<MediaInputType> kind = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("groupCall"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    groupCall = GroupCall.DeserializeGroupCall(property.Value);
                    continue;
                }
                if (property.NameEquals("room"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    room = GroupCall.DeserializeGroupCall(property.Value);
                    continue;
                }
                if (property.NameEquals("teamsMeeting"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    teamsMeeting = TeamsMeeting.DeserializeTeamsMeeting(property.Value);
                    continue;
                }
                if (property.NameEquals("rtmp"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    rtmp = RtmpStream.DeserializeRtmpStream(property.Value);
                    continue;
                }
                if (property.NameEquals("srt"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    srt = SrtStream.DeserializeSrtStream(property.Value);
                    continue;
                }
                if (property.NameEquals("participant"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    participant = ParticipantInput.DeserializeParticipantInput(property.Value);
                    continue;
                }
                if (property.NameEquals("activePresenter"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    activePresenter = CommunicationCallIdentifierModel.DeserializeCommunicationCallIdentifierModel(property.Value);
                    continue;
                }
                if (property.NameEquals("dominantSpeaker"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    dominantSpeaker = CommunicationCallIdentifierModel.DeserializeCommunicationCallIdentifierModel(property.Value);
                    continue;
                }
                if (property.NameEquals("screenShare"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    screenShare = CommunicationCallIdentifierModel.DeserializeCommunicationCallIdentifierModel(property.Value);
                    continue;
                }
                if (property.NameEquals("image"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    image = ImageInput.DeserializeImageInput(property.Value);
                    continue;
                }
                if (property.NameEquals("kind"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    kind = property.Value.GetString().ToMediaInputType();
                    continue;
                }
            }
            return new MediaInput(groupCall.Value, room.Value, teamsMeeting.Value, rtmp.Value, srt.Value, participant.Value, activePresenter.Value, dominantSpeaker.Value, screenShare.Value, image.Value, Optional.ToNullable(kind));
        }
    }
}
