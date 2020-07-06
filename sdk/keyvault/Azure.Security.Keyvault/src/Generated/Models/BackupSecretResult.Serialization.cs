// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.Security.KeyVault.Models
{
    public partial class BackupSecretResult
    {
        internal static BackupSecretResult DeserializeBackupSecretResult(JsonElement element)
        {
            byte[] value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    value = property.Value.GetBytesFromBase64("U");
                    continue;
                }
            }
            return new BackupSecretResult(value);
        }
    }
}
