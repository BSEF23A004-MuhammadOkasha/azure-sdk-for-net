﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using NUnit.Framework;

namespace Azure.AI.DocumentIntelligence.Tests
{
    public class DocumentModelAdministrationLiveTests : DocumentIntelligenceLiveTestBase
    {
        private static readonly DocumentBuildMode[] s_buildDocumentModelTestCases = new[]
        {
            DocumentBuildMode.Template,
            DocumentBuildMode.Neural
        };

        public DocumentModelAdministrationLiveTests(bool isAsync)
            : base(isAsync)
        {
        }

        #region Build

        [RecordedTest]
        [TestCaseSource(nameof(s_buildDocumentModelTestCases))]
        public async Task BuildDocumentModelWithAzureBlobContentSource(DocumentBuildMode buildMode)
        {
            if (buildMode == DocumentBuildMode.Neural && Recording.Mode == RecordedTestMode.Live)
            {
                // Test takes too long to finish running, and seems to cause multiple failures in our
                // live test pipeline. For this reason, this test is ignored when running in Live mode.
                Assert.Ignore();
            }

            var client = CreateDocumentIntelligenceAdministrationClient();
            var modelId = Recording.GenerateId();
            var description = "This classifier was generated by a .NET test.";
            var startTime = Recording.UtcNow;

            var containerUrl = new Uri(TestEnvironment.BlobContainerSasUrl);
            var prefix = "subfolder";
            var source = new AzureBlobContentSource(containerUrl) { Prefix = prefix };

            var content = new BuildDocumentModelContent(modelId, buildMode)
            {
                AzureBlobSource = source,
                Description = description,
                Tags = { { "tag1", "value1" }, { "tag2", "value2" } }
            };

            Operation<DocumentModelDetails> operation = null;

            try
            {
                operation = await client.BuildDocumentModelAsync(WaitUntil.Started, content);

                await (buildMode == DocumentBuildMode.Neural
                    ? operation.WaitForCompletionAsync(TimeSpan.FromMinutes(1), CancellationToken.None)
                    : operation.WaitForCompletionAsync());
            }
            finally
            {
                if (operation != null && operation.HasCompleted)
                {
                    await client.DeleteModelAsync(modelId);
                }
            }

            Assert.That(operation.HasCompleted);
            Assert.That(operation.HasValue);

            DocumentModelDetails model = operation.Value;

            Assert.That(model.ModelId, Is.EqualTo(modelId));
            Assert.That(model.Description, Is.EqualTo(description));
            Assert.That(model.ApiVersion, Is.EqualTo(ServiceVersionString));

            // Add a 4-hour tolerance because the model could have been cached before this test.
            Assert.That(model.CreatedDateTime, Is.GreaterThan(startTime - TimeSpan.FromHours(4)));
            Assert.That(model.ExpirationDateTime, Is.GreaterThan(model.CreatedDateTime));
            Assert.That(model.Tags, Is.EquivalentTo(content.Tags));

            Assert.That(model.AzureBlobSource, Is.Null);
            Assert.That(model.AzureBlobFileListSource, Is.Null);

            Assert.That(model.DocTypes.Count, Is.EqualTo(1));
            Assert.That(model.DocTypes.ContainsKey(modelId));

            DocumentTypeDetails docType = model.DocTypes[modelId];

            Assert.That(docType.Description, Is.Null);
            Assert.That(docType.BuildMode, Is.EqualTo(buildMode));

            if (buildMode == DocumentBuildMode.Template)
            {
                Assert.That(docType.FieldConfidence.Keys, Is.EquivalentTo(docType.FieldSchema.Keys));

                foreach (float confidence in docType.FieldConfidence.Values)
                {
                    Assert.That(confidence, Is.GreaterThanOrEqualTo(0f));
                    Assert.That(confidence, Is.LessThanOrEqualTo(1f));
                }
            }
            else
            {
                Assert.That(docType.FieldConfidence, Is.Empty);
            }

            foreach (DocumentFieldSchema fieldSchema in docType.FieldSchema.Values)
            {
                Assert.That(fieldSchema.Description, Is.Null);
                Assert.That(fieldSchema.Example, Is.Null);
                Assert.That(fieldSchema.Items, Is.Null);
                Assert.That(fieldSchema.Properties, Is.Empty);
            }

            DocumentFieldSchema merchantSchema = docType.FieldSchema["Merchant"];
            DocumentFieldSchema quantitySchema = docType.FieldSchema["Quantity"];

            Assert.That(merchantSchema.Type, Is.EqualTo(DocumentFieldType.String));
            Assert.That(quantitySchema.Type, Is.EqualTo(DocumentFieldType.Number));
        }

