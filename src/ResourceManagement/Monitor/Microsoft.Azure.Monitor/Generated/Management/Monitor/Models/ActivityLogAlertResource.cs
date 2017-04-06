// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Insights.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Insights;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// An activity log alert resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ActivityLogAlertResource : Resource
    {
        /// <summary>
        /// Initializes a new instance of the ActivityLogAlertResource class.
        /// </summary>
        public ActivityLogAlertResource() { }

        /// <summary>
        /// Initializes a new instance of the ActivityLogAlertResource class.
        /// </summary>
        /// <param name="location">Resource location</param>
        /// <param name="scopes">A list of resourceIds that will be used as
        /// prefixes. The alert will only apply to activityLogs with
        /// resourceIds that fall under one of these prefixes. This list must
        /// include at least one item.</param>
        /// <param name="condition">The conditon that will cause this alert to
        /// activate.</param>
        /// <param name="actions">The actions that will activate when the
        /// condition is met.</param>
        /// <param name="id">Azure resource Id</param>
        /// <param name="name">Azure resource name</param>
        /// <param name="type">Azure resource type</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="enabled">Indicates whether this activity log alert is
        /// enabled. If an activity log alert is not enabled, then none of its
        /// actions will be activated.</param>
        /// <param name="description">A description of this activity log
        /// alert.</param>
        public ActivityLogAlertResource(string location, IList<string> scopes, ActivityLogAlertAllOfCondition condition, ActivityLogAlertActionList actions, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), bool? enabled = default(bool?), string description = default(string))
            : base(location, id, name, type, tags)
        {
            Scopes = scopes;
            Enabled = enabled;
            Condition = condition;
            Actions = actions;
            Description = description;
        }

        /// <summary>
        /// Gets or sets a list of resourceIds that will be used as prefixes.
        /// The alert will only apply to activityLogs with resourceIds that
        /// fall under one of these prefixes. This list must include at least
        /// one item.
        /// </summary>
        [JsonProperty(PropertyName = "properties.scopes")]
        public IList<string> Scopes { get; set; }

        /// <summary>
        /// Gets or sets indicates whether this activity log alert is enabled.
        /// If an activity log alert is not enabled, then none of its actions
        /// will be activated.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or sets the conditon that will cause this alert to activate.
        /// </summary>
        [JsonProperty(PropertyName = "properties.condition")]
        public ActivityLogAlertAllOfCondition Condition { get; set; }

        /// <summary>
        /// Gets or sets the actions that will activate when the condition is
        /// met.
        /// </summary>
        [JsonProperty(PropertyName = "properties.actions")]
        public ActivityLogAlertActionList Actions { get; set; }

        /// <summary>
        /// Gets or sets a description of this activity log alert.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Scopes == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Scopes");
            }
            if (Condition == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Condition");
            }
            if (Actions == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Actions");
            }
            if (Condition != null)
            {
                Condition.Validate();
            }
        }
    }
}
