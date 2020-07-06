// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Security.KeyVault.Models
{
    /// <summary> The backup secret result, containing the backup blob. </summary>
    public partial class BackupSecretResult
    {
        /// <summary> Initializes a new instance of BackupSecretResult. </summary>
        internal BackupSecretResult()
        {
        }

        /// <summary> Initializes a new instance of BackupSecretResult. </summary>
        /// <param name="value"> The backup blob containing the backed up secret. </param>
        internal BackupSecretResult(byte[] value)
        {
            Value = value;
        }

        /// <summary> The backup blob containing the backed up secret. </summary>
        public byte[] Value { get; }
    }
}
