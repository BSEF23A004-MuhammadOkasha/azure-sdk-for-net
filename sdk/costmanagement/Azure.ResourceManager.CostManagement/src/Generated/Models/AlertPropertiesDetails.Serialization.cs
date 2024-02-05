// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CostManagement.Models
{
    public partial class AlertPropertiesDetails : IUtf8JsonSerializable, IJsonModel<AlertPropertiesDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AlertPropertiesDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AlertPropertiesDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AlertPropertiesDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AlertPropertiesDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(TimeGrainType))
            {
                writer.WritePropertyName("timeGrainType"u8);
                writer.WriteStringValue(TimeGrainType.Value.ToString());
            }
            if (Optional.IsDefined(PeriodStartDate))
            {
                writer.WritePropertyName("periodStartDate"u8);
                writer.WriteStringValue(PeriodStartDate);
            }
            if (Optional.IsDefined(TriggeredBy))
            {
                writer.WritePropertyName("triggeredBy"u8);
                writer.WriteStringValue(TriggeredBy);
            }
            if (Optional.IsCollectionDefined(ResourceGroupFilter))
            {
                writer.WritePropertyName("resourceGroupFilter"u8);
                writer.WriteStartArray();
                foreach (var item in ResourceGroupFilter)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item);
#else
                    using (JsonDocument document = JsonDocument.Parse(item))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ResourceFilter))
            {
                writer.WritePropertyName("resourceFilter"u8);
                writer.WriteStartArray();
                foreach (var item in ResourceFilter)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item);
#else
                    using (JsonDocument document = JsonDocument.Parse(item))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(MeterFilter))
            {
                writer.WritePropertyName("meterFilter"u8);
                writer.WriteStartArray();
                foreach (var item in MeterFilter)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item);
