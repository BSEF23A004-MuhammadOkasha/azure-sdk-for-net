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

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class ContainerAppOpenIdConnectLogin : IUtf8JsonSerializable, IModelJsonSerializable<ContainerAppOpenIdConnectLogin>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ContainerAppOpenIdConnectLogin>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ContainerAppOpenIdConnectLogin>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContainerAppOpenIdConnectLogin>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(NameClaimType))
            {
                writer.WritePropertyName("nameClaimType"u8);
                writer.WriteStringValue(NameClaimType);
            }
            if (Optional.IsCollectionDefined(Scopes))
            {
                writer.WritePropertyName("scopes"u8);
                writer.WriteStartArray();
                foreach (var item in Scopes)
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

        internal static ContainerAppOpenIdConnectLogin DeserializeContainerAppOpenIdConnectLogin(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> nameClaimType = default;
            Optional<IList<string>> scopes = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nameClaimType"u8))
                {
                    nameClaimType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scopes"u8))
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
                    scopes = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ContainerAppOpenIdConnectLogin(nameClaimType.Value, Optional.ToList(scopes), rawData);
        }

        ContainerAppOpenIdConnectLogin IModelJsonSerializable<ContainerAppOpenIdConnectLogin>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContainerAppOpenIdConnectLogin>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerAppOpenIdConnectLogin(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ContainerAppOpenIdConnectLogin>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContainerAppOpenIdConnectLogin>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ContainerAppOpenIdConnectLogin IModelSerializable<ContainerAppOpenIdConnectLogin>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContainerAppOpenIdConnectLogin>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeContainerAppOpenIdConnectLogin(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ContainerAppOpenIdConnectLogin"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ContainerAppOpenIdConnectLogin"/> to convert. </param>
        public static implicit operator RequestContent(ContainerAppOpenIdConnectLogin model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ContainerAppOpenIdConnectLogin"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ContainerAppOpenIdConnectLogin(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeContainerAppOpenIdConnectLogin(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
