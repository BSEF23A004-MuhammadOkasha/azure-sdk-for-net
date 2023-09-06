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
    public partial class VirtualMachineScaleSetPriorityMixPolicy : IUtf8JsonSerializable, IModelJsonSerializable<VirtualMachineScaleSetPriorityMixPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<VirtualMachineScaleSetPriorityMixPolicy>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<VirtualMachineScaleSetPriorityMixPolicy>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<VirtualMachineScaleSetPriorityMixPolicy>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(BaseRegularPriorityCount))
            {
                writer.WritePropertyName("baseRegularPriorityCount"u8);
                writer.WriteNumberValue(BaseRegularPriorityCount.Value);
            }
            if (Optional.IsDefined(RegularPriorityPercentageAboveBase))
            {
                writer.WritePropertyName("regularPriorityPercentageAboveBase"u8);
                writer.WriteNumberValue(RegularPriorityPercentageAboveBase.Value);
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

        internal static VirtualMachineScaleSetPriorityMixPolicy DeserializeVirtualMachineScaleSetPriorityMixPolicy(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> baseRegularPriorityCount = default;
            Optional<int> regularPriorityPercentageAboveBase = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("baseRegularPriorityCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    baseRegularPriorityCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("regularPriorityPercentageAboveBase"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    regularPriorityPercentageAboveBase = property.Value.GetInt32();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new VirtualMachineScaleSetPriorityMixPolicy(Optional.ToNullable(baseRegularPriorityCount), Optional.ToNullable(regularPriorityPercentageAboveBase), rawData);
        }

        VirtualMachineScaleSetPriorityMixPolicy IModelJsonSerializable<VirtualMachineScaleSetPriorityMixPolicy>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<VirtualMachineScaleSetPriorityMixPolicy>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualMachineScaleSetPriorityMixPolicy(doc.RootElement, options);
        }

        BinaryData IModelSerializable<VirtualMachineScaleSetPriorityMixPolicy>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<VirtualMachineScaleSetPriorityMixPolicy>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        VirtualMachineScaleSetPriorityMixPolicy IModelSerializable<VirtualMachineScaleSetPriorityMixPolicy>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<VirtualMachineScaleSetPriorityMixPolicy>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeVirtualMachineScaleSetPriorityMixPolicy(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="VirtualMachineScaleSetPriorityMixPolicy"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="VirtualMachineScaleSetPriorityMixPolicy"/> to convert. </param>
        public static implicit operator RequestContent(VirtualMachineScaleSetPriorityMixPolicy model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="VirtualMachineScaleSetPriorityMixPolicy"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator VirtualMachineScaleSetPriorityMixPolicy(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeVirtualMachineScaleSetPriorityMixPolicy(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
