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
    /// Hadoop Distributed File System (HDFS) linked service.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Hdfs")]
    [Rest.Serialization.JsonTransformation]
    public partial class HdfsLinkedService : LinkedService
    {
        /// <summary>
        /// Initializes a new instance of the HdfsLinkedService class.
        /// </summary>
        public HdfsLinkedService()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HdfsLinkedService class.
        /// </summary>
        /// <param name="url">The URL of the HDFS service endpoint, e.g.
        /// http://myhostname:50070/webhdfs/v1 . Type: string (or Expression
        /// with resultType string).</param>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="connectVia">The integration runtime reference.</param>
        /// <param name="description">Linked service description.</param>
        /// <param name="parameters">Parameters for linked service.</param>
        /// <param name="annotations">List of tags that can be used for
        /// describing the Dataset.</param>
        /// <param name="authenticationType">Type of authentication used to
        /// connect to the HDFS. Possible values are: Anonymous and Windows.
        /// Type: string (or Expression with resultType string).</param>
        /// <param name="encryptedCredential">The encrypted credential used for
        /// authentication. Credentials are encrypted using the integration
        /// runtime credential manager. Type: string (or Expression with
        /// resultType string).</param>
        /// <param name="userName">User name for Windows authentication. Type:
        /// string (or Expression with resultType string).</param>
        /// <param name="password">Password for Windows authentication.</param>
        public HdfsLinkedService(object url, IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), IntegrationRuntimeReference connectVia = default(IntegrationRuntimeReference), string description = default(string), IDictionary<string, ParameterSpecification> parameters = default(IDictionary<string, ParameterSpecification>), IList<object> annotations = default(IList<object>), object authenticationType = default(object), object encryptedCredential = default(object), object userName = default(object), SecretBase password = default(SecretBase))
            : base(additionalProperties, connectVia, description, parameters, annotations)
        {
            Url = url;
            AuthenticationType = authenticationType;
            EncryptedCredential = encryptedCredential;
            UserName = userName;
            Password = password;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the URL of the HDFS service endpoint, e.g.
        /// http://myhostname:50070/webhdfs/v1 . Type: string (or Expression
        /// with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.url")]
        public object Url { get; set; }

        /// <summary>
        /// Gets or sets type of authentication used to connect to the HDFS.
        /// Possible values are: Anonymous and Windows. Type: string (or
        /// Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.authenticationType")]
        public object AuthenticationType { get; set; }

        /// <summary>
        /// Gets or sets the encrypted credential used for authentication.
        /// Credentials are encrypted using the integration runtime credential
        /// manager. Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.encryptedCredential")]
        public object EncryptedCredential { get; set; }

        /// <summary>
        /// Gets or sets user name for Windows authentication. Type: string (or
        /// Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.userName")]
        public object UserName { get; set; }

        /// <summary>
        /// Gets or sets password for Windows authentication.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.password")]
        public SecretBase Password { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Url == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Url");
            }
        }
    }
}
