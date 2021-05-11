// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

#pragma warning disable AZC0007

namespace Azure.Storage.ConfidentialLedger
{
    /// <summary> The ConfidentialLedger service client. </summary>
    public partial class ConfidentialLedgerClient
    {
        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline { get; }
        private readonly string[] AuthorizationScopes = { "https://confidential-ledger.azure.com/.default" };
        private Uri ledgerUri;
        private readonly string apiVersion;

        /// <summary> Initializes a new instance of ConfidentialLedgerClient for mocking. </summary>
        protected ConfidentialLedgerClient()
        {
        }

        /// <summary> Initializes a new instance of ConfidentialLedgerClient. </summary>
        /// <param name="ledgerUri"> The Confidential Ledger URL, for example https://contoso.confidentialledger.azure.com. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public ConfidentialLedgerClient(Uri ledgerUri, TokenCredential credential, ConfidentialLedgerClientOptions options = null)
        {
            if (ledgerUri == null)
            {
                throw new ArgumentNullException(nameof(ledgerUri));
            }
            if (credential == null)
            {
                throw new ArgumentNullException(nameof(credential));
            }

            options ??= new ConfidentialLedgerClientOptions();
            Pipeline = HttpPipelineBuilder.Build(options, new BearerTokenAuthenticationPolicy(credential, AuthorizationScopes));
            this.ledgerUri = ledgerUri;
            apiVersion = options.Version;
        }

