// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Ssis Package. </summary>
    public partial class SsisPackage : SsisObjectMetadata
    {
        /// <summary> Initializes a new instance of SsisPackage. </summary>
        internal SsisPackage()
        {
            Parameters = new ChangeTrackingList<SsisParameter>();
            MetadataType = SsisObjectMetadataType.Package;
        }

        /// <summary> Initializes a new instance of SsisPackage. </summary>
        /// <param name="metadataType"> Type of metadata. </param>
        /// <param name="id"> Metadata id. </param>
        /// <param name="name"> Metadata name. </param>
        /// <param name="description"> Metadata description. </param>
        /// <param name="folderId"> Folder id which contains package. </param>
        /// <param name="projectVersion"> Project version which contains package. </param>
        /// <param name="projectId"> Project id which contains package. </param>
        /// <param name="parameters"> Parameters in package. </param>
        internal SsisPackage(SsisObjectMetadataType metadataType, long? id, string name, string description, long? folderId, long? projectVersion, long? projectId, IReadOnlyList<SsisParameter> parameters) : base(metadataType, id, name, description)
        {
            FolderId = folderId;
            ProjectVersion = projectVersion;
            ProjectId = projectId;
            Parameters = parameters;
            MetadataType = metadataType;
        }

        /// <summary> Folder id which contains package. </summary>
        public long? FolderId { get; }
        /// <summary> Project version which contains package. </summary>
        public long? ProjectVersion { get; }
        /// <summary> Project id which contains package. </summary>
        public long? ProjectId { get; }
        /// <summary> Parameters in package. </summary>
        public IReadOnlyList<SsisParameter> Parameters { get; }
    }
}
