// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    public partial class ProcessInfoData : IUtf8JsonSerializable, IJsonModel<ProcessInfoData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ProcessInfoData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ProcessInfoData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProcessInfoData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ProcessInfoData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
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
            if (options.Format != "W" && Optional.IsDefined(Identifier))
            {
                writer.WritePropertyName("identifier"u8);
                writer.WriteNumberValue(Identifier.Value);
            }
            if (Optional.IsDefined(DeploymentName))
            {
                writer.WritePropertyName("deployment_name"u8);
                writer.WriteStringValue(DeploymentName);
            }
            if (Optional.IsDefined(Href))
            {
                writer.WritePropertyName("href"u8);
                writer.WriteStringValue(Href);
            }
            if (Optional.IsDefined(Minidump))
            {
                writer.WritePropertyName("minidump"u8);
                writer.WriteStringValue(Minidump);
            }
            if (Optional.IsDefined(IsProfileRunning))
            {
                writer.WritePropertyName("is_profile_running"u8);
                writer.WriteBooleanValue(IsProfileRunning.Value);
            }
            if (Optional.IsDefined(IsIisProfileRunning))
            {
                writer.WritePropertyName("is_iis_profile_running"u8);
                writer.WriteBooleanValue(IsIisProfileRunning.Value);
            }
            if (Optional.IsDefined(IisProfileTimeoutInSeconds))
            {
                writer.WritePropertyName("iis_profile_timeout_in_seconds"u8);
                writer.WriteNumberValue(IisProfileTimeoutInSeconds.Value);
            }
            if (Optional.IsDefined(Parent))
            {
                writer.WritePropertyName("parent"u8);
                writer.WriteStringValue(Parent);
            }
            if (!(Children is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("children"u8);
                writer.WriteStartArray();
                foreach (var item in Children)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(Threads is ChangeTrackingList<ProcessThreadInfo> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("threads"u8);
                writer.WriteStartArray();
                foreach (var item in Threads)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(OpenFileHandles is ChangeTrackingList<string> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("open_file_handles"u8);
                writer.WriteStartArray();
                foreach (var item in OpenFileHandles)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(Modules is ChangeTrackingList<ProcessModuleInfoData> collection2 && collection2.IsUndefined))
            {
                writer.WritePropertyName("modules"u8);
                writer.WriteStartArray();
                foreach (var item in Modules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(FileName))
            {
                writer.WritePropertyName("file_name"u8);
                writer.WriteStringValue(FileName);
            }
            if (Optional.IsDefined(CommandLine))
            {
                writer.WritePropertyName("command_line"u8);
                writer.WriteStringValue(CommandLine);
            }
            if (Optional.IsDefined(UserName))
            {
                writer.WritePropertyName("user_name"u8);
                writer.WriteStringValue(UserName);
            }
            if (Optional.IsDefined(HandleCount))
            {
                writer.WritePropertyName("handle_count"u8);
                writer.WriteNumberValue(HandleCount.Value);
            }
            if (Optional.IsDefined(ModuleCount))
            {
                writer.WritePropertyName("module_count"u8);
                writer.WriteNumberValue(ModuleCount.Value);
            }
            if (Optional.IsDefined(ThreadCount))
            {
                writer.WritePropertyName("thread_count"u8);
                writer.WriteNumberValue(ThreadCount.Value);
            }
            if (Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("start_time"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (Optional.IsDefined(TotalCpuTime))
            {
                writer.WritePropertyName("total_cpu_time"u8);
                writer.WriteStringValue(TotalCpuTime);
            }
            if (Optional.IsDefined(UserCpuTime))
            {
                writer.WritePropertyName("user_cpu_time"u8);
                writer.WriteStringValue(UserCpuTime);
            }
            if (Optional.IsDefined(PrivilegedCpuTime))
            {
                writer.WritePropertyName("privileged_cpu_time"u8);
                writer.WriteStringValue(PrivilegedCpuTime);
            }
            if (Optional.IsDefined(WorkingSet))
            {
                writer.WritePropertyName("working_set"u8);
                writer.WriteNumberValue(WorkingSet.Value);
            }
            if (Optional.IsDefined(PeakWorkingSet))
            {
                writer.WritePropertyName("peak_working_set"u8);
                writer.WriteNumberValue(PeakWorkingSet.Value);
            }
            if (Optional.IsDefined(PrivateMemory))
            {
                writer.WritePropertyName("private_memory"u8);
                writer.WriteNumberValue(PrivateMemory.Value);
            }
            if (Optional.IsDefined(VirtualMemory))
            {
                writer.WritePropertyName("virtual_memory"u8);
                writer.WriteNumberValue(VirtualMemory.Value);
            }
            if (Optional.IsDefined(PeakVirtualMemory))
            {
                writer.WritePropertyName("peak_virtual_memory"u8);
                writer.WriteNumberValue(PeakVirtualMemory.Value);
            }
            if (Optional.IsDefined(PagedSystemMemory))
            {
                writer.WritePropertyName("paged_system_memory"u8);
                writer.WriteNumberValue(PagedSystemMemory.Value);
            }
            if (Optional.IsDefined(NonPagedSystemMemory))
            {
                writer.WritePropertyName("non_paged_system_memory"u8);
                writer.WriteNumberValue(NonPagedSystemMemory.Value);
            }
            if (Optional.IsDefined(PagedMemory))
            {
                writer.WritePropertyName("paged_memory"u8);
                writer.WriteNumberValue(PagedMemory.Value);
            }
            if (Optional.IsDefined(PeakPagedMemory))
            {
                writer.WritePropertyName("peak_paged_memory"u8);
                writer.WriteNumberValue(PeakPagedMemory.Value);
            }
            if (Optional.IsDefined(TimeStamp))
            {
                writer.WritePropertyName("time_stamp"u8);
                writer.WriteStringValue(TimeStamp.Value, "O");
            }
            if (!(EnvironmentVariables is ChangeTrackingDictionary<string, string> collection3 && collection3.IsUndefined))
            {
                writer.WritePropertyName("environment_variables"u8);
                writer.WriteStartObject();
                foreach (var item in EnvironmentVariables)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(IsScmSite))
            {
                writer.WritePropertyName("is_scm_site"u8);
                writer.WriteBooleanValue(IsScmSite.Value);
            }
            if (Optional.IsDefined(IsWebjob))
            {
                writer.WritePropertyName("is_webjob"u8);
                writer.WriteBooleanValue(IsWebjob.Value);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
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

        ProcessInfoData IJsonModel<ProcessInfoData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProcessInfoData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ProcessInfoData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeProcessInfoData(document.RootElement, options);
        }

        internal static ProcessInfoData DeserializeProcessInfoData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<int> identifier = default;
            Optional<string> deploymentName = default;
            Optional<string> href = default;
            Optional<string> minidump = default;
            Optional<bool> isProfileRunning = default;
            Optional<bool> isIisProfileRunning = default;
            Optional<double> iisProfileTimeoutInSeconds = default;
            Optional<string> parent = default;
            Optional<IList<string>> children = default;
            Optional<IList<ProcessThreadInfo>> threads = default;
            Optional<IList<string>> openFileHandles = default;
            Optional<IList<ProcessModuleInfoData>> modules = default;
            Optional<string> fileName = default;
            Optional<string> commandLine = default;
            Optional<string> userName = default;
            Optional<int> handleCount = default;
            Optional<int> moduleCount = default;
            Optional<int> threadCount = default;
            Optional<DateTimeOffset> startTime = default;
            Optional<string> totalCpuTime = default;
            Optional<string> userCpuTime = default;
            Optional<string> privilegedCpuTime = default;
            Optional<long> workingSet = default;
            Optional<long> peakWorkingSet = default;
            Optional<long> privateMemory = default;
            Optional<long> virtualMemory = default;
            Optional<long> peakVirtualMemory = default;
            Optional<long> pagedSystemMemory = default;
            Optional<long> nonPagedSystemMemory = default;
            Optional<long> pagedMemory = default;
            Optional<long> peakPagedMemory = default;
            Optional<DateTimeOffset> timeStamp = default;
            Optional<IDictionary<string, string>> environmentVariables = default;
            Optional<bool> isScmSite = default;
            Optional<bool> isWebjob = default;
            Optional<string> description = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
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
                        if (property0.NameEquals("identifier"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            identifier = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("deployment_name"u8))
                        {
                            deploymentName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("href"u8))
                        {
                            href = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("minidump"u8))
                        {
                            minidump = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("is_profile_running"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isProfileRunning = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("is_iis_profile_running"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isIisProfileRunning = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("iis_profile_timeout_in_seconds"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            iisProfileTimeoutInSeconds = property0.Value.GetDouble();
                            continue;
                        }
                        if (property0.NameEquals("parent"u8))
                        {
                            parent = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("children"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            children = array;
                            continue;
                        }
                        if (property0.NameEquals("threads"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ProcessThreadInfo> array = new List<ProcessThreadInfo>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ProcessThreadInfo.DeserializeProcessThreadInfo(item, options));
                            }
                            threads = array;
                            continue;
                        }
                        if (property0.NameEquals("open_file_handles"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            openFileHandles = array;
                            continue;
                        }
                        if (property0.NameEquals("modules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ProcessModuleInfoData> array = new List<ProcessModuleInfoData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ProcessModuleInfoData.DeserializeProcessModuleInfoData(item, options));
                            }
                            modules = array;
                            continue;
                        }
                        if (property0.NameEquals("file_name"u8))
                        {
                            fileName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("command_line"u8))
                        {
                            commandLine = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("user_name"u8))
                        {
                            userName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("handle_count"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            handleCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("module_count"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            moduleCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("thread_count"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            threadCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("start_time"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            startTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("total_cpu_time"u8))
                        {
                            totalCpuTime = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("user_cpu_time"u8))
                        {
                            userCpuTime = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("privileged_cpu_time"u8))
                        {
                            privilegedCpuTime = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("working_set"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            workingSet = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("peak_working_set"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            peakWorkingSet = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("private_memory"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            privateMemory = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("virtual_memory"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            virtualMemory = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("peak_virtual_memory"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            peakVirtualMemory = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("paged_system_memory"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            pagedSystemMemory = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("non_paged_system_memory"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            nonPagedSystemMemory = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("paged_memory"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            pagedMemory = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("peak_paged_memory"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            peakPagedMemory = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("time_stamp"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            timeStamp = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("environment_variables"u8))
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
                            environmentVariables = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("is_scm_site"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isScmSite = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("is_webjob"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isWebjob = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
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
            return new ProcessInfoData(id, name, type, systemData.Value, Optional.ToNullable(identifier), deploymentName.Value, href.Value, minidump.Value, Optional.ToNullable(isProfileRunning), Optional.ToNullable(isIisProfileRunning), Optional.ToNullable(iisProfileTimeoutInSeconds), parent.Value, Optional.ToList(children), Optional.ToList(threads), Optional.ToList(openFileHandles), Optional.ToList(modules), fileName.Value, commandLine.Value, userName.Value, Optional.ToNullable(handleCount), Optional.ToNullable(moduleCount), Optional.ToNullable(threadCount), Optional.ToNullable(startTime), totalCpuTime.Value, userCpuTime.Value, privilegedCpuTime.Value, Optional.ToNullable(workingSet), Optional.ToNullable(peakWorkingSet), Optional.ToNullable(privateMemory), Optional.ToNullable(virtualMemory), Optional.ToNullable(peakVirtualMemory), Optional.ToNullable(pagedSystemMemory), Optional.ToNullable(nonPagedSystemMemory), Optional.ToNullable(pagedMemory), Optional.ToNullable(peakPagedMemory), Optional.ToNullable(timeStamp), Optional.ToDictionary(environmentVariables), Optional.ToNullable(isScmSite), Optional.ToNullable(isWebjob), description.Value, kind.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ProcessInfoData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProcessInfoData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ProcessInfoData)} does not support '{options.Format}' format.");
            }
        }

        ProcessInfoData IPersistableModel<ProcessInfoData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProcessInfoData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeProcessInfoData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ProcessInfoData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ProcessInfoData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
