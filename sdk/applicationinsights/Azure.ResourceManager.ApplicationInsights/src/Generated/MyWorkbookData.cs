// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ApplicationInsights.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ApplicationInsights
{
    /// <summary>
    /// A class representing the MyWorkbook data model.
    /// An Application Insights private workbook definition.
    /// </summary>
    public partial class MyWorkbookData : MyWorkbookResourceContent
    {
        /// <summary> Initializes a new instance of MyWorkbookData. </summary>
        public MyWorkbookData()
        {
        }

        /// <summary> Initializes a new instance of MyWorkbookData. </summary>
        /// <param name="identity"> Identity used for BYOS. </param>
        /// <param name="id"> Azure resource Id. </param>
        /// <param name="name"> Azure resource name. </param>
        /// <param name="resourceType"> Azure resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="etag"> Resource etag. </param>
        /// <param name="kind"> The kind of workbook. Choices are user and shared. </param>
        /// <param name="systemData"> Metadata pertaining to creation and last modification of the resource. </param>
        /// <param name="displayName"> The user-defined name of the private workbook. </param>
        /// <param name="serializedData"> Configuration of this particular private workbook. Configuration data is a string containing valid JSON. </param>
        /// <param name="version"> This instance's version of the data model. This can change as new features are added that can be marked private workbook. </param>
        /// <param name="timeModified"> Date and time in UTC of the last modification that was made to this private workbook definition. </param>
        /// <param name="category"> Workbook category, as defined by the user at creation time. </param>
        /// <param name="userId"> Unique user id of the specific user that owns this private workbook. </param>
        /// <param name="sourceId"> Optional resourceId for a source resource. </param>
        /// <param name="storageUri"> BYOS Storage Account URI. </param>
        internal MyWorkbookData(MyWorkbookManagedIdentity identity, string id, string name, string resourceType, AzureLocation? location, IDictionary<string, string> tags, IDictionary<string, string> etag, ApplicationInsightsKind? kind, SystemData systemData, string displayName, string serializedData, string version, string timeModified, string category, string userId, string sourceId, Uri storageUri) : base(identity, id, name, resourceType, location, tags, etag)
        {
            Kind = kind;
            SystemData = systemData;
            DisplayName = displayName;
            SerializedData = serializedData;
            Version = version;
            TimeModified = timeModified;
            Category = category;
            UserId = userId;
            SourceId = sourceId;
            StorageUri = storageUri;
        }

        /// <summary> The kind of workbook. Choices are user and shared. </summary>
        public ApplicationInsightsKind? Kind { get; set; }
        /// <summary> Metadata pertaining to creation and last modification of the resource. </summary>
        public SystemData SystemData { get; }
        /// <summary> The user-defined name of the private workbook. </summary>
        public string DisplayName { get; set; }
        /// <summary> Configuration of this particular private workbook. Configuration data is a string containing valid JSON. </summary>
        public string SerializedData { get; set; }
        /// <summary> This instance's version of the data model. This can change as new features are added that can be marked private workbook. </summary>
        public string Version { get; set; }
        /// <summary> Date and time in UTC of the last modification that was made to this private workbook definition. </summary>
        public string TimeModified { get; }
        /// <summary> Workbook category, as defined by the user at creation time. </summary>
        public string Category { get; set; }
        /// <summary> Unique user id of the specific user that owns this private workbook. </summary>
        public string UserId { get; }
        /// <summary> Optional resourceId for a source resource. </summary>
        public string SourceId { get; set; }
        /// <summary> BYOS Storage Account URI. </summary>
        public Uri StorageUri { get; set; }
    }
}
