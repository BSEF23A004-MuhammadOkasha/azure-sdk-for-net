// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.Analytics.Purview.Catalog.Samples
{
    public class Samples_PurviewCatalogClient
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Search()
        {
            var credential = new DefaultAzureCredential();
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new PurviewCatalogClient(endpoint, credential);

            var data = new { };

            Response response = client.Search(RequestContent.Create(data));

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Search_AllParameters()
        {
            var credential = new DefaultAzureCredential();
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new PurviewCatalogClient(endpoint, credential);

            var data = new
            {
                keywords = "<keywords>",
                offset = 1234,
                limit = 1234,
                filter = new { },
                facets = new[] {
        new {
            count = 1234,
            facet = "<facet>",
            sort = new {},
        }
    },
                taxonomySetting = new
                {
                    assetTypes = new[] {
            "<String>"
        },
                    facet = new
                    {
                        count = 1234,
                        facet = "<facet>",
                        sort = new { },
                    },
                },
            };

            Response response = client.Search(RequestContent.Create(data));

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("@search.count").ToString());
            Console.WriteLine(result.GetProperty("@search.facets").GetProperty("assetType")[0].GetProperty("count").ToString());
            Console.WriteLine(result.GetProperty("@search.facets").GetProperty("assetType")[0].GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("@search.facets").GetProperty("classification")[0].GetProperty("count").ToString());
            Console.WriteLine(result.GetProperty("@search.facets").GetProperty("classification")[0].GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("@search.facets").GetProperty("classificationCategory")[0].GetProperty("count").ToString());
            Console.WriteLine(result.GetProperty("@search.facets").GetProperty("classificationCategory")[0].GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("@search.facets").GetProperty("contactId")[0].GetProperty("count").ToString());
            Console.WriteLine(result.GetProperty("@search.facets").GetProperty("contactId")[0].GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("@search.facets").GetProperty("fileExtension")[0].GetProperty("count").ToString());
            Console.WriteLine(result.GetProperty("@search.facets").GetProperty("fileExtension")[0].GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("@search.facets").GetProperty("label")[0].GetProperty("count").ToString());
            Console.WriteLine(result.GetProperty("@search.facets").GetProperty("label")[0].GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("@search.facets").GetProperty("term")[0].GetProperty("count").ToString());
            Console.WriteLine(result.GetProperty("@search.facets").GetProperty("term")[0].GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("@search.score").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("@search.highlights").GetProperty("id")[0].ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("@search.highlights").GetProperty("qualifiedName")[0].ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("@search.highlights").GetProperty("name")[0].ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("@search.highlights").GetProperty("description")[0].ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("@search.highlights").GetProperty("entityType")[0].ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("@search.text").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("owner").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("qualifiedName").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("entityType").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("classification")[0].ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("label")[0].ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("term")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("term")[0].GetProperty("glossaryName").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("term")[0].GetProperty("guid").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("contact")[0].GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("contact")[0].GetProperty("info").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("contact")[0].GetProperty("contactType").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("assetType")[0].ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Search_Async()
        {
            var credential = new DefaultAzureCredential();
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new PurviewCatalogClient(endpoint, credential);

            var data = new { };

            Response response = await client.SearchAsync(RequestContent.Create(data));

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Search_AllParameters_Async()
        {
            var credential = new DefaultAzureCredential();
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new PurviewCatalogClient(endpoint, credential);

            var data = new
            {
                keywords = "<keywords>",
                offset = 1234,
                limit = 1234,
                filter = new { },
                facets = new[] {
        new {
            count = 1234,
            facet = "<facet>",
            sort = new {},
        }
    },
                taxonomySetting = new
                {
                    assetTypes = new[] {
            "<String>"
        },
                    facet = new
                    {
                        count = 1234,
                        facet = "<facet>",
                        sort = new { },
                    },
                },
            };

            Response response = await client.SearchAsync(RequestContent.Create(data));

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("@search.count").ToString());
            Console.WriteLine(result.GetProperty("@search.facets").GetProperty("assetType")[0].GetProperty("count").ToString());
            Console.WriteLine(result.GetProperty("@search.facets").GetProperty("assetType")[0].GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("@search.facets").GetProperty("classification")[0].GetProperty("count").ToString());
            Console.WriteLine(result.GetProperty("@search.facets").GetProperty("classification")[0].GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("@search.facets").GetProperty("classificationCategory")[0].GetProperty("count").ToString());
            Console.WriteLine(result.GetProperty("@search.facets").GetProperty("classificationCategory")[0].GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("@search.facets").GetProperty("contactId")[0].GetProperty("count").ToString());
            Console.WriteLine(result.GetProperty("@search.facets").GetProperty("contactId")[0].GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("@search.facets").GetProperty("fileExtension")[0].GetProperty("count").ToString());
            Console.WriteLine(result.GetProperty("@search.facets").GetProperty("fileExtension")[0].GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("@search.facets").GetProperty("label")[0].GetProperty("count").ToString());
            Console.WriteLine(result.GetProperty("@search.facets").GetProperty("label")[0].GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("@search.facets").GetProperty("term")[0].GetProperty("count").ToString());
            Console.WriteLine(result.GetProperty("@search.facets").GetProperty("term")[0].GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("@search.score").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("@search.highlights").GetProperty("id")[0].ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("@search.highlights").GetProperty("qualifiedName")[0].ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("@search.highlights").GetProperty("name")[0].ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("@search.highlights").GetProperty("description")[0].ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("@search.highlights").GetProperty("entityType")[0].ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("@search.text").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("owner").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("qualifiedName").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("entityType").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("classification")[0].ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("label")[0].ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("term")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("term")[0].GetProperty("glossaryName").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("term")[0].GetProperty("guid").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("contact")[0].GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("contact")[0].GetProperty("info").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("contact")[0].GetProperty("contactType").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("assetType")[0].ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Suggest()
        {
            var credential = new DefaultAzureCredential();
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new PurviewCatalogClient(endpoint, credential);

            var data = new { };

            Response response = client.Suggest(RequestContent.Create(data));

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Suggest_AllParameters()
        {
            var credential = new DefaultAzureCredential();
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new PurviewCatalogClient(endpoint, credential);

            var data = new
            {
                keywords = "<keywords>",
                limit = 1234,
                filter = new { },
            };

            Response response = client.Suggest(RequestContent.Create(data));

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("@search.score").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("@search.text").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("owner").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("qualifiedName").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("entityType").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("classification")[0].ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("label")[0].ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("term")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("term")[0].GetProperty("glossaryName").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("term")[0].GetProperty("guid").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("contact")[0].GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("contact")[0].GetProperty("info").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("contact")[0].GetProperty("contactType").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("assetType")[0].ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Suggest_Async()
        {
            var credential = new DefaultAzureCredential();
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new PurviewCatalogClient(endpoint, credential);

            var data = new { };

            Response response = await client.SuggestAsync(RequestContent.Create(data));

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Suggest_AllParameters_Async()
        {
            var credential = new DefaultAzureCredential();
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new PurviewCatalogClient(endpoint, credential);

            var data = new
            {
                keywords = "<keywords>",
                limit = 1234,
                filter = new { },
            };

            Response response = await client.SuggestAsync(RequestContent.Create(data));

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("@search.score").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("@search.text").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("owner").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("qualifiedName").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("entityType").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("classification")[0].ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("label")[0].ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("term")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("term")[0].GetProperty("glossaryName").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("term")[0].GetProperty("guid").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("contact")[0].GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("contact")[0].GetProperty("info").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("contact")[0].GetProperty("contactType").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("assetType")[0].ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Browse()
        {
            var credential = new DefaultAzureCredential();
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new PurviewCatalogClient(endpoint, credential);

            var data = new { };

            Response response = client.Browse(RequestContent.Create(data));

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Browse_AllParameters()
        {
            var credential = new DefaultAzureCredential();
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new PurviewCatalogClient(endpoint, credential);

            var data = new
            {
                entityType = "<entityType>",
                path = "<path>",
                limit = 1234,
                offset = 1234,
            };

            Response response = client.Browse(RequestContent.Create(data));

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("@search.count").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("entityType").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("isLeaf").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("owner")[0].GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("owner")[0].GetProperty("displayName").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("owner")[0].GetProperty("mail").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("owner")[0].GetProperty("contactType").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("path").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("qualifiedName").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Browse_Async()
        {
            var credential = new DefaultAzureCredential();
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new PurviewCatalogClient(endpoint, credential);

            var data = new { };

            Response response = await client.BrowseAsync(RequestContent.Create(data));

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Browse_AllParameters_Async()
        {
            var credential = new DefaultAzureCredential();
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new PurviewCatalogClient(endpoint, credential);

            var data = new
            {
                entityType = "<entityType>",
                path = "<path>",
                limit = 1234,
                offset = 1234,
            };

            Response response = await client.BrowseAsync(RequestContent.Create(data));

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("@search.count").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("entityType").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("isLeaf").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("owner")[0].GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("owner")[0].GetProperty("displayName").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("owner")[0].GetProperty("mail").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("owner")[0].GetProperty("contactType").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("path").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("qualifiedName").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_AutoComplete()
        {
            var credential = new DefaultAzureCredential();
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new PurviewCatalogClient(endpoint, credential);

            var data = new { };

            Response response = client.AutoComplete(RequestContent.Create(data));

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_AutoComplete_AllParameters()
        {
            var credential = new DefaultAzureCredential();
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new PurviewCatalogClient(endpoint, credential);

            var data = new
            {
                keywords = "<keywords>",
                limit = 1234,
                filter = new { },
            };

            Response response = client.AutoComplete(RequestContent.Create(data));

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("text").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("queryPlusText").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_AutoComplete_Async()
        {
            var credential = new DefaultAzureCredential();
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new PurviewCatalogClient(endpoint, credential);

            var data = new { };

            Response response = await client.AutoCompleteAsync(RequestContent.Create(data));

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_AutoComplete_AllParameters_Async()
        {
            var credential = new DefaultAzureCredential();
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new PurviewCatalogClient(endpoint, credential);

            var data = new
            {
                keywords = "<keywords>",
                limit = 1234,
                filter = new { },
            };

            Response response = await client.AutoCompleteAsync(RequestContent.Create(data));

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("text").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("queryPlusText").ToString());
        }
    }
}
