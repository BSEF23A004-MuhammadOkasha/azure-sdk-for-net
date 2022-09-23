// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> Details of the service principal. </summary>
    public partial class ServicePrincipalProperties
    {
        /// <summary> Initializes a new instance of ServicePrincipalProperties. </summary>
        public ServicePrincipalProperties()
        {
        }

        /// <summary> Initializes a new instance of ServicePrincipalProperties. </summary>
        /// <param name="applicationId"> Application ID of service principal. </param>
        /// <param name="secret"> A secret string that the application uses to prove its identity, also can be referred to as application password (write only). </param>
        internal ServicePrincipalProperties(string applicationId, string secret)
        {
            ApplicationId = applicationId;
            Secret = secret;
        }

        /// <summary> Application ID of service principal. </summary>
        public string ApplicationId { get; set; }
        /// <summary> A secret string that the application uses to prove its identity, also can be referred to as application password (write only). </summary>
        public string Secret { get; set; }
    }
}
