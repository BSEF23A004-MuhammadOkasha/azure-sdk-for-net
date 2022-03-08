// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DesktopVirtualization.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DesktopVirtualization
{
    /// <summary> A class representing the HostPool data model. </summary>
    public partial class HostPoolData : ResourceModelWithAllowedPropertySet
    {
        /// <summary> Initializes a new instance of HostPoolData. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="hostPoolType"> HostPool type for desktop. </param>
        /// <param name="loadBalancerType"> The type of the load balancer. </param>
        /// <param name="preferredAppGroupType"> The type of preferred application group type, default to Desktop Application Group. </param>
        public HostPoolData(AzureLocation location, HostPoolType hostPoolType, LoadBalancerType loadBalancerType, PreferredAppGroupType preferredAppGroupType) : base(location)
        {
            HostPoolType = hostPoolType;
            LoadBalancerType = loadBalancerType;
            ApplicationGroupReferences = new ChangeTrackingList<string>();
            PreferredAppGroupType = preferredAppGroupType;
        }

        /// <summary> Initializes a new instance of HostPoolData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="managedBy"> The fully qualified resource ID of the resource that manages this resource. Indicates if this resource is managed by another Azure resource. If this is present, complete mode deployment will not delete the resource if it is removed from the template since it is managed by another resource. </param>
        /// <param name="kind"> Metadata used by portal/tooling/etc to render different UX experiences for resources of the same type; e.g. ApiApps are a kind of Microsoft.Web/sites type.  If supported, the resource provider must validate and persist this value. </param>
        /// <param name="etag"> The etag field is *not* required. If it is provided in the response body, it must also be provided as a header per the normal etag convention.  Entity tags are used for comparing two or more entities from the same requested resource. HTTP/1.1 uses entity tags in the etag (section 14.19), If-Match (section 14.24), If-None-Match (section 14.26), and If-Range (section 14.27) header fields. </param>
        /// <param name="identity"></param>
        /// <param name="sku"></param>
        /// <param name="plan"></param>
        /// <param name="objectId"> ObjectId of HostPool. (internal use). </param>
        /// <param name="friendlyName"> Friendly name of HostPool. </param>
        /// <param name="description"> Description of HostPool. </param>
        /// <param name="hostPoolType"> HostPool type for desktop. </param>
        /// <param name="personalDesktopAssignmentType"> PersonalDesktopAssignment type for HostPool. </param>
        /// <param name="customRdpProperty"> Custom rdp property of HostPool. </param>
        /// <param name="maxSessionLimit"> The max session limit of HostPool. </param>
        /// <param name="loadBalancerType"> The type of the load balancer. </param>
        /// <param name="ring"> The ring number of HostPool. </param>
        /// <param name="validationEnvironment"> Is validation environment. </param>
        /// <param name="registrationInfo"> The registration info of HostPool. </param>
        /// <param name="vmTemplate"> VM template for sessionhosts configuration within hostpool. </param>
        /// <param name="applicationGroupReferences"> List of applicationGroup links. </param>
        /// <param name="ssoadfsAuthority"> URL to customer ADFS server for signing WVD SSO certificates. </param>
        /// <param name="ssoClientId"> ClientId for the registered Relying Party used to issue WVD SSO certificates. </param>
        /// <param name="ssoClientSecretKeyVaultPath"> Path to Azure KeyVault storing the secret used for communication to ADFS. </param>
        /// <param name="ssoSecretType"> The type of single sign on Secret Type. </param>
        /// <param name="preferredAppGroupType"> The type of preferred application group type, default to Desktop Application Group. </param>
        /// <param name="startVmOnConnect"> The flag to turn on/off StartVMOnConnect feature. </param>
        /// <param name="migrationRequest"> The registration info of HostPool. </param>
        /// <param name="cloudPcResource"> Is cloud pc resource. </param>
        internal HostPoolData(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string managedBy, string kind, string etag, SystemAssignedServiceIdentity identity, ResourceModelWithAllowedPropertySetSku sku, Plan plan, string objectId, string friendlyName, string description, HostPoolType hostPoolType, PersonalDesktopAssignmentType? personalDesktopAssignmentType, string customRdpProperty, int? maxSessionLimit, LoadBalancerType loadBalancerType, int? ring, bool? validationEnvironment, RegistrationInfo registrationInfo, string vmTemplate, IReadOnlyList<string> applicationGroupReferences, string ssoadfsAuthority, string ssoClientId, string ssoClientSecretKeyVaultPath, SsoSecretType? ssoSecretType, PreferredAppGroupType preferredAppGroupType, bool? startVmOnConnect, MigrationRequestProperties migrationRequest, bool? cloudPcResource) : base(id, name, type, systemData, tags, location, managedBy, kind, etag, identity, sku, plan)
        {
            ObjectId = objectId;
            FriendlyName = friendlyName;
            Description = description;
            HostPoolType = hostPoolType;
            PersonalDesktopAssignmentType = personalDesktopAssignmentType;
            CustomRdpProperty = customRdpProperty;
            MaxSessionLimit = maxSessionLimit;
            LoadBalancerType = loadBalancerType;
            Ring = ring;
            ValidationEnvironment = validationEnvironment;
            RegistrationInfo = registrationInfo;
            VmTemplate = vmTemplate;
            ApplicationGroupReferences = applicationGroupReferences;
            SsoadfsAuthority = ssoadfsAuthority;
            SsoClientId = ssoClientId;
            SsoClientSecretKeyVaultPath = ssoClientSecretKeyVaultPath;
            SsoSecretType = ssoSecretType;
            PreferredAppGroupType = preferredAppGroupType;
            StartVmOnConnect = startVmOnConnect;
            MigrationRequest = migrationRequest;
            CloudPcResource = cloudPcResource;
        }

        /// <summary> ObjectId of HostPool. (internal use). </summary>
        public string ObjectId { get; }
        /// <summary> Friendly name of HostPool. </summary>
        public string FriendlyName { get; set; }
        /// <summary> Description of HostPool. </summary>
        public string Description { get; set; }
        /// <summary> HostPool type for desktop. </summary>
        public HostPoolType HostPoolType { get; set; }
        /// <summary> PersonalDesktopAssignment type for HostPool. </summary>
        public PersonalDesktopAssignmentType? PersonalDesktopAssignmentType { get; set; }
        /// <summary> Custom rdp property of HostPool. </summary>
        public string CustomRdpProperty { get; set; }
        /// <summary> The max session limit of HostPool. </summary>
        public int? MaxSessionLimit { get; set; }
        /// <summary> The type of the load balancer. </summary>
        public LoadBalancerType LoadBalancerType { get; set; }
        /// <summary> The ring number of HostPool. </summary>
        public int? Ring { get; set; }
        /// <summary> Is validation environment. </summary>
        public bool? ValidationEnvironment { get; set; }
        /// <summary> The registration info of HostPool. </summary>
        public RegistrationInfo RegistrationInfo { get; set; }
        /// <summary> VM template for sessionhosts configuration within hostpool. </summary>
        public string VmTemplate { get; set; }
        /// <summary> List of applicationGroup links. </summary>
        public IReadOnlyList<string> ApplicationGroupReferences { get; }
        /// <summary> URL to customer ADFS server for signing WVD SSO certificates. </summary>
        public string SsoadfsAuthority { get; set; }
        /// <summary> ClientId for the registered Relying Party used to issue WVD SSO certificates. </summary>
        public string SsoClientId { get; set; }
        /// <summary> Path to Azure KeyVault storing the secret used for communication to ADFS. </summary>
        public string SsoClientSecretKeyVaultPath { get; set; }
        /// <summary> The type of single sign on Secret Type. </summary>
        public SsoSecretType? SsoSecretType { get; set; }
        /// <summary> The type of preferred application group type, default to Desktop Application Group. </summary>
        public PreferredAppGroupType PreferredAppGroupType { get; set; }
        /// <summary> The flag to turn on/off StartVMOnConnect feature. </summary>
        public bool? StartVmOnConnect { get; set; }
        /// <summary> The registration info of HostPool. </summary>
        public MigrationRequestProperties MigrationRequest { get; set; }
        /// <summary> Is cloud pc resource. </summary>
        public bool? CloudPcResource { get; }
    }
}