        [RecordedTest]
        public void BuildDocumentModelCanParseError()
        {
            var client = CreateDocumentIntelligenceAdministrationClient();
            var modelId = Recording.GenerateId();

            var containerUrl = new Uri(TestEnvironment.BlobContainerSasUrl);
            var prefix = "testfolder"; // folder exists but most training files are missing
            var source = new AzureBlobContentSource(containerUrl) { Prefix = prefix };

            var content = new BuildDocumentModelContent(modelId, DocumentBuildMode.Template)
            {
                AzureBlobSource = source
            };

            RequestFailedException ex = Assert.ThrowsAsync<RequestFailedException>(async () => await client.BuildDocumentModelAsync(WaitUntil.Started, content));

            Assert.That(ex.ErrorCode, Is.EqualTo("InvalidRequest"));
        }

        #endregion Build

        #region Copy

        [RecordedTest]
        public async Task CopyModelTo()
        {
            var client = CreateDocumentIntelligenceAdministrationClient();
            var modelId = Recording.GenerateId();
            var description = "This model was generated by a .NET test.";
            var tags = new Dictionary<string, string>() { { "tag1", "value1" }, { "tag2", "value2" } };
            var startTime = Recording.UtcNow;

            await using var disposableModel = await BuildDisposableDocumentModelAsync(TestEnvironment.BlobContainerSasUrl);

            var authorizeCopyContent = new AuthorizeCopyContent(modelId, description, tags);

            CopyAuthorization copyAuthorization = await client.AuthorizeModelCopyAsync(authorizeCopyContent);

            Operation<DocumentModelDetails> operation = null;

            try
            {
                operation = await client.CopyModelToAsync(WaitUntil.Completed, disposableModel.ModelId, copyAuthorization);
            }
            finally
            {
                if (operation != null && operation.HasCompleted)
                {
                    await client.DeleteModelAsync(modelId);
                }
            }

            Assert.That(operation.HasCompleted);
            Assert.That(operation.HasValue);

            DocumentModelDetails sourceModel = disposableModel.Value;
            DocumentModelDetails model = operation.Value;

            Assert.That(model.ModelId, Is.EqualTo(modelId));
            Assert.That(model.Description, Is.EqualTo(description));
            Assert.That(model.ApiVersion, Is.EqualTo(ServiceVersionString));

            // Add a 4-hour tolerance because the model could have been cached before this test.
            Assert.That(model.CreatedDateTime, Is.GreaterThan(startTime - TimeSpan.FromHours(4)));
            Assert.That(model.ExpirationDateTime, Is.GreaterThan(model.CreatedDateTime));
            Assert.That(model.Tags, Is.EquivalentTo(tags));

            Assert.That(model.AzureBlobSource, Is.Null);
            Assert.That(model.AzureBlobFileListSource, Is.Null);

            // TODO: reenable validation once the following service issue has been fixed: https://github.com/Azure/azure-sdk-for-net/issues/37172
            // DocumentAssert.AreEquivalent(sourceModel.DocTypes, model.DocTypes);
        }

        #endregion Copy

        #region Compose

