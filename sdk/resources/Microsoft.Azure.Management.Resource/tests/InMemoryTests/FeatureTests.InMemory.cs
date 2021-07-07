﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Microsoft.Azure.Management.ResourceManager;
using Microsoft.Rest;
using Microsoft.Azure.Test.HttpRecorder;
using System;
using System.Net;
using System.Net.Http;
using Xunit;


namespace ResourceGroups.Tests
{
    public class InMemoryFeatureTests
    {
        public FeatureClient GetFeatureClient(RecordedDelegatingHandler handler)
        {
            var subscriptionId = Guid.NewGuid().ToString();
            var token = new TokenCredentials(subscriptionId, "abc123");
            handler.IsPassThrough = false;
            var client = new FeatureClient(token, handler);
            client.SubscriptionId = subscriptionId;
            HttpMockServer.Mode = HttpRecorderMode.Playback;
            return client;
        }


        [Fact]
        public void RegisterFeature()
        {
            var response = new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(@"{
                      'name': 'Providers.Test/DONOTDELETEBETA',

                      'properties': {

                        'state': 'NotRegistered'

                      },

                      'id': '/subscriptions/fda3b6ba-8803-441c-91fb-6cc798cf6ea0/providers/Microsoft.Features/providers/Providers.Test/features/DONOTDELETEBETA',

                      'type': 'Microsoft.Features/providers/features'
                }")
            };

            var handler = new RecordedDelegatingHandler() { StatusCodeToReturn = HttpStatusCode.OK };

            var client = GetFeatureClient(handler);

            string resourceProviderNamespace = "Providers.Test";

            string featureName = "DONOTDELETEBETA";

            string apiVersion = "2015-12-01";

            var registerResult = client.Features.Register(resourceProviderNamespace, featureName, apiVersion);

            // Validate headers 
            Assert.Equal(HttpMethod.Post, handler.Method);
            Assert.NotNull(handler.RequestHeaders.GetValues("Authorization"));

            //Valid payload
            //Construct expected URL
            string expectedUrl = "/subscriptions/" + Uri.EscapeDataString(client.SubscriptionId) + "/providers/Microsoft.Features/providers/" + Uri.EscapeDataString(resourceProviderNamespace) + "/features/" + Uri.EscapeDataString(featureName) + "/register?";
            expectedUrl = expectedUrl + "api-version=2015-12-01";
            string baseUrl = client.BaseUri.AbsoluteUri;
            // Trim '/' character from the end of baseUrl and beginning of url.
            if (baseUrl[baseUrl.Length - 1] == '/')
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            if (expectedUrl[0] == '/')
            {
                expectedUrl = expectedUrl.Substring(1);
            }
            expectedUrl = baseUrl + "/" + expectedUrl;
            expectedUrl = expectedUrl.Replace(" ", "%20");

            Assert.Equal(expectedUrl, handler.Uri.ToString());
        }

        [Fact]
        public void UnRegisterFeature()
        {
            var response = new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(@"{
                      'name': 'Providers.Test/DONOTDELETEBETA',

                      'properties': {

                        'state': 'NotRegistered'

                      },

                      'id': '/subscriptions/fda3b6ba-8803-441c-91fb-6cc798cf6ea0/providers/Microsoft.Features/providers/Providers.Test/features/DONOTDELETEBETA',

                      'type': 'Microsoft.Features/providers/features'
                }")
            };

            var handler = new RecordedDelegatingHandler() { StatusCodeToReturn = HttpStatusCode.OK };

            var client = GetFeatureClient(handler);

            string resourceProviderNamespace = "Providers.Test";

            string featureName = "DONOTDELETEBETA";

            string apiVersion = "2015-12-01";

            var registerResult = client.Features.Unregister(resourceProviderNamespace, featureName, apiVersion);

            // Validate headers 
            Assert.Equal(HttpMethod.Post, handler.Method);
            Assert.NotNull(handler.RequestHeaders.GetValues("Authorization"));

            //Valid payload
            //Construct expected URL
            string expectedUrl = "/subscriptions/" + Uri.EscapeDataString(client.SubscriptionId) + "/providers/Microsoft.Features/providers/" + Uri.EscapeDataString(resourceProviderNamespace) + "/features/" + Uri.EscapeDataString(featureName) + "/unregister?";
            expectedUrl = expectedUrl + "api-version=2015-12-01";
            string baseUrl = client.BaseUri.AbsoluteUri;
            // Trim '/' character from the end of baseUrl and beginning of url.
            if (baseUrl[baseUrl.Length - 1] == '/')
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            if (expectedUrl[0] == '/')
            {
                expectedUrl = expectedUrl.Substring(1);
            }
            expectedUrl = baseUrl + "/" + expectedUrl;
            expectedUrl = expectedUrl.Replace(" ", "%20");

