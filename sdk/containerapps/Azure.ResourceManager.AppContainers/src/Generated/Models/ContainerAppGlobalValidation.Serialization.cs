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
    public partial class ContainerAppGlobalValidation : IUtf8JsonSerializable, IModelJsonSerializable<ContainerAppGlobalValidation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ContainerAppGlobalValidation>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ContainerAppGlobalValidation>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContainerAppGlobalValidation>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(UnauthenticatedClientAction))
            {
                writer.WritePropertyName("unauthenticatedClientAction"u8);
                writer.WriteStringValue(UnauthenticatedClientAction.Value.ToSerialString());
            }
            if (Optional.IsDefined(RedirectToProvider))
            {
                writer.WritePropertyName("redirectToProvider"u8);
                writer.WriteStringValue(RedirectToProvider);
            }
            if (Optional.IsCollectionDefined(ExcludedPaths))
            {
                writer.WritePropertyName("excludedPaths"u8);
                writer.WriteStartArray();
                foreach (var item in ExcludedPaths)
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

        internal static ContainerAppGlobalValidation DeserializeContainerAppGlobalValidation(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ContainerAppUnauthenticatedClientActionV2> unauthenticatedClientAction = default;
            Optional<string> redirectToProvider = default;
            Optional<IList<string>> excludedPaths = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("unauthenticatedClientAction"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    unauthenticatedClientAction = property.Value.GetString().ToContainerAppUnauthenticatedClientActionV2();
                    continue;
                }
                if (property.NameEquals("redirectToProvider"u8))
                {
                    redirectToProvider = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("excludedPaths"u8))
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
                    excludedPaths = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ContainerAppGlobalValidation(Optional.ToNullable(unauthenticatedClientAction), redirectToProvider.Value, Optional.ToList(excludedPaths), rawData);
        }

        ContainerAppGlobalValidation IModelJsonSerializable<ContainerAppGlobalValidation>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContainerAppGlobalValidation>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerAppGlobalValidation(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ContainerAppGlobalValidation>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContainerAppGlobalValidation>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ContainerAppGlobalValidation IModelSerializable<ContainerAppGlobalValidation>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContainerAppGlobalValidation>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeContainerAppGlobalValidation(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ContainerAppGlobalValidation"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ContainerAppGlobalValidation"/> to convert. </param>
        public static implicit operator RequestContent(ContainerAppGlobalValidation model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ContainerAppGlobalValidation"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ContainerAppGlobalValidation(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeContainerAppGlobalValidation(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
