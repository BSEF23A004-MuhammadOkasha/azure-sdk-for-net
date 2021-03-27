﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core.TestFramework;
using Microsoft.Azure.Management.ContainerRegistry;
using Microsoft.Azure.Management.ContainerRegistry.Models;
using Microsoft.Azure.Management.ResourceManager.Fluent;
using Microsoft.Azure.Management.ResourceManager.Fluent.Authentication;
using NUnit.Framework;
using Task = System.Threading.Tasks.Task;

namespace Azure.Containers.ContainerRegistry.Tests
{
    public class ContainerRepositoryClientLiveTests : RecordedTestBase<ContainerRegistryTestEnvironment>
    {
        private readonly string _repositoryName = "library/hello-world";

        public ContainerRepositoryClientLiveTests(bool isAsync) : base(isAsync, RecordedTestMode.Live)
        {
            Sanitizer = new ContainerRegistryRecordedTestSanitizer();
        }

        #region Setup methods
        protected ContainerRepositoryClient CreateClient(string repository = null)
        {
            return InstrumentClient(new ContainerRepositoryClient(
                new Uri(TestEnvironment.Endpoint),
                repository ?? _repositoryName,
                TestEnvironment.Credential,
                InstrumentClientOptions(new ContainerRegistryClientOptions())
            ));
        }

        public async Task ImportImage(string repository, string tag)
        {
            var credential = new AzureCredentials(
                new ServicePrincipalLoginInformation
                {
                    ClientId = TestEnvironment.ClientId,
                    ClientSecret = TestEnvironment.ClientSecret,
                },
                TestEnvironment.TenantId,
                AzureEnvironment.AzureGlobalCloud);

            var _registryClient = new ContainerRegistryManagementClient(credential.WithDefaultSubscription(TestEnvironment.SubscriptionId));
            _registryClient.SubscriptionId = TestEnvironment.SubscriptionId;

            var importSource = new ImportSource
            {
                SourceImage = repository,
                RegistryUri = "registry.hub.docker.com"
            };

            await _registryClient.Registries.ImportImageAsync(
                resourceGroupName: TestEnvironment.ResourceGroup,
                registryName: TestEnvironment.Registry,
                parameters:
                    new ImportImageParameters
                    {
                        Mode = ImportMode.Force,
                        Source = importSource,
                        TargetTags = new List<string>()
                        {
                            $"{repository}:{tag}"
                        }
                    });
        }
        #endregion

        #region Repository Tests
        [RecordedTest]
        public async Task CanGetRepositoryProperties()
        {
            // Arrange
            ContainerRepositoryClient client = CreateClient();

            // Act
            RepositoryProperties properties = await client.GetPropertiesAsync();

            // Assert
            Assert.AreEqual(_repositoryName, properties.Name);
        }

        [RecordedTest, NonParallelizable]
        public async Task CanSetRepositoryProperties()
        {
            // Arrange
            ContainerRepositoryClient client = CreateClient();
            RepositoryProperties repositoryProperties = await client.GetPropertiesAsync();
            ContentProperties originalContentProperties = repositoryProperties.WriteableProperties;

            // Act
            await client.SetPropertiesAsync(
                new ContentProperties()
                {
                    CanList = false,
                    CanRead = false,
                    CanWrite = false,
                    CanDelete = false,
                });

            // Assert
            RepositoryProperties properties = await client.GetPropertiesAsync();

            Assert.IsFalse(properties.WriteableProperties.CanList);
            Assert.IsFalse(properties.WriteableProperties.CanRead);
            Assert.IsFalse(properties.WriteableProperties.CanWrite);
            Assert.IsFalse(properties.WriteableProperties.CanDelete);

            // Cleanup
            await client.SetPropertiesAsync(originalContentProperties);
        }
        #endregion

