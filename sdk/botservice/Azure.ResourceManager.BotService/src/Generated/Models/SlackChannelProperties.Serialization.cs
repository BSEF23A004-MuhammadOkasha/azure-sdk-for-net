// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.BotService.Models
{
    public partial class SlackChannelProperties : IUtf8JsonSerializable, IJsonModel<SlackChannelProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SlackChannelProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SlackChannelProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SlackChannelProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SlackChannelProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (ClientId != null)
            {
                writer.WritePropertyName("clientId"u8);
                writer.WriteStringValue(ClientId);
            }
            if (ClientSecret != null)
            {
                writer.WritePropertyName("clientSecret"u8);
                writer.WriteStringValue(ClientSecret);
            }
            if (VerificationToken != null)
            {
                writer.WritePropertyName("verificationToken"u8);
                writer.WriteStringValue(VerificationToken);
            }
            if (Scopes != null)
            {
                writer.WritePropertyName("scopes"u8);
                writer.WriteStringValue(Scopes);
            }
            if (LandingPageUri != null)
            {
                writer.WritePropertyName("landingPageUrl"u8);
                writer.WriteStringValue(LandingPageUri.AbsoluteUri);
            }
            if (options.Format != "W" && RedirectAction != null)
            {
                writer.WritePropertyName("redirectAction"u8);
                writer.WriteStringValue(RedirectAction);
            }
            if (options.Format != "W" && LastSubmissionId != null)
            {
                writer.WritePropertyName("lastSubmissionId"u8);
                writer.WriteStringValue(LastSubmissionId);
            }
            if (RegisterBeforeOAuthFlow.HasValue)
            {
                writer.WritePropertyName("registerBeforeOAuthFlow"u8);
                writer.WriteBooleanValue(RegisterBeforeOAuthFlow.Value);
            }
            if (options.Format != "W" && IsValidated.HasValue)
            {
                writer.WritePropertyName("IsValidated"u8);
                writer.WriteBooleanValue(IsValidated.Value);
            }
            if (SigningSecret != null)
            {
                writer.WritePropertyName("signingSecret"u8);
                writer.WriteStringValue(SigningSecret);
            }
            writer.WritePropertyName("isEnabled"u8);
            writer.WriteBooleanValue(IsEnabled);
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        SlackChannelProperties IJsonModel<SlackChannelProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SlackChannelProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SlackChannelProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSlackChannelProperties(document.RootElement, options);
        }

        internal static SlackChannelProperties DeserializeSlackChannelProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string clientId = default;
            string clientSecret = default;
            string verificationToken = default;
            string scopes = default;
            Uri landingPageUrl = default;
            string redirectAction = default;
            string lastSubmissionId = default;
            bool? registerBeforeOAuthFlow = default;
            bool? isValidated = default;
            string signingSecret = default;
            bool isEnabled = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("clientId"u8))
                {
                    clientId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientSecret"u8))
                {
                    clientSecret = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("verificationToken"u8))
                {
                    verificationToken = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scopes"u8))
                {
                    scopes = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("landingPageUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    landingPageUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("redirectAction"u8))
                {
                    redirectAction = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastSubmissionId"u8))
                {
                    lastSubmissionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("registerBeforeOAuthFlow"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    registerBeforeOAuthFlow = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("IsValidated"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isValidated = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("signingSecret"u8))
                {
                    signingSecret = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isEnabled"u8))
                {
                    isEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SlackChannelProperties(
                clientId,
                clientSecret,
                verificationToken,
                scopes,
                landingPageUrl,
                redirectAction,
                lastSubmissionId,
                registerBeforeOAuthFlow,
                isValidated,
                signingSecret,
                isEnabled,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SlackChannelProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SlackChannelProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SlackChannelProperties)} does not support '{options.Format}' format.");
            }
        }

        SlackChannelProperties IPersistableModel<SlackChannelProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SlackChannelProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSlackChannelProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SlackChannelProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SlackChannelProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
