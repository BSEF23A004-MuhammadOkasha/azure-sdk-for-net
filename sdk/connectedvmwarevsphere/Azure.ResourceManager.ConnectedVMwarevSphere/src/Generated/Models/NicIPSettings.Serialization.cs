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

namespace Azure.ResourceManager.ConnectedVMwarevSphere.Models
{
    public partial class NicIPSettings : IUtf8JsonSerializable, IJsonModel<NicIPSettings>, IPersistableModel<NicIPSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NicIPSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NicIPSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NicIPSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NicIPSettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(AllocationMethod))
            {
                writer.WritePropertyName("allocationMethod"u8);
                writer.WriteStringValue(AllocationMethod.Value.ToString());
            }
            if (Optional.IsCollectionDefined(DnsServers))
            {
                writer.WritePropertyName("dnsServers"u8);
                writer.WriteStartArray();
                foreach (var item in DnsServers)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Gateway))
            {
                writer.WritePropertyName("gateway"u8);
                writer.WriteStartArray();
                foreach (var item in Gateway)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IPAddress))
            {
                writer.WritePropertyName("ipAddress"u8);
                writer.WriteStringValue(IPAddress);
            }
            if (Optional.IsDefined(SubnetMask))
            {
                writer.WritePropertyName("subnetMask"u8);
                writer.WriteStringValue(SubnetMask);
            }
            if (options.Format != "W" && Optional.IsDefined(PrimaryWinsServer))
            {
                writer.WritePropertyName("primaryWinsServer"u8);
                writer.WriteStringValue(PrimaryWinsServer);
            }
            if (options.Format != "W" && Optional.IsDefined(SecondaryWinsServer))
            {
                writer.WritePropertyName("secondaryWinsServer"u8);
                writer.WriteStringValue(SecondaryWinsServer);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(IPAddressInfo))
            {
                writer.WritePropertyName("ipAddressInfo"u8);
                writer.WriteStartArray();
                foreach (var item in IPAddressInfo)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        NicIPSettings IJsonModel<NicIPSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NicIPSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NicIPSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNicIPSettings(document.RootElement, options);
        }

        internal static NicIPSettings DeserializeNicIPSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IPAddressAllocationMethod> allocationMethod = default;
            Optional<IList<string>> dnsServers = default;
            Optional<IList<string>> gateway = default;
            Optional<string> ipAddress = default;
            Optional<string> subnetMask = default;
            Optional<string> primaryWinsServer = default;
            Optional<string> secondaryWinsServer = default;
            Optional<IReadOnlyList<NicIPAddressSettings>> ipAddressInfo = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("allocationMethod"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allocationMethod = new IPAddressAllocationMethod(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dnsServers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    dnsServers = array;
                    continue;
                }
                if (property.NameEquals("gateway"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    gateway = array;
                    continue;
                }
                if (property.NameEquals("ipAddress"u8))
                {
                    ipAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subnetMask"u8))
                {
                    subnetMask = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("primaryWinsServer"u8))
                {
                    primaryWinsServer = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondaryWinsServer"u8))
                {
                    secondaryWinsServer = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ipAddressInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NicIPAddressSettings> array = new List<NicIPAddressSettings>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NicIPAddressSettings.DeserializeNicIPAddressSettings(item));
                    }
                    ipAddressInfo = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NicIPSettings(Optional.ToNullable(allocationMethod), Optional.ToList(dnsServers), Optional.ToList(gateway), ipAddress.Value, subnetMask.Value, primaryWinsServer.Value, secondaryWinsServer.Value, Optional.ToList(ipAddressInfo), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(AllocationMethod))
            {
                builder.Append("  allocationMethod:");
                builder.AppendLine($" '{AllocationMethod.ToString()}'");
            }

            if (Optional.IsCollectionDefined(DnsServers))
            {
                builder.Append("  dnsServers:");
                builder.AppendLine(" [");
                foreach (var item in DnsServers)
                {
                    if (item == null)
                    {
                        builder.Append("null");
                        continue;
                    }
                    builder.AppendLine($"    '{item}'");
                }
                builder.AppendLine("  ]");
            }

            if (Optional.IsCollectionDefined(Gateway))
            {
                builder.Append("  gateway:");
                builder.AppendLine(" [");
                foreach (var item in Gateway)
                {
                    if (item == null)
                    {
                        builder.Append("null");
                        continue;
                    }
                    builder.AppendLine($"    '{item}'");
                }
                builder.AppendLine("  ]");
            }

            if (Optional.IsDefined(IPAddress))
            {
                builder.Append("  ipAddress:");
                builder.AppendLine($" '{IPAddress}'");
            }

            if (Optional.IsDefined(SubnetMask))
            {
                builder.Append("  subnetMask:");
                builder.AppendLine($" '{SubnetMask}'");
            }

            if (Optional.IsDefined(PrimaryWinsServer))
            {
                builder.Append("  primaryWinsServer:");
                builder.AppendLine($" '{PrimaryWinsServer}'");
            }

            if (Optional.IsDefined(SecondaryWinsServer))
            {
                builder.Append("  secondaryWinsServer:");
                builder.AppendLine($" '{SecondaryWinsServer}'");
            }

            if (Optional.IsCollectionDefined(IPAddressInfo))
            {
                builder.Append("  ipAddressInfo:");
                builder.AppendLine(" [");
                foreach (var item in IPAddressInfo)
                {
                    AppendChildObject(builder, item, options, 4);
                }
                builder.AppendLine("  ]");
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

        BinaryData IPersistableModel<NicIPSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NicIPSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(NicIPSettings)} does not support '{options.Format}' format.");
            }
        }

        NicIPSettings IPersistableModel<NicIPSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NicIPSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNicIPSettings(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(NicIPSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NicIPSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
