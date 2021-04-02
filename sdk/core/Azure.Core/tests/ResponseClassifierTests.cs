﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.Core.TestFramework;
using NUnit.Framework;

namespace Azure.Core.Tests
{
    public class ResponseClassifierTests
    {
        [Theory]
        [TestCase(500)]
        [TestCase(429)]
        [TestCase(408)]
        [TestCase(502)]
        [TestCase(503)]
        [TestCase(504)]
        public void RetriesStatusCodes(int code)
        {
            var httpMessage = new HttpMessage(new MockRequest(), new ResponseClassifier());
            httpMessage.Response = new MockResponse(code);

            Assert.True(httpMessage.ResponseClassifier.IsRetriableResponse(httpMessage));
        }

        [Test]
        public void RetriesRequestFailedExceptionsWithoutCode()
        {
            var classifier = new ResponseClassifier();

            Assert.True(classifier.IsRetriableException(new RequestFailedException(0, "IO Exception")));
        }

        [Test]
        public void DoesntRetryRequestFailedExceptionsWithStatusCode()
        {
            var classifier = new ResponseClassifier();

            Assert.False(classifier.IsRetriableException(new RequestFailedException(500, "IO Exception")));
        }

        [Test]
        public void RetriesNonCustomerOperationCancelledExceptions()
        {
            var httpMessage = new HttpMessage(new MockRequest(), new ResponseClassifier());

            Assert.True(httpMessage.ResponseClassifier.IsRetriable(httpMessage, new OperationCanceledException()));
        }

        [TestCase(409, "If-Match")]
        [TestCase(409,"If-None-Match")]
        [TestCase(409,"If-Unmodified-Since")]
        [TestCase(409,"If-Modified-Since")]
        [TestCase(412, "If-Match")]
        [TestCase(412, "If-None-Match")]
        [TestCase(412, "If-Unmodified-Since")]
        [TestCase(412, "If-Modified-Since")]
        public void ConditionalRequestsWith409ResponseNotErrors(int code, string header)
        {
            var classifier = new ResponseClassifier();
            var mockRequest = new MockRequest();
            mockRequest.AddHeader(header, "value");
            var httpMessage = new HttpMessage(mockRequest, new ResponseClassifier());

            httpMessage.Response = new MockResponse(code);
            Assert.False(classifier.IsErrorResponse(httpMessage));
        }
    }
}