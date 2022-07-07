// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Get GitHub access token request definition. </summary>
    public partial class GitHubAccessTokenContent
    {
        /// <summary> Initializes a new instance of GitHubAccessTokenContent. </summary>
        /// <param name="gitHubAccessCode"> GitHub access code. </param>
        /// <param name="gitHubAccessTokenBaseUri"> GitHub access token base URL. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="gitHubAccessCode"/> or <paramref name="gitHubAccessTokenBaseUri"/> is null. </exception>
        public GitHubAccessTokenContent(string gitHubAccessCode, Uri gitHubAccessTokenBaseUri)
        {
            if (gitHubAccessCode == null)
            {
                throw new ArgumentNullException(nameof(gitHubAccessCode));
            }
            if (gitHubAccessTokenBaseUri == null)
            {
                throw new ArgumentNullException(nameof(gitHubAccessTokenBaseUri));
            }

            GitHubAccessCode = gitHubAccessCode;
            GitHubAccessTokenBaseUri = gitHubAccessTokenBaseUri;
        }

        /// <summary> GitHub access code. </summary>
        public string GitHubAccessCode { get; }
        /// <summary> GitHub application client ID. </summary>
        public string GitHubClientId { get; set; }
        /// <summary> GitHub bring your own app client secret information. </summary>
        public GitHubClientSecret GitHubClientSecret { get; set; }
        /// <summary> GitHub access token base URL. </summary>
        public Uri GitHubAccessTokenBaseUri { get; }
    }
}
