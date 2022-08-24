// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary>
    /// The routes that specify the endpoints used for login and logout requests.
    /// Serialized Name: LoginRoutes
    /// </summary>
    internal partial class LoginRoutes
    {
        /// <summary> Initializes a new instance of LoginRoutes. </summary>
        public LoginRoutes()
        {
        }

        /// <summary> Initializes a new instance of LoginRoutes. </summary>
        /// <param name="logoutEndpoint">
        /// The endpoint at which a logout request should be made.
        /// Serialized Name: LoginRoutes.logoutEndpoint
        /// </param>
        internal LoginRoutes(string logoutEndpoint)
        {
            LogoutEndpoint = logoutEndpoint;
        }

        /// <summary>
        /// The endpoint at which a logout request should be made.
        /// Serialized Name: LoginRoutes.logoutEndpoint
        /// </summary>
        public string LogoutEndpoint { get; set; }
    }
}
