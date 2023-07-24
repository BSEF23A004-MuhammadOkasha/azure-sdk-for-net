// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> AgentOptions are configurations that will be applied to each agent in an agent pool. </summary>
    public partial class AgentOptions
    {
        /// <summary> Initializes a new instance of AgentOptions. </summary>
        /// <param name="hugepagesCount"> The number of hugepages to allocate. </param>
        public AgentOptions(long hugepagesCount)
        {
            HugepagesCount = hugepagesCount;
        }

        /// <summary> Initializes a new instance of AgentOptions. </summary>
        /// <param name="hugepagesCount"> The number of hugepages to allocate. </param>
        /// <param name="hugepagesSize"> The size of the hugepages to allocate. </param>
        internal AgentOptions(long hugepagesCount, HugepagesSize? hugepagesSize)
        {
            HugepagesCount = hugepagesCount;
            HugepagesSize = hugepagesSize;
        }

        /// <summary> The number of hugepages to allocate. </summary>
        public long HugepagesCount { get; set; }
        /// <summary> The size of the hugepages to allocate. </summary>
        public HugepagesSize? HugepagesSize { get; set; }
    }
}
