// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
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
    /// Linked service for Amazon S3.
    /// </summary>
    [Newtonsoft.Json.JsonObject("AmazonS3")]
    [Rest.Serialization.JsonTransformation]
    public partial class AmazonS3LinkedService : LinkedService
    {
        /// <summary>
        /// Initializes a new instance of the AmazonS3LinkedService class.
        /// </summary>
        public AmazonS3LinkedService()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AmazonS3LinkedService class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="connectVia">The integration runtime reference.</param>
        /// <param name="description">Linked service description.</param>
        /// <param name="parameters">Parameters for linked service.</param>
        /// <param name="annotations">List of tags that can be used for
        /// describing the Dataset.</param>
        /// <param name="accessKeyId">The access key identifier of the Amazon
        /// S3 Identity and Access Management (IAM) user. Type: string (or
        /// Expression with resultType string).</param>
        /// <param name="secretAccessKey">The secret access key of the Amazon
        /// S3 Identity and Access Management (IAM) user.</param>
        /// <param name="encryptedCredential">The encrypted credential used for
        /// authentication. Credentials are encrypted using the integration
        /// runtime credential manager. Type: string (or Expression with
        /// resultType string).</param>
        public AmazonS3LinkedService(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), IntegrationRuntimeReference connectVia = default(IntegrationRuntimeReference), string description = default(string), IDictionary<string, ParameterSpecification> parameters = default(IDictionary<string, ParameterSpecification>), IList<object> annotations = default(IList<object>), object accessKeyId = default(object), SecretBase secretAccessKey = default(SecretBase), object encryptedCredential = default(object))
            : base(additionalProperties, connectVia, description, parameters, annotations)
        {
            AccessKeyId = accessKeyId;
            SecretAccessKey = secretAccessKey;
            EncryptedCredential = encryptedCredential;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the access key identifier of the Amazon S3 Identity
        /// and Access Management (IAM) user. Type: string (or Expression with
        /// resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.accessKeyId")]
        public object AccessKeyId { get; set; }

        /// <summary>
        /// Gets or sets the secret access key of the Amazon S3 Identity and
        /// Access Management (IAM) user.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.secretAccessKey")]
        public SecretBase SecretAccessKey { get; set; }

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
        }
    }
}
