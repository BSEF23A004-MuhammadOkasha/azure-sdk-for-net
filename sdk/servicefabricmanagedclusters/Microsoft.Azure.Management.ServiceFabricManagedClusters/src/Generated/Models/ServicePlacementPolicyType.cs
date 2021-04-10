// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ServiceFabricManagedClusters.Models
{

    /// <summary>
    /// Defines values for ServicePlacementPolicyType.
    /// </summary>
    public static class ServicePlacementPolicyType
    {
        /// <summary>
        /// Indicates that the ServicePlacementPolicyDescription is of type
        /// ServicePlacementInvalidDomainPolicyDescription, which indicates
        /// that a particular fault or upgrade domain cannot be used for
        /// placement of this service. The value is 0.
        /// </summary>
        public const string InvalidDomain = "InvalidDomain";
        /// <summary>
        /// Indicates that the ServicePlacementPolicyDescription is of type
        /// ServicePlacementRequireDomainDistributionPolicyDescription
        /// indicating that the replicas of the service must be placed in a
        /// specific domain. The value is 1.
        /// </summary>
        public const string RequiredDomain = "RequiredDomain";
        /// <summary>
        /// Indicates that the ServicePlacementPolicyDescription is of type
        /// ServicePlacementPreferPrimaryDomainPolicyDescription, which
        /// indicates that if possible the Primary replica for the partitions
        /// of the service should be located in a particular domain as an
        /// optimization. The value is 2.
        /// </summary>
        public const string PreferredPrimaryDomain = "PreferredPrimaryDomain";
        /// <summary>
        /// Indicates that the ServicePlacementPolicyDescription is of type
        /// ServicePlacementRequireDomainDistributionPolicyDescription,
        /// indicating that the system will disallow placement of any two
        /// replicas from the same partition in the same domain at any time.
        /// The value is 3.
        /// </summary>
        public const string RequiredDomainDistribution = "RequiredDomainDistribution";
        /// <summary>
        /// Indicates that the ServicePlacementPolicyDescription is of type
        /// ServicePlacementNonPartiallyPlaceServicePolicyDescription, which
        /// indicates that if possible all replicas of a particular partition
        /// of the service should be placed atomically. The value is 4.
        /// </summary>
        public const string NonPartiallyPlaceService = "NonPartiallyPlaceService";
    }
}
