﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Microsoft.Azure.WebJobs.Extensions.AuthenticationEvents.Framework;
using System.ComponentModel;
using tisEvents = Microsoft.Azure.WebJobs.Extensions.AuthenticationEvents.TokenIssuanceStart;

//[assembly: InternalsVisibleTo("WebJobs.Extensions.AuthenticationEvents.Tests")]

namespace Microsoft.Azure.WebJobs.Extensions.AuthenticationEvents
{
    #region Global Enums
    /// <summary>Events available by event type.</summary>
    public enum EventDefinition
    {
        /// <summary>onTokenIssuanceStart event -&gt; preview 10 01 2021.</summary>
        [AuthEventMetadata(typeof(tisEvents.TokenIssuanceStartRequest),
            "onTokenIssuanceStartCustomExtension",
            "TokenIssuanceStart.preview_10_01_2021")]
        TokenIssuanceStartV20211001Preview,
        /// <summary>onTokenIssuanceStart event.</summary>
        [AuthEventMetadata(typeof(tisEvents.TokenIssuanceStartRequest),
           "microsoft.graph.authenticationEvent.TokenIssuanceStart",
           "TokenIssuanceStart", responseTemplate: "CloudEventActionableTemplate.json")]
        TokenIssuanceStart
    }

    /// <summary>Types of events to listen for and attach a function to.</summary>
    public enum EventType
    {
        /// <summary>When a token is issued, this event will be called and the ability to append claim to the token is enabled via the response.</summary>
        OnTokenIssuanceStart
    }

    /// <summary>The status of the incoming request.</summary>
    public enum AuthEventConvertStatusType
    {
        /// <summary>If there is any failures on the incoming status, the StatusMessage property will contain the reason for the failure.</summary>
        Failed,
        /// <summary>All check have passed except for the Token, which is invalid.</summary>
        TokenInvalid,
        /// <summary>Incoming request and token has passed all checks and is in a successful state.</summary>
        Successful
    }

    /// <summary>Supported Azure token schema.</summary>
    internal enum SupportedTokenSchemaVersions
    {
        /// <summary>Version 1.</summary>
        [Description("1.0")] V1_0,
        /// <summary>Version 2.</summary>
        [Description("2.0")] V2_0
    }

    /// <summary>Document Types.</summary>
    internal enum OpenAPIDocumentTypes
    {
        /// <summary>The open API document.</summary>
        OpenApiDocument,
        /// <summary>The request schema.</summary>
        RequestSchema,
        /// <summary>The response schema.</summary>
        ResponseSchema
    }
    #endregion
}
