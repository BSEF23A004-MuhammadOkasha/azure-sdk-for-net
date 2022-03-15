// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> The EncryptionProperty. </summary>
    public partial class EncryptionProperty
    {
        /// <summary> Initializes a new instance of EncryptionProperty. </summary>
        /// <param name="status"> Indicates whether or not the encryption is enabled for the workspace. </param>
        /// <param name="keyVaultProperties"> Customer Key vault properties. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="keyVaultProperties"/> is null. </exception>
        public EncryptionProperty(EncryptionStatus status, EncryptionKeyVaultProperties keyVaultProperties)
        {
            if (keyVaultProperties == null)
            {
                throw new ArgumentNullException(nameof(keyVaultProperties));
            }

            Status = status;
            KeyVaultProperties = keyVaultProperties;
        }

        /// <summary> Initializes a new instance of EncryptionProperty. </summary>
        /// <param name="status"> Indicates whether or not the encryption is enabled for the workspace. </param>
        /// <param name="identity"> The identity that will be used to access the key vault for encryption at rest. </param>
        /// <param name="keyVaultProperties"> Customer Key vault properties. </param>
        internal EncryptionProperty(EncryptionStatus status, IdentityForCmk identity, EncryptionKeyVaultProperties keyVaultProperties)
        {
            Status = status;
            Identity = identity;
            KeyVaultProperties = keyVaultProperties;
        }

        /// <summary> Indicates whether or not the encryption is enabled for the workspace. </summary>
        public EncryptionStatus Status { get; set; }
        /// <summary> The identity that will be used to access the key vault for encryption at rest. </summary>
        internal IdentityForCmk Identity { get; set; }
        /// <summary> The ArmId of the user assigned identity that will be used to access the customer managed key vault. </summary>
        public string UserAssignedIdentity
        {
            get => Identity is null ? default : Identity.UserAssignedIdentity;
            set
            {
                if (Identity is null)
                    Identity = new IdentityForCmk();
                Identity.UserAssignedIdentity = value;
            }
        }

        /// <summary> Customer Key vault properties. </summary>
        public EncryptionKeyVaultProperties KeyVaultProperties { get; set; }
    }
}
