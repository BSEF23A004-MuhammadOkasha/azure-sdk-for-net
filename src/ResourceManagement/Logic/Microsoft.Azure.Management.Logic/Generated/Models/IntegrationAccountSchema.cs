// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Logic.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    [JsonTransformation]
    public partial class IntegrationAccountSchema : IntegrationAccountResource
    {
        /// <summary>
        /// Initializes a new instance of the IntegrationAccountSchema class.
        /// </summary>
        public IntegrationAccountSchema() { }

        /// <summary>
        /// Initializes a new instance of the IntegrationAccountSchema class.
        /// </summary>
        public IntegrationAccountSchema(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), SchemaType? schemaType = default(SchemaType?), string targetNamespace = default(string), string documentName = default(string), string fileName = default(string), DateTime? createdTime = default(DateTime?), DateTime? changedTime = default(DateTime?), object metadata = default(object), object content = default(object), string contentType = default(string), IntegrationAccountContentLink contentLink = default(IntegrationAccountContentLink))
            : base(id, name, type, location, tags)
        {
            SchemaType = schemaType;
            TargetNamespace = targetNamespace;
            DocumentName = documentName;
            FileName = fileName;
            CreatedTime = createdTime;
            ChangedTime = changedTime;
            Metadata = metadata;
            Content = content;
            ContentType = contentType;
            ContentLink = contentLink;
        }

        /// <summary>
        /// Gets or sets the schema type. Possible values include:
        /// 'NotSpecified', 'Xml'
        /// </summary>
        [JsonProperty(PropertyName = "properties.schemaType")]
        public SchemaType? SchemaType { get; set; }

        /// <summary>
        /// Gets or sets the target namespace.
        /// </summary>
        [JsonProperty(PropertyName = "properties.targetNamespace")]
        public string TargetNamespace { get; set; }

        /// <summary>
        /// Gets or sets the document name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.documentName")]
        public string DocumentName { get; set; }

        /// <summary>
        /// Gets or sets the file name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.fileName")]
        public string FileName { get; set; }

        /// <summary>
        /// Gets the created time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.createdTime")]
        public DateTime? CreatedTime { get; private set; }

        /// <summary>
        /// Gets the changed time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.changedTime")]
        public DateTime? ChangedTime { get; private set; }

        /// <summary>
        /// Gets or sets the metadata.
        /// </summary>
        [JsonProperty(PropertyName = "properties.metadata")]
        public object Metadata { get; set; }

        /// <summary>
        /// Gets or sets the content.
        /// </summary>
        [JsonProperty(PropertyName = "properties.content")]
        public object Content { get; set; }

        /// <summary>
        /// Gets or sets the content type.
        /// </summary>
        [JsonProperty(PropertyName = "properties.contentType")]
        public string ContentType { get; set; }

        /// <summary>
        /// Gets the content link.
        /// </summary>
        [JsonProperty(PropertyName = "properties.contentLink")]
        public IntegrationAccountContentLink ContentLink { get; private set; }

    }
}
