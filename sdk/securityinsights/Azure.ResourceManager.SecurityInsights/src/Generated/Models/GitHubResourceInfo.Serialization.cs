// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    internal partial class GitHubResourceInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(AppInstallationId))
            {
                writer.WritePropertyName("appInstallationId");
                writer.WriteStringValue(AppInstallationId);
            }
            writer.WriteEndObject();
        }

        internal static GitHubResourceInfo DeserializeGitHubResourceInfo(JsonElement element)
        {
            Optional<string> appInstallationId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("appInstallationId"))
                {
                    appInstallationId = property.Value.GetString();
                    continue;
                }
            }
            return new GitHubResourceInfo(appInstallationId.Value);
        }
    }
}
