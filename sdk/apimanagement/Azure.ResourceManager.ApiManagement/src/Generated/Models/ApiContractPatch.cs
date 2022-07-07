// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> API update contract details. </summary>
    public partial class ApiContractPatch
    {
        /// <summary> Initializes a new instance of ApiContractPatch. </summary>
        public ApiContractPatch()
        {
            Protocols = new ChangeTrackingList<Protocol>();
        }

        /// <summary> Description of the API. May include HTML formatting tags. </summary>
        public string Description { get; set; }
        /// <summary> Collection of authentication settings included into this API. </summary>
        public AuthenticationSettingsContract AuthenticationSettings { get; set; }
        /// <summary> Protocols over which API is made available. </summary>
        public SubscriptionKeyParameterNamesContract SubscriptionKeyParameterNames { get; set; }
        /// <summary> Type of API. </summary>
        public ApiType? ApiType { get; set; }
        /// <summary> Describes the revision of the API. If no value is provided, default revision 1 is created. </summary>
        public string ApiRevision { get; set; }
        /// <summary> Indicates the version identifier of the API if the API is versioned. </summary>
        public string ApiVersion { get; set; }
        /// <summary> Indicates if API revision is current api revision. </summary>
        public bool? IsCurrent { get; set; }
        /// <summary> Indicates if API revision is accessible via the gateway. </summary>
        public bool? IsOnline { get; }
        /// <summary> Description of the API Revision. </summary>
        public string ApiRevisionDescription { get; set; }
        /// <summary> Description of the API Version. </summary>
        public string ApiVersionDescription { get; set; }
        /// <summary> A resource identifier for the related ApiVersionSet. </summary>
        public string ApiVersionSetId { get; set; }
        /// <summary> Specifies whether an API or Product subscription is required for accessing the API. </summary>
        public bool? SubscriptionRequired { get; set; }
        /// <summary> A URL to the Terms of Service for the API. MUST be in the format of a URL. </summary>
        public Uri TermsOfServiceUri { get; set; }
        /// <summary> Contact information for the API. </summary>
        public ApiContactInformation Contact { get; set; }
        /// <summary> License information for the API. </summary>
        public ApiLicenseInformation License { get; set; }
        /// <summary> API name. </summary>
        public string DisplayName { get; set; }
        /// <summary> Absolute URL of the backend service implementing this API. </summary>
        public Uri ServiceUri { get; set; }
        /// <summary> Relative URL uniquely identifying this API and all of its resource paths within the API Management service instance. It is appended to the API endpoint base URL specified during the service instance creation to form a public URL for this API. </summary>
        public string Path { get; set; }
        /// <summary> Describes on which protocols the operations in this API can be invoked. </summary>
        public IList<Protocol> Protocols { get; }
    }
}
