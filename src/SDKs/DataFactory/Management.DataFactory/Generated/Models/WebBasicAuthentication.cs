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
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A WebLinkedService that uses basic authentication to communicate with
    /// an HTTP endpoint.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Basic")]
    public partial class WebBasicAuthentication : WebLinkedServiceTypeProperties
    {
        /// <summary>
        /// Initializes a new instance of the WebBasicAuthentication class.
        /// </summary>
        public WebBasicAuthentication()
        {
            Password = new SecureString();
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WebBasicAuthentication class.
        /// </summary>
        /// <param name="url">The URL of the web service endpoint, e.g.
        /// http://www.microsoft.com . Type: string (or Expression with
        /// resultType string).</param>
        /// <param name="username">User name for Basic authentication. Type:
        /// string (or Expression with resultType string).</param>
        /// <param name="password">The password for Basic
        /// authentication.</param>
        public WebBasicAuthentication(object url, object username, SecureString password)
            : base(url)
        {
            Password = new SecureString();
            Username = username;
            Password = password;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets user name for Basic authentication. Type: string (or
        /// Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        public object Username { get; set; }

        /// <summary>
        /// Gets or sets the password for Basic authentication.
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public SecureString Password { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Username == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Username");
            }
            if (Password == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Password");
            }
            if (Password != null)
            {
                Password.Validate();
            }
        }
    }
}
