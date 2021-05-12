﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Storage.Shared
{
    /// <summary>
    ///
    /// </summary>
    public class StorageBearerTokenChallengeAuthorizationPolicy : BearerTokenAuthenticationPolicy
    {
        private readonly bool _disableTenantDiscovery;
        private readonly string[] _scopes;
        private volatile string tenantId;

        /// <summary>
        ///
        /// </summary>
        /// <param name="credential"></param>
        /// <param name="scope"></param>
        public StorageBearerTokenChallengeAuthorizationPolicy(TokenCredential credential, string scope, bool disableTenantDiscovery) : base(credential, scope)
        {
            _disableTenantDiscovery = disableTenantDiscovery;
            Argument.AssertNotNullOrEmpty(scope, nameof(scope));
            _scopes = new[] { scope };
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="credential"></param>
        /// <param name="scopes"></param>
        public StorageBearerTokenChallengeAuthorizationPolicy(TokenCredential credential, IEnumerable<string> scopes, bool disableTenantDiscovery) : base(credential, scopes)
        {
            Argument.AssertNotNull(scopes, nameof(scopes));
            _scopes = scopes.ToArray();
        }

        /// <inheritdoc />
        protected override void AuthorizeRequest(HttpMessage message)
        {
            if (tenantId != null || disab)
            {
                base.AuthorizeRequest(message);
            }
        }

        /// <inheritdoc />
        protected override ValueTask AuthorizeRequestAsync(HttpMessage message)
        {
            return tenantId switch
            {
                null => default,
                _ => base.AuthorizeRequestAsync(message)
            };
        }

        /// <inheritdoc />
        protected override bool AuthorizeRequestOnChallenge(HttpMessage message) => AuthorizeRequestOnChallengeInternalAsync(message, false).EnsureCompleted();

        /// <inheritdoc />
        protected override ValueTask<bool> AuthorizeRequestOnChallengeAsync(HttpMessage message) => AuthorizeRequestOnChallengeInternalAsync(message, true);

        private async ValueTask<bool> AuthorizeRequestOnChallengeInternalAsync(HttpMessage message, bool async)
        {
            try
            {
                var authUri = AuthorizationChallengeParser.GetChallengeParameterFromResponse(message.Response, "Bearer", "authorization_uri");

                // tenantId should be the guid as seen in this example: https://login.microsoftonline.com/72f988bf-86f1-41af-91ab-2d7cd011db47/oauth2/authorize
                 tenantId = new Uri(authUri).Segments[1].Trim('/');

                var context = new TokenRequestContext(
                    new TokenRequestContextOptions { Scopes = _scopes, TenantIdHint = tenantId, ParentRequestId = message.Request.ClientRequestId });
                if (async)
                {
                    await AuthenticateAndAuthorizeRequestAsync(message, context).ConfigureAwait(false);
                }
                else
                {
                    AuthenticateAndAuthorizeRequest(message, context);
                }
                return true;
            }
            catch
            {
                return default;
            }
        }
    }
}