#else
                    using (JsonDocument document = JsonDocument.Parse(item))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(TagFilter))
            {
                writer.WritePropertyName("tagFilter"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(TagFilter);
#else
                using (JsonDocument document = JsonDocument.Parse(TagFilter))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(Threshold))
            {
                writer.WritePropertyName("threshold"u8);
                writer.WriteNumberValue(Threshold.Value);
            }
            if (Optional.IsDefined(Operator))
            {
                writer.WritePropertyName("operator"u8);
                writer.WriteStringValue(Operator.Value.ToString());
            }
            if (Optional.IsDefined(Amount))
            {
                writer.WritePropertyName("amount"u8);
                writer.WriteNumberValue(Amount.Value);
            }
            if (Optional.IsDefined(Unit))
            {
                writer.WritePropertyName("unit"u8);
                writer.WriteStringValue(Unit);
            }
            if (Optional.IsDefined(CurrentSpend))
            {
                writer.WritePropertyName("currentSpend"u8);
                writer.WriteNumberValue(CurrentSpend.Value);
            }
            if (Optional.IsCollectionDefined(ContactEmails))
            {
                writer.WritePropertyName("contactEmails"u8);
                writer.WriteStartArray();
                foreach (var item in ContactEmails)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ContactGroups))
            {
                writer.WritePropertyName("contactGroups"u8);
                writer.WriteStartArray();
                foreach (var item in ContactGroups)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ContactRoles))
            {
                writer.WritePropertyName("contactRoles"u8);
                writer.WriteStartArray();
                foreach (var item in ContactRoles)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(OverridingAlert))
            {
                writer.WritePropertyName("overridingAlert"u8);
                writer.WriteStringValue(OverridingAlert);
            }
            if (Optional.IsDefined(DepartmentName))
            {
                writer.WritePropertyName("departmentName"u8);
                writer.WriteStringValue(DepartmentName);
            }
            if (Optional.IsDefined(CompanyName))
            {
                writer.WritePropertyName("companyName"u8);
                writer.WriteStringValue(CompanyName);
            }
            if (Optional.IsDefined(EnrollmentNumber))
            {
                writer.WritePropertyName("enrollmentNumber"u8);
                writer.WriteStringValue(EnrollmentNumber);
            }
            if (Optional.IsDefined(EnrollmentStartDate))
            {
                writer.WritePropertyName("enrollmentStartDate"u8);
                writer.WriteStringValue(EnrollmentStartDate);
            }
            if (Optional.IsDefined(EnrollmentEndDate))
            {
                writer.WritePropertyName("enrollmentEndDate"u8);
                writer.WriteStringValue(EnrollmentEndDate);
            }
            if (Optional.IsDefined(InvoicingThreshold))
            {
                writer.WritePropertyName("invoicingThreshold"u8);
                writer.WriteNumberValue(InvoicingThreshold.Value);
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

        AlertPropertiesDetails IJsonModel<AlertPropertiesDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AlertPropertiesDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AlertPropertiesDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAlertPropertiesDetails(document.RootElement, options);
        }

        internal static AlertPropertiesDetails DeserializeAlertPropertiesDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AlertTimeGrainType> timeGrainType = default;
            Optional<string> periodStartDate = default;
            Optional<string> triggeredBy = default;
            Optional<IList<BinaryData>> resourceGroupFilter = default;
            Optional<IList<BinaryData>> resourceFilter = default;
            Optional<IList<BinaryData>> meterFilter = default;
            Optional<BinaryData> tagFilter = default;
            Optional<decimal> threshold = default;
            Optional<CostManagementAlertOperator> @operator = default;
            Optional<decimal> amount = default;
            Optional<string> unit = default;
            Optional<decimal> currentSpend = default;
            Optional<IList<string>> contactEmails = default;
            Optional<IList<string>> contactGroups = default;
            Optional<IList<string>> contactRoles = default;
            Optional<string> overridingAlert = default;
            Optional<string> departmentName = default;
            Optional<string> companyName = default;
            Optional<string> enrollmentNumber = default;
            Optional<string> enrollmentStartDate = default;
            Optional<string> enrollmentEndDate = default;
            Optional<decimal> invoicingThreshold = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("timeGrainType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeGrainType = new AlertTimeGrainType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("periodStartDate"u8))
                {
                    periodStartDate = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("triggeredBy"u8))
                {
                    triggeredBy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceGroupFilter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BinaryData> array = new List<BinaryData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(BinaryData.FromString(item.GetRawText()));
                        }
                    }
                    resourceGroupFilter = array;
                    continue;
                }
                if (property.NameEquals("resourceFilter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BinaryData> array = new List<BinaryData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(BinaryData.FromString(item.GetRawText()));
                        }
                    }
                    resourceFilter = array;
                    continue;
                }
                if (property.NameEquals("meterFilter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BinaryData> array = new List<BinaryData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(BinaryData.FromString(item.GetRawText()));
                        }
                    }
                    meterFilter = array;
                    continue;
                }
                if (property.NameEquals("tagFilter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tagFilter = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("threshold"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    threshold = property.Value.GetDecimal();
                    continue;
                }
                if (property.NameEquals("operator"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    @operator = new CostManagementAlertOperator(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("amount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    amount = property.Value.GetDecimal();
                    continue;
                }
                if (property.NameEquals("unit"u8))
                {
                    unit = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("currentSpend"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    currentSpend = property.Value.GetDecimal();
                    continue;
                }
                if (property.NameEquals("contactEmails"u8))
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
                    contactEmails = array;
                    continue;
                }
                if (property.NameEquals("contactGroups"u8))
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
                    contactGroups = array;
                    continue;
                }
                if (property.NameEquals("contactRoles"u8))
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
                    contactRoles = array;
                    continue;
                }
                if (property.NameEquals("overridingAlert"u8))
                {
                    overridingAlert = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("departmentName"u8))
                {
                    departmentName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("companyName"u8))
                {
                    companyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("enrollmentNumber"u8))
                {
                    enrollmentNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("enrollmentStartDate"u8))
                {
                    enrollmentStartDate = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("enrollmentEndDate"u8))
                {
                    enrollmentEndDate = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("invoicingThreshold"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    invoicingThreshold = property.Value.GetDecimal();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AlertPropertiesDetails(Optional.ToNullable(timeGrainType), periodStartDate.Value, triggeredBy.Value, Optional.ToList(resourceGroupFilter), Optional.ToList(resourceFilter), Optional.ToList(meterFilter), tagFilter.Value, Optional.ToNullable(threshold), Optional.ToNullable(@operator), Optional.ToNullable(amount), unit.Value, Optional.ToNullable(currentSpend), Optional.ToList(contactEmails), Optional.ToList(contactGroups), Optional.ToList(contactRoles), overridingAlert.Value, departmentName.Value, companyName.Value, enrollmentNumber.Value, enrollmentStartDate.Value, enrollmentEndDate.Value, Optional.ToNullable(invoicingThreshold), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(TimeGrainType))
            {
                builder.Append("  timeGrainType:");
                builder.AppendLine($" '{TimeGrainType.ToString()}'");
            }

            if (Optional.IsDefined(PeriodStartDate))
            {
                builder.Append("  periodStartDate:");
                builder.AppendLine($" '{PeriodStartDate}'");
            }

            if (Optional.IsDefined(TriggeredBy))
            {
                builder.Append("  triggeredBy:");
                builder.AppendLine($" '{TriggeredBy}'");
            }

            if (Optional.IsCollectionDefined(ResourceGroupFilter))
            {
                if (ResourceGroupFilter.Any())
                {
                    builder.Append("  resourceGroupFilter:");
                    builder.AppendLine(" [");
                    foreach (var item in ResourceGroupFilter)
                    {
                        if (item == null)
                        {
                            builder.Append("null");
                            continue;
                        }
                        builder.AppendLine($"    '{item.ToString()}'");
                    }
                    builder.AppendLine("  ]");
                }
            }

            if (Optional.IsCollectionDefined(ResourceFilter))
            {
                if (ResourceFilter.Any())
                {
                    builder.Append("  resourceFilter:");
                    builder.AppendLine(" [");
                    foreach (var item in ResourceFilter)
                    {
                        if (item == null)
                        {
                            builder.Append("null");
                            continue;
                        }
                        builder.AppendLine($"    '{item.ToString()}'");
                    }
                    builder.AppendLine("  ]");
                }
            }

            if (Optional.IsCollectionDefined(MeterFilter))
            {
                if (MeterFilter.Any())
                {
                    builder.Append("  meterFilter:");
                    builder.AppendLine(" [");
                    foreach (var item in MeterFilter)
                    {
                        if (item == null)
                        {
                            builder.Append("null");
                            continue;
                        }
                        builder.AppendLine($"    '{item.ToString()}'");
                    }
                    builder.AppendLine("  ]");
                }
            }

            if (Optional.IsDefined(TagFilter))
            {
                builder.Append("  tagFilter:");
                builder.AppendLine($" '{TagFilter.ToString()}'");
            }

            if (Optional.IsDefined(Threshold))
            {
                builder.Append("  threshold:");
                builder.AppendLine($" '{Threshold.Value.ToString()}'");
            }

            if (Optional.IsDefined(Operator))
            {
                builder.Append("  operator:");
                builder.AppendLine($" '{Operator.ToString()}'");
            }

            if (Optional.IsDefined(Amount))
            {
                builder.Append("  amount:");
                builder.AppendLine($" '{Amount.Value.ToString()}'");
            }

            if (Optional.IsDefined(Unit))
            {
                builder.Append("  unit:");
                builder.AppendLine($" '{Unit}'");
            }

            if (Optional.IsDefined(CurrentSpend))
            {
                builder.Append("  currentSpend:");
                builder.AppendLine($" '{CurrentSpend.Value.ToString()}'");
            }

            if (Optional.IsCollectionDefined(ContactEmails))
            {
                if (ContactEmails.Any())
                {
                    builder.Append("  contactEmails:");
                    builder.AppendLine(" [");
                    foreach (var item in ContactEmails)
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
            }

            if (Optional.IsCollectionDefined(ContactGroups))
            {
                if (ContactGroups.Any())
                {
                    builder.Append("  contactGroups:");
                    builder.AppendLine(" [");
                    foreach (var item in ContactGroups)
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
            }

            if (Optional.IsCollectionDefined(ContactRoles))
            {
                if (ContactRoles.Any())
                {
                    builder.Append("  contactRoles:");
                    builder.AppendLine(" [");
                    foreach (var item in ContactRoles)
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
            }

            if (Optional.IsDefined(OverridingAlert))
            {
                builder.Append("  overridingAlert:");
                builder.AppendLine($" '{OverridingAlert}'");
            }

            if (Optional.IsDefined(DepartmentName))
            {
                builder.Append("  departmentName:");
                builder.AppendLine($" '{DepartmentName}'");
            }

            if (Optional.IsDefined(CompanyName))
            {
                builder.Append("  companyName:");
                builder.AppendLine($" '{CompanyName}'");
            }

            if (Optional.IsDefined(EnrollmentNumber))
            {
                builder.Append("  enrollmentNumber:");
                builder.AppendLine($" '{EnrollmentNumber}'");
            }

            if (Optional.IsDefined(EnrollmentStartDate))
            {
                builder.Append("  enrollmentStartDate:");
                builder.AppendLine($" '{EnrollmentStartDate}'");
            }

            if (Optional.IsDefined(EnrollmentEndDate))
            {
                builder.Append("  enrollmentEndDate:");
                builder.AppendLine($" '{EnrollmentEndDate}'");
            }

            if (Optional.IsDefined(InvoicingThreshold))
            {
                builder.Append("  invoicingThreshold:");
                builder.AppendLine($" '{InvoicingThreshold.Value.ToString()}'");
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

        BinaryData IPersistableModel<AlertPropertiesDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AlertPropertiesDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(AlertPropertiesDetails)} does not support '{options.Format}' format.");
            }
        }

        AlertPropertiesDetails IPersistableModel<AlertPropertiesDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AlertPropertiesDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAlertPropertiesDetails(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(AlertPropertiesDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AlertPropertiesDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
