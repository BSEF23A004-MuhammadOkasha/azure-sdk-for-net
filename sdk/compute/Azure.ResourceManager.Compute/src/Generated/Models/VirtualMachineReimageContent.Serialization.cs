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

namespace Azure.ResourceManager.Compute.Models
{
    public partial class VirtualMachineReimageContent : IUtf8JsonSerializable, IModelJsonSerializable<VirtualMachineReimageContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<VirtualMachineReimageContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<VirtualMachineReimageContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<VirtualMachineReimageContent>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(TempDisk))
            {
                writer.WritePropertyName("tempDisk"u8);
                writer.WriteBooleanValue(TempDisk.Value);
            }
            if (Optional.IsDefined(ExactVersion))
            {
                writer.WritePropertyName("exactVersion"u8);
                writer.WriteStringValue(ExactVersion);
            }
            if (Optional.IsDefined(OSProfile))
            {
                writer.WritePropertyName("osProfile"u8);
                if (OSProfile is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<OSProfileProvisioningData>)OSProfile).Serialize(writer, options);
                }
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

        internal static VirtualMachineReimageContent DeserializeVirtualMachineReimageContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> tempDisk = default;
            Optional<string> exactVersion = default;
            Optional<OSProfileProvisioningData> osProfile = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tempDisk"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tempDisk = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("exactVersion"u8))
                {
                    exactVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("osProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    osProfile = OSProfileProvisioningData.DeserializeOSProfileProvisioningData(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new VirtualMachineReimageContent(Optional.ToNullable(tempDisk), exactVersion.Value, osProfile.Value, rawData);
        }

        VirtualMachineReimageContent IModelJsonSerializable<VirtualMachineReimageContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<VirtualMachineReimageContent>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualMachineReimageContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<VirtualMachineReimageContent>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<VirtualMachineReimageContent>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        VirtualMachineReimageContent IModelSerializable<VirtualMachineReimageContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<VirtualMachineReimageContent>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeVirtualMachineReimageContent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="VirtualMachineReimageContent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="VirtualMachineReimageContent"/> to convert. </param>
        public static implicit operator RequestContent(VirtualMachineReimageContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="VirtualMachineReimageContent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator VirtualMachineReimageContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeVirtualMachineReimageContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
