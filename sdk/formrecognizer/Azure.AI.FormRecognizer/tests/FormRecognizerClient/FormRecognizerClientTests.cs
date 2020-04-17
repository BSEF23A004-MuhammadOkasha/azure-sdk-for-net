﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Azure.AI.FormRecognizer.Models;
using Azure.Core.Testing;
using NUnit.Framework;

namespace Azure.AI.FormRecognizer.Tests
{
    /// <summary>
    /// The suite of tests for the <see cref="FormRecognizerClient"/> class.
    /// </summary>
    public class FormRecognizerClientTests : ClientTestBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormRecognizerClientTests"/> class.
        /// </summary>
        /// <param name="isAsync">A flag used by the Azure Core Test Framework to differentiate between tests for asynchronous and synchronous methods.</param>
        public FormRecognizerClientTests(bool isAsync) : base(isAsync)
        {
        }

        /// <summary>
        /// Creates a fake <see cref="FormRecognizerClient" /> and instruments it to make use of the Azure Core
        /// Test Framework functionalities.
        /// </summary>
        /// <returns>The instrumented <see cref="FormRecognizerClient" />.</returns>
        private FormRecognizerClient CreateInstrumentedClient()
        {
            var fakeEndpoint = new Uri("http://localhost");
            var fakeCredential = new AzureKeyCredential("fakeKey");
            var client = new FormRecognizerClient(fakeEndpoint, fakeCredential);

            return InstrumentClient(client);
        }

        /// <summary>
        /// Verifies functionality of the <see cref="FormRecognizerClient"/> constructors.
        /// </summary>
        [Test]
        public void ConstructorRequiresTheEndpoint()
        {
            var credential = new AzureKeyCredential("key");

            Assert.Throws<ArgumentNullException>(() => new FormRecognizerClient(null, credential));
            Assert.Throws<ArgumentNullException>(() => new FormRecognizerClient(null, credential, new FormRecognizerClientOptions()));
        }

        /// <summary>
        /// Verifies functionality of the <see cref="FormRecognizerClient"/> constructors.
        /// </summary>
        [Test]
        public void ConstructorRequiresTheCredential()
        {
            var endpoint = new Uri("http://localhost");

            Assert.Throws<ArgumentNullException>(() => new FormRecognizerClient(endpoint, null));
            Assert.Throws<ArgumentNullException>(() => new FormRecognizerClient(endpoint, null, new FormRecognizerClientOptions()));
        }

        /// <summary>
        /// Verifies functionality of the <see cref="FormRecognizerClient"/> constructors.
        /// </summary>
        [Test]
        public void ConstructorRequiresTheOptions()
        {
            var endpoint = new Uri("http://localhost");
            var credential = new AzureKeyCredential("key");

            Assert.Throws<ArgumentNullException>(() => new FormRecognizerClient(endpoint, credential, null));
        }

        /// <summary>
        /// Verifies functionality of the <see cref="FormRecognizerClient.StartRecognizeContentAsync"/>
        /// method.
        /// </summary>
        [Test]
        public void StartRecognizeContentRequiresTheFormFileStream()
        {
            var client = CreateInstrumentedClient();
            Assert.ThrowsAsync<ArgumentNullException>(async () => await client.StartRecognizeContentAsync(null));
        }

        /// <summary>
        /// Verifies functionality of the <see cref="FormRecognizerClient.StartRecognizeContentAsync"/>
        /// method.
        /// </summary>
        [Test]
        public void StartRecognizeContentRespectsTheCancellationToken()
        {
            var client = CreateInstrumentedClient();
            var options = new RecognizeOptions { ContentType = ContentType.Pdf };

            using var stream = new MemoryStream(Array.Empty<byte>());
            using var cancellationSource = new CancellationTokenSource();
            cancellationSource.Cancel();

            Assert.ThrowsAsync<TaskCanceledException>(async () => await client.StartRecognizeContentAsync(stream, options, cancellationSource.Token));
        }

        /// <summary>
        /// Verifies functionality of the <see cref="FormRecognizerClient.StartRecognizeContentFromUriAsync"/>
        /// method.
        /// </summary>
        [Test]
        public void StartRecognizeContentFromUriRequiresTheFormFileUri()
        {
            var client = CreateInstrumentedClient();
            Assert.ThrowsAsync<ArgumentNullException>(async () => await client.StartRecognizeContentFromUriAsync(null));
        }

        /// <summary>
        /// Verifies functionality of the <see cref="FormRecognizerClient.StartRecognizeContentFromUriAsync"/>
        /// method.
        /// </summary>
        [Test]
        public void StartRecognizeContentFromUriRespectsTheCancellationToken()
        {
            var client = CreateInstrumentedClient();
            var fakeUri = new Uri("http://localhost");

            using var cancellationSource = new CancellationTokenSource();
            cancellationSource.Cancel();

            Assert.ThrowsAsync<TaskCanceledException>(async () => await client.StartRecognizeContentFromUriAsync(fakeUri, cancellationToken: cancellationSource.Token));
        }

        /// <summary>
        /// Verifies functionality of the <see cref="FormRecognizerClient.StartRecognizeReceiptsAsync"/>
        /// method.
        /// </summary>
        [Test]
        public void StartRecognizeReceiptsRequiresTheReceiptFileStream()
        {
            var client = CreateInstrumentedClient();
            Assert.ThrowsAsync<ArgumentNullException>(async () => await client.StartRecognizeReceiptsAsync(null));
        }

        /// <summary>
        /// Verifies functionality of the <see cref="FormRecognizerClient.StartRecognizeReceiptsAsync"/>
        /// method.
        /// </summary>
        [Test]
        public void StartRecognizeReceiptsRespectsTheCancellationToken()
        {
            var client = CreateInstrumentedClient();
            var options = new RecognizeOptions { ContentType = ContentType.Pdf };

            using var stream = new MemoryStream(Array.Empty<byte>());
            using var cancellationSource = new CancellationTokenSource();
            cancellationSource.Cancel();

            Assert.ThrowsAsync<TaskCanceledException>(async () => await client.StartRecognizeReceiptsAsync(stream, recognizeOptions: options, cancellationToken: cancellationSource.Token));
        }

        /// <summary>
        /// Verifies functionality of the <see cref="FormRecognizerClient.StartRecognizeReceiptsFromUriAsync"/>
        /// method.
        /// </summary>
        [Test]
        public void StartRecognizeReceiptsFromUriRequiresTheReceiptFileUri()
        {
            var client = CreateInstrumentedClient();
            Assert.ThrowsAsync<ArgumentNullException>(async () => await client.StartRecognizeReceiptsFromUriAsync(null));
        }

        /// <summary>
        /// Verifies functionality of the <see cref="FormRecognizerClient.StartRecognizeReceiptsFromUriAsync"/>
        /// method.
        /// </summary>
        [Test]
        public void StartRecognizeReceiptsFromUriRespectsTheCancellationToken()
        {
            var client = CreateInstrumentedClient();
            var fakeUri = new Uri("http://localhost");

            using var cancellationSource = new CancellationTokenSource();
            cancellationSource.Cancel();

            Assert.ThrowsAsync<TaskCanceledException>(async () => await client.StartRecognizeReceiptsFromUriAsync(fakeUri, cancellationToken: cancellationSource.Token));
        }

    }
}
