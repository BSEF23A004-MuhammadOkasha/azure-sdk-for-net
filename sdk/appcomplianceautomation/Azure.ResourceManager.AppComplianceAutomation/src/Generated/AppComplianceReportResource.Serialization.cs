// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.AppComplianceAutomation
{
    public partial class AppComplianceReportResource : IJsonModel<AppComplianceReportData>
    {
        void IJsonModel<AppComplianceReportData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<AppComplianceReportData>)Data).Write(writer, options);

        AppComplianceReportData IJsonModel<AppComplianceReportData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<AppComplianceReportData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<AppComplianceReportData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        AppComplianceReportData IPersistableModel<AppComplianceReportData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<AppComplianceReportData>(data, options);

        string IPersistableModel<AppComplianceReportData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<AppComplianceReportData>)Data).GetFormatFromOptions(options);
    }
}
