﻿using System.Linq;
using Microsoft.Azure.Management.IotHub;
using Microsoft.Rest.ClientRuntime.Azure.TestFramework;
using Xunit;

namespace ProvisioningServices.Tests
{
    public class ProvisioningClientAllocationPolicyTests : DeviceProvisioningTestBase
    {
        [Fact]
        public void Get()
        {
            using (var context = MockContext.Start(this.GetType().FullName))
            {
                var testName = "unitTestingUpdateAllocationPolicyGet";
                this.Initialize(context);
                var resourceGroup = this.GetResourceGroup(testName);
                var testedService = GetService(testName, resourceGroup.Name);

                
                Assert.Contains(testedService.Properties.AllocationPolicy, x => x.Equals(Constants.AllocationPolicies));
            }
        }
        [Fact]
        public void Update()
        {
            using (var context = MockContext.Start(this.GetType().FullName))
            {
                var testName = "unitTestingDPSAllocationPolicyUpdate";
                this.Initialize(context);
                var resourceGroup = this.GetResourceGroup(testName);
                var testedService = GetService(testName, testName);

                //get a different Allocation policy
                var newAllocationPolicy = Constants.AllocationPolicies
                    .Except(new[] { testedService.Properties.AllocationPolicy }).First();

                testedService.Properties.AllocationPolicy = newAllocationPolicy;

                var updatedInstance =
                    this.provisioningClient.IotDpsResource.CreateOrUpdate(resourceGroup.Name, testName,
                        testedService);

                Assert.Equal(newAllocationPolicy, updatedInstance.Properties.AllocationPolicy);
            }
        }
        
    }
}