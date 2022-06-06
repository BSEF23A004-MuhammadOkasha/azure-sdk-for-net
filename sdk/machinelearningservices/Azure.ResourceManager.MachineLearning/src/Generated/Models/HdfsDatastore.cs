// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The HdfsDatastore. </summary>
    public partial class HdfsDatastore : DatastoreProperties
    {
        /// <summary> Initializes a new instance of HdfsDatastore. </summary>
        /// <param name="credentials">
        /// [Required] Account credentials.
        /// Please note <see cref="DatastoreCredentials"/> is the base class. In order to more specifically assign or retrieve the value of this property, the derived class is needed.
        /// The available derived classes include <see cref="AccountKeyDatastoreCredentials"/>, <see cref="CertificateDatastoreCredentials"/>, <see cref="KerberosKeytabCredentials"/>, <see cref="KerberosPasswordCredentials"/>, <see cref="NoneDatastoreCredentials"/>, <see cref="SasDatastoreCredentials"/>, <see cref="ServicePrincipalDatastoreCredentials"/>.
        /// </param>
        /// <param name="nameNodeAddress"> [Required] IP Address or DNS HostName. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="credentials"/> or <paramref name="nameNodeAddress"/> is null. </exception>
        public HdfsDatastore(DatastoreCredentials credentials, string nameNodeAddress) : base(credentials)
        {
            if (credentials == null)
            {
                throw new ArgumentNullException(nameof(credentials));
            }
            if (nameNodeAddress == null)
            {
                throw new ArgumentNullException(nameof(nameNodeAddress));
            }

            NameNodeAddress = nameNodeAddress;
            DatastoreType = DatastoreType.Hdfs;
        }

        /// <summary> Initializes a new instance of HdfsDatastore. </summary>
        /// <param name="description"> The asset description text. </param>
        /// <param name="properties"> The asset property dictionary. </param>
        /// <param name="tags"> Tag dictionary. Tags can be added, removed, and updated. </param>
        /// <param name="credentials">
        /// [Required] Account credentials.
        /// Please note <see cref="DatastoreCredentials"/> is the base class. In order to more specifically assign or retrieve the value of this property, the derived class is needed.
        /// The available derived classes include <see cref="AccountKeyDatastoreCredentials"/>, <see cref="CertificateDatastoreCredentials"/>, <see cref="KerberosKeytabCredentials"/>, <see cref="KerberosPasswordCredentials"/>, <see cref="NoneDatastoreCredentials"/>, <see cref="SasDatastoreCredentials"/>, <see cref="ServicePrincipalDatastoreCredentials"/>.
        /// </param>
        /// <param name="datastoreType"> [Required] Storage type backing the datastore. </param>
        /// <param name="isDefault"> Readonly property to indicate if datastore is the workspace default datastore. </param>
        /// <param name="hdfsServerCertificate"> The TLS cert of the HDFS server. Needs to be a base64 encoded string. Required if &quot;Https&quot; protocol is selected. </param>
        /// <param name="nameNodeAddress"> [Required] IP Address or DNS HostName. </param>
        /// <param name="protocol"> Protocol used to communicate with the storage account (Https/Http). </param>
        internal HdfsDatastore(string description, IDictionary<string, string> properties, IDictionary<string, string> tags, DatastoreCredentials credentials, DatastoreType datastoreType, bool? isDefault, string hdfsServerCertificate, string nameNodeAddress, string protocol) : base(description, properties, tags, credentials, datastoreType, isDefault)
        {
            HdfsServerCertificate = hdfsServerCertificate;
            NameNodeAddress = nameNodeAddress;
            Protocol = protocol;
            DatastoreType = datastoreType;
        }

        /// <summary> The TLS cert of the HDFS server. Needs to be a base64 encoded string. Required if &quot;Https&quot; protocol is selected. </summary>
        public string HdfsServerCertificate { get; set; }
        /// <summary> [Required] IP Address or DNS HostName. </summary>
        public string NameNodeAddress { get; set; }
        /// <summary> Protocol used to communicate with the storage account (Https/Http). </summary>
        public string Protocol { get; set; }
    }
}
