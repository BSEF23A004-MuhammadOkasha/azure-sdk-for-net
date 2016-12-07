// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Redis.Fluent.Models
{
    using System.Linq;

    /// <summary>
    /// Specifies which Redis access keys to reset.
    /// </summary>
    public partial class RedisRegenerateKeyParameters
    {
        /// <summary>
        /// Initializes a new instance of the RedisRegenerateKeyParameters
        /// class.
        /// </summary>
        public RedisRegenerateKeyParameters() { }

        /// <summary>
        /// Initializes a new instance of the RedisRegenerateKeyParameters
        /// class.
        /// </summary>
        /// <param name="keyType">The Redis access key to regenerate. Possible
        /// values include: 'Primary', 'Secondary'</param>
        public RedisRegenerateKeyParameters(RedisKeyType keyType)
        {
            KeyType = keyType;
        }

        /// <summary>
        /// Gets or sets the Redis access key to regenerate. Possible values
        /// include: 'Primary', 'Secondary'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "keyType")]
        public RedisKeyType KeyType { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
