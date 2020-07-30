// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;

    /// <summary>
    /// ApiManagement Client
    /// </summary>
    public partial class ApiManagementClient : ServiceClient<ApiManagementClient>, IApiManagementClient, IAzureClient
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        public System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        public JsonSerializerSettings SerializationSettings { get; private set; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        public JsonSerializerSettings DeserializationSettings { get; private set; }

        /// <summary>
        /// Credentials needed for the client to connect to Azure.
        /// </summary>
        public ServiceClientCredentials Credentials { get; private set; }

        /// <summary>
        /// Version of the API to be used with the client request.
        /// </summary>
        public string ApiVersion { get; private set; }

        /// <summary>
        /// Subscription credentials which uniquely identify Microsoft Azure
        /// subscription. The subscription ID forms part of the URI for every service
        /// call.
        /// </summary>
        public string SubscriptionId { get; set; }

        /// <summary>
        /// The preferred language for the response.
        /// </summary>
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// The retry timeout in seconds for Long Running Operations. Default value is
        /// 30.
        /// </summary>
        public int? LongRunningOperationRetryTimeout { get; set; }

        /// <summary>
        /// Whether a unique x-ms-client-request-id should be generated. When set to
        /// true a unique x-ms-client-request-id value is generated and included in
        /// each request. Default is true.
        /// </summary>
        public bool? GenerateClientRequestId { get; set; }

        /// <summary>
        /// Gets the IApiOperations.
        /// </summary>
        public virtual IApiOperations Api { get; private set; }

        /// <summary>
        /// Gets the IApiRevisionOperations.
        /// </summary>
        public virtual IApiRevisionOperations ApiRevision { get; private set; }

        /// <summary>
        /// Gets the IApiReleaseOperations.
        /// </summary>
        public virtual IApiReleaseOperations ApiRelease { get; private set; }

        /// <summary>
        /// Gets the IApiOperationOperations.
        /// </summary>
        public virtual IApiOperationOperations ApiOperation { get; private set; }

        /// <summary>
        /// Gets the IApiOperationPolicyOperations.
        /// </summary>
        public virtual IApiOperationPolicyOperations ApiOperationPolicy { get; private set; }

        /// <summary>
        /// Gets the ITagOperations.
        /// </summary>
        public virtual ITagOperations Tag { get; private set; }

        /// <summary>
        /// Gets the IApiProductOperations.
        /// </summary>
        public virtual IApiProductOperations ApiProduct { get; private set; }

        /// <summary>
        /// Gets the IApiPolicyOperations.
        /// </summary>
        public virtual IApiPolicyOperations ApiPolicy { get; private set; }

        /// <summary>
        /// Gets the IApiSchemaOperations.
        /// </summary>
        public virtual IApiSchemaOperations ApiSchema { get; private set; }

        /// <summary>
        /// Gets the IApiDiagnosticOperations.
        /// </summary>
        public virtual IApiDiagnosticOperations ApiDiagnostic { get; private set; }

        /// <summary>
        /// Gets the IApiIssueOperations.
        /// </summary>
        public virtual IApiIssueOperations ApiIssue { get; private set; }

        /// <summary>
        /// Gets the IApiIssueCommentOperations.
        /// </summary>
        public virtual IApiIssueCommentOperations ApiIssueComment { get; private set; }

        /// <summary>
        /// Gets the IApiIssueAttachmentOperations.
        /// </summary>
        public virtual IApiIssueAttachmentOperations ApiIssueAttachment { get; private set; }

        /// <summary>
        /// Gets the IApiTagDescriptionOperations.
        /// </summary>
        public virtual IApiTagDescriptionOperations ApiTagDescription { get; private set; }

        /// <summary>
        /// Gets the IOperationOperations.
        /// </summary>
        public virtual IOperationOperations Operation { get; private set; }

        /// <summary>
        /// Gets the IApiVersionSetOperations.
        /// </summary>
        public virtual IApiVersionSetOperations ApiVersionSet { get; private set; }

        /// <summary>
        /// Gets the IAuthorizationServerOperations.
        /// </summary>
        public virtual IAuthorizationServerOperations AuthorizationServer { get; private set; }

        /// <summary>
        /// Gets the IBackendOperations.
        /// </summary>
        public virtual IBackendOperations Backend { get; private set; }

        /// <summary>
        /// Gets the ICacheOperations.
        /// </summary>
        public virtual ICacheOperations Cache { get; private set; }

        /// <summary>
        /// Gets the ICertificateOperations.
        /// </summary>
        public virtual ICertificateOperations Certificate { get; private set; }

        /// <summary>
        /// Gets the IApiManagementOperations.
        /// </summary>
        public virtual IApiManagementOperations ApiManagementOperations { get; private set; }

        /// <summary>
        /// Gets the IApiManagementServiceSkusOperations.
        /// </summary>
        public virtual IApiManagementServiceSkusOperations ApiManagementServiceSkus { get; private set; }

        /// <summary>
        /// Gets the IApiManagementServiceOperations.
        /// </summary>
        public virtual IApiManagementServiceOperations ApiManagementService { get; private set; }

        /// <summary>
        /// Gets the IDiagnosticOperations.
        /// </summary>
        public virtual IDiagnosticOperations Diagnostic { get; private set; }

        /// <summary>
        /// Gets the IEmailTemplateOperations.
        /// </summary>
        public virtual IEmailTemplateOperations EmailTemplate { get; private set; }

        /// <summary>
        /// Gets the IGatewayOperations.
        /// </summary>
        public virtual IGatewayOperations Gateway { get; private set; }

        /// <summary>
        /// Gets the IGatewayHostnameConfigurationOperations.
        /// </summary>
        public virtual IGatewayHostnameConfigurationOperations GatewayHostnameConfiguration { get; private set; }

        /// <summary>
        /// Gets the IGatewayApiOperations.
        /// </summary>
        public virtual IGatewayApiOperations GatewayApi { get; private set; }

        /// <summary>
        /// Gets the IGroupOperations.
        /// </summary>
        public virtual IGroupOperations Group { get; private set; }

        /// <summary>
        /// Gets the IGroupUserOperations.
        /// </summary>
        public virtual IGroupUserOperations GroupUser { get; private set; }

        /// <summary>
        /// Gets the IIdentityProviderOperations.
        /// </summary>
        public virtual IIdentityProviderOperations IdentityProvider { get; private set; }

        /// <summary>
        /// Gets the IIssueOperations.
        /// </summary>
        public virtual IIssueOperations Issue { get; private set; }

        /// <summary>
        /// Gets the ILoggerOperations.
        /// </summary>
        public virtual ILoggerOperations Logger { get; private set; }

        /// <summary>
        /// Gets the INamedValueOperations.
        /// </summary>
        public virtual INamedValueOperations NamedValue { get; private set; }

        /// <summary>
        /// Gets the INetworkStatusOperations.
        /// </summary>
        public virtual INetworkStatusOperations NetworkStatus { get; private set; }

        /// <summary>
        /// Gets the INotificationOperations.
        /// </summary>
        public virtual INotificationOperations Notification { get; private set; }

        /// <summary>
        /// Gets the INotificationRecipientUserOperations.
        /// </summary>
        public virtual INotificationRecipientUserOperations NotificationRecipientUser { get; private set; }

        /// <summary>
        /// Gets the INotificationRecipientEmailOperations.
        /// </summary>
        public virtual INotificationRecipientEmailOperations NotificationRecipientEmail { get; private set; }

        /// <summary>
        /// Gets the IOpenIdConnectProviderOperations.
        /// </summary>
        public virtual IOpenIdConnectProviderOperations OpenIdConnectProvider { get; private set; }

        /// <summary>
        /// Gets the IPolicyOperations.
        /// </summary>
        public virtual IPolicyOperations Policy { get; private set; }

        /// <summary>
        /// Gets the IPolicyDescriptionOperations.
        /// </summary>
        public virtual IPolicyDescriptionOperations PolicyDescription { get; private set; }

        /// <summary>
        /// Gets the ISignInSettingsOperations.
        /// </summary>
        public virtual ISignInSettingsOperations SignInSettings { get; private set; }

        /// <summary>
        /// Gets the ISignUpSettingsOperations.
        /// </summary>
        public virtual ISignUpSettingsOperations SignUpSettings { get; private set; }

        /// <summary>
        /// Gets the IDelegationSettingsOperations.
        /// </summary>
        public virtual IDelegationSettingsOperations DelegationSettings { get; private set; }

        /// <summary>
        /// Gets the IProductOperations.
        /// </summary>
        public virtual IProductOperations Product { get; private set; }

        /// <summary>
        /// Gets the IProductApiOperations.
        /// </summary>
        public virtual IProductApiOperations ProductApi { get; private set; }

        /// <summary>
        /// Gets the IProductGroupOperations.
        /// </summary>
        public virtual IProductGroupOperations ProductGroup { get; private set; }

        /// <summary>
        /// Gets the IProductSubscriptionsOperations.
        /// </summary>
        public virtual IProductSubscriptionsOperations ProductSubscriptions { get; private set; }

        /// <summary>
        /// Gets the IProductPolicyOperations.
        /// </summary>
        public virtual IProductPolicyOperations ProductPolicy { get; private set; }

        /// <summary>
        /// Gets the IQuotaByCounterKeysOperations.
        /// </summary>
        public virtual IQuotaByCounterKeysOperations QuotaByCounterKeys { get; private set; }

        /// <summary>
        /// Gets the IQuotaByPeriodKeysOperations.
        /// </summary>
        public virtual IQuotaByPeriodKeysOperations QuotaByPeriodKeys { get; private set; }

        /// <summary>
        /// Gets the IRegionOperations.
        /// </summary>
        public virtual IRegionOperations Region { get; private set; }

        /// <summary>
        /// Gets the IReportsOperations.
        /// </summary>
        public virtual IReportsOperations Reports { get; private set; }

        /// <summary>
        /// Gets the ISubscriptionOperations.
        /// </summary>
        public virtual ISubscriptionOperations Subscription { get; private set; }

        /// <summary>
        /// Gets the ITagResourceOperations.
        /// </summary>
        public virtual ITagResourceOperations TagResource { get; private set; }

        /// <summary>
        /// Gets the ITenantAccessOperations.
        /// </summary>
        public virtual ITenantAccessOperations TenantAccess { get; private set; }

        /// <summary>
        /// Gets the ITenantAccessGitOperations.
        /// </summary>
        public virtual ITenantAccessGitOperations TenantAccessGit { get; private set; }

        /// <summary>
        /// Gets the ITenantConfigurationOperations.
        /// </summary>
        public virtual ITenantConfigurationOperations TenantConfiguration { get; private set; }

        /// <summary>
        /// Gets the IUserOperations.
        /// </summary>
        public virtual IUserOperations User { get; private set; }

        /// <summary>
        /// Gets the IUserGroupOperations.
        /// </summary>
        public virtual IUserGroupOperations UserGroup { get; private set; }

        /// <summary>
        /// Gets the IUserSubscriptionOperations.
        /// </summary>
        public virtual IUserSubscriptionOperations UserSubscription { get; private set; }

        /// <summary>
        /// Gets the IUserIdentitiesOperations.
        /// </summary>
        public virtual IUserIdentitiesOperations UserIdentities { get; private set; }

        /// <summary>
        /// Gets the IUserConfirmationPasswordOperations.
        /// </summary>
        public virtual IUserConfirmationPasswordOperations UserConfirmationPassword { get; private set; }

        /// <summary>
        /// Gets the IApiExportOperations.
        /// </summary>
        public virtual IApiExportOperations ApiExport { get; private set; }

        /// <summary>
        /// Initializes a new instance of the ApiManagementClient class.
        /// </summary>
        /// <param name='httpClient'>
        /// HttpClient to be used
        /// </param>
        /// <param name='disposeHttpClient'>
        /// True: will dispose the provided httpClient on calling ApiManagementClient.Dispose(). False: will not dispose provided httpClient</param>
        protected ApiManagementClient(HttpClient httpClient, bool disposeHttpClient) : base(httpClient, disposeHttpClient)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the ApiManagementClient class.
        /// </summary>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        protected ApiManagementClient(params DelegatingHandler[] handlers) : base(handlers)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the ApiManagementClient class.
        /// </summary>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        protected ApiManagementClient(HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : base(rootHandler, handlers)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the ApiManagementClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        protected ApiManagementClient(System.Uri baseUri, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            BaseUri = baseUri;
        }

        /// <summary>
        /// Initializes a new instance of the ApiManagementClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        protected ApiManagementClient(System.Uri baseUri, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            BaseUri = baseUri;
        }

        /// <summary>
        /// Initializes a new instance of the ApiManagementClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public ApiManagementClient(ServiceClientCredentials credentials, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the ApiManagementClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='httpClient'>
        /// HttpClient to be used
        /// </param>
        /// <param name='disposeHttpClient'>
        /// True: will dispose the provided httpClient on calling ApiManagementClient.Dispose(). False: will not dispose provided httpClient</param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public ApiManagementClient(ServiceClientCredentials credentials, HttpClient httpClient, bool disposeHttpClient) : this(httpClient, disposeHttpClient)
        {
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the ApiManagementClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public ApiManagementClient(ServiceClientCredentials credentials, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the ApiManagementClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public ApiManagementClient(System.Uri baseUri, ServiceClientCredentials credentials, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            BaseUri = baseUri;
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the ApiManagementClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public ApiManagementClient(System.Uri baseUri, ServiceClientCredentials credentials, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            BaseUri = baseUri;
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// An optional partial-method to perform custom initialization.
        /// </summary>
        partial void CustomInitialize();
        /// <summary>
        /// Initializes client properties.
        /// </summary>
        private void Initialize()
        {
            Api = new ApiOperations(this);
            ApiRevision = new ApiRevisionOperations(this);
            ApiRelease = new ApiReleaseOperations(this);
            ApiOperation = new ApiOperationOperations(this);
            ApiOperationPolicy = new ApiOperationPolicyOperations(this);
            Tag = new TagOperations(this);
            ApiProduct = new ApiProductOperations(this);
            ApiPolicy = new ApiPolicyOperations(this);
            ApiSchema = new ApiSchemaOperations(this);
            ApiDiagnostic = new ApiDiagnosticOperations(this);
            ApiIssue = new ApiIssueOperations(this);
            ApiIssueComment = new ApiIssueCommentOperations(this);
            ApiIssueAttachment = new ApiIssueAttachmentOperations(this);
            ApiTagDescription = new ApiTagDescriptionOperations(this);
            Operation = new OperationOperations(this);
            ApiVersionSet = new ApiVersionSetOperations(this);
            AuthorizationServer = new AuthorizationServerOperations(this);
            Backend = new BackendOperations(this);
            Cache = new CacheOperations(this);
            Certificate = new CertificateOperations(this);
            ApiManagementOperations = new ApiManagementOperations(this);
            ApiManagementServiceSkus = new ApiManagementServiceSkusOperations(this);
            ApiManagementService = new ApiManagementServiceOperations(this);
            Diagnostic = new DiagnosticOperations(this);
            EmailTemplate = new EmailTemplateOperations(this);
            Gateway = new GatewayOperations(this);
            GatewayHostnameConfiguration = new GatewayHostnameConfigurationOperations(this);
            GatewayApi = new GatewayApiOperations(this);
            Group = new GroupOperations(this);
            GroupUser = new GroupUserOperations(this);
            IdentityProvider = new IdentityProviderOperations(this);
            Issue = new IssueOperations(this);
            Logger = new LoggerOperations(this);
            NamedValue = new NamedValueOperations(this);
            NetworkStatus = new NetworkStatusOperations(this);
            Notification = new NotificationOperations(this);
            NotificationRecipientUser = new NotificationRecipientUserOperations(this);
            NotificationRecipientEmail = new NotificationRecipientEmailOperations(this);
            OpenIdConnectProvider = new OpenIdConnectProviderOperations(this);
            Policy = new PolicyOperations(this);
            PolicyDescription = new PolicyDescriptionOperations(this);
            SignInSettings = new SignInSettingsOperations(this);
            SignUpSettings = new SignUpSettingsOperations(this);
            DelegationSettings = new DelegationSettingsOperations(this);
            Product = new ProductOperations(this);
            ProductApi = new ProductApiOperations(this);
            ProductGroup = new ProductGroupOperations(this);
            ProductSubscriptions = new ProductSubscriptionsOperations(this);
            ProductPolicy = new ProductPolicyOperations(this);
            QuotaByCounterKeys = new QuotaByCounterKeysOperations(this);
            QuotaByPeriodKeys = new QuotaByPeriodKeysOperations(this);
            Region = new RegionOperations(this);
            Reports = new ReportsOperations(this);
            Subscription = new SubscriptionOperations(this);
            TagResource = new TagResourceOperations(this);
            TenantAccess = new TenantAccessOperations(this);
            TenantAccessGit = new TenantAccessGitOperations(this);
            TenantConfiguration = new TenantConfigurationOperations(this);
            User = new UserOperations(this);
            UserGroup = new UserGroupOperations(this);
            UserSubscription = new UserSubscriptionOperations(this);
            UserIdentities = new UserIdentitiesOperations(this);
            UserConfirmationPassword = new UserConfirmationPasswordOperations(this);
            ApiExport = new ApiExportOperations(this);
            BaseUri = new System.Uri("https://management.azure.com");
            ApiVersion = "2019-12-01";
            AcceptLanguage = "en-US";
            LongRunningOperationRetryTimeout = 30;
            GenerateClientRequestId = true;
            SerializationSettings = new JsonSerializerSettings
            {
                Formatting = Newtonsoft.Json.Formatting.Indented,
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            SerializationSettings.Converters.Add(new TransformationJsonConverter());
            DeserializationSettings = new JsonSerializerSettings
            {
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            CustomInitialize();
            DeserializationSettings.Converters.Add(new TransformationJsonConverter());
            DeserializationSettings.Converters.Add(new CloudErrorJsonConverter());
        }
    }
}
