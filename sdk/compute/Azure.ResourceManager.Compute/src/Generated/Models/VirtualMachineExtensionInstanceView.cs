// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The instance view of a virtual machine extension. </summary>
    public partial class VirtualMachineExtensionInstanceView
    {
        /// <summary> Initializes a new instance of VirtualMachineExtensionInstanceView. </summary>
        public VirtualMachineExtensionInstanceView()
        {
        }

        /// <summary> Initializes a new instance of VirtualMachineExtensionInstanceView. </summary>
        /// <param name="name"> The virtual machine extension name. </param>
        /// <param name="type"> Specifies the type of the extension; an example is &quot;CustomScriptExtension&quot;. </param>
        /// <param name="typeHandlerVersion"> Specifies the version of the script handler. </param>
        /// <param name="substatuses"> The resource status information. </param>
        /// <param name="statuses"> The resource status information. </param>
        internal VirtualMachineExtensionInstanceView(string name, string type, string typeHandlerVersion, IList<InstanceViewStatus> substatuses, IList<InstanceViewStatus> statuses)
        {
            Name = name;
            Type = type;
            TypeHandlerVersion = typeHandlerVersion;
            Substatuses = substatuses;
            Statuses = statuses;
        }

        /// <summary> The virtual machine extension name. </summary>
        public string Name { get; set; }
        /// <summary> Specifies the type of the extension; an example is &quot;CustomScriptExtension&quot;. </summary>
        public string Type { get; set; }
        /// <summary> Specifies the version of the script handler. </summary>
        public string TypeHandlerVersion { get; set; }
        /// <summary> The resource status information. </summary>
        public IList<InstanceViewStatus> Substatuses { get; set; }
        /// <summary> The resource status information. </summary>
        public IList<InstanceViewStatus> Statuses { get; set; }
    }
}
