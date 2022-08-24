// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class DataBoxHeavyJobDetails : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DevicePassword))
            {
                writer.WritePropertyName("devicePassword");
                writer.WriteStringValue(DevicePassword);
            }
            writer.WritePropertyName("contactDetails");
            writer.WriteObjectValue(ContactDetails);
            if (Optional.IsDefined(ShippingAddress))
            {
                writer.WritePropertyName("shippingAddress");
                writer.WriteObjectValue(ShippingAddress);
            }
            if (Optional.IsCollectionDefined(DataImportDetails))
            {
                writer.WritePropertyName("dataImportDetails");
                writer.WriteStartArray();
                foreach (var item in DataImportDetails)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(DataExportDetails))
            {
                writer.WritePropertyName("dataExportDetails");
                writer.WriteStartArray();
                foreach (var item in DataExportDetails)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("jobDetailsType");
            writer.WriteStringValue(JobDetailsType.ToSerialString());
            if (Optional.IsDefined(Preferences))
            {
                writer.WritePropertyName("preferences");
                writer.WriteObjectValue(Preferences);
            }
            if (Optional.IsDefined(KeyEncryptionKey))
            {
                writer.WritePropertyName("keyEncryptionKey");
                writer.WriteObjectValue(KeyEncryptionKey);
            }
            if (Optional.IsDefined(ExpectedDataSizeInTeraBytes))
            {
                writer.WritePropertyName("expectedDataSizeInTeraBytes");
                writer.WriteNumberValue(ExpectedDataSizeInTeraBytes.Value);
            }
            writer.WriteEndObject();
        }

        internal static DataBoxHeavyJobDetails DeserializeDataBoxHeavyJobDetails(JsonElement element)
        {
            Optional<IReadOnlyList<CopyProgress>> copyProgress = default;
            Optional<string> devicePassword = default;
            Optional<IReadOnlyList<JobStages>> jobStages = default;
            ContactDetails contactDetails = default;
            Optional<ShippingAddress> shippingAddress = default;
            Optional<PackageShippingDetails> deliveryPackage = default;
            Optional<PackageShippingDetails> returnPackage = default;
            Optional<IList<DataImportDetails>> dataImportDetails = default;
            Optional<IList<DataExportDetails>> dataExportDetails = default;
            ClassDiscriminator jobDetailsType = default;
            Optional<Preferences> preferences = default;
            Optional<IReadOnlyList<CopyLogDetails>> copyLogDetails = default;
            Optional<string> reverseShipmentLabelSasKey = default;
            Optional<string> chainOfCustodySasKey = default;
            Optional<DeviceErasureDetails> deviceErasureDetails = default;
            Optional<KeyEncryptionKey> keyEncryptionKey = default;
            Optional<int> expectedDataSizeInTeraBytes = default;
            Optional<IReadOnlyList<CustomerResolutionCode>> actions = default;
            Optional<LastMitigationActionOnJob> lastMitigationActionOnJob = default;
            Optional<DatacenterAddressResponse> datacenterAddress = default;
            Optional<DataCenterCode> dataCenterCode = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("copyProgress"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<CopyProgress> array = new List<CopyProgress>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Models.CopyProgress.DeserializeCopyProgress(item));
                    }
                    copyProgress = array;
                    continue;
                }
                if (property.NameEquals("devicePassword"))
                {
                    devicePassword = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("jobStages"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<JobStages> array = new List<JobStages>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Models.JobStages.DeserializeJobStages(item));
                    }
                    jobStages = array;
                    continue;
                }
                if (property.NameEquals("contactDetails"))
                {
                    contactDetails = ContactDetails.DeserializeContactDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("shippingAddress"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    shippingAddress = ShippingAddress.DeserializeShippingAddress(property.Value);
                    continue;
                }
                if (property.NameEquals("deliveryPackage"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    deliveryPackage = PackageShippingDetails.DeserializePackageShippingDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("returnPackage"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    returnPackage = PackageShippingDetails.DeserializePackageShippingDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("dataImportDetails"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<DataImportDetails> array = new List<DataImportDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Models.DataImportDetails.DeserializeDataImportDetails(item));
                    }
                    dataImportDetails = array;
                    continue;
                }
                if (property.NameEquals("dataExportDetails"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<DataExportDetails> array = new List<DataExportDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Models.DataExportDetails.DeserializeDataExportDetails(item));
                    }
                    dataExportDetails = array;
                    continue;
                }
                if (property.NameEquals("jobDetailsType"))
                {
                    jobDetailsType = property.Value.GetString().ToClassDiscriminator();
                    continue;
                }
                if (property.NameEquals("preferences"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    preferences = Preferences.DeserializePreferences(property.Value);
                    continue;
                }
                if (property.NameEquals("copyLogDetails"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<CopyLogDetails> array = new List<CopyLogDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Models.CopyLogDetails.DeserializeCopyLogDetails(item));
                    }
                    copyLogDetails = array;
                    continue;
                }
                if (property.NameEquals("reverseShipmentLabelSasKey"))
                {
                    reverseShipmentLabelSasKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("chainOfCustodySasKey"))
                {
                    chainOfCustodySasKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deviceErasureDetails"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    deviceErasureDetails = DeviceErasureDetails.DeserializeDeviceErasureDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("keyEncryptionKey"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    keyEncryptionKey = KeyEncryptionKey.DeserializeKeyEncryptionKey(property.Value);
                    continue;
                }
                if (property.NameEquals("expectedDataSizeInTeraBytes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    expectedDataSizeInTeraBytes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("actions"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<CustomerResolutionCode> array = new List<CustomerResolutionCode>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString().ToCustomerResolutionCode());
                    }
                    actions = array;
                    continue;
                }
                if (property.NameEquals("lastMitigationActionOnJob"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    lastMitigationActionOnJob = LastMitigationActionOnJob.DeserializeLastMitigationActionOnJob(property.Value);
                    continue;
                }
                if (property.NameEquals("datacenterAddress"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    datacenterAddress = DatacenterAddressResponse.DeserializeDatacenterAddressResponse(property.Value);
                    continue;
                }
                if (property.NameEquals("dataCenterCode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    dataCenterCode = new DataCenterCode(property.Value.GetString());
                    continue;
                }
            }
            return new DataBoxHeavyJobDetails(Optional.ToList(jobStages), contactDetails, shippingAddress.Value, deliveryPackage.Value, returnPackage.Value, Optional.ToList(dataImportDetails), Optional.ToList(dataExportDetails), jobDetailsType, preferences.Value, Optional.ToList(copyLogDetails), reverseShipmentLabelSasKey.Value, chainOfCustodySasKey.Value, deviceErasureDetails.Value, keyEncryptionKey.Value, Optional.ToNullable(expectedDataSizeInTeraBytes), Optional.ToList(actions), lastMitigationActionOnJob.Value, datacenterAddress.Value, Optional.ToNullable(dataCenterCode), Optional.ToList(copyProgress), devicePassword.Value);
        }
    }
}
