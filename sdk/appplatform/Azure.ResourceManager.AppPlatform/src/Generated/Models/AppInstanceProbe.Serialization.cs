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

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class AppInstanceProbe : IUtf8JsonSerializable, IJsonModel<AppInstanceProbe>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppInstanceProbe>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AppInstanceProbe>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppInstanceProbe>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(AppInstanceProbe)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ProbeAction))
            {
                writer.WritePropertyName("probeAction"u8);
                writer.WriteObjectValue(ProbeAction);
            }
            writer.WritePropertyName("disableProbe"u8);
            writer.WriteBooleanValue(IsProbeDisabled);
            if (Optional.IsDefined(InitialDelayInSeconds))
            {
                writer.WritePropertyName("initialDelaySeconds"u8);
                writer.WriteNumberValue(InitialDelayInSeconds.Value);
            }
            if (Optional.IsDefined(PeriodInSeconds))
            {
                writer.WritePropertyName("periodSeconds"u8);
                writer.WriteNumberValue(PeriodInSeconds.Value);
            }
            if (Optional.IsDefined(TimeoutInSeconds))
            {
                writer.WritePropertyName("timeoutSeconds"u8);
                writer.WriteNumberValue(TimeoutInSeconds.Value);
            }
            if (Optional.IsDefined(FailureThreshold))
            {
                writer.WritePropertyName("failureThreshold"u8);
                writer.WriteNumberValue(FailureThreshold.Value);
            }
            if (Optional.IsDefined(SuccessThreshold))
            {
                writer.WritePropertyName("successThreshold"u8);
                writer.WriteNumberValue(SuccessThreshold.Value);
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

        AppInstanceProbe IJsonModel<AppInstanceProbe>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppInstanceProbe>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(AppInstanceProbe)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppInstanceProbe(document.RootElement, options);
        }

        internal static AppInstanceProbe DeserializeAppInstanceProbe(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AppInstanceProbeAction> probeAction = default;
            bool disableProbe = default;
            Optional<int> initialDelaySeconds = default;
            Optional<int> periodSeconds = default;
            Optional<int> timeoutSeconds = default;
            Optional<int> failureThreshold = default;
            Optional<int> successThreshold = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("probeAction"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    probeAction = AppInstanceProbeAction.DeserializeAppInstanceProbeAction(property.Value);
                    continue;
                }
                if (property.NameEquals("disableProbe"u8))
                {
                    disableProbe = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("initialDelaySeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    initialDelaySeconds = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("periodSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    periodSeconds = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("timeoutSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeoutSeconds = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("failureThreshold"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    failureThreshold = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("successThreshold"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    successThreshold = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AppInstanceProbe(probeAction.Value, disableProbe, Optional.ToNullable(initialDelaySeconds), Optional.ToNullable(periodSeconds), Optional.ToNullable(timeoutSeconds), Optional.ToNullable(failureThreshold), Optional.ToNullable(successThreshold), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AppInstanceProbe>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppInstanceProbe>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(AppInstanceProbe)} does not support '{options.Format}' format.");
            }
        }

        AppInstanceProbe IPersistableModel<AppInstanceProbe>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppInstanceProbe>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAppInstanceProbe(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(AppInstanceProbe)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AppInstanceProbe>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
