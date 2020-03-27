// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Management.Storage.Models
{
    /// <summary> Properties of the blob container, including Id, resource name, resource type, Etag. </summary>
    public partial class BlobContainer : AzureEntityResource
    {
        /// <summary> Initializes a new instance of BlobContainer. </summary>
        public BlobContainer()
        {
        }

        /// <summary> Initializes a new instance of BlobContainer. </summary>
        /// <param name="defaultEncryptionScope"> Default the container to use specified encryption scope for all writes. </param>
        /// <param name="denyEncryptionScopeOverride"> Block override of encryption scope from the container default. </param>
        /// <param name="publicAccess"> Specifies whether data in the container may be accessed publicly and the level of access. </param>
        /// <param name="lastModifiedTime"> Returns the date and time the container was last modified. </param>
        /// <param name="leaseStatus"> The lease status of the container. </param>
        /// <param name="leaseState"> Lease state of the container. </param>
        /// <param name="leaseDuration"> Specifies whether the lease on a container is of infinite or fixed duration, only when the container is leased. </param>
        /// <param name="metadata"> A name-value pair to associate with the container as metadata. </param>
        /// <param name="immutabilityPolicy"> The ImmutabilityPolicy property of the container. </param>
        /// <param name="legalHold"> The LegalHold property of the container. </param>
        /// <param name="hasLegalHold"> The hasLegalHold public property is set to true by SRP if there are at least one existing tag. The hasLegalHold public property is set to false by SRP if all existing legal hold tags are cleared out. There can be a maximum of 1000 blob containers with hasLegalHold=true for a given account. </param>
        /// <param name="hasImmutabilityPolicy"> The hasImmutabilityPolicy public property is set to true by SRP if ImmutabilityPolicy has been created for this container. The hasImmutabilityPolicy public property is set to false by SRP if ImmutabilityPolicy has not been created for this container. </param>
        /// <param name="etag"> Resource Etag. </param>
        /// <param name="id"> Fully qualified resource Id for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. </param>
        /// <param name="name"> The name of the resource. </param>
        /// <param name="type"> The type of the resource. Ex- Microsoft.Compute/virtualMachines or Microsoft.Storage/storageAccounts. </param>
        internal BlobContainer(string defaultEncryptionScope, bool? denyEncryptionScopeOverride, PublicAccess? publicAccess, DateTimeOffset? lastModifiedTime, LeaseStatus? leaseStatus, LeaseState? leaseState, LeaseDuration? leaseDuration, IDictionary<string, string> metadata, ImmutabilityPolicyProperties immutabilityPolicy, LegalHoldProperties legalHold, bool? hasLegalHold, bool? hasImmutabilityPolicy, string etag, string id, string name, string type) : base(etag, id, name, type)
        {
            DefaultEncryptionScope = defaultEncryptionScope;
            DenyEncryptionScopeOverride = denyEncryptionScopeOverride;
            PublicAccess = publicAccess;
            LastModifiedTime = lastModifiedTime;
            LeaseStatus = leaseStatus;
            LeaseState = leaseState;
            LeaseDuration = leaseDuration;
            Metadata = metadata;
            ImmutabilityPolicy = immutabilityPolicy;
            LegalHold = legalHold;
            HasLegalHold = hasLegalHold;
            HasImmutabilityPolicy = hasImmutabilityPolicy;
        }

        /// <summary> Default the container to use specified encryption scope for all writes. </summary>
        public string DefaultEncryptionScope { get; set; }
        /// <summary> Block override of encryption scope from the container default. </summary>
        public bool? DenyEncryptionScopeOverride { get; set; }
        /// <summary> Specifies whether data in the container may be accessed publicly and the level of access. </summary>
        public PublicAccess? PublicAccess { get; set; }
        /// <summary> Returns the date and time the container was last modified. </summary>
        public DateTimeOffset? LastModifiedTime { get; }
        /// <summary> The lease status of the container. </summary>
        public LeaseStatus? LeaseStatus { get; }
        /// <summary> Lease state of the container. </summary>
        public LeaseState? LeaseState { get; }
        /// <summary> Specifies whether the lease on a container is of infinite or fixed duration, only when the container is leased. </summary>
        public LeaseDuration? LeaseDuration { get; }
        /// <summary> A name-value pair to associate with the container as metadata. </summary>
        public IDictionary<string, string> Metadata { get; set; }
        /// <summary> The ImmutabilityPolicy property of the container. </summary>
        public ImmutabilityPolicyProperties ImmutabilityPolicy { get; }
        /// <summary> The LegalHold property of the container. </summary>
        public LegalHoldProperties LegalHold { get; }
        /// <summary> The hasLegalHold public property is set to true by SRP if there are at least one existing tag. The hasLegalHold public property is set to false by SRP if all existing legal hold tags are cleared out. There can be a maximum of 1000 blob containers with hasLegalHold=true for a given account. </summary>
        public bool? HasLegalHold { get; }
        /// <summary> The hasImmutabilityPolicy public property is set to true by SRP if ImmutabilityPolicy has been created for this container. The hasImmutabilityPolicy public property is set to false by SRP if ImmutabilityPolicy has not been created for this container. </summary>
        public bool? HasImmutabilityPolicy { get; }
    }
}
