﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Azure.Core
{
    /// <summary>
    /// Contains the details of an authentication token request.
    /// </summary>
    public readonly struct TokenRequestContext
    {
        /// <summary>
        /// Creates a new TokenRequest with the specified scopes.
        /// </summary>
        /// <param name="scopes">The scopes required for the token.</param>
        /// <param name="parentRequestId">The <see cref="Request.ClientRequestId"/> of the request requiring a token for authentication, if applicable.</param>
        public TokenRequestContext(string[] scopes, string? parentRequestId)
        {
            Scopes = scopes;
            ParentRequestId = parentRequestId;
            Claims = default;
            TenantIdHint = default;
        }

        /// <summary>
        /// Creates a new TokenRequest with the specified scopes.
        /// </summary>
        /// <param name="scopes">The scopes required for the token.</param>
        /// <param name="parentRequestId">The <see cref="Request.ClientRequestId"/> of the request requiring a token for authentication, if applicable.</param>
        /// <param name="claims">Additional claims to be included in the token.</param>
        public TokenRequestContext(string[] scopes, string? parentRequestId = default, string? claims = default)
        {
            Scopes = scopes;
            ParentRequestId = parentRequestId;
            Claims = claims;
            TenantIdHint = default;
        }

        /// <summary>
        /// Creates a new TokenRequest with the specified scopes.
        /// </summary>
        /// <param name="options"> The options to initialized the <see cref="TokenRequestContext"/> </param>
        public TokenRequestContext(TokenRequestContextOptions options)
        {
            Scopes = options.Scopes;
            ParentRequestId = options.ParentRequestId;
            Claims = options.Claims;
            TenantIdHint = options.TenantIdHint;
        }

        /// <summary>
        /// The scopes required for the token.
        /// </summary>
        public string[] Scopes { get; }

        /// <summary>
        /// The <see cref="Request.ClientRequestId"/> of the request requiring a token for authentication, if applicable.
        /// </summary>
        public string? ParentRequestId { get; }

        /// <summary>
        /// Additional claims to be included in the token. See <see href="https://openid.net/specs/openid-connect-core-1_0-final.html#ClaimsParameter">https://openid.net/specs/openid-connect-core-1_0-final.html#ClaimsParameter</see> for more information on format and content.
        /// </summary>
        public string? Claims { get; }

        /// <summary>
        /// A hint to indicate which tenantId is preferred.
        /// </summary>
        public string? TenantIdHint { get; }
    }
}
