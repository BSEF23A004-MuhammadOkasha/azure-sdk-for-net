// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> Properties of the additional workspaces. </summary>
    public partial class AdditionalWorkspacesProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AdditionalWorkspacesProperties"/>. </summary>
        public AdditionalWorkspacesProperties()
        {
            DataTypes = new ChangeTrackingList<AdditionalWorkspaceDataType>();
        }

        /// <summary> Initializes a new instance of <see cref="AdditionalWorkspacesProperties"/>. </summary>
        /// <param name="workspace"> Workspace resource id. </param>
        /// <param name="workspaceType"> Workspace type. </param>
        /// <param name="dataTypes"> List of data types sent to workspace. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AdditionalWorkspacesProperties(string workspace, AdditionalWorkspaceType? workspaceType, IList<AdditionalWorkspaceDataType> dataTypes, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Workspace = workspace;
            WorkspaceType = workspaceType;
            DataTypes = dataTypes;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Workspace resource id. </summary>
        public string Workspace { get; set; }
        /// <summary> Workspace type. </summary>
        public AdditionalWorkspaceType? WorkspaceType { get; set; }
        /// <summary> List of data types sent to workspace. </summary>
        public IList<AdditionalWorkspaceDataType> DataTypes { get; }
    }
}
