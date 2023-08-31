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

namespace Azure.ResourceManager.DeviceProvisioningServices.Models
{
    public partial class DeviceProvisioningServicesIPFilterRule : IUtf8JsonSerializable, IModelJsonSerializable<DeviceProvisioningServicesIPFilterRule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DeviceProvisioningServicesIPFilterRule>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DeviceProvisioningServicesIPFilterRule>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("filterName"u8);
            writer.WriteStringValue(FilterName);
            writer.WritePropertyName("action"u8);
            writer.WriteStringValue(Action.ToSerialString());
            writer.WritePropertyName("ipMask"u8);
            writer.WriteStringValue(IPMask);
            if (Optional.IsDefined(Target))
            {
                writer.WritePropertyName("target"u8);
                writer.WriteStringValue(Target.Value.ToSerialString());
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

        internal static DeviceProvisioningServicesIPFilterRule DeserializeDeviceProvisioningServicesIPFilterRule(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string filterName = default;
            DeviceProvisioningServicesIPFilterActionType action = default;
            string ipMask = default;
            Optional<DeviceProvisioningServicesIPFilterTargetType> target = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("filterName"u8))
                {
                    filterName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("action"u8))
                {
                    action = property.Value.GetString().ToDeviceProvisioningServicesIPFilterActionType();
                    continue;
                }
                if (property.NameEquals("ipMask"u8))
                {
                    ipMask = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("target"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    target = property.Value.GetString().ToDeviceProvisioningServicesIPFilterTargetType();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DeviceProvisioningServicesIPFilterRule(filterName, action, ipMask, Optional.ToNullable(target), rawData);
        }

        DeviceProvisioningServicesIPFilterRule IModelJsonSerializable<DeviceProvisioningServicesIPFilterRule>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDeviceProvisioningServicesIPFilterRule(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DeviceProvisioningServicesIPFilterRule>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DeviceProvisioningServicesIPFilterRule IModelSerializable<DeviceProvisioningServicesIPFilterRule>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDeviceProvisioningServicesIPFilterRule(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DeviceProvisioningServicesIPFilterRule"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DeviceProvisioningServicesIPFilterRule"/> to convert. </param>
        public static implicit operator RequestContent(DeviceProvisioningServicesIPFilterRule model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DeviceProvisioningServicesIPFilterRule"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DeviceProvisioningServicesIPFilterRule(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDeviceProvisioningServicesIPFilterRule(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
