// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.Verticals.AgriFood.Farming;
using NUnit.Framework;

namespace Azure.Verticals.AgriFood.Farming.Samples
{
    internal class Samples_Sensors
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CreateOrUpdate()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Sensors client = new FarmBeatsClient(credential).GetSensorsClient(apiVersion: "2022-11-01-preview");

            RequestContent content = RequestContent.Create(new object());
            Response response = client.CreateOrUpdate("<sensorPartnerId>", "<sensorId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CreateOrUpdate_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Sensors client = new FarmBeatsClient(credential).GetSensorsClient(apiVersion: "2022-11-01-preview");

            RequestContent content = RequestContent.Create(new object());
            Response response = await client.CreateOrUpdateAsync("<sensorPartnerId>", "<sensorId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CreateOrUpdate_AllParameters()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Sensors client = new FarmBeatsClient(credential).GetSensorsClient(apiVersion: "2022-11-01-preview");

            RequestContent content = RequestContent.Create(new
            {
                sensorDataModelId = "<sensorDataModelId>",
                integrationId = "<integrationId>",
                hardwareId = "<hardwareId>",
                deviceId = "<deviceId>",
                type = "<type>",
                location = new
                {
                    latitude = 123.45,
                    longitude = 123.45,
                },
                port = new
                {
                    name = "<name>",
                    type = "<type>",
                },
                depthInMeters = new List<object>()
{
123.45
},
                status = "<status>",
                name = "<name>",
                description = "<description>",
                properties = new
                {
                    key = new object(),
                },
            });
            Response response = client.CreateOrUpdate("<sensorPartnerId>", "<sensorId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("sensorDataModelId").ToString());
            Console.WriteLine(result.GetProperty("integrationId").ToString());
            Console.WriteLine(result.GetProperty("hardwareId").ToString());
            Console.WriteLine(result.GetProperty("deviceId").ToString());
            Console.WriteLine(result.GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("location").GetProperty("latitude").ToString());
            Console.WriteLine(result.GetProperty("location").GetProperty("longitude").ToString());
            Console.WriteLine(result.GetProperty("port").GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("port").GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("depthInMeters")[0].ToString());
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
            Sensors client = new FarmBeatsClient(credential).GetSensorsClient(apiVersion: "2022-11-01-preview");

            RequestContent content = RequestContent.Create(new
            {
                sensorDataModelId = "<sensorDataModelId>",
                integrationId = "<integrationId>",
                hardwareId = "<hardwareId>",
                deviceId = "<deviceId>",
                type = "<type>",
                location = new
                {
                    latitude = 123.45,
                    longitude = 123.45,
                },
                port = new
                {
                    name = "<name>",
                    type = "<type>",
                },
                depthInMeters = new List<object>()
{
123.45
},
                status = "<status>",
                name = "<name>",
                description = "<description>",
                properties = new
                {
                    key = new object(),
                },
            });
            Response response = await client.CreateOrUpdateAsync("<sensorPartnerId>", "<sensorId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("sensorDataModelId").ToString());
            Console.WriteLine(result.GetProperty("integrationId").ToString());
            Console.WriteLine(result.GetProperty("hardwareId").ToString());
            Console.WriteLine(result.GetProperty("deviceId").ToString());
            Console.WriteLine(result.GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("location").GetProperty("latitude").ToString());
            Console.WriteLine(result.GetProperty("location").GetProperty("longitude").ToString());
            Console.WriteLine(result.GetProperty("port").GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("port").GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("depthInMeters")[0].ToString());
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
        public void Example_GetSensor()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Sensors client = new FarmBeatsClient(credential).GetSensorsClient(apiVersion: "2022-11-01-preview");

            Response response = client.GetSensor("<sensorPartnerId>", "<sensorId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetSensor_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Sensors client = new FarmBeatsClient(credential).GetSensorsClient(apiVersion: "2022-11-01-preview");

            Response response = await client.GetSensorAsync("<sensorPartnerId>", "<sensorId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetSensor_AllParameters()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Sensors client = new FarmBeatsClient(credential).GetSensorsClient(apiVersion: "2022-11-01-preview");

            Response response = client.GetSensor("<sensorPartnerId>", "<sensorId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("sensorDataModelId").ToString());
            Console.WriteLine(result.GetProperty("integrationId").ToString());
            Console.WriteLine(result.GetProperty("hardwareId").ToString());
            Console.WriteLine(result.GetProperty("deviceId").ToString());
            Console.WriteLine(result.GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("location").GetProperty("latitude").ToString());
            Console.WriteLine(result.GetProperty("location").GetProperty("longitude").ToString());
            Console.WriteLine(result.GetProperty("port").GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("port").GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("depthInMeters")[0].ToString());
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
        public async Task Example_GetSensor_AllParameters_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Sensors client = new FarmBeatsClient(credential).GetSensorsClient(apiVersion: "2022-11-01-preview");

            Response response = await client.GetSensorAsync("<sensorPartnerId>", "<sensorId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("sensorDataModelId").ToString());
            Console.WriteLine(result.GetProperty("integrationId").ToString());
            Console.WriteLine(result.GetProperty("hardwareId").ToString());
            Console.WriteLine(result.GetProperty("deviceId").ToString());
            Console.WriteLine(result.GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("location").GetProperty("latitude").ToString());
            Console.WriteLine(result.GetProperty("location").GetProperty("longitude").ToString());
            Console.WriteLine(result.GetProperty("port").GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("port").GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("depthInMeters")[0].ToString());
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
            Sensors client = new FarmBeatsClient(credential).GetSensorsClient(apiVersion: "2022-11-01-preview");

            Response response = client.Delete("<sensorPartnerId>", "<sensorId>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Delete_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Sensors client = new FarmBeatsClient(credential).GetSensorsClient(apiVersion: "2022-11-01-preview");

            Response response = await client.DeleteAsync("<sensorPartnerId>", "<sensorId>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Delete_AllParameters()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Sensors client = new FarmBeatsClient(credential).GetSensorsClient(apiVersion: "2022-11-01-preview");

            Response response = client.Delete("<sensorPartnerId>", "<sensorId>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Delete_AllParameters_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Sensors client = new FarmBeatsClient(credential).GetSensorsClient(apiVersion: "2022-11-01-preview");

            Response response = await client.DeleteAsync("<sensorPartnerId>", "<sensorId>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetConnectionString()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Sensors client = new FarmBeatsClient(credential).GetSensorsClient(apiVersion: "2022-11-01-preview");

            Response response = client.GetConnectionString("<sensorPartnerId>", "<sensorId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetConnectionString_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Sensors client = new FarmBeatsClient(credential).GetSensorsClient(apiVersion: "2022-11-01-preview");

            Response response = await client.GetConnectionStringAsync("<sensorPartnerId>", "<sensorId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetConnectionString_AllParameters()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Sensors client = new FarmBeatsClient(credential).GetSensorsClient(apiVersion: "2022-11-01-preview");

            Response response = client.GetConnectionString("<sensorPartnerId>", "<sensorId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("primaryDeviceConnectionString").ToString());
            Console.WriteLine(result.GetProperty("secondaryDeviceConnectionString").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetConnectionString_AllParameters_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Sensors client = new FarmBeatsClient(credential).GetSensorsClient(apiVersion: "2022-11-01-preview");

            Response response = await client.GetConnectionStringAsync("<sensorPartnerId>", "<sensorId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("primaryDeviceConnectionString").ToString());
            Console.WriteLine(result.GetProperty("secondaryDeviceConnectionString").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_RenewConnectionString()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Sensors client = new FarmBeatsClient(credential).GetSensorsClient(apiVersion: "2022-11-01-preview");

            RequestContent content = RequestContent.Create(new
            {
                connectionStringType = "Primary",
            });
            Response response = client.RenewConnectionString("<sensorPartnerId>", "<sensorId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_RenewConnectionString_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Sensors client = new FarmBeatsClient(credential).GetSensorsClient(apiVersion: "2022-11-01-preview");

            RequestContent content = RequestContent.Create(new
            {
                connectionStringType = "Primary",
            });
            Response response = await client.RenewConnectionStringAsync("<sensorPartnerId>", "<sensorId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_RenewConnectionString_AllParameters()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Sensors client = new FarmBeatsClient(credential).GetSensorsClient(apiVersion: "2022-11-01-preview");

            RequestContent content = RequestContent.Create(new
            {
                connectionStringType = "Primary",
            });
            Response response = client.RenewConnectionString("<sensorPartnerId>", "<sensorId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("primaryDeviceConnectionString").ToString());
            Console.WriteLine(result.GetProperty("secondaryDeviceConnectionString").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_RenewConnectionString_AllParameters_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Sensors client = new FarmBeatsClient(credential).GetSensorsClient(apiVersion: "2022-11-01-preview");

            RequestContent content = RequestContent.Create(new
            {
                connectionStringType = "Primary",
            });
            Response response = await client.RenewConnectionStringAsync("<sensorPartnerId>", "<sensorId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("primaryDeviceConnectionString").ToString());
            Console.WriteLine(result.GetProperty("secondaryDeviceConnectionString").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetSensors()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Sensors client = new FarmBeatsClient(credential).GetSensorsClient(apiVersion: "2022-11-01-preview");

            foreach (BinaryData item in client.GetSensors("<sensorPartnerId>", null, null, null, null, null, null, null, null, null, null, null, null, null, null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result[0].ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetSensors_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Sensors client = new FarmBeatsClient(credential).GetSensorsClient(apiVersion: "2022-11-01-preview");

            await foreach (BinaryData item in client.GetSensorsAsync("<sensorPartnerId>", null, null, null, null, null, null, null, null, null, null, null, null, null, null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result[0].ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetSensors_AllParameters()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Sensors client = new FarmBeatsClient(credential).GetSensorsClient(apiVersion: "2022-11-01-preview");

            foreach (BinaryData item in client.GetSensors("<sensorPartnerId>", new List<string>()
{
"<sensorDataModelIds>"
}, new List<string>()
{
"<sensorMappingIds>"
}, new List<string>()
{
"<deviceIds>"
}, new List<string>()
{
"<ids>"
}, new List<string>()
{
"<names>"
}, new List<string>()
{
"<propertyFilters>"
}, new List<string>()
{
"<statuses>"
}, DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), 1234, "<skipToken>", null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result[0].GetProperty("sensorDataModelId").ToString());
                Console.WriteLine(result[0].GetProperty("integrationId").ToString());
                Console.WriteLine(result[0].GetProperty("hardwareId").ToString());
                Console.WriteLine(result[0].GetProperty("deviceId").ToString());
                Console.WriteLine(result[0].GetProperty("type").ToString());
                Console.WriteLine(result[0].GetProperty("location").GetProperty("latitude").ToString());
                Console.WriteLine(result[0].GetProperty("location").GetProperty("longitude").ToString());
                Console.WriteLine(result[0].GetProperty("port").GetProperty("name").ToString());
                Console.WriteLine(result[0].GetProperty("port").GetProperty("type").ToString());
                Console.WriteLine(result[0].GetProperty("depthInMeters")[0].ToString());
                Console.WriteLine(result[0].GetProperty("sensorPartnerId").ToString());
                Console.WriteLine(result[0].GetProperty("id").ToString());
                Console.WriteLine(result[0].GetProperty("status").ToString());
                Console.WriteLine(result[0].GetProperty("createdDateTime").ToString());
                Console.WriteLine(result[0].GetProperty("modifiedDateTime").ToString());
                Console.WriteLine(result[0].GetProperty("eTag").ToString());
                Console.WriteLine(result[0].GetProperty("name").ToString());
                Console.WriteLine(result[0].GetProperty("description").ToString());
                Console.WriteLine(result[0].GetProperty("createdBy").ToString());
                Console.WriteLine(result[0].GetProperty("modifiedBy").ToString());
                Console.WriteLine(result[0].GetProperty("properties").GetProperty("<key>").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetSensors_AllParameters_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Sensors client = new FarmBeatsClient(credential).GetSensorsClient(apiVersion: "2022-11-01-preview");

            await foreach (BinaryData item in client.GetSensorsAsync("<sensorPartnerId>", new List<string>()
{
"<sensorDataModelIds>"
}, new List<string>()
{
"<sensorMappingIds>"
}, new List<string>()
{
"<deviceIds>"
}, new List<string>()
{
"<ids>"
}, new List<string>()
{
"<names>"
}, new List<string>()
{
"<propertyFilters>"
}, new List<string>()
{
"<statuses>"
}, DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), 1234, "<skipToken>", null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result[0].GetProperty("sensorDataModelId").ToString());
                Console.WriteLine(result[0].GetProperty("integrationId").ToString());
                Console.WriteLine(result[0].GetProperty("hardwareId").ToString());
                Console.WriteLine(result[0].GetProperty("deviceId").ToString());
                Console.WriteLine(result[0].GetProperty("type").ToString());
                Console.WriteLine(result[0].GetProperty("location").GetProperty("latitude").ToString());
                Console.WriteLine(result[0].GetProperty("location").GetProperty("longitude").ToString());
                Console.WriteLine(result[0].GetProperty("port").GetProperty("name").ToString());
                Console.WriteLine(result[0].GetProperty("port").GetProperty("type").ToString());
                Console.WriteLine(result[0].GetProperty("depthInMeters")[0].ToString());
                Console.WriteLine(result[0].GetProperty("sensorPartnerId").ToString());
                Console.WriteLine(result[0].GetProperty("id").ToString());
                Console.WriteLine(result[0].GetProperty("status").ToString());
                Console.WriteLine(result[0].GetProperty("createdDateTime").ToString());
                Console.WriteLine(result[0].GetProperty("modifiedDateTime").ToString());
                Console.WriteLine(result[0].GetProperty("eTag").ToString());
                Console.WriteLine(result[0].GetProperty("name").ToString());
                Console.WriteLine(result[0].GetProperty("description").ToString());
                Console.WriteLine(result[0].GetProperty("createdBy").ToString());
                Console.WriteLine(result[0].GetProperty("modifiedBy").ToString());
                Console.WriteLine(result[0].GetProperty("properties").GetProperty("<key>").ToString());
            }
        }
    }
}
