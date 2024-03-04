// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ApiManagement;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class ApiManagementGroupUserData : IUtf8JsonSerializable, IJsonModel<ApiManagementGroupUserData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ApiManagementGroupUserData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ApiManagementGroupUserData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiManagementGroupUserData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApiManagementGroupUserData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            if (Optional.IsDefined(Note))
            {
                writer.WritePropertyName("note"u8);
                writer.WriteStringValue(Note);
            }
            if (Optional.IsCollectionDefined(Identities))
            {
                writer.WritePropertyName("identities"u8);
                writer.WriteStartArray();
                foreach (var item in Identities)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(FirstName))
            {
                writer.WritePropertyName("firstName"u8);
                writer.WriteStringValue(FirstName);
            }
            if (Optional.IsDefined(LastName))
            {
                writer.WritePropertyName("lastName"u8);
                writer.WriteStringValue(LastName);
            }
            if (Optional.IsDefined(Email))
            {
                writer.WritePropertyName("email"u8);
                writer.WriteStringValue(Email);
            }
            if (Optional.IsDefined(RegistriesOn))
            {
                writer.WritePropertyName("registrationDate"u8);
                writer.WriteStringValue(RegistriesOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Groups))
            {
                writer.WritePropertyName("groups"u8);
                writer.WriteStartArray();
                foreach (var item in Groups)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        ApiManagementGroupUserData IJsonModel<ApiManagementGroupUserData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiManagementGroupUserData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApiManagementGroupUserData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeApiManagementGroupUserData(document.RootElement, options);
        }

        internal static ApiManagementGroupUserData DeserializeApiManagementGroupUserData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            ApiManagementUserState? state = default;
            string note = default;
            IList<UserIdentityContract> identities = default;
            string firstName = default;
            string lastName = default;
            string email = default;
            DateTimeOffset? registrationDate = default;
            IReadOnlyList<GroupContractProperties> groups = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
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
                        if (property0.NameEquals("state"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            state = new ApiManagementUserState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("note"u8))
                        {
                            note = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("identities"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<UserIdentityContract> array = new List<UserIdentityContract>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(UserIdentityContract.DeserializeUserIdentityContract(item, options));
                            }
                            identities = array;
                            continue;
                        }
                        if (property0.NameEquals("firstName"u8))
                        {
                            firstName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("lastName"u8))
                        {
                            lastName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("email"u8))
                        {
                            email = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("registrationDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            registrationDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("groups"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<GroupContractProperties> array = new List<GroupContractProperties>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(GroupContractProperties.DeserializeGroupContractProperties(item, options));
                            }
                            groups = array;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ApiManagementGroupUserData(
                id,
                name,
                type,
                systemData,
                state,
                note,
                identities ?? new ChangeTrackingList<UserIdentityContract>(),
                firstName,
                lastName,
                email,
                registrationDate,
                groups ?? new ChangeTrackingList<GroupContractProperties>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ApiManagementGroupUserData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiManagementGroupUserData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ApiManagementGroupUserData)} does not support '{options.Format}' format.");
            }
        }

        ApiManagementGroupUserData IPersistableModel<ApiManagementGroupUserData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiManagementGroupUserData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeApiManagementGroupUserData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ApiManagementGroupUserData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ApiManagementGroupUserData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
