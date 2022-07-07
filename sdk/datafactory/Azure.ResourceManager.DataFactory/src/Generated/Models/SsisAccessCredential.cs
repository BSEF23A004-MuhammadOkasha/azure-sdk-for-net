// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> SSIS access credential. </summary>
    public partial class SsisAccessCredential
    {
        /// <summary> Initializes a new instance of SsisAccessCredential. </summary>
        /// <param name="domain"> Domain for windows authentication. </param>
        /// <param name="userName"> UseName for windows authentication. </param>
        /// <param name="password">
        /// Password for windows authentication.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SecureString"/> and <see cref="AzureKeyVaultSecretReference"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="domain"/>, <paramref name="userName"/> or <paramref name="password"/> is null. </exception>
        public SsisAccessCredential(BinaryData domain, BinaryData userName, SecretBase password)
        {
            if (domain == null)
            {
                throw new ArgumentNullException(nameof(domain));
            }
            if (userName == null)
            {
                throw new ArgumentNullException(nameof(userName));
            }
            if (password == null)
            {
                throw new ArgumentNullException(nameof(password));
            }

            Domain = domain;
            UserName = userName;
            Password = password;
        }

        /// <summary> Domain for windows authentication. </summary>
        public BinaryData Domain { get; set; }
        /// <summary> UseName for windows authentication. </summary>
        public BinaryData UserName { get; set; }
        /// <summary>
        /// Password for windows authentication.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SecureString"/> and <see cref="AzureKeyVaultSecretReference"/>.
        /// </summary>
        public SecretBase Password { get; set; }
    }
}
