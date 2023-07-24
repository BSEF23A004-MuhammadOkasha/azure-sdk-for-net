// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Package store for the SSIS integration runtime. </summary>
    public partial class DataFactoryPackageStore
    {
        /// <summary> Initializes a new instance of DataFactoryPackageStore. </summary>
        /// <param name="name"> The name of the package store. </param>
        /// <param name="packageStoreLinkedService"> The package store linked service reference. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="packageStoreLinkedService"/> is null. </exception>
        public DataFactoryPackageStore(string name, EntityReference packageStoreLinkedService)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(packageStoreLinkedService, nameof(packageStoreLinkedService));

            Name = name;
            PackageStoreLinkedService = packageStoreLinkedService;
        }

        /// <summary> The name of the package store. </summary>
        public string Name { get; set; }
        /// <summary> The package store linked service reference. </summary>
        public EntityReference PackageStoreLinkedService { get; set; }
    }
}
