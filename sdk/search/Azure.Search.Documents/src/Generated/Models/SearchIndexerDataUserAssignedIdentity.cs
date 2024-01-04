// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> Specifies the identity for a datasource to use. </summary>
    public partial class SearchIndexerDataUserAssignedIdentity : SearchIndexerDataIdentity
    {
        /// <summary> Initializes a new instance of <see cref="SearchIndexerDataUserAssignedIdentity"/>. </summary>
        /// <param name="userAssignedIdentity"> The fully qualified Azure resource Id of a user assigned managed identity typically in the form "/subscriptions/12345678-1234-1234-1234-1234567890ab/resourceGroups/rg/providers/Microsoft.ManagedIdentity/userAssignedIdentities/myId" that should have been assigned to the search service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="userAssignedIdentity"/> is null. </exception>
        public SearchIndexerDataUserAssignedIdentity(string userAssignedIdentity)
        {
            Argument.AssertNotNull(userAssignedIdentity, nameof(userAssignedIdentity));

            UserAssignedIdentity = userAssignedIdentity;
            ODataType = "#Microsoft.Azure.Search.DataUserAssignedIdentity";
        }

        /// <summary> Initializes a new instance of <see cref="SearchIndexerDataUserAssignedIdentity"/>. </summary>
        /// <param name="oDataType"> Identifies the concrete type of the identity. </param>
        /// <param name="userAssignedIdentity"> The fully qualified Azure resource Id of a user assigned managed identity typically in the form "/subscriptions/12345678-1234-1234-1234-1234567890ab/resourceGroups/rg/providers/Microsoft.ManagedIdentity/userAssignedIdentities/myId" that should have been assigned to the search service. </param>
        internal SearchIndexerDataUserAssignedIdentity(string oDataType, string userAssignedIdentity) : base(oDataType)
        {
            UserAssignedIdentity = userAssignedIdentity;
            ODataType = oDataType ?? "#Microsoft.Azure.Search.DataUserAssignedIdentity";
        }

        /// <summary> The fully qualified Azure resource Id of a user assigned managed identity typically in the form "/subscriptions/12345678-1234-1234-1234-1234567890ab/resourceGroups/rg/providers/Microsoft.ManagedIdentity/userAssignedIdentities/myId" that should have been assigned to the search service. </summary>
        public string UserAssignedIdentity { get; set; }
    }
}
