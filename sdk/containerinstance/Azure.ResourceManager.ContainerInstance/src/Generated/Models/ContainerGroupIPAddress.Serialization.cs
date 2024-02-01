// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    public partial class ContainerGroupIPAddress : IUtf8JsonSerializable, IJsonModel<ContainerGroupIPAddress>, IPersistableModel<ContainerGroupIPAddress>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerGroupIPAddress>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerGroupIPAddress>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerGroupIPAddress>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerGroupIPAddress)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("ports"u8);
            writer.WriteStartArray();
            foreach (var item in Ports)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(AddressType.ToString());
            if (Optional.IsDefined(IP))
            {
                writer.WritePropertyName("ip"u8);
                writer.WriteStringValue(IP.ToString());
            }
            if (Optional.IsDefined(DnsNameLabel))
            {
                writer.WritePropertyName("dnsNameLabel"u8);
                writer.WriteStringValue(DnsNameLabel);
            }
            if (Optional.IsDefined(AutoGeneratedDomainNameLabelScope))
            {
                writer.WritePropertyName("autoGeneratedDomainNameLabelScope"u8);
                writer.WriteStringValue(AutoGeneratedDomainNameLabelScope.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(Fqdn))
            {
                writer.WritePropertyName("fqdn"u8);
                writer.WriteStringValue(Fqdn);
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

        ContainerGroupIPAddress IJsonModel<ContainerGroupIPAddress>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerGroupIPAddress>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerGroupIPAddress)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerGroupIPAddress(document.RootElement, options);
        }

        internal static ContainerGroupIPAddress DeserializeContainerGroupIPAddress(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<ContainerGroupPort> ports = default;
            ContainerGroupIPAddressType type = default;
            Optional<IPAddress> ip = default;
            Optional<string> dnsNameLabel = default;
            Optional<DnsNameLabelReusePolicy> autoGeneratedDomainNameLabelScope = default;
            Optional<string> fqdn = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ports"u8))
                {
                    List<ContainerGroupPort> array = new List<ContainerGroupPort>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerGroupPort.DeserializeContainerGroupPort(item));
                    }
                    ports = array;
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ContainerGroupIPAddressType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ip"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ip = IPAddress.Parse(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dnsNameLabel"u8))
                {
                    dnsNameLabel = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("autoGeneratedDomainNameLabelScope"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    autoGeneratedDomainNameLabelScope = new DnsNameLabelReusePolicy(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("fqdn"u8))
                {
                    fqdn = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerGroupIPAddress(ports, type, ip.Value, dnsNameLabel.Value, Optional.ToNullable(autoGeneratedDomainNameLabelScope), fqdn.Value, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsCollectionDefined(Ports))
            {
                builder.Append("  ports:");
                builder.AppendLine(" [");
                foreach (var item in Ports)
                {
                    AppendChildObject(builder, item, options, 4);
                }
                builder.AppendLine("  ]");
            }

            if (Optional.IsDefined(AddressType))
            {
                builder.Append("  type:");
                builder.AppendLine($" '{AddressType.ToString()}'");
            }

            if (Optional.IsDefined(IP))
            {
                builder.Append("  ip:");
                builder.AppendLine($" '{IP.ToString()}'");
            }

            if (Optional.IsDefined(DnsNameLabel))
            {
                builder.Append("  dnsNameLabel:");
                builder.AppendLine($" '{DnsNameLabel}'");
            }

            if (Optional.IsDefined(AutoGeneratedDomainNameLabelScope))
            {
                builder.Append("  autoGeneratedDomainNameLabelScope:");
                builder.AppendLine($" '{AutoGeneratedDomainNameLabelScope.ToString()}'");
            }

            if (Optional.IsDefined(Fqdn))
            {
                builder.Append("  fqdn:");
                builder.AppendLine($" '{Fqdn}'");
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void AppendChildObject(StringBuilder stringBuilder, object childObject, ModelReaderWriterOptions options, int spaces)
        {
            string indent = new string(' ', spaces);
            BinaryData data = ModelReaderWriter.Write(childObject, options);
            string[] lines = data.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in lines)
            {
                stringBuilder.AppendLine($"{indent}{line}");
            }
        }

        BinaryData IPersistableModel<ContainerGroupIPAddress>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerGroupIPAddress>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ContainerGroupIPAddress)} does not support '{options.Format}' format.");
            }
        }

        ContainerGroupIPAddress IPersistableModel<ContainerGroupIPAddress>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerGroupIPAddress>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerGroupIPAddress(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(ContainerGroupIPAddress)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerGroupIPAddress>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
