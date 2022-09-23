// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    /// <summary> Property/Properties which represent a unique ID. </summary>
    public partial class StrongId
    {
        /// <summary> Initializes a new instance of StrongId. </summary>
        /// <param name="keyPropertyNames"> The properties which make up the unique ID. </param>
        /// <param name="strongIdName"> The Name identifying the strong ID. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="keyPropertyNames"/> or <paramref name="strongIdName"/> is null. </exception>
        public StrongId(IEnumerable<string> keyPropertyNames, string strongIdName)
        {
            if (keyPropertyNames == null)
            {
                throw new ArgumentNullException(nameof(keyPropertyNames));
            }
            if (strongIdName == null)
            {
                throw new ArgumentNullException(nameof(strongIdName));
            }

            KeyPropertyNames = keyPropertyNames.ToList();
            StrongIdName = strongIdName;
            DisplayName = new ChangeTrackingDictionary<string, string>();
            Description = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of StrongId. </summary>
        /// <param name="keyPropertyNames"> The properties which make up the unique ID. </param>
        /// <param name="strongIdName"> The Name identifying the strong ID. </param>
        /// <param name="displayName"> Localized display name. </param>
        /// <param name="description"> Localized descriptions. </param>
        internal StrongId(IList<string> keyPropertyNames, string strongIdName, IDictionary<string, string> displayName, IDictionary<string, string> description)
        {
            KeyPropertyNames = keyPropertyNames;
            StrongIdName = strongIdName;
            DisplayName = displayName;
            Description = description;
        }

        /// <summary> The properties which make up the unique ID. </summary>
        public IList<string> KeyPropertyNames { get; }
        /// <summary> The Name identifying the strong ID. </summary>
        public string StrongIdName { get; set; }
        /// <summary> Localized display name. </summary>
        public IDictionary<string, string> DisplayName { get; }
        /// <summary> Localized descriptions. </summary>
        public IDictionary<string, string> Description { get; }
    }
}
