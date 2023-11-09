// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SignalR.Models
{
    /// <summary> A class represents the access keys of the resource. </summary>
    public partial class SignalRKeys
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SignalRKeys"/>. </summary>
        internal SignalRKeys()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SignalRKeys"/>. </summary>
        /// <param name="primaryKey"> The primary access key. </param>
        /// <param name="secondaryKey"> The secondary access key. </param>
        /// <param name="primaryConnectionString"> Connection string constructed via the primaryKey. </param>
        /// <param name="secondaryConnectionString"> Connection string constructed via the secondaryKey. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SignalRKeys(string primaryKey, string secondaryKey, string primaryConnectionString, string secondaryConnectionString, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PrimaryKey = primaryKey;
            SecondaryKey = secondaryKey;
            PrimaryConnectionString = primaryConnectionString;
            SecondaryConnectionString = secondaryConnectionString;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The primary access key. </summary>
        public string PrimaryKey { get; }
        /// <summary> The secondary access key. </summary>
        public string SecondaryKey { get; }
        /// <summary> Connection string constructed via the primaryKey. </summary>
        public string PrimaryConnectionString { get; }
        /// <summary> Connection string constructed via the secondaryKey. </summary>
        public string SecondaryConnectionString { get; }
    }
}
