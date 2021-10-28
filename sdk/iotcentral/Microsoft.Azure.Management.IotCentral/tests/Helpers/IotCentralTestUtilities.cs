﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//


namespace IotCentral.Tests.Helpers
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using Microsoft.Azure.Management.IotCentral;
    using Microsoft.Azure.Management.IotCentral.Models;
    using Microsoft.Azure.Management.ResourceManager;
    using Microsoft.Rest.ClientRuntime.Azure.TestFramework;

    public class IotCentralTestUtilities
    {
        public static string DefaultLocation = "EastUS";
        public static string DefaultResourceName = "defaultdotnetsdkapp";
        public static string DefaultUpdateResourceName = "defaultdotnetsdkappupdate";
        public static string DefaultSubdomain = "defaultdotnetsdksubdomain";
        public static string DefaultUpdateSubdomain = "defaultdotnetsdksubdomainupdate";
        public static string DefaultResourceGroupName = "DefaultDotNetSdkIotCentralRG";
        public static string DefaultUpdateResourceGroupName = "DefaultDotNetSdkIotCentralRGUpdate";

        internal static string RandomizedResourceName = DefaultResourceName + Guid.NewGuid().ToString("n");
        internal static string RandomizedSubdomain = DefaultUpdateSubdomain + Guid.NewGuid().ToString("n");
        internal static string RandomizedResourceGroupName = DefaultUpdateSubdomain + Guid.NewGuid().ToString("n");

        internal static List<AppTemplateLocations> SupportedAzureRegions = new List<AppTemplateLocations> {
                    new AppTemplateLocations("australiaeast", "Australia East"),
                    new AppTemplateLocations("australiaeast", "Central US"),
                    new AppTemplateLocations("australiaeast", "East US"),
                    new AppTemplateLocations("australiaeast", "East US 2"),
                    new AppTemplateLocations("australiaeast", "Japan East"),
                    new AppTemplateLocations("australiaeast", "North Europe"),
                    new AppTemplateLocations("australiaeast", "South East Asia"),
                    new AppTemplateLocations("australiaeast", "UK South"),
                    new AppTemplateLocations("australiaeast", "West Europe"),
                    new AppTemplateLocations("australiaeast", "West US") };

        public static IotCentralClient GetIotCentralClient(MockContext context, RecordedDelegatingHandler handler = null)
        {
            if (handler != null)
            {
                handler.IsPassThrough = true;
            }

            return context.GetServiceClient<IotCentralClient>(handlers: handler ?? new RecordedDelegatingHandler { StatusCodeToReturn = HttpStatusCode.OK });
        }

        public static ResourceManagementClient GetResourceManagementClient(MockContext context, RecordedDelegatingHandler handler)
        {
            handler.IsPassThrough = true;
            var client = context.GetServiceClient<ResourceManagementClient>(handlers: handler);
            return client;
        }
    }
}
