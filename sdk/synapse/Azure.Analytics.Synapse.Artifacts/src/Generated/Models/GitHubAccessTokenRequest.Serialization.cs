// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(GitHubAccessTokenRequestConverter))]
    public partial class GitHubAccessTokenRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("gitHubClientId");
            writer.WriteStringValue(GitHubClientId);
            writer.WritePropertyName("gitHubAccessCode");
            writer.WriteStringValue(GitHubAccessCode);
            writer.WritePropertyName("gitHubAccessTokenBaseUrl");
            writer.WriteStringValue(GitHubAccessTokenBaseUrl);
            writer.WriteEndObject();
        }

        internal partial class GitHubAccessTokenRequestConverter : JsonConverter<GitHubAccessTokenRequest>
        {
            public override void Write(Utf8JsonWriter writer, GitHubAccessTokenRequest model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override GitHubAccessTokenRequest Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeGitHubAccessTokenRequest(document.RootElement);
            }
        }
    }
}
