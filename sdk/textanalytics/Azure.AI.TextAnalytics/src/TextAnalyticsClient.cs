﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.AI.TextAnalytics.Models;
using Azure.AI.TextAnalytics.ServiceClients;
using Azure.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Azure.AI.TextAnalytics
{
    /// <summary>
    /// The client to use for interacting with the Azure Cognitive Service for Language, which includes Text Analytics.
    /// </summary>
    public class TextAnalyticsClient
    {
        private static HashSet<TextAnalyticsClientOptions.ServiceVersion> s_legacyServiceVersions = new()
        {
            TextAnalyticsClientOptions.ServiceVersion.V3_0,
            TextAnalyticsClientOptions.ServiceVersion.V3_1,
        };

        private readonly ServiceClient _serviceClient;

        /// <summary>
        /// Gets the <see cref="ServiceClient" /> instance that can be used for
        /// interacting with the Text Analytics service.
        /// </summary>
        internal ServiceClient ServiceClient => _serviceClient;

        /// <summary>
        /// Protected constructor to allow mocking.
        /// </summary>
        protected TextAnalyticsClient()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextAnalyticsClient"/>
        /// class for the specified service instance.
        /// </summary>
        /// <param name="endpoint">A <see cref="Uri"/> to the service the client
        /// sends requests to.  Endpoint can be found in the Azure portal.</param>
        /// <param name="credential">A <see cref="TokenCredential"/> used to
        /// authenticate requests to the service, such as DefaultAzureCredential.</param>
        public TextAnalyticsClient(Uri endpoint, TokenCredential credential)
            : this(endpoint, credential, new TextAnalyticsClientOptions())
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextAnalyticsClient"/>
        /// class for the specified service instance.
        /// </summary>
        /// <param name="endpoint">A <see cref="Uri"/> to the service the client
        /// sends requests to.  Endpoint can be found in the Azure portal.</param>
        /// <param name="credential">A <see cref="TokenCredential"/> used to
        /// authenticate requests to the service, such as DefaultAzureCredential.</param>
        /// <param name="options"><see cref="TextAnalyticsClientOptions"/> that allow
        /// callers to configure how requests are sent to the service.</param>
        public TextAnalyticsClient(Uri endpoint, TokenCredential credential, TextAnalyticsClientOptions options)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            Argument.AssertNotNull(credential, nameof(credential));
            Argument.AssertNotNull(options, nameof(options));

            var authorizationScope = $"{(string.IsNullOrEmpty(options.Audience?.ToString()) ? TextAnalyticsAudience.AzurePublicCloud : options.Audience)}/.default";

            _serviceClient = options.Version switch
            {
                var version when s_legacyServiceVersions.Contains(version) =>
                    new LegacyServiceClient(
                        endpoint,
                        credential,
                        authorizationScope,
                        TextAnalyticsClientOptions.GetVersionString(options.Version),
                        options),

                _ =>
                    new LanguageServiceClient(
                        endpoint,
                        credential,
                        authorizationScope,
                        TextAnalyticsClientOptions.GetVersionString(options.Version),
                        options)
            };
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AzureKeyCredential"/>
        /// class for the specified service instance.
        /// </summary>
        /// <param name="endpoint">A <see cref="Uri"/> to the service the client
        /// sends requests to.  Endpoint can be found in the Azure portal.</param>
        /// <param name="credential">The API key used to access
        /// the service. This will allow you to update the API key
        /// without creating a new client.</param>
        public TextAnalyticsClient(Uri endpoint, AzureKeyCredential credential)
            : this(endpoint, credential, new TextAnalyticsClientOptions())
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AzureKeyCredential"/>
        /// class for the specified service instance.
        /// </summary>
        /// <param name="endpoint">A <see cref="Uri"/> to the service the client
        /// sends requests to.  Endpoint can be found in the Azure portal.</param>
        /// <param name="credential">The API key used to access
        /// the service. This will allow you to update the API key
        /// without creating a new client.</param>
        /// <param name="options"><see cref="TextAnalyticsClientOptions"/> that allow
        /// callers to configure how requests are sent to the service.</param>
        public TextAnalyticsClient(Uri endpoint, AzureKeyCredential credential, TextAnalyticsClientOptions options)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            Argument.AssertNotNull(credential, nameof(credential));
            Argument.AssertNotNull(options, nameof(options));

            _serviceClient = options.Version switch
            {
                var version when s_legacyServiceVersions.Contains(version) =>
                    new LegacyServiceClient(
                        endpoint,
                        credential,
                        TextAnalyticsClientOptions.GetVersionString(options.Version), options),

                _ =>
                    new LanguageServiceClient(
                        endpoint,
                        credential,
                        TextAnalyticsClientOptions.GetVersionString(options.Version),
                        options)
            };
        }

        #region Detect Language

        /// <summary>
        /// Runs a predictive model to determine the language the passed-in
        /// document is written in, and returns the detected language as well
        /// as a score indicating the model's confidence that the inferred
        /// language is correct. Scores close to 1 indicate high certainty in
        /// the result.
        /// <para>For document length limits, maximum batch size, and supported text encoding, see
        /// <see href="https://aka.ms/azsdk/textanalytics/data-limits"/>.</para>
        /// </summary>
        /// <param name="document">The document to analyze.</param>
        /// <param name="countryHint">Indicates the country of origin of the
        /// document to assist the model in predicting the language
        /// it is written in. If unspecified, this value will be set to the
        /// default country hint in <see cref="TextAnalyticsClientOptions.DefaultCountryHint"/>
        /// in the request sent to the service.
        /// To remove this behavior, set to <see cref="DetectLanguageInput.None"/>.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/>
        /// controlling the request lifetime.</param>
        /// <returns>A result containing the detected language or an error if
        /// the model could not analyze the document.</returns>
        /// <exception cref="RequestFailedException">Service returned a non-success
        /// status code.</exception>
        public virtual async Task<Response<DetectedLanguage>> DetectLanguageAsync(string document, string countryHint = default, CancellationToken cancellationToken = default) =>
            await _serviceClient.DetectLanguageAsync(document, countryHint, cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Runs a predictive model to determine the language the passed-in
        /// document is written in, and returns the detected language as well
        /// as a score indicating the model's confidence that the inferred
        /// language is correct. Scores close to 1 indicate high certainty in
        /// the result.
        /// <para>For document length limits, maximum batch size, and supported text encoding, see
        /// <see href="https://aka.ms/azsdk/textanalytics/data-limits"/>.</para>
        /// </summary>
        /// <param name="document">The document to analyze.</param>
        /// <param name="countryHint">Indicates the country of origin of the
        /// document to assist the model in predicting the language
        /// it is written in. If unspecified, this value will be set to the
        /// default country hint in <see cref="TextAnalyticsClientOptions.DefaultCountryHint"/>
        /// in the request sent to the service.
        /// To remove this behavior, set to <see cref="DetectLanguageInput.None"/>.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/>
        /// controlling the request lifetime.</param>
        /// <returns>A result containing the detected language or an error if
        /// the model could not analyze the document.</returns>
        /// <exception cref="RequestFailedException">Service returned a non-success
        /// status code.</exception>
        public virtual Response<DetectedLanguage> DetectLanguage(string document, string countryHint = default, CancellationToken cancellationToken = default) =>
            _serviceClient.DetectLanguage(document, countryHint, cancellationToken);

        /// <summary>
        /// Runs a predictive model to determine the language the passed-in
        /// documents are written in, and returns, for each one, the detected
        /// language as well as a score indicating the model's confidence that
        /// the inferred language is correct. Scores close to 1 indicate high
        /// certainty in the result.
        /// <para>For document length limits, maximum batch size, and supported text encoding, see
        /// <see href="https://aka.ms/azsdk/textanalytics/data-limits"/>.</para>
        /// </summary>
        /// <param name="documents">A collection of documents to analyze.</param>
        /// <param name="countryHint">Indicates the country of origin of all of
        /// the documents to assist the model in predicting
        /// the language they are written in. If unspecified, this value will be
        /// set to the default country hint in <see cref="TextAnalyticsClientOptions.DefaultCountryHint"/>
        /// in the request sent to the service.
        /// To remove this behavior, set to <see cref="DetectLanguageInput.None"/>.</param>
        /// <param name="options"><see cref="TextAnalyticsRequestOptions"/> used to
        /// select the version of the predictive model to run, and whether
        /// statistics are returned in the response.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/>
        /// controlling the request lifetime.</param>
        /// <returns>A result containing the detected language or an error if
        /// the model could not analyze the documents.</returns>
        /// <exception cref="RequestFailedException">Service returned a non-success
        /// status code.</exception>
        public virtual async Task<Response<DetectLanguageResultCollection>> DetectLanguageBatchAsync(IEnumerable<string> documents, string countryHint = default, TextAnalyticsRequestOptions options = default, CancellationToken cancellationToken = default) =>
            await _serviceClient.DetectLanguageBatchAsync(documents, countryHint, options, cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Runs a predictive model to determine the language the passed-in
        /// documents are written in, and returns, for each one, the detected
        /// language as well as a score indicating the model's confidence that
        /// the inferred language is correct. Scores close to 1 indicate high
        /// certainty in the result.
        /// <para>For document length limits, maximum batch size, and supported text encoding, see
        /// <see href="https://aka.ms/azsdk/textanalytics/data-limits"/>.</para>
        /// </summary>
        /// <param name="documents">A collection of documents to analyze.</param>
        /// <param name="countryHint">Indicates the country of origin of all of
        /// the documents to assist the model in predicting
        /// the language they are written in. If unspecified, this value will be
        /// set to the default country hint in <see cref="TextAnalyticsClientOptions.DefaultCountryHint"/>
        /// in the request sent to the service.
        /// To remove this behavior, set to <see cref="DetectLanguageInput.None"/>.</param>
        /// <param name="options"><see cref="TextAnalyticsRequestOptions"/> used to
        /// select the version of the predictive model to run, and whether
        /// statistics are returned in the response.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/>
        /// controlling the request lifetime.</param>
        /// <returns>A result containing the detected language or an error if
        /// the model could not analyze the documents.</returns>
        /// <exception cref="RequestFailedException">Service returned a non-success
        /// status code.</exception>
        public virtual Response<DetectLanguageResultCollection> DetectLanguageBatch(IEnumerable<string> documents, string countryHint = default, TextAnalyticsRequestOptions options = default, CancellationToken cancellationToken = default) =>
            _serviceClient.DetectLanguageBatch(documents, countryHint, options, cancellationToken);

        /// <summary>
        /// Runs a predictive model to determine the language the passed-in
        /// documents are written in, and returns, for each one, the detected
        /// language as well as a score indicating the model's confidence that
        /// the inferred language is correct. Scores close to 1 indicate high
        /// certainty in the result.
        /// <para>For document length limits, maximum batch size, and supported text encoding, see
        /// <see href="https://aka.ms/azsdk/textanalytics/data-limits"/>.</para>
        /// </summary>
        /// <param name="documents">A collection of documents to analyze.</param>
        /// <param name="options"><see cref="TextAnalyticsRequestOptions"/> used to
        /// select the version of the predictive model to run, and whether
        /// statistics are returned in the response.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/>
        /// controlling the request lifetime.</param>
        /// <returns>A result containing the detected language or an error if
        /// the model could not analyze the documents.</returns>
        /// <exception cref="RequestFailedException">Service returned a non-success
        /// status code.</exception>
        public virtual async Task<Response<DetectLanguageResultCollection>> DetectLanguageBatchAsync(IEnumerable<DetectLanguageInput> documents, TextAnalyticsRequestOptions options = default, CancellationToken cancellationToken = default) =>
            await _serviceClient.DetectLanguageBatchAsync(documents, options, cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Runs a predictive model to determine the language the passed-in
        /// documents are written in, and returns, for each one, the detected
        /// language as well as a score indicating the model's confidence that
        /// the inferred language is correct. Scores close to 1 indicate high
        /// certainty in the result.
        /// <para>For document length limits, maximum batch size, and supported text encoding, see
        /// <see href="https://aka.ms/azsdk/textanalytics/data-limits"/>.</para>
        /// </summary>
        /// <param name="documents">A collection of documents to analyze.</param>
        /// <param name="options"><see cref="TextAnalyticsRequestOptions"/> used to
        /// select the version of the predictive model to run, and whether
        /// statistics are returned in the response.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/>
        /// controlling the request lifetime.</param>
        /// <returns>A result containing the detected language or an error if
        /// the model could not analyze the document.</returns>
        /// <exception cref="RequestFailedException">Service returned a non-success
        /// status code.</exception>
        public virtual Response<DetectLanguageResultCollection> DetectLanguageBatch(IEnumerable<DetectLanguageInput> documents, TextAnalyticsRequestOptions options = default, CancellationToken cancellationToken = default) =>
            _serviceClient.DetectLanguageBatch(documents, options, cancellationToken);

        #endregion

        #region Recognize Entities

        /// <summary>
        /// Runs a predictive model to identify a collection of named entities
        /// in the passed-in document, and categorize those entities into types
        /// such as person, location, or organization.
        /// <para>For more information on available categories, see
        /// <see href="https://docs.microsoft.com/azure/cognitive-services/language-service/named-entity-recognition/concepts/named-entity-categories"/>.</para>
        /// <para>For a list of languages supported by this operation, see
        /// <see href="https://aka.ms/talangs"/>.</para>
        /// <para>For document length limits, maximum batch size, and supported text encoding, see
        /// <see href="https://aka.ms/azsdk/textanalytics/data-limits"/>.</para>
        /// </summary>
        /// <param name="document">The document to analyze.</param>
        /// <param name="language">The language that the document is written in.
        /// If unspecified, this value will be set to the default language in
        /// <see cref="TextAnalyticsClientOptions.DefaultLanguage"/> in the request sent to the
        /// service.  If set to an empty string, the service will apply a model
        /// where the language is explicitly set to "None".</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/>
        /// controlling the request lifetime.</param>
        /// <returns>A result containing the collection of entities identified
        /// in the document, as well as a score indicating the confidence
        /// that the entity correctly matches the identified substring.</returns>
        /// <exception cref="RequestFailedException">Service returned a non-success
        /// status code.</exception>
        public virtual async Task<Response<CategorizedEntityCollection>> RecognizeEntitiesAsync(string document, string language = default, CancellationToken cancellationToken = default) =>
            await _serviceClient.RecognizeEntitiesAsync(document, language, cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Runs a predictive model to identify a collection of named entities
        /// in the passed-in document, and categorize those entities into types
        /// such as person, location, or organization.
        /// <para>For more information on available categories, see
        /// <see href="https://docs.microsoft.com/azure/cognitive-services/language-service/named-entity-recognition/concepts/named-entity-categories"/>.</para>
        /// <para>For a list of languages supported by this operation, see
        /// <see href="https://aka.ms/talangs"/>.</para>
        /// <para>For document length limits, maximum batch size, and supported text encoding, see
        /// <see href="https://aka.ms/azsdk/textanalytics/data-limits"/>.</para>
        /// </summary>
        /// <param name="document">The document to analyze.</param>
        /// <param name="language">The language that the document is written in.
        /// If unspecified, this value will be set to the default language in
        /// <see cref="TextAnalyticsClientOptions.DefaultLanguage"/> in the request sent to the
        /// service.  If set to an empty string, the service will apply a model
        /// where the language is explicitly set to "None".</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/>
        /// controlling the request lifetime.</param>
        /// <returns>A result containing the collection of entities identified
        /// in the document, as well as a score indicating the confidence
        /// that the entity correctly matches the identified substring.</returns>
        /// <exception cref="RequestFailedException">Service returned a non-success
        /// status code.</exception>
        public virtual Response<CategorizedEntityCollection> RecognizeEntities(string document, string language = default, CancellationToken cancellationToken = default) =>
            _serviceClient.RecognizeEntities(document, language, cancellationToken);

        /// <summary>
        /// Runs a predictive model to identify a collection of named entities
        /// in the passed-in documents, and categorize those entities into types
        /// such as person, location, or organization.
        /// <para>For more information on available categories, see
        /// <see href="https://docs.microsoft.com/azure/cognitive-services/language-service/named-entity-recognition/concepts/named-entity-categories"/>.</para>
        /// <para>For a list of languages supported by this operation, see
        /// <see href="https://aka.ms/talangs"/>.</para>
        /// <para>For document length limits, maximum batch size, and supported text encoding, see
        /// <see href="https://aka.ms/azsdk/textanalytics/data-limits"/>.</para>
        /// </summary>
        /// <param name="documents">The documents to analyze.</param>
        /// <param name="language">The language that all the documents are
        /// written in. If unspecified, this value will be set to the default
        /// language in <see cref="TextAnalyticsClientOptions.DefaultLanguage"/> in the request
        /// sent to the service.  If set to an empty string, the service will apply a model
        /// where the language is explicitly set to "None".</param>
        /// <param name="options"><see cref="TextAnalyticsRequestOptions"/> used to
        /// select the version of the predictive model to run, and whether
        /// statistics are returned in the response.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/>
        /// controlling the request lifetime.</param>
        /// <returns>A result containing the collection of entities identified
        /// for each of the documents, as well as scores indicating the confidence
        /// that a given entity correctly matches the identified substring.</returns>
        /// <exception cref="RequestFailedException">Service returned a non-success
        /// status code.</exception>
        public virtual async Task<Response<RecognizeEntitiesResultCollection>> RecognizeEntitiesBatchAsync(IEnumerable<string> documents, string language = default, TextAnalyticsRequestOptions options = default, CancellationToken cancellationToken = default) =>
            await _serviceClient.RecognizeEntitiesBatchAsync(documents, language, options, cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Runs a predictive model to identify a collection of named entities
        /// in the passed-in documents, and categorize those entities into types
        /// such as person, location, or organization.
        /// <para>For more information on available categories, see
        /// <see href="https://docs.microsoft.com/azure/cognitive-services/language-service/named-entity-recognition/concepts/named-entity-categories"/>.</para>
        /// <para>For a list of languages supported by this operation, see
        /// <see href="https://aka.ms/talangs"/>.</para>
        /// <para>For document length limits, maximum batch size, and supported text encoding, see
        /// <see href="https://aka.ms/azsdk/textanalytics/data-limits"/>.</para>
        /// </summary>
        /// <param name="documents">The documents to analyze.</param>
        /// <param name="language">The language that all the documents are
        /// written in. If unspecified, this value will be set to the default
        /// language in <see cref="TextAnalyticsClientOptions.DefaultLanguage"/> in the request
        /// sent to the service.  If set to an empty string, the service will apply a model
        /// where the language is explicitly set to "None".</param>
        /// <param name="options"><see cref="TextAnalyticsRequestOptions"/> used to
        /// select the version of the predictive model to run, and whether
        /// statistics are returned in the response.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/>
        /// controlling the request lifetime.</param>
        /// <returns>A result containing the collection of entities identified
        /// for each of the documents, as well as scores indicating the confidence
        /// that a given entity correctly matches the identified substring.</returns>
        /// <exception cref="RequestFailedException">Service returned a non-success
        /// status code.</exception>
        public virtual Response<RecognizeEntitiesResultCollection> RecognizeEntitiesBatch(IEnumerable<string> documents, string language = default, TextAnalyticsRequestOptions options = default, CancellationToken cancellationToken = default) =>
            _serviceClient.RecognizeEntitiesBatch(documents, language, options, cancellationToken);

        /// <summary>
        /// Runs a predictive model to identify a collection of named entities
        /// in the passed-in documents, and categorize those entities into types
        /// such as person, location, or organization.
        /// <para>For more information on available categories, see
        /// <see href="https://docs.microsoft.com/azure/cognitive-services/language-service/named-entity-recognition/concepts/named-entity-categories"/>.</para>
        /// <para>For a list of languages supported by this operation, see
        /// <see href="https://aka.ms/talangs"/>.</para>
        /// <para>For document length limits, maximum batch size, and supported text encoding, see
        /// <see href="https://aka.ms/azsdk/textanalytics/data-limits"/>.</para>
        /// </summary>
        /// <param name="documents">The documents to analyze.</param>
        /// <param name="options"><see cref="TextAnalyticsRequestOptions"/> used to
        /// select the version of the predictive model to run, and whether
        /// statistics are returned in the response.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/>
        /// controlling the request lifetime.</param>
        /// <returns>A result containing the collection of entities identified
        /// for each of the documents, as well as scores indicating the confidence
        /// that a given entity correctly matches the identified substring.</returns>
        /// <exception cref="RequestFailedException">Service returned a non-success
        /// status code.</exception>
        public virtual async Task<Response<RecognizeEntitiesResultCollection>> RecognizeEntitiesBatchAsync(IEnumerable<TextDocumentInput> documents, TextAnalyticsRequestOptions options = default, CancellationToken cancellationToken = default) =>
            await _serviceClient.RecognizeEntitiesBatchAsync(documents, options, cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Runs a predictive model to identify a collection of named entities
        /// in the passed-in documents, and categorize those entities into types
        /// such as person, location, or organization.
        /// <para>For more information on available categories, see
        /// <see href="https://docs.microsoft.com/azure/cognitive-services/language-service/named-entity-recognition/concepts/named-entity-categories"/>.</para>
        /// <para>For a list of languages supported by this operation, see
        /// <see href="https://aka.ms/talangs"/>.</para>
        /// <para>For document length limits, maximum batch size, and supported text encoding, see
        /// <see href="https://aka.ms/azsdk/textanalytics/data-limits"/>.</para>
        /// </summary>
        /// <param name="documents">The documents to analyze.</param>
        /// <param name="options"><see cref="TextAnalyticsRequestOptions"/> used to
        /// select the version of the predictive model to run, and whether
        /// statistics are returned in the response.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/>
        /// controlling the request lifetime.</param>
        /// <returns>A result containing the collection of entities identified
        /// for each of the documents, as well as scores indicating the confidence
        /// that a given entity correctly matches the identified substring.</returns>
        /// <exception cref="RequestFailedException">Service returned a non-success
        /// status code.</exception>
        public virtual Response<RecognizeEntitiesResultCollection> RecognizeEntitiesBatch(IEnumerable<TextDocumentInput> documents, TextAnalyticsRequestOptions options = default, CancellationToken cancellationToken = default) =>
            _serviceClient.RecognizeEntitiesBatch(documents, options, cancellationToken);

        private static AnalyzeTextEntityRecognitionInput DocumentsToEntityRecognition(IEnumerable<string> documents, string language)
        {
            AnalyzeTextEntityRecognitionInput textEntityInputs = new AnalyzeTextEntityRecognitionInput();
            int id = 0;
            foreach (var document in documents)
            {
                var input = new MultiLanguageInput(id: id.ToString(CultureInfo.InvariantCulture), text: document);
                id++;
                input.Language = language;
                textEntityInputs.AnalysisInput.Documents.Add(input);
            }

            return textEntityInputs;
        }

        private static AnalyzeTextEntityRecognitionInput TextDocumentInputToEntityRecognition(IEnumerable<TextDocumentInput> documents)
        {
            AnalyzeTextEntityRecognitionInput textEntityInputs = new AnalyzeTextEntityRecognitionInput();
            foreach (var document in documents)
            {
                var input = new MultiLanguageInput(document.Id, document.Text);
                input.Language = document.Language;
                textEntityInputs.AnalysisInput.Documents.Add(input);
            }

            return textEntityInputs;
        }

        #endregion

        #region Recognize PII Entities

        /// <summary>
        /// Runs a predictive model to identify a collection of entities containing
        /// Personally Identifiable Information found in the passed-in document,
        /// and categorize those entities into types such as US social security
        /// number, drivers license number, or credit card number.
        /// <para>For more information on available categories, see
        /// <see href="https://aka.ms/tanerpii"/>.</para>
        /// <para>For a list of languages supported by this operation, see
        /// <see href="https://aka.ms/talangs"/>.</para>
        /// <para>For document length limits, maximum batch size, and supported text encoding, see
        /// <see href="https://aka.ms/azsdk/textanalytics/data-limits"/>.</para>
        /// </summary>
        /// <remarks>
        /// This method is only available for <see cref="TextAnalyticsClientOptions.ServiceVersion.V3_1"/>, <see cref="TextAnalyticsClientOptions.ServiceVersion.V2022_05_01"/>, and up.
        /// </remarks>
        /// <param name="document">The document to analyze.</param>
        /// <param name="language">The language that the document is written in.
        /// If unspecified, this value will be set to the default language in
        /// <see cref="TextAnalyticsClientOptions.DefaultLanguage"/> in the request sent to the
        /// service.  If set to an empty string, the service will apply a model
        /// where the language is explicitly set to "None".</param>
        /// <param name="options">The additional configurable <see cref="RecognizePiiEntitiesOptions"/> that may be passed when
        /// recognizing PII entities. Options include entity domain filters, model version, and more.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/>
        /// controlling the request lifetime.</param>
        /// <returns>A result containing the collection of entities identified
        /// in the document, as well as a score indicating the confidence
        /// that the entity correctly matches the identified substring.</returns>
        /// <exception cref="RequestFailedException">Service returned a non-success
        /// status code.</exception>
        public virtual async Task<Response<PiiEntityCollection>> RecognizePiiEntitiesAsync(string document, string language = default, RecognizePiiEntitiesOptions options = default, CancellationToken cancellationToken = default) =>
            await _serviceClient.RecognizePiiEntitiesAsync(document, language, options, cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Runs a predictive model to identify a collection of entities containing
        /// Personally Identifiable Information found in the passed-in document,
        /// and categorize those entities into types such as US social security
        /// number, drivers license number, or credit card number.
        /// <para>For more information on available categories, see
        /// <see href="https://aka.ms/tanerpii"/>.</para>
        /// <para>For a list of languages supported by this operation, see
        /// <see href="https://aka.ms/talangs"/>.</para>
        /// <para>For document length limits, maximum batch size, and supported text encoding, see
        /// <see href="https://aka.ms/azsdk/textanalytics/data-limits"/>.</para>
        /// </summary>
        /// <remarks>
        /// This method is only available for <see cref="TextAnalyticsClientOptions.ServiceVersion.V3_1"/>, <see cref="TextAnalyticsClientOptions.ServiceVersion.V2022_05_01"/>, and up.
        /// </remarks>
        /// <param name="document">The document to analyze.</param>
        /// <param name="language">The language that the document is written in.
        /// If unspecified, this value will be set to the default language in
        /// <see cref="TextAnalyticsClientOptions.DefaultLanguage"/> in the request sent to the
        /// service.  If set to an empty string, the service will apply a model
        /// where the language is explicitly set to "None".</param>
        /// <param name="options">The additional configurable <see cref="RecognizePiiEntitiesOptions"/> that may be passed when
        /// recognizing PII entities. Options include entity domain filters, model version, and more.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/>
        /// controlling the request lifetime.</param>
        /// <returns>A result containing the collection of entities identified
        /// in the document, as well as a score indicating the confidence
        /// that the entity correctly matches the identified substring.</returns>
        /// <exception cref="RequestFailedException">Service returned a non-success
        /// status code.</exception>
        public virtual Response<PiiEntityCollection> RecognizePiiEntities(string document, string language = default, RecognizePiiEntitiesOptions options = default, CancellationToken cancellationToken = default) =>
            _serviceClient.RecognizePiiEntities(document, language, options, cancellationToken);

        /// <summary>
        /// Runs a predictive model to identify a collection of entities containing
        /// Personally Identifiable Information found in the passed-in document,
        /// and categorize those entities into types such as US social security
        /// number, drivers license number, or credit card number.
        /// <para>For more information on available categories, see
        /// <see href="https://aka.ms/tanerpii"/>.</para>
        /// <para>For a list of languages supported by this operation, see
        /// <see href="https://aka.ms/talangs"/>.</para>
        /// <para>For document length limits, maximum batch size, and supported text encoding, see
        /// <see href="https://aka.ms/azsdk/textanalytics/data-limits"/>.</para>
        /// </summary>
        /// <remarks>
        /// This method is only available for <see cref="TextAnalyticsClientOptions.ServiceVersion.V3_1"/>, <see cref="TextAnalyticsClientOptions.ServiceVersion.V2022_05_01"/>, and up.
        /// </remarks>
        /// <param name="documents">The documents to analyze.</param>
        /// <param name="language">The language that the document is written in.
        /// If unspecified, this value will be set to the default language in
        /// <see cref="TextAnalyticsClientOptions.DefaultLanguage"/> in the request sent to the
        /// service.  If set to an empty string, the service will apply a model
        /// where the language is explicitly set to "None".</param>
        /// <param name="options">The additional configurable <see cref="RecognizePiiEntitiesOptions"/> that may be passed when
        /// recognizing PII entities. Options include entity domain filters, model version, and more.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/>
        /// controlling the request lifetime.</param>
        /// <returns>A result containing the collection of entities identified
        /// for each of the documents, as well as scores indicating the confidence
        /// that a given entity correctly matches the identified substring.</returns>
        /// <exception cref="RequestFailedException">Service returned a non-success
        /// status code.</exception>
        public virtual async Task<Response<RecognizePiiEntitiesResultCollection>> RecognizePiiEntitiesBatchAsync(IEnumerable<string> documents, string language = default, RecognizePiiEntitiesOptions options = default, CancellationToken cancellationToken = default) =>
            await _serviceClient.RecognizePiiEntitiesBatchAsync(documents, language, options, cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Runs a predictive model to identify a collection of entities containing
        /// Personally Identifiable Information found in the passed-in document,
        /// and categorize those entities into types such as US social security
        /// number, drivers license number, or credit card number.
        /// <para>For more information on available categories, see
        /// <see href="https://aka.ms/tanerpii"/>.</para>
        /// <para>For a list of languages supported by this operation, see
        /// <see href="https://aka.ms/talangs"/>.</para>
        /// <para>For document length limits, maximum batch size, and supported text encoding, see
        /// <see href="https://aka.ms/azsdk/textanalytics/data-limits"/>.</para>
        /// </summary>
        /// <remarks>
        /// This method is only available for <see cref="TextAnalyticsClientOptions.ServiceVersion.V3_1"/>, <see cref="TextAnalyticsClientOptions.ServiceVersion.V2022_05_01"/>, and up.
        /// </remarks>
        /// <param name="documents">The documents to analyze.</param>
        /// <param name="language">The language that the document is written in.
        /// If unspecified, this value will be set to the default language in
        /// <see cref="TextAnalyticsClientOptions.DefaultLanguage"/> in the request sent to the
        /// service.  If set to an empty string, the service will apply a model
        /// where the language is explicitly set to "None".</param>
        /// <param name="options">The additional configurable <see cref="RecognizePiiEntitiesOptions"/> that may be passed when
        /// recognizing PII entities. Options include entity domain filters, model version, and more.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/>
        /// controlling the request lifetime.</param>
        /// <returns>A result containing the collection of entities identified
        /// for each of the documents, as well as scores indicating the confidence
        /// that a given entity correctly matches the identified substring.</returns>
        /// <exception cref="RequestFailedException">Service returned a non-success
        /// status code.</exception>
        public virtual Response<RecognizePiiEntitiesResultCollection> RecognizePiiEntitiesBatch(IEnumerable<string> documents, string language = default, RecognizePiiEntitiesOptions options = default, CancellationToken cancellationToken = default) =>
            _serviceClient.RecognizePiiEntitiesBatch(documents, language, options, cancellationToken);

        /// <summary>
        /// Runs a predictive model to identify a collection of entities containing
        /// Personally Identifiable Information found in the passed-in document,
        /// and categorize those entities into types such as US social security
        /// number, drivers license number, or credit card number.
        /// <para>For more information on available categories, see
        /// <see href="https://aka.ms/tanerpii"/>.</para>
        /// <para>For a list of languages supported by this operation, see
        /// <see href="https://aka.ms/talangs"/>.</para>
        /// <para>For document length limits, maximum batch size, and supported text encoding, see
        /// <see href="https://aka.ms/azsdk/textanalytics/data-limits"/>.</para>
        /// </summary>
        /// <remarks>
        /// This method is only available for <see cref="TextAnalyticsClientOptions.ServiceVersion.V3_1"/>, <see cref="TextAnalyticsClientOptions.ServiceVersion.V2022_05_01"/>, and up.
        /// </remarks>
        /// <param name="documents">The documents to analyze.</param>
        /// <param name="options">The additional configurable <see cref="RecognizePiiEntitiesOptions"/> that may be passed when
        /// recognizing PII entities. Options include entity domain filters, model version, and more.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/>
        /// controlling the request lifetime.</param>
        /// <returns>A result containing the collection of entities identified
        /// for each of the documents, as well as scores indicating the confidence
        /// that a given entity correctly matches the identified substring.</returns>
        /// <exception cref="RequestFailedException">Service returned a non-success
        /// status code.</exception>
        public virtual async Task<Response<RecognizePiiEntitiesResultCollection>> RecognizePiiEntitiesBatchAsync(IEnumerable<TextDocumentInput> documents, RecognizePiiEntitiesOptions options = default, CancellationToken cancellationToken = default) =>
            await _serviceClient.RecognizePiiEntitiesBatchAsync(documents.ToArray(), options, cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Runs a predictive model to identify a collection of entities containing
        /// Personally Identifiable Information found in the passed-in document,
        /// and categorize those entities into types such as US social security
        /// number, drivers license number, or credit card number.
        /// <para>For more information on available categories, see
        /// <see href="https://aka.ms/tanerpii"/>.</para>
        /// <para>For a list of languages supported by this operation, see
        /// <see href="https://aka.ms/talangs"/>.</para>
        /// <para>For document length limits, maximum batch size, and supported text encoding, see
        /// <see href="https://aka.ms/azsdk/textanalytics/data-limits"/>.</para>
        /// </summary>
        /// <remarks>
        /// This method is only available for <see cref="TextAnalyticsClientOptions.ServiceVersion.V3_1"/>, <see cref="TextAnalyticsClientOptions.ServiceVersion.V2022_05_01"/>, and up.
        /// </remarks>
        /// <param name="documents">The documents to analyze.</param>
        /// <param name="options">The additional configurable <see cref="RecognizePiiEntitiesOptions"/> that may be passed when
        /// recognizing PII entities. Options include entity domain filters, model version, and more.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/>
        /// controlling the request lifetime.</param>
        /// <returns>A result containing the collection of entities identified
        /// for each of the documents, as well as scores indicating the confidence
        /// that a given entity correctly matches the identified substring.</returns>
        /// <exception cref="RequestFailedException">Service returned a non-success
        /// status code.</exception>
        public virtual Response<RecognizePiiEntitiesResultCollection> RecognizePiiEntitiesBatch(IEnumerable<TextDocumentInput> documents, RecognizePiiEntitiesOptions options = default, CancellationToken cancellationToken = default) =>
            _serviceClient.RecognizePiiEntitiesBatch(documents, options, cancellationToken);

        #endregion

        #region Analyze Sentiment
        /// <summary>
        /// Runs a predictive model to identify the positive, negative, neutral
        /// or mixed sentiment contained in the document, as well as a score
        /// indicating the model's confidence in the predicted sentiment.
        /// <para>For a list of languages supported by this operation, see
        /// <see href="https://aka.ms/talangs"/>.</para>
        /// <para>For document length limits, maximum batch size, and supported text encoding, see
        /// <see href="https://aka.ms/azsdk/textanalytics/data-limits"/>.</para>
        /// </summary>
        /// <param name="document">The document to analyze.</param>
        /// <param name="language">The language that the document is written in.
        /// If unspecified, this value will be set to the default language in
        /// <see cref="TextAnalyticsClientOptions.DefaultLanguage"/> in the request sent to the
        /// service.  If set to an empty string, the service will apply a model
        /// where the language is explicitly set to "None".</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/>
        /// controlling the request lifetime.</param>
        /// <returns>A result containing sentiment predictions for the document
        /// and each of the sentences it contains.</returns>
        /// <exception cref="RequestFailedException">Service returned a non-success
        /// status code.</exception>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "AZC0002:DO ensure all service methods, both asynchronous and synchronous, take an optional CancellationToken parameter called cancellationToken.", Justification = "Hidden method we don't encourage people to use.")]
        public virtual async Task<Response<DocumentSentiment>> AnalyzeSentimentAsync(string document, string language, CancellationToken cancellationToken) =>
            await AnalyzeSentimentAsync(document, language, new AnalyzeSentimentOptions(), cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Runs a predictive model to identify the positive, negative or neutral
        /// sentiment contained in the document, as well as a score indicating the model's
        /// confidence in the predicted sentiment.
        /// <para>For a list of languages supported by this operation, see
        /// <see href="https://aka.ms/talangs"/>.</para>
        /// <para>For document length limits, maximum batch size, and supported text encoding, see
        /// <see href="https://aka.ms/azsdk/textanalytics/data-limits"/>.</para>
        /// </summary>
        /// <param name="document">The text to analyze.</param>
        /// <param name="language">The language that the document is written in.
        /// If unspecified, this value will be set to the default language in
        /// <see cref="TextAnalyticsClientOptions.DefaultLanguage"/> in the request sent to the
        /// service.  If set to an empty string, the service will apply a model
        /// where the language is explicitly set to "None".</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/>
        /// controlling the request lifetime.</param>
        /// <returns>A result containing sentiment predictions for the document
        /// and each of the sentences it contains.</returns>
        /// <exception cref="RequestFailedException">Service returned a non-success
        /// status code.</exception>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "AZC0002:DO ensure all service methods, both asynchronous and synchronous, take an optional CancellationToken parameter called cancellationToken.", Justification = "Hidden method we don't encourage people to use.")]
        public virtual Response<DocumentSentiment> AnalyzeSentiment(string document, string language, CancellationToken cancellationToken) =>
            AnalyzeSentiment(document, language, new AnalyzeSentimentOptions(), cancellationToken);

        /// <summary>
        /// Runs a predictive model to identify the positive, negative, neutral
        /// or mixed sentiment contained in the document, as well as a score
        /// indicating the model's confidence in the predicted sentiment.
        /// <para>For a list of languages supported by this operation, see
        /// <see href="https://aka.ms/talangs"/>.</para>
        /// <para>For document length limits, maximum batch size, and supported text encoding, see
        /// <see href="https://aka.ms/azsdk/textanalytics/data-limits"/>.</para>
        /// </summary>
        /// <param name="document">The document to analyze.</param>
        /// <param name="language">The language that the document is written in.
        /// If unspecified, this value will be set to the default language in
        /// <see cref="TextAnalyticsClientOptions.DefaultLanguage"/> in the request sent to the
        /// service.  If set to an empty string, the service will apply a model
        /// where the language is explicitly set to "None".</param>
        /// <param name="options">The additional configurable <see cref="AnalyzeSentimentOptions"/> that may be passed when
        /// analyzing sentiments. Options include Opinion mining, model version, and more.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/>
        /// controlling the request lifetime.</param>
        /// <returns>A result containing sentiment predictions for the document
        /// and each of the sentences it contains.</returns>
        /// <exception cref="RequestFailedException">Service returned a non-success
        /// status code.</exception>
        public virtual async Task<Response<DocumentSentiment>> AnalyzeSentimentAsync(string document, string language = default, AnalyzeSentimentOptions options = null, CancellationToken cancellationToken = default) =>
            await _serviceClient.AnalyzeSentimentAsync(document, language, options, cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Runs a predictive model to identify the positive, negative or neutral
        /// sentiment contained in the document, as well as a score indicating the model's
        /// confidence in the predicted sentiment.
        /// <para>For a list of languages supported by this operation, see
        /// <see href="https://aka.ms/talangs"/>.</para>
        /// <para>For document length limits, maximum batch size, and supported text encoding, see
        /// <see href="https://aka.ms/azsdk/textanalytics/data-limits"/>.</para>
        /// </summary>
        /// <param name="document">The text to analyze.</param>
        /// <param name="language">The language that the document is written in.
        /// If unspecified, this value will be set to the default language in
        /// <see cref="TextAnalyticsClientOptions.DefaultLanguage"/> in the request sent to the
        /// service.  If set to an empty string, the service will apply a model
        /// where the language is explicitly set to "None".</param>
        /// <param name="options">The additional configurable <see cref="AnalyzeSentimentOptions"/> that may be passed when
        /// analyzing sentiments. Options include Opinion mining, model version, and more.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/>
        /// controlling the request lifetime.</param>
        /// <returns>A result containing sentiment predictions for the document
        /// and each of the sentences it contains.</returns>
        /// <exception cref="RequestFailedException">Service returned a non-success
        /// status code.</exception>
        public virtual Response<DocumentSentiment> AnalyzeSentiment(string document, string language = default, AnalyzeSentimentOptions options = null, CancellationToken cancellationToken = default) =>
            _serviceClient.AnalyzeSentiment(document, language, options, cancellationToken);

        /// <summary>
        /// Runs a predictive model to identify the positive, negative or neutral
        /// sentiment contained in the documents, as well as scores indicating
        /// the model's confidence in each of the predicted sentiments.
        /// <para>For a list of languages supported by this operation, see
        /// <see href="https://aka.ms/talangs"/>.</para>
        /// <para>For document length limits, maximum batch size, and supported text encoding, see
        /// <see href="https://aka.ms/azsdk/textanalytics/data-limits"/>.</para>
        /// </summary>
        /// <param name="documents">The documents to analyze.</param>
        /// <param name="language">The language that all of the documents are written in.
        /// If unspecified, this value will be set to the default language in
        /// <see cref="TextAnalyticsClientOptions.DefaultLanguage"/> in the request sent to the
        /// service.  If set to an empty string, the service will apply a model
        /// where the language is explicitly set to "None".</param>
        /// <param name="options"><see cref="TextAnalyticsRequestOptions"/> used to
        /// select the version of the predictive model to run, and whether
        /// statistics are returned in the response.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/>
        /// controlling the request lifetime.</param>
        /// <returns>A result containing sentiment predictions for each of the documents
        /// and predictions for each of the sentences each document contains.</returns>
        /// <exception cref="RequestFailedException">Service returned a non-success
        /// status code.</exception>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public virtual async Task<Response<AnalyzeSentimentResultCollection>> AnalyzeSentimentBatchAsync(IEnumerable<string> documents, string language, TextAnalyticsRequestOptions options, CancellationToken cancellationToken = default) =>
            await _serviceClient.AnalyzeSentimentBatchAsync(documents, language, (options != null ? new AnalyzeSentimentOptions(options) : null), cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Runs a predictive model to identify the positive, negative or neutral
        /// sentiment contained in the documents, as well as scores indicating
        /// the model's confidence in each of the predicted sentiments.
        /// <para>For a list of languages supported by this operation, see
        /// <see href="https://aka.ms/talangs"/>.</para>
        /// <para>For document length limits, maximum batch size, and supported text encoding, see
        /// <see href="https://aka.ms/azsdk/textanalytics/data-limits"/>.</para>
        /// </summary>
        /// <param name="documents">The documents to analyze.</param>
        /// <param name="language">The language that all of the documents are written in.
        /// If unspecified, this value will be set to the default language in
        /// <see cref="TextAnalyticsClientOptions.DefaultLanguage"/> in the request sent to the
        /// service.  If set to an empty string, the service will apply a model
        /// where the language is explicitly set to "None".</param>
        /// <param name="options"><see cref="TextAnalyticsRequestOptions"/> used to
        /// select the version of the predictive model to run, and whether
        /// statistics are returned in the response.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/>
        /// controlling the request lifetime.</param>
        /// <returns>A result containing sentiment predictions for each of the documents
        /// and predictions for each of the sentences each document contains.</returns>
        /// <exception cref="RequestFailedException">Service returned a non-success
        /// status code.</exception>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public virtual Response<AnalyzeSentimentResultCollection> AnalyzeSentimentBatch(IEnumerable<string> documents, string language, TextAnalyticsRequestOptions options, CancellationToken cancellationToken = default) =>
            _serviceClient.AnalyzeSentimentBatch(documents, language, (options != null ? new AnalyzeSentimentOptions(options) : null), cancellationToken);

        /// <summary>
        /// Runs a predictive model to identify the positive, negative or neutral
        /// sentiment contained in the documents, as well as scores indicating
        /// the model's confidence in each of the predicted sentiments.
        /// <para>For a list of languages supported by this operation, see
        /// <see href="https://aka.ms/talangs"/>.</para>
        /// <para>For document length limits, maximum batch size, and supported text encoding, see
        /// <see href="https://aka.ms/azsdk/textanalytics/data-limits"/>.</para>
        /// </summary>
        /// <param name="documents">The documents to analyze.</param>
        /// <param name="language">The language that all of the documents are written in.
        /// If unspecified, this value will be set to the default language in
        /// <see cref="TextAnalyticsClientOptions.DefaultLanguage"/> in the request sent to the
        /// service.  If set to an empty string, the service will apply a model
        /// where the language is explicitly set to "None".</param>
        /// <param name="options">The additional configurable <see cref="AnalyzeSentimentOptions"/> that may be passed when
        /// analyzing sentiments. Options include Opinion mining, model version, and more.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/>
        /// controlling the request lifetime.</param>
        /// <returns>A result containing sentiment predictions for each of the documents
        /// and predictions for each of the sentences each document contains.</returns>
        /// <exception cref="RequestFailedException">Service returned a non-success
        /// status code.</exception>
        public virtual async Task<Response<AnalyzeSentimentResultCollection>> AnalyzeSentimentBatchAsync(IEnumerable<string> documents, string language = default, AnalyzeSentimentOptions options = default, CancellationToken cancellationToken = default) =>
            await _serviceClient.AnalyzeSentimentBatchAsync(documents, language,options, cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Runs a predictive model to identify the positive, negative or neutral
        /// sentiment contained in the documents, as well as scores indicating
        /// the model's confidence in each of the predicted sentiments.
        /// <para>For a list of languages supported by this operation, see
        /// <see href="https://aka.ms/talangs"/>.</para>
        /// <para>For document length limits, maximum batch size, and supported text encoding, see
        /// <see href="https://aka.ms/azsdk/textanalytics/data-limits"/>.</para>
        /// </summary>
        /// <param name="documents">The documents to analyze.</param>
        /// <param name="language">The language that all of the documents are written in.
        /// If unspecified, this value will be set to the default language in
        /// <see cref="TextAnalyticsClientOptions.DefaultLanguage"/> in the request sent to the
        /// service.  If set to an empty string, the service will apply a model
        /// where the language is explicitly set to "None".</param>
        /// <param name="options">The additional configurable <see cref="AnalyzeSentimentOptions"/> that may be passed when
        /// analyzing sentiments. Options include Opinion mining, model version, and more.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/>
        /// controlling the request lifetime.</param>
        /// <returns>A result containing sentiment predictions for each of the documents
        /// and predictions for each of the sentences each document contains.</returns>
        /// <exception cref="RequestFailedException">Service returned a non-success
        /// status code.</exception>
        public virtual Response<AnalyzeSentimentResultCollection> AnalyzeSentimentBatch(IEnumerable<string> documents, string language = default, AnalyzeSentimentOptions options = default, CancellationToken cancellationToken = default) =>
            _serviceClient.AnalyzeSentimentBatch(documents, language, options, cancellationToken);

        /// <summary>
        /// Runs a predictive model to identify the positive, negative or neutral
        /// sentiment contained in the documents, as well as scores indicating
        /// the model's confidence in each of the predicted sentiments.
        /// <para>For a list of languages supported by this operation, see
        /// <see href="https://aka.ms/talangs"/>.</para>
        /// <para>For document length limits, maximum batch size, and supported text encoding, see
        /// <see href="https://aka.ms/azsdk/textanalytics/data-limits"/>.</para>
        /// </summary>
        /// <param name="documents">The documents to analyze.</param>
        /// <param name="options"><see cref="TextAnalyticsRequestOptions"/> used to
        /// select the version of the predictive model to run, and whether
        /// statistics are returned in the response.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/>
        /// controlling the request lifetime.</param>
        /// <returns>A result containing sentiment predictions for each of the documents
        /// and predictions for each of the sentences each document contains.</returns>
        /// <exception cref="RequestFailedException">Service returned a non-success
        /// status code.</exception>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public virtual async Task<Response<AnalyzeSentimentResultCollection>> AnalyzeSentimentBatchAsync(IEnumerable<TextDocumentInput> documents, TextAnalyticsRequestOptions options, CancellationToken cancellationToken = default) =>
            await _serviceClient.AnalyzeSentimentBatchAsync(documents, (options != null ? new AnalyzeSentimentOptions(options) : null), cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Runs a predictive model to identify the positive, negative or neutral
        /// sentiment contained in the documents, as well as scores indicating
        /// the model's confidence in each of the predicted sentiments.
        /// <para>For a list of languages supported by this operation, see
        /// <see href="https://aka.ms/talangs"/>.</para>
        /// <para>For document length limits, maximum batch size, and supported text encoding, see
        /// <see href="https://aka.ms/azsdk/textanalytics/data-limits"/>.</para>
        /// </summary>
        /// <param name="documents">The documents to analyze.</param>
        /// <param name="options"><see cref="TextAnalyticsRequestOptions"/> used to
        /// select the version of the predictive model to run, and whether
        /// statistics are returned in the response.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/>
        /// controlling the request lifetime.</param>
        /// <returns>A result containing sentiment predictions for each of the documents
        /// and predictions for each of the sentences each document contains.</returns>
        /// <exception cref="RequestFailedException">Service returned a non-success
        /// status code.</exception>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public virtual Response<AnalyzeSentimentResultCollection> AnalyzeSentimentBatch(IEnumerable<TextDocumentInput> documents, TextAnalyticsRequestOptions options, CancellationToken cancellationToken = default) =>
            _serviceClient?.AnalyzeSentimentBatch(documents, (options != null ? new AnalyzeSentimentOptions(options) : null), cancellationToken);

        /// <summary>
        /// Runs a predictive model to identify the positive, negative or neutral
        /// sentiment contained in the documents, as well as scores indicating
        /// the model's confidence in each of the predicted sentiments.
        /// <para>For a list of languages supported by this operation, see
        /// <see href="https://aka.ms/talangs"/>.</para>
        /// <para>For document length limits, maximum batch size, and supported text encoding, see
        /// <see href="https://aka.ms/azsdk/textanalytics/data-limits"/>.</para>
        /// </summary>
        /// <param name="documents">The documents to analyze.</param>
        /// <param name="options">The additional configurable <see cref="AnalyzeSentimentOptions"/> that may be passed when
        /// analyzing sentiments. Options include Opinion mining, model version, and more.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/>
        /// controlling the request lifetime.</param>
        /// <returns>A result containing sentiment predictions for each of the documents
        /// and predictions for each of the sentences each document contains.</returns>
        /// <exception cref="RequestFailedException">Service returned a non-success
        /// status code.</exception>
        public virtual async Task<Response<AnalyzeSentimentResultCollection>> AnalyzeSentimentBatchAsync(IEnumerable<TextDocumentInput> documents, AnalyzeSentimentOptions options = default, CancellationToken cancellationToken = default) =>
            await _serviceClient.AnalyzeSentimentBatchAsync(documents, options, cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Runs a predictive model to identify the positive, negative or neutral
        /// sentiment contained in the documents, as well as scores indicating
        /// the model's confidence in each of the predicted sentiments.
        /// <para>For a list of languages supported by this operation, see
        /// <see href="https://aka.ms/talangs"/>.</para>
        /// <para>For document length limits, maximum batch size, and supported text encoding, see
        /// <see href="https://aka.ms/azsdk/textanalytics/data-limits"/>.</para>
        /// </summary>
        /// <param name="documents">The documents to analyze.</param>
        /// <param name="options">The additional configurable <see cref="AnalyzeSentimentOptions"/> that may be passed when
        /// analyzing sentiments. Options include Opinion mining, model version, and more.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/>
        /// controlling the request lifetime.</param>
        /// <returns>A result containing sentiment predictions for each of the documents
        /// and predictions for each of the sentences each document contains.</returns>
        /// <exception cref="RequestFailedException">Service returned a non-success
        /// status code.</exception>
        public virtual Response<AnalyzeSentimentResultCollection> AnalyzeSentimentBatch(IEnumerable<TextDocumentInput> documents, AnalyzeSentimentOptions options = default, CancellationToken cancellationToken = default) =>
            _serviceClient.AnalyzeSentimentBatch(documents, options, cancellationToken);

        #endregion

        #region Extract Key Phrases

        /// <summary>
        /// Runs a model to identify a collection of significant phrases
        /// found in the passed-in document.
        /// <para>For example, for the document "The food was delicious and there
        /// were wonderful staff", the API returns the main talking points: "food"
        /// and "wonderful staff".</para>
        /// <para>For a list of languages supported by this operation, see
        /// <see href="https://aka.ms/talangs"/>.</para>
        /// <para>For document length limits, maximum batch size, and supported text encoding, see
        /// <see href="https://aka.ms/azsdk/textanalytics/data-limits"/>.</para>
        /// </summary>
        /// <param name="document">The document to analyze.</param>
        /// <param name="language">The language that the document is written in.
        /// If unspecified, this value will be set to the default language in
        /// <see cref="TextAnalyticsClientOptions.DefaultLanguage"/> in the request sent to the
        /// service.  If set to an empty string, the service will apply a model
        /// where the language is explicitly set to "None".</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/>
        /// controlling the request lifetime.</param>
        /// <returns>A result containing the collection of key phrases identified
        /// in the document.</returns>
        /// <exception cref="RequestFailedException">Service returned a non-success
        /// status code.</exception>
        public virtual async Task<Response<KeyPhraseCollection>> ExtractKeyPhrasesAsync(string document, string language = default, CancellationToken cancellationToken = default) =>
            await _serviceClient.ExtractKeyPhrasesAsync(document, language, cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Runs a model to identify a collection of significant phrases
        /// found in the passed-in document.
        /// <para>For example, for the document "The food was delicious and there
        /// were wonderful staff", the API returns the main talking points: "food"
        /// and "wonderful staff".</para>
        /// <para>For a list of languages supported by this operation, see
        /// <see href="https://aka.ms/talangs"/>.</para>
        /// <para>For document length limits, maximum batch size, and supported text encoding, see
        /// <see href="https://aka.ms/azsdk/textanalytics/data-limits"/>.</para>
        /// </summary>
        /// <param name="document">The document to analyze.</param>
        /// <param name="language">The language that the document is written in.
        /// If unspecified, this value will be set to the default language in
        /// <see cref="TextAnalyticsClientOptions.DefaultLanguage"/> in the request sent to the
        /// service.  If set to an empty string, the service will apply a model
        /// where the language is explicitly set to "None".</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/>
        /// controlling the request lifetime.</param>
        /// <returns>A result containing the collection of key phrases identified
        /// in the document.</returns>
        /// <exception cref="RequestFailedException">Service returned a non-success
        /// status code.</exception>
        public virtual Response<KeyPhraseCollection> ExtractKeyPhrases(string document, string language = default, CancellationToken cancellationToken = default) =>
            _serviceClient.ExtractKeyPhrases(document, language, cancellationToken);

        /// <summary>
        /// Runs a model to identify a collection of significant phrases
        /// found in the passed-in documents.
        /// <para>For example, for the document "The food was delicious and there
        /// were wonderful staff", the API returns the main talking points: "food"
        /// and "wonderful staff".</para>
        /// <para>For a list of languages supported by this operation, see
        /// <see href="https://aka.ms/talangs"/>.</para>
        /// <para>For document length limits, maximum batch size, and supported text encoding, see
        /// <see href="https://aka.ms/azsdk/textanalytics/data-limits"/>.</para>
        /// </summary>
        /// <param name="documents">The documents to analyze.</param>
        /// <param name="language">The language that all the documents are
        /// written in. If unspecified, this value will be set to the default
        /// language in <see cref="TextAnalyticsClientOptions.DefaultLanguage"/> in the request
        /// sent to the service.  If set to an empty string, the service will apply a model
        /// where the language is explicitly set to "None".</param>
        /// <param name="options"><see cref="TextAnalyticsRequestOptions"/> used to
        /// select the version of the predictive model to run, and whether
        /// statistics are returned in the response.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/>
        /// controlling the request lifetime.</param>
        /// <returns>A result containing the collection of key phrases identified
        /// in each of the documents.</returns>
        /// <exception cref="RequestFailedException">Service returned a non-success
        /// status code.</exception>
        public virtual async Task<Response<ExtractKeyPhrasesResultCollection>> ExtractKeyPhrasesBatchAsync(IEnumerable<string> documents, string language = default, TextAnalyticsRequestOptions options = default, CancellationToken cancellationToken = default) =>
            await _serviceClient.ExtractKeyPhrasesBatchAsync(documents, language, options, cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Runs a model to identify a collection of significant phrases
        /// found in the passed-in documents.
        /// <para>For example, for the document "The food was delicious and there
        /// were wonderful staff", the API returns the main talking points: "food"
        /// and "wonderful staff".</para>
        /// <para>For a list of languages supported by this operation, see
        /// <see href="https://aka.ms/talangs"/>.</para>
        /// <para>For document length limits, maximum batch size, and supported text encoding, see
        /// <see href="https://aka.ms/azsdk/textanalytics/data-limits"/>.</para>
        /// </summary>
        /// <param name="documents">The documents to analyze.</param>
        /// <param name="language">The language that all the documents are
        /// written in. If unspecified, this value will be set to the default
        /// language in <see cref="TextAnalyticsClientOptions"/> in the request
        /// sent to the service.  If set to an empty string, the service will apply a model
        /// where the language is explicitly set to "None".</param>
        /// <param name="options"><see cref="TextAnalyticsRequestOptions"/> used to
        /// select the version of the predictive model to run, and whether
        /// statistics are returned in the response.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/>
        /// controlling the request lifetime.</param>
        /// <returns>A result containing the collection of key phrases identified
        /// in each of the documents.</returns>
        /// <exception cref="RequestFailedException">Service returned a non-success
        /// status code.</exception>
        public virtual Response<ExtractKeyPhrasesResultCollection> ExtractKeyPhrasesBatch(IEnumerable<string> documents, string language = default, TextAnalyticsRequestOptions options = default, CancellationToken cancellationToken = default) =>
            _serviceClient.ExtractKeyPhrasesBatch(documents, language, options, cancellationToken);

        /// <summary>
        /// Runs a model to identify a collection of significant phrases
        /// found in the passed-in documents.
        /// <para>For example, for the document "The food was delicious and there
        /// were wonderful staff", the API returns the main talking points: "food"
        /// and "wonderful staff".</para>
        /// <para>For a list of languages supported by this operation, see
        /// <see href="https://aka.ms/talangs"/>.</para>
        /// <para>For document length limits, maximum batch size, and supported text encoding, see
        /// <see href="https://aka.ms/azsdk/textanalytics/data-limits"/>.</para>
        /// </summary>
        /// <param name="documents">The documents to analyze.</param>
        /// <param name="options"><see cref="TextAnalyticsRequestOptions"/> used to
        /// select the version of the predictive model to run, and whether
        /// statistics are returned in the response.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/>
        /// controlling the request lifetime.</param>
        /// <returns>A result containing the collection of key phrases identified
        /// in each of the documents.</returns>
        /// <exception cref="RequestFailedException">Service returned a non-success
        /// status code.</exception>
        public virtual async Task<Response<ExtractKeyPhrasesResultCollection>> ExtractKeyPhrasesBatchAsync(IEnumerable<TextDocumentInput> documents, TextAnalyticsRequestOptions options = default, CancellationToken cancellationToken = default) =>
            await _serviceClient.ExtractKeyPhrasesBatchAsync(documents, options, cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Runs a model to identify a collection of significant phrases
        /// found in the passed-in documents.
        /// <para>For example, for the document "The food was delicious and there
        /// were wonderful staff", the API returns the main talking points: "food"
        /// and "wonderful staff".</para>
        /// <para>For a list of languages supported by this operation, see
        /// <see href="https://aka.ms/talangs"/>.</para>
        /// <para>For document length limits, maximum batch size, and supported text encoding, see
        /// <see href="https://aka.ms/azsdk/textanalytics/data-limits"/>.</para>
        /// </summary>
        /// <param name="documents">The documents to analyze.</param>
        /// <param name="options"><see cref="TextAnalyticsRequestOptions"/> used to
        /// select the version of the predictive model to run, and whether
        /// statistics are returned in the response.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/>
        /// controlling the request lifetime.</param>
        /// <returns>A result containing the collection of key phrases identified
        /// in each of the documents.</returns>
        /// <exception cref="RequestFailedException">Service returned a non-success
        /// status code.</exception>
        public virtual Response<ExtractKeyPhrasesResultCollection> ExtractKeyPhrasesBatch(IEnumerable<TextDocumentInput> documents, TextAnalyticsRequestOptions options = default, CancellationToken cancellationToken = default) =>
            _serviceClient.ExtractKeyPhrasesBatch(documents, options, cancellationToken);

        #endregion

        #region Linked Entities

        /// <summary>
        /// Runs a predictive model to identify a collection of entities
        /// found in the passed-in document, and include information linking the
        /// entities to their corresponding entries in a well-known knowledge base.
        /// <para>For a list of languages supported by this operation, see
        /// <see href="https://aka.ms/talangs"/>.</para>
        /// <para>For document length limits, maximum batch size, and supported text encoding, see
        /// <see href="https://aka.ms/azsdk/textanalytics/data-limits"/>.</para>
        /// </summary>
        /// <param name="document">The document to analyze.</param>
        /// <param name="language">The language that the document is written in.
        /// If unspecified, this value will be set to the default language in
        /// <see cref="TextAnalyticsClientOptions.DefaultLanguage"/> in the request sent to the
        /// service.  If set to an empty string, the service will apply a model
        /// where the language is explicitly set to "None".</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/>
        /// controlling the request lifetime.</param>
        /// <returns>A result containing the collection of linked entities identified
        /// in the document, as well as scores indicating the confidence
        /// that the entity correctly matches the identified substring.</returns>
        /// <exception cref="RequestFailedException">Service returned a non-success
        /// status code.</exception>
        public virtual async Task<Response<LinkedEntityCollection>> RecognizeLinkedEntitiesAsync(string document, string language = default, CancellationToken cancellationToken = default) =>
            await _serviceClient.RecognizeLinkedEntitiesAsync(document, language, cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Runs a predictive model to identify a collection of entities
        /// found in the passed-in document, and include information linking the
        /// entities to their corresponding entries in a well-known knowledge base.
        /// <para>For a list of languages supported by this operation, see
        /// <see href="https://aka.ms/talangs"/>.</para>
        /// <para>For document length limits, maximum batch size, and supported text encoding, see
        /// <see href="https://aka.ms/azsdk/textanalytics/data-limits"/>.</para>
        /// </summary>
        /// <param name="document">The document to analyze.</param>
        /// <param name="language">The language that the document is written in.
        /// If unspecified, this value will be set to the default language in
        /// <see cref="TextAnalyticsClientOptions.DefaultLanguage"/> in the request sent to the
        /// service.  If set to an empty string, the service will apply a model
        /// where the language is explicitly set to "None".</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/>
        /// controlling the request lifetime.</param>
        /// <returns>A result containing the collection of linked entities identified
        /// in the document, as well as scores indicating the confidence
        /// that the entity correctly matches the identified substring.</returns>
        /// <exception cref="RequestFailedException">Service returned a non-success
        /// status code.</exception>
        public virtual Response<LinkedEntityCollection> RecognizeLinkedEntities(string document, string language = default, CancellationToken cancellationToken = default) =>
            _serviceClient.RecognizeLinkedEntities(document, language, cancellationToken);

        /// <summary>
        /// Runs a predictive model to identify a collection of entities
        /// found in the passed-in documents, and include information linking the
        /// entities to their corresponding entries in a well-known knowledge base.
        /// <para>For a list of languages supported by this operation, see
        /// <see href="https://aka.ms/talangs"/>.</para>
        /// <para>For document length limits, maximum batch size, and supported text encoding, see
        /// <see href="https://aka.ms/azsdk/textanalytics/data-limits"/>.</para>
        /// </summary>
        /// <param name="documents">The documents to analyze.</param>
        /// <param name="language">The language that the documents are written in.
        /// If unspecified, this value will be set to the default language in
        /// <see cref="TextAnalyticsClientOptions.DefaultLanguage"/> in the request sent to the
        /// service.  If set to an empty string, the service will apply a model
        /// where the language is explicitly set to "None".</param>
        /// <param name="options"><see cref="TextAnalyticsRequestOptions"/> used to
        /// select the version of the predictive model to run, and whether
        /// statistics are returned in the response.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/>
        /// controlling the request lifetime.</param>
        /// <returns>A result containing the collection of entities identified
        /// for each of the documents, as well as scores indicating the confidence
        /// that a given entity correctly matches the identified substring.</returns>
        /// <exception cref="RequestFailedException">Service returned a non-success
        /// status code.</exception>
        public virtual async Task<Response<RecognizeLinkedEntitiesResultCollection>> RecognizeLinkedEntitiesBatchAsync(IEnumerable<string> documents, string language = default, TextAnalyticsRequestOptions options = default, CancellationToken cancellationToken = default) =>
            await _serviceClient.RecognizeLinkedEntitiesBatchAsync(documents, language, options, cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Runs a predictive model to identify a collection of entities
        /// found in the passed-in documents, and include information linking the
        /// entities to their corresponding entries in a well-known knowledge base.
        /// <para>For a list of languages supported by this operation, see
        /// <see href="https://aka.ms/talangs"/>.</para>
        /// <para>For document length limits, maximum batch size, and supported text encoding, see
        /// <see href="https://aka.ms/azsdk/textanalytics/data-limits"/>.</para>
        /// </summary>
        /// <param name="documents">The documents to analyze.</param>
        /// <param name="language">The language that the documents are written in.
        /// If unspecified, this value will be set to the default language in
        /// <see cref="TextAnalyticsClientOptions.DefaultLanguage"/> in the request sent to the
        /// service.  If set to an empty string, the service will apply a model
        /// where the language is explicitly set to "None".</param>
        /// <param name="options"><see cref="TextAnalyticsRequestOptions"/> used to
        /// select the version of the predictive model to run, and whether
        /// statistics are returned in the response.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/>
        /// controlling the request lifetime.</param>
        /// <returns>A result containing the collection of entities identified
        /// for each of the documents, as well as scores indicating the confidence
        /// that a given entity correctly matches the identified substring.</returns>
        /// <exception cref="RequestFailedException">Service returned a non-success
        /// status code.</exception>
        public virtual Response<RecognizeLinkedEntitiesResultCollection> RecognizeLinkedEntitiesBatch(IEnumerable<string> documents, string language = default, TextAnalyticsRequestOptions options = default, CancellationToken cancellationToken = default) =>
            _serviceClient.RecognizeLinkedEntitiesBatch(documents, language, options, cancellationToken);

        /// <summary>
        /// Runs a predictive model to identify a collection of entities
        /// found in the passed-in documents, and include information linking the
        /// entities to their corresponding entries in a well-known knowledge base.
        /// <para>For a list of languages supported by this operation, see
        /// <see href="https://aka.ms/talangs"/>.</para>
        /// <para>For document length limits, maximum batch size, and supported text encoding, see
        /// <see href="https://aka.ms/azsdk/textanalytics/data-limits"/>.</para>
        /// </summary>
        /// <param name="documents">The documents to analyze.</param>
        /// <param name="options"><see cref="TextAnalyticsRequestOptions"/> used to
        /// select the version of the predictive model to run, and whether
        /// statistics are returned in the response.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/>
        /// controlling the request lifetime.</param>
        /// <returns>A result containing the collection of entities identified
        /// for each of the documents, as well as scores indicating the confidence
        /// that a given entity correctly matches the identified substring.</returns>
        /// <exception cref="RequestFailedException">Service returned a non-success
        /// status code.</exception>
        public virtual async Task<Response<RecognizeLinkedEntitiesResultCollection>> RecognizeLinkedEntitiesBatchAsync(IEnumerable<TextDocumentInput> documents, TextAnalyticsRequestOptions options = default, CancellationToken cancellationToken = default) =>
            await _serviceClient.RecognizeLinkedEntitiesBatchAsync(documents, options, cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Runs a predictive model to identify a collection of entities
        /// found in the passed-in documents, and include information linking the
        /// entities to their corresponding entries in a well-known knowledge base.
        /// <para>For a list of languages supported by this operation, see
        /// <see href="https://aka.ms/talangs"/>.</para>
        /// <para>For document length limits, maximum batch size, and supported text encoding, see
        /// <see href="https://aka.ms/azsdk/textanalytics/data-limits"/>.</para>
        /// </summary>
        /// <param name="documents">The documents to analyze.</param>
        /// <param name="options"><see cref="TextAnalyticsRequestOptions"/> used to
        /// select the version of the predictive model to run, and whether
        /// statistics are returned in the response.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/>
        /// controlling the request lifetime.</param>
        /// <returns>A result containing the collection of entities identified
        /// for each of the documents, as well as scores indicating the confidence
        /// that a given entity correctly matches the identified substring.</returns>
        /// <exception cref="RequestFailedException">Service returned a non-success
        /// status code.</exception>
        public virtual Response<RecognizeLinkedEntitiesResultCollection> RecognizeLinkedEntitiesBatch(IEnumerable<TextDocumentInput> documents, TextAnalyticsRequestOptions options = default, CancellationToken cancellationToken = default) =>
            _serviceClient.RecognizeLinkedEntitiesBatch(documents, options, cancellationToken);

        #endregion

        #region Healthcare

        /// <summary>
        /// Runs a predictive model to identify a collection of healthcare entities
        /// found in the passed-in document, and include information linking the
        /// entities to their corresponding entries in a well-known knowledge base.
        /// For a list of languages supported by this operation, see
        /// <see href="https://aka.ms/talangs"/>.
        /// For document length limits, maximum batch size, and supported text encoding, see
        /// <see href="https://aka.ms/azsdk/textanalytics/data-limits"/>.
        /// </summary>
        /// <remarks>
        /// This method is only available for <see cref="TextAnalyticsClientOptions.ServiceVersion.V3_1"/>, <see cref="TextAnalyticsClientOptions.ServiceVersion.V2022_05_01"/>, and up.
        /// </remarks>
        /// <param name="documents">The documents to analyze.</param>
        /// <param name="language">The language that the document is written in.</param>
        /// <param name="options">The additional configurable <see cref="AnalyzeHealthcareEntitiesOptions"/> </param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/>
        /// controlling the request lifetime.</param>
        /// <exception cref="RequestFailedException">Service returned a non-success
        /// status code.</exception>
        public virtual async Task<AnalyzeHealthcareEntitiesOperation> StartAnalyzeHealthcareEntitiesAsync(IEnumerable<string> documents, string language = default, AnalyzeHealthcareEntitiesOptions options = default, CancellationToken cancellationToken = default) =>
            await _serviceClient.StartAnalyzeHealthcareEntitiesAsync(documents, language, options, cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Runs a predictive model to identify a collection of healthcare entities
        /// found in the passed-in document, and include information linking the
        /// entities to their corresponding entries in a well-known knowledge base.
        /// For a list of languages supported by this operation, see
        /// <see href="https://aka.ms/talangs"/>.
        /// For document length limits, maximum batch size, and supported text encoding, see
        /// <see href="https://aka.ms/azsdk/textanalytics/data-limits"/>.
        /// </summary>
        /// <remarks>
        /// This method is only available for <see cref="TextAnalyticsClientOptions.ServiceVersion.V3_1"/>, <see cref="TextAnalyticsClientOptions.ServiceVersion.V2022_05_01"/>, and up.
        /// </remarks>
        /// <param name="documents">The documents to analyze.</param>
        /// <param name="language">The language that the document is written in.
        /// If unspecified, this value will be set to the default language in
        /// <see cref="TextAnalyticsClientOptions"/> in the request sent to the
        /// service.  If set to an empty string, the service will apply a model
        /// where the language is explicitly set to "None".</param>
        /// <param name="options">The additional configurable options<see cref="AnalyzeHealthcareEntitiesOptions"/></param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/>
        /// controlling the request lifetime.</param>
        /// <returns>A result containing the collection of entities identified
        /// for each of the documents, as well as scores indicating the confidence
        /// that a given entity correctly matches the identified substring.</returns>
        /// <exception cref="RequestFailedException">Service returned a non-success
        /// status code.</exception>
        public virtual AnalyzeHealthcareEntitiesOperation StartAnalyzeHealthcareEntities(IEnumerable<string> documents, string language = default, AnalyzeHealthcareEntitiesOptions options = default, CancellationToken cancellationToken = default) =>
            _serviceClient.StartAnalyzeHealthcareEntities(documents, language, options, cancellationToken);

        /// <summary>
        /// Runs a predictive model to identify a collection of healthcare entities
        /// found in the passed-in document, and include information linking the
        /// entities to their corresponding entries in a well-known knowledge base.
        /// For a list of languages supported by this operation, see
        /// <see href="https://aka.ms/talangs"/>.
        /// For document length limits, maximum batch size, and supported text encoding, see
        /// <see href="https://aka.ms/azsdk/textanalytics/data-limits"/>.
        /// </summary>
        /// <remarks>
        /// This method is only available for <see cref="TextAnalyticsClientOptions.ServiceVersion.V3_1"/>, <see cref="TextAnalyticsClientOptions.ServiceVersion.V2022_05_01"/>, and up.
        /// </remarks>
        /// <param name="documents">The documents to analyze.</param>
        /// <param name="options">The additional configurable options<see cref="AnalyzeHealthcareEntitiesOptions"/></param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <returns>A <see cref="AnalyzeHealthcareEntitiesOperation"/> to wait on this long-running operation.  Its <see cref="AnalyzeHealthcareEntitiesOperation.Value"/> upon successful
        /// completion will contain layout elements extracted from the form.</returns>
        public virtual AnalyzeHealthcareEntitiesOperation StartAnalyzeHealthcareEntities(IEnumerable<TextDocumentInput> documents, AnalyzeHealthcareEntitiesOptions options, CancellationToken cancellationToken = default) =>
            _serviceClient.StartAnalyzeHealthcareEntities(documents, options, cancellationToken);

        /// <summary>
        /// Runs a predictive model to identify a collection of healthcare entities
        /// found in the passed-in document, and include information linking the
        /// entities to their corresponding entries in a well-known knowledge base.
        /// For a list of languages supported by this operation, see
        /// <see href="https://aka.ms/talangs"/>.
        /// For document length limits, maximum batch size, and supported text encoding, see
        /// <see href="https://aka.ms/azsdk/textanalytics/data-limits"/>.
        /// </summary>
        /// <remarks>
        /// This method is only available for <see cref="TextAnalyticsClientOptions.ServiceVersion.V3_1"/>, <see cref="TextAnalyticsClientOptions.ServiceVersion.V2022_05_01"/>, and up.
        /// </remarks>
        /// <param name="documents">The documents to analyze.</param>
        /// <param name="options">The additional configurable options<see cref="AnalyzeHealthcareEntitiesOptions"/></param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <returns>A <see cref="AnalyzeHealthcareEntitiesOperation"/> to wait on this long-running operation.  Its <see cref="AnalyzeHealthcareEntitiesOperation.Value"/> upon successful
        /// completion will contain layout elements extracted from the form.</returns>
        public virtual async Task<AnalyzeHealthcareEntitiesOperation> StartAnalyzeHealthcareEntitiesAsync(IEnumerable<TextDocumentInput> documents, AnalyzeHealthcareEntitiesOptions options = default, CancellationToken cancellationToken = default) =>
            await _serviceClient.StartAnalyzeHealthcareEntitiesAsync(documents, options, cancellationToken).ConfigureAwait(false);

        #endregion

        #region Analyze Operation

        /// <summary>
        /// StartAnalyzeActionsAsync enables the application to execute multiple actions in a set of documents. It includes:
        /// <list type="bullet">
        /// <item><description>Entity Recognition (Named, Linked, and Personally Identifiable Information (PII) entities)</description></item>
        /// <item><description>Key Phrases Extraction</description></item>
        /// <item><description>Sentiment Analysis</description></item>
        /// <item><description>Extractive Text Summarization</description></item>
        /// <item><description>Custom Entity Recognition</description></item>
        /// <item><description>Custom Single and Multi Label Classification</description></item>
        /// </list>
        /// <para>For document length limits, maximum batch size, and supported text encoding, see more information
        /// <see href="https://aka.ms/azsdk/textanalytics/data-limits">here</see>.
        /// </para>
        /// </summary>
        /// <remarks>
        /// This method is only available for <see cref="TextAnalyticsClientOptions.ServiceVersion.V3_1"/>, <see cref="TextAnalyticsClientOptions.ServiceVersion.V2022_05_01"/>, and up.
        /// See the service <see href="https://aka.ms/azsdk/textanalytics/customfunctionalities">documentation</see> for regional support of custom action features.
        /// </remarks>
        /// <param name="documents">The list of documents to analyze.</param>
        /// <param name="language">The language that the document is written in.</param>
        /// <param name="actions"> The different <see cref="TextAnalyticsActions"/> to execute in the list of documents.</param>
        /// <param name="options">Sets the IncludeStatistcs property on the analyze action operation. </param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <exception cref="RequestFailedException">Service returned a non-success
        /// status code.</exception>
        public virtual async Task<AnalyzeActionsOperation> StartAnalyzeActionsAsync(IEnumerable<string> documents, TextAnalyticsActions actions, string language = default, AnalyzeActionsOptions options = default, CancellationToken cancellationToken = default) =>
            await _serviceClient.StartAnalyzeActionsAsync(documents, actions, language, options, cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// StartAnalyzeActionsAsync enables the application to execute multiple actions in a set of documents. It includes:
        /// <list type="bullet">
        /// <item><description>Entity Recognition (Named, Linked, and Personally Identifiable Information (PII) entities)</description></item>
        /// <item><description>Key Phrases Extraction</description></item>
        /// <item><description>Sentiment Analysis</description></item>
        /// <item><description>Extractive Text Summarization</description></item>
        /// <item><description>Custom Entity Recognition</description></item>
        /// <item><description>Custom Single and Multi Label Classification</description></item>
        /// </list>
        /// <para>For document length limits, maximum batch size, and supported text encoding, see
        /// <see href="https://aka.ms/azsdk/textanalytics/data-limits">here</see>.
        /// </para>
        /// </summary>
        /// <remarks>
        /// This method is only available for <see cref="TextAnalyticsClientOptions.ServiceVersion.V3_1"/>, <see cref="TextAnalyticsClientOptions.ServiceVersion.V2022_05_01"/>, and up.
        /// See the service <see href="https://aka.ms/azsdk/textanalytics/customfunctionalities">documentation</see> for regional support of custom action features.
        /// </remarks>
        /// <param name="documents">The list of documents to analyze.</param>
        /// <param name="actions"> The different <see cref="TextAnalyticsActions"/> to execute in the list of documents.</param>
        /// <param name="language">The language that the document is written in.</param>
        /// <param name="options">Sets the IncludeStatistcs property on the analyze action operation. </param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <exception cref="RequestFailedException">Service returned a non-success
        /// status code.</exception>
        public virtual AnalyzeActionsOperation StartAnalyzeActions(IEnumerable<string> documents, TextAnalyticsActions actions, string language = default, AnalyzeActionsOptions options = default, CancellationToken cancellationToken = default) =>
            _serviceClient.StartAnalyzeActions(documents, actions, language, options, cancellationToken);

        /// <summary>
        /// StartAnalyzeActionsAsync enables the application to execute multiple actions in a set of documents. It includes:
        /// <list type="bullet">
        /// <item><description>Entity Recognition (Named, Linked, and Personally Identifiable Information (PII) entities)</description></item>
        /// <item><description>Key Phrases Extraction</description></item>
        /// <item><description>Sentiment Analysis</description></item>
        /// <item><description>Extractive Text Summarization</description></item>
        /// <item><description>Custom Entity Recognition</description></item>
        /// <item><description>Custom Single and Multi Label Classification</description></item>
        /// </list>
        /// <para>For document length limits, maximum batch size, and supported text encoding, see
        /// <see href="https://aka.ms/azsdk/textanalytics/data-limits">here</see>.
        /// </para>
        /// </summary>
        /// <remarks>
        /// This method is only available for <see cref="TextAnalyticsClientOptions.ServiceVersion.V3_1"/>, <see cref="TextAnalyticsClientOptions.ServiceVersion.V2022_05_01"/>, and up.
        /// See the service <see href="https://aka.ms/azsdk/textanalytics/customfunctionalities">documentation</see> for regional support of custom action features.
        /// </remarks>
        /// <param name="documents">The list of documents to analyze.</param>
        /// <param name="actions"> The different <see cref="TextAnalyticsActions"/> to execute in the list of documents.</param>
        /// <param name="options">Sets the IncludeStatistcs property on the analyze action operation. </param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <exception cref="RequestFailedException">Service returned a non-success
        /// status code.</exception>
        public virtual AnalyzeActionsOperation StartAnalyzeActions(IEnumerable<TextDocumentInput> documents, TextAnalyticsActions actions, AnalyzeActionsOptions options = default, CancellationToken cancellationToken = default) =>
            _serviceClient.StartAnalyzeActions(documents, actions, options, cancellationToken);

        /// <summary>
        /// StartAnalyzeActionsAsync enables the application to execute multiple actions in a set of documents. It includes:
        /// <list type="bullet">
        /// <item><description>Entity Recognition (Named, Linked, and Personally Identifiable Information (PII) entities)</description></item>
        /// <item><description>Key Phrases Extraction</description></item>
        /// <item><description>Sentiment Analysis</description></item>
        /// <item><description>Extractive Text Summarization</description></item>
        /// <item><description>Custom Entity Recognition</description></item>
        /// <item><description>Custom Single and Multi Label Classification</description></item>
        /// </list>
        /// <para>For document length limits, maximum batch size, and supported text encoding, see
        /// <see href="https://aka.ms/azsdk/textanalytics/data-limits">here</see>.
        /// </para>
        /// </summary>
        /// <remarks>
        /// This method is only available for <see cref="TextAnalyticsClientOptions.ServiceVersion.V3_1"/>, <see cref="TextAnalyticsClientOptions.ServiceVersion.V2022_05_01"/>, and up.
        /// See the service <see href="https://aka.ms/azsdk/textanalytics/customfunctionalities">documentation</see> for regional support of custom action features.
        /// </remarks>
        /// <param name="documents">The list of documents to analyze.</param>
        /// <param name="actions"> The different <see cref="TextAnalyticsActions"/> to execute in the list of documents.</param>
        /// <param name="options">Sets the IncludeStatistcs property on the analyze action operation. </param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <exception cref="RequestFailedException">Service returned a non-success
        /// status code.</exception>
        public virtual async Task<AnalyzeActionsOperation> StartAnalyzeActionsAsync(IEnumerable<TextDocumentInput> documents, TextAnalyticsActions actions, AnalyzeActionsOptions options = default, CancellationToken cancellationToken = default) =>
            await _serviceClient.StartAnalyzeActionsAsync(documents, actions, options, cancellationToken).ConfigureAwait(false);

        #endregion

        #region nobody wants to see these
        /// <summary>
        /// Check if two TextAnalyticsClient instances are equal.
        /// </summary>
        /// <param name="obj">The instance to compare to.</param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => base.Equals(obj);

        /// <summary>
        /// Get a hash code for the TextAnalyticsClient.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => base.GetHashCode();

        /// <summary>
        /// TextAnalyticsClient ToString.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override string ToString() => base.ToString();
        #endregion
    }
}
