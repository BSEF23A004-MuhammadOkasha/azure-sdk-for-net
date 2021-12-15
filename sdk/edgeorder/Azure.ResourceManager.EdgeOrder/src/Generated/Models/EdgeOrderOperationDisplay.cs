// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.EdgeOrder.Models
{
    /// <summary> Localized display information for this particular operation. </summary>
    public partial class EdgeOrderOperationDisplay
    {
        /// <summary> Initializes a new instance of EdgeOrderOperationDisplay. </summary>
        internal EdgeOrderOperationDisplay()
        {
        }

        /// <summary> Initializes a new instance of EdgeOrderOperationDisplay. </summary>
        /// <param name="provider"> The localized friendly form of the resource provider name, e.g. &quot;Microsoft Monitoring Insights&quot; or &quot;Microsoft Compute&quot;. </param>
        /// <param name="resource"> The localized friendly name of the resource type related to this operation. E.g. &quot;Virtual Machines&quot; or &quot;Job Schedule Collections&quot;. </param>
        /// <param name="operation"> The concise, localized friendly name for the operation; suitable for dropdowns. E.g. &quot;Create or Update Virtual Machine&quot;, &quot;Restart Virtual Machine&quot;. </param>
        /// <param name="description"> The short, localized friendly description of the operation; suitable for tool tips and detailed views. </param>
        internal EdgeOrderOperationDisplay(string provider, string resource, string operation, string description)
        {
            Provider = provider;
            Resource = resource;
            Operation = operation;
            Description = description;
        }

        /// <summary> The localized friendly form of the resource provider name, e.g. &quot;Microsoft Monitoring Insights&quot; or &quot;Microsoft Compute&quot;. </summary>
        public string Provider { get; }
        /// <summary> The localized friendly name of the resource type related to this operation. E.g. &quot;Virtual Machines&quot; or &quot;Job Schedule Collections&quot;. </summary>
        public string Resource { get; }
        /// <summary> The concise, localized friendly name for the operation; suitable for dropdowns. E.g. &quot;Create or Update Virtual Machine&quot;, &quot;Restart Virtual Machine&quot;. </summary>
        public string Operation { get; }
        /// <summary> The short, localized friendly description of the operation; suitable for tool tips and detailed views. </summary>
        public string Description { get; }
    }
}
