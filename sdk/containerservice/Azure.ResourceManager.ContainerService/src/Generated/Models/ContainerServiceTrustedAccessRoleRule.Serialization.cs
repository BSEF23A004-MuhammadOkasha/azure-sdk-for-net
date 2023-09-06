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

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class ContainerServiceTrustedAccessRoleRule : IUtf8JsonSerializable, IModelJsonSerializable<ContainerServiceTrustedAccessRoleRule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ContainerServiceTrustedAccessRoleRule>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ContainerServiceTrustedAccessRoleRule>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContainerServiceTrustedAccessRoleRule>(this, options.Format);

            writer.WriteStartObject();
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

        internal static ContainerServiceTrustedAccessRoleRule DeserializeContainerServiceTrustedAccessRoleRule(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<string>> verbs = default;
            Optional<IReadOnlyList<string>> apiGroups = default;
            Optional<IReadOnlyList<string>> resources = default;
            Optional<IReadOnlyList<string>> resourceNames = default;
            Optional<IReadOnlyList<string>> nonResourceUrls = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("verbs"u8))
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
                    verbs = array;
                    continue;
                }
                if (property.NameEquals("apiGroups"u8))
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
                    apiGroups = array;
                    continue;
                }
                if (property.NameEquals("resources"u8))
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
                    resources = array;
                    continue;
                }
                if (property.NameEquals("resourceNames"u8))
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
                    resourceNames = array;
                    continue;
                }
                if (property.NameEquals("nonResourceURLs"u8))
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
                    nonResourceUrls = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ContainerServiceTrustedAccessRoleRule(Optional.ToList(verbs), Optional.ToList(apiGroups), Optional.ToList(resources), Optional.ToList(resourceNames), Optional.ToList(nonResourceUrls), rawData);
        }

        ContainerServiceTrustedAccessRoleRule IModelJsonSerializable<ContainerServiceTrustedAccessRoleRule>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContainerServiceTrustedAccessRoleRule>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerServiceTrustedAccessRoleRule(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ContainerServiceTrustedAccessRoleRule>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContainerServiceTrustedAccessRoleRule>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ContainerServiceTrustedAccessRoleRule IModelSerializable<ContainerServiceTrustedAccessRoleRule>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContainerServiceTrustedAccessRoleRule>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeContainerServiceTrustedAccessRoleRule(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ContainerServiceTrustedAccessRoleRule"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ContainerServiceTrustedAccessRoleRule"/> to convert. </param>
        public static implicit operator RequestContent(ContainerServiceTrustedAccessRoleRule model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ContainerServiceTrustedAccessRoleRule"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ContainerServiceTrustedAccessRoleRule(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeContainerServiceTrustedAccessRoleRule(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
