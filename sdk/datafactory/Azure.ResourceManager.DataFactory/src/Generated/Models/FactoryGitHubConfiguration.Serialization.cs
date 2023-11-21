// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class FactoryGitHubConfiguration : IUtf8JsonSerializable, IJsonModel<FactoryGitHubConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FactoryGitHubConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<FactoryGitHubConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FactoryGitHubConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(FactoryGitHubConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(HostName))
            {
                writer.WritePropertyName("hostName"u8);
                writer.WriteStringValue(HostName);
            }
            if (Optional.IsDefined(ClientId))
            {
                writer.WritePropertyName("clientId"u8);
                writer.WriteStringValue(ClientId);
            }
            if (Optional.IsDefined(ClientSecret))
            {
                writer.WritePropertyName("clientSecret"u8);
                writer.WriteObjectValue(ClientSecret);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(FactoryRepoConfigurationType);
            writer.WritePropertyName("accountName"u8);
            writer.WriteStringValue(AccountName);
            writer.WritePropertyName("repositoryName"u8);
            writer.WriteStringValue(RepositoryName);
            writer.WritePropertyName("collaborationBranch"u8);
            writer.WriteStringValue(CollaborationBranch);
            writer.WritePropertyName("rootFolder"u8);
            writer.WriteStringValue(RootFolder);
            if (Optional.IsDefined(LastCommitId))
            {
                writer.WritePropertyName("lastCommitId"u8);
                writer.WriteStringValue(LastCommitId);
            }
            if (Optional.IsDefined(DisablePublish))
            {
                writer.WritePropertyName("disablePublish"u8);
                writer.WriteBooleanValue(DisablePublish.Value);
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

        FactoryGitHubConfiguration IJsonModel<FactoryGitHubConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FactoryGitHubConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(FactoryGitHubConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFactoryGitHubConfiguration(document.RootElement, options);
        }

        internal static FactoryGitHubConfiguration DeserializeFactoryGitHubConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> hostName = default;
            Optional<string> clientId = default;
            Optional<FactoryGitHubClientSecret> clientSecret = default;
            string type = default;
            string accountName = default;
            string repositoryName = default;
            string collaborationBranch = default;
            string rootFolder = default;
            Optional<string> lastCommitId = default;
            Optional<bool> disablePublish = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("hostName"u8))
                {
                    hostName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientId"u8))
                {
                    clientId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientSecret"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    clientSecret = FactoryGitHubClientSecret.DeserializeFactoryGitHubClientSecret(property.Value);
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("accountName"u8))
                {
                    accountName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("repositoryName"u8))
                {
                    repositoryName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("collaborationBranch"u8))
                {
                    collaborationBranch = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rootFolder"u8))
                {
                    rootFolder = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastCommitId"u8))
                {
                    lastCommitId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("disablePublish"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    disablePublish = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new FactoryGitHubConfiguration(type, accountName, repositoryName, collaborationBranch, rootFolder, lastCommitId.Value, Optional.ToNullable(disablePublish), serializedAdditionalRawData, hostName.Value, clientId.Value, clientSecret.Value);
        }

        BinaryData IPersistableModel<FactoryGitHubConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FactoryGitHubConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(FactoryGitHubConfiguration)} does not support '{options.Format}' format.");
            }
        }

        FactoryGitHubConfiguration IPersistableModel<FactoryGitHubConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FactoryGitHubConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFactoryGitHubConfiguration(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(FactoryGitHubConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<FactoryGitHubConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
