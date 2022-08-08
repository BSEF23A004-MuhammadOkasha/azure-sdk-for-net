// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Migrate.Models
{
    /// <summary> The move custom error info. </summary>
    internal partial class MoveErrorInfo
    {
        /// <summary> Initializes a new instance of MoveErrorInfo. </summary>
        internal MoveErrorInfo()
        {
            MoveResources = new ChangeTrackingList<MoverAffectedMoveResourceInfo>();
        }

        /// <summary> Initializes a new instance of MoveErrorInfo. </summary>
        /// <param name="moveResources"> The affected move resources. </param>
        internal MoveErrorInfo(IReadOnlyList<MoverAffectedMoveResourceInfo> moveResources)
        {
            MoveResources = moveResources;
        }

        /// <summary> The affected move resources. </summary>
        public IReadOnlyList<MoverAffectedMoveResourceInfo> MoveResources { get; }
    }
}
