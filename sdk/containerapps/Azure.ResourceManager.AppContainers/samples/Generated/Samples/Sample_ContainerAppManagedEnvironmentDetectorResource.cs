// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.AppContainers;

namespace Azure.ResourceManager.AppContainers.Samples
{
    public partial class Sample_ContainerAppManagedEnvironmentDetectorResource
    {
        // Get diagnostic data for a managed environments
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetDiagnosticDataForAManagedEnvironments()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/preview/2023-04-01-preview/examples/ManagedEnvironmentDiagnostics_Get.json
            // this example is just showing the usage of "ManagedEnvironmentDiagnostics_GetDetector" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerAppManagedEnvironmentDetectorResource created on azure
            // for more information of creating ContainerAppManagedEnvironmentDetectorResource, please refer to the document of ContainerAppManagedEnvironmentDetectorResource
            string subscriptionId = "f07f3711-b45e-40fe-a941-4e6d93f851e6";
            string resourceGroupName = "mikono-workerapp-test-rg";
            string environmentName = "mikonokubeenv";
            string detectorName = "ManagedEnvAvailabilityMetrics";
            ResourceIdentifier containerAppManagedEnvironmentDetectorResourceId = ContainerAppManagedEnvironmentDetectorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, environmentName, detectorName);
            ContainerAppManagedEnvironmentDetectorResource containerAppManagedEnvironmentDetector = client.GetContainerAppManagedEnvironmentDetectorResource(containerAppManagedEnvironmentDetectorResourceId);

            // invoke the operation
            ContainerAppManagedEnvironmentDetectorResource result = await containerAppManagedEnvironmentDetector.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerAppDiagnosticData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
