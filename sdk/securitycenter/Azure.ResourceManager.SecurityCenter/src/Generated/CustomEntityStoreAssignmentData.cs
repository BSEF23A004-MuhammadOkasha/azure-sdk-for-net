// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A class representing the CustomEntityStoreAssignment data model.
    /// Custom entity store assignment
    /// </summary>
    public partial class CustomEntityStoreAssignmentData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="CustomEntityStoreAssignmentData"/>. </summary>
        public CustomEntityStoreAssignmentData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CustomEntityStoreAssignmentData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="principal"> The principal assigned with entity store. Format of principal is: [AAD type]=[PrincipalObjectId];[TenantId]. </param>
        /// <param name="entityStoreDatabaseLink"> The link to entity store database. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CustomEntityStoreAssignmentData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string principal, string entityStoreDatabaseLink, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Principal = principal;
            EntityStoreDatabaseLink = entityStoreDatabaseLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The principal assigned with entity store. Format of principal is: [AAD type]=[PrincipalObjectId];[TenantId]. </summary>
        public string Principal { get; set; }
        /// <summary> The link to entity store database. </summary>
        public string EntityStoreDatabaseLink { get; set; }
    }
}
