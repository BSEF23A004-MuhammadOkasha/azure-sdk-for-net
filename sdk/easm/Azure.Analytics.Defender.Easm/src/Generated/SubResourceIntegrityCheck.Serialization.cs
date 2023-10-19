// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.Analytics.Defender.Easm
{
    public partial class SubResourceIntegrityCheck : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Violation))
            {
                writer.WritePropertyName("violation"u8);
                writer.WriteBooleanValue(Violation.Value);
            }
            if (Optional.IsDefined(FirstSeen))
            {
                writer.WritePropertyName("firstSeen"u8);
                writer.WriteStringValue(FirstSeen.Value, "O");
            }
            if (Optional.IsDefined(LastSeen))
            {
                writer.WritePropertyName("lastSeen"u8);
                writer.WriteStringValue(LastSeen.Value, "O");
            }
            if (Optional.IsDefined(Count))
            {
                writer.WritePropertyName("count"u8);
                writer.WriteNumberValue(Count.Value);
            }
            if (Optional.IsDefined(CausePageUrl))
            {
                writer.WritePropertyName("causePageUrl"u8);
                writer.WriteStringValue(CausePageUrl);
            }
            if (Optional.IsDefined(CrawlGuid))
            {
                writer.WritePropertyName("crawlGuid"u8);
                writer.WriteStringValue(CrawlGuid);
            }
            if (Optional.IsDefined(PageGuid))
            {
                writer.WritePropertyName("pageGuid"u8);
                writer.WriteStringValue(PageGuid);
            }
            if (Optional.IsDefined(ResourceGuid))
            {
                writer.WritePropertyName("resourceGuid"u8);
                writer.WriteStringValue(ResourceGuid);
            }
            if (Optional.IsDefined(ExpectedHash))
            {
                writer.WritePropertyName("expectedHash"u8);
                writer.WriteStringValue(ExpectedHash);
            }
            writer.WriteEndObject();
        }

        internal static SubResourceIntegrityCheck DeserializeSubResourceIntegrityCheck(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> violation = default;
            Optional<DateTimeOffset> firstSeen = default;
            Optional<DateTimeOffset> lastSeen = default;
            Optional<long> count = default;
            Optional<string> causePageUrl = default;
            Optional<string> crawlGuid = default;
            Optional<string> pageGuid = default;
            Optional<string> resourceGuid = default;
            Optional<string> expectedHash = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("violation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    violation = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("firstSeen"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    firstSeen = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastSeen"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastSeen = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("count"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    count = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("causePageUrl"u8))
                {
                    causePageUrl = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("crawlGuid"u8))
                {
                    crawlGuid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("pageGuid"u8))
                {
                    pageGuid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceGuid"u8))
                {
                    resourceGuid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("expectedHash"u8))
                {
                    expectedHash = property.Value.GetString();
                    continue;
                }
            }
            return new SubResourceIntegrityCheck(Optional.ToNullable(violation), Optional.ToNullable(firstSeen), Optional.ToNullable(lastSeen), Optional.ToNullable(count), causePageUrl.Value, crawlGuid.Value, pageGuid.Value, resourceGuid.Value, expectedHash.Value);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static SubResourceIntegrityCheck FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeSubResourceIntegrityCheck(document.RootElement);
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
