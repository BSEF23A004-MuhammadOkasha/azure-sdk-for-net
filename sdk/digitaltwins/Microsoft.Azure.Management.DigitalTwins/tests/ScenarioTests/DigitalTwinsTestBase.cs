﻿using DigitalTwins.Tests.Helpers;
using Microsoft.Azure.Management.Resources;
using Microsoft.Azure.Management.Resources.Models;
using Microsoft.Azure.Management.DigitalTwins;
using Microsoft.Azure.Management.DigitalTwins.Models;
using Microsoft.Rest.ClientRuntime.Azure.TestFramework;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace DigitalTwins.Tests.ScenarioTests
{
    public class DigitalTwinsTestBase
    {
        protected ResourceManagementClient resourcesClient;
        protected AzureDigitalTwinsManagementClient digitalTwinsClient;

        protected bool initialized = false;
        protected object locker = new object();
        protected string location;
        protected TestEnvironment testEnv;

        protected void Initialize(MockContext context)
        {
            if (!initialized)
            {
                lock (locker)
                {
                    if (!initialized)
                    {
                        testEnv = TestEnvironmentFactory.GetTestEnvironment();
                        resourcesClient = DigitalTwinsTestUtilities.GetResourceManagementClient(context, new RecordedDelegatingHandler { StatusCodeToReturn = HttpStatusCode.OK });

                        if (string.IsNullOrEmpty(Environment.GetEnvironmentVariable("AZURE_VM_TEST_LOCATION")))
                        {
                            location = DigitalTwinsTestUtilities.DefaultLocation;
                        }
                        else
                        {
                            location = Environment.GetEnvironmentVariable("AZURE_VM_TEST_LOCATION").Replace(" ", "").ToLower();
                        }

                        this.initialized = true;
                    }
                }
            }
        }

        protected DigitalTwinsDescription CreateDigitalTwinsInstance(ResourceGroup resourceGroup, string location, string digitalTwinsInstanceName)
        {
            var digitalTwinsDescription = new DigitalTwinsDescription()
            {
                Location = location,
            };
            return this.digitalTwinsClient.DigitalTwins.CreateOrUpdate(
                resourceGroup.Name,
                digitalTwinsInstanceName,
                digitalTwinsDescription
            );
        }
        protected DigitalTwinsDescription UpdateDigitalTwinsInstance(ResourceGroup resourceGroup, DigitalTwinsDescription digitalTwinsDescription, string digitalTwinsInstanceName)
        {
            return this.digitalTwinsClient.DigitalTwins.CreateOrUpdate(
               resourceGroup.Name,
               digitalTwinsInstanceName,
               digitalTwinsDescription
           );
        }


        protected ResourceGroup CreateResourceGroup(string resourceGroupName)
        {
            return this.resourcesClient.ResourceGroups.CreateOrUpdate(resourceGroupName,
                new ResourceGroup
                {
                    Location = DigitalTwinsTestUtilities.DefaultLocation
                });
        }

        protected void DeleteResourceGroup(string resourceGroupName)
        {
            this.resourcesClient.ResourceGroups.Delete(resourceGroupName);
        }

    }
}
