// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The RegistryListCredentialsResult. </summary>
    public partial class RegistryListCredentialsResult
    {
        /// <summary> Initializes a new instance of RegistryListCredentialsResult. </summary>
        internal RegistryListCredentialsResult()
        {
            Passwords = new ChangeTrackingList<PasswordDetail>();
        }

        /// <summary> Initializes a new instance of RegistryListCredentialsResult. </summary>
        /// <param name="location"></param>
        /// <param name="username"></param>
        /// <param name="passwords"></param>
        internal RegistryListCredentialsResult(string location, string username, IReadOnlyList<PasswordDetail> passwords)
        {
            Location = location;
            Username = username;
            Passwords = passwords;
        }

        /// <summary> Gets the location. </summary>
        public string Location { get; }
        /// <summary> Gets the username. </summary>
        public string Username { get; }
        /// <summary> Gets the passwords. </summary>
        public IReadOnlyList<PasswordDetail> Passwords { get; }
    }
}
