// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.BotService;

namespace Azure.ResourceManager.BotService.Models
{
    /// <summary> The list of bot service channel operation response. </summary>
    internal partial class ChannelResponseList
    {
        /// <summary> Initializes a new instance of ChannelResponseList. </summary>
        internal ChannelResponseList()
        {
            Value = new ChangeTrackingList<BotChannelData>();
        }

        /// <summary> Initializes a new instance of ChannelResponseList. </summary>
        /// <param name="nextLink"> The link used to get the next page of bot service channel resources. </param>
        /// <param name="value"> Gets the list of bot service channel results and their properties. </param>
        internal ChannelResponseList(string nextLink, IReadOnlyList<BotChannelData> value)
        {
            NextLink = nextLink;
            Value = value;
        }

        /// <summary> The link used to get the next page of bot service channel resources. </summary>
        public string NextLink { get; }
        /// <summary> Gets the list of bot service channel results and their properties. </summary>
        public IReadOnlyList<BotChannelData> Value { get; }
    }
}
