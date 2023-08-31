// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.FrontDoor.Models
{
    public partial class FrontDoorWebApplicationFirewallPolicySettings : IUtf8JsonSerializable, IModelJsonSerializable<FrontDoorWebApplicationFirewallPolicySettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<FrontDoorWebApplicationFirewallPolicySettings>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<FrontDoorWebApplicationFirewallPolicySettings>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(EnabledState))
            {
                writer.WritePropertyName("enabledState"u8);
                writer.WriteStringValue(EnabledState.Value.ToString());
            }
            if (Optional.IsDefined(Mode))
            {
                writer.WritePropertyName("mode"u8);
                writer.WriteStringValue(Mode.Value.ToString());
            }
            if (Optional.IsDefined(RedirectUri))
            {
                writer.WritePropertyName("redirectUrl"u8);
                writer.WriteStringValue(RedirectUri.AbsoluteUri);
            }
            if (Optional.IsDefined(CustomBlockResponseStatusCode))
            {
                writer.WritePropertyName("customBlockResponseStatusCode"u8);
                writer.WriteNumberValue(CustomBlockResponseStatusCode.Value);
            }
            if (Optional.IsDefined(CustomBlockResponseBody))
            {
                writer.WritePropertyName("customBlockResponseBody"u8);
                writer.WriteStringValue(CustomBlockResponseBody);
            }
            if (Optional.IsDefined(RequestBodyCheck))
            {
                writer.WritePropertyName("requestBodyCheck"u8);
                writer.WriteStringValue(RequestBodyCheck.Value.ToString());
            }
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static FrontDoorWebApplicationFirewallPolicySettings DeserializeFrontDoorWebApplicationFirewallPolicySettings(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<PolicyEnabledState> enabledState = default;
            Optional<FrontDoorWebApplicationFirewallPolicyMode> mode = default;
            Optional<Uri> redirectUrl = default;
            Optional<int> customBlockResponseStatusCode = default;
            Optional<string> customBlockResponseBody = default;
            Optional<PolicyRequestBodyCheck> requestBodyCheck = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabledState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabledState = new PolicyEnabledState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("mode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mode = new FrontDoorWebApplicationFirewallPolicyMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("redirectUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    redirectUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("customBlockResponseStatusCode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    customBlockResponseStatusCode = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("customBlockResponseBody"u8))
                {
                    customBlockResponseBody = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("requestBodyCheck"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    requestBodyCheck = new PolicyRequestBodyCheck(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new FrontDoorWebApplicationFirewallPolicySettings(Optional.ToNullable(enabledState), Optional.ToNullable(mode), redirectUrl.Value, Optional.ToNullable(customBlockResponseStatusCode), customBlockResponseBody.Value, Optional.ToNullable(requestBodyCheck), rawData);
        }

        FrontDoorWebApplicationFirewallPolicySettings IModelJsonSerializable<FrontDoorWebApplicationFirewallPolicySettings>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeFrontDoorWebApplicationFirewallPolicySettings(doc.RootElement, options);
        }

        BinaryData IModelSerializable<FrontDoorWebApplicationFirewallPolicySettings>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        FrontDoorWebApplicationFirewallPolicySettings IModelSerializable<FrontDoorWebApplicationFirewallPolicySettings>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeFrontDoorWebApplicationFirewallPolicySettings(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="FrontDoorWebApplicationFirewallPolicySettings"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="FrontDoorWebApplicationFirewallPolicySettings"/> to convert. </param>
        public static implicit operator RequestContent(FrontDoorWebApplicationFirewallPolicySettings model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="FrontDoorWebApplicationFirewallPolicySettings"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator FrontDoorWebApplicationFirewallPolicySettings(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeFrontDoorWebApplicationFirewallPolicySettings(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
