// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Analytics.Purview.Account
{
    /// <summary> The PurviewResourceSetRule service client. </summary>
    public partial class PurviewResourceSetRule
    {
        private static readonly string[] AuthorizationScopes = new string[] { "https://purview.azure.net/.default" };
        private readonly TokenCredential _tokenCredential;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of PurviewResourceSetRule for mocking. </summary>
        protected PurviewResourceSetRule()
        {
        }

        /// <summary> Initializes a new instance of PurviewResourceSetRule. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="tokenCredential"> The token credential to copy. </param>
        /// <param name="endpoint"> The account endpoint of your Purview account. Example: https://{accountName}.purview.azure.com/account/. </param>
        /// <param name="apiVersion"> Api Version. </param>
        internal PurviewResourceSetRule(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, TokenCredential tokenCredential, Uri endpoint, string apiVersion)
        {
            ClientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _tokenCredential = tokenCredential;
            _endpoint = endpoint;
            _apiVersion = apiVersion;
        }

        /// <summary> Get a resource set config service model. </summary>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns cref="Response"> The response returned from the service. Details of the response body schema are in the Remarks section below. </returns>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   advancedResourceSet: {
        ///     modifiedAt: string (ISO 8601 Format),
        ///     resourceSetProcessing: &quot;Default&quot; | &quot;Advanced&quot;
        ///   },
        ///   name: string,
        ///   pathPatternConfig: {
        ///     acceptedPatterns: [
        ///       {
        ///         createdBy: string,
        ///         filterType: &quot;Pattern&quot; | &quot;Regex&quot;,
        ///         lastUpdatedTimestamp: number,
        ///         modifiedBy: string,
        ///         name: string,
        ///         path: string
        ///       }
        ///     ],
        ///     complexReplacers: [
        ///       {
        ///         createdBy: string,
        ///         description: string,
        ///         disabled: boolean,
        ///         disableRecursiveReplacerApplication: boolean,
        ///         lastUpdatedTimestamp: number,
        ///         modifiedBy: string,
        ///         name: string,
        ///         typeName: string
        ///       }
        ///     ],
        ///     createdBy: string,
        ///     enableDefaultPatterns: boolean,
        ///     lastUpdatedTimestamp: number,
        ///     modifiedBy: string,
        ///     normalizationRules: [
        ///       {
        ///         description: string,
        ///         disabled: boolean,
        ///         dynamicReplacement: boolean,
        ///         entityTypes: [string],
        ///         lastUpdatedTimestamp: number,
        ///         name: string,
        ///         regex: {
        ///           maxDigits: number,
        ///           maxLetters: number,
        ///           minDashes: number,
        ///           minDigits: number,
        ///           minDigitsOrLetters: number,
        ///           minDots: number,
        ///           minHex: number,
        ///           minLetters: number,
        ///           minUnderscores: number,
        ///           options: number,
        ///           regexStr: string
        ///         },
        ///         replaceWith: string,
        ///         version: number
        ///       }
        ///     ],
        ///     regexReplacers: [
        ///       {
        ///         condition: string,
        ///         createdBy: string,
        ///         description: string,
        ///         disabled: boolean,
        ///         disableRecursiveReplacerApplication: boolean,
        ///         doNotReplaceRegex: FastRegex,
        ///         lastUpdatedTimestamp: number,
        ///         modifiedBy: string,
        ///         name: string,
        ///         regex: FastRegex,
        ///         replaceWith: string
        ///       }
        ///     ],
        ///     rejectedPatterns: [Filter],
        ///     scopedRules: [
        ///       {
        ///         bindingUrl: string,
        ///         rules: [
        ///           {
        ///             displayName: string,
        ///             isResourceSet: boolean,
        ///             lastUpdatedTimestamp: number,
        ///             name: string,
        ///             qualifiedName: string
        ///           }
        ///         ],
        ///         storeType: string
        ///       }
        ///     ],
        ///     version: number
        ///   }
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     details: [
        ///       {
        ///         code: string,
        ///         details: [ErrorModel],
        ///         message: string,
        ///         target: string
        ///       }
        ///     ],
        ///     message: string,
        ///     target: string
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual async Task<Response> GetResourceSetRuleAsync(RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("PurviewResourceSetRule.GetResourceSetRule");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetResourceSetRuleRequest(context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get a resource set config service model. </summary>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns cref="Response"> The response returned from the service. Details of the response body schema are in the Remarks section below. </returns>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   advancedResourceSet: {
        ///     modifiedAt: string (ISO 8601 Format),
        ///     resourceSetProcessing: &quot;Default&quot; | &quot;Advanced&quot;
        ///   },
        ///   name: string,
        ///   pathPatternConfig: {
        ///     acceptedPatterns: [
        ///       {
        ///         createdBy: string,
        ///         filterType: &quot;Pattern&quot; | &quot;Regex&quot;,
        ///         lastUpdatedTimestamp: number,
        ///         modifiedBy: string,
        ///         name: string,
        ///         path: string
        ///       }
        ///     ],
        ///     complexReplacers: [
        ///       {
        ///         createdBy: string,
        ///         description: string,
        ///         disabled: boolean,
        ///         disableRecursiveReplacerApplication: boolean,
        ///         lastUpdatedTimestamp: number,
        ///         modifiedBy: string,
        ///         name: string,
        ///         typeName: string
        ///       }
        ///     ],
        ///     createdBy: string,
        ///     enableDefaultPatterns: boolean,
        ///     lastUpdatedTimestamp: number,
        ///     modifiedBy: string,
        ///     normalizationRules: [
        ///       {
        ///         description: string,
        ///         disabled: boolean,
        ///         dynamicReplacement: boolean,
        ///         entityTypes: [string],
        ///         lastUpdatedTimestamp: number,
        ///         name: string,
        ///         regex: {
        ///           maxDigits: number,
        ///           maxLetters: number,
        ///           minDashes: number,
        ///           minDigits: number,
        ///           minDigitsOrLetters: number,
        ///           minDots: number,
        ///           minHex: number,
        ///           minLetters: number,
        ///           minUnderscores: number,
        ///           options: number,
        ///           regexStr: string
        ///         },
        ///         replaceWith: string,
        ///         version: number
        ///       }
        ///     ],
        ///     regexReplacers: [
        ///       {
        ///         condition: string,
        ///         createdBy: string,
        ///         description: string,
        ///         disabled: boolean,
        ///         disableRecursiveReplacerApplication: boolean,
        ///         doNotReplaceRegex: FastRegex,
        ///         lastUpdatedTimestamp: number,
        ///         modifiedBy: string,
        ///         name: string,
        ///         regex: FastRegex,
        ///         replaceWith: string
        ///       }
        ///     ],
        ///     rejectedPatterns: [Filter],
        ///     scopedRules: [
        ///       {
        ///         bindingUrl: string,
        ///         rules: [
        ///           {
        ///             displayName: string,
        ///             isResourceSet: boolean,
        ///             lastUpdatedTimestamp: number,
        ///             name: string,
        ///             qualifiedName: string
        ///           }
        ///         ],
        ///         storeType: string
        ///       }
        ///     ],
        ///     version: number
        ///   }
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     details: [
        ///       {
        ///         code: string,
        ///         details: [ErrorModel],
        ///         message: string,
        ///         target: string
        ///       }
        ///     ],
        ///     message: string,
        ///     target: string
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual Response GetResourceSetRule(RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("PurviewResourceSetRule.GetResourceSetRule");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetResourceSetRuleRequest(context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates an resource set config. </summary>
        /// <param name="content"> The content to send as the body of the request. Details of the request body schema are in the Remarks section below. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns cref="Response"> The response returned from the service. Details of the response body schema are in the Remarks section below. </returns>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <code>{
        ///   advancedResourceSet: {
        ///     modifiedAt: string (ISO 8601 Format),
        ///     resourceSetProcessing: &quot;Default&quot; | &quot;Advanced&quot;
        ///   },
        ///   name: string,
        ///   pathPatternConfig: {
        ///     acceptedPatterns: [
        ///       {
        ///         createdBy: string,
        ///         filterType: &quot;Pattern&quot; | &quot;Regex&quot;,
        ///         lastUpdatedTimestamp: number,
        ///         modifiedBy: string,
        ///         name: string (required),
        ///         path: string (required)
        ///       }
        ///     ],
        ///     complexReplacers: [
        ///       {
        ///         createdBy: string,
        ///         description: string,
        ///         disabled: boolean,
        ///         disableRecursiveReplacerApplication: boolean,
        ///         lastUpdatedTimestamp: number,
        ///         modifiedBy: string,
        ///         name: string,
        ///         typeName: string
        ///       }
        ///     ],
        ///     createdBy: string (required),
        ///     enableDefaultPatterns: boolean (required),
        ///     lastUpdatedTimestamp: number,
        ///     modifiedBy: string,
        ///     normalizationRules: [
        ///       {
        ///         description: string,
        ///         disabled: boolean,
        ///         dynamicReplacement: boolean,
        ///         entityTypes: [string],
        ///         lastUpdatedTimestamp: number,
        ///         name: string,
        ///         regex: {
        ///           maxDigits: number,
        ///           maxLetters: number,
        ///           minDashes: number,
        ///           minDigits: number,
        ///           minDigitsOrLetters: number,
        ///           minDots: number,
        ///           minHex: number,
        ///           minLetters: number,
        ///           minUnderscores: number,
        ///           options: number,
        ///           regexStr: string
        ///         },
        ///         replaceWith: string,
        ///         version: number
        ///       }
        ///     ],
        ///     regexReplacers: [
        ///       {
        ///         condition: string,
        ///         createdBy: string,
        ///         description: string,
        ///         disabled: boolean (required),
        ///         disableRecursiveReplacerApplication: boolean,
        ///         doNotReplaceRegex: FastRegex,
        ///         lastUpdatedTimestamp: number,
        ///         modifiedBy: string,
        ///         name: string (required),
        ///         regex: FastRegex,
        ///         replaceWith: string
        ///       }
        ///     ],
        ///     rejectedPatterns: [Filter],
        ///     scopedRules: [
        ///       {
        ///         bindingUrl: string (required),
        ///         rules: [
        ///           {
        ///             displayName: string,
        ///             isResourceSet: boolean,
        ///             lastUpdatedTimestamp: number,
        ///             name: string,
        ///             qualifiedName: string (required)
        ///           }
        ///         ],
        ///         storeType: string (required)
        ///       }
        ///     ],
        ///     version: number
        ///   }
        /// }
        /// </code>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   advancedResourceSet: {
        ///     modifiedAt: string (ISO 8601 Format),
        ///     resourceSetProcessing: &quot;Default&quot; | &quot;Advanced&quot;
        ///   },
        ///   name: string,
        ///   pathPatternConfig: {
        ///     acceptedPatterns: [
        ///       {
        ///         createdBy: string,
        ///         filterType: &quot;Pattern&quot; | &quot;Regex&quot;,
        ///         lastUpdatedTimestamp: number,
        ///         modifiedBy: string,
        ///         name: string,
        ///         path: string
        ///       }
        ///     ],
        ///     complexReplacers: [
        ///       {
        ///         createdBy: string,
        ///         description: string,
        ///         disabled: boolean,
        ///         disableRecursiveReplacerApplication: boolean,
        ///         lastUpdatedTimestamp: number,
        ///         modifiedBy: string,
        ///         name: string,
        ///         typeName: string
        ///       }
        ///     ],
        ///     createdBy: string,
        ///     enableDefaultPatterns: boolean,
        ///     lastUpdatedTimestamp: number,
        ///     modifiedBy: string,
        ///     normalizationRules: [
        ///       {
        ///         description: string,
        ///         disabled: boolean,
        ///         dynamicReplacement: boolean,
        ///         entityTypes: [string],
        ///         lastUpdatedTimestamp: number,
        ///         name: string,
        ///         regex: {
        ///           maxDigits: number,
        ///           maxLetters: number,
        ///           minDashes: number,
        ///           minDigits: number,
        ///           minDigitsOrLetters: number,
        ///           minDots: number,
        ///           minHex: number,
        ///           minLetters: number,
        ///           minUnderscores: number,
        ///           options: number,
        ///           regexStr: string
        ///         },
        ///         replaceWith: string,
        ///         version: number
        ///       }
        ///     ],
        ///     regexReplacers: [
        ///       {
        ///         condition: string,
        ///         createdBy: string,
        ///         description: string,
        ///         disabled: boolean,
        ///         disableRecursiveReplacerApplication: boolean,
        ///         doNotReplaceRegex: FastRegex,
        ///         lastUpdatedTimestamp: number,
        ///         modifiedBy: string,
        ///         name: string,
        ///         regex: FastRegex,
        ///         replaceWith: string
        ///       }
        ///     ],
        ///     rejectedPatterns: [Filter],
        ///     scopedRules: [
        ///       {
        ///         bindingUrl: string,
        ///         rules: [
        ///           {
        ///             displayName: string,
        ///             isResourceSet: boolean,
        ///             lastUpdatedTimestamp: number,
        ///             name: string,
        ///             qualifiedName: string
        ///           }
        ///         ],
        ///         storeType: string
        ///       }
        ///     ],
        ///     version: number
        ///   }
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     details: [
        ///       {
        ///         code: string,
        ///         details: [ErrorModel],
        ///         message: string,
        ///         target: string
        ///       }
        ///     ],
        ///     message: string,
        ///     target: string
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual async Task<Response> CreateOrUpdateResourceSetRuleAsync(RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("PurviewResourceSetRule.CreateOrUpdateResourceSetRule");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCreateOrUpdateResourceSetRuleRequest(content, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates an resource set config. </summary>
        /// <param name="content"> The content to send as the body of the request. Details of the request body schema are in the Remarks section below. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns cref="Response"> The response returned from the service. Details of the response body schema are in the Remarks section below. </returns>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <code>{
        ///   advancedResourceSet: {
        ///     modifiedAt: string (ISO 8601 Format),
        ///     resourceSetProcessing: &quot;Default&quot; | &quot;Advanced&quot;
        ///   },
        ///   name: string,
        ///   pathPatternConfig: {
        ///     acceptedPatterns: [
        ///       {
        ///         createdBy: string,
        ///         filterType: &quot;Pattern&quot; | &quot;Regex&quot;,
        ///         lastUpdatedTimestamp: number,
        ///         modifiedBy: string,
        ///         name: string (required),
        ///         path: string (required)
        ///       }
        ///     ],
        ///     complexReplacers: [
        ///       {
        ///         createdBy: string,
        ///         description: string,
        ///         disabled: boolean,
        ///         disableRecursiveReplacerApplication: boolean,
        ///         lastUpdatedTimestamp: number,
        ///         modifiedBy: string,
        ///         name: string,
        ///         typeName: string
        ///       }
        ///     ],
        ///     createdBy: string (required),
        ///     enableDefaultPatterns: boolean (required),
        ///     lastUpdatedTimestamp: number,
        ///     modifiedBy: string,
        ///     normalizationRules: [
        ///       {
        ///         description: string,
        ///         disabled: boolean,
        ///         dynamicReplacement: boolean,
        ///         entityTypes: [string],
        ///         lastUpdatedTimestamp: number,
        ///         name: string,
        ///         regex: {
        ///           maxDigits: number,
        ///           maxLetters: number,
        ///           minDashes: number,
        ///           minDigits: number,
        ///           minDigitsOrLetters: number,
        ///           minDots: number,
        ///           minHex: number,
        ///           minLetters: number,
        ///           minUnderscores: number,
        ///           options: number,
        ///           regexStr: string
        ///         },
        ///         replaceWith: string,
        ///         version: number
        ///       }
        ///     ],
        ///     regexReplacers: [
        ///       {
        ///         condition: string,
        ///         createdBy: string,
        ///         description: string,
        ///         disabled: boolean (required),
        ///         disableRecursiveReplacerApplication: boolean,
        ///         doNotReplaceRegex: FastRegex,
        ///         lastUpdatedTimestamp: number,
        ///         modifiedBy: string,
        ///         name: string (required),
        ///         regex: FastRegex,
        ///         replaceWith: string
        ///       }
        ///     ],
        ///     rejectedPatterns: [Filter],
        ///     scopedRules: [
        ///       {
        ///         bindingUrl: string (required),
        ///         rules: [
        ///           {
        ///             displayName: string,
        ///             isResourceSet: boolean,
        ///             lastUpdatedTimestamp: number,
        ///             name: string,
        ///             qualifiedName: string (required)
        ///           }
        ///         ],
        ///         storeType: string (required)
        ///       }
        ///     ],
        ///     version: number
        ///   }
        /// }
        /// </code>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   advancedResourceSet: {
        ///     modifiedAt: string (ISO 8601 Format),
        ///     resourceSetProcessing: &quot;Default&quot; | &quot;Advanced&quot;
        ///   },
        ///   name: string,
        ///   pathPatternConfig: {
        ///     acceptedPatterns: [
        ///       {
        ///         createdBy: string,
        ///         filterType: &quot;Pattern&quot; | &quot;Regex&quot;,
        ///         lastUpdatedTimestamp: number,
        ///         modifiedBy: string,
        ///         name: string,
        ///         path: string
        ///       }
        ///     ],
        ///     complexReplacers: [
        ///       {
        ///         createdBy: string,
        ///         description: string,
        ///         disabled: boolean,
        ///         disableRecursiveReplacerApplication: boolean,
        ///         lastUpdatedTimestamp: number,
        ///         modifiedBy: string,
        ///         name: string,
        ///         typeName: string
        ///       }
        ///     ],
        ///     createdBy: string,
        ///     enableDefaultPatterns: boolean,
        ///     lastUpdatedTimestamp: number,
        ///     modifiedBy: string,
        ///     normalizationRules: [
        ///       {
        ///         description: string,
        ///         disabled: boolean,
        ///         dynamicReplacement: boolean,
        ///         entityTypes: [string],
        ///         lastUpdatedTimestamp: number,
        ///         name: string,
        ///         regex: {
        ///           maxDigits: number,
        ///           maxLetters: number,
        ///           minDashes: number,
        ///           minDigits: number,
        ///           minDigitsOrLetters: number,
        ///           minDots: number,
        ///           minHex: number,
        ///           minLetters: number,
        ///           minUnderscores: number,
        ///           options: number,
        ///           regexStr: string
        ///         },
        ///         replaceWith: string,
        ///         version: number
        ///       }
        ///     ],
        ///     regexReplacers: [
        ///       {
        ///         condition: string,
        ///         createdBy: string,
        ///         description: string,
        ///         disabled: boolean,
        ///         disableRecursiveReplacerApplication: boolean,
        ///         doNotReplaceRegex: FastRegex,
        ///         lastUpdatedTimestamp: number,
        ///         modifiedBy: string,
        ///         name: string,
        ///         regex: FastRegex,
        ///         replaceWith: string
        ///       }
        ///     ],
        ///     rejectedPatterns: [Filter],
        ///     scopedRules: [
        ///       {
        ///         bindingUrl: string,
        ///         rules: [
        ///           {
        ///             displayName: string,
        ///             isResourceSet: boolean,
        ///             lastUpdatedTimestamp: number,
        ///             name: string,
        ///             qualifiedName: string
        ///           }
        ///         ],
        ///         storeType: string
        ///       }
        ///     ],
        ///     version: number
        ///   }
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     details: [
        ///       {
        ///         code: string,
        ///         details: [ErrorModel],
        ///         message: string,
        ///         target: string
        ///       }
        ///     ],
        ///     message: string,
        ///     target: string
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual Response CreateOrUpdateResourceSetRule(RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("PurviewResourceSetRule.CreateOrUpdateResourceSetRule");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCreateOrUpdateResourceSetRuleRequest(content, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a ResourceSetRuleConfig resource. </summary>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <remarks>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     details: [
        ///       {
        ///         code: string,
        ///         details: [ErrorModel],
        ///         message: string,
        ///         target: string
        ///       }
        ///     ],
        ///     message: string,
        ///     target: string
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual async Task<Response> DeleteResourceSetRuleAsync(RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("PurviewResourceSetRule.DeleteResourceSetRule");
            scope.Start();
            try
            {
                using HttpMessage message = CreateDeleteResourceSetRuleRequest(context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a ResourceSetRuleConfig resource. </summary>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <remarks>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     details: [
        ///       {
        ///         code: string,
        ///         details: [ErrorModel],
        ///         message: string,
        ///         target: string
        ///       }
        ///     ],
        ///     message: string,
        ///     target: string
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual Response DeleteResourceSetRule(RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("PurviewResourceSetRule.DeleteResourceSetRule");
            scope.Start();
            try
            {
                using HttpMessage message = CreateDeleteResourceSetRuleRequest(context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateGetResourceSetRuleRequest(RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/resourceSetRuleConfigs/defaultResourceSetRuleConfig", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateCreateOrUpdateResourceSetRuleRequest(RequestContent content, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/resourceSetRuleConfigs/defaultResourceSetRuleConfig", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            return message;
        }

        internal HttpMessage CreateDeleteResourceSetRuleRequest(RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200204);
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/resourceSetRuleConfigs/defaultResourceSetRuleConfig", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        private static ResponseClassifier _responseClassifier200;
        private static ResponseClassifier ResponseClassifier200 => _responseClassifier200 ??= new StatusCodeClassifier(stackalloc ushort[] { 200 });
        private static ResponseClassifier _responseClassifier200204;
        private static ResponseClassifier ResponseClassifier200204 => _responseClassifier200204 ??= new StatusCodeClassifier(stackalloc ushort[] { 200, 204 });
    }
}
