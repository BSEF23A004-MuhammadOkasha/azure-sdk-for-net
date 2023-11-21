// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Office365 linked service. </summary>
    public partial class Office365LinkedService : DataFactoryLinkedServiceProperties
    {
        /// <summary> Initializes a new instance of <see cref="Office365LinkedService"/>. </summary>
        /// <param name="office365TenantId"> Azure tenant ID to which the Office 365 account belongs. Type: string (or Expression with resultType string). </param>
        /// <param name="servicePrincipalTenantId"> Specify the tenant information under which your Azure AD web application resides. Type: string (or Expression with resultType string). </param>
        /// <param name="servicePrincipalId"> Specify the application's client ID. Type: string (or Expression with resultType string). </param>
        /// <param name="servicePrincipalKey"> Specify the application's key. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="office365TenantId"/>, <paramref name="servicePrincipalTenantId"/>, <paramref name="servicePrincipalId"/> or <paramref name="servicePrincipalKey"/> is null. </exception>
        public Office365LinkedService(DataFactoryElement<string> office365TenantId, DataFactoryElement<string> servicePrincipalTenantId, DataFactoryElement<string> servicePrincipalId, DataFactorySecretBaseDefinition servicePrincipalKey)
        {
            Argument.AssertNotNull(office365TenantId, nameof(office365TenantId));
            Argument.AssertNotNull(servicePrincipalTenantId, nameof(servicePrincipalTenantId));
            Argument.AssertNotNull(servicePrincipalId, nameof(servicePrincipalId));
            Argument.AssertNotNull(servicePrincipalKey, nameof(servicePrincipalKey));

            Office365TenantId = office365TenantId;
            ServicePrincipalTenantId = servicePrincipalTenantId;
            ServicePrincipalId = servicePrincipalId;
            ServicePrincipalKey = servicePrincipalKey;
            LinkedServiceType = "Office365";
        }

        /// <summary> Initializes a new instance of <see cref="Office365LinkedService"/>. </summary>
        /// <param name="linkedServiceType"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="office365TenantId"> Azure tenant ID to which the Office 365 account belongs. Type: string (or Expression with resultType string). </param>
        /// <param name="servicePrincipalTenantId"> Specify the tenant information under which your Azure AD web application resides. Type: string (or Expression with resultType string). </param>
        /// <param name="servicePrincipalId"> Specify the application's client ID. Type: string (or Expression with resultType string). </param>
        /// <param name="servicePrincipalKey"> Specify the application's key. </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </param>
        internal Office365LinkedService(string linkedServiceType, IntegrationRuntimeReference connectVia, string description, IDictionary<string, EntityParameterSpecification> parameters, IList<BinaryData> annotations, IDictionary<string, BinaryData> additionalProperties, DataFactoryElement<string> office365TenantId, DataFactoryElement<string> servicePrincipalTenantId, DataFactoryElement<string> servicePrincipalId, DataFactorySecretBaseDefinition servicePrincipalKey, string encryptedCredential) : base(linkedServiceType, connectVia, description, parameters, annotations, additionalProperties)
        {
            Office365TenantId = office365TenantId;
            ServicePrincipalTenantId = servicePrincipalTenantId;
            ServicePrincipalId = servicePrincipalId;
            ServicePrincipalKey = servicePrincipalKey;
            EncryptedCredential = encryptedCredential;
            LinkedServiceType = linkedServiceType ?? "Office365";
        }

        /// <summary> Initializes a new instance of <see cref="Office365LinkedService"/> for deserialization. </summary>
        internal Office365LinkedService()
        {
        }

        /// <summary> Azure tenant ID to which the Office 365 account belongs. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Office365TenantId { get; set; }
        /// <summary> Specify the tenant information under which your Azure AD web application resides. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> ServicePrincipalTenantId { get; set; }
        /// <summary> Specify the application's client ID. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> ServicePrincipalId { get; set; }
        /// <summary> Specify the application's key. </summary>
        public DataFactorySecretBaseDefinition ServicePrincipalKey { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </summary>
        public string EncryptedCredential { get; set; }
    }
}
