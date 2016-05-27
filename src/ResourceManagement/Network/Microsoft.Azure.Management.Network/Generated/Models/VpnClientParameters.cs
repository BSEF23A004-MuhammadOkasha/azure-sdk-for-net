// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// VpnClientParameters
    /// </summary>
    public partial class VpnClientParameters
    {
        /// <summary>
        /// Initializes a new instance of the VpnClientParameters class.
        /// </summary>
        public VpnClientParameters() { }

        /// <summary>
        /// Initializes a new instance of the VpnClientParameters class.
        /// </summary>
        public VpnClientParameters(string processorArchitecture = default(string))
        {
            ProcessorArchitecture = processorArchitecture;
        }

        /// <summary>
        /// VPN client Processor Architecture -Amd64/X86. Possible values
        /// include: 'Amd64', 'X86'
        /// </summary>
        [JsonProperty(PropertyName = "ProcessorArchitecture")]
        public string ProcessorArchitecture { get; set; }

    }
}