        #region Registry Artifact Tests
        [RecordedTest]
        public async Task CanGetMultiArchitectureImageProperties()
        {
            // Arrange
            ContainerRepositoryClient client = CreateClient();
            string tag = "v1";
            int helloWorldManifestReferences = 9;

            // Act
            RegistryArtifactProperties properties = await client.GetRegistryArtifactPropertiesAsync(tag);

            // Assert
            Assert.Contains(tag, properties.Tags.ToList());
            Assert.AreEqual(_repositoryName, properties.Repository);
            Assert.GreaterOrEqual(helloWorldManifestReferences, properties.RegistryArtifacts.Count);

            Assert.IsTrue(properties.RegistryArtifacts.Any(
                artifact => {
                    return artifact.CpuArchitecture == "arm64" &&
                           artifact.OperatingSystem == "linux"; } ));

            Assert.IsTrue(properties.RegistryArtifacts.Any(
                artifact => {
                    return artifact.CpuArchitecture == "amd64" &&
                           artifact.OperatingSystem == "windows";
                }));
        }

        [RecordedTest]
        public async Task CanGetArtifactProperties()
        {
            // Arrange
            ContainerRepositoryClient client = CreateClient();
            string tag = "v1";

            // Act
            RegistryArtifactProperties listProperties = await client.GetRegistryArtifactPropertiesAsync(tag);
            var arm64LinuxImage = listProperties.RegistryArtifacts.Where(
               artifact =>
               {
                   return artifact.CpuArchitecture == "arm64" &&
                          artifact.OperatingSystem == "linux";
               }).First();
            RegistryArtifactProperties properties = await client.GetRegistryArtifactPropertiesAsync(arm64LinuxImage.Digest);

            // Assert
            Assert.AreEqual(_repositoryName, properties.Repository);
            Assert.IsNotNull(properties.Digest);
            Assert.AreEqual("arm64", properties.CpuArchitecture);
            Assert.AreEqual("linux", properties.OperatingSystem);
        }

        [RecordedTest, NonParallelizable]
        public async Task CanSetManifestProperties()
        {
            // Arrange
            ContainerRepositoryClient client = CreateClient();
            string tag = "latest";
            TagProperties tagProperties = await client.GetTagPropertiesAsync(tag);
            string digest = tagProperties.Digest;
            RegistryArtifactProperties artifactProperties = await client.GetRegistryArtifactPropertiesAsync(digest);
            ContentProperties originalContentProperties = artifactProperties.WriteableProperties;

            // Act
            await client.SetManifestPropertiesAsync(
                digest,
                new ContentProperties()
                {
                    CanList = false,
                    CanRead = false,
                    CanWrite = false,
                    CanDelete = false
                });

            // Assert
            RegistryArtifactProperties properties = await client.GetRegistryArtifactPropertiesAsync(digest);

            Assert.IsFalse(properties.WriteableProperties.CanList);
            Assert.IsFalse(properties.WriteableProperties.CanRead);
            Assert.IsFalse(properties.WriteableProperties.CanWrite);
            Assert.IsFalse(properties.WriteableProperties.CanDelete);

            // Cleanup
            await client.SetManifestPropertiesAsync(digest, originalContentProperties);
        }

        [RecordedTest, NonParallelizable]
        public async Task CanDeleteRegistryArtifact()
        {
            // Arrange
            string repository = $"library/node";
            string tag = "test-delete-image";
            ContainerRepositoryClient client = CreateClient(repository);

            if (this.Mode != RecordedTestMode.Playback)
            {
                await ImportImage(repository, tag);
            }

            TagProperties tagProperties = await client.GetTagPropertiesAsync(tag);
            string digest = tagProperties.Digest;

            // Act
            await client.DeleteRegistryArtifactAsync(digest);

            // Assert

            // This will be removed, pending investigation into potential race condition.
            // https://github.com/azure/azure-sdk-for-net/issues/19699
            if (this.Mode != RecordedTestMode.Playback)
            {
                await Task.Delay(5000);
            }

            Assert.ThrowsAsync<RequestFailedException>(async () => { await client.GetRegistryArtifactPropertiesAsync(tag); });
        }

        [RecordedTest]
        public async Task CanGetArtifacts()
        {
            // Arrange
            var client = CreateClient();

            // Act
            AsyncPageable<RegistryArtifactProperties> images = client.GetRegistryArtifactsAsync();

            RegistryArtifactProperties latest = null;
            await foreach (RegistryArtifactProperties image in images)
            {
                if (image.Tags.Count > 0 && image.Tags.Contains("latest"))
                {
                    latest = image;
                    break;
                }
            }

            // Assert
            Assert.IsNotNull(latest);
            Assert.AreEqual(_repositoryName, latest.Repository);
        }

