// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.IotHub.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// The properties that describe the keys to access the IotHub artifacts.
    /// </summary>
    public partial class SharedAccessSignatureAuthorizationRule
    {
        /// <summary>
        /// Initializes a new instance of the
        /// SharedAccessSignatureAuthorizationRule class.
        /// </summary>
        public SharedAccessSignatureAuthorizationRule() { }

        /// <summary>
        /// Initializes a new instance of the
        /// SharedAccessSignatureAuthorizationRule class.
        /// </summary>
        public SharedAccessSignatureAuthorizationRule(string keyName = default(string), string primaryKey = default(string), string secondaryKey = default(string), AccessRights? rights = default(AccessRights?))
        {
            KeyName = keyName;
            PrimaryKey = primaryKey;
            SecondaryKey = secondaryKey;
            Rights = rights;
        }

        /// <summary>
        /// The name of the key.
        /// </summary>
        [JsonProperty(PropertyName = "keyName")]
        public string KeyName { get; set; }

        /// <summary>
        /// The primary key.
        /// </summary>
        [JsonProperty(PropertyName = "primaryKey")]
        public string PrimaryKey { get; set; }

        /// <summary>
        /// The secondary key.
        /// </summary>
        [JsonProperty(PropertyName = "secondaryKey")]
        public string SecondaryKey { get; set; }

        /// <summary>
        /// The access rights. Possible values include: 'RegistryRead',
        /// 'RegistryWrite', 'ServiceConnect', 'DeviceConnect',
        /// 'RegistryRead, RegistryWrite', 'RegistryRead, ServiceConnect',
        /// 'RegistryRead, DeviceConnect', 'RegistryWrite, ServiceConnect',
        /// 'RegistryWrite, DeviceConnect', 'ServiceConnect, DeviceConnect',
        /// 'RegistryRead, RegistryWrite, ServiceConnect', 'RegistryRead,
        /// RegistryWrite, DeviceConnect', 'RegistryRead, ServiceConnect,
        /// DeviceConnect', 'RegistryWrite, ServiceConnect, DeviceConnect',
        /// 'RegistryRead, RegistryWrite, ServiceConnect, DeviceConnect'
        /// </summary>
        [JsonProperty(PropertyName = "rights")]
        public AccessRights? Rights { get; set; }

    }
}
