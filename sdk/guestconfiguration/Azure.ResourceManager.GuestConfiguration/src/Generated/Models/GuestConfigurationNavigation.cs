// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.GuestConfiguration.Models
{
    /// <summary> Guest configuration is an artifact that encapsulates DSC configuration and its dependencies. The artifact is a zip file containing DSC configuration (as MOF) and dependent resources and other dependencies like modules. </summary>
    public partial class GuestConfigurationNavigation
    {
        /// <summary> Initializes a new instance of <see cref="GuestConfigurationNavigation"/>. </summary>
        public GuestConfigurationNavigation()
        {
            ConfigurationParameters = new ChangeTrackingList<GuestConfigurationParameter>();
            ConfigurationProtectedParameters = new ChangeTrackingList<GuestConfigurationParameter>();
        }

        /// <summary> Initializes a new instance of <see cref="GuestConfigurationNavigation"/>. </summary>
        /// <param name="kind"> Kind of the guest configuration. For example:DSC. </param>
        /// <param name="name"> Name of the guest configuration. </param>
        /// <param name="version"> Version of the guest configuration. </param>
        /// <param name="contentUri"> Uri of the storage where guest configuration package is uploaded. </param>
        /// <param name="contentHash"> Combined hash of the guest configuration package and configuration parameters. </param>
        /// <param name="assignmentType"> Specifies the assignment type and execution of the configuration. Possible values are Audit, DeployAndAutoCorrect, ApplyAndAutoCorrect and ApplyAndMonitor. </param>
        /// <param name="assignmentSource"> Specifies the origin of the configuration. </param>
        /// <param name="contentType"> Specifies the content type of the configuration. Possible values could be Builtin or Custom. </param>
        /// <param name="configurationParameters"> The configuration parameters for the guest configuration. </param>
        /// <param name="configurationProtectedParameters"> The protected configuration parameters for the guest configuration. </param>
        /// <param name="configurationSetting"> The configuration setting for the guest configuration. </param>
        internal GuestConfigurationNavigation(GuestConfigurationKind? kind, string name, string version, Uri contentUri, string contentHash, GuestConfigurationAssignmentType? assignmentType, string assignmentSource, string contentType, IList<GuestConfigurationParameter> configurationParameters, IList<GuestConfigurationParameter> configurationProtectedParameters, LcmConfigurationSetting configurationSetting)
        {
            Kind = kind;
            Name = name;
            Version = version;
            ContentUri = contentUri;
            ContentHash = contentHash;
            AssignmentType = assignmentType;
            AssignmentSource = assignmentSource;
            ContentType = contentType;
            ConfigurationParameters = configurationParameters;
            ConfigurationProtectedParameters = configurationProtectedParameters;
            ConfigurationSetting = configurationSetting;
        }

        /// <summary> Kind of the guest configuration. For example:DSC. </summary>
        public GuestConfigurationKind? Kind { get; set; }
        /// <summary> Name of the guest configuration. </summary>
        public string Name { get; set; }
        /// <summary> Version of the guest configuration. </summary>
        public string Version { get; set; }
        /// <summary> Uri of the storage where guest configuration package is uploaded. </summary>
        public Uri ContentUri { get; set; }
        /// <summary> Combined hash of the guest configuration package and configuration parameters. </summary>
        public string ContentHash { get; set; }
        /// <summary> Specifies the assignment type and execution of the configuration. Possible values are Audit, DeployAndAutoCorrect, ApplyAndAutoCorrect and ApplyAndMonitor. </summary>
        public GuestConfigurationAssignmentType? AssignmentType { get; set; }
        /// <summary> Specifies the origin of the configuration. </summary>
        public string AssignmentSource { get; }
        /// <summary> Specifies the content type of the configuration. Possible values could be Builtin or Custom. </summary>
        public string ContentType { get; }
        /// <summary> The configuration parameters for the guest configuration. </summary>
        public IList<GuestConfigurationParameter> ConfigurationParameters { get; }
        /// <summary> The protected configuration parameters for the guest configuration. </summary>
        public IList<GuestConfigurationParameter> ConfigurationProtectedParameters { get; }
        /// <summary> The configuration setting for the guest configuration. </summary>
        public LcmConfigurationSetting ConfigurationSetting { get; }
    }
}