        [RecordedTest]
        public async Task CanGetArtifactsWithCustomPageSize()
        {
            // Arrange
            var client = CreateClient();
            int pageSize = 2;
            int minExpectedPages = 2;

            // Act
            AsyncPageable<RegistryArtifactProperties> artifacts = client.GetRegistryArtifactsAsync();
            var pages = artifacts.AsPages(pageSizeHint: pageSize);

            int pageCount = 0;
            await foreach (var page in pages)
            {
                Assert.GreaterOrEqual(page.Values.Count, pageSize);
                pageCount++;
            }

            // Assert
            Assert.IsTrue(pageCount >= minExpectedPages);
        }

        [RecordedTest]
        public async Task CanGetArtifactsStartingMidCollection()
        {
            // Arrange
            var client = CreateClient();
            int pageSize = 1;
            int minExpectedPages = 2;

            AsyncPageable<RegistryArtifactProperties> artifacts = client.GetRegistryArtifactsAsync();
            string firstDigest = null;
            string secondDigest = null;
            int artifactCount = 0;
            await foreach (var artifact in artifacts)
            {
                if (artifactCount == 0)
                {
                    firstDigest = artifact.Digest;
                }

                if (artifactCount == 1)
                {
                    secondDigest = artifact.Digest;
                    break;
                }

                artifactCount++;
            }

            // Act
            artifacts = client.GetRegistryArtifactsAsync();
            var pages = artifacts.AsPages($"</acr/v1/{_repositoryName}/_manifests?last={firstDigest}&n={pageSize}>");

            int pageCount = 0;
            Page<RegistryArtifactProperties> firstPage = null;
            await foreach (var page in pages)
            {
                if (pageCount == 0)
                {
                    firstPage = page;
                }

                Assert.LessOrEqual(page.Values.Count, pageSize);
                pageCount++;
            }

            // Assert
            Assert.AreNotEqual(null, firstPage);
            Assert.AreEqual(secondDigest, firstPage.Values[0].Digest);
            Assert.GreaterOrEqual(pageCount, minExpectedPages);
        }

        #endregion

        #region Tag Tests
        [RecordedTest]
        public async Task CanGetTagProperties()
        {
            // Arrange
            ContainerRepositoryClient client = CreateClient();
            string tag = "latest";

            // Act
            TagProperties properties = await client.GetTagPropertiesAsync(tag);

            // Assert
            Assert.AreEqual(tag, properties.Name);
            Assert.AreEqual(_repositoryName, properties.Repository);
        }

        [RecordedTest, NonParallelizable]
        public async Task CanSetTagProperties()
        {
            // Arrange
            ContainerRepositoryClient client = CreateClient();
            string tag = "latest";
            TagProperties tagProperties = await client.GetTagPropertiesAsync(tag);
            ContentProperties originalContentProperties = tagProperties.WriteableProperties;

            // Act
            await client.SetTagPropertiesAsync(
                tag,
                new ContentProperties()
                {
                    CanList = false,
                    CanRead = false,
                    CanWrite = false,
                    CanDelete = false
                });

            // Assert
            TagProperties properties = await client.GetTagPropertiesAsync(tag);

            Assert.IsFalse(properties.WriteableProperties.CanList);
            Assert.IsFalse(properties.WriteableProperties.CanRead);
            Assert.IsFalse(properties.WriteableProperties.CanWrite);
            Assert.IsFalse(properties.WriteableProperties.CanDelete);

            // Cleanup
            await client.SetTagPropertiesAsync(tag, originalContentProperties);
        }

        [RecordedTest, NonParallelizable]
        public async Task CanDeleteTag()
        {
            // Arrange
            ContainerRepositoryClient client = CreateClient();
            string tag = "test-delete-tag";

            if (this.Mode != RecordedTestMode.Playback)
            {
                await ImportImage(_repositoryName, tag);
            }

            // Act
            await client.DeleteTagAsync(tag);

            // Assert

            // This will be removed, pending investigation into potential race condition.
            // https://github.com/azure/azure-sdk-for-net/issues/19699
            if (this.Mode != RecordedTestMode.Playback)
            {
                await Task.Delay(5000);
            }

            Assert.ThrowsAsync<RequestFailedException>(async () => { await client.GetTagPropertiesAsync(tag); });
        }
        #endregion
    }
}
