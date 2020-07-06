// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Security.KeyVault.Models
{
    /// <summary> The deleted secret list result. </summary>
    public partial class DeletedSecretListResult
    {
        /// <summary> Initializes a new instance of DeletedSecretListResult. </summary>
        internal DeletedSecretListResult()
        {
        }

        /// <summary> Initializes a new instance of DeletedSecretListResult. </summary>
        /// <param name="value"> A response message containing a list of the deleted secrets in the vault along with a link to the next page of deleted secrets. </param>
        /// <param name="nextLink"> The URL to get the next set of deleted secrets. </param>
        internal DeletedSecretListResult(IReadOnlyList<DeletedSecretItem> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> A response message containing a list of the deleted secrets in the vault along with a link to the next page of deleted secrets. </summary>
        public IReadOnlyList<DeletedSecretItem> Value { get; }
        /// <summary> The URL to get the next set of deleted secrets. </summary>
        public string NextLink { get; }
    }
}
