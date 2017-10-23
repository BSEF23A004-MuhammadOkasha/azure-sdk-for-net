// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DataFactory;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Dynamics linked service.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Dynamics")]
    [Rest.Serialization.JsonTransformation]
    public partial class DynamicsLinkedService : LinkedService
    {
        /// <summary>
        /// Initializes a new instance of the DynamicsLinkedService class.
        /// </summary>
        public DynamicsLinkedService()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DynamicsLinkedService class.
        /// </summary>
        /// <param name="deploymentType">The deployment type of the Dynamics
        /// instance. 'Online' for Dynamics Online and 'OnPremisesWithIfd' for
        /// Dynamics on-premises with Ifd. Type: string (or Expression with
        /// resultType string).</param>
        /// <param name="authenticationType">The authentication type to connect
        /// to Dynamics server. 'Office365' for online scenario, 'Ifd' for
        /// on-premises with Ifd scenario. Type: string (or Expression with
        /// resultType string).</param>
        /// <param name="username">User name to access the Dynamics instance.
        /// Type: string (or Expression with resultType string).</param>
        /// <param name="connectVia">The integration runtime reference.</param>
        /// <param name="description">Linked service description.</param>
        /// <param name="hostName">The host name of the on-premises Dynamics
        /// server. The property is required for on-prem and not allowed for
        /// online. Type: string (or Expression with resultType
        /// string).</param>
        /// <param name="port">The port of on-premises Dynamics server. The
        /// property is required for on-prem and not allowed for online.
        /// Default is 443. Type: integer (or Expression with resultType
        /// integer), minimum: 0.</param>
        /// <param name="organizationName">The organization name of the
        /// Dynamics instance. The property is required for on-prem and
        /// required for online when there are more than one Dynamics instances
        /// associated with the user. Type: string (or Expression with
        /// resultType string).</param>
        /// <param name="password">Password to access the Dynamics
        /// instance.</param>
        /// <param name="encryptedCredential">The encrypted credential used for
        /// authentication. Credentials are encrypted using the integration
        /// runtime credential manager. Type: string (or Expression with
        /// resultType string).</param>
        public DynamicsLinkedService(object deploymentType, object authenticationType, object username, IntegrationRuntimeReference connectVia = default(IntegrationRuntimeReference), string description = default(string), object hostName = default(object), object port = default(object), object organizationName = default(object), SecretBase password = default(SecretBase), object encryptedCredential = default(object))
            : base(connectVia, description)
        {
            DeploymentType = deploymentType;
            HostName = hostName;
            Port = port;
            OrganizationName = organizationName;
            AuthenticationType = authenticationType;
            Username = username;
            Password = password;
            EncryptedCredential = encryptedCredential;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the deployment type of the Dynamics instance. 'Online'
        /// for Dynamics Online and 'OnPremisesWithIfd' for Dynamics
        /// on-premises with Ifd. Type: string (or Expression with resultType
        /// string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.deploymentType")]
        public object DeploymentType { get; set; }

        /// <summary>
        /// Gets or sets the host name of the on-premises Dynamics server. The
        /// property is required for on-prem and not allowed for online. Type:
        /// string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.hostName")]
        public object HostName { get; set; }

        /// <summary>
        /// Gets or sets the port of on-premises Dynamics server. The property
        /// is required for on-prem and not allowed for online. Default is 443.
        /// Type: integer (or Expression with resultType integer), minimum: 0.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.port")]
        public object Port { get; set; }

        /// <summary>
        /// Gets or sets the organization name of the Dynamics instance. The
        /// property is required for on-prem and required for online when there
        /// are more than one Dynamics instances associated with the user.
        /// Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.organizationName")]
        public object OrganizationName { get; set; }

        /// <summary>
        /// Gets or sets the authentication type to connect to Dynamics server.
        /// 'Office365' for online scenario, 'Ifd' for on-premises with Ifd
        /// scenario. Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.authenticationType")]
        public object AuthenticationType { get; set; }

        /// <summary>
        /// Gets or sets user name to access the Dynamics instance. Type:
        /// string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.username")]
        public object Username { get; set; }

        /// <summary>
        /// Gets or sets password to access the Dynamics instance.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.password")]
        public SecretBase Password { get; set; }

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
            if (DeploymentType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DeploymentType");
            }
            if (AuthenticationType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AuthenticationType");
            }
            if (Username == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Username");
            }
        }
    }
}
