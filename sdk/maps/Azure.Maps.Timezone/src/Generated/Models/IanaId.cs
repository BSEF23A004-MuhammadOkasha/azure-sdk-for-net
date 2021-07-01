// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Maps.Timezone.Models
{
    /// <summary> The IanaId. </summary>
    public partial class IanaId
    {
        /// <summary> Initializes a new instance of IanaId. </summary>
        internal IanaId()
        {
        }

        /// <summary> Initializes a new instance of IanaId. </summary>
        /// <param name="id"> Id property. </param>
        /// <param name="isAlias"> IsAlias property. </param>
        /// <param name="aliasOf"> AliasOf property. </param>
        /// <param name="hasZone1970Location"> HasZone1970Location property. </param>
        internal IanaId(string id, bool? isAlias, string aliasOf, bool? hasZone1970Location)
        {
            Id = id;
            IsAlias = isAlias;
            AliasOf = aliasOf;
            HasZone1970Location = hasZone1970Location;
        }

        /// <summary> Id property. </summary>
        public string Id { get; }
        /// <summary> IsAlias property. </summary>
        public bool? IsAlias { get; }
        /// <summary> AliasOf property. </summary>
        public string AliasOf { get; }
        /// <summary> HasZone1970Location property. </summary>
        public bool? HasZone1970Location { get; }
    }
}
