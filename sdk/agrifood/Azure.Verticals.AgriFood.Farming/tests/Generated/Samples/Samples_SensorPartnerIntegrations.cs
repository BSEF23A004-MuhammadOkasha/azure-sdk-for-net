// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.Verticals.AgriFood.Farming;
using NUnit.Framework;

namespace Azure.Verticals.AgriFood.Farming.Samples
{
    public partial class Samples_SensorPartnerIntegrations
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CreateOrUpdate()
        {
            TokenCredential credential = new DefaultAzureCredential();
            SensorPartnerIntegrations client = new FarmBeatsClient(credential).GetSensorPartnerIntegrationsClient(apiVersion: "2022-11-01-preview");

            RequestContent content = RequestContent.Create(new object());
            Response response = client.CreateOrUpdate("<sensorPartnerId>", "<integrationId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CreateOrUpdate_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            SensorPartnerIntegrations client = new FarmBeatsClient(credential).GetSensorPartnerIntegrationsClient(apiVersion: "2022-11-01-preview");

            RequestContent content = RequestContent.Create(new object());
            Response response = await client.CreateOrUpdateAsync("<sensorPartnerId>", "<integrationId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CreateOrUpdate_AllParameters()
        {
            TokenCredential credential = new DefaultAzureCredential();
            SensorPartnerIntegrations client = new FarmBeatsClient(credential).GetSensorPartnerIntegrationsClient(apiVersion: "2022-11-01-preview");

            RequestContent content = RequestContent.Create(new
            {
                partyId = "<partyId>",
                status = "<status>",
                name = "<name>",
                description = "<description>",
                properties = new
                {
                    key = new object(),
                },
            });
            Response response = client.CreateOrUpdate("<sensorPartnerId>", "<integrationId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("integrationId").ToString());
            Console.WriteLine(result.GetProperty("partyId").ToString());
            Console.WriteLine(result.GetProperty("sensorPartnerId").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("modifiedDateTime").ToString());
            Console.WriteLine(result.GetProperty("eTag").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("createdBy").ToString());
            Console.WriteLine(result.GetProperty("modifiedBy").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("<key>").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CreateOrUpdate_AllParameters_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            SensorPartnerIntegrations client = new FarmBeatsClient(credential).GetSensorPartnerIntegrationsClient(apiVersion: "2022-11-01-preview");

            RequestContent content = RequestContent.Create(new
            {
                partyId = "<partyId>",
                status = "<status>",
                name = "<name>",
                description = "<description>",
                properties = new
                {
                    key = new object(),
                },
            });
            Response response = await client.CreateOrUpdateAsync("<sensorPartnerId>", "<integrationId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("integrationId").ToString());
            Console.WriteLine(result.GetProperty("partyId").ToString());
            Console.WriteLine(result.GetProperty("sensorPartnerId").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("modifiedDateTime").ToString());
            Console.WriteLine(result.GetProperty("eTag").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("createdBy").ToString());
            Console.WriteLine(result.GetProperty("modifiedBy").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("<key>").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetSensorPartnerIntegration()
        {
            TokenCredential credential = new DefaultAzureCredential();
            SensorPartnerIntegrations client = new FarmBeatsClient(credential).GetSensorPartnerIntegrationsClient(apiVersion: "2022-11-01-preview");

            Response response = client.GetSensorPartnerIntegration("<sensorPartnerId>", "<integrationId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetSensorPartnerIntegration_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            SensorPartnerIntegrations client = new FarmBeatsClient(credential).GetSensorPartnerIntegrationsClient(apiVersion: "2022-11-01-preview");

            Response response = await client.GetSensorPartnerIntegrationAsync("<sensorPartnerId>", "<integrationId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetSensorPartnerIntegration_AllParameters()
        {
            TokenCredential credential = new DefaultAzureCredential();
            SensorPartnerIntegrations client = new FarmBeatsClient(credential).GetSensorPartnerIntegrationsClient(apiVersion: "2022-11-01-preview");

            Response response = client.GetSensorPartnerIntegration("<sensorPartnerId>", "<integrationId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("integrationId").ToString());
            Console.WriteLine(result.GetProperty("partyId").ToString());
            Console.WriteLine(result.GetProperty("sensorPartnerId").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("modifiedDateTime").ToString());
            Console.WriteLine(result.GetProperty("eTag").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("createdBy").ToString());
            Console.WriteLine(result.GetProperty("modifiedBy").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("<key>").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetSensorPartnerIntegration_AllParameters_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            SensorPartnerIntegrations client = new FarmBeatsClient(credential).GetSensorPartnerIntegrationsClient(apiVersion: "2022-11-01-preview");

            Response response = await client.GetSensorPartnerIntegrationAsync("<sensorPartnerId>", "<integrationId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("integrationId").ToString());
            Console.WriteLine(result.GetProperty("partyId").ToString());
            Console.WriteLine(result.GetProperty("sensorPartnerId").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("modifiedDateTime").ToString());
            Console.WriteLine(result.GetProperty("eTag").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("createdBy").ToString());
            Console.WriteLine(result.GetProperty("modifiedBy").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("<key>").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Delete()
        {
            TokenCredential credential = new DefaultAzureCredential();
            SensorPartnerIntegrations client = new FarmBeatsClient(credential).GetSensorPartnerIntegrationsClient(apiVersion: "2022-11-01-preview");

            Response response = client.Delete("<sensorPartnerId>", "<integrationId>");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Delete_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            SensorPartnerIntegrations client = new FarmBeatsClient(credential).GetSensorPartnerIntegrationsClient(apiVersion: "2022-11-01-preview");

            Response response = await client.DeleteAsync("<sensorPartnerId>", "<integrationId>");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Delete_AllParameters()
        {
            TokenCredential credential = new DefaultAzureCredential();
            SensorPartnerIntegrations client = new FarmBeatsClient(credential).GetSensorPartnerIntegrationsClient(apiVersion: "2022-11-01-preview");

            Response response = client.Delete("<sensorPartnerId>", "<integrationId>");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Delete_AllParameters_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            SensorPartnerIntegrations client = new FarmBeatsClient(credential).GetSensorPartnerIntegrationsClient(apiVersion: "2022-11-01-preview");

            Response response = await client.DeleteAsync("<sensorPartnerId>", "<integrationId>");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CheckConsent()
        {
            TokenCredential credential = new DefaultAzureCredential();
            SensorPartnerIntegrations client = new FarmBeatsClient(credential).GetSensorPartnerIntegrationsClient(apiVersion: "2022-11-01-preview");

            Response response = client.CheckConsent("<sensorPartnerId>", "<integrationId>", "<key>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CheckConsent_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            SensorPartnerIntegrations client = new FarmBeatsClient(credential).GetSensorPartnerIntegrationsClient(apiVersion: "2022-11-01-preview");

            Response response = await client.CheckConsentAsync("<sensorPartnerId>", "<integrationId>", "<key>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CheckConsent_AllParameters()
        {
            TokenCredential credential = new DefaultAzureCredential();
            SensorPartnerIntegrations client = new FarmBeatsClient(credential).GetSensorPartnerIntegrationsClient(apiVersion: "2022-11-01-preview");

            Response response = client.CheckConsent("<sensorPartnerId>", "<integrationId>", "<key>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("consented").ToString());
            Console.WriteLine(result.GetProperty("sensorPartnerId").ToString());
            Console.WriteLine(result.GetProperty("integrationId").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CheckConsent_AllParameters_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            SensorPartnerIntegrations client = new FarmBeatsClient(credential).GetSensorPartnerIntegrationsClient(apiVersion: "2022-11-01-preview");

            Response response = await client.CheckConsentAsync("<sensorPartnerId>", "<integrationId>", "<key>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("consented").ToString());
            Console.WriteLine(result.GetProperty("sensorPartnerId").ToString());
            Console.WriteLine(result.GetProperty("integrationId").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GenerateConsentLink()
        {
            TokenCredential credential = new DefaultAzureCredential();
            SensorPartnerIntegrations client = new FarmBeatsClient(credential).GetSensorPartnerIntegrationsClient(apiVersion: "2022-11-01-preview");

            Response response = client.GenerateConsentLink("<sensorPartnerId>", "<integrationId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GenerateConsentLink_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            SensorPartnerIntegrations client = new FarmBeatsClient(credential).GetSensorPartnerIntegrationsClient(apiVersion: "2022-11-01-preview");

            Response response = await client.GenerateConsentLinkAsync("<sensorPartnerId>", "<integrationId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GenerateConsentLink_AllParameters()
        {
            TokenCredential credential = new DefaultAzureCredential();
            SensorPartnerIntegrations client = new FarmBeatsClient(credential).GetSensorPartnerIntegrationsClient(apiVersion: "2022-11-01-preview");

            Response response = client.GenerateConsentLink("<sensorPartnerId>", "<integrationId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("consentLink").ToString());
            Console.WriteLine(result.GetProperty("consentExpiryDateTime").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GenerateConsentLink_AllParameters_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            SensorPartnerIntegrations client = new FarmBeatsClient(credential).GetSensorPartnerIntegrationsClient(apiVersion: "2022-11-01-preview");

            Response response = await client.GenerateConsentLinkAsync("<sensorPartnerId>", "<integrationId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("consentLink").ToString());
            Console.WriteLine(result.GetProperty("consentExpiryDateTime").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetSensorPartnerIntegrations()
        {
            TokenCredential credential = new DefaultAzureCredential();
            SensorPartnerIntegrations client = new FarmBeatsClient(credential).GetSensorPartnerIntegrationsClient(apiVersion: "2022-11-01-preview");

            foreach (BinaryData item in client.GetSensorPartnerIntegrations("<sensorPartnerId>", null, null, null, null, null, null, null, null, null, null, null, null, null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetSensorPartnerIntegrations_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            SensorPartnerIntegrations client = new FarmBeatsClient(credential).GetSensorPartnerIntegrationsClient(apiVersion: "2022-11-01-preview");

            await foreach (BinaryData item in client.GetSensorPartnerIntegrationsAsync("<sensorPartnerId>", null, null, null, null, null, null, null, null, null, null, null, null, null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetSensorPartnerIntegrations_AllParameters()
        {
            TokenCredential credential = new DefaultAzureCredential();
            SensorPartnerIntegrations client = new FarmBeatsClient(credential).GetSensorPartnerIntegrationsClient(apiVersion: "2022-11-01-preview");

            foreach (BinaryData item in client.GetSensorPartnerIntegrations("<sensorPartnerId>", new string[] { "<integrationIds>" }, new string[] { "<partyIds>" }, new string[] { "<ids>" }, new string[] { "<names>" }, new string[] { "<propertyFilters>" }, new string[] { "<statuses>" }, DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), 1234, "<skipToken>", null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("integrationId").ToString());
                Console.WriteLine(result.GetProperty("partyId").ToString());
                Console.WriteLine(result.GetProperty("sensorPartnerId").ToString());
                Console.WriteLine(result.GetProperty("id").ToString());
                Console.WriteLine(result.GetProperty("status").ToString());
                Console.WriteLine(result.GetProperty("createdDateTime").ToString());
                Console.WriteLine(result.GetProperty("modifiedDateTime").ToString());
                Console.WriteLine(result.GetProperty("eTag").ToString());
                Console.WriteLine(result.GetProperty("name").ToString());
                Console.WriteLine(result.GetProperty("description").ToString());
                Console.WriteLine(result.GetProperty("createdBy").ToString());
                Console.WriteLine(result.GetProperty("modifiedBy").ToString());
                Console.WriteLine(result.GetProperty("properties").GetProperty("<key>").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetSensorPartnerIntegrations_AllParameters_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            SensorPartnerIntegrations client = new FarmBeatsClient(credential).GetSensorPartnerIntegrationsClient(apiVersion: "2022-11-01-preview");

            await foreach (BinaryData item in client.GetSensorPartnerIntegrationsAsync("<sensorPartnerId>", new string[] { "<integrationIds>" }, new string[] { "<partyIds>" }, new string[] { "<ids>" }, new string[] { "<names>" }, new string[] { "<propertyFilters>" }, new string[] { "<statuses>" }, DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), 1234, "<skipToken>", null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("integrationId").ToString());
                Console.WriteLine(result.GetProperty("partyId").ToString());
                Console.WriteLine(result.GetProperty("sensorPartnerId").ToString());
                Console.WriteLine(result.GetProperty("id").ToString());
                Console.WriteLine(result.GetProperty("status").ToString());
                Console.WriteLine(result.GetProperty("createdDateTime").ToString());
                Console.WriteLine(result.GetProperty("modifiedDateTime").ToString());
                Console.WriteLine(result.GetProperty("eTag").ToString());
                Console.WriteLine(result.GetProperty("name").ToString());
                Console.WriteLine(result.GetProperty("description").ToString());
                Console.WriteLine(result.GetProperty("createdBy").ToString());
                Console.WriteLine(result.GetProperty("modifiedBy").ToString());
                Console.WriteLine(result.GetProperty("properties").GetProperty("<key>").ToString());
            }
        }
    }
}
