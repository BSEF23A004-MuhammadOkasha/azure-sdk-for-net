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

namespace Azure.ResourceManager.ContainerInstance.Models
{
    public partial class ContainerSecurityContextCapabilitiesDefinition : IUtf8JsonSerializable, IModelJsonSerializable<ContainerSecurityContextCapabilitiesDefinition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ContainerSecurityContextCapabilitiesDefinition>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ContainerSecurityContextCapabilitiesDefinition>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContainerSecurityContextCapabilitiesDefinition>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Add))
            {
                writer.WritePropertyName("add"u8);
                writer.WriteStartArray();
                foreach (var item in Add)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Drop))
            {
                writer.WritePropertyName("drop"u8);
                writer.WriteStartArray();
                foreach (var item in Drop)
                {
                    writer.WriteStringValue(item);
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

        internal static ContainerSecurityContextCapabilitiesDefinition DeserializeContainerSecurityContextCapabilitiesDefinition(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<string>> @add = default;
            Optional<IList<string>> drop = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("add"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    @add = array;
                    continue;
                }
                if (property.NameEquals("drop"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    drop = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ContainerSecurityContextCapabilitiesDefinition(Optional.ToList(@add), Optional.ToList(drop), rawData);
        }

        ContainerSecurityContextCapabilitiesDefinition IModelJsonSerializable<ContainerSecurityContextCapabilitiesDefinition>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContainerSecurityContextCapabilitiesDefinition>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerSecurityContextCapabilitiesDefinition(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ContainerSecurityContextCapabilitiesDefinition>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContainerSecurityContextCapabilitiesDefinition>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ContainerSecurityContextCapabilitiesDefinition IModelSerializable<ContainerSecurityContextCapabilitiesDefinition>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContainerSecurityContextCapabilitiesDefinition>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeContainerSecurityContextCapabilitiesDefinition(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ContainerSecurityContextCapabilitiesDefinition"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ContainerSecurityContextCapabilitiesDefinition"/> to convert. </param>
        public static implicit operator RequestContent(ContainerSecurityContextCapabilitiesDefinition model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ContainerSecurityContextCapabilitiesDefinition"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ContainerSecurityContextCapabilitiesDefinition(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeContainerSecurityContextCapabilitiesDefinition(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
