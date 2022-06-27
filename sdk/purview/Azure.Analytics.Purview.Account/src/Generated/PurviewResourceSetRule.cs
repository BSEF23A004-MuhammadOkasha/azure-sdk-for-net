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
        private readonly string _apiVersion;

        /// <summary> The account endpoint of your Purview account. Example: https://{accountName}.purview.azure.com/account/. </summary>
        public Uri Endpoint { get; }

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
            Endpoint = endpoint;
            _apiVersion = apiVersion;
        }

        /// <summary> Get a resource set config service model. </summary>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <remarks>
        /// Below is the JSON schema for the response payload.
        /// 
        /// Response Body:
        /// 
        /// Schema for <c>ResourceSetRuleConfig</c>:
        /// <code>{
        ///   advancedResourceSet: {
        ///     modifiedAt: string (ISO 8601 Format), # Optional. Date at which ResourceSetProcessing property of the account is updated.
        ///     resourceSetProcessing: &quot;Default&quot; | &quot;Advanced&quot;, # Optional. The advanced resource property of the account.
        ///   }, # Optional. Gets or sets the advanced resource set property of the account.
        ///   name: string, # Optional. The name of the rule
        ///   pathPatternConfig: {
        ///     acceptedPatterns: [
        ///       {
        ///         createdBy: string, # Optional.
        ///         filterType: &quot;Pattern&quot; | &quot;Regex&quot;, # Optional.
        ///         lastUpdatedTimestamp: number, # Optional.
        ///         modifiedBy: string, # Optional.
        ///         name: string, # Required.
        ///         path: string, # Required.
        ///       }
        ///     ], # Optional.
        ///     complexReplacers: [
        ///       {
        ///         createdBy: string, # Optional.
        ///         description: string, # Optional.
        ///         disabled: boolean, # Optional.
        ///         disableRecursiveReplacerApplication: boolean, # Optional.
        ///         lastUpdatedTimestamp: number, # Optional.
        ///         modifiedBy: string, # Optional.
        ///         name: string, # Optional.
        ///         typeName: string, # Optional.
        ///       }
        ///     ], # Optional.
        ///     createdBy: string, # Required.
        ///     enableDefaultPatterns: boolean, # Required.
        ///     lastUpdatedTimestamp: number, # Optional.
        ///     modifiedBy: string, # Optional.
        ///     normalizationRules: [
        ///       {
        ///         description: string, # Optional.
        ///         disabled: boolean, # Optional.
        ///         dynamicReplacement: boolean, # Optional.
        ///         entityTypes: [string], # Optional.
        ///         lastUpdatedTimestamp: number, # Optional.
        ///         name: string, # Optional.
        ///         regex: {
        ///           maxDigits: number, # Optional.
        ///           maxLetters: number, # Optional.
        ///           minDashes: number, # Optional.
        ///           minDigits: number, # Optional.
        ///           minDigitsOrLetters: number, # Optional.
        ///           minDots: number, # Optional.
        ///           minHex: number, # Optional.
        ///           minLetters: number, # Optional.
        ///           minUnderscores: number, # Optional.
        ///           options: number, # Optional.
        ///           regexStr: string, # Optional.
        ///         }, # Optional.
        ///         replaceWith: string, # Optional.
        ///         version: number, # Optional.
        ///       }
        ///     ], # Optional.
        ///     regexReplacers: [
        ///       {
        ///         condition: string, # Optional.
        ///         createdBy: string, # Optional.
        ///         description: string, # Optional.
        ///         disabled: boolean, # Required.
        ///         disableRecursiveReplacerApplication: boolean, # Optional.
        ///         doNotReplaceRegex: FastRegex, # Optional.
        ///         lastUpdatedTimestamp: number, # Optional.
        ///         modifiedBy: string, # Optional.
        ///         name: string, # Required.
        ///         regex: FastRegex, # Optional.
        ///         replaceWith: string, # Optional.
        ///       }
        ///     ], # Optional.
        ///     rejectedPatterns: [Filter], # Optional.
        ///     scopedRules: [
        ///       {
        ///         bindingUrl: string, # Required.
        ///         rules: [
        ///           {
        ///             displayName: string, # Optional.
        ///             isResourceSet: boolean, # Optional.
        ///             lastUpdatedTimestamp: number, # Optional.
        ///             name: string, # Optional.
        ///             qualifiedName: string, # Required.
        ///           }
        ///         ], # Optional.
        ///         storeType: string, # Required.
        ///       }
        ///     ], # Optional.
        ///     version: number, # Optional.
        ///   }, # Optional. The configuration rules for path pattern extraction.
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
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <remarks>
        /// Below is the JSON schema for the response payload.
        /// 
        /// Response Body:
        /// 
        /// Schema for <c>ResourceSetRuleConfig</c>:
        /// <code>{
        ///   advancedResourceSet: {
        ///     modifiedAt: string (ISO 8601 Format), # Optional. Date at which ResourceSetProcessing property of the account is updated.
        ///     resourceSetProcessing: &quot;Default&quot; | &quot;Advanced&quot;, # Optional. The advanced resource property of the account.
        ///   }, # Optional. Gets or sets the advanced resource set property of the account.
        ///   name: string, # Optional. The name of the rule
        ///   pathPatternConfig: {
        ///     acceptedPatterns: [
        ///       {
        ///         createdBy: string, # Optional.
        ///         filterType: &quot;Pattern&quot; | &quot;Regex&quot;, # Optional.
        ///         lastUpdatedTimestamp: number, # Optional.
        ///         modifiedBy: string, # Optional.
        ///         name: string, # Required.
        ///         path: string, # Required.
        ///       }
        ///     ], # Optional.
        ///     complexReplacers: [
        ///       {
        ///         createdBy: string, # Optional.
        ///         description: string, # Optional.
        ///         disabled: boolean, # Optional.
        ///         disableRecursiveReplacerApplication: boolean, # Optional.
        ///         lastUpdatedTimestamp: number, # Optional.
        ///         modifiedBy: string, # Optional.
        ///         name: string, # Optional.
        ///         typeName: string, # Optional.
        ///       }
        ///     ], # Optional.
        ///     createdBy: string, # Required.
        ///     enableDefaultPatterns: boolean, # Required.
        ///     lastUpdatedTimestamp: number, # Optional.
        ///     modifiedBy: string, # Optional.
        ///     normalizationRules: [
        ///       {
        ///         description: string, # Optional.
        ///         disabled: boolean, # Optional.
        ///         dynamicReplacement: boolean, # Optional.
        ///         entityTypes: [string], # Optional.
        ///         lastUpdatedTimestamp: number, # Optional.
        ///         name: string, # Optional.
        ///         regex: {
        ///           maxDigits: number, # Optional.
        ///           maxLetters: number, # Optional.
        ///           minDashes: number, # Optional.
        ///           minDigits: number, # Optional.
        ///           minDigitsOrLetters: number, # Optional.
        ///           minDots: number, # Optional.
        ///           minHex: number, # Optional.
        ///           minLetters: number, # Optional.
        ///           minUnderscores: number, # Optional.
        ///           options: number, # Optional.
        ///           regexStr: string, # Optional.
        ///         }, # Optional.
        ///         replaceWith: string, # Optional.
        ///         version: number, # Optional.
        ///       }
        ///     ], # Optional.
        ///     regexReplacers: [
        ///       {
        ///         condition: string, # Optional.
        ///         createdBy: string, # Optional.
        ///         description: string, # Optional.
        ///         disabled: boolean, # Required.
        ///         disableRecursiveReplacerApplication: boolean, # Optional.
        ///         doNotReplaceRegex: FastRegex, # Optional.
        ///         lastUpdatedTimestamp: number, # Optional.
        ///         modifiedBy: string, # Optional.
        ///         name: string, # Required.
        ///         regex: FastRegex, # Optional.
        ///         replaceWith: string, # Optional.
        ///       }
        ///     ], # Optional.
        ///     rejectedPatterns: [Filter], # Optional.
        ///     scopedRules: [
        ///       {
        ///         bindingUrl: string, # Required.
        ///         rules: [
        ///           {
        ///             displayName: string, # Optional.
        ///             isResourceSet: boolean, # Optional.
        ///             lastUpdatedTimestamp: number, # Optional.
        ///             name: string, # Optional.
        ///             qualifiedName: string, # Required.
        ///           }
        ///         ], # Optional.
        ///         storeType: string, # Required.
        ///       }
        ///     ], # Optional.
        ///     version: number, # Optional.
        ///   }, # Optional. The configuration rules for path pattern extraction.
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
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <remarks>
        /// Below is the JSON schema for the request and response payloads.
        /// 
        /// Request Body:
        /// 
        /// Schema for <c>ResourceSetRuleConfig</c>:
        /// <code>{
        ///   advancedResourceSet: {
        ///     modifiedAt: string (ISO 8601 Format), # Optional. Date at which ResourceSetProcessing property of the account is updated.
        ///     resourceSetProcessing: &quot;Default&quot; | &quot;Advanced&quot;, # Optional. The advanced resource property of the account.
        ///   }, # Optional. Gets or sets the advanced resource set property of the account.
        ///   name: string, # Optional. The name of the rule
        ///   pathPatternConfig: {
        ///     acceptedPatterns: [
        ///       {
        ///         createdBy: string, # Optional.
        ///         filterType: &quot;Pattern&quot; | &quot;Regex&quot;, # Optional.
        ///         lastUpdatedTimestamp: number, # Optional.
        ///         modifiedBy: string, # Optional.
        ///         name: string, # Required.
        ///         path: string, # Required.
        ///       }
        ///     ], # Optional.
        ///     complexReplacers: [
        ///       {
        ///         createdBy: string, # Optional.
        ///         description: string, # Optional.
        ///         disabled: boolean, # Optional.
        ///         disableRecursiveReplacerApplication: boolean, # Optional.
        ///         lastUpdatedTimestamp: number, # Optional.
        ///         modifiedBy: string, # Optional.
        ///         name: string, # Optional.
        ///         typeName: string, # Optional.
        ///       }
        ///     ], # Optional.
        ///     createdBy: string, # Required.
        ///     enableDefaultPatterns: boolean, # Required.
        ///     lastUpdatedTimestamp: number, # Optional.
        ///     modifiedBy: string, # Optional.
        ///     normalizationRules: [
        ///       {
        ///         description: string, # Optional.
        ///         disabled: boolean, # Optional.
        ///         dynamicReplacement: boolean, # Optional.
        ///         entityTypes: [string], # Optional.
        ///         lastUpdatedTimestamp: number, # Optional.
        ///         name: string, # Optional.
        ///         regex: {
        ///           maxDigits: number, # Optional.
        ///           maxLetters: number, # Optional.
        ///           minDashes: number, # Optional.
        ///           minDigits: number, # Optional.
        ///           minDigitsOrLetters: number, # Optional.
        ///           minDots: number, # Optional.
        ///           minHex: number, # Optional.
        ///           minLetters: number, # Optional.
        ///           minUnderscores: number, # Optional.
        ///           options: number, # Optional.
        ///           regexStr: string, # Optional.
        ///         }, # Optional.
        ///         replaceWith: string, # Optional.
        ///         version: number, # Optional.
        ///       }
        ///     ], # Optional.
        ///     regexReplacers: [
        ///       {
        ///         condition: string, # Optional.
        ///         createdBy: string, # Optional.
        ///         description: string, # Optional.
        ///         disabled: boolean, # Required.
        ///         disableRecursiveReplacerApplication: boolean, # Optional.
        ///         doNotReplaceRegex: FastRegex, # Optional.
        ///         lastUpdatedTimestamp: number, # Optional.
        ///         modifiedBy: string, # Optional.
        ///         name: string, # Required.
        ///         regex: FastRegex, # Optional.
        ///         replaceWith: string, # Optional.
        ///       }
        ///     ], # Optional.
        ///     rejectedPatterns: [Filter], # Optional.
        ///     scopedRules: [
        ///       {
        ///         bindingUrl: string, # Required.
        ///         rules: [
        ///           {
        ///             displayName: string, # Optional.
        ///             isResourceSet: boolean, # Optional.
        ///             lastUpdatedTimestamp: number, # Optional.
        ///             name: string, # Optional.
        ///             qualifiedName: string, # Required.
        ///           }
        ///         ], # Optional.
        ///         storeType: string, # Required.
        ///       }
        ///     ], # Optional.
        ///     version: number, # Optional.
        ///   }, # Optional. The configuration rules for path pattern extraction.
        /// }
        /// </code>
        /// 
        /// Response Body:
        /// 
        /// Schema for <c>ResourceSetRuleConfig</c>:
        /// <code>{
        ///   advancedResourceSet: {
        ///     modifiedAt: string (ISO 8601 Format), # Optional. Date at which ResourceSetProcessing property of the account is updated.
        ///     resourceSetProcessing: &quot;Default&quot; | &quot;Advanced&quot;, # Optional. The advanced resource property of the account.
        ///   }, # Optional. Gets or sets the advanced resource set property of the account.
        ///   name: string, # Optional. The name of the rule
        ///   pathPatternConfig: {
        ///     acceptedPatterns: [
        ///       {
        ///         createdBy: string, # Optional.
        ///         filterType: &quot;Pattern&quot; | &quot;Regex&quot;, # Optional.
        ///         lastUpdatedTimestamp: number, # Optional.
        ///         modifiedBy: string, # Optional.
        ///         name: string, # Required.
        ///         path: string, # Required.
        ///       }
        ///     ], # Optional.
        ///     complexReplacers: [
        ///       {
        ///         createdBy: string, # Optional.
        ///         description: string, # Optional.
        ///         disabled: boolean, # Optional.
        ///         disableRecursiveReplacerApplication: boolean, # Optional.
        ///         lastUpdatedTimestamp: number, # Optional.
        ///         modifiedBy: string, # Optional.
        ///         name: string, # Optional.
        ///         typeName: string, # Optional.
        ///       }
        ///     ], # Optional.
        ///     createdBy: string, # Required.
        ///     enableDefaultPatterns: boolean, # Required.
        ///     lastUpdatedTimestamp: number, # Optional.
        ///     modifiedBy: string, # Optional.
        ///     normalizationRules: [
        ///       {
        ///         description: string, # Optional.
        ///         disabled: boolean, # Optional.
        ///         dynamicReplacement: boolean, # Optional.
        ///         entityTypes: [string], # Optional.
        ///         lastUpdatedTimestamp: number, # Optional.
        ///         name: string, # Optional.
        ///         regex: {
        ///           maxDigits: number, # Optional.
        ///           maxLetters: number, # Optional.
        ///           minDashes: number, # Optional.
        ///           minDigits: number, # Optional.
        ///           minDigitsOrLetters: number, # Optional.
        ///           minDots: number, # Optional.
        ///           minHex: number, # Optional.
        ///           minLetters: number, # Optional.
        ///           minUnderscores: number, # Optional.
        ///           options: number, # Optional.
        ///           regexStr: string, # Optional.
        ///         }, # Optional.
        ///         replaceWith: string, # Optional.
        ///         version: number, # Optional.
        ///       }
        ///     ], # Optional.
        ///     regexReplacers: [
        ///       {
        ///         condition: string, # Optional.
        ///         createdBy: string, # Optional.
        ///         description: string, # Optional.
        ///         disabled: boolean, # Required.
        ///         disableRecursiveReplacerApplication: boolean, # Optional.
        ///         doNotReplaceRegex: FastRegex, # Optional.
        ///         lastUpdatedTimestamp: number, # Optional.
        ///         modifiedBy: string, # Optional.
        ///         name: string, # Required.
        ///         regex: FastRegex, # Optional.
        ///         replaceWith: string, # Optional.
        ///       }
        ///     ], # Optional.
        ///     rejectedPatterns: [Filter], # Optional.
        ///     scopedRules: [
        ///       {
        ///         bindingUrl: string, # Required.
        ///         rules: [
        ///           {
        ///             displayName: string, # Optional.
        ///             isResourceSet: boolean, # Optional.
        ///             lastUpdatedTimestamp: number, # Optional.
        ///             name: string, # Optional.
        ///             qualifiedName: string, # Required.
        ///           }
        ///         ], # Optional.
        ///         storeType: string, # Required.
        ///       }
        ///     ], # Optional.
        ///     version: number, # Optional.
        ///   }, # Optional. The configuration rules for path pattern extraction.
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
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <remarks>
        /// Below is the JSON schema for the request and response payloads.
        /// 
        /// Request Body:
        /// 
        /// Schema for <c>ResourceSetRuleConfig</c>:
        /// <code>{
        ///   advancedResourceSet: {
        ///     modifiedAt: string (ISO 8601 Format), # Optional. Date at which ResourceSetProcessing property of the account is updated.
        ///     resourceSetProcessing: &quot;Default&quot; | &quot;Advanced&quot;, # Optional. The advanced resource property of the account.
        ///   }, # Optional. Gets or sets the advanced resource set property of the account.
        ///   name: string, # Optional. The name of the rule
        ///   pathPatternConfig: {
        ///     acceptedPatterns: [
        ///       {
        ///         createdBy: string, # Optional.
        ///         filterType: &quot;Pattern&quot; | &quot;Regex&quot;, # Optional.
        ///         lastUpdatedTimestamp: number, # Optional.
        ///         modifiedBy: string, # Optional.
        ///         name: string, # Required.
        ///         path: string, # Required.
        ///       }
        ///     ], # Optional.
        ///     complexReplacers: [
        ///       {
        ///         createdBy: string, # Optional.
        ///         description: string, # Optional.
        ///         disabled: boolean, # Optional.
        ///         disableRecursiveReplacerApplication: boolean, # Optional.
        ///         lastUpdatedTimestamp: number, # Optional.
        ///         modifiedBy: string, # Optional.
        ///         name: string, # Optional.
        ///         typeName: string, # Optional.
        ///       }
        ///     ], # Optional.
        ///     createdBy: string, # Required.
        ///     enableDefaultPatterns: boolean, # Required.
        ///     lastUpdatedTimestamp: number, # Optional.
        ///     modifiedBy: string, # Optional.
        ///     normalizationRules: [
        ///       {
        ///         description: string, # Optional.
        ///         disabled: boolean, # Optional.
        ///         dynamicReplacement: boolean, # Optional.
        ///         entityTypes: [string], # Optional.
        ///         lastUpdatedTimestamp: number, # Optional.
        ///         name: string, # Optional.
        ///         regex: {
        ///           maxDigits: number, # Optional.
        ///           maxLetters: number, # Optional.
        ///           minDashes: number, # Optional.
        ///           minDigits: number, # Optional.
        ///           minDigitsOrLetters: number, # Optional.
        ///           minDots: number, # Optional.
        ///           minHex: number, # Optional.
        ///           minLetters: number, # Optional.
        ///           minUnderscores: number, # Optional.
        ///           options: number, # Optional.
        ///           regexStr: string, # Optional.
        ///         }, # Optional.
        ///         replaceWith: string, # Optional.
        ///         version: number, # Optional.
        ///       }
        ///     ], # Optional.
        ///     regexReplacers: [
        ///       {
        ///         condition: string, # Optional.
        ///         createdBy: string, # Optional.
        ///         description: string, # Optional.
        ///         disabled: boolean, # Required.
        ///         disableRecursiveReplacerApplication: boolean, # Optional.
        ///         doNotReplaceRegex: FastRegex, # Optional.
        ///         lastUpdatedTimestamp: number, # Optional.
        ///         modifiedBy: string, # Optional.
        ///         name: string, # Required.
        ///         regex: FastRegex, # Optional.
        ///         replaceWith: string, # Optional.
        ///       }
        ///     ], # Optional.
        ///     rejectedPatterns: [Filter], # Optional.
        ///     scopedRules: [
        ///       {
        ///         bindingUrl: string, # Required.
        ///         rules: [
        ///           {
        ///             displayName: string, # Optional.
        ///             isResourceSet: boolean, # Optional.
        ///             lastUpdatedTimestamp: number, # Optional.
        ///             name: string, # Optional.
        ///             qualifiedName: string, # Required.
        ///           }
        ///         ], # Optional.
        ///         storeType: string, # Required.
        ///       }
        ///     ], # Optional.
        ///     version: number, # Optional.
        ///   }, # Optional. The configuration rules for path pattern extraction.
        /// }
        /// </code>
        /// 
        /// Response Body:
        /// 
        /// Schema for <c>ResourceSetRuleConfig</c>:
        /// <code>{
        ///   advancedResourceSet: {
        ///     modifiedAt: string (ISO 8601 Format), # Optional. Date at which ResourceSetProcessing property of the account is updated.
        ///     resourceSetProcessing: &quot;Default&quot; | &quot;Advanced&quot;, # Optional. The advanced resource property of the account.
        ///   }, # Optional. Gets or sets the advanced resource set property of the account.
        ///   name: string, # Optional. The name of the rule
        ///   pathPatternConfig: {
        ///     acceptedPatterns: [
        ///       {
        ///         createdBy: string, # Optional.
        ///         filterType: &quot;Pattern&quot; | &quot;Regex&quot;, # Optional.
        ///         lastUpdatedTimestamp: number, # Optional.
        ///         modifiedBy: string, # Optional.
        ///         name: string, # Required.
        ///         path: string, # Required.
        ///       }
        ///     ], # Optional.
        ///     complexReplacers: [
        ///       {
        ///         createdBy: string, # Optional.
        ///         description: string, # Optional.
        ///         disabled: boolean, # Optional.
        ///         disableRecursiveReplacerApplication: boolean, # Optional.
        ///         lastUpdatedTimestamp: number, # Optional.
        ///         modifiedBy: string, # Optional.
        ///         name: string, # Optional.
        ///         typeName: string, # Optional.
        ///       }
        ///     ], # Optional.
        ///     createdBy: string, # Required.
        ///     enableDefaultPatterns: boolean, # Required.
        ///     lastUpdatedTimestamp: number, # Optional.
        ///     modifiedBy: string, # Optional.
        ///     normalizationRules: [
        ///       {
        ///         description: string, # Optional.
        ///         disabled: boolean, # Optional.
        ///         dynamicReplacement: boolean, # Optional.
        ///         entityTypes: [string], # Optional.
        ///         lastUpdatedTimestamp: number, # Optional.
        ///         name: string, # Optional.
        ///         regex: {
        ///           maxDigits: number, # Optional.
        ///           maxLetters: number, # Optional.
        ///           minDashes: number, # Optional.
        ///           minDigits: number, # Optional.
        ///           minDigitsOrLetters: number, # Optional.
        ///           minDots: number, # Optional.
        ///           minHex: number, # Optional.
        ///           minLetters: number, # Optional.
        ///           minUnderscores: number, # Optional.
        ///           options: number, # Optional.
        ///           regexStr: string, # Optional.
        ///         }, # Optional.
        ///         replaceWith: string, # Optional.
        ///         version: number, # Optional.
        ///       }
        ///     ], # Optional.
        ///     regexReplacers: [
        ///       {
        ///         condition: string, # Optional.
        ///         createdBy: string, # Optional.
        ///         description: string, # Optional.
        ///         disabled: boolean, # Required.
        ///         disableRecursiveReplacerApplication: boolean, # Optional.
        ///         doNotReplaceRegex: FastRegex, # Optional.
        ///         lastUpdatedTimestamp: number, # Optional.
        ///         modifiedBy: string, # Optional.
        ///         name: string, # Required.
        ///         regex: FastRegex, # Optional.
        ///         replaceWith: string, # Optional.
        ///       }
        ///     ], # Optional.
        ///     rejectedPatterns: [Filter], # Optional.
        ///     scopedRules: [
        ///       {
        ///         bindingUrl: string, # Required.
        ///         rules: [
        ///           {
        ///             displayName: string, # Optional.
        ///             isResourceSet: boolean, # Optional.
        ///             lastUpdatedTimestamp: number, # Optional.
        ///             name: string, # Optional.
        ///             qualifiedName: string, # Required.
        ///           }
        ///         ], # Optional.
        ///         storeType: string, # Required.
        ///       }
        ///     ], # Optional.
        ///     version: number, # Optional.
        ///   }, # Optional. The configuration rules for path pattern extraction.
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
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
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
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
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
            uri.Reset(Endpoint);
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
            uri.Reset(Endpoint);
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
            uri.Reset(Endpoint);
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
