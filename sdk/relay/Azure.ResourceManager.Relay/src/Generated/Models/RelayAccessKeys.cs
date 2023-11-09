// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Relay.Models
{
    /// <summary> Namespace/Relay Connection String. </summary>
    public partial class RelayAccessKeys
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RelayAccessKeys"/>. </summary>
        internal RelayAccessKeys()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RelayAccessKeys"/>. </summary>
        /// <param name="primaryConnectionString"> Primary connection string of the created namespace authorization rule. </param>
        /// <param name="secondaryConnectionString"> Secondary connection string of the created namespace authorization rule. </param>
        /// <param name="primaryKey"> A base64-encoded 256-bit primary key for signing and validating the SAS token. </param>
        /// <param name="secondaryKey"> A base64-encoded 256-bit secondary key for signing and validating the SAS token. </param>
        /// <param name="keyName"> A string that describes the authorization rule. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RelayAccessKeys(string primaryConnectionString, string secondaryConnectionString, string primaryKey, string secondaryKey, string keyName, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PrimaryConnectionString = primaryConnectionString;
            SecondaryConnectionString = secondaryConnectionString;
            PrimaryKey = primaryKey;
            SecondaryKey = secondaryKey;
            KeyName = keyName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Primary connection string of the created namespace authorization rule. </summary>
        public string PrimaryConnectionString { get; }
        /// <summary> Secondary connection string of the created namespace authorization rule. </summary>
        public string SecondaryConnectionString { get; }
        /// <summary> A base64-encoded 256-bit primary key for signing and validating the SAS token. </summary>
        public string PrimaryKey { get; }
        /// <summary> A base64-encoded 256-bit secondary key for signing and validating the SAS token. </summary>
        public string SecondaryKey { get; }
        /// <summary> A string that describes the authorization rule. </summary>
        public string KeyName { get; }
    }
}
