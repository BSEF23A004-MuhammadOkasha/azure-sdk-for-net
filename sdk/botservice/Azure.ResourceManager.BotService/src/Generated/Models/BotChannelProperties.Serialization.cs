// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.BotService.Models
{
    public partial class BotChannelProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("channelName"u8);
            writer.WriteStringValue(ChannelName);
            if (Optional.IsDefined(ETag))
            {
                if (ETag != null)
                {
                    writer.WritePropertyName("etag"u8);
                    writer.WriteStringValue(ETag.Value.ToString());
                }
                else
                {
                    writer.WriteNull("etag");
                }
            }
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            writer.WriteEndObject();
        }

        internal static BotChannelProperties DeserializeBotChannelProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("channelName", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AcsChatChannel": return AcsChatChannel.DeserializeAcsChatChannel(element);
                    case "AlexaChannel": return AlexaChannel.DeserializeAlexaChannel(element);
                    case "DirectLineChannel": return DirectLineChannel.DeserializeDirectLineChannel(element);
                    case "DirectLineSpeechChannel": return DirectLineSpeechChannel.DeserializeDirectLineSpeechChannel(element);
                    case "EmailChannel": return EmailChannel.DeserializeEmailChannel(element);
                    case "FacebookChannel": return FacebookChannel.DeserializeFacebookChannel(element);
                    case "KikChannel": return KikChannel.DeserializeKikChannel(element);
                    case "LineChannel": return LineChannel.DeserializeLineChannel(element);
                    case "M365Extensions": return M365Extensions.DeserializeM365Extensions(element);
                    case "MsTeamsChannel": return MsTeamsChannel.DeserializeMsTeamsChannel(element);
                    case "Omnichannel": return Omnichannel.DeserializeOmnichannel(element);
                    case "OutlookChannel": return OutlookChannel.DeserializeOutlookChannel(element);
                    case "SearchAssistant": return SearchAssistant.DeserializeSearchAssistant(element);
                    case "SkypeChannel": return SkypeChannel.DeserializeSkypeChannel(element);
                    case "SlackChannel": return SlackChannel.DeserializeSlackChannel(element);
                    case "SmsChannel": return SmsChannel.DeserializeSmsChannel(element);
                    case "TelegramChannel": return TelegramChannel.DeserializeTelegramChannel(element);
                    case "TelephonyChannel": return TelephonyChannel.DeserializeTelephonyChannel(element);
                    case "WebChatChannel": return WebChatChannel.DeserializeWebChatChannel(element);
                }
            }
            return UnknownChannel.DeserializeUnknownChannel(element);
        }
    }
}
