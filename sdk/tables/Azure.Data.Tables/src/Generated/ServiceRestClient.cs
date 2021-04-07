// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Data.Tables.Models;

namespace Azure.Data.Tables
{
    internal partial class ServiceRestClient
    {
        private string url;
        private string version;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of ServiceRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="url"> The URL of the service account or table that is the target of the desired operation. </param>
        /// <param name="version"> Specifies the version of the operation to use for this request. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="url"/> or <paramref name="version"/> is null. </exception>
        public ServiceRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string url, string version = "2019-02-02")
        {
            if (url == null)
            {
                throw new ArgumentNullException(nameof(url));
            }
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }

            this.url = url;
            this.version = version;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateSetPropertiesRequest(TableServiceProperties tableServiceProperties, int? timeout)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(url, false);
            uri.AppendPath("/", false);
            uri.AppendQuery("restype", "service", true);
            uri.AppendQuery("comp", "properties", true);
            if (timeout != null)
            {
                uri.AppendQuery("timeout", timeout.Value, true);
            }
            request.Uri = uri;
            request.Headers.Add("x-ms-version", version);
            request.Headers.Add("Accept", "application/xml");
            request.Headers.Add("Content-Type", "application/xml");
            var content = new XmlWriterContent();
            content.XmlWriter.WriteObjectValue(tableServiceProperties, "StorageServiceProperties");
            request.Content = content;
            return message;
        }

        /// <summary> Sets properties for an account&apos;s Table service endpoint, including properties for Analytics and CORS (Cross-Origin Resource Sharing) rules. </summary>
        /// <param name="tableServiceProperties"> The Table Service properties. </param>
        /// <param name="timeout"> The timeout parameter is expressed in seconds. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tableServiceProperties"/> is null. </exception>
        public async Task<ResponseWithHeaders<ServiceSetPropertiesHeaders>> SetPropertiesAsync(TableServiceProperties tableServiceProperties, int? timeout = null, CancellationToken cancellationToken = default)
        {
            if (tableServiceProperties == null)
            {
                throw new ArgumentNullException(nameof(tableServiceProperties));
            }

            using var message = CreateSetPropertiesRequest(tableServiceProperties, timeout);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            var headers = new ServiceSetPropertiesHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 202:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Sets properties for an account&apos;s Table service endpoint, including properties for Analytics and CORS (Cross-Origin Resource Sharing) rules. </summary>
        /// <param name="tableServiceProperties"> The Table Service properties. </param>
        /// <param name="timeout"> The timeout parameter is expressed in seconds. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tableServiceProperties"/> is null. </exception>
        public ResponseWithHeaders<ServiceSetPropertiesHeaders> SetProperties(TableServiceProperties tableServiceProperties, int? timeout = null, CancellationToken cancellationToken = default)
        {
            if (tableServiceProperties == null)
            {
                throw new ArgumentNullException(nameof(tableServiceProperties));
            }

            using var message = CreateSetPropertiesRequest(tableServiceProperties, timeout);
            _pipeline.Send(message, cancellationToken);
            var headers = new ServiceSetPropertiesHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 202:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetPropertiesRequest(int? timeout)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(url, false);
            uri.AppendPath("/", false);
            uri.AppendQuery("restype", "service", true);
            uri.AppendQuery("comp", "properties", true);
            if (timeout != null)
            {
                uri.AppendQuery("timeout", timeout.Value, true);
            }
            request.Uri = uri;
            request.Headers.Add("x-ms-version", version);
            request.Headers.Add("Accept", "application/xml");
            return message;
        }

        /// <summary> Gets the properties of an account&apos;s Table service, including properties for Analytics and CORS (Cross-Origin Resource Sharing) rules. </summary>
        /// <param name="timeout"> The timeout parameter is expressed in seconds. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<ResponseWithHeaders<TableServiceProperties, ServiceGetPropertiesHeaders>> GetPropertiesAsync(int? timeout = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateGetPropertiesRequest(timeout);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            var headers = new ServiceGetPropertiesHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TableServiceProperties value = default;
                        var document = XDocument.Load(message.Response.ContentStream, LoadOptions.PreserveWhitespace);
                        if (document.Element("StorageServiceProperties") is XElement storageServicePropertiesElement)
                        {
                            value = TableServiceProperties.DeserializeTableServiceProperties(storageServicePropertiesElement);
                        }
                        return ResponseWithHeaders.FromValue(value, headers, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets the properties of an account&apos;s Table service, including properties for Analytics and CORS (Cross-Origin Resource Sharing) rules. </summary>
        /// <param name="timeout"> The timeout parameter is expressed in seconds. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public ResponseWithHeaders<TableServiceProperties, ServiceGetPropertiesHeaders> GetProperties(int? timeout = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateGetPropertiesRequest(timeout);
            _pipeline.Send(message, cancellationToken);
            var headers = new ServiceGetPropertiesHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TableServiceProperties value = default;
                        var document = XDocument.Load(message.Response.ContentStream, LoadOptions.PreserveWhitespace);
                        if (document.Element("StorageServiceProperties") is XElement storageServicePropertiesElement)
                        {
                            value = TableServiceProperties.DeserializeTableServiceProperties(storageServicePropertiesElement);
                        }
                        return ResponseWithHeaders.FromValue(value, headers, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetStatisticsRequest(int? timeout)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(url, false);
            uri.AppendPath("/", false);
            uri.AppendQuery("restype", "service", true);
            uri.AppendQuery("comp", "stats", true);
            if (timeout != null)
            {
                uri.AppendQuery("timeout", timeout.Value, true);
            }
            request.Uri = uri;
            request.Headers.Add("x-ms-version", version);
            request.Headers.Add("Accept", "application/xml");
            return message;
        }

        /// <summary> Retrieves statistics related to replication for the Table service. It is only available on the secondary location endpoint when read-access geo-redundant replication is enabled for the account. </summary>
        /// <param name="timeout"> The timeout parameter is expressed in seconds. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<ResponseWithHeaders<TableServiceStatistics, ServiceGetStatisticsHeaders>> GetStatisticsAsync(int? timeout = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateGetStatisticsRequest(timeout);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            var headers = new ServiceGetStatisticsHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TableServiceStatistics value = default;
                        var document = XDocument.Load(message.Response.ContentStream, LoadOptions.PreserveWhitespace);
                        if (document.Element("StorageServiceStats") is XElement storageServiceStatsElement)
                        {
                            value = TableServiceStatistics.DeserializeTableServiceStatistics(storageServiceStatsElement);
                        }
                        return ResponseWithHeaders.FromValue(value, headers, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Retrieves statistics related to replication for the Table service. It is only available on the secondary location endpoint when read-access geo-redundant replication is enabled for the account. </summary>
        /// <param name="timeout"> The timeout parameter is expressed in seconds. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public ResponseWithHeaders<TableServiceStatistics, ServiceGetStatisticsHeaders> GetStatistics(int? timeout = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateGetStatisticsRequest(timeout);
            _pipeline.Send(message, cancellationToken);
            var headers = new ServiceGetStatisticsHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TableServiceStatistics value = default;
                        var document = XDocument.Load(message.Response.ContentStream, LoadOptions.PreserveWhitespace);
                        if (document.Element("StorageServiceStats") is XElement storageServiceStatsElement)
                        {
                            value = TableServiceStatistics.DeserializeTableServiceStatistics(storageServiceStatsElement);
                        }
                        return ResponseWithHeaders.FromValue(value, headers, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
