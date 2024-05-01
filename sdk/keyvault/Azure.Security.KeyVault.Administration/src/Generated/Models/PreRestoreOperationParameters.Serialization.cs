// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Security.KeyVault.Administration.Models
{
    public partial class PreRestoreOperationParameters : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SasTokenParameters))
            {
                writer.WritePropertyName("sasTokenParameters"u8);
                writer.WriteObjectValue(SasTokenParameters);
            }
            if (Optional.IsDefined(FolderToRestore))
            {
                writer.WritePropertyName("folderToRestore"u8);
                writer.WriteStringValue(FolderToRestore);
            }
            writer.WriteEndObject();
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
