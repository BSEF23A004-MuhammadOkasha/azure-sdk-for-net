// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Resources.Models
{
    public partial class AzureCliScript : IUtf8JsonSerializable, IJsonModel<AzureCliScript>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AzureCliScript>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<AzureCliScript>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                writer.WriteObjectValue(Identity);
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(SystemData))
                {
                    writer.WritePropertyName("systemData"u8);
                    JsonSerializer.Serialize(writer, SystemData);
                }
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ContainerSettings))
            {
                writer.WritePropertyName("containerSettings"u8);
                writer.WriteObjectValue(ContainerSettings);
            }
            if (Optional.IsDefined(StorageAccountSettings))
            {
                writer.WritePropertyName("storageAccountSettings"u8);
                writer.WriteObjectValue(StorageAccountSettings);
            }
            if (Optional.IsDefined(CleanupPreference))
            {
                writer.WritePropertyName("cleanupPreference"u8);
                writer.WriteStringValue(CleanupPreference.Value.ToString());
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(ProvisioningState))
                {
                    writer.WritePropertyName("provisioningState"u8);
                    writer.WriteStringValue(ProvisioningState.Value.ToString());
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(Status))
                {
                    writer.WritePropertyName("status"u8);
                    writer.WriteObjectValue(Status);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(Outputs))
                {
                    writer.WritePropertyName("outputs"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Outputs);
#else
                    using (JsonDocument document = JsonDocument.Parse(Outputs))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            if (Optional.IsDefined(PrimaryScriptUri))
            {
                writer.WritePropertyName("primaryScriptUri"u8);
                writer.WriteStringValue(PrimaryScriptUri.AbsoluteUri);
            }
            if (Optional.IsCollectionDefined(SupportingScriptUris))
            {
                writer.WritePropertyName("supportingScriptUris"u8);
                writer.WriteStartArray();
                foreach (var item in SupportingScriptUris)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item.AbsoluteUri);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ScriptContent))
            {
                writer.WritePropertyName("scriptContent"u8);
                writer.WriteStringValue(ScriptContent);
            }
            if (Optional.IsDefined(Arguments))
            {
                writer.WritePropertyName("arguments"u8);
                writer.WriteStringValue(Arguments);
            }
            if (Optional.IsCollectionDefined(EnvironmentVariables))
            {
                writer.WritePropertyName("environmentVariables"u8);
                writer.WriteStartArray();
                foreach (var item in EnvironmentVariables)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ForceUpdateTag))
            {
                writer.WritePropertyName("forceUpdateTag"u8);
                writer.WriteStringValue(ForceUpdateTag);
            }
            writer.WritePropertyName("retentionInterval"u8);
            writer.WriteStringValue(RetentionInterval, "P");
            if (Optional.IsDefined(Timeout))
            {
                writer.WritePropertyName("timeout"u8);
                writer.WriteStringValue(Timeout.Value, "P");
            }
            writer.WritePropertyName("azCliVersion"u8);
            writer.WriteStringValue(AzCliVersion);
            writer.WriteEndObject();
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
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

        AzureCliScript IJsonModel<AzureCliScript>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AzureCliScript)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureCliScript(document.RootElement, options);
        }

        internal static AzureCliScript DeserializeAzureCliScript(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ArmDeploymentScriptManagedIdentity> identity = default;
            AzureLocation location = default;
            Optional<IDictionary<string, string>> tags = default;
            ScriptType kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<ContainerConfiguration> containerSettings = default;
            Optional<ScriptStorageConfiguration> storageAccountSettings = default;
            Optional<ScriptCleanupOptions> cleanupPreference = default;
            Optional<ScriptProvisioningState> provisioningState = default;
            Optional<ScriptStatus> status = default;
            Optional<BinaryData> outputs = default;
            Optional<Uri> primaryScriptUri = default;
            Optional<IList<Uri>> supportingScriptUris = default;
            Optional<string> scriptContent = default;
            Optional<string> arguments = default;
            Optional<IList<ScriptEnvironmentVariable>> environmentVariables = default;
            Optional<string> forceUpdateTag = default;
            TimeSpan retentionInterval = default;
            Optional<TimeSpan> timeout = default;
            string azCliVersion = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = ArmDeploymentScriptManagedIdentity.DeserializeArmDeploymentScriptManagedIdentity(property.Value);
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tags"u8))
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
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = new ScriptType(property.Value.GetString());
                    continue;
                }
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
                        if (property0.NameEquals("containerSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            containerSettings = ContainerConfiguration.DeserializeContainerConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("storageAccountSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            storageAccountSettings = ScriptStorageConfiguration.DeserializeScriptStorageConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("cleanupPreference"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            cleanupPreference = new ScriptCleanupOptions(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new ScriptProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = ScriptStatus.DeserializeScriptStatus(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("outputs"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            outputs = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("primaryScriptUri"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            primaryScriptUri = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("supportingScriptUris"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<Uri> array = new List<Uri>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(new Uri(item.GetString()));
                                }
                            }
                            supportingScriptUris = array;
                            continue;
                        }
                        if (property0.NameEquals("scriptContent"u8))
                        {
                            scriptContent = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("arguments"u8))
                        {
                            arguments = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("environmentVariables"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ScriptEnvironmentVariable> array = new List<ScriptEnvironmentVariable>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ScriptEnvironmentVariable.DeserializeScriptEnvironmentVariable(item));
                            }
                            environmentVariables = array;
                            continue;
                        }
                        if (property0.NameEquals("forceUpdateTag"u8))
                        {
                            forceUpdateTag = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("retentionInterval"u8))
                        {
                            retentionInterval = property0.Value.GetTimeSpan("P");
                            continue;
                        }
                        if (property0.NameEquals("timeout"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            timeout = property0.Value.GetTimeSpan("P");
                            continue;
                        }
                        if (property0.NameEquals("azCliVersion"u8))
                        {
                            azCliVersion = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AzureCliScript(id, name, type, systemData.Value, identity.Value, location, Optional.ToDictionary(tags), kind, serializedAdditionalRawData, containerSettings.Value, storageAccountSettings.Value, Optional.ToNullable(cleanupPreference), Optional.ToNullable(provisioningState), status.Value, outputs.Value, primaryScriptUri.Value, Optional.ToList(supportingScriptUris), scriptContent.Value, arguments.Value, Optional.ToList(environmentVariables), forceUpdateTag.Value, retentionInterval, Optional.ToNullable(timeout), azCliVersion);
        }

        BinaryData IModel<AzureCliScript>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AzureCliScript)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        AzureCliScript IModel<AzureCliScript>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AzureCliScript)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeAzureCliScript(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<AzureCliScript>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
