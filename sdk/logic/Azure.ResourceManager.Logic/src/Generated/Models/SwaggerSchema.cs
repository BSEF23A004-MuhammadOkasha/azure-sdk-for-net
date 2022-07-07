// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The swagger schema. </summary>
    public partial class SwaggerSchema
    {
        /// <summary> Initializes a new instance of SwaggerSchema. </summary>
        public SwaggerSchema()
        {
            Properties = new ChangeTrackingDictionary<string, SwaggerSchema>();
            Required = new ChangeTrackingList<string>();
            AllOf = new ChangeTrackingList<SwaggerSchema>();
        }

        /// <summary> Initializes a new instance of SwaggerSchema. </summary>
        /// <param name="ref"> The reference. </param>
        /// <param name="schemaType"> The type. </param>
        /// <param name="title"> The title. </param>
        /// <param name="items"> The items schema. </param>
        /// <param name="properties"> The object properties. </param>
        /// <param name="additionalProperties"> The additional properties. </param>
        /// <param name="required"> The object required properties. </param>
        /// <param name="maxProperties"> The maximum number of allowed properties. </param>
        /// <param name="minProperties"> The minimum number of allowed properties. </param>
        /// <param name="allOf"> The schemas which must pass validation when this schema is used. </param>
        /// <param name="discriminator"> The discriminator. </param>
        /// <param name="readOnly"> Indicates whether this property must be present in the a request. </param>
        /// <param name="xml"> The xml representation format for a property. </param>
        /// <param name="externalDocs"> The external documentation. </param>
        /// <param name="example"> The example value. </param>
        /// <param name="notificationUrlExtension"> Indicates the notification url extension. If this is set, the property&apos;s value should be a callback url for a webhook. </param>
        /// <param name="dynamicSchemaOld"> The dynamic schema configuration. </param>
        /// <param name="dynamicSchemaNew"> The dynamic schema configuration. </param>
        /// <param name="dynamicListNew"> The dynamic list. </param>
        /// <param name="dynamicTree"> The dynamic values tree configuration. </param>
        internal SwaggerSchema(string @ref, SwaggerSchemaType? schemaType, string title, SwaggerSchema items, IDictionary<string, SwaggerSchema> properties, BinaryData additionalProperties, IList<string> required, int? maxProperties, int? minProperties, IList<SwaggerSchema> allOf, string discriminator, bool? readOnly, SwaggerXml xml, SwaggerExternalDocumentation externalDocs, BinaryData example, bool? notificationUrlExtension, SwaggerCustomDynamicSchema dynamicSchemaOld, SwaggerCustomDynamicProperties dynamicSchemaNew, SwaggerCustomDynamicList dynamicListNew, SwaggerCustomDynamicTree dynamicTree)
        {
            Ref = @ref;
            SchemaType = schemaType;
            Title = title;
            Items = items;
            Properties = properties;
            AdditionalProperties = additionalProperties;
            Required = required;
            MaxProperties = maxProperties;
            MinProperties = minProperties;
            AllOf = allOf;
            Discriminator = discriminator;
            ReadOnly = readOnly;
            Xml = xml;
            ExternalDocs = externalDocs;
            Example = example;
            NotificationUrlExtension = notificationUrlExtension;
            DynamicSchemaOld = dynamicSchemaOld;
            DynamicSchemaNew = dynamicSchemaNew;
            DynamicListNew = dynamicListNew;
            DynamicTree = dynamicTree;
        }

        /// <summary> The reference. </summary>
        public string Ref { get; set; }
        /// <summary> The type. </summary>
        public SwaggerSchemaType? SchemaType { get; set; }
        /// <summary> The title. </summary>
        public string Title { get; set; }
        /// <summary> The items schema. </summary>
        public SwaggerSchema Items { get; set; }
        /// <summary> The object properties. </summary>
        public IDictionary<string, SwaggerSchema> Properties { get; }
        /// <summary> The additional properties. </summary>
        public BinaryData AdditionalProperties { get; set; }
        /// <summary> The object required properties. </summary>
        public IList<string> Required { get; }
        /// <summary> The maximum number of allowed properties. </summary>
        public int? MaxProperties { get; set; }
        /// <summary> The minimum number of allowed properties. </summary>
        public int? MinProperties { get; set; }
        /// <summary> The schemas which must pass validation when this schema is used. </summary>
        public IList<SwaggerSchema> AllOf { get; }
        /// <summary> The discriminator. </summary>
        public string Discriminator { get; set; }
        /// <summary> Indicates whether this property must be present in the a request. </summary>
        public bool? ReadOnly { get; set; }
        /// <summary> The xml representation format for a property. </summary>
        public SwaggerXml Xml { get; set; }
        /// <summary> The external documentation. </summary>
        public SwaggerExternalDocumentation ExternalDocs { get; set; }
        /// <summary> The example value. </summary>
        public BinaryData Example { get; set; }
        /// <summary> Indicates the notification url extension. If this is set, the property&apos;s value should be a callback url for a webhook. </summary>
        public bool? NotificationUrlExtension { get; set; }
        /// <summary> The dynamic schema configuration. </summary>
        public SwaggerCustomDynamicSchema DynamicSchemaOld { get; set; }
        /// <summary> The dynamic schema configuration. </summary>
        public SwaggerCustomDynamicProperties DynamicSchemaNew { get; set; }
        /// <summary> The dynamic list. </summary>
        public SwaggerCustomDynamicList DynamicListNew { get; set; }
        /// <summary> The dynamic values tree configuration. </summary>
        public SwaggerCustomDynamicTree DynamicTree { get; set; }
    }
}
