// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> The configuration settings of the Azure Active Directory login flow. </summary>
    public partial class ContainerAppAzureActiveDirectoryLoginConfiguration
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ContainerAppAzureActiveDirectoryLoginConfiguration"/>. </summary>
        public ContainerAppAzureActiveDirectoryLoginConfiguration()
        {
            LoginParameters = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="ContainerAppAzureActiveDirectoryLoginConfiguration"/>. </summary>
        /// <param name="loginParameters">
        /// Login parameters to send to the OpenID Connect authorization endpoint when
        /// a user logs in. Each parameter must be in the form "key=value".
        /// </param>
        /// <param name="isWwwAuthenticationDisabled"> &lt;code&gt;true&lt;/code&gt; if the www-authenticate provider should be omitted from the request; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerAppAzureActiveDirectoryLoginConfiguration(IList<string> loginParameters, bool? isWwwAuthenticationDisabled, Dictionary<string, BinaryData> rawData)
        {
            LoginParameters = loginParameters;
            IsWwwAuthenticationDisabled = isWwwAuthenticationDisabled;
            _rawData = rawData;
        }

        /// <summary>
        /// Login parameters to send to the OpenID Connect authorization endpoint when
        /// a user logs in. Each parameter must be in the form "key=value".
        /// </summary>
        public IList<string> LoginParameters { get; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if the www-authenticate provider should be omitted from the request; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? IsWwwAuthenticationDisabled { get; set; }
    }
}
