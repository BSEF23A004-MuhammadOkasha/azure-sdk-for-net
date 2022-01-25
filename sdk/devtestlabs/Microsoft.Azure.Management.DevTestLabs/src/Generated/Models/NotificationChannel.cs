// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DevTestLabs.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A notification.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class NotificationChannel : TrackedResource
    {
        /// <summary>
        /// Initializes a new instance of the NotificationChannel class.
        /// </summary>
        public NotificationChannel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NotificationChannel class.
        /// </summary>
        /// <param name="location">The geo-location where the resource
        /// lives</param>
        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. E.g.
        /// "Microsoft.Compute/virtualMachines" or
        /// "Microsoft.Storage/storageAccounts"</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="webHookUrl">The webhook URL to send notifications
        /// to.</param>
        /// <param name="emailRecipient">The email recipient to send
        /// notifications to (can be a list of semi-colon separated email
        /// addresses).</param>
        /// <param name="notificationLocale">The locale to use when sending a
        /// notification (fallback for unsupported languages is EN).</param>
        /// <param name="description">Description of notification.</param>
        /// <param name="events">The list of event for which this notification
        /// is enabled.</param>
        /// <param name="createdDate">The creation date of the notification
        /// channel.</param>
        /// <param name="provisioningState">The provisioning status of the
        /// resource.</param>
        /// <param name="uniqueIdentifier">The unique immutable identifier of a
        /// resource (Guid).</param>
        /// <param name="systemData">The system metadata relating to this
        /// resource</param>
        public NotificationChannel(string location, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string webHookUrl = default(string), string emailRecipient = default(string), string notificationLocale = default(string), string description = default(string), IList<EventModel> events = default(IList<EventModel>), System.DateTime? createdDate = default(System.DateTime?), string provisioningState = default(string), string uniqueIdentifier = default(string), SystemData systemData = default(SystemData))
            : base(location, id, name, type, tags)
        {
            WebHookUrl = webHookUrl;
            EmailRecipient = emailRecipient;
            NotificationLocale = notificationLocale;
            Description = description;
            Events = events;
            CreatedDate = createdDate;
            ProvisioningState = provisioningState;
            UniqueIdentifier = uniqueIdentifier;
            SystemData = systemData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the webhook URL to send notifications to.
        /// </summary>
        [JsonProperty(PropertyName = "properties.webHookUrl")]
        public string WebHookUrl { get; set; }

        /// <summary>
        /// Gets or sets the email recipient to send notifications to (can be a
        /// list of semi-colon separated email addresses).
        /// </summary>
        [JsonProperty(PropertyName = "properties.emailRecipient")]
        public string EmailRecipient { get; set; }

        /// <summary>
        /// Gets or sets the locale to use when sending a notification
        /// (fallback for unsupported languages is EN).
        /// </summary>
        [JsonProperty(PropertyName = "properties.notificationLocale")]
        public string NotificationLocale { get; set; }

        /// <summary>
        /// Gets or sets description of notification.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the list of event for which this notification is
        /// enabled.
        /// </summary>
        [JsonProperty(PropertyName = "properties.events")]
        public IList<EventModel> Events { get; set; }

        /// <summary>
        /// Gets the creation date of the notification channel.
        /// </summary>
        [JsonProperty(PropertyName = "properties.createdDate")]
        public System.DateTime? CreatedDate { get; private set; }

        /// <summary>
        /// Gets the provisioning status of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets the unique immutable identifier of a resource (Guid).
        /// </summary>
        [JsonProperty(PropertyName = "properties.uniqueIdentifier")]
        public string UniqueIdentifier { get; private set; }

        /// <summary>
        /// Gets the system metadata relating to this resource
        /// </summary>
        [JsonProperty(PropertyName = "systemData")]
        public SystemData SystemData { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