            Assert.Equal(expectedUrl, handler.Uri.ToString());
        }

        [Fact]
        public void CreateFeatureRegistration()
        {
            var handler = new RecordedDelegatingHandler() { StatusCodeToReturn = HttpStatusCode.OK };

            var client = GetFeatureClient(handler);
            
            string resourceProviderNamespace = "Providers.Test";

            client.ProviderNamespace = resourceProviderNamespace;

            string featureName = "DONOTDELETEBETA";

            string apiVersion = "2021-07-01";

            var registerResult = client.SubscriptionFeatureRegistrations.CreateOrUpdate(featureName: featureName, apiVersion: apiVersion);

            // Validate headers 
            Assert.Equal(HttpMethod.Put, handler.Method);
            Assert.NotNull(handler.RequestHeaders.GetValues("Authorization"));

            //Valid payload
            //Construct expected URL
            string expectedUrl = "/subscriptions/" + Uri.EscapeDataString(client.SubscriptionId) + "/providers/Microsoft.Features/featureProviders/" + Uri.EscapeDataString(resourceProviderNamespace) + "/subscriptionFeatureRegistrations/" + Uri.EscapeDataString(featureName) + "?";
            expectedUrl = expectedUrl + $"api-version={apiVersion}";
            string baseUrl = client.BaseUri.AbsoluteUri;
            // Trim '/' character from the end of baseUrl and beginning of url.
            if (baseUrl[baseUrl.Length - 1] == '/')
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            if (expectedUrl[0] == '/')
            {
                expectedUrl = expectedUrl.Substring(1);
            }
            expectedUrl = baseUrl + "/" + expectedUrl;
            expectedUrl = expectedUrl.Replace(" ", "%20");

            Assert.Equal(expectedUrl, handler.Uri.ToString());
        }

        [Fact]
        public void DeleteFeatureRegistration()
        {
            var handler = new RecordedDelegatingHandler() { StatusCodeToReturn = HttpStatusCode.OK };

            var client = GetFeatureClient(handler);

            string resourceProviderNamespace = "Providers.Test";

            client.ProviderNamespace = resourceProviderNamespace;

            string featureName = "DONOTDELETEBETA";

            string apiVersion = "2021-07-01";

            client.SubscriptionFeatureRegistrations.Delete(featureName: featureName, apiVersion: apiVersion);

            // Validate headers 
            Assert.Equal(HttpMethod.Delete, handler.Method);
            Assert.NotNull(handler.RequestHeaders.GetValues("Authorization"));

            //Valid payload
            //Construct expected URL
            string expectedUrl = "/subscriptions/" + Uri.EscapeDataString(client.SubscriptionId) + "/providers/Microsoft.Features/featureProviders/" + Uri.EscapeDataString(resourceProviderNamespace) + "/subscriptionFeatureRegistrations/" + Uri.EscapeDataString(featureName) + "?";
            expectedUrl = expectedUrl + $"api-version={apiVersion}";
            string baseUrl = client.BaseUri.AbsoluteUri;
            // Trim '/' character from the end of baseUrl and beginning of url.
            if (baseUrl[baseUrl.Length - 1] == '/')
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            if (expectedUrl[0] == '/')
            {
                expectedUrl = expectedUrl.Substring(1);
            }
            expectedUrl = baseUrl + "/" + expectedUrl;
            expectedUrl = expectedUrl.Replace(" ", "%20");

            Assert.Equal(expectedUrl, handler.Uri.ToString());
        }

        [Fact]
        public void GetPreviewedFeatures()
        {
            var response = new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(@"{                    
                       
                    'name': 'Providers.Test/DONOTDELETEBETA',

                    'properties': {

                    'state': 'NotRegistered'

                     },

                    'id': '/subscriptions/fda3b6ba-8803-441c-91fb-6cc798cf6ea0/providers/Microsoft.Features/providers/Providers.Test/features/DONOTDELETEBETA',

                    'type': 'Microsoft.Features/providers/features'  
              
              }
            ")
            };

            var handler = new RecordedDelegatingHandler() { StatusCodeToReturn = HttpStatusCode.OK };

            var client = GetFeatureClient(handler);

            string resourceProviderNamespace = "Providers.Test";

            string featureName = "DONOTDELETEBETA";

            string apiVersion = "2015-12-01";

            // ----Verify API calls for get all features under current subid----
            var getResult = client.Features.Get( resourceProviderNamespace, featureName, apiVersion);

            // Validate headers 
            Assert.Equal(HttpMethod.Get, handler.Method);
            Assert.NotNull(handler.RequestHeaders.GetValues("Authorization"));

            //Valid payload
            //Construct expected URL
            string expectedUrl = "/subscriptions/" + Uri.EscapeDataString(client.SubscriptionId) + "/providers/Microsoft.Features/providers/"+Uri.EscapeDataString(resourceProviderNamespace) + "/features/" + Uri.EscapeDataString(featureName) + "?";
            expectedUrl = expectedUrl + "api-version=2015-12-01";
            string baseUrl = client.BaseUri.AbsoluteUri;
            // Trim '/' character from the end of baseUrl and beginning of url.
            if (baseUrl[baseUrl.Length - 1] == '/')
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            if (expectedUrl[0] == '/')
            {
                expectedUrl = expectedUrl.Substring(1);
            }
            expectedUrl = baseUrl + "/" + expectedUrl;
            expectedUrl = expectedUrl.Replace(" ", "%20");

            Assert.Equal(expectedUrl, handler.Uri.ToString());
        }

        [Fact]
        public void ListPreviewedFeatures()
        {
            var response = new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(@"{
                'value': [
                    {
                    'name': 'Providers.Test/DONOTDELETEBETA',

                    'properties': {

                    'state': 'NotRegistered'

                     },

                    'id': '/subscriptions/fda3b6ba-8803-441c-91fb-6cc798cf6ea0/providers/Microsoft.Features/providers/Providers.Test/features/DONOTDELETEBETA',

                    'type': 'Microsoft.Features/providers/features'   
                }
                ],
              'nextLink': 'https://wa.com/subscriptions/mysubid/resourcegroups/TestRG/deployments/test-release-3/operations?$skiptoken=983fknw'
              }
            ")
            };

            var handler = new RecordedDelegatingHandler() { StatusCodeToReturn = HttpStatusCode.OK };

            var client = GetFeatureClient(handler);

            string resourceProviderNamespace = "Providers.Test";

            string apiVersion = "2015-12-01";

            //-------------Verify get all features within a resource provider
            var getResult = client.Features.List(resourceProviderNamespace, apiVersion);

            // Validate headers 
            Assert.Equal(HttpMethod.Get, handler.Method);
            Assert.NotNull(handler.RequestHeaders.GetValues("Authorization"));

            //Valid payload
            //Construct expected URL
            string expectedUrl = "/subscriptions/" + Uri.EscapeDataString(client.SubscriptionId) + "/providers/Microsoft.Features/providers/" + Uri.EscapeDataString(resourceProviderNamespace) + "/features?";
            expectedUrl = expectedUrl + "api-version=2015-12-01";
            string baseUrl = client.BaseUri.AbsoluteUri;
            // Trim '/' character from the end of baseUrl and beginning of url.
            if (baseUrl[baseUrl.Length - 1] == '/')
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            if (expectedUrl[0] == '/')
            {
                expectedUrl = expectedUrl.Substring(1);
            }
            expectedUrl = baseUrl + "/" + expectedUrl;
            expectedUrl = expectedUrl.Replace(" ", "%20");

            Assert.Equal(expectedUrl, handler.Uri.ToString());

        }

        [Fact]
        public void ListAllPreviewedFeatures()
        {
              var response = new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(@"{                    
            'value': [
                    {
                    'name': 'Providers.Test/DONOTDELETEBETA',

                    'properties': {

                    'state': 'NotRegistered'

                     },

                    'id': '/subscriptions/fda3b6ba-8803-441c-91fb-6cc798cf6ea0/providers/Microsoft.Features/providers/Providers.Test/features/DONOTDELETEBETA',

                    'type': 'Microsoft.Features/providers/features'   
                }            
                ],
              'nextLink': 'https://wa.com/subscriptions/mysubid/resourcegroups/TestRG/deployments/test-release-3/operations?$skiptoken=983fknw'
              }
            ")
            };
            var handler = new RecordedDelegatingHandler() { StatusCodeToReturn = HttpStatusCode.OK };
            var client = GetFeatureClient(handler);

            //-------------Verify get all features within a resource provider
            string apiVersion = "2015-12-01";
            var getResult = client.Features.ListAll(apiVersion);

            // Validate headers 
            Assert.Equal(HttpMethod.Get, handler.Method);
            Assert.NotNull(handler.RequestHeaders.GetValues("Authorization"));

            //Valid payload
            //Construct expected URL
            string expectedUrl = "/subscriptions/" + Uri.EscapeDataString(client.SubscriptionId) + "/providers/Microsoft.Features/features?";
            expectedUrl = expectedUrl + "api-version=2015-12-01";
            string baseUrl = client.BaseUri.AbsoluteUri;
            // Trim '/' character from the end of baseUrl and beginning of url.
            if (baseUrl[baseUrl.Length - 1] == '/')
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            if (expectedUrl[0] == '/')
            {
                expectedUrl = expectedUrl.Substring(1);
            }
            expectedUrl = baseUrl + "/" + expectedUrl;
            expectedUrl = expectedUrl.Replace(" ", "%20");

            Assert.Equal(expectedUrl, handler.Uri.ToString());
        }
    }
}
