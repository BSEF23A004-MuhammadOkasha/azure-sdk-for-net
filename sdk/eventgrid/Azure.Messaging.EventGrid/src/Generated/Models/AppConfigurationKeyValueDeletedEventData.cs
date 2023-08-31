// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for a Microsoft.AppConfiguration.KeyValueDeleted event. </summary>
    public partial class AppConfigurationKeyValueDeletedEventData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AppConfigurationKeyValueDeletedEventData"/>. </summary>
        internal AppConfigurationKeyValueDeletedEventData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AppConfigurationKeyValueDeletedEventData"/>. </summary>
        /// <param name="key"> The key used to identify the key-value that was deleted. </param>
        /// <param name="label"> The label, if any, used to identify the key-value that was deleted. </param>
        /// <param name="etag"> The etag representing the key-value that was deleted. </param>
        /// <param name="syncToken"> The sync token representing the server state after the event. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AppConfigurationKeyValueDeletedEventData(string key, string label, string etag, string syncToken, Dictionary<string, BinaryData> rawData)
        {
            Key = key;
            Label = label;
            Etag = etag;
            SyncToken = syncToken;
            _rawData = rawData;
        }

        /// <summary> The key used to identify the key-value that was deleted. </summary>
        public string Key { get; }
        /// <summary> The label, if any, used to identify the key-value that was deleted. </summary>
        public string Label { get; }
        /// <summary> The etag representing the key-value that was deleted. </summary>
        public string Etag { get; }
        /// <summary> The sync token representing the server state after the event. </summary>
        public string SyncToken { get; }
    }
}
