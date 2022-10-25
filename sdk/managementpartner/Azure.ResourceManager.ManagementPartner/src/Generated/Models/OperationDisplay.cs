// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ManagementPartner.Models
{
    /// <summary> this is the management partner operation. </summary>
    public partial class OperationDisplay
    {
        /// <summary> Initializes a new instance of OperationDisplay. </summary>
        internal OperationDisplay()
        {
        }

        /// <summary> Initializes a new instance of OperationDisplay. </summary>
        /// <param name="provider"> the is management partner provider. </param>
        /// <param name="resource"> the is management partner resource. </param>
        /// <param name="operation"> the is management partner operation. </param>
        /// <param name="description"> the is management partner operation description. </param>
        internal OperationDisplay(string provider, string resource, string operation, string description)
        {
            Provider = provider;
            Resource = resource;
            Operation = operation;
            Description = description;
        }

        /// <summary> the is management partner provider. </summary>
        public string Provider { get; }
        /// <summary> the is management partner resource. </summary>
        public string Resource { get; }
        /// <summary> the is management partner operation. </summary>
        public string Operation { get; }
        /// <summary> the is management partner operation description. </summary>
        public string Description { get; }
    }
}
