// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> The FqdnEndpointDetail. </summary>
    public partial class FqdnEndpointDetail
    {
        /// <summary> Initializes a new instance of FqdnEndpointDetail. </summary>
        internal FqdnEndpointDetail()
        {
        }

        /// <summary> Initializes a new instance of FqdnEndpointDetail. </summary>
        /// <param name="port"> . </param>
        internal FqdnEndpointDetail(int? port)
        {
            Port = port;
        }

        public int? Port { get; }
    }
}
