// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Information of the backup file. </summary>
    public partial class BackupFileInfo
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="BackupFileInfo"/>. </summary>
        internal BackupFileInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="BackupFileInfo"/>. </summary>
        /// <param name="fileLocation"> Location of the backup file in shared folder. </param>
        /// <param name="familySequenceNumber"> Sequence number of the backup file in the backup set. </param>
        /// <param name="status"> Status of the backup file during migration. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal BackupFileInfo(string fileLocation, int? familySequenceNumber, BackupFileStatus? status, Dictionary<string, BinaryData> rawData)
        {
            FileLocation = fileLocation;
            FamilySequenceNumber = familySequenceNumber;
            Status = status;
            _rawData = rawData;
        }

        /// <summary> Location of the backup file in shared folder. </summary>
        public string FileLocation { get; }
        /// <summary> Sequence number of the backup file in the backup set. </summary>
        public int? FamilySequenceNumber { get; }
        /// <summary> Status of the backup file during migration. </summary>
        public BackupFileStatus? Status { get; }
    }
}
