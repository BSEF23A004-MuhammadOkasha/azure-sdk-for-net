// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class DefenderForDatabasesAwsOffering : IUtf8JsonSerializable, IJsonModel<DefenderForDatabasesAwsOffering>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DefenderForDatabasesAwsOffering>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DefenderForDatabasesAwsOffering>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderForDatabasesAwsOffering>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DefenderForDatabasesAwsOffering)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(ArcAutoProvisioning))
            {
                writer.WritePropertyName("arcAutoProvisioning"u8);
                writer.WriteObjectValue(ArcAutoProvisioning, options);
            }
            if (Optional.IsDefined(Rds))
            {
                writer.WritePropertyName("rds"u8);
                writer.WriteObjectValue(Rds, options);
            }
            if (Optional.IsDefined(DatabasesDspm))
            {
                writer.WritePropertyName("databasesDspm"u8);
                writer.WriteObjectValue(DatabasesDspm, options);
            }
        }

        DefenderForDatabasesAwsOffering IJsonModel<DefenderForDatabasesAwsOffering>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderForDatabasesAwsOffering>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DefenderForDatabasesAwsOffering)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDefenderForDatabasesAwsOffering(document.RootElement, options);
        }

        internal static DefenderForDatabasesAwsOffering DeserializeDefenderForDatabasesAwsOffering(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DefenderForDatabasesAwsOfferingArcAutoProvisioning arcAutoProvisioning = default;
            DefenderForDatabasesAwsOfferingRds rds = default;
            DefenderFoDatabasesAwsOfferingDatabasesDspm databasesDspm = default;
            OfferingType offeringType = default;
            string description = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("arcAutoProvisioning"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    arcAutoProvisioning = DefenderForDatabasesAwsOfferingArcAutoProvisioning.DeserializeDefenderForDatabasesAwsOfferingArcAutoProvisioning(property.Value, options);
                    continue;
                }
                if (property.NameEquals("rds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rds = DefenderForDatabasesAwsOfferingRds.DeserializeDefenderForDatabasesAwsOfferingRds(property.Value, options);
                    continue;
                }
                if (property.NameEquals("databasesDspm"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    databasesDspm = DefenderFoDatabasesAwsOfferingDatabasesDspm.DeserializeDefenderFoDatabasesAwsOfferingDatabasesDspm(property.Value, options);
                    continue;
                }
                if (property.NameEquals("offeringType"u8))
                {
                    offeringType = new OfferingType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DefenderForDatabasesAwsOffering(
                offeringType,
                description,
                serializedAdditionalRawData,
                arcAutoProvisioning,
                rds,
                databasesDspm);
        }

        BinaryData IPersistableModel<DefenderForDatabasesAwsOffering>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderForDatabasesAwsOffering>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DefenderForDatabasesAwsOffering)} does not support writing '{options.Format}' format.");
            }
        }

        DefenderForDatabasesAwsOffering IPersistableModel<DefenderForDatabasesAwsOffering>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderForDatabasesAwsOffering>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDefenderForDatabasesAwsOffering(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DefenderForDatabasesAwsOffering)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DefenderForDatabasesAwsOffering>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
