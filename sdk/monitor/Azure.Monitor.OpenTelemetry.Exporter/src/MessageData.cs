﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core;
using OpenTelemetry.Logs;

namespace Azure.Monitor.OpenTelemetry.Exporter.Models
{
    internal partial class MessageData
    {
        public MessageData(int version, LogRecord logRecord) : base(version)
        {
            Properties = new ChangeTrackingDictionary<string, string>();
            Measurements = new ChangeTrackingDictionary<string, double>();

            Message = LogsHelper.GetMessage(logRecord);
            LogsHelper.SetLogStateValuesToProperties(logRecord, Properties);
            SeverityLevel = LogsHelper.GetSeverityLevel(logRecord.LogLevel);
        }
    }
}
