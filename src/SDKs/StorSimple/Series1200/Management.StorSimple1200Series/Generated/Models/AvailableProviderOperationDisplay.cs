// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StorSimple1200Series.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Contains the localized display information for this particular
    /// operation / action.
    /// These value will be used by several clients for
    /// (1) custom role definitions for RBAC;
    /// (2) complex query filters for the event service; and (3) audit history
    /// / records for management operations.
    /// </summary>
    public partial class AvailableProviderOperationDisplay
    {
        /// <summary>
        /// Initializes a new instance of the AvailableProviderOperationDisplay
        /// class.
        /// </summary>
        public AvailableProviderOperationDisplay()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AvailableProviderOperationDisplay
        /// class.
        /// </summary>
        /// <param name="provider">Gets or sets Provider
        /// The localized friendly form of the resource provider name – it is
        /// expected to also include the publisher/company responsible.
        /// It should use Title Casing and begin with “Microsoft” for 1st party
        /// services.</param>
        /// <param name="resource">Gets or sets Resource
        /// The localized friendly form of the resource type related to this
        /// action/operation – it should match the public documentation for the
        /// resource provider.
        /// It should use Title Casing – for examples, please refer to the
        /// “name” section.</param>
        /// <param name="operation">Gets or sets Operation
        /// The localized friendly name for the operation, as it should be
        /// shown to the user.
        /// It should be concise (to fit in drop downs) but clear (i.e.
        /// self-documenting). It should use Title Casing and include the
        /// entity/resource to which it applies.</param>
        /// <param name="description">Gets or sets Description
        /// The localized friendly description for the operation, as it should
        /// be shown to the user.
        /// It should be thorough, yet concise – it will be used in tool tips
        /// and detailed views.</param>
        public AvailableProviderOperationDisplay(string provider = default(string), string resource = default(string), string operation = default(string), string description = default(string))
        {
            Provider = provider;
            Resource = resource;
            Operation = operation;
            Description = description;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets Provider
        /// The localized friendly form of the resource provider name – it is
        /// expected to also include the publisher/company responsible.
        /// It should use Title Casing and begin with “Microsoft” for 1st party
        /// services.
        /// </summary>
        [JsonProperty(PropertyName = "provider")]
        public string Provider { get; set; }

        /// <summary>
        /// Gets or sets Resource
        /// The localized friendly form of the resource type related to this
        /// action/operation – it should match the public documentation for the
        /// resource provider.
        /// It should use Title Casing – for examples, please refer to the
        /// “name” section.
        /// </summary>
        [JsonProperty(PropertyName = "resource")]
        public string Resource { get; set; }

        /// <summary>
        /// Gets or sets Operation
        /// The localized friendly name for the operation, as it should be
        /// shown to the user.
        /// It should be concise (to fit in drop downs) but clear (i.e.
        /// self-documenting). It should use Title Casing and include the
        /// entity/resource to which it applies.
        /// </summary>
        [JsonProperty(PropertyName = "operation")]
        public string Operation { get; set; }

        /// <summary>
        /// Gets or sets Description
        /// The localized friendly description for the operation, as it should
        /// be shown to the user.
        /// It should be thorough, yet concise – it will be used in tool tips
        /// and detailed views.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

    }
}
