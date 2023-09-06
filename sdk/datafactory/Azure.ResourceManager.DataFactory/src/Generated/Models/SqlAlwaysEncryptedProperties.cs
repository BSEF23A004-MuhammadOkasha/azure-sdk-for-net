// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Sql always encrypted properties. </summary>
    public partial class SqlAlwaysEncryptedProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SqlAlwaysEncryptedProperties"/>. </summary>
        /// <param name="alwaysEncryptedAkvAuthType"> Sql always encrypted AKV authentication type. Type: string. </param>
        public SqlAlwaysEncryptedProperties(SqlAlwaysEncryptedAkvAuthType alwaysEncryptedAkvAuthType)
        {
            AlwaysEncryptedAkvAuthType = alwaysEncryptedAkvAuthType;
        }

        /// <summary> Initializes a new instance of <see cref="SqlAlwaysEncryptedProperties"/>. </summary>
        /// <param name="alwaysEncryptedAkvAuthType"> Sql always encrypted AKV authentication type. Type: string. </param>
        /// <param name="servicePrincipalId"> The client ID of the application in Azure Active Directory used for Azure Key Vault authentication. Type: string (or Expression with resultType string). </param>
        /// <param name="servicePrincipalKey"> The key of the service principal used to authenticate against Azure Key Vault. </param>
        /// <param name="credential"> The credential reference containing authentication information. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SqlAlwaysEncryptedProperties(SqlAlwaysEncryptedAkvAuthType alwaysEncryptedAkvAuthType, DataFactoryElement<string> servicePrincipalId, DataFactorySecretBaseDefinition servicePrincipalKey, DataFactoryCredentialReference credential, Dictionary<string, BinaryData> rawData)
        {
            AlwaysEncryptedAkvAuthType = alwaysEncryptedAkvAuthType;
            ServicePrincipalId = servicePrincipalId;
            ServicePrincipalKey = servicePrincipalKey;
            Credential = credential;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="SqlAlwaysEncryptedProperties"/> for deserialization. </summary>
        internal SqlAlwaysEncryptedProperties()
        {
        }

        /// <summary> Sql always encrypted AKV authentication type. Type: string. </summary>
        public SqlAlwaysEncryptedAkvAuthType AlwaysEncryptedAkvAuthType { get; set; }
        /// <summary> The client ID of the application in Azure Active Directory used for Azure Key Vault authentication. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> ServicePrincipalId { get; set; }
        /// <summary> The key of the service principal used to authenticate against Azure Key Vault. </summary>
        public DataFactorySecretBaseDefinition ServicePrincipalKey { get; set; }
        /// <summary> The credential reference containing authentication information. </summary>
        public DataFactoryCredentialReference Credential { get; set; }
    }
}
