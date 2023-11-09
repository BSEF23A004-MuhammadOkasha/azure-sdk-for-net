// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RedisEnterprise.Models
{
    /// <summary> All Customer-managed key encryption properties for the resource. Set this to an empty object to use Microsoft-managed key encryption. </summary>
    public partial class RedisEnterpriseCustomerManagedKeyEncryption
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RedisEnterpriseCustomerManagedKeyEncryption"/>. </summary>
        public RedisEnterpriseCustomerManagedKeyEncryption()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RedisEnterpriseCustomerManagedKeyEncryption"/>. </summary>
        /// <param name="keyEncryptionKeyIdentity"> All identity configuration for Customer-managed key settings defining which identity should be used to auth to Key Vault. </param>
        /// <param name="keyEncryptionKeyUri"> Key encryption key Url, versioned only. Ex: https://contosovault.vault.azure.net/keys/contosokek/562a4bb76b524a1493a6afe8e536ee78. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RedisEnterpriseCustomerManagedKeyEncryption(RedisEnterpriseCustomerManagedKeyEncryptionKeyIdentity keyEncryptionKeyIdentity, Uri keyEncryptionKeyUri, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            KeyEncryptionKeyIdentity = keyEncryptionKeyIdentity;
            KeyEncryptionKeyUri = keyEncryptionKeyUri;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> All identity configuration for Customer-managed key settings defining which identity should be used to auth to Key Vault. </summary>
        public RedisEnterpriseCustomerManagedKeyEncryptionKeyIdentity KeyEncryptionKeyIdentity { get; set; }
        /// <summary> Key encryption key Url, versioned only. Ex: https://contosovault.vault.azure.net/keys/contosokek/562a4bb76b524a1493a6afe8e536ee78. </summary>
        public Uri KeyEncryptionKeyUri { get; set; }
    }
}
