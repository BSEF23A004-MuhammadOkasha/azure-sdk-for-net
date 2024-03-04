﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.NetApp;

namespace Azure.ResourceManager.NetApp.Models
{
    internal partial class BackupsList
    {
        internal static BackupsList DeserializeBackupsList(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<NetAppBackupData> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NetAppBackupData> array = new List<NetAppBackupData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NetAppBackupData.DeserializeNetAppBackupData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new BackupsList(value ?? new ChangeTrackingList<NetAppBackupData>());
        }
    }
}
