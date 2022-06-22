// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Web App stack. </summary>
    public partial class WebAppStack : ProxyOnlyResource
    {
        /// <summary> Initializes a new instance of WebAppStack. </summary>
        public WebAppStack()
        {
            MajorVersions = new ChangeTrackingList<WebAppMajorVersion>();
        }

        /// <summary> Initializes a new instance of WebAppStack. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="location"> Web App stack location. </param>
        /// <param name="displayText"> Web App stack (display only). </param>
        /// <param name="value"> Web App stack name. </param>
        /// <param name="majorVersions"> List of major versions available. </param>
        /// <param name="preferredOS"> Web App stack preferred OS. </param>
        internal WebAppStack(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string kind, AzureLocation? location, string displayText, string value, IReadOnlyList<WebAppMajorVersion> majorVersions, StackPreferredOS? preferredOS) : base(id, name, resourceType, systemData, kind)
        {
            Location = location;
            DisplayText = displayText;
            Value = value;
            MajorVersions = majorVersions;
            PreferredOS = preferredOS;
        }

        /// <summary> Web App stack location. </summary>
        public AzureLocation? Location { get; }
        /// <summary> Web App stack (display only). </summary>
        public string DisplayText { get; }
        /// <summary> Web App stack name. </summary>
        public string Value { get; }
        /// <summary> List of major versions available. </summary>
        public IReadOnlyList<WebAppMajorVersion> MajorVersions { get; }
        /// <summary> Web App stack preferred OS. </summary>
        public StackPreferredOS? PreferredOS { get; }
    }
}
