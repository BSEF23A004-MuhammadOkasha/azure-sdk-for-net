// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

//
// This file was autogenerated by a tool.
// Do not modify it.
//

namespace Microsoft.Azure.Batch
{
    using Models = Microsoft.Azure.Batch.Protocol.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The result of uploading batch service log files from a specific compute node.
    /// </summary>
    public partial class UploadBatchServiceLogsResult : IPropertyMetadata
    {
        #region Constructors

        internal UploadBatchServiceLogsResult(Models.UploadBatchServiceLogsResult protocolObject)
        {
            this.UploadSetSize = protocolObject.UploadSetSize;
            this.VirtualDirectoryName = protocolObject.VirtualDirectoryName;
        }

        #endregion Constructors

        #region UploadBatchServiceLogsResult

        /// <summary>
        /// Gets the number of log files which will be uploaded.
        /// </summary>
        public int UploadSetSize { get; }

        /// <summary>
        /// Gets the virtual directory within the Azure Blob Storage container to which the Batch Service log file(s) will 
        /// be uploaded.
        /// </summary>
        /// <remarks>
        /// The virtual directory name is part of the blob name for each log file uploaded.
        /// </remarks>
        public string VirtualDirectoryName { get; }

        #endregion // UploadBatchServiceLogsResult

        #region IPropertyMetadata

        bool IModifiable.HasBeenModified
        {
            //This class is compile time readonly so it cannot have been modified
            get { return false; }
        }

        bool IReadOnly.IsReadOnly
        {
            get { return true; }
            set
            {
                // This class is compile time readonly already
            }
        }

        #endregion // IPropertyMetadata
    }
}