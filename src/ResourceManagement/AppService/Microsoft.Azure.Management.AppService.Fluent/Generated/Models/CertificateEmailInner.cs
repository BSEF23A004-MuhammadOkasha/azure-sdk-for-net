// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.AppService.Fluent.Models
{
    using System.Linq;

    /// <summary>
    /// SSL certificate email.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class CertificateEmailInner : Microsoft.Azure.Management.ResourceManager.Fluent.Resource
    {
        /// <summary>
        /// Initializes a new instance of the CertificateEmailInner class.
        /// </summary>
        public CertificateEmailInner() { }

        /// <summary>
        /// Initializes a new instance of the CertificateEmailInner class.
        /// </summary>
        /// <param name="emailId">Email id.</param>
        /// <param name="timeStamp">Time stamp.</param>
        public CertificateEmailInner(string location = default(string), string id = default(string), string name = default(string), string type = default(string), System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>), string emailId = default(string), System.DateTime? timeStamp = default(System.DateTime?))
            : base(location, id, name, type, tags)
        {
            EmailId = emailId;
            TimeStamp = timeStamp;
        }

        /// <summary>
        /// Gets or sets email id.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.emailId")]
        public string EmailId { get; set; }

        /// <summary>
        /// Gets or sets time stamp.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.timeStamp")]
        public System.DateTime? TimeStamp { get; set; }

    }
}
