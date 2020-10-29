﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Text.RegularExpressions;
using Azure.Core.TestFramework;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.Data.SchemaRegistry.Tests.Samples
{
    public class Sample01_ReadmeSnippets : SamplesBase<SchemaRegistryClientTestEnvironment>
    {
#pragma warning disable IDE1006 // Naming Styles
        private SchemaRegistryClient client;
#pragma warning restore IDE1006 // Naming Styles
        private SchemaProperties _schemaProperties;

        [OneTimeSetUp]
        public void CreateSchemaRegistryClient()
        {
            string endpoint = TestEnvironment.SchemaRegistryEndpoint;

            #region Snippet:SchemaRegistryCreateSchemaRegistryClient
            // Create a new access Spark batch client using the default credential from Azure.Identity using environment variables previously set,
            // including AZURE_CLIENT_ID, AZURE_CLIENT_SECRET, and AZURE_TENANT_ID.
            var client = new SchemaRegistryClient(endpoint: endpoint, credential: new DefaultAzureCredential());
            #endregion

            this.client = client;
        }

        [Test]
        public void RegisterSchema()
        {
            string groupName = TestEnvironment.SchemaRegistryGroup;

            #region Snippet:SchemaRegistryRegisterSchema
            string schemaName = "employeeSample";
            SerializationType schemaType = SerializationType.Avro;
            // Example schema's content
            string schemaContent = @"
            {
               ""type"" : ""record"",
                ""namespace"" : ""TestSchema"",
                ""name"" : ""Employee"",
                ""fields"" : [
                { ""name"" : ""Name"" , ""type"" : ""string"" },
                { ""name"" : ""Age"", ""type"" : ""int"" }
                ]
            }";

            Response<SchemaProperties> schemaProperties = client.RegisterSchema(groupName, schemaName, schemaType, schemaContent);
            #endregion

            Assert.NotNull(schemaProperties);
            _schemaProperties = schemaProperties.Value;
        }

        [Test]
        public void RetrieveSchemaId()
        {
            RegisterSchema();
            string groupName = TestEnvironment.SchemaRegistryGroup;

            #region Snippet:SchemaRegistryRetrieveSchemaId
            string schemaName = "employeeSample";
            SerializationType schemaType = SerializationType.Avro;
            // Example schema's content
            string schemaContent = @"
            {
               ""type"" : ""record"",
                ""namespace"" : ""TestSchema"",
                ""name"" : ""Employee"",
                ""fields"" : [
                { ""name"" : ""Name"" , ""type"" : ""string"" },
                { ""name"" : ""Age"", ""type"" : ""int"" }
                ]
            }";

            Response<SchemaProperties> schemaProperties = client.GetSchemaId(groupName, schemaName, schemaType, schemaContent);
            string schemaId = schemaProperties.Value.Id;
            #endregion

            Assert.AreEqual(_schemaProperties.Id, schemaId);
        }

        [Test]
        public void RetrieveSchema()
        {
            RegisterSchema();
            var schemaId = _schemaProperties.Id;

            #region Snippet:SchemaRegistryRetrieveSchema
            Response<SchemaProperties> schemaProperties = client.GetSchema(schemaId);
            string schemaContent = schemaProperties.Value.Content;
            #endregion

            Assert.AreEqual(Regex.Replace(_schemaProperties.Content, @"\s+", string.Empty), schemaContent);
        }
    }
}
