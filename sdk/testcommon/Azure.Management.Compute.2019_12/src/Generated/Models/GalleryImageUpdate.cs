// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Management.Compute.Models
{
    /// <summary> Specifies information about the gallery Image Definition that you want to update. </summary>
    public partial class GalleryImageUpdate : UpdateResourceDefinition
    {
        /// <summary> Initializes a new instance of GalleryImageUpdate. </summary>
        public GalleryImageUpdate()
        {
        }

        /// <summary> Initializes a new instance of GalleryImageUpdate. </summary>
        /// <param name="id"> Resource Id. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="description"> The description of this gallery Image Definition resource. This property is updatable. </param>
        /// <param name="eula"> The Eula agreement for the gallery Image Definition. </param>
        /// <param name="privacyStatementUri"> The privacy statement uri. </param>
        /// <param name="releaseNoteUri"> The release note uri. </param>
        /// <param name="osType"> This property allows you to specify the type of the OS that is included in the disk when creating a VM from a managed image. &lt;br&gt;&lt;br&gt; Possible values are: &lt;br&gt;&lt;br&gt; **Windows** &lt;br&gt;&lt;br&gt; **Linux**. </param>
        /// <param name="osState"> This property allows the user to specify whether the virtual machines created under this image are &apos;Generalized&apos; or &apos;Specialized&apos;. </param>
        /// <param name="hyperVGeneration"> The hypervisor generation of the Virtual Machine. Applicable to OS disks only. </param>
        /// <param name="endOfLifeDate"> The end of life date of the gallery Image Definition. This property can be used for decommissioning purposes. This property is updatable. </param>
        /// <param name="identifier"> This is the gallery Image Definition identifier. </param>
        /// <param name="recommended"> The properties describe the recommended machine configuration for this Image Definition. These properties are updatable. </param>
        /// <param name="disallowed"> Describes the disallowed disk types. </param>
        /// <param name="purchasePlan"> Describes the gallery Image Definition purchase plan. This is used by marketplace images. </param>
        /// <param name="provisioningState"> The provisioning state, which only appears in the response. </param>
        internal GalleryImageUpdate(string id, string name, string type, IDictionary<string, string> tags, string description, string eula, string privacyStatementUri, string releaseNoteUri, OperatingSystemTypes? osType, OperatingSystemStateTypes? osState, HyperVGeneration? hyperVGeneration, DateTimeOffset? endOfLifeDate, GalleryImageIdentifier identifier, RecommendedMachineConfiguration recommended, Disallowed disallowed, ImagePurchasePlan purchasePlan, GalleryImagePropertiesProvisioningState? provisioningState) : base(id, name, type, tags)
        {
            Description = description;
            Eula = eula;
            PrivacyStatementUri = privacyStatementUri;
            ReleaseNoteUri = releaseNoteUri;
            OsType = osType;
            OsState = osState;
            HyperVGeneration = hyperVGeneration;
            EndOfLifeDate = endOfLifeDate;
            Identifier = identifier;
            Recommended = recommended;
            Disallowed = disallowed;
            PurchasePlan = purchasePlan;
            ProvisioningState = provisioningState;
        }

        /// <summary> The description of this gallery Image Definition resource. This property is updatable. </summary>
        public string Description { get; set; }
        /// <summary> The Eula agreement for the gallery Image Definition. </summary>
        public string Eula { get; set; }
        /// <summary> The privacy statement uri. </summary>
        public string PrivacyStatementUri { get; set; }
        /// <summary> The release note uri. </summary>
        public string ReleaseNoteUri { get; set; }
        /// <summary> This property allows you to specify the type of the OS that is included in the disk when creating a VM from a managed image. &lt;br&gt;&lt;br&gt; Possible values are: &lt;br&gt;&lt;br&gt; **Windows** &lt;br&gt;&lt;br&gt; **Linux**. </summary>
        public OperatingSystemTypes? OsType { get; set; }
        /// <summary> This property allows the user to specify whether the virtual machines created under this image are &apos;Generalized&apos; or &apos;Specialized&apos;. </summary>
        public OperatingSystemStateTypes? OsState { get; set; }
        /// <summary> The hypervisor generation of the Virtual Machine. Applicable to OS disks only. </summary>
        public HyperVGeneration? HyperVGeneration { get; set; }
        /// <summary> The end of life date of the gallery Image Definition. This property can be used for decommissioning purposes. This property is updatable. </summary>
        public DateTimeOffset? EndOfLifeDate { get; set; }
        /// <summary> This is the gallery Image Definition identifier. </summary>
        public GalleryImageIdentifier Identifier { get; set; }
        /// <summary> The properties describe the recommended machine configuration for this Image Definition. These properties are updatable. </summary>
        public RecommendedMachineConfiguration Recommended { get; set; }
        /// <summary> Describes the disallowed disk types. </summary>
        public Disallowed Disallowed { get; set; }
        /// <summary> Describes the gallery Image Definition purchase plan. This is used by marketplace images. </summary>
        public ImagePurchasePlan PurchasePlan { get; set; }
        /// <summary> The provisioning state, which only appears in the response. </summary>
        public GalleryImagePropertiesProvisioningState? ProvisioningState { get; }
    }
}
