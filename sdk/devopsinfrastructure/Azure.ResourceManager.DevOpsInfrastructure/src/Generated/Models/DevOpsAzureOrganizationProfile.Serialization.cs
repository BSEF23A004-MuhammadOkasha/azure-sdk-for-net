// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DevOpsInfrastructure.Models
{
    public partial class DevOpsAzureOrganizationProfile : IUtf8JsonSerializable, IJsonModel<DevOpsAzureOrganizationProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DevOpsAzureOrganizationProfile>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DevOpsAzureOrganizationProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevOpsAzureOrganizationProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevOpsAzureOrganizationProfile)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("organizations"u8);
            writer.WriteStartArray();
            foreach (var item in Organizations)
            {
                writer.WriteObjectValue(item, options);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(PermissionProfile))
            {
                writer.WritePropertyName("permissionProfile"u8);
                writer.WriteObjectValue(PermissionProfile, options);
            }
        }

        DevOpsAzureOrganizationProfile IJsonModel<DevOpsAzureOrganizationProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevOpsAzureOrganizationProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevOpsAzureOrganizationProfile)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDevOpsAzureOrganizationProfile(document.RootElement, options);
        }

        internal static DevOpsAzureOrganizationProfile DeserializeDevOpsAzureOrganizationProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<DevOpsOrganization> organizations = default;
            DevOpsAzurePermissionProfile permissionProfile = default;
            string kind = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("organizations"u8))
                {
                    List<DevOpsOrganization> array = new List<DevOpsOrganization>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DevOpsOrganization.DeserializeDevOpsOrganization(item, options));
                    }
                    organizations = array;
                    continue;
                }
                if (property.NameEquals("permissionProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    permissionProfile = DevOpsAzurePermissionProfile.DeserializeDevOpsAzurePermissionProfile(property.Value, options);
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DevOpsAzureOrganizationProfile(kind, serializedAdditionalRawData, organizations, permissionProfile);
        }

        BinaryData IPersistableModel<DevOpsAzureOrganizationProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevOpsAzureOrganizationProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DevOpsAzureOrganizationProfile)} does not support writing '{options.Format}' format.");
            }
        }

        DevOpsAzureOrganizationProfile IPersistableModel<DevOpsAzureOrganizationProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevOpsAzureOrganizationProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDevOpsAzureOrganizationProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DevOpsAzureOrganizationProfile)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DevOpsAzureOrganizationProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
