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
using Azure.ResourceManager.CustomerInsights.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CustomerInsights
{
    public partial class RelationshipLinkResourceFormatData : IUtf8JsonSerializable, IModelJsonSerializable<RelationshipLinkResourceFormatData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<RelationshipLinkResourceFormatData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<RelationshipLinkResourceFormatData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RelationshipLinkResourceFormatData>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStartObject();
                foreach (var item in DisplayName)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStartObject();
                foreach (var item in Description)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(InteractionType))
            {
                writer.WritePropertyName("interactionType"u8);
                writer.WriteStringValue(InteractionType);
            }
            if (Optional.IsCollectionDefined(Mappings))
            {
                writer.WritePropertyName("mappings"u8);
                writer.WriteStartArray();
                foreach (var item in Mappings)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<RelationshipLinkFieldMapping>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ProfilePropertyReferences))
            {
                writer.WritePropertyName("profilePropertyReferences"u8);
                writer.WriteStartArray();
                foreach (var item in ProfilePropertyReferences)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<ParticipantProfilePropertyReference>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(RelatedProfilePropertyReferences))
            {
                writer.WritePropertyName("relatedProfilePropertyReferences"u8);
                writer.WriteStartArray();
                foreach (var item in RelatedProfilePropertyReferences)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<ParticipantProfilePropertyReference>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(RelationshipName))
            {
                writer.WritePropertyName("relationshipName"u8);
                writer.WriteStringValue(RelationshipName);
            }
            writer.WriteEndObject();
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

        internal static RelationshipLinkResourceFormatData DeserializeRelationshipLinkResourceFormatData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<IDictionary<string, string>> displayName = default;
            Optional<IDictionary<string, string>> description = default;
            Optional<string> interactionType = default;
            Optional<string> linkName = default;
            Optional<IList<RelationshipLinkFieldMapping>> mappings = default;
            Optional<IList<ParticipantProfilePropertyReference>> profilePropertyReferences = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<IList<ParticipantProfilePropertyReference>> relatedProfilePropertyReferences = default;
            Optional<string> relationshipName = default;
            Optional<string> relationshipGuidId = default;
            Optional<Guid> tenantId = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("displayName"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            displayName = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            description = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("interactionType"u8))
                        {
                            interactionType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("linkName"u8))
                        {
                            linkName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("mappings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<RelationshipLinkFieldMapping> array = new List<RelationshipLinkFieldMapping>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(RelationshipLinkFieldMapping.DeserializeRelationshipLinkFieldMapping(item));
                            }
                            mappings = array;
                            continue;
                        }
                        if (property0.NameEquals("profilePropertyReferences"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ParticipantProfilePropertyReference> array = new List<ParticipantProfilePropertyReference>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ParticipantProfilePropertyReference.DeserializeParticipantProfilePropertyReference(item));
                            }
                            profilePropertyReferences = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("relatedProfilePropertyReferences"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ParticipantProfilePropertyReference> array = new List<ParticipantProfilePropertyReference>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ParticipantProfilePropertyReference.DeserializeParticipantProfilePropertyReference(item));
                            }
                            relatedProfilePropertyReferences = array;
                            continue;
                        }
                        if (property0.NameEquals("relationshipName"u8))
                        {
                            relationshipName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("relationshipGuidId"u8))
                        {
                            relationshipGuidId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("tenantId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            tenantId = property0.Value.GetGuid();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new RelationshipLinkResourceFormatData(id, name, type, systemData.Value, Optional.ToDictionary(displayName), Optional.ToDictionary(description), interactionType.Value, linkName.Value, Optional.ToList(mappings), Optional.ToList(profilePropertyReferences), Optional.ToNullable(provisioningState), Optional.ToList(relatedProfilePropertyReferences), relationshipName.Value, relationshipGuidId.Value, Optional.ToNullable(tenantId), rawData);
        }

        RelationshipLinkResourceFormatData IModelJsonSerializable<RelationshipLinkResourceFormatData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RelationshipLinkResourceFormatData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeRelationshipLinkResourceFormatData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<RelationshipLinkResourceFormatData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RelationshipLinkResourceFormatData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        RelationshipLinkResourceFormatData IModelSerializable<RelationshipLinkResourceFormatData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RelationshipLinkResourceFormatData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeRelationshipLinkResourceFormatData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="RelationshipLinkResourceFormatData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="RelationshipLinkResourceFormatData"/> to convert. </param>
        public static implicit operator RequestContent(RelationshipLinkResourceFormatData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="RelationshipLinkResourceFormatData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator RelationshipLinkResourceFormatData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeRelationshipLinkResourceFormatData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
