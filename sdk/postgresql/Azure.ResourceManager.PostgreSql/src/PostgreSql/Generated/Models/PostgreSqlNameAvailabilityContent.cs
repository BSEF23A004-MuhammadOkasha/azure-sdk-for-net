// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.PostgreSql.Models
{
    /// <summary> Request from client to check resource name availability. </summary>
    public partial class PostgreSqlNameAvailabilityContent
    {
        /// <summary> Initializes a new instance of PostgreSqlNameAvailabilityContent. </summary>
        /// <param name="name"> Resource name to verify. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public PostgreSqlNameAvailabilityContent(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;
        }

        /// <summary> Resource name to verify. </summary>
        public string Name { get; }
        /// <summary> Resource type used for verification. </summary>
        public ResourceType? ResourceType { get; set; }
    }
}