        /// <summary> The constitution is a script that assesses and applies proposals from consortium members. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> GetConstitutionAsync(CancellationToken cancellationToken = default)
        {
            Request req = CreateGetConstitutionRequest();
            return await Pipeline.SendRequestAsync(req, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> The constitution is a script that assesses and applies proposals from consortium members. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response GetConstitution(CancellationToken cancellationToken = default)
        {
            Request req = CreateGetConstitutionRequest();
            return Pipeline.SendRequest(req, cancellationToken);
        }

        /// <summary> Create Request for <see cref="GetConstitution"/> and <see cref="GetConstitutionAsync"/> operations. </summary>
        private Request CreateGetConstitutionRequest()
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(ledgerUri);
            uri.AppendPath("/app/governance/constitution", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return request;
        }

        /// <summary> Consortium members can manage the Confidential Ledger. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> GetConsortiumMembersAsync(CancellationToken cancellationToken = default)
        {
            Request req = CreateGetConsortiumMembersRequest();
            return await Pipeline.SendRequestAsync(req, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Consortium members can manage the Confidential Ledger. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response GetConsortiumMembers(CancellationToken cancellationToken = default)
        {
            Request req = CreateGetConsortiumMembersRequest();
            return Pipeline.SendRequest(req, cancellationToken);
        }

        /// <summary> Create Request for <see cref="GetConsortiumMembers"/> and <see cref="GetConsortiumMembersAsync"/> operations. </summary>
        private Request CreateGetConsortiumMembersRequest()
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(ledgerUri);
            uri.AppendPath("/app/governance/members", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return request;
        }

        /// <summary> A quote is an SGX enclave measurement that can be used to verify the validity of a node and its enclave. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> GetEnclaveQuotesAsync(CancellationToken cancellationToken = default)
        {
            Request req = CreateGetEnclaveQuotesRequest();
            return await Pipeline.SendRequestAsync(req, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> A quote is an SGX enclave measurement that can be used to verify the validity of a node and its enclave. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response GetEnclaveQuotes(CancellationToken cancellationToken = default)
        {
            Request req = CreateGetEnclaveQuotesRequest();
            return Pipeline.SendRequest(req, cancellationToken);
        }

        /// <summary> Create Request for <see cref="GetEnclaveQuotes"/> and <see cref="GetEnclaveQuotesAsync"/> operations. </summary>
        private Request CreateGetEnclaveQuotesRequest()
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(ledgerUri);
            uri.AppendPath("/app/enclaveQuotes", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return request;
        }

        /// <summary> A sub-ledger id may optionally be specified. Only entries in the specified (or default) sub-ledger will be returned. </summary>
        /// <param name="subLedgerId"> The sub-ledger id. </param>
        /// <param name="fromTransactionId"> Specify the first transaction ID in a range. </param>
        /// <param name="toTransactionId"> Specify the last transaction ID in a range. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> GetLedgerEntriesAsync(string subLedgerId = null, string fromTransactionId = null, string toTransactionId = null, CancellationToken cancellationToken = default)
        {
            Request req = CreateGetLedgerEntriesRequest(subLedgerId, fromTransactionId, toTransactionId);
            return await Pipeline.SendRequestAsync(req, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> A sub-ledger id may optionally be specified. Only entries in the specified (or default) sub-ledger will be returned. </summary>
        /// <param name="subLedgerId"> The sub-ledger id. </param>
        /// <param name="fromTransactionId"> Specify the first transaction ID in a range. </param>
        /// <param name="toTransactionId"> Specify the last transaction ID in a range. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response GetLedgerEntries(string subLedgerId = null, string fromTransactionId = null, string toTransactionId = null, CancellationToken cancellationToken = default)
        {
            Request req = CreateGetLedgerEntriesRequest(subLedgerId, fromTransactionId, toTransactionId);
            return Pipeline.SendRequest(req, cancellationToken);
        }

        /// <summary> Create Request for <see cref="GetLedgerEntries"/> and <see cref="GetLedgerEntriesAsync"/> operations. </summary>
        /// <param name="subLedgerId"> The sub-ledger id. </param>
        /// <param name="fromTransactionId"> Specify the first transaction ID in a range. </param>
        /// <param name="toTransactionId"> Specify the last transaction ID in a range. </param>
        private Request CreateGetLedgerEntriesRequest(string subLedgerId = null, string fromTransactionId = null, string toTransactionId = null)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(ledgerUri);
            uri.AppendPath("/app/transactions", false);
            uri.AppendQuery("api-version", apiVersion, true);
            if (subLedgerId != null)
            {
                uri.AppendQuery("subLedgerId", subLedgerId, true);
            }
            if (fromTransactionId != null)
            {
                uri.AppendQuery("fromTransactionId", fromTransactionId, true);
            }
            if (toTransactionId != null)
            {
                uri.AppendQuery("toTransactionId", toTransactionId, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return request;
        }

        /// <summary> A sub-ledger id may optionally be specified. </summary>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <list type="table">
        ///   <listeader>
        ///     <term>Name</term>
        ///     <term>Type</term>
        ///     <term>Required</term>
        ///     <term>Description</term>
        ///   </listeader>
        ///   <item>
        ///     <term>contents</term>
        ///     <term>string</term>
        ///     <term>Yes</term>
        ///     <term> Contents of the ledger entry. </term>
        ///   </item>
        ///   <item>
        ///     <term>subLedgerId</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term> Identifier for sub-ledgers. </term>
        ///   </item>
        ///   <item>
        ///     <term>transactionId</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term> A unique identifier for the state of the ledger. If returned as part of a LedgerEntry, it indicates the state from which the entry was read. </term>
        ///   </item>
        /// </list>
        /// </remarks>
        /// <param name="requestBody"> The request body. </param>
        /// <param name="subLedgerId"> The sub-ledger id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> PostLedgerEntryAsync(RequestContent requestBody, string subLedgerId = null, CancellationToken cancellationToken = default)
        {
            Request req = CreatePostLedgerEntryRequest(requestBody, subLedgerId);
            return await Pipeline.SendRequestAsync(req, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> A sub-ledger id may optionally be specified. </summary>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <list type="table">
        ///   <listeader>
        ///     <term>Name</term>
        ///     <term>Type</term>
        ///     <term>Required</term>
        ///     <term>Description</term>
        ///   </listeader>
        ///   <item>
        ///     <term>contents</term>
        ///     <term>string</term>
        ///     <term>Yes</term>
        ///     <term> Contents of the ledger entry. </term>
        ///   </item>
        ///   <item>
        ///     <term>subLedgerId</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term> Identifier for sub-ledgers. </term>
        ///   </item>
        ///   <item>
        ///     <term>transactionId</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term> A unique identifier for the state of the ledger. If returned as part of a LedgerEntry, it indicates the state from which the entry was read. </term>
        ///   </item>
        /// </list>
        /// </remarks>
        /// <param name="requestBody"> The request body. </param>
        /// <param name="subLedgerId"> The sub-ledger id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response PostLedgerEntry(RequestContent requestBody, string subLedgerId = null, CancellationToken cancellationToken = default)
        {
            Request req = CreatePostLedgerEntryRequest(requestBody, subLedgerId);
            return Pipeline.SendRequest(req, cancellationToken);
        }

        /// <summary> Create Request for <see cref="PostLedgerEntry"/> and <see cref="PostLedgerEntryAsync"/> operations. </summary>
        /// <param name="requestBody"> The request body. </param>
        /// <param name="subLedgerId"> The sub-ledger id. </param>
        private Request CreatePostLedgerEntryRequest(RequestContent requestBody, string subLedgerId = null)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(ledgerUri);
            uri.AppendPath("/app/transactions", false);
            uri.AppendQuery("api-version", apiVersion, true);
            if (subLedgerId != null)
            {
                uri.AppendQuery("subLedgerId", subLedgerId, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = requestBody;
            return request;
        }

        /// <summary> To return older ledger entries, the relevant sections of the ledger must be read from disk and validated. To prevent blocking within the enclave, the response will indicate whether the entry is ready and part of the response, or if the loading is still ongoing. </summary>
        /// <param name="transactionId"> Identifies a write transaction. </param>
        /// <param name="subLedgerId"> The sub-ledger id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> GetLedgerEntryAsync(string transactionId, string subLedgerId = null, CancellationToken cancellationToken = default)
        {
            Request req = CreateGetLedgerEntryRequest(transactionId, subLedgerId);
            return await Pipeline.SendRequestAsync(req, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> To return older ledger entries, the relevant sections of the ledger must be read from disk and validated. To prevent blocking within the enclave, the response will indicate whether the entry is ready and part of the response, or if the loading is still ongoing. </summary>
        /// <param name="transactionId"> Identifies a write transaction. </param>
        /// <param name="subLedgerId"> The sub-ledger id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response GetLedgerEntry(string transactionId, string subLedgerId = null, CancellationToken cancellationToken = default)
        {
            Request req = CreateGetLedgerEntryRequest(transactionId, subLedgerId);
            return Pipeline.SendRequest(req, cancellationToken);
        }

        /// <summary> Create Request for <see cref="GetLedgerEntry"/> and <see cref="GetLedgerEntryAsync"/> operations. </summary>
        /// <param name="transactionId"> Identifies a write transaction. </param>
        /// <param name="subLedgerId"> The sub-ledger id. </param>
        private Request CreateGetLedgerEntryRequest(string transactionId, string subLedgerId = null)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(ledgerUri);
            uri.AppendPath("/app/transactions/", false);
            uri.AppendPath(transactionId, true);
            uri.AppendQuery("api-version", apiVersion, true);
            if (subLedgerId != null)
            {
                uri.AppendQuery("subLedgerId", subLedgerId, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return request;
        }

        /// <summary> Gets a receipt certifying ledger contents at a particular transaction id. </summary>
        /// <param name="transactionId"> Identifies a write transaction. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> GetReceiptAsync(string transactionId, CancellationToken cancellationToken = default)
        {
            Request req = CreateGetReceiptRequest(transactionId);
            return await Pipeline.SendRequestAsync(req, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Gets a receipt certifying ledger contents at a particular transaction id. </summary>
        /// <param name="transactionId"> Identifies a write transaction. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response GetReceipt(string transactionId, CancellationToken cancellationToken = default)
        {
            Request req = CreateGetReceiptRequest(transactionId);
            return Pipeline.SendRequest(req, cancellationToken);
        }

        /// <summary> Create Request for <see cref="GetReceipt"/> and <see cref="GetReceiptAsync"/> operations. </summary>
        /// <param name="transactionId"> Identifies a write transaction. </param>
        private Request CreateGetReceiptRequest(string transactionId)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(ledgerUri);
            uri.AppendPath("/app/transactions/", false);
            uri.AppendPath(transactionId, true);
            uri.AppendPath("/receipt", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return request;
        }

        /// <summary> Gets the status of an entry identified by a transaction id. </summary>
        /// <param name="transactionId"> Identifies a write transaction. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> GetTransactionStatusAsync(string transactionId, CancellationToken cancellationToken = default)
        {
            Request req = CreateGetTransactionStatusRequest(transactionId);
            return await Pipeline.SendRequestAsync(req, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Gets the status of an entry identified by a transaction id. </summary>
        /// <param name="transactionId"> Identifies a write transaction. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response GetTransactionStatus(string transactionId, CancellationToken cancellationToken = default)
        {
            Request req = CreateGetTransactionStatusRequest(transactionId);
            return Pipeline.SendRequest(req, cancellationToken);
        }

        /// <summary> Create Request for <see cref="GetTransactionStatus"/> and <see cref="GetTransactionStatusAsync"/> operations. </summary>
        /// <param name="transactionId"> Identifies a write transaction. </param>
        private Request CreateGetTransactionStatusRequest(string transactionId)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(ledgerUri);
            uri.AppendPath("/app/transactions/", false);
            uri.AppendPath(transactionId, true);
            uri.AppendPath("/status", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return request;
        }

        /// <summary> A sub-ledger id may optionally be specified. </summary>
        /// <param name="subLedgerId"> The sub-ledger id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> GetCurrentLedgerEntryAsync(string subLedgerId = null, CancellationToken cancellationToken = default)
        {
            Request req = CreateGetCurrentLedgerEntryRequest(subLedgerId);
            return await Pipeline.SendRequestAsync(req, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> A sub-ledger id may optionally be specified. </summary>
        /// <param name="subLedgerId"> The sub-ledger id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response GetCurrentLedgerEntry(string subLedgerId = null, CancellationToken cancellationToken = default)
        {
            Request req = CreateGetCurrentLedgerEntryRequest(subLedgerId);
            return Pipeline.SendRequest(req, cancellationToken);
        }

        /// <summary> Create Request for <see cref="GetCurrentLedgerEntry"/> and <see cref="GetCurrentLedgerEntryAsync"/> operations. </summary>
        /// <param name="subLedgerId"> The sub-ledger id. </param>
        private Request CreateGetCurrentLedgerEntryRequest(string subLedgerId = null)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(ledgerUri);
            uri.AppendPath("/app/transactions/current", false);
            uri.AppendQuery("api-version", apiVersion, true);
            if (subLedgerId != null)
            {
                uri.AppendQuery("subLedgerId", subLedgerId, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return request;
        }

        /// <summary> Deletes a user from the Confidential Ledger. </summary>
        /// <param name="userId"> The user id, either an AAD object ID or certificate fingerprint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DeleteUserAsync(string userId, CancellationToken cancellationToken = default)
        {
            Request req = CreateDeleteUserRequest(userId);
            return await Pipeline.SendRequestAsync(req, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Deletes a user from the Confidential Ledger. </summary>
        /// <param name="userId"> The user id, either an AAD object ID or certificate fingerprint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response DeleteUser(string userId, CancellationToken cancellationToken = default)
        {
            Request req = CreateDeleteUserRequest(userId);
            return Pipeline.SendRequest(req, cancellationToken);
        }

        /// <summary> Create Request for <see cref="DeleteUser"/> and <see cref="DeleteUserAsync"/> operations. </summary>
        /// <param name="userId"> The user id, either an AAD object ID or certificate fingerprint. </param>
        private Request CreateDeleteUserRequest(string userId)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(ledgerUri);
            uri.AppendPath("/app/users/", false);
            uri.AppendPath(userId, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return request;
        }

        /// <summary> Gets a user. </summary>
        /// <param name="userId"> The user id, either an AAD object ID or certificate fingerprint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> GetUserAsync(string userId, CancellationToken cancellationToken = default)
        {
            Request req = CreateGetUserRequest(userId);
            return await Pipeline.SendRequestAsync(req, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Gets a user. </summary>
        /// <param name="userId"> The user id, either an AAD object ID or certificate fingerprint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response GetUser(string userId, CancellationToken cancellationToken = default)
        {
            Request req = CreateGetUserRequest(userId);
            return Pipeline.SendRequest(req, cancellationToken);
        }

        /// <summary> Create Request for <see cref="GetUser"/> and <see cref="GetUserAsync"/> operations. </summary>
        /// <param name="userId"> The user id, either an AAD object ID or certificate fingerprint. </param>
        private Request CreateGetUserRequest(string userId)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(ledgerUri);
            uri.AppendPath("/app/users/", false);
            uri.AppendPath(userId, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return request;
        }

        /// <summary> A JSON merge patch is applied for existing users. </summary>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <list type="table">
        ///   <listeader>
        ///     <term>Name</term>
        ///     <term>Type</term>
        ///     <term>Required</term>
        ///     <term>Description</term>
        ///   </listeader>
        ///   <item>
        ///     <term>assignedRole</term>
        ///     <term>&quot;Administrator&quot; | &quot;Contributor&quot; | &quot;Reader&quot;</term>
        ///     <term>Yes</term>
        ///     <term> Represents an assignable role. </term>
        ///   </item>
        ///   <item>
        ///     <term>userId</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term> Identifier for the user. This must either be an AAD object id or a certificate fingerprint. </term>
        ///   </item>
        /// </list>
        /// </remarks>
        /// <param name="userId"> The user id, either an AAD object ID or certificate fingerprint. </param>
        /// <param name="requestBody"> The request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> CreateOrUpdateUserAsync(string userId, RequestContent requestBody, CancellationToken cancellationToken = default)
        {
            Request req = CreateCreateOrUpdateUserRequest(userId, requestBody);
            return await Pipeline.SendRequestAsync(req, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> A JSON merge patch is applied for existing users. </summary>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <list type="table">
        ///   <listeader>
        ///     <term>Name</term>
        ///     <term>Type</term>
        ///     <term>Required</term>
        ///     <term>Description</term>
        ///   </listeader>
        ///   <item>
        ///     <term>assignedRole</term>
        ///     <term>&quot;Administrator&quot; | &quot;Contributor&quot; | &quot;Reader&quot;</term>
        ///     <term>Yes</term>
        ///     <term> Represents an assignable role. </term>
        ///   </item>
        ///   <item>
        ///     <term>userId</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term> Identifier for the user. This must either be an AAD object id or a certificate fingerprint. </term>
        ///   </item>
        /// </list>
        /// </remarks>
        /// <param name="userId"> The user id, either an AAD object ID or certificate fingerprint. </param>
        /// <param name="requestBody"> The request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response CreateOrUpdateUser(string userId, RequestContent requestBody, CancellationToken cancellationToken = default)
        {
            Request req = CreateCreateOrUpdateUserRequest(userId, requestBody);
            return Pipeline.SendRequest(req, cancellationToken);
        }

        /// <summary> Create Request for <see cref="CreateOrUpdateUser"/> and <see cref="CreateOrUpdateUserAsync"/> operations. </summary>
        /// <param name="userId"> The user id, either an AAD object ID or certificate fingerprint. </param>
        /// <param name="requestBody"> The request body. </param>
        private Request CreateCreateOrUpdateUserRequest(string userId, RequestContent requestBody)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.Reset(ledgerUri);
            uri.AppendPath("/app/users/", false);
            uri.AppendPath(userId, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = requestBody;
            return request;
        }
    }
}
