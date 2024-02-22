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
    public partial class SparkJob : IUtf8JsonSerializable, IJsonModel<SparkJob>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SparkJob>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SparkJob>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SparkJob>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SparkJob)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Archives))
            {
                if (Archives != null)
                {
                    writer.WritePropertyName("archives"u8);
                    writer.WriteStartArray();
                    foreach (var item in Archives)
                    {
                        writer.WriteStringValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("archives");
                }
            }
            if (Optional.IsDefined(Args))
            {
                if (Args != null)
                {
                    writer.WritePropertyName("args"u8);
                    writer.WriteStringValue(Args);
                }
                else
                {
                    writer.WriteNull("args");
                }
            }
            writer.WritePropertyName("codeId"u8);
            writer.WriteStringValue(CodeId);
            if (Optional.IsCollectionDefined(Conf))
            {
                if (Conf != null)
                {
                    writer.WritePropertyName("conf"u8);
                    writer.WriteStartObject();
                    foreach (var item in Conf)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("conf");
                }
            }
            writer.WritePropertyName("entry"u8);
            writer.WriteObjectValue(Entry);
            if (Optional.IsDefined(EnvironmentId))
            {
                if (EnvironmentId != null)
                {
                    writer.WritePropertyName("environmentId"u8);
                    writer.WriteStringValue(EnvironmentId);
                }
                else
                {
                    writer.WriteNull("environmentId");
                }
            }
            if (Optional.IsCollectionDefined(Files))
            {
                if (Files != null)
                {
                    writer.WritePropertyName("files"u8);
                    writer.WriteStartArray();
                    foreach (var item in Files)
                    {
                        writer.WriteStringValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("files");
                }
            }
            if (Optional.IsCollectionDefined(Inputs))
            {
                if (Inputs != null)
                {
                    writer.WritePropertyName("inputs"u8);
                    writer.WriteStartObject();
                    foreach (var item in Inputs)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteObjectValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("inputs");
                }
            }
            if (Optional.IsCollectionDefined(Jars))
            {
                if (Jars != null)
                {
                    writer.WritePropertyName("jars"u8);
                    writer.WriteStartArray();
                    foreach (var item in Jars)
                    {
                        writer.WriteStringValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("jars");
                }
            }
            if (Optional.IsCollectionDefined(Outputs))
            {
                if (Outputs != null)
                {
                    writer.WritePropertyName("outputs"u8);
                    writer.WriteStartObject();
                    foreach (var item in Outputs)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteObjectValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("outputs");
                }
            }
            if (Optional.IsCollectionDefined(PyFiles))
            {
                if (PyFiles != null)
                {
                    writer.WritePropertyName("pyFiles"u8);
                    writer.WriteStartArray();
                    foreach (var item in PyFiles)
                    {
                        writer.WriteStringValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("pyFiles");
                }
            }
            if (Optional.IsDefined(QueueSettings))
            {
                if (QueueSettings != null)
                {
                    writer.WritePropertyName("queueSettings"u8);
                    writer.WriteObjectValue(QueueSettings);
                }
                else
                {
                    writer.WriteNull("queueSettings");
                }
            }
            if (Optional.IsDefined(Resources))
            {
                if (Resources != null)
                {
                    writer.WritePropertyName("resources"u8);
                    writer.WriteObjectValue(Resources);
                }
                else
                {
                    writer.WriteNull("resources");
                }
            }
            if (Optional.IsDefined(ComponentId))
            {
                if (ComponentId != null)
                {
                    writer.WritePropertyName("componentId"u8);
                    writer.WriteStringValue(ComponentId);
                }
                else
                {
                    writer.WriteNull("componentId");
                }
            }
            if (Optional.IsDefined(ComputeId))
            {
                if (ComputeId != null)
                {
                    writer.WritePropertyName("computeId"u8);
                    writer.WriteStringValue(ComputeId);
                }
                else
                {
                    writer.WriteNull("computeId");
                }
            }
            if (Optional.IsDefined(DisplayName))
            {
                if (DisplayName != null)
                {
                    writer.WritePropertyName("displayName"u8);
                    writer.WriteStringValue(DisplayName);
                }
                else
                {
                    writer.WriteNull("displayName");
                }
            }
            if (Optional.IsDefined(ExperimentName))
            {
                writer.WritePropertyName("experimentName"u8);
                writer.WriteStringValue(ExperimentName);
            }
            if (Optional.IsDefined(Identity))
            {
                if (Identity != null)
                {
                    writer.WritePropertyName("identity"u8);
                    writer.WriteObjectValue(Identity);
                }
                else
                {
                    writer.WriteNull("identity");
                }
            }
            if (Optional.IsDefined(IsArchived))
            {
                writer.WritePropertyName("isArchived"u8);
                writer.WriteBooleanValue(IsArchived.Value);
            }
            writer.WritePropertyName("jobType"u8);
            writer.WriteStringValue(JobType.ToString());
            if (Optional.IsDefined(NotificationSetting))
            {
                if (NotificationSetting != null)
                {
                    writer.WritePropertyName("notificationSetting"u8);
                    writer.WriteObjectValue(NotificationSetting);
                }
                else
                {
                    writer.WriteNull("notificationSetting");
                }
            }
            if (Optional.IsCollectionDefined(SecretsConfiguration))
            {
                if (SecretsConfiguration != null)
                {
                    writer.WritePropertyName("secretsConfiguration"u8);
                    writer.WriteStartObject();
                    foreach (var item in SecretsConfiguration)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteObjectValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("secretsConfiguration");
                }
            }
            if (Optional.IsCollectionDefined(Services))
            {
                if (Services != null)
                {
                    writer.WritePropertyName("services"u8);
                    writer.WriteStartObject();
                    foreach (var item in Services)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteObjectValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("services");
                }
            }
            if (options.Format != "W" && Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (Optional.IsDefined(Description))
            {
                if (Description != null)
                {
                    writer.WritePropertyName("description"u8);
                    writer.WriteStringValue(Description);
                }
                else
                {
                    writer.WriteNull("description");
                }
            }
            if (Optional.IsCollectionDefined(Properties))
            {
                if (Properties != null)
                {
                    writer.WritePropertyName("properties"u8);
                    writer.WriteStartObject();
                    foreach (var item in Properties)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("properties");
                }
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                if (Tags != null)
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
                else
                {
                    writer.WriteNull("tags");
                }
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

        SparkJob IJsonModel<SparkJob>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SparkJob>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SparkJob)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSparkJob(document.RootElement, options);
        }

        internal static SparkJob DeserializeSparkJob(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<string>> archives = default;
            Optional<string> args = default;
            string codeId = default;
            Optional<IDictionary<string, string>> conf = default;
            SparkJobEntry entry = default;
            Optional<string> environmentId = default;
            Optional<IList<string>> files = default;
            Optional<IDictionary<string, MachineLearningJobInput>> inputs = default;
            Optional<IList<string>> jars = default;
            Optional<IDictionary<string, MachineLearningJobOutput>> outputs = default;
            Optional<IList<string>> pyFiles = default;
            Optional<JobQueueSettings> queueSettings = default;
            Optional<SparkResourceConfiguration> resources = default;
            Optional<ResourceIdentifier> componentId = default;
            Optional<ResourceIdentifier> computeId = default;
            Optional<string> displayName = default;
            Optional<string> experimentName = default;
            Optional<MachineLearningIdentityConfiguration> identity = default;
            Optional<bool> isArchived = default;
            JobType jobType = default;
            Optional<NotificationSetting> notificationSetting = default;
            Optional<IDictionary<string, SecretConfiguration>> secretsConfiguration = default;
            Optional<IDictionary<string, MachineLearningJobService>> services = default;
            Optional<MachineLearningJobStatus> status = default;
            Optional<string> description = default;
            Optional<IDictionary<string, string>> properties = default;
            Optional<IDictionary<string, string>> tags = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("archives"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        archives = null;
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    archives = array;
                    continue;
                }
                if (property.NameEquals("args"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        args = null;
                        continue;
                    }
                    args = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("codeId"u8))
                {
                    codeId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("conf"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        conf = null;
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    conf = dictionary;
                    continue;
                }
                if (property.NameEquals("entry"u8))
                {
                    entry = SparkJobEntry.DeserializeSparkJobEntry(property.Value, options);
                    continue;
                }
                if (property.NameEquals("environmentId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        environmentId = null;
                        continue;
                    }
                    environmentId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("files"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        files = null;
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    files = array;
                    continue;
                }
                if (property.NameEquals("inputs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        inputs = null;
                        continue;
                    }
                    Dictionary<string, MachineLearningJobInput> dictionary = new Dictionary<string, MachineLearningJobInput>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, MachineLearningJobInput.DeserializeMachineLearningJobInput(property0.Value, options));
                    }
                    inputs = dictionary;
                    continue;
                }
                if (property.NameEquals("jars"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        jars = null;
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    jars = array;
                    continue;
                }
                if (property.NameEquals("outputs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        outputs = null;
                        continue;
                    }
                    Dictionary<string, MachineLearningJobOutput> dictionary = new Dictionary<string, MachineLearningJobOutput>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, MachineLearningJobOutput.DeserializeMachineLearningJobOutput(property0.Value, options));
                    }
                    outputs = dictionary;
                    continue;
                }
                if (property.NameEquals("pyFiles"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        pyFiles = null;
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    pyFiles = array;
                    continue;
                }
                if (property.NameEquals("queueSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        queueSettings = null;
                        continue;
                    }
                    queueSettings = JobQueueSettings.DeserializeJobQueueSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("resources"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        resources = null;
                        continue;
                    }
                    resources = SparkResourceConfiguration.DeserializeSparkResourceConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("componentId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        componentId = null;
                        continue;
                    }
                    componentId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("computeId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        computeId = null;
                        continue;
                    }
                    computeId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        displayName = null;
                        continue;
                    }
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("experimentName"u8))
                {
                    experimentName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        identity = null;
                        continue;
                    }
                    identity = MachineLearningIdentityConfiguration.DeserializeMachineLearningIdentityConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("isArchived"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isArchived = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("jobType"u8))
                {
                    jobType = new JobType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("notificationSetting"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        notificationSetting = null;
                        continue;
                    }
                    notificationSetting = NotificationSetting.DeserializeNotificationSetting(property.Value, options);
                    continue;
                }
                if (property.NameEquals("secretsConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        secretsConfiguration = null;
                        continue;
                    }
                    Dictionary<string, SecretConfiguration> dictionary = new Dictionary<string, SecretConfiguration>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, SecretConfiguration.DeserializeSecretConfiguration(property0.Value, options));
                    }
                    secretsConfiguration = dictionary;
                    continue;
                }
                if (property.NameEquals("services"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        services = null;
                        continue;
                    }
                    Dictionary<string, MachineLearningJobService> dictionary = new Dictionary<string, MachineLearningJobService>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, MachineLearningJobService.DeserializeMachineLearningJobService(property0.Value, options));
                    }
                    services = dictionary;
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new MachineLearningJobStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        description = null;
                        continue;
                    }
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        properties = null;
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    properties = dictionary;
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        tags = null;
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
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SparkJob(description.Value, Optional.ToDictionary(properties), Optional.ToDictionary(tags), serializedAdditionalRawData, componentId.Value, computeId.Value, displayName.Value, experimentName.Value, identity.Value, Optional.ToNullable(isArchived), jobType, notificationSetting.Value, Optional.ToDictionary(secretsConfiguration), Optional.ToDictionary(services), Optional.ToNullable(status), Optional.ToList(archives), args.Value, codeId, Optional.ToDictionary(conf), entry, environmentId.Value, Optional.ToList(files), Optional.ToDictionary(inputs), Optional.ToList(jars), Optional.ToDictionary(outputs), Optional.ToList(pyFiles), queueSettings.Value, resources.Value);
        }

        BinaryData IPersistableModel<SparkJob>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SparkJob>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SparkJob)} does not support '{options.Format}' format.");
            }
        }

        SparkJob IPersistableModel<SparkJob>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SparkJob>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSparkJob(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SparkJob)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SparkJob>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