        [RecordedTest]
        public async Task ComposeModel()
        {
            var client = CreateDocumentIntelligenceAdministrationClient();
            var modelId = Recording.GenerateId();
            var description = "This model was generated by a .NET test.";
            var startTime = Recording.UtcNow;

            // Note: this will fail once we implement model caching. We'll need to set different containers to make it work.
            await using var disposableModel0 = await BuildDisposableDocumentModelAsync(TestEnvironment.BlobContainerSasUrl);
            await using var disposableModel1 = await BuildDisposableDocumentModelAsync(TestEnvironment.BlobContainerSasUrl);

            var componentModels = new List<ComponentDocumentModelDetails>()
            {
                new ComponentDocumentModelDetails(disposableModel0.ModelId),
                new ComponentDocumentModelDetails(disposableModel1.ModelId)
            };

            var content = new ComposeDocumentModelContent(modelId, componentModels)
            {
                Description = description,
                Tags = { { "tag1", "value1" }, { "tag2", "value2" } }
            };

            Operation<DocumentModelDetails> operation = null;

            try
            {
                operation = await client.ComposeModelAsync(WaitUntil.Completed, content);
            }
            finally
            {
                if (operation != null && operation.HasCompleted)
                {
                    await client.DeleteModelAsync(modelId);
                }
            }

            Assert.That(operation.HasCompleted);
            Assert.That(operation.HasValue);

            DocumentModelDetails componentModel0 = disposableModel0.Value;
            DocumentModelDetails componentModel1 = disposableModel1.Value;
            DocumentModelDetails model = operation.Value;

            Assert.That(model.ModelId, Is.EqualTo(modelId));
            Assert.That(model.Description, Is.EqualTo(description));
            Assert.That(model.ApiVersion, Is.EqualTo(ServiceVersionString));

            // Add a 4-hour tolerance because the model could have been cached before this test.
            Assert.That(model.CreatedDateTime, Is.GreaterThan(startTime - TimeSpan.FromHours(4)));
            Assert.That(model.ExpirationDateTime, Is.GreaterThan(model.CreatedDateTime));
            Assert.That(model.Tags, Is.EquivalentTo(content.Tags));

            Assert.That(model.AzureBlobSource, Is.Null);
            Assert.That(model.AzureBlobFileListSource, Is.Null);

            Assert.That(model.DocTypes.Count, Is.EqualTo(2));

            DocumentTypeDetails expectedDocType0 = componentModel0.DocTypes[componentModel0.ModelId];
            DocumentTypeDetails expectedDocType1 = componentModel1.DocTypes[componentModel1.ModelId];
            DocumentTypeDetails docType0 = model.DocTypes[componentModel0.ModelId];
            DocumentTypeDetails docType1 = model.DocTypes[componentModel1.ModelId];

            DocumentAssert.AreEqual(expectedDocType0, docType0);
            DocumentAssert.AreEqual(expectedDocType1, docType1);
        }

        [RecordedTest]
        public void ComposeModelCanParseError()
        {
            var client = CreateDocumentIntelligenceAdministrationClient();
            var modelId = Recording.GenerateId();

            var componentModels = new List<ComponentDocumentModelDetails>()
            {
                new ComponentDocumentModelDetails("00000000-0000-0000-0000-000000000000"),
                new ComponentDocumentModelDetails("00000000-0000-0000-0000-000000000001")
            };

            var content = new ComposeDocumentModelContent(modelId, componentModels);

            RequestFailedException ex = Assert.ThrowsAsync<RequestFailedException>(async () => await client.ComposeModelAsync(WaitUntil.Started, content));

            Assert.That(ex.ErrorCode, Is.EqualTo("InvalidRequest"));
        }

        #endregion Compose

        #region Get

        [RecordedTest]
        public async Task GetModel()
        {
            var client = CreateDocumentIntelligenceAdministrationClient();
            var description = "This model was generated by a .NET test.";
            var tags = new Dictionary<string, string>() { { "tag1", "value1" }, { "tag2", "value2" } };

            await using var disposableModel = await BuildDisposableDocumentModelAsync(TestEnvironment.BlobContainerSasUrl, description, tags);

            DocumentModelDetails expected = disposableModel.Value;
            DocumentModelDetails model = await client.GetModelAsync(disposableModel.ModelId);

            DocumentAssert.AreEqual(expected, model);
        }

        [RecordedTest]
        public void GetModelCanParseError()
        {
            var client = CreateDocumentIntelligenceAdministrationClient();
            var modelId = "00000000-0000-0000-0000-000000000000";

            RequestFailedException ex = Assert.ThrowsAsync<RequestFailedException>(async () => await client.GetModelAsync(modelId));

            Assert.That(ex.ErrorCode, Is.EqualTo("NotFound"));
        }

        #endregion Get

        #region List

