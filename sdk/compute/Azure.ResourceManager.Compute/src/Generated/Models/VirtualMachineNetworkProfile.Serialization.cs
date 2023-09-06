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
    public partial class VirtualMachineNetworkProfile : IUtf8JsonSerializable, IModelJsonSerializable<VirtualMachineNetworkProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<VirtualMachineNetworkProfile>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<VirtualMachineNetworkProfile>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<VirtualMachineNetworkProfile>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(NetworkInterfaces))
            {
                writer.WritePropertyName("networkInterfaces"u8);
                writer.WriteStartArray();
                foreach (var item in NetworkInterfaces)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<VirtualMachineNetworkInterfaceReference>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(NetworkApiVersion))
            {
                writer.WritePropertyName("networkApiVersion"u8);
                writer.WriteStringValue(NetworkApiVersion.Value.ToString());
            }
            if (Optional.IsCollectionDefined(NetworkInterfaceConfigurations))
            {
                writer.WritePropertyName("networkInterfaceConfigurations"u8);
                writer.WriteStartArray();
                foreach (var item in NetworkInterfaceConfigurations)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<VirtualMachineNetworkInterfaceConfiguration>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
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

        internal static VirtualMachineNetworkProfile DeserializeVirtualMachineNetworkProfile(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<VirtualMachineNetworkInterfaceReference>> networkInterfaces = default;
            Optional<NetworkApiVersion> networkApiVersion = default;
            Optional<IList<VirtualMachineNetworkInterfaceConfiguration>> networkInterfaceConfigurations = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("networkInterfaces"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<VirtualMachineNetworkInterfaceReference> array = new List<VirtualMachineNetworkInterfaceReference>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VirtualMachineNetworkInterfaceReference.DeserializeVirtualMachineNetworkInterfaceReference(item));
                    }
                    networkInterfaces = array;
                    continue;
                }
                if (property.NameEquals("networkApiVersion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    networkApiVersion = new NetworkApiVersion(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("networkInterfaceConfigurations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<VirtualMachineNetworkInterfaceConfiguration> array = new List<VirtualMachineNetworkInterfaceConfiguration>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VirtualMachineNetworkInterfaceConfiguration.DeserializeVirtualMachineNetworkInterfaceConfiguration(item));
                    }
                    networkInterfaceConfigurations = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new VirtualMachineNetworkProfile(Optional.ToList(networkInterfaces), Optional.ToNullable(networkApiVersion), Optional.ToList(networkInterfaceConfigurations), rawData);
        }

        VirtualMachineNetworkProfile IModelJsonSerializable<VirtualMachineNetworkProfile>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<VirtualMachineNetworkProfile>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualMachineNetworkProfile(doc.RootElement, options);
        }

        BinaryData IModelSerializable<VirtualMachineNetworkProfile>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<VirtualMachineNetworkProfile>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        VirtualMachineNetworkProfile IModelSerializable<VirtualMachineNetworkProfile>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<VirtualMachineNetworkProfile>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeVirtualMachineNetworkProfile(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="VirtualMachineNetworkProfile"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="VirtualMachineNetworkProfile"/> to convert. </param>
        public static implicit operator RequestContent(VirtualMachineNetworkProfile model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="VirtualMachineNetworkProfile"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator VirtualMachineNetworkProfile(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeVirtualMachineNetworkProfile(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
