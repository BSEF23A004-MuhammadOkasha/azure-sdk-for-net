﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace Microsoft.Rest.ClientRuntime.Azure.LRO
{
    using Microsoft.Rest.Azure;
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Threading;
    using System.Threading.Tasks;

    internal class PATCHLro<TResourceBody, TRequestHeaders> : AzureLRO<TResourceBody, TRequestHeaders>
            where TResourceBody : class
            where TRequestHeaders : class
    {
        public override string RESTOperationVerb { get => "PATCH"; }

        public PATCHLro(IAzureClient client, AzureOperationResponse<TResourceBody, TRequestHeaders> response,
            Dictionary<string, List<string>> customHeaders,
            CancellationToken cancellationToken) : base(client, response, customHeaders, cancellationToken)
        { }

        protected override void InitializeAsyncHeadersToUse()
        {
            base.InitializeAsyncHeadersToUse();
            if (string.IsNullOrEmpty(CurrentPollingState.PollingUrlToUse))
            {
                CurrentPollingState.PollingUrlToUse = InitialResponse.Request.RequestUri.AbsoluteUri;
                CurrentPollingState.FinalGETUrlToUser = CurrentPollingState.PollingUrlToUse;
            }

            // 201
            if (CurrentPollingState.CurrentStatusCode == System.Net.HttpStatusCode.Created)
            {
                if (string.IsNullOrEmpty(CurrentPollingState.AzureAsyncOperationHeaderLink))
                {
                    string requestUri = CurrentPollingState.Request.RequestUri.AbsoluteUri;
                    if (string.IsNullOrEmpty(requestUri))
                    {
                        throw new ValidationException(ValidationRules.CannotBeNull, "RequestUri");
                    }
                    else
                    {
                        CurrentPollingState.PollingUrlToUse = CurrentPollingState.Request.RequestUri.AbsoluteUri;
                    }
                }
                else
                {
                    CurrentPollingState.PollingUrlToUse = CurrentPollingState.AzureAsyncOperationHeaderLink;
                }
            }

            // For 202, we prefer AzureAsyncOperation header, else we fallback on LocationHeader
            if (CurrentPollingState.CurrentStatusCode == System.Net.HttpStatusCode.Accepted)
            {
                if (!string.IsNullOrEmpty(CurrentPollingState.AzureAsyncOperationHeaderLink))
                {
                    CurrentPollingState.PollingUrlToUse = CurrentPollingState.AzureAsyncOperationHeaderLink;
                }
                else if (!string.IsNullOrEmpty(CurrentPollingState.LocationHeaderLink))
                {
                    CurrentPollingState.PollingUrlToUse = GetValidAbsoluteUri(CurrentPollingState.LocationHeaderLink);
                }

                if (string.IsNullOrEmpty(CurrentPollingState.PollingUrlToUse))
                {
                    throw new ValidationException(ValidationRules.CannotBeNull, "AzureAsyncOperationHeader/LocationHeader");
                }
            }
        }

        protected override bool IsCheckingProvisioningStateApplicable()
        {
            // For PATCH check Provisioning for 200 and 201
            return ((CurrentPollingState.CurrentStatusCode == HttpStatusCode.OK) ||
                     (CurrentPollingState.CurrentStatusCode == HttpStatusCode.Created));
        }

        protected override async Task PostPollingAsync()
        {
            // We do an additional Get to get the resource for PATCH requests
            if (AzureAsyncOperation.SuccessStatus.Equals(CurrentPollingState.Status, StringComparison.OrdinalIgnoreCase))
            {
                if ((!string.IsNullOrEmpty(CurrentPollingState.AzureAsyncOperationHeaderLink) || CurrentPollingState.Resource == null))
                {
                    CurrentPollingState.PollingUrlToUse = GetValidAbsoluteUri(CurrentPollingState.InitialResponse.Request.RequestUri.AbsoluteUri, throwForInvalidUri: true);

                    await CurrentPollingState.UpdateResourceFromPollingUri(CustomHeaders, CancelToken);
                }
            }
        }
    }
}