        [RecordedTest]
        public async Task GetModels()
        {
            var client = CreateDocumentIntelligenceAdministrationClient();
            var description = "This model was generated by a .NET test.";
            var tags = new Dictionary<string, string>() { { "tag1", "value1" }, { "tag2", "value2" } };

            // Once model caching is implemented, we should make the models slightly different to make sure the cache won't return copies of the same model.
            await using var disposableModel0 = await BuildDisposableDocumentModelAsync(TestEnvironment.BlobContainerSasUrl, description, tags);
            await using var disposableModel1 = await BuildDisposableDocumentModelAsync(TestEnvironment.BlobContainerSasUrl, description, tags);

            var expectedIdMapping = new Dictionary<string, DocumentModelDetails>()
            {
                { disposableModel0.ModelId, disposableModel0.Value },
                { disposableModel1.ModelId, disposableModel1.Value }
            };
            var idMapping = new Dictionary<string, DocumentModelDetails>();

            await foreach (DocumentModelDetails model in client.GetModelsAsync())
            {
                if (expectedIdMapping.ContainsKey(model.ModelId))
                {
                    idMapping.Add(model.ModelId, model);
                }

                if (idMapping.Count == expectedIdMapping.Count)
                {
                    break;
                }
            }

            Assert.That(idMapping.Count, Is.EqualTo(expectedIdMapping.Count));

            foreach (string id in expectedIdMapping.Keys)
            {
                Assert.That(idMapping, Contains.Key(id));

                DocumentModelDetails expected = expectedIdMapping[id];
                DocumentModelDetails model = idMapping[id];

                Assert.That(model.ModelId, Is.EqualTo(expected.ModelId));
                Assert.That(model.Description, Is.EqualTo(expected.Description));
                Assert.That(model.ApiVersion, Is.EqualTo(expected.ApiVersion));
                Assert.That(model.CreatedDateTime, Is.EqualTo(expected.CreatedDateTime));
                Assert.That(model.ExpirationDateTime, Is.EqualTo(expected.ExpirationDateTime));
                Assert.That(model.Tags, Is.EquivalentTo(expected.Tags));

                Assert.That(model.AzureBlobSource, Is.Null);
                Assert.That(model.AzureBlobFileListSource, Is.Null);
                Assert.That(model.DocTypes, Is.Empty);
            }
        }

        #endregion List

        #region Delete

        [RecordedTest]
        public async Task DeleteModel()
        {
            var client = CreateDocumentIntelligenceAdministrationClient();

            // Once model caching is implemented, make sure we don't cache the model we'll delete, otherwise this may affect other tests.
            var disposableModel = await BuildDisposableDocumentModelAsync(TestEnvironment.BlobContainerSasUrl);
            var response = await client.DeleteModelAsync(disposableModel.ModelId);

            Assert.That(response.Status, Is.EqualTo((int)HttpStatusCode.NoContent));
        }

        [RecordedTest]
        public void DeleteModelCanParseError()
        {
            var client = CreateDocumentIntelligenceAdministrationClient();
            var modelId = "00000000-0000-0000-0000-000000000000";

            RequestFailedException ex = Assert.ThrowsAsync<RequestFailedException>(async () => await client.DeleteModelAsync(modelId));

            Assert.That(ex.ErrorCode, Is.EqualTo("NotFound"));
        }

        #endregion Delete

        [RecordedTest]
        public async Task AuthorizeModelCopy()
        {
            var client = CreateDocumentIntelligenceAdministrationClient();
            var modelId = Recording.GenerateId();
            var content = new AuthorizeCopyContent(modelId);

            CopyAuthorization copyAuthorization = await client.AuthorizeModelCopyAsync(content);

            Assert.That(copyAuthorization.TargetModelId, Is.EqualTo(modelId));
            Assert.That(copyAuthorization.TargetResourceId, Is.EqualTo(TestEnvironment.ResourceId));
            Assert.That(copyAuthorization.TargetResourceRegion, Is.EqualTo(TestEnvironment.ResourceRegion));
            Assert.That(copyAuthorization.AccessToken, Is.Not.Null);
            Assert.That(copyAuthorization.AccessToken, Is.Not.Empty);
            Assert.That(copyAuthorization.ExpirationDateTime, Is.GreaterThan(Recording.UtcNow));
        }
    }
}
