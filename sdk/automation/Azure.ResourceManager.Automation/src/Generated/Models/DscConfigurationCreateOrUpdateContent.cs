// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> The parameters supplied to the create or update configuration operation. </summary>
    public partial class DscConfigurationCreateOrUpdateContent
    {
        /// <summary> Initializes a new instance of <see cref="DscConfigurationCreateOrUpdateContent"/>. </summary>
        /// <param name="source"> Gets or sets the source. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="source"/> is null. </exception>
        public DscConfigurationCreateOrUpdateContent(AutomationContentSource source)
        {
            Argument.AssertNotNull(source, nameof(source));

            Tags = new ChangeTrackingDictionary<string, string>();
            Source = source;
            Parameters = new ChangeTrackingDictionary<string, DscConfigurationParameterDefinition>();
        }

        /// <summary> Initializes a new instance of <see cref="DscConfigurationCreateOrUpdateContent"/>. </summary>
        /// <param name="name"> Gets or sets name of the resource. </param>
        /// <param name="location"> Gets or sets the location of the resource. </param>
        /// <param name="tags"> Gets or sets the tags attached to the resource. </param>
        /// <param name="isLogVerboseEnabled"> Gets or sets verbose log option. </param>
        /// <param name="isLogProgressEnabled"> Gets or sets progress log option. </param>
        /// <param name="source"> Gets or sets the source. </param>
        /// <param name="parameters"> Gets or sets the configuration parameters. </param>
        /// <param name="description"> Gets or sets the description of the configuration. </param>
        internal DscConfigurationCreateOrUpdateContent(string name, AzureLocation? location, IDictionary<string, string> tags, bool? isLogVerboseEnabled, bool? isLogProgressEnabled, AutomationContentSource source, IDictionary<string, DscConfigurationParameterDefinition> parameters, string description)
        {
            Name = name;
            Location = location;
            Tags = tags;
            IsLogVerboseEnabled = isLogVerboseEnabled;
            IsLogProgressEnabled = isLogProgressEnabled;
            Source = source;
            Parameters = parameters;
            Description = description;
        }

        /// <summary> Gets or sets name of the resource. </summary>
        public string Name { get; set; }
        /// <summary> Gets or sets the location of the resource. </summary>
        public AzureLocation? Location { get; set; }
        /// <summary> Gets or sets the tags attached to the resource. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Gets or sets verbose log option. </summary>
        public bool? IsLogVerboseEnabled { get; set; }
        /// <summary> Gets or sets progress log option. </summary>
        public bool? IsLogProgressEnabled { get; set; }
        /// <summary> Gets or sets the source. </summary>
        public AutomationContentSource Source { get; }
        /// <summary> Gets or sets the configuration parameters. </summary>
        public IDictionary<string, DscConfigurationParameterDefinition> Parameters { get; }
        /// <summary> Gets or sets the description of the configuration. </summary>
        public string Description { get; set; }
    }
}
