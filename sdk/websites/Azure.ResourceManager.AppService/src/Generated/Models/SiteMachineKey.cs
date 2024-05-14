// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> MachineKey of an app. </summary>
    public partial class SiteMachineKey
    {
        /// <summary> Initializes a new instance of <see cref="SiteMachineKey"/>. </summary>
        internal SiteMachineKey()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SiteMachineKey"/>. </summary>
        /// <param name="validation"> MachineKey validation. </param>
        /// <param name="validationKey"> Validation key. </param>
        /// <param name="decryption"> Algorithm used for decryption. </param>
        /// <param name="decryptionKey"> Decryption key. </param>
        internal SiteMachineKey(string validation, string validationKey, string decryption, string decryptionKey)
        {
            Validation = validation;
            ValidationKey = validationKey;
            Decryption = decryption;
            DecryptionKey = decryptionKey;
        }

        /// <summary> MachineKey validation. </summary>
        public string Validation { get; }
        /// <summary> Validation key. </summary>
        public string ValidationKey { get; }
        /// <summary> Algorithm used for decryption. </summary>
        public string Decryption { get; }
        /// <summary> Decryption key. </summary>
        public string DecryptionKey { get; }
    }
}
