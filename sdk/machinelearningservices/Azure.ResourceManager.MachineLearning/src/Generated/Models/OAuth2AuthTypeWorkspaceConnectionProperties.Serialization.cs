// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class OAuth2AuthTypeWorkspaceConnectionProperties : IUtf8JsonSerializable, IJsonModel<OAuth2AuthTypeWorkspaceConnectionProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<OAuth2AuthTypeWorkspaceConnectionProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<OAuth2AuthTypeWorkspaceConnectionProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OAuth2AuthTypeWorkspaceConnectionProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OAuth2AuthTypeWorkspaceConnectionProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Credentials))
            {
                writer.WritePropertyName("credentials"u8);
                writer.WriteObjectValue(Credentials, options);
            }
            writer.WritePropertyName("authType"u8);
            writer.WriteStringValue(AuthType.ToString());
            if (Optional.IsDefined(Category))
            {
                writer.WritePropertyName("category"u8);
                writer.WriteStringValue(Category.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(CreatedByWorkspaceArmId))
            {
                writer.WritePropertyName("createdByWorkspaceArmId"u8);
                writer.WriteStringValue(CreatedByWorkspaceArmId);
            }
<<<<<<< HEAD
=======
            if (Optional.IsDefined(Error))
            {
                writer.WritePropertyName("error"u8);
                writer.WriteStringValue(Error);
            }
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
            if (Optional.IsDefined(ExpiryOn))
            {
                writer.WritePropertyName("expiryTime"u8);
                writer.WriteStringValue(ExpiryOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(Group))
            {
                writer.WritePropertyName("group"u8);
                writer.WriteStringValue(Group.Value.ToString());
            }
            if (Optional.IsDefined(IsSharedToAll))
            {
                writer.WritePropertyName("isSharedToAll"u8);
                writer.WriteBooleanValue(IsSharedToAll.Value);
            }
<<<<<<< HEAD
            if (Optional.IsDefined(Target))
            {
                writer.WritePropertyName("target"u8);
                writer.WriteStringValue(Target);
            }
=======
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
            if (Optional.IsCollectionDefined(Metadata))
            {
                writer.WritePropertyName("metadata"u8);
                writer.WriteStartObject();
                foreach (var item in Metadata)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
<<<<<<< HEAD
=======
            if (Optional.IsDefined(PeRequirement))
            {
                writer.WritePropertyName("peRequirement"u8);
                writer.WriteStringValue(PeRequirement.Value.ToString());
            }
            if (Optional.IsDefined(PeStatus))
            {
                writer.WritePropertyName("peStatus"u8);
                writer.WriteStringValue(PeStatus.Value.ToString());
            }
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
            if (Optional.IsCollectionDefined(SharedUserList))
            {
                writer.WritePropertyName("sharedUserList"u8);
                writer.WriteStartArray();
                foreach (var item in SharedUserList)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
<<<<<<< HEAD
            if (Optional.IsDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStringValue(Value);
            }
            if (Optional.IsDefined(ValueFormat))
            {
                writer.WritePropertyName("valueFormat"u8);
                writer.WriteStringValue(ValueFormat.Value.ToString());
=======
            if (Optional.IsDefined(Target))
            {
                writer.WritePropertyName("target"u8);
                writer.WriteStringValue(Target);
            }
            if (Optional.IsDefined(UseWorkspaceManagedIdentity))
            {
                writer.WritePropertyName("useWorkspaceManagedIdentity"u8);
                writer.WriteBooleanValue(UseWorkspaceManagedIdentity.Value);
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
            }
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

        OAuth2AuthTypeWorkspaceConnectionProperties IJsonModel<OAuth2AuthTypeWorkspaceConnectionProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OAuth2AuthTypeWorkspaceConnectionProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OAuth2AuthTypeWorkspaceConnectionProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOAuth2AuthTypeWorkspaceConnectionProperties(document.RootElement, options);
        }

        internal static OAuth2AuthTypeWorkspaceConnectionProperties DeserializeOAuth2AuthTypeWorkspaceConnectionProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            WorkspaceConnectionOAuth2 credentials = default;
            MachineLearningConnectionAuthType authType = default;
            MachineLearningConnectionCategory? category = default;
            ResourceIdentifier createdByWorkspaceArmId = default;
<<<<<<< HEAD
            DateTimeOffset? expiryTime = default;
            ConnectionGroup? group = default;
            bool? isSharedToAll = default;
            string target = default;
            IDictionary<string, string> metadata = default;
            IList<string> sharedUserList = default;
            string value = default;
            MachineLearningValueFormat? valueFormat = default;
=======
            string error = default;
            DateTimeOffset? expiryTime = default;
            ConnectionGroup? group = default;
            bool? isSharedToAll = default;
            IDictionary<string, string> metadata = default;
            ManagedPERequirement? peRequirement = default;
            ManagedPEStatus? peStatus = default;
            IList<string> sharedUserList = default;
            string target = default;
            bool? useWorkspaceManagedIdentity = default;
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("credentials"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    credentials = WorkspaceConnectionOAuth2.DeserializeWorkspaceConnectionOAuth2(property.Value, options);
                    continue;
                }
                if (property.NameEquals("authType"u8))
                {
                    authType = new MachineLearningConnectionAuthType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("category"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    category = new MachineLearningConnectionCategory(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("createdByWorkspaceArmId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createdByWorkspaceArmId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
<<<<<<< HEAD
=======
                if (property.NameEquals("error"u8))
                {
                    error = property.Value.GetString();
                    continue;
                }
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
                if (property.NameEquals("expiryTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expiryTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("group"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    group = new ConnectionGroup(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("isSharedToAll"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isSharedToAll = property.Value.GetBoolean();
                    continue;
                }
<<<<<<< HEAD
                if (property.NameEquals("target"u8))
                {
                    target = property.Value.GetString();
                    continue;
                }
=======
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
                if (property.NameEquals("metadata"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    metadata = dictionary;
                    continue;
                }
<<<<<<< HEAD
=======
                if (property.NameEquals("peRequirement"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    peRequirement = new ManagedPERequirement(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("peStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    peStatus = new ManagedPEStatus(property.Value.GetString());
                    continue;
                }
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
                if (property.NameEquals("sharedUserList"u8))
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
                    sharedUserList = array;
                    continue;
                }
<<<<<<< HEAD
                if (property.NameEquals("value"u8))
                {
                    value = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("valueFormat"u8))
=======
                if (property.NameEquals("target"u8))
                {
                    target = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("useWorkspaceManagedIdentity"u8))
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
<<<<<<< HEAD
                    valueFormat = new MachineLearningValueFormat(property.Value.GetString());
=======
                    useWorkspaceManagedIdentity = property.Value.GetBoolean();
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new OAuth2AuthTypeWorkspaceConnectionProperties(
                authType,
                category,
                createdByWorkspaceArmId,
<<<<<<< HEAD
                expiryTime,
                group,
                isSharedToAll,
                target,
                metadata ?? new ChangeTrackingDictionary<string, string>(),
                sharedUserList ?? new ChangeTrackingList<string>(),
                value,
                valueFormat,
=======
                error,
                expiryTime,
                group,
                isSharedToAll,
                metadata ?? new ChangeTrackingDictionary<string, string>(),
                peRequirement,
                peStatus,
                sharedUserList ?? new ChangeTrackingList<string>(),
                target,
                useWorkspaceManagedIdentity,
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
                serializedAdditionalRawData,
                credentials);
        }

        BinaryData IPersistableModel<OAuth2AuthTypeWorkspaceConnectionProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OAuth2AuthTypeWorkspaceConnectionProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(OAuth2AuthTypeWorkspaceConnectionProperties)} does not support writing '{options.Format}' format.");
            }
        }

        OAuth2AuthTypeWorkspaceConnectionProperties IPersistableModel<OAuth2AuthTypeWorkspaceConnectionProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OAuth2AuthTypeWorkspaceConnectionProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeOAuth2AuthTypeWorkspaceConnectionProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(OAuth2AuthTypeWorkspaceConnectionProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<OAuth2AuthTypeWorkspaceConnectionProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
