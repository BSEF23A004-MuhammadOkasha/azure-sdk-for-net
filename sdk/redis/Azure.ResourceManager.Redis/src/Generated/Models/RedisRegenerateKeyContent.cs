// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Redis.Models
{
    /// <summary> Specifies which Redis access keys to reset. </summary>
    public partial class RedisRegenerateKeyContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RedisRegenerateKeyContent"/>. </summary>
        /// <param name="keyType"> The Redis access key to regenerate. </param>
        public RedisRegenerateKeyContent(RedisRegenerateKeyType keyType)
        {
            KeyType = keyType;
        }

        /// <summary> Initializes a new instance of <see cref="RedisRegenerateKeyContent"/>. </summary>
        /// <param name="keyType"> The Redis access key to regenerate. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RedisRegenerateKeyContent(RedisRegenerateKeyType keyType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            KeyType = keyType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="RedisRegenerateKeyContent"/> for deserialization. </summary>
        internal RedisRegenerateKeyContent()
        {
        }

        /// <summary> The Redis access key to regenerate. </summary>
        public RedisRegenerateKeyType KeyType { get; }
    }
}
