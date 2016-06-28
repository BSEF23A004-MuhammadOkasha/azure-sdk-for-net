// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ResourceManager.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Deployment properties.
    /// </summary>
    public partial class DeploymentProperties
    {
        /// <summary>
        /// Initializes a new instance of the DeploymentProperties class.
        /// </summary>
        public DeploymentProperties() { }

        /// <summary>
        /// Initializes a new instance of the DeploymentProperties class.
        /// </summary>
        public DeploymentProperties(DeploymentMode? mode, object template = default(object), TemplateLink templateLink = default(TemplateLink), object parameters = default(object), ParametersLink parametersLink = default(ParametersLink), DebugSetting debugSetting = default(DebugSetting))
        {
            Template = template;
            TemplateLink = templateLink;
            Parameters = parameters;
            ParametersLink = parametersLink;
            Mode = mode;
            DebugSetting = debugSetting;
        }

        /// <summary>
        /// Gets or sets the template content. Use only one of Template or
        /// TemplateLink.
        /// </summary>
        [JsonProperty(PropertyName = "template")]
        public object Template { get; set; }

        /// <summary>
        /// Gets or sets the URI referencing the template. Use only one of
        /// Template or TemplateLink.
        /// </summary>
        [JsonProperty(PropertyName = "templateLink")]
        public TemplateLink TemplateLink { get; set; }

        /// <summary>
        /// Deployment parameters. Use only one of Parameters or
        /// ParametersLink.
        /// </summary>
        [JsonProperty(PropertyName = "parameters")]
        public object Parameters { get; set; }

        /// <summary>
        /// Gets or sets the URI referencing the parameters. Use only one of
        /// Parameters or ParametersLink.
        /// </summary>
        [JsonProperty(PropertyName = "parametersLink")]
        public ParametersLink ParametersLink { get; set; }

        /// <summary>
        /// Gets or sets the deployment mode. Possible values for this
        /// property include: 'Incremental', 'Complete'.
        /// </summary>
        [JsonProperty(PropertyName = "mode")]
        public DeploymentMode? Mode { get; set; }

        /// <summary>
        /// Gets or sets the debug setting of the deployment.
        /// </summary>
        [JsonProperty(PropertyName = "debugSetting")]
        public DebugSetting DebugSetting { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Mode == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Mode");
            }
            if (this.TemplateLink != null)
            {
                this.TemplateLink.Validate();
            }
            if (this.ParametersLink != null)
            {
                this.ParametersLink.Validate();
            }
        }
    }
}
