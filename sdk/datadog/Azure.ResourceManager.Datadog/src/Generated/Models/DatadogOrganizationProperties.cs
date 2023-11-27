// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Datadog.Models
{
    /// <summary> Datadog organization properties. </summary>
    public partial class DatadogOrganizationProperties
    {
        /// <summary> Initializes a new instance of <see cref="DatadogOrganizationProperties"/>. </summary>
        public DatadogOrganizationProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DatadogOrganizationProperties"/>. </summary>
        /// <param name="name"> Name of the Datadog organization. </param>
        /// <param name="id"> Id of the Datadog organization. </param>
        /// <param name="linkingAuthCode"> The auth code used to linking to an existing datadog organization. </param>
        /// <param name="linkingClientId"> The client_id from an existing in exchange for an auth token to link organization. </param>
        /// <param name="redirectUri"> The redirect uri for linking. </param>
        /// <param name="apiKey"> Api key associated to the Datadog organization. </param>
        /// <param name="applicationKey"> Application key associated to the Datadog organization. </param>
        /// <param name="enterpriseAppId"> The Id of the Enterprise App used for Single sign on. </param>
        internal DatadogOrganizationProperties(string name, string id, string linkingAuthCode, string linkingClientId, Uri redirectUri, string apiKey, string applicationKey, string enterpriseAppId)
        {
            Name = name;
            Id = id;
            LinkingAuthCode = linkingAuthCode;
            LinkingClientId = linkingClientId;
            RedirectUri = redirectUri;
            ApiKey = apiKey;
            ApplicationKey = applicationKey;
            EnterpriseAppId = enterpriseAppId;
        }

        /// <summary> Name of the Datadog organization. </summary>
        public string Name { get; }
        /// <summary> Id of the Datadog organization. </summary>
        public string Id { get; }
        /// <summary> The auth code used to linking to an existing datadog organization. </summary>
        public string LinkingAuthCode { get; set; }
        /// <summary> The client_id from an existing in exchange for an auth token to link organization. </summary>
        public string LinkingClientId { get; set; }
        /// <summary> The redirect uri for linking. </summary>
        public Uri RedirectUri { get; set; }
        /// <summary> Api key associated to the Datadog organization. </summary>
        public string ApiKey { get; set; }
        /// <summary> Application key associated to the Datadog organization. </summary>
        public string ApplicationKey { get; set; }
        /// <summary> The Id of the Enterprise App used for Single sign on. </summary>
        public string EnterpriseAppId { get; set; }
    }
}
