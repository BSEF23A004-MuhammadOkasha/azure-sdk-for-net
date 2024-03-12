// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Expressions.DataFactory;
using Azure.ResourceManager.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Azure Function linked service. </summary>
    public partial class AzureFunctionLinkedService : DataFactoryLinkedServiceProperties
    {
        /// <summary> Initializes a new instance of <see cref="AzureFunctionLinkedService"/>. </summary>
        /// <param name="functionAppUri"> The endpoint of the Azure Function App. URL will be in the format https://&lt;accountName&gt;.azurewebsites.net. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="functionAppUri"/> is null. </exception>
        public AzureFunctionLinkedService(DataFactoryElement<string> functionAppUri)
        {
            Argument.AssertNotNull(functionAppUri, nameof(functionAppUri));

            FunctionAppUri = functionAppUri;
            LinkedServiceType = "AzureFunction";
        }

        /// <summary> Initializes a new instance of <see cref="AzureFunctionLinkedService"/>. </summary>
        /// <param name="linkedServiceType"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="functionAppUri"> The endpoint of the Azure Function App. URL will be in the format https://&lt;accountName&gt;.azurewebsites.net. Type: string (or Expression with resultType string). </param>
        /// <param name="functionKey"> Function or Host key for Azure Function App. </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </param>
        /// <param name="credential"> The credential reference containing authentication information. </param>
        /// <param name="resourceId"> Allowed token audiences for azure function. Type: string (or Expression with resultType string). </param>
        /// <param name="authentication"> Type of authentication (Required to specify MSI) used to connect to AzureFunction. Type: string (or Expression with resultType string). </param>
        internal AzureFunctionLinkedService(string linkedServiceType, IntegrationRuntimeReference connectVia, string description, IDictionary<string, EntityParameterSpecification> parameters, IList<BinaryData> annotations, IDictionary<string, BinaryData> additionalProperties, DataFactoryElement<string> functionAppUri, DataFactorySecret functionKey, string encryptedCredential, DataFactoryCredentialReference credential, DataFactoryElement<string> resourceId, DataFactoryElement<string> authentication) : base(linkedServiceType, connectVia, description, parameters, annotations, additionalProperties)
        {
            FunctionAppUri = functionAppUri;
            FunctionKey = functionKey;
            EncryptedCredential = encryptedCredential;
            Credential = credential;
            ResourceId = resourceId;
            Authentication = authentication;
            LinkedServiceType = linkedServiceType ?? "AzureFunction";
        }

        /// <summary> Initializes a new instance of <see cref="AzureFunctionLinkedService"/> for deserialization. </summary>
        internal AzureFunctionLinkedService()
        {
        }

        /// <summary> The endpoint of the Azure Function App. URL will be in the format https://&lt;accountName&gt;.azurewebsites.net. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> FunctionAppUri { get; set; }
        /// <summary> Function or Host key for Azure Function App. </summary>
        public DataFactorySecret FunctionKey { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </summary>
        public string EncryptedCredential { get; set; }
        /// <summary> The credential reference containing authentication information. </summary>
        public DataFactoryCredentialReference Credential { get; set; }
        /// <summary> Allowed token audiences for azure function. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> ResourceId { get; set; }
        /// <summary> Type of authentication (Required to specify MSI) used to connect to AzureFunction. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Authentication { get; set; }
    }
}
