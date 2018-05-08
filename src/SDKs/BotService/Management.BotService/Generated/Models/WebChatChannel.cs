// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.BotService.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Web Chat channel definition
    /// </summary>
    public partial class WebChatChannel : Channel
    {
        /// <summary>
        /// Initializes a new instance of the WebChatChannel class.
        /// </summary>
        public WebChatChannel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WebChatChannel class.
        /// </summary>
        /// <param name="properties">The set of properties specific to Web Chat
        /// channel resource</param>
        public WebChatChannel(WebChatChannelProperties properties = default(WebChatChannelProperties))
        {
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the set of properties specific to Web Chat channel
        /// resource
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public WebChatChannelProperties Properties { get; set; }

    }
}
