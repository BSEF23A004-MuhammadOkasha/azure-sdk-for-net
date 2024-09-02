// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Credential for user managed identity. </summary>
    public partial class ManagedIdentityCredential : DataReferenceCredential
    {
        /// <summary> Initializes a new instance of <see cref="ManagedIdentityCredential"/>. </summary>
        internal ManagedIdentityCredential()
        {
            CredentialType = DataReferenceCredentialType.ManagedIdentity;
        }

        /// <summary> Initializes a new instance of <see cref="ManagedIdentityCredential"/>. </summary>
        /// <param name="credentialType"> [Required] Credential type used to authentication with storage. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="managedIdentityType"> ManagedIdentityCredential identity type. </param>
<<<<<<< HEAD
        /// <param name="userManagedIdentityResourceId"> Full arm scope for the Id. For ManagedIdentityType = SystemManaged, this field is null. </param>
        /// <param name="userManagedIdentityClientId"> ClientId for the UAMI. For ManagedIdentityType = SystemManaged, this field is null. </param>
        /// <param name="userManagedIdentityPrincipalId"> PrincipalId for the UAMI. For ManagedIdentityType = SystemManaged, this field is null. </param>
        /// <param name="userManagedIdentityTenantId"> TenantId for the UAMI. For ManagedIdentityType = SystemManaged, this field is null. </param>
        internal ManagedIdentityCredential(DataReferenceCredentialType credentialType, IDictionary<string, BinaryData> serializedAdditionalRawData, string managedIdentityType, string userManagedIdentityResourceId, string userManagedIdentityClientId, string userManagedIdentityPrincipalId, string userManagedIdentityTenantId) : base(credentialType, serializedAdditionalRawData)
        {
            ManagedIdentityType = managedIdentityType;
            UserManagedIdentityResourceId = userManagedIdentityResourceId;
            UserManagedIdentityClientId = userManagedIdentityClientId;
            UserManagedIdentityPrincipalId = userManagedIdentityPrincipalId;
=======
        /// <param name="userManagedIdentityClientId"> ClientId for the UAMI. For ManagedIdentityType = SystemManaged, this field is null. </param>
        /// <param name="userManagedIdentityPrincipalId"> PrincipalId for the UAMI. For ManagedIdentityType = SystemManaged, this field is null. </param>
        /// <param name="userManagedIdentityResourceId"> Full arm scope for the Id. For ManagedIdentityType = SystemManaged, this field is null. </param>
        /// <param name="userManagedIdentityTenantId"> TenantId for the UAMI. For ManagedIdentityType = SystemManaged, this field is null. </param>
        internal ManagedIdentityCredential(DataReferenceCredentialType credentialType, IDictionary<string, BinaryData> serializedAdditionalRawData, string managedIdentityType, string userManagedIdentityClientId, string userManagedIdentityPrincipalId, string userManagedIdentityResourceId, string userManagedIdentityTenantId) : base(credentialType, serializedAdditionalRawData)
        {
            ManagedIdentityType = managedIdentityType;
            UserManagedIdentityClientId = userManagedIdentityClientId;
            UserManagedIdentityPrincipalId = userManagedIdentityPrincipalId;
            UserManagedIdentityResourceId = userManagedIdentityResourceId;
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
            UserManagedIdentityTenantId = userManagedIdentityTenantId;
            CredentialType = credentialType;
        }

        /// <summary> ManagedIdentityCredential identity type. </summary>
        public string ManagedIdentityType { get; }
<<<<<<< HEAD
        /// <summary> Full arm scope for the Id. For ManagedIdentityType = SystemManaged, this field is null. </summary>
        public string UserManagedIdentityResourceId { get; }
=======
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
        /// <summary> ClientId for the UAMI. For ManagedIdentityType = SystemManaged, this field is null. </summary>
        public string UserManagedIdentityClientId { get; }
        /// <summary> PrincipalId for the UAMI. For ManagedIdentityType = SystemManaged, this field is null. </summary>
        public string UserManagedIdentityPrincipalId { get; }
<<<<<<< HEAD
=======
        /// <summary> Full arm scope for the Id. For ManagedIdentityType = SystemManaged, this field is null. </summary>
        public string UserManagedIdentityResourceId { get; }
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
        /// <summary> TenantId for the UAMI. For ManagedIdentityType = SystemManaged, this field is null. </summary>
        public string UserManagedIdentityTenantId { get; }
    }
}
