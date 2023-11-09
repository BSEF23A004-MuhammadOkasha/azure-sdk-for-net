// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> describes the custom entity store assignment request. </summary>
    public partial class CustomEntityStoreAssignmentCreateOrUpdateContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="CustomEntityStoreAssignmentCreateOrUpdateContent"/>. </summary>
        public CustomEntityStoreAssignmentCreateOrUpdateContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CustomEntityStoreAssignmentCreateOrUpdateContent"/>. </summary>
        /// <param name="principal"> The principal assigned with entity store. If not provided, will use caller principal. Format of principal is: [AAD type]=[PrincipalObjectId];[TenantId]. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CustomEntityStoreAssignmentCreateOrUpdateContent(string principal, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Principal = principal;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The principal assigned with entity store. If not provided, will use caller principal. Format of principal is: [AAD type]=[PrincipalObjectId];[TenantId]. </summary>
        public string Principal { get; set; }
    }
}
