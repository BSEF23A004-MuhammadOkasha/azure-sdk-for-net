// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Communication.PhoneNumbers
{
    /// <summary> The InternalPhoneNumbers service client. </summary>
    internal partial class InternalPhoneNumbersClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal InternalPhoneNumbersRestClient RestClient { get; }

        /// <summary> Initializes a new instance of InternalPhoneNumbersClient for mocking. </summary>
        protected InternalPhoneNumbersClient()
        {
        }

        /// <summary> Initializes a new instance of InternalPhoneNumbersClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> The communication resource, for example https://resourcename.communication.azure.com. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/>, <paramref name="endpoint"/> or <paramref name="apiVersion"/> is null. </exception>
        internal InternalPhoneNumbersClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string endpoint, string apiVersion = "2022-12-01")
        {
            RestClient = new InternalPhoneNumbersRestClient(clientDiagnostics, pipeline, endpoint, apiVersion);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Gets a phone number search result by search id. </summary>
        /// <param name="searchId"> The search Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<PhoneNumberSearchResult>> GetSearchResultAsync(string searchId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("InternalPhoneNumbersClient.GetSearchResult");
            scope.Start();
            try
            {
                return await RestClient.GetSearchResultAsync(searchId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a phone number search result by search id. </summary>
        /// <param name="searchId"> The search Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PhoneNumberSearchResult> GetSearchResult(string searchId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("InternalPhoneNumbersClient.GetSearchResult");
            scope.Start();
            try
            {
                return RestClient.GetSearchResult(searchId, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the details of the given purchased phone number. </summary>
        /// <param name="phoneNumber"> The purchased phone number whose details are to be fetched in E.164 format, e.g. +11234567890. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<PurchasedPhoneNumber>> GetByNumberAsync(string phoneNumber, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("InternalPhoneNumbersClient.GetByNumber");
            scope.Start();
            try
            {
                return await RestClient.GetByNumberAsync(phoneNumber, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the details of the given purchased phone number. </summary>
        /// <param name="phoneNumber"> The purchased phone number whose details are to be fetched in E.164 format, e.g. +11234567890. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PurchasedPhoneNumber> GetByNumber(string phoneNumber, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("InternalPhoneNumbersClient.GetByNumber");
            scope.Start();
            try
            {
                return RestClient.GetByNumber(phoneNumber, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the list of available area codes. </summary>
        /// <param name="twoLetterIsoCountryName"> The ISO 3166-2 country code, e.g. US. </param>
        /// <param name="phoneNumberType"> Filter by numberType, e.g. Geographic, TollFree. </param>
        /// <param name="skip"> An optional parameter for how many entries to skip, for pagination purposes. The default value is 0. </param>
        /// <param name="maxPageSize"> An optional parameter for how many entries to return, for pagination purposes. The default value is 100. </param>
        /// <param name="assignmentType"> Filter by assignmentType, e.g. Person, Application. </param>
        /// <param name="locality"> The name of locality or town in which to search for the area code. This is required if the number type is Geographic. </param>
        /// <param name="administrativeDivision"> The name of the state or province in which to search for the area code. </param>
        /// <param name="acceptLanguage"> The locale to display in the localized fields in the response. e.g. 'en-US'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="twoLetterIsoCountryName"/> is null. </exception>
        public virtual AsyncPageable<PhoneNumberAreaCode> ListAreaCodesAsync(string twoLetterIsoCountryName, PhoneNumberType phoneNumberType, int? skip = null, int? maxPageSize = null, PhoneNumberAssignmentType? assignmentType = null, string locality = null, string administrativeDivision = null, string acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(twoLetterIsoCountryName, nameof(twoLetterIsoCountryName));

            HttpMessage FirstPageRequest(int? pageSizeHint) => RestClient.CreateListAreaCodesRequest(twoLetterIsoCountryName, phoneNumberType, skip, maxPageSize, assignmentType, locality, administrativeDivision, acceptLanguage);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => RestClient.CreateListAreaCodesNextPageRequest(nextLink, twoLetterIsoCountryName, phoneNumberType, skip, maxPageSize, assignmentType, locality, administrativeDivision, acceptLanguage);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, PhoneNumberAreaCode.DeserializePhoneNumberAreaCode, _clientDiagnostics, _pipeline, "InternalPhoneNumbersClient.ListAreaCodes", "areaCodes", "nextLink", cancellationToken);
        }

        /// <summary> Gets the list of available area codes. </summary>
        /// <param name="twoLetterIsoCountryName"> The ISO 3166-2 country code, e.g. US. </param>
        /// <param name="phoneNumberType"> Filter by numberType, e.g. Geographic, TollFree. </param>
        /// <param name="skip"> An optional parameter for how many entries to skip, for pagination purposes. The default value is 0. </param>
        /// <param name="maxPageSize"> An optional parameter for how many entries to return, for pagination purposes. The default value is 100. </param>
        /// <param name="assignmentType"> Filter by assignmentType, e.g. Person, Application. </param>
        /// <param name="locality"> The name of locality or town in which to search for the area code. This is required if the number type is Geographic. </param>
        /// <param name="administrativeDivision"> The name of the state or province in which to search for the area code. </param>
        /// <param name="acceptLanguage"> The locale to display in the localized fields in the response. e.g. 'en-US'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="twoLetterIsoCountryName"/> is null. </exception>
        public virtual Pageable<PhoneNumberAreaCode> ListAreaCodes(string twoLetterIsoCountryName, PhoneNumberType phoneNumberType, int? skip = null, int? maxPageSize = null, PhoneNumberAssignmentType? assignmentType = null, string locality = null, string administrativeDivision = null, string acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(twoLetterIsoCountryName, nameof(twoLetterIsoCountryName));

            HttpMessage FirstPageRequest(int? pageSizeHint) => RestClient.CreateListAreaCodesRequest(twoLetterIsoCountryName, phoneNumberType, skip, maxPageSize, assignmentType, locality, administrativeDivision, acceptLanguage);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => RestClient.CreateListAreaCodesNextPageRequest(nextLink, twoLetterIsoCountryName, phoneNumberType, skip, maxPageSize, assignmentType, locality, administrativeDivision, acceptLanguage);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, PhoneNumberAreaCode.DeserializePhoneNumberAreaCode, _clientDiagnostics, _pipeline, "InternalPhoneNumbersClient.ListAreaCodes", "areaCodes", "nextLink", cancellationToken);
        }

        /// <summary> Gets the list of supported countries. </summary>
        /// <param name="skip"> An optional parameter for how many entries to skip, for pagination purposes. The default value is 0. </param>
        /// <param name="maxPageSize"> An optional parameter for how many entries to return, for pagination purposes. The default value is 100. </param>
        /// <param name="acceptLanguage"> The locale to display in the localized fields in the response. e.g. 'en-US'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<PhoneNumberCountry> ListAvailableCountriesAsync(int? skip = null, int? maxPageSize = null, string acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => RestClient.CreateListAvailableCountriesRequest(skip, maxPageSize, acceptLanguage);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => RestClient.CreateListAvailableCountriesNextPageRequest(nextLink, skip, maxPageSize, acceptLanguage);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, PhoneNumberCountry.DeserializePhoneNumberCountry, _clientDiagnostics, _pipeline, "InternalPhoneNumbersClient.ListAvailableCountries", "countries", "nextLink", cancellationToken);
        }

        /// <summary> Gets the list of supported countries. </summary>
        /// <param name="skip"> An optional parameter for how many entries to skip, for pagination purposes. The default value is 0. </param>
        /// <param name="maxPageSize"> An optional parameter for how many entries to return, for pagination purposes. The default value is 100. </param>
        /// <param name="acceptLanguage"> The locale to display in the localized fields in the response. e.g. 'en-US'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<PhoneNumberCountry> ListAvailableCountries(int? skip = null, int? maxPageSize = null, string acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => RestClient.CreateListAvailableCountriesRequest(skip, maxPageSize, acceptLanguage);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => RestClient.CreateListAvailableCountriesNextPageRequest(nextLink, skip, maxPageSize, acceptLanguage);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, PhoneNumberCountry.DeserializePhoneNumberCountry, _clientDiagnostics, _pipeline, "InternalPhoneNumbersClient.ListAvailableCountries", "countries", "nextLink", cancellationToken);
        }

        /// <summary> Gets the list of cities or towns with available phone numbers. </summary>
        /// <param name="twoLetterIsoCountryName"> The ISO 3166-2 country code, e.g. US. </param>
        /// <param name="skip"> An optional parameter for how many entries to skip, for pagination purposes. The default value is 0. </param>
        /// <param name="maxPageSize"> An optional parameter for how many entries to return, for pagination purposes. The default value is 100. </param>
        /// <param name="administrativeDivision"> An optional parameter for the name of the state or province in which to search for the area code. </param>
        /// <param name="acceptLanguage"> The locale to display in the localized fields in the response. e.g. 'en-US'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="twoLetterIsoCountryName"/> is null. </exception>
        public virtual AsyncPageable<PhoneNumberLocality> ListAvailableLocalitiesAsync(string twoLetterIsoCountryName, int? skip = null, int? maxPageSize = null, string administrativeDivision = null, string acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(twoLetterIsoCountryName, nameof(twoLetterIsoCountryName));

            HttpMessage FirstPageRequest(int? pageSizeHint) => RestClient.CreateListAvailableLocalitiesRequest(twoLetterIsoCountryName, skip, maxPageSize, administrativeDivision, acceptLanguage);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => RestClient.CreateListAvailableLocalitiesNextPageRequest(nextLink, twoLetterIsoCountryName, skip, maxPageSize, administrativeDivision, acceptLanguage);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, PhoneNumberLocality.DeserializePhoneNumberLocality, _clientDiagnostics, _pipeline, "InternalPhoneNumbersClient.ListAvailableLocalities", "phoneNumberLocalities", "nextLink", cancellationToken);
        }

        /// <summary> Gets the list of cities or towns with available phone numbers. </summary>
        /// <param name="twoLetterIsoCountryName"> The ISO 3166-2 country code, e.g. US. </param>
        /// <param name="skip"> An optional parameter for how many entries to skip, for pagination purposes. The default value is 0. </param>
        /// <param name="maxPageSize"> An optional parameter for how many entries to return, for pagination purposes. The default value is 100. </param>
        /// <param name="administrativeDivision"> An optional parameter for the name of the state or province in which to search for the area code. </param>
        /// <param name="acceptLanguage"> The locale to display in the localized fields in the response. e.g. 'en-US'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="twoLetterIsoCountryName"/> is null. </exception>
        public virtual Pageable<PhoneNumberLocality> ListAvailableLocalities(string twoLetterIsoCountryName, int? skip = null, int? maxPageSize = null, string administrativeDivision = null, string acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(twoLetterIsoCountryName, nameof(twoLetterIsoCountryName));

            HttpMessage FirstPageRequest(int? pageSizeHint) => RestClient.CreateListAvailableLocalitiesRequest(twoLetterIsoCountryName, skip, maxPageSize, administrativeDivision, acceptLanguage);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => RestClient.CreateListAvailableLocalitiesNextPageRequest(nextLink, twoLetterIsoCountryName, skip, maxPageSize, administrativeDivision, acceptLanguage);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, PhoneNumberLocality.DeserializePhoneNumberLocality, _clientDiagnostics, _pipeline, "InternalPhoneNumbersClient.ListAvailableLocalities", "phoneNumberLocalities", "nextLink", cancellationToken);
        }

        /// <summary> List available offerings of capabilities with rates for the given country. </summary>
        /// <param name="twoLetterIsoCountryName"> The ISO 3166-2 country code, e.g. US. </param>
        /// <param name="skip"> An optional parameter for how many entries to skip, for pagination purposes. The default value is 0. </param>
        /// <param name="maxPageSize"> An optional parameter for how many entries to return, for pagination purposes. The default value is 100. </param>
        /// <param name="phoneNumberType"> Filter by numberType, e.g. Geographic, TollFree. </param>
        /// <param name="assignmentType"> Filter by assignmentType, e.g. Person, Application. </param>
        /// <param name="acceptLanguage"> The locale to display in the localized fields in the response. e.g. 'en-US'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="twoLetterIsoCountryName"/> is null. </exception>
        public virtual AsyncPageable<PhoneNumberOffering> ListOfferingsAsync(string twoLetterIsoCountryName, int? skip = null, int? maxPageSize = null, PhoneNumberType? phoneNumberType = null, PhoneNumberAssignmentType? assignmentType = null, string acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(twoLetterIsoCountryName, nameof(twoLetterIsoCountryName));

            HttpMessage FirstPageRequest(int? pageSizeHint) => RestClient.CreateListOfferingsRequest(twoLetterIsoCountryName, skip, maxPageSize, phoneNumberType, assignmentType, acceptLanguage);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => RestClient.CreateListOfferingsNextPageRequest(nextLink, twoLetterIsoCountryName, skip, maxPageSize, phoneNumberType, assignmentType, acceptLanguage);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, PhoneNumberOffering.DeserializePhoneNumberOffering, _clientDiagnostics, _pipeline, "InternalPhoneNumbersClient.ListOfferings", "phoneNumberOfferings", "nextLink", cancellationToken);
        }

        /// <summary> List available offerings of capabilities with rates for the given country. </summary>
        /// <param name="twoLetterIsoCountryName"> The ISO 3166-2 country code, e.g. US. </param>
        /// <param name="skip"> An optional parameter for how many entries to skip, for pagination purposes. The default value is 0. </param>
        /// <param name="maxPageSize"> An optional parameter for how many entries to return, for pagination purposes. The default value is 100. </param>
        /// <param name="phoneNumberType"> Filter by numberType, e.g. Geographic, TollFree. </param>
        /// <param name="assignmentType"> Filter by assignmentType, e.g. Person, Application. </param>
        /// <param name="acceptLanguage"> The locale to display in the localized fields in the response. e.g. 'en-US'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="twoLetterIsoCountryName"/> is null. </exception>
        public virtual Pageable<PhoneNumberOffering> ListOfferings(string twoLetterIsoCountryName, int? skip = null, int? maxPageSize = null, PhoneNumberType? phoneNumberType = null, PhoneNumberAssignmentType? assignmentType = null, string acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(twoLetterIsoCountryName, nameof(twoLetterIsoCountryName));

            HttpMessage FirstPageRequest(int? pageSizeHint) => RestClient.CreateListOfferingsRequest(twoLetterIsoCountryName, skip, maxPageSize, phoneNumberType, assignmentType, acceptLanguage);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => RestClient.CreateListOfferingsNextPageRequest(nextLink, twoLetterIsoCountryName, skip, maxPageSize, phoneNumberType, assignmentType, acceptLanguage);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, PhoneNumberOffering.DeserializePhoneNumberOffering, _clientDiagnostics, _pipeline, "InternalPhoneNumbersClient.ListOfferings", "phoneNumberOfferings", "nextLink", cancellationToken);
        }

        /// <summary> Gets the list of all purchased phone numbers. </summary>
        /// <param name="skip"> An optional parameter for how many entries to skip, for pagination purposes. The default value is 0. </param>
        /// <param name="top"> An optional parameter for how many entries to return, for pagination purposes. The default value is 100. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<PurchasedPhoneNumber> ListPhoneNumbersAsync(int? skip = null, int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => RestClient.CreateListPhoneNumbersRequest(skip, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => RestClient.CreateListPhoneNumbersNextPageRequest(nextLink, skip, top);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, PurchasedPhoneNumber.DeserializePurchasedPhoneNumber, _clientDiagnostics, _pipeline, "InternalPhoneNumbersClient.ListPhoneNumbers", "phoneNumbers", "nextLink", cancellationToken);
        }

        /// <summary> Gets the list of all purchased phone numbers. </summary>
        /// <param name="skip"> An optional parameter for how many entries to skip, for pagination purposes. The default value is 0. </param>
        /// <param name="top"> An optional parameter for how many entries to return, for pagination purposes. The default value is 100. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<PurchasedPhoneNumber> ListPhoneNumbers(int? skip = null, int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => RestClient.CreateListPhoneNumbersRequest(skip, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => RestClient.CreateListPhoneNumbersNextPageRequest(nextLink, skip, top);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, PurchasedPhoneNumber.DeserializePurchasedPhoneNumber, _clientDiagnostics, _pipeline, "InternalPhoneNumbersClient.ListPhoneNumbers", "phoneNumbers", "nextLink", cancellationToken);
        }

        /// <summary> Search for available phone numbers to purchase. </summary>
        /// <param name="twoLetterIsoCountryName"> The ISO 3166-2 country code, e.g. US. </param>
        /// <param name="body"> The phone number search request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="twoLetterIsoCountryName"/> or <paramref name="body"/> is null. </exception>
        public virtual async Task<SearchAvailablePhoneNumbersOperation> StartSearchAvailablePhoneNumbersAsync(string twoLetterIsoCountryName, PhoneNumberSearchRequest body, CancellationToken cancellationToken = default)
        {
            if (twoLetterIsoCountryName == null)
            {
                throw new ArgumentNullException(nameof(twoLetterIsoCountryName));
            }
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            using var scope = _clientDiagnostics.CreateScope("InternalPhoneNumbersClient.StartSearchAvailablePhoneNumbers");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.SearchAvailablePhoneNumbersAsync(twoLetterIsoCountryName, body, cancellationToken).ConfigureAwait(false);
                return new SearchAvailablePhoneNumbersOperation(_clientDiagnostics, _pipeline, RestClient.CreateSearchAvailablePhoneNumbersRequest(twoLetterIsoCountryName, body).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Search for available phone numbers to purchase. </summary>
        /// <param name="twoLetterIsoCountryName"> The ISO 3166-2 country code, e.g. US. </param>
        /// <param name="body"> The phone number search request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="twoLetterIsoCountryName"/> or <paramref name="body"/> is null. </exception>
        public virtual SearchAvailablePhoneNumbersOperation StartSearchAvailablePhoneNumbers(string twoLetterIsoCountryName, PhoneNumberSearchRequest body, CancellationToken cancellationToken = default)
        {
            if (twoLetterIsoCountryName == null)
            {
                throw new ArgumentNullException(nameof(twoLetterIsoCountryName));
            }
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            using var scope = _clientDiagnostics.CreateScope("InternalPhoneNumbersClient.StartSearchAvailablePhoneNumbers");
            scope.Start();
            try
            {
                var originalResponse = RestClient.SearchAvailablePhoneNumbers(twoLetterIsoCountryName, body, cancellationToken);
                return new SearchAvailablePhoneNumbersOperation(_clientDiagnostics, _pipeline, RestClient.CreateSearchAvailablePhoneNumbersRequest(twoLetterIsoCountryName, body).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Purchases phone numbers. </summary>
        /// <param name="searchId"> The search id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<InternalPurchasePhoneNumbersOperation> StartPurchasePhoneNumbersAsync(string searchId = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("InternalPhoneNumbersClient.StartPurchasePhoneNumbers");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.PurchasePhoneNumbersAsync(searchId, cancellationToken).ConfigureAwait(false);
                return new InternalPurchasePhoneNumbersOperation(_clientDiagnostics, _pipeline, RestClient.CreatePurchasePhoneNumbersRequest(searchId).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Purchases phone numbers. </summary>
        /// <param name="searchId"> The search id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual InternalPurchasePhoneNumbersOperation StartPurchasePhoneNumbers(string searchId = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("InternalPhoneNumbersClient.StartPurchasePhoneNumbers");
            scope.Start();
            try
            {
                var originalResponse = RestClient.PurchasePhoneNumbers(searchId, cancellationToken);
                return new InternalPurchasePhoneNumbersOperation(_clientDiagnostics, _pipeline, RestClient.CreatePurchasePhoneNumbersRequest(searchId).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates the capabilities of a phone number. </summary>
        /// <param name="phoneNumber"> The phone number id in E.164 format. The leading plus can be either + or encoded as %2B, e.g. +11234567890. </param>
        /// <param name="calling"> Capability value for calling. </param>
        /// <param name="sms"> Capability value for SMS. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="phoneNumber"/> is null. </exception>
        public virtual async Task<UpdatePhoneNumberCapabilitiesOperation> StartUpdateCapabilitiesAsync(string phoneNumber, PhoneNumberCapabilityType? calling = null, PhoneNumberCapabilityType? sms = null, CancellationToken cancellationToken = default)
        {
            if (phoneNumber == null)
            {
                throw new ArgumentNullException(nameof(phoneNumber));
            }

            using var scope = _clientDiagnostics.CreateScope("InternalPhoneNumbersClient.StartUpdateCapabilities");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.UpdateCapabilitiesAsync(phoneNumber, calling, sms, cancellationToken).ConfigureAwait(false);
                return new UpdatePhoneNumberCapabilitiesOperation(_clientDiagnostics, _pipeline, RestClient.CreateUpdateCapabilitiesRequest(phoneNumber, calling, sms).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates the capabilities of a phone number. </summary>
        /// <param name="phoneNumber"> The phone number id in E.164 format. The leading plus can be either + or encoded as %2B, e.g. +11234567890. </param>
        /// <param name="calling"> Capability value for calling. </param>
        /// <param name="sms"> Capability value for SMS. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="phoneNumber"/> is null. </exception>
        public virtual UpdatePhoneNumberCapabilitiesOperation StartUpdateCapabilities(string phoneNumber, PhoneNumberCapabilityType? calling = null, PhoneNumberCapabilityType? sms = null, CancellationToken cancellationToken = default)
        {
            if (phoneNumber == null)
            {
                throw new ArgumentNullException(nameof(phoneNumber));
            }

            using var scope = _clientDiagnostics.CreateScope("InternalPhoneNumbersClient.StartUpdateCapabilities");
            scope.Start();
            try
            {
                var originalResponse = RestClient.UpdateCapabilities(phoneNumber, calling, sms, cancellationToken);
                return new UpdatePhoneNumberCapabilitiesOperation(_clientDiagnostics, _pipeline, RestClient.CreateUpdateCapabilitiesRequest(phoneNumber, calling, sms).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Releases a purchased phone number. </summary>
        /// <param name="phoneNumber"> Phone number to be released, e.g. +11234567890. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="phoneNumber"/> is null. </exception>
        public virtual async Task<InternalReleasePhoneNumberOperation> StartReleasePhoneNumberAsync(string phoneNumber, CancellationToken cancellationToken = default)
        {
            if (phoneNumber == null)
            {
                throw new ArgumentNullException(nameof(phoneNumber));
            }

            using var scope = _clientDiagnostics.CreateScope("InternalPhoneNumbersClient.StartReleasePhoneNumber");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.ReleasePhoneNumberAsync(phoneNumber, cancellationToken).ConfigureAwait(false);
                return new InternalReleasePhoneNumberOperation(_clientDiagnostics, _pipeline, RestClient.CreateReleasePhoneNumberRequest(phoneNumber).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Releases a purchased phone number. </summary>
        /// <param name="phoneNumber"> Phone number to be released, e.g. +11234567890. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="phoneNumber"/> is null. </exception>
        public virtual InternalReleasePhoneNumberOperation StartReleasePhoneNumber(string phoneNumber, CancellationToken cancellationToken = default)
        {
            if (phoneNumber == null)
            {
                throw new ArgumentNullException(nameof(phoneNumber));
            }

            using var scope = _clientDiagnostics.CreateScope("InternalPhoneNumbersClient.StartReleasePhoneNumber");
            scope.Start();
            try
            {
                var originalResponse = RestClient.ReleasePhoneNumber(phoneNumber, cancellationToken);
                return new InternalReleasePhoneNumberOperation(_clientDiagnostics, _pipeline, RestClient.CreateReleasePhoneNumberRequest(phoneNumber).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
