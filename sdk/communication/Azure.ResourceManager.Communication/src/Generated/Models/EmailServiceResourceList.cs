// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Communication;

namespace Azure.ResourceManager.Communication.Models
{
    /// <summary> Object that includes an array of EmailServices and a possible link for next set. </summary>
    internal partial class EmailServiceResourceList
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="EmailServiceResourceList"/>. </summary>
        internal EmailServiceResourceList()
        {
            Value = new ChangeTrackingList<EmailServiceResourceData>();
        }

        /// <summary> Initializes a new instance of <see cref="EmailServiceResourceList"/>. </summary>
        /// <param name="value"> List of EmailService. </param>
        /// <param name="nextLink">
        /// The URL the client should use to fetch the next page (per server side paging).
        /// It's null for now, added for future use.
        /// </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal EmailServiceResourceList(IReadOnlyList<EmailServiceResourceData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> List of EmailService. </summary>
        public IReadOnlyList<EmailServiceResourceData> Value { get; }
        /// <summary>
        /// The URL the client should use to fetch the next page (per server side paging).
        /// It's null for now, added for future use.
        /// </summary>
        public string NextLink { get; }
    }
}
