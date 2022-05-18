// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.EventGrid.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Verified partner information
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class VerifiedPartner : Resource
    {
        /// <summary>
        /// Initializes a new instance of the VerifiedPartner class.
        /// </summary>
        public VerifiedPartner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VerifiedPartner class.
        /// </summary>
        /// <param name="id">Fully qualified identifier of the
        /// resource.</param>
        /// <param name="name">Name of the resource.</param>
        /// <param name="type">Type of the resource.</param>
        /// <param name="partnerRegistrationImmutableId">ImmutableId of the
        /// corresponding partner registration.</param>
        /// <param name="organizationName">Official name of the
        /// Partner.</param>
        /// <param name="partnerDisplayName">Display name of the verified
        /// partner.</param>
        /// <param name="partnerTopicDetails">Details of the partner topic
        /// scenario.</param>
        /// <param name="partnerDestinationDetails">Details of the partner
        /// destination scenario.</param>
        /// <param name="provisioningState">Provisioning state of the verified
        /// partner. Possible values include: 'Creating', 'Updating',
        /// 'Deleting', 'Succeeded', 'Canceled', 'Failed'</param>
        /// <param name="systemData">The system metadata relating to Verified
        /// Partner resource.</param>
        public VerifiedPartner(string id = default(string), string name = default(string), string type = default(string), System.Guid? partnerRegistrationImmutableId = default(System.Guid?), string organizationName = default(string), string partnerDisplayName = default(string), PartnerDetails partnerTopicDetails = default(PartnerDetails), PartnerDetails partnerDestinationDetails = default(PartnerDetails), string provisioningState = default(string), SystemData systemData = default(SystemData))
            : base(id, name, type)
        {
            PartnerRegistrationImmutableId = partnerRegistrationImmutableId;
            OrganizationName = organizationName;
            PartnerDisplayName = partnerDisplayName;
            PartnerTopicDetails = partnerTopicDetails;
            PartnerDestinationDetails = partnerDestinationDetails;
            ProvisioningState = provisioningState;
            SystemData = systemData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets immutableId of the corresponding partner registration.
        /// </summary>
        [JsonProperty(PropertyName = "properties.partnerRegistrationImmutableId")]
        public System.Guid? PartnerRegistrationImmutableId { get; set; }

        /// <summary>
        /// Gets or sets official name of the Partner.
        /// </summary>
        [JsonProperty(PropertyName = "properties.organizationName")]
        public string OrganizationName { get; set; }

        /// <summary>
        /// Gets or sets display name of the verified partner.
        /// </summary>
        [JsonProperty(PropertyName = "properties.partnerDisplayName")]
        public string PartnerDisplayName { get; set; }

        /// <summary>
        /// Gets or sets details of the partner topic scenario.
        /// </summary>
        [JsonProperty(PropertyName = "properties.partnerTopicDetails")]
        public PartnerDetails PartnerTopicDetails { get; set; }

        /// <summary>
        /// Gets or sets details of the partner destination scenario.
        /// </summary>
        [JsonProperty(PropertyName = "properties.partnerDestinationDetails")]
        public PartnerDetails PartnerDestinationDetails { get; set; }

        /// <summary>
        /// Gets or sets provisioning state of the verified partner. Possible
        /// values include: 'Creating', 'Updating', 'Deleting', 'Succeeded',
        /// 'Canceled', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets the system metadata relating to Verified Partner resource.
        /// </summary>
        [JsonProperty(PropertyName = "systemData")]
        public SystemData SystemData { get; private set; }

    }
}
