// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.IotHub.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for JobType.
    /// </summary>
    public static class JobType
    {
        public const string Unknown = "unknown";
        public const string Export = "export";
        public const string Import = "import";
        public const string Backup = "backup";
        public const string ReadDeviceProperties = "readDeviceProperties";
        public const string WriteDeviceProperties = "writeDeviceProperties";
        public const string UpdateDeviceConfiguration = "updateDeviceConfiguration";
        public const string RebootDevice = "rebootDevice";
        public const string FactoryResetDevice = "factoryResetDevice";
        public const string FirmwareUpdate = "firmwareUpdate";
    }
}
