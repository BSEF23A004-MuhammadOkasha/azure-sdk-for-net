// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class ManagedClusterAutoScalerProfile : IUtf8JsonSerializable, IJsonModel<ManagedClusterAutoScalerProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedClusterAutoScalerProfile>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ManagedClusterAutoScalerProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterAutoScalerProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedClusterAutoScalerProfile)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(BalanceSimilarNodeGroups))
            {
                writer.WritePropertyName("balance-similar-node-groups"u8);
                writer.WriteStringValue(BalanceSimilarNodeGroups);
            }
            if (Optional.IsDefined(Expander))
            {
                writer.WritePropertyName("expander"u8);
                writer.WriteStringValue(Expander.Value.ToString());
            }
            if (Optional.IsDefined(MaxEmptyBulkDelete))
            {
                writer.WritePropertyName("max-empty-bulk-delete"u8);
                writer.WriteStringValue(MaxEmptyBulkDelete);
            }
            if (Optional.IsDefined(MaxGracefulTerminationSec))
            {
                writer.WritePropertyName("max-graceful-termination-sec"u8);
                writer.WriteStringValue(MaxGracefulTerminationSec);
            }
            if (Optional.IsDefined(MaxNodeProvisionTime))
            {
                writer.WritePropertyName("max-node-provision-time"u8);
                writer.WriteStringValue(MaxNodeProvisionTime);
            }
            if (Optional.IsDefined(MaxTotalUnreadyPercentage))
            {
                writer.WritePropertyName("max-total-unready-percentage"u8);
                writer.WriteStringValue(MaxTotalUnreadyPercentage);
            }
            if (Optional.IsDefined(NewPodScaleUpDelay))
            {
                writer.WritePropertyName("new-pod-scale-up-delay"u8);
                writer.WriteStringValue(NewPodScaleUpDelay);
            }
            if (Optional.IsDefined(OkTotalUnreadyCount))
            {
                writer.WritePropertyName("ok-total-unready-count"u8);
                writer.WriteStringValue(OkTotalUnreadyCount);
            }
            if (Optional.IsDefined(ScanIntervalInSeconds))
            {
                writer.WritePropertyName("scan-interval"u8);
                writer.WriteStringValue(ScanIntervalInSeconds);
            }
            if (Optional.IsDefined(ScaleDownDelayAfterAdd))
            {
                writer.WritePropertyName("scale-down-delay-after-add"u8);
                writer.WriteStringValue(ScaleDownDelayAfterAdd);
            }
            if (Optional.IsDefined(ScaleDownDelayAfterDelete))
            {
                writer.WritePropertyName("scale-down-delay-after-delete"u8);
                writer.WriteStringValue(ScaleDownDelayAfterDelete);
            }
            if (Optional.IsDefined(ScaleDownDelayAfterFailure))
            {
                writer.WritePropertyName("scale-down-delay-after-failure"u8);
                writer.WriteStringValue(ScaleDownDelayAfterFailure);
            }
            if (Optional.IsDefined(ScaleDownUnneededTime))
            {
                writer.WritePropertyName("scale-down-unneeded-time"u8);
                writer.WriteStringValue(ScaleDownUnneededTime);
            }
            if (Optional.IsDefined(ScaleDownUnreadyTime))
            {
                writer.WritePropertyName("scale-down-unready-time"u8);
                writer.WriteStringValue(ScaleDownUnreadyTime);
            }
            if (Optional.IsDefined(ScaleDownUtilizationThreshold))
            {
                writer.WritePropertyName("scale-down-utilization-threshold"u8);
                writer.WriteStringValue(ScaleDownUtilizationThreshold);
            }
            if (Optional.IsDefined(SkipNodesWithLocalStorage))
            {
                writer.WritePropertyName("skip-nodes-with-local-storage"u8);
                writer.WriteStringValue(SkipNodesWithLocalStorage);
            }
            if (Optional.IsDefined(SkipNodesWithSystemPods))
            {
                writer.WritePropertyName("skip-nodes-with-system-pods"u8);
                writer.WriteStringValue(SkipNodesWithSystemPods);
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

        ManagedClusterAutoScalerProfile IJsonModel<ManagedClusterAutoScalerProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterAutoScalerProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedClusterAutoScalerProfile)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedClusterAutoScalerProfile(document.RootElement, options);
        }

        internal static ManagedClusterAutoScalerProfile DeserializeManagedClusterAutoScalerProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> balanceSimilarNodeGroups = default;
            Optional<AutoScaleExpander> expander = default;
            Optional<string> maxEmptyBulkDelete = default;
            Optional<string> maxGracefulTerminationSec = default;
            Optional<string> maxNodeProvisionTime = default;
            Optional<string> maxTotalUnreadyPercentage = default;
            Optional<string> newPodScaleUpDelay = default;
            Optional<string> okTotalUnreadyCount = default;
            Optional<string> scanInterval = default;
            Optional<string> scaleDownDelayAfterAdd = default;
            Optional<string> scaleDownDelayAfterDelete = default;
            Optional<string> scaleDownDelayAfterFailure = default;
            Optional<string> scaleDownUnneededTime = default;
            Optional<string> scaleDownUnreadyTime = default;
            Optional<string> scaleDownUtilizationThreshold = default;
            Optional<string> skipNodesWithLocalStorage = default;
            Optional<string> skipNodesWithSystemPods = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("balance-similar-node-groups"u8))
                {
                    balanceSimilarNodeGroups = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("expander"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expander = new AutoScaleExpander(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("max-empty-bulk-delete"u8))
                {
                    maxEmptyBulkDelete = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("max-graceful-termination-sec"u8))
                {
                    maxGracefulTerminationSec = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("max-node-provision-time"u8))
                {
                    maxNodeProvisionTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("max-total-unready-percentage"u8))
                {
                    maxTotalUnreadyPercentage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("new-pod-scale-up-delay"u8))
                {
                    newPodScaleUpDelay = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ok-total-unready-count"u8))
                {
                    okTotalUnreadyCount = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scan-interval"u8))
                {
                    scanInterval = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scale-down-delay-after-add"u8))
                {
                    scaleDownDelayAfterAdd = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scale-down-delay-after-delete"u8))
                {
                    scaleDownDelayAfterDelete = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scale-down-delay-after-failure"u8))
                {
                    scaleDownDelayAfterFailure = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scale-down-unneeded-time"u8))
                {
                    scaleDownUnneededTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scale-down-unready-time"u8))
                {
                    scaleDownUnreadyTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scale-down-utilization-threshold"u8))
                {
                    scaleDownUtilizationThreshold = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("skip-nodes-with-local-storage"u8))
                {
                    skipNodesWithLocalStorage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("skip-nodes-with-system-pods"u8))
                {
                    skipNodesWithSystemPods = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ManagedClusterAutoScalerProfile(balanceSimilarNodeGroups.Value, Optional.ToNullable(expander), maxEmptyBulkDelete.Value, maxGracefulTerminationSec.Value, maxNodeProvisionTime.Value, maxTotalUnreadyPercentage.Value, newPodScaleUpDelay.Value, okTotalUnreadyCount.Value, scanInterval.Value, scaleDownDelayAfterAdd.Value, scaleDownDelayAfterDelete.Value, scaleDownDelayAfterFailure.Value, scaleDownUnneededTime.Value, scaleDownUnreadyTime.Value, scaleDownUtilizationThreshold.Value, skipNodesWithLocalStorage.Value, skipNodesWithSystemPods.Value, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(BalanceSimilarNodeGroups))
            {
                builder.Append("  balance-similar-node-groups:");
                builder.AppendLine($" '{BalanceSimilarNodeGroups}'");
            }

            if (Optional.IsDefined(Expander))
            {
                builder.Append("  expander:");
                builder.AppendLine($" '{Expander.ToString()}'");
            }

            if (Optional.IsDefined(MaxEmptyBulkDelete))
            {
                builder.Append("  max-empty-bulk-delete:");
                builder.AppendLine($" '{MaxEmptyBulkDelete}'");
            }

            if (Optional.IsDefined(MaxGracefulTerminationSec))
            {
                builder.Append("  max-graceful-termination-sec:");
                builder.AppendLine($" '{MaxGracefulTerminationSec}'");
            }

            if (Optional.IsDefined(MaxNodeProvisionTime))
            {
                builder.Append("  max-node-provision-time:");
                builder.AppendLine($" '{MaxNodeProvisionTime}'");
            }

            if (Optional.IsDefined(MaxTotalUnreadyPercentage))
            {
                builder.Append("  max-total-unready-percentage:");
                builder.AppendLine($" '{MaxTotalUnreadyPercentage}'");
            }

            if (Optional.IsDefined(NewPodScaleUpDelay))
            {
                builder.Append("  new-pod-scale-up-delay:");
                builder.AppendLine($" '{NewPodScaleUpDelay}'");
            }

            if (Optional.IsDefined(OkTotalUnreadyCount))
            {
                builder.Append("  ok-total-unready-count:");
                builder.AppendLine($" '{OkTotalUnreadyCount}'");
            }

            if (Optional.IsDefined(ScanIntervalInSeconds))
            {
                builder.Append("  scan-interval:");
                builder.AppendLine($" '{ScanIntervalInSeconds}'");
            }

            if (Optional.IsDefined(ScaleDownDelayAfterAdd))
            {
                builder.Append("  scale-down-delay-after-add:");
                builder.AppendLine($" '{ScaleDownDelayAfterAdd}'");
            }

            if (Optional.IsDefined(ScaleDownDelayAfterDelete))
            {
                builder.Append("  scale-down-delay-after-delete:");
                builder.AppendLine($" '{ScaleDownDelayAfterDelete}'");
            }

            if (Optional.IsDefined(ScaleDownDelayAfterFailure))
            {
                builder.Append("  scale-down-delay-after-failure:");
                builder.AppendLine($" '{ScaleDownDelayAfterFailure}'");
            }

            if (Optional.IsDefined(ScaleDownUnneededTime))
            {
                builder.Append("  scale-down-unneeded-time:");
                builder.AppendLine($" '{ScaleDownUnneededTime}'");
            }

            if (Optional.IsDefined(ScaleDownUnreadyTime))
            {
                builder.Append("  scale-down-unready-time:");
                builder.AppendLine($" '{ScaleDownUnreadyTime}'");
            }

            if (Optional.IsDefined(ScaleDownUtilizationThreshold))
            {
                builder.Append("  scale-down-utilization-threshold:");
                builder.AppendLine($" '{ScaleDownUtilizationThreshold}'");
            }

            if (Optional.IsDefined(SkipNodesWithLocalStorage))
            {
                builder.Append("  skip-nodes-with-local-storage:");
                builder.AppendLine($" '{SkipNodesWithLocalStorage}'");
            }

            if (Optional.IsDefined(SkipNodesWithSystemPods))
            {
                builder.Append("  skip-nodes-with-system-pods:");
                builder.AppendLine($" '{SkipNodesWithSystemPods}'");
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void AppendChildObject(StringBuilder stringBuilder, object childObject, ModelReaderWriterOptions options, int spaces, bool indentFirstLine)
        {
            string indent = new string(' ', spaces);
            BinaryData data = ModelReaderWriter.Write(childObject, options);
            string[] lines = data.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                if (i == 0 && !indentFirstLine)
                {
                    stringBuilder.AppendLine($" {line}");
                }
                else
                {
                    stringBuilder.AppendLine($"{indent}{line}");
                }
            }
        }

        BinaryData IPersistableModel<ManagedClusterAutoScalerProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterAutoScalerProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ManagedClusterAutoScalerProfile)} does not support '{options.Format}' format.");
            }
        }

        ManagedClusterAutoScalerProfile IPersistableModel<ManagedClusterAutoScalerProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterAutoScalerProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManagedClusterAutoScalerProfile(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(ManagedClusterAutoScalerProfile)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedClusterAutoScalerProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
