// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Azure File datastore configuration. </summary>
    public partial class AzureFileDatastore : DatastoreProperties
    {
        /// <summary> Initializes a new instance of AzureFileDatastore. </summary>
        /// <param name="credentials">
        /// [Required] Account credentials.
        /// Please note <see cref="DatastoreCredentials"/> is the base class. In order to more specifically assign or retrieve the value of this property, the derived class is needed.
        /// The available derived classes include <see cref="AccountKeyDatastoreCredentials"/>, <see cref="CertificateDatastoreCredentials"/>, <see cref="KerberosKeytabCredentials"/>, <see cref="KerberosPasswordCredentials"/>, <see cref="NoneDatastoreCredentials"/>, <see cref="SasDatastoreCredentials"/>, <see cref="ServicePrincipalDatastoreCredentials"/>.
        /// </param>
        /// <param name="accountName"> [Required] Storage account name. </param>
        /// <param name="fileShareName"> [Required] TODO - File share name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="credentials"/>, <paramref name="accountName"/> or <paramref name="fileShareName"/> is null. </exception>
        public AzureFileDatastore(DatastoreCredentials credentials, string accountName, string fileShareName) : base(credentials)
        {
            if (credentials == null)
            {
                throw new ArgumentNullException(nameof(credentials));
            }
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }
            if (fileShareName == null)
            {
                throw new ArgumentNullException(nameof(fileShareName));
            }

            AccountName = accountName;
            FileShareName = fileShareName;
            DatastoreType = DatastoreType.AzureFile;
        }

        /// <summary> Initializes a new instance of AzureFileDatastore. </summary>
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
        /// <param name="accountName"> [Required] Storage account name. </param>
        /// <param name="endpoint"> Azure cloud endpoint for the storage account. </param>
        /// <param name="fileShareName"> [Required] TODO - File share name. </param>
        /// <param name="protocol"> Protocol used to communicate with the storage account. </param>
        /// <param name="serviceDataAccessAuthIdentity"> Indicates which identity to use to authenticate service data access to customer&apos;s storage. </param>
        internal AzureFileDatastore(string description, IDictionary<string, string> properties, IDictionary<string, string> tags, DatastoreCredentials credentials, DatastoreType datastoreType, bool? isDefault, string accountName, string endpoint, string fileShareName, string protocol, ServiceDataAccessAuthIdentity? serviceDataAccessAuthIdentity) : base(description, properties, tags, credentials, datastoreType, isDefault)
        {
            AccountName = accountName;
            Endpoint = endpoint;
            FileShareName = fileShareName;
            Protocol = protocol;
            ServiceDataAccessAuthIdentity = serviceDataAccessAuthIdentity;
            DatastoreType = datastoreType;
        }

        /// <summary> [Required] Storage account name. </summary>
        public string AccountName { get; set; }
        /// <summary> Azure cloud endpoint for the storage account. </summary>
        public string Endpoint { get; set; }
        /// <summary> [Required] TODO - File share name. </summary>
        public string FileShareName { get; set; }
        /// <summary> Protocol used to communicate with the storage account. </summary>
        public string Protocol { get; set; }
        /// <summary> Indicates which identity to use to authenticate service data access to customer&apos;s storage. </summary>
        public ServiceDataAccessAuthIdentity? ServiceDataAccessAuthIdentity { get; set; }
    }
}
