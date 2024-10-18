// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    [PersistableModelProxy(typeof(UnknownServicePlacementPolicy))]
    public partial class ManagedServicePlacementPolicy : IUtf8JsonSerializable, IJsonModel<ManagedServicePlacementPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedServicePlacementPolicy>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ManagedServicePlacementPolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedServicePlacementPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedServicePlacementPolicy)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(ServicePlacementPolicyType.ToString());
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
        }

        ManagedServicePlacementPolicy IJsonModel<ManagedServicePlacementPolicy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedServicePlacementPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedServicePlacementPolicy)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedServicePlacementPolicy(document.RootElement, options);
        }

        internal static ManagedServicePlacementPolicy DeserializeManagedServicePlacementPolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "InvalidDomain": return ServicePlacementInvalidDomainPolicy.DeserializeServicePlacementInvalidDomainPolicy(element, options);
                    case "NonPartiallyPlaceService": return ServicePlacementNonPartiallyPlaceServicePolicy.DeserializeServicePlacementNonPartiallyPlaceServicePolicy(element, options);
                    case "PreferredPrimaryDomain": return ServicePlacementPreferPrimaryDomainPolicy.DeserializeServicePlacementPreferPrimaryDomainPolicy(element, options);
                    case "RequiredDomain": return ServicePlacementRequiredDomainPolicy.DeserializeServicePlacementRequiredDomainPolicy(element, options);
                    case "RequiredDomainDistribution": return ServicePlacementRequireDomainDistributionPolicy.DeserializeServicePlacementRequireDomainDistributionPolicy(element, options);
                }
            }
            return UnknownServicePlacementPolicy.DeserializeUnknownServicePlacementPolicy(element, options);
        }

        BinaryData IPersistableModel<ManagedServicePlacementPolicy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedServicePlacementPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ManagedServicePlacementPolicy)} does not support writing '{options.Format}' format.");
            }
        }

        ManagedServicePlacementPolicy IPersistableModel<ManagedServicePlacementPolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedServicePlacementPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManagedServicePlacementPolicy(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagedServicePlacementPolicy)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedServicePlacementPolicy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
