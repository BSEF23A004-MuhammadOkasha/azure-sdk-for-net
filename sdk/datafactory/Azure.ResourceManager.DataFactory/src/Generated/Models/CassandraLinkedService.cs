// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Linked service for Cassandra data source. </summary>
    public partial class CassandraLinkedService : DataFactoryLinkedServiceProperties
    {
        /// <summary> Initializes a new instance of <see cref="CassandraLinkedService"/>. </summary>
        /// <param name="host"> Host name for connection. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="host"/> is null. </exception>
        public CassandraLinkedService(DataFactoryElement<string> host)
        {
            Argument.AssertNotNull(host, nameof(host));

            Host = host;
            LinkedServiceType = "Cassandra";
        }

        /// <summary> Initializes a new instance of <see cref="CassandraLinkedService"/>. </summary>
        /// <param name="linkedServiceType"> Type of linked service. </param>
        /// <param name="linkedServiceVersion"> Version of the linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="host"> Host name for connection. Type: string (or Expression with resultType string). </param>
        /// <param name="authenticationType"> AuthenticationType to be used for connection. Type: string (or Expression with resultType string). </param>
        /// <param name="port"> The port for the connection. Type: integer (or Expression with resultType integer). </param>
        /// <param name="username"> Username for authentication. Type: string (or Expression with resultType string). </param>
        /// <param name="password"> Password for authentication. </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </param>
        internal CassandraLinkedService(string linkedServiceType, string linkedServiceVersion, IntegrationRuntimeReference connectVia, string description, IDictionary<string, EntityParameterSpecification> parameters, IList<BinaryData> annotations, IDictionary<string, BinaryData> additionalProperties, DataFactoryElement<string> host, DataFactoryElement<string> authenticationType, DataFactoryElement<int> port, DataFactoryElement<string> username, DataFactorySecret password, string encryptedCredential) : base(linkedServiceType, linkedServiceVersion, connectVia, description, parameters, annotations, additionalProperties)
        {
            Host = host;
            AuthenticationType = authenticationType;
            Port = port;
            Username = username;
            Password = password;
            EncryptedCredential = encryptedCredential;
            LinkedServiceType = linkedServiceType ?? "Cassandra";
        }

        /// <summary> Initializes a new instance of <see cref="CassandraLinkedService"/> for deserialization. </summary>
        internal CassandraLinkedService()
        {
        }

        /// <summary> Host name for connection. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Host { get; set; }
        /// <summary> AuthenticationType to be used for connection. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> AuthenticationType { get; set; }
        /// <summary> The port for the connection. Type: integer (or Expression with resultType integer). </summary>
        public DataFactoryElement<int> Port { get; set; }
        /// <summary> Username for authentication. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Username { get; set; }
        /// <summary> Password for authentication. </summary>
        public DataFactorySecret Password { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </summary>
        public string EncryptedCredential { get; set; }
    }
}
