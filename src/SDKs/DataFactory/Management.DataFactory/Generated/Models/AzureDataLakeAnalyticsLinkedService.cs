// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 2.4.36.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Azure Data Lake Analytics linked service.
    /// </summary>
    [Newtonsoft.Json.JsonObject("AzureDataLakeAnalytics")]
    [Rest.Serialization.JsonTransformation]
    public partial class AzureDataLakeAnalyticsLinkedService : LinkedService
    {
        /// <summary>
        /// Initializes a new instance of the
        /// AzureDataLakeAnalyticsLinkedService class.
        /// </summary>
        public AzureDataLakeAnalyticsLinkedService()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// AzureDataLakeAnalyticsLinkedService class.
        /// </summary>
        /// <param name="accountName">The Azure Data Lake Analytics account
        /// name. Type: string (or Expression with resultType string).</param>
        /// <param name="tenant">The name or ID of the tenant to which the
        /// service principal belongs. Type: string (or Expression with
        /// resultType string).</param>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="connectVia">The integration runtime reference.</param>
        /// <param name="description">Linked service description.</param>
        /// <param name="parameters">Parameters for linked service.</param>
        /// <param name="annotations">List of tags that can be used for
        /// describing the Dataset.</param>
        /// <param name="servicePrincipalId">The ID of the application used to
        /// authenticate against the Azure Data Lake Analytics account. Type:
        /// string (or Expression with resultType string).</param>
        /// <param name="servicePrincipalKey">The Key of the application used
        /// to authenticate against the Azure Data Lake Analytics
        /// account.</param>
        /// <param name="subscriptionId">Data Lake Analytics account
        /// subscription ID (if different from Data Factory account). Type:
        /// string (or Expression with resultType string).</param>
        /// <param name="resourceGroupName">Data Lake Analytics account
        /// resource group name (if different from Data Factory account). Type:
        /// string (or Expression with resultType string).</param>
        /// <param name="dataLakeAnalyticsUri">Azure Data Lake Analytics URI
        /// Type: string (or Expression with resultType string).</param>
        /// <param name="encryptedCredential">The encrypted credential used for
        /// authentication. Credentials are encrypted using the integration
        /// runtime credential manager. Type: string (or Expression with
        /// resultType string).</param>
        public AzureDataLakeAnalyticsLinkedService(object accountName, object tenant, IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), IntegrationRuntimeReference connectVia = default(IntegrationRuntimeReference), string description = default(string), IDictionary<string, ParameterSpecification> parameters = default(IDictionary<string, ParameterSpecification>), IList<object> annotations = default(IList<object>), object servicePrincipalId = default(object), SecretBase servicePrincipalKey = default(SecretBase), object subscriptionId = default(object), object resourceGroupName = default(object), object dataLakeAnalyticsUri = default(object), object encryptedCredential = default(object))
            : base(additionalProperties, connectVia, description, parameters, annotations)
        {
            AccountName = accountName;
            ServicePrincipalId = servicePrincipalId;
            ServicePrincipalKey = servicePrincipalKey;
            Tenant = tenant;
            SubscriptionId = subscriptionId;
            ResourceGroupName = resourceGroupName;
            DataLakeAnalyticsUri = dataLakeAnalyticsUri;
            EncryptedCredential = encryptedCredential;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Azure Data Lake Analytics account name. Type:
        /// string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.accountName")]
        public object AccountName { get; set; }

        /// <summary>
        /// Gets or sets the ID of the application used to authenticate against
        /// the Azure Data Lake Analytics account. Type: string (or Expression
        /// with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.servicePrincipalId")]
        public object ServicePrincipalId { get; set; }

        /// <summary>
        /// Gets or sets the Key of the application used to authenticate
        /// against the Azure Data Lake Analytics account.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.servicePrincipalKey")]
        public SecretBase ServicePrincipalKey { get; set; }

        /// <summary>
        /// Gets or sets the name or ID of the tenant to which the service
        /// principal belongs. Type: string (or Expression with resultType
        /// string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.tenant")]
        public object Tenant { get; set; }

        /// <summary>
        /// Gets or sets data Lake Analytics account subscription ID (if
        /// different from Data Factory account). Type: string (or Expression
        /// with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.subscriptionId")]
        public object SubscriptionId { get; set; }

        /// <summary>
        /// Gets or sets data Lake Analytics account resource group name (if
        /// different from Data Factory account). Type: string (or Expression
        /// with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.resourceGroupName")]
        public object ResourceGroupName { get; set; }

        /// <summary>
        /// Gets or sets azure Data Lake Analytics URI Type: string (or
        /// Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.dataLakeAnalyticsUri")]
        public object DataLakeAnalyticsUri { get; set; }

        /// <summary>
        /// Gets or sets the encrypted credential used for authentication.
        /// Credentials are encrypted using the integration runtime credential
        /// manager. Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.encryptedCredential")]
        public object EncryptedCredential { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (AccountName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AccountName");
            }
            if (Tenant == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Tenant");
            }
        }
    }
}
