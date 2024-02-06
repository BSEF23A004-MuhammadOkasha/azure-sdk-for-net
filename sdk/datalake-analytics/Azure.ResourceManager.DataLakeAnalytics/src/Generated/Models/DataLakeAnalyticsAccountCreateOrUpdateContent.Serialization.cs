// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataLakeAnalytics.Models
{
    public partial class DataLakeAnalyticsAccountCreateOrUpdateContent : IUtf8JsonSerializable, IJsonModel<DataLakeAnalyticsAccountCreateOrUpdateContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataLakeAnalyticsAccountCreateOrUpdateContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataLakeAnalyticsAccountCreateOrUpdateContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataLakeAnalyticsAccountCreateOrUpdateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataLakeAnalyticsAccountCreateOrUpdateContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
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
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("defaultDataLakeStoreAccount"u8);
            writer.WriteStringValue(DefaultDataLakeStoreAccount);
            writer.WritePropertyName("dataLakeStoreAccounts"u8);
            writer.WriteStartArray();
            foreach (var item in DataLakeStoreAccounts)
            {
                BinaryData data = ModelReaderWriter.Write(item, options);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(data);
#else
                using (JsonDocument document = JsonDocument.Parse(data))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            writer.WriteEndArray();
            if (Optional.IsCollectionDefined(StorageAccounts))
            {
                writer.WritePropertyName("storageAccounts"u8);
                writer.WriteStartArray();
                foreach (var item in StorageAccounts)
                {
                    BinaryData data = ModelReaderWriter.Write(item, options);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(data);
#else
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ComputePolicies))
            {
                writer.WritePropertyName("computePolicies"u8);
                writer.WriteStartArray();
                foreach (var item in ComputePolicies)
                {
                    BinaryData data = ModelReaderWriter.Write(item, options);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(data);
#else
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(FirewallRules))
            {
                writer.WritePropertyName("firewallRules"u8);
                writer.WriteStartArray();
                foreach (var item in FirewallRules)
                {
                    BinaryData data = ModelReaderWriter.Write(item, options);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(data);
#else
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(FirewallState))
            {
                writer.WritePropertyName("firewallState"u8);
                writer.WriteStringValue(FirewallState.Value.ToSerialString());
            }
            if (Optional.IsDefined(FirewallAllowAzureIPs))
            {
                writer.WritePropertyName("firewallAllowAzureIps"u8);
                writer.WriteStringValue(FirewallAllowAzureIPs.Value.ToSerialString());
            }
            if (Optional.IsDefined(NewTier))
            {
                writer.WritePropertyName("newTier"u8);
                writer.WriteStringValue(NewTier.Value.ToSerialString());
            }
            if (Optional.IsDefined(MaxJobCount))
            {
                writer.WritePropertyName("maxJobCount"u8);
                writer.WriteNumberValue(MaxJobCount.Value);
            }
            if (Optional.IsDefined(MaxDegreeOfParallelism))
            {
                writer.WritePropertyName("maxDegreeOfParallelism"u8);
                writer.WriteNumberValue(MaxDegreeOfParallelism.Value);
            }
            if (Optional.IsDefined(MaxDegreeOfParallelismPerJob))
            {
                writer.WritePropertyName("maxDegreeOfParallelismPerJob"u8);
                writer.WriteNumberValue(MaxDegreeOfParallelismPerJob.Value);
            }
            if (Optional.IsDefined(MinPriorityPerJob))
            {
                writer.WritePropertyName("minPriorityPerJob"u8);
                writer.WriteNumberValue(MinPriorityPerJob.Value);
            }
            if (Optional.IsDefined(QueryStoreRetention))
            {
                writer.WritePropertyName("queryStoreRetention"u8);
                writer.WriteNumberValue(QueryStoreRetention.Value);
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

        DataLakeAnalyticsAccountCreateOrUpdateContent IJsonModel<DataLakeAnalyticsAccountCreateOrUpdateContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataLakeAnalyticsAccountCreateOrUpdateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataLakeAnalyticsAccountCreateOrUpdateContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataLakeAnalyticsAccountCreateOrUpdateContent(document.RootElement, options);
        }

        internal static DataLakeAnalyticsAccountCreateOrUpdateContent DeserializeDataLakeAnalyticsAccountCreateOrUpdateContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AzureLocation location = default;
            Optional<IDictionary<string, string>> tags = default;
            string defaultDataLakeStoreAccount = default;
            IList<DataLakeStoreForDataLakeAnalyticsAccountCreateOrUpdateContent> dataLakeStoreAccounts = default;
            Optional<IList<StorageAccountForDataLakeAnalyticsAccountCreateOrUpdateContent>> storageAccounts = default;
            Optional<IList<ComputePolicyForDataLakeAnalyticsAccountCreateOrUpdateContent>> computePolicies = default;
            Optional<IList<FirewallRuleForDataLakeAnalyticsAccountCreateOrUpdateContent>> firewallRules = default;
            Optional<DataLakeAnalyticsFirewallState> firewallState = default;
            Optional<DataLakeAnalyticsFirewallAllowAzureIPsState> firewallAllowAzureIPs = default;
            Optional<DataLakeAnalyticsCommitmentTierType> newTier = default;
            Optional<int> maxJobCount = default;
            Optional<int> maxDegreeOfParallelism = default;
            Optional<int> maxDegreeOfParallelismPerJob = default;
            Optional<int> minPriorityPerJob = default;
            Optional<int> queryStoreRetention = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("defaultDataLakeStoreAccount"u8))
                        {
                            defaultDataLakeStoreAccount = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("dataLakeStoreAccounts"u8))
                        {
                            List<DataLakeStoreForDataLakeAnalyticsAccountCreateOrUpdateContent> array = new List<DataLakeStoreForDataLakeAnalyticsAccountCreateOrUpdateContent>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DataLakeStoreForDataLakeAnalyticsAccountCreateOrUpdateContent.DeserializeDataLakeStoreForDataLakeAnalyticsAccountCreateOrUpdateContent(item));
                            }
                            dataLakeStoreAccounts = array;
                            continue;
                        }
                        if (property0.NameEquals("storageAccounts"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<StorageAccountForDataLakeAnalyticsAccountCreateOrUpdateContent> array = new List<StorageAccountForDataLakeAnalyticsAccountCreateOrUpdateContent>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(StorageAccountForDataLakeAnalyticsAccountCreateOrUpdateContent.DeserializeStorageAccountForDataLakeAnalyticsAccountCreateOrUpdateContent(item));
                            }
                            storageAccounts = array;
                            continue;
                        }
                        if (property0.NameEquals("computePolicies"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ComputePolicyForDataLakeAnalyticsAccountCreateOrUpdateContent> array = new List<ComputePolicyForDataLakeAnalyticsAccountCreateOrUpdateContent>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ComputePolicyForDataLakeAnalyticsAccountCreateOrUpdateContent.DeserializeComputePolicyForDataLakeAnalyticsAccountCreateOrUpdateContent(item));
                            }
                            computePolicies = array;
                            continue;
                        }
                        if (property0.NameEquals("firewallRules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<FirewallRuleForDataLakeAnalyticsAccountCreateOrUpdateContent> array = new List<FirewallRuleForDataLakeAnalyticsAccountCreateOrUpdateContent>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(FirewallRuleForDataLakeAnalyticsAccountCreateOrUpdateContent.DeserializeFirewallRuleForDataLakeAnalyticsAccountCreateOrUpdateContent(item));
                            }
                            firewallRules = array;
                            continue;
                        }
                        if (property0.NameEquals("firewallState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            firewallState = property0.Value.GetString().ToDataLakeAnalyticsFirewallState();
                            continue;
                        }
                        if (property0.NameEquals("firewallAllowAzureIps"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            firewallAllowAzureIPs = property0.Value.GetString().ToDataLakeAnalyticsFirewallAllowAzureIPsState();
                            continue;
                        }
                        if (property0.NameEquals("newTier"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            newTier = property0.Value.GetString().ToDataLakeAnalyticsCommitmentTierType();
                            continue;
                        }
                        if (property0.NameEquals("maxJobCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maxJobCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("maxDegreeOfParallelism"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maxDegreeOfParallelism = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("maxDegreeOfParallelismPerJob"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maxDegreeOfParallelismPerJob = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("minPriorityPerJob"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            minPriorityPerJob = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("queryStoreRetention"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            queryStoreRetention = property0.Value.GetInt32();
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
            return new DataLakeAnalyticsAccountCreateOrUpdateContent(location, Optional.ToDictionary(tags), defaultDataLakeStoreAccount, dataLakeStoreAccounts, Optional.ToList(storageAccounts), Optional.ToList(computePolicies), Optional.ToList(firewallRules), Optional.ToNullable(firewallState), Optional.ToNullable(firewallAllowAzureIPs), Optional.ToNullable(newTier), Optional.ToNullable(maxJobCount), Optional.ToNullable(maxDegreeOfParallelism), Optional.ToNullable(maxDegreeOfParallelismPerJob), Optional.ToNullable(minPriorityPerJob), Optional.ToNullable(queryStoreRetention), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataLakeAnalyticsAccountCreateOrUpdateContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataLakeAnalyticsAccountCreateOrUpdateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataLakeAnalyticsAccountCreateOrUpdateContent)} does not support '{options.Format}' format.");
            }
        }

        DataLakeAnalyticsAccountCreateOrUpdateContent IPersistableModel<DataLakeAnalyticsAccountCreateOrUpdateContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataLakeAnalyticsAccountCreateOrUpdateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataLakeAnalyticsAccountCreateOrUpdateContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataLakeAnalyticsAccountCreateOrUpdateContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataLakeAnalyticsAccountCreateOrUpdateContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
