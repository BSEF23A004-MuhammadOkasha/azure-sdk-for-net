// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.VoiceServices.Models;

namespace Azure.ResourceManager.VoiceServices
{
    /// <summary>
    /// A class representing the VoiceServicesCommunicationsGateway data model.
    /// A CommunicationsGateway resource
    /// </summary>
    public partial class VoiceServicesCommunicationsGatewayData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of <see cref="VoiceServicesCommunicationsGatewayData"/>. </summary>
        /// <param name="location"> The location. </param>
        public VoiceServicesCommunicationsGatewayData(AzureLocation location) : base(location)
        {
            ServiceLocations = new ChangeTrackingList<VoiceServicesServiceRegionProperties>();
            Codecs = new ChangeTrackingList<VoiceServicesTeamsCodec>();
            Platforms = new ChangeTrackingList<VoiceServicesCommunicationsPlatform>();
            EmergencyDialStrings = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="VoiceServicesCommunicationsGatewayData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="provisioningState"> Resource provisioning state. </param>
        /// <param name="status"> The current status of the deployment. </param>
        /// <param name="serviceLocations"> The regions in which to deploy the resources needed for Teams Calling. </param>
        /// <param name="connectivity"> How to connect back to the operator network, e.g. MAPS. </param>
        /// <param name="codecs"> Voice codecs to support. </param>
        /// <param name="e911Type"> How to handle 911 calls. </param>
        /// <param name="platforms"> What platforms to support. </param>
        /// <param name="apiBridge"> Details of API bridge functionality, if required. </param>
        /// <param name="autoGeneratedDomainNameLabelScope"> The scope at which the auto-generated domain name can be re-used. </param>
        /// <param name="autoGeneratedDomainNameLabel"> The autogenerated label used as part of the FQDNs for accessing the Communications Gateway. </param>
        /// <param name="teamsVoicemailPilotNumber"> This number is used in Teams Phone Mobile scenarios for access to the voicemail IVR from the native dialer. </param>
        /// <param name="isOnPremMcpEnabled"> Whether an on-premises Mobile Control Point is in use. </param>
        /// <param name="emergencyDialStrings"> A list of dial strings used for emergency calling. </param>
        internal VoiceServicesCommunicationsGatewayData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, VoiceServicesProvisioningState? provisioningState, VoiceServicesCommunicationsGatewayStatus? status, IList<VoiceServicesServiceRegionProperties> serviceLocations, VoiceServicesCommunicationsGatewayConnectivity? connectivity, IList<VoiceServicesTeamsCodec> codecs, VoiceServicesEmergencyCallType? e911Type, IList<VoiceServicesCommunicationsPlatform> platforms, BinaryData apiBridge, VoiceServicesAutoGeneratedDomainNameLabelScope? autoGeneratedDomainNameLabelScope, string autoGeneratedDomainNameLabel, string teamsVoicemailPilotNumber, bool? isOnPremMcpEnabled, IList<string> emergencyDialStrings) : base(id, name, resourceType, systemData, tags, location)
        {
            ProvisioningState = provisioningState;
            Status = status;
            ServiceLocations = serviceLocations;
            Connectivity = connectivity;
            Codecs = codecs;
            E911Type = e911Type;
            Platforms = platforms;
            ApiBridge = apiBridge;
            AutoGeneratedDomainNameLabelScope = autoGeneratedDomainNameLabelScope;
            AutoGeneratedDomainNameLabel = autoGeneratedDomainNameLabel;
            TeamsVoicemailPilotNumber = teamsVoicemailPilotNumber;
            IsOnPremMcpEnabled = isOnPremMcpEnabled;
            EmergencyDialStrings = emergencyDialStrings;
        }

        /// <summary> Resource provisioning state. </summary>
        public VoiceServicesProvisioningState? ProvisioningState { get; }
        /// <summary> The current status of the deployment. </summary>
        public VoiceServicesCommunicationsGatewayStatus? Status { get; }
        /// <summary> The regions in which to deploy the resources needed for Teams Calling. </summary>
        public IList<VoiceServicesServiceRegionProperties> ServiceLocations { get; }
        /// <summary> How to connect back to the operator network, e.g. MAPS. </summary>
        public VoiceServicesCommunicationsGatewayConnectivity? Connectivity { get; set; }
        /// <summary> Voice codecs to support. </summary>
        public IList<VoiceServicesTeamsCodec> Codecs { get; }
        /// <summary> How to handle 911 calls. </summary>
        public VoiceServicesEmergencyCallType? E911Type { get; set; }
        /// <summary> What platforms to support. </summary>
        public IList<VoiceServicesCommunicationsPlatform> Platforms { get; }
        /// <summary>
        /// Details of API bridge functionality, if required
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData ApiBridge { get; set; }
        /// <summary> The scope at which the auto-generated domain name can be re-used. </summary>
        public VoiceServicesAutoGeneratedDomainNameLabelScope? AutoGeneratedDomainNameLabelScope { get; set; }
        /// <summary> The autogenerated label used as part of the FQDNs for accessing the Communications Gateway. </summary>
        public string AutoGeneratedDomainNameLabel { get; }
        /// <summary> This number is used in Teams Phone Mobile scenarios for access to the voicemail IVR from the native dialer. </summary>
        public string TeamsVoicemailPilotNumber { get; set; }
        /// <summary> Whether an on-premises Mobile Control Point is in use. </summary>
        public bool? IsOnPremMcpEnabled { get; set; }
        /// <summary> A list of dial strings used for emergency calling. </summary>
        public IList<string> EmergencyDialStrings { get; }
    }
}
