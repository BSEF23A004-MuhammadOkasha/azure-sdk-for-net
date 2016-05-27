// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Net;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// The Microsoft Azure Network management API provides a RESTful set of
    /// web services that interact with Microsoft Azure Networks service to
    /// manage your network resrources. The API has entities that capture the
    /// relationship between an end user and the Microsoft Azure Networks
    /// service.
    /// </summary>
    public partial class NetworkManagementClient : ServiceClient<NetworkManagementClient>, INetworkManagementClient, IAzureClient
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        public Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        public JsonSerializerSettings SerializationSettings { get; private set; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        public JsonSerializerSettings DeserializationSettings { get; private set; }        

        /// <summary>
        /// Gets Azure subscription credentials.
        /// </summary>
        public ServiceClientCredentials Credentials { get; private set; }

        /// <summary>
        /// Gets subscription credentials which uniquely identify Microsoft Azure
        /// subscription. The subscription ID forms part of the URI for every service
        /// call.
        /// </summary>
        public string SubscriptionId { get; set; }

        /// <summary>
        /// Client Api Version.
        /// </summary>
        public string ApiVersion { get; private set; }

        /// <summary>
        /// Gets or sets the preferred language for the response.
        /// </summary>
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// Gets or sets the retry timeout in seconds for Long Running Operations.
        /// Default value is 30.
        /// </summary>
        public int? LongRunningOperationRetryTimeout { get; set; }

        /// <summary>
        /// When set to true a unique x-ms-client-request-id value is generated and
        /// included in each request. Default is true.
        /// </summary>
        public bool? GenerateClientRequestId { get; set; }

        /// <summary>
        /// Gets the IApplicationGatewaysOperations.
        /// </summary>
        public virtual IApplicationGatewaysOperations ApplicationGateways { get; private set; }

        /// <summary>
        /// Gets the IExpressRouteCircuitAuthorizationsOperations.
        /// </summary>
        public virtual IExpressRouteCircuitAuthorizationsOperations ExpressRouteCircuitAuthorizations { get; private set; }

        /// <summary>
        /// Gets the IExpressRouteCircuitPeeringsOperations.
        /// </summary>
        public virtual IExpressRouteCircuitPeeringsOperations ExpressRouteCircuitPeerings { get; private set; }

        /// <summary>
        /// Gets the IExpressRouteCircuitsOperations.
        /// </summary>
        public virtual IExpressRouteCircuitsOperations ExpressRouteCircuits { get; private set; }

        /// <summary>
        /// Gets the IExpressRouteServiceProvidersOperations.
        /// </summary>
        public virtual IExpressRouteServiceProvidersOperations ExpressRouteServiceProviders { get; private set; }

        /// <summary>
        /// Gets the ILoadBalancersOperations.
        /// </summary>
        public virtual ILoadBalancersOperations LoadBalancers { get; private set; }

        /// <summary>
        /// Gets the ILocalNetworkGatewaysOperations.
        /// </summary>
        public virtual ILocalNetworkGatewaysOperations LocalNetworkGateways { get; private set; }

        /// <summary>
        /// Gets the INetworkInterfacesOperations.
        /// </summary>
        public virtual INetworkInterfacesOperations NetworkInterfaces { get; private set; }

        /// <summary>
        /// Gets the INetworkSecurityGroupsOperations.
        /// </summary>
        public virtual INetworkSecurityGroupsOperations NetworkSecurityGroups { get; private set; }

        /// <summary>
        /// Gets the IPublicIPAddressesOperations.
        /// </summary>
        public virtual IPublicIPAddressesOperations PublicIPAddresses { get; private set; }

        /// <summary>
        /// Gets the IRouteTablesOperations.
        /// </summary>
        public virtual IRouteTablesOperations RouteTables { get; private set; }

        /// <summary>
        /// Gets the IRoutesOperations.
        /// </summary>
        public virtual IRoutesOperations Routes { get; private set; }

        /// <summary>
        /// Gets the ISecurityRulesOperations.
        /// </summary>
        public virtual ISecurityRulesOperations SecurityRules { get; private set; }

        /// <summary>
        /// Gets the ISubnetsOperations.
        /// </summary>
        public virtual ISubnetsOperations Subnets { get; private set; }

        /// <summary>
        /// Gets the IUsagesOperations.
        /// </summary>
        public virtual IUsagesOperations Usages { get; private set; }

        /// <summary>
        /// Gets the IVirtualNetworkGatewayConnectionsOperations.
        /// </summary>
        public virtual IVirtualNetworkGatewayConnectionsOperations VirtualNetworkGatewayConnections { get; private set; }

        /// <summary>
        /// Gets the IVirtualNetworkGatewaysOperations.
        /// </summary>
        public virtual IVirtualNetworkGatewaysOperations VirtualNetworkGateways { get; private set; }

        /// <summary>
        /// Gets the IVirtualNetworksOperations.
        /// </summary>
        public virtual IVirtualNetworksOperations VirtualNetworks { get; private set; }

        /// <summary>
        /// Initializes a new instance of the NetworkManagementClient class.
        /// </summary>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        protected NetworkManagementClient(params DelegatingHandler[] handlers) : base(handlers)
        {
            this.Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the NetworkManagementClient class.
        /// </summary>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        protected NetworkManagementClient(HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : base(rootHandler, handlers)
        {
            this.Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the NetworkManagementClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        protected NetworkManagementClient(Uri baseUri, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            this.BaseUri = baseUri;
        }

        /// <summary>
        /// Initializes a new instance of the NetworkManagementClient class.
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
        protected NetworkManagementClient(Uri baseUri, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            this.BaseUri = baseUri;
        }

        /// <summary>
        /// Initializes a new instance of the NetworkManagementClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Gets Azure subscription credentials.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        public NetworkManagementClient(ServiceClientCredentials credentials, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            this.Credentials = credentials;
            if (this.Credentials != null)
            {
                this.Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the NetworkManagementClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Gets Azure subscription credentials.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        public NetworkManagementClient(ServiceClientCredentials credentials, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            this.Credentials = credentials;
            if (this.Credentials != null)
            {
                this.Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the NetworkManagementClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='credentials'>
        /// Required. Gets Azure subscription credentials.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        public NetworkManagementClient(Uri baseUri, ServiceClientCredentials credentials, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            this.BaseUri = baseUri;
            this.Credentials = credentials;
            if (this.Credentials != null)
            {
                this.Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the NetworkManagementClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='credentials'>
        /// Required. Gets Azure subscription credentials.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        public NetworkManagementClient(Uri baseUri, ServiceClientCredentials credentials, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            this.BaseUri = baseUri;
            this.Credentials = credentials;
            if (this.Credentials != null)
            {
                this.Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes client properties.
        /// </summary>
        private void Initialize()
        {
            this.ApplicationGateways = new ApplicationGatewaysOperations(this);
            this.ExpressRouteCircuitAuthorizations = new ExpressRouteCircuitAuthorizationsOperations(this);
            this.ExpressRouteCircuitPeerings = new ExpressRouteCircuitPeeringsOperations(this);
            this.ExpressRouteCircuits = new ExpressRouteCircuitsOperations(this);
            this.ExpressRouteServiceProviders = new ExpressRouteServiceProvidersOperations(this);
            this.LoadBalancers = new LoadBalancersOperations(this);
            this.LocalNetworkGateways = new LocalNetworkGatewaysOperations(this);
            this.NetworkInterfaces = new NetworkInterfacesOperations(this);
            this.NetworkSecurityGroups = new NetworkSecurityGroupsOperations(this);
            this.PublicIPAddresses = new PublicIPAddressesOperations(this);
            this.RouteTables = new RouteTablesOperations(this);
            this.Routes = new RoutesOperations(this);
            this.SecurityRules = new SecurityRulesOperations(this);
            this.Subnets = new SubnetsOperations(this);
            this.Usages = new UsagesOperations(this);
            this.VirtualNetworkGatewayConnections = new VirtualNetworkGatewayConnectionsOperations(this);
            this.VirtualNetworkGateways = new VirtualNetworkGatewaysOperations(this);
            this.VirtualNetworks = new VirtualNetworksOperations(this);
            this.BaseUri = new Uri("https://management.azure.com");
            this.ApiVersion = "2016-03-30";
            this.AcceptLanguage = "en-US";
            this.LongRunningOperationRetryTimeout = 30;
            this.GenerateClientRequestId = true;
            SerializationSettings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                DateFormatHandling = DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = DateTimeZoneHandling.Utc,
                NullValueHandling = NullValueHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            SerializationSettings.Converters.Add(new TransformationJsonConverter());
            DeserializationSettings = new JsonSerializerSettings
            {
                DateFormatHandling = DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = DateTimeZoneHandling.Utc,
                NullValueHandling = NullValueHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            DeserializationSettings.Converters.Add(new TransformationJsonConverter());
            DeserializationSettings.Converters.Add(new CloudErrorJsonConverter()); 
        }    
        /// <summary>
        /// Checks whether a domain name in the cloudapp.net zone is available for use.
        /// </summary>
        /// <param name='location'>
        /// The location of the domain name
        /// </param>
        /// <param name='domainNameLabel'>
        /// The domain name to be verified. It must conform to the following regular
        /// expression: ^[a-z][a-z0-9-]{1,61}[a-z0-9]$.
        /// </param>
        /// <param name='customHeaders'>
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <return>
        /// A response object containing the response body and response headers.
        /// </return>
        public async Task<AzureOperationResponse<DnsNameAvailabilityResult>> CheckDnsNameAvailabilityWithHttpMessagesAsync(string location, string domainNameLabel = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (location == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "location");
            }
            if (this.ApiVersion == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "this.ApiVersion");
            }
            if (this.SubscriptionId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "this.SubscriptionId");
            }
            // Tracing
            bool _shouldTrace = ServiceClientTracing.IsEnabled;
            string _invocationId = null;
            if (_shouldTrace)
            {
                _invocationId = ServiceClientTracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("location", location);
                tracingParameters.Add("domainNameLabel", domainNameLabel);
                tracingParameters.Add("cancellationToken", cancellationToken);
                ServiceClientTracing.Enter(_invocationId, this, "CheckDnsNameAvailability", tracingParameters);
            }
            // Construct URL
            var _baseUrl = this.BaseUri.AbsoluteUri;
            var _url = new Uri(new Uri(_baseUrl + (_baseUrl.EndsWith("/") ? "" : "/")), "subscriptions/{subscriptionId}/providers/Microsoft.Network/locations/{location}/CheckDnsNameAvailability").ToString();
            _url = _url.Replace("{location}", Uri.EscapeDataString(location));
            _url = _url.Replace("{subscriptionId}", Uri.EscapeDataString(this.SubscriptionId));
            List<string> _queryParameters = new List<string>();
            if (domainNameLabel != null)
            {
                _queryParameters.Add(string.Format("domainNameLabel={0}", Uri.EscapeDataString(domainNameLabel)));
            }
            if (this.ApiVersion != null)
            {
                _queryParameters.Add(string.Format("api-version={0}", Uri.EscapeDataString(this.ApiVersion)));
            }
            if (_queryParameters.Count > 0)
            {
                _url += "?" + string.Join("&", _queryParameters);
            }
            // Create HTTP transport objects
            HttpRequestMessage _httpRequest = new HttpRequestMessage();
            HttpResponseMessage _httpResponse = null;
            _httpRequest.Method = new HttpMethod("GET");
            _httpRequest.RequestUri = new Uri(_url);
            // Set Headers
            if (this.GenerateClientRequestId != null && this.GenerateClientRequestId.Value)
            {
                _httpRequest.Headers.TryAddWithoutValidation("x-ms-client-request-id", Guid.NewGuid().ToString());
            }
            if (this.AcceptLanguage != null)
            {
                if (_httpRequest.Headers.Contains("accept-language"))
                {
                    _httpRequest.Headers.Remove("accept-language");
                }
                _httpRequest.Headers.TryAddWithoutValidation("accept-language", this.AcceptLanguage);
            }
            if (customHeaders != null)
            {
                foreach(var _header in customHeaders)
                {
                    if (_httpRequest.Headers.Contains(_header.Key))
                    {
                        _httpRequest.Headers.Remove(_header.Key);
                    }
                    _httpRequest.Headers.TryAddWithoutValidation(_header.Key, _header.Value);
                }
            }

            // Serialize Request
            string _requestContent = null;
            // Set Credentials
            if (this.Credentials != null)
            {
                cancellationToken.ThrowIfCancellationRequested();
                await this.Credentials.ProcessHttpRequestAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
            }
            // Send Request
            if (_shouldTrace)
            {
                ServiceClientTracing.SendRequest(_invocationId, _httpRequest);
            }
            cancellationToken.ThrowIfCancellationRequested();
            _httpResponse = await this.HttpClient.SendAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
            if (_shouldTrace)
            {
                ServiceClientTracing.ReceiveResponse(_invocationId, _httpResponse);
            }
            HttpStatusCode _statusCode = _httpResponse.StatusCode;
            cancellationToken.ThrowIfCancellationRequested();
            string _responseContent = null;
            if ((int)_statusCode != 200)
            {
                var ex = new CloudException(string.Format("Operation returned an invalid status code '{0}'", _statusCode));
                try
                {
                    _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                    CloudError _errorBody = SafeJsonConvert.DeserializeObject<CloudError>(_responseContent, this.DeserializationSettings);
                    if (_errorBody != null)
                    {
                        ex = new CloudException(_errorBody.Message);
                        ex.Body = _errorBody;
                    }
                }
                catch (JsonException)
                {
                    // Ignore the exception
                }
                ex.Request = new HttpRequestMessageWrapper(_httpRequest, _requestContent);
                ex.Response = new HttpResponseMessageWrapper(_httpResponse, _responseContent);
                if (_httpResponse.Headers.Contains("x-ms-request-id"))
                {
                    ex.RequestId = _httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
                }
                if (_shouldTrace)
                {
                    ServiceClientTracing.Error(_invocationId, ex);
                }
                _httpRequest.Dispose();
                if (_httpResponse != null)
                {
                    _httpResponse.Dispose();
                }
                throw ex;
            }
            // Create Result
            var _result = new AzureOperationResponse<DnsNameAvailabilityResult>();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;
            if (_httpResponse.Headers.Contains("x-ms-request-id"))
            {
                _result.RequestId = _httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
            }
            // Deserialize Response
            if ((int)_statusCode == 200)
            {
                _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    _result.Body = SafeJsonConvert.DeserializeObject<DnsNameAvailabilityResult>(_responseContent, this.DeserializationSettings);
                }
                catch (JsonException ex)
                {
                    _httpRequest.Dispose();
                    if (_httpResponse != null)
                    {
                        _httpResponse.Dispose();
                    }
                    throw new SerializationException("Unable to deserialize the response.", _responseContent, ex);
                }
            }
            if (_shouldTrace)
            {
                ServiceClientTracing.Exit(_invocationId, _result);
            }
            return _result;
        }

    }
}
