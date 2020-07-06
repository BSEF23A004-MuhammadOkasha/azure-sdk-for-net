// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Security.KeyVault.Models
{
    /// <summary> The deleted SAS definition list result. </summary>
    public partial class DeletedSasDefinitionListResult
    {
        /// <summary> Initializes a new instance of DeletedSasDefinitionListResult. </summary>
        internal DeletedSasDefinitionListResult()
        {
        }

        /// <summary> Initializes a new instance of DeletedSasDefinitionListResult. </summary>
        /// <param name="value"> A response message containing a list of the deleted SAS definitions in the vault along with a link to the next page of deleted sas definitions. </param>
        /// <param name="nextLink"> The URL to get the next set of deleted SAS definitions. </param>
        internal DeletedSasDefinitionListResult(IReadOnlyList<DeletedSasDefinitionItem> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> A response message containing a list of the deleted SAS definitions in the vault along with a link to the next page of deleted sas definitions. </summary>
        public IReadOnlyList<DeletedSasDefinitionItem> Value { get; }
        /// <summary> The URL to get the next set of deleted SAS definitions. </summary>
        public string NextLink { get; }
    }
}
