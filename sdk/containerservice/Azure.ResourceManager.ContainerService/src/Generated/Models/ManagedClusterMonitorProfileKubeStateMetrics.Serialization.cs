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

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class ManagedClusterMonitorProfileKubeStateMetrics : IUtf8JsonSerializable, IModelJsonSerializable<ManagedClusterMonitorProfileKubeStateMetrics>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ManagedClusterMonitorProfileKubeStateMetrics>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ManagedClusterMonitorProfileKubeStateMetrics>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagedClusterMonitorProfileKubeStateMetrics>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(MetricLabelsAllowlist))
            {
                writer.WritePropertyName("metricLabelsAllowlist"u8);
                writer.WriteStringValue(MetricLabelsAllowlist);
            }
            if (Optional.IsDefined(MetricAnnotationsAllowList))
            {
                writer.WritePropertyName("metricAnnotationsAllowList"u8);
                writer.WriteStringValue(MetricAnnotationsAllowList);
            }
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

        internal static ManagedClusterMonitorProfileKubeStateMetrics DeserializeManagedClusterMonitorProfileKubeStateMetrics(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> metricLabelsAllowlist = default;
            Optional<string> metricAnnotationsAllowList = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("metricLabelsAllowlist"u8))
                {
                    metricLabelsAllowlist = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("metricAnnotationsAllowList"u8))
                {
                    metricAnnotationsAllowList = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ManagedClusterMonitorProfileKubeStateMetrics(metricLabelsAllowlist.Value, metricAnnotationsAllowList.Value, rawData);
        }

        ManagedClusterMonitorProfileKubeStateMetrics IModelJsonSerializable<ManagedClusterMonitorProfileKubeStateMetrics>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagedClusterMonitorProfileKubeStateMetrics>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedClusterMonitorProfileKubeStateMetrics(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ManagedClusterMonitorProfileKubeStateMetrics>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagedClusterMonitorProfileKubeStateMetrics>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ManagedClusterMonitorProfileKubeStateMetrics IModelSerializable<ManagedClusterMonitorProfileKubeStateMetrics>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagedClusterMonitorProfileKubeStateMetrics>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeManagedClusterMonitorProfileKubeStateMetrics(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ManagedClusterMonitorProfileKubeStateMetrics"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ManagedClusterMonitorProfileKubeStateMetrics"/> to convert. </param>
        public static implicit operator RequestContent(ManagedClusterMonitorProfileKubeStateMetrics model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ManagedClusterMonitorProfileKubeStateMetrics"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ManagedClusterMonitorProfileKubeStateMetrics(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeManagedClusterMonitorProfileKubeStateMetrics(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
