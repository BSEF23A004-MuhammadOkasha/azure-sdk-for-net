// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Language.LUIS.Authoring.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// List Entity Extractor.
    /// </summary>
    public partial class ClosedListEntityExtractor
    {
        /// <summary>
        /// Initializes a new instance of the ClosedListEntityExtractor class.
        /// </summary>
        public ClosedListEntityExtractor()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ClosedListEntityExtractor class.
        /// </summary>
        /// <param name="id">The ID of the Entity Model.</param>
        /// <param name="readableType">Possible values include: 'Entity
        /// Extractor', 'Hierarchical Entity Extractor', 'Hierarchical Child
        /// Entity Extractor', 'Composite Entity Extractor', 'List Entity
        /// Extractor', 'Prebuilt Entity Extractor', 'Intent Classifier',
        /// 'Pattern.Any Entity Extractor', 'Closed List Entity Extractor',
        /// 'Regex Entity Extractor'</param>
        /// <param name="name">Name of the Entity Model.</param>
        /// <param name="typeId">The type ID of the Entity Model.</param>
        /// <param name="subLists">List of sublists.</param>
        public ClosedListEntityExtractor(System.Guid id, string readableType, string name = default(string), int? typeId = default(int?), IList<EntityRole> roles = default(IList<EntityRole>), IList<SubClosedListResponse> subLists = default(IList<SubClosedListResponse>))
        {
            Id = id;
            Name = name;
            TypeId = typeId;
            ReadableType = readableType;
            Roles = roles;
            SubLists = subLists;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the ID of the Entity Model.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public System.Guid Id { get; set; }

        /// <summary>
        /// Gets or sets name of the Entity Model.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the type ID of the Entity Model.
        /// </summary>
        [JsonProperty(PropertyName = "typeId")]
        public int? TypeId { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Entity Extractor',
        /// 'Hierarchical Entity Extractor', 'Hierarchical Child Entity
        /// Extractor', 'Composite Entity Extractor', 'List Entity Extractor',
        /// 'Prebuilt Entity Extractor', 'Intent Classifier', 'Pattern.Any
        /// Entity Extractor', 'Closed List Entity Extractor', 'Regex Entity
        /// Extractor'
        /// </summary>
        [JsonProperty(PropertyName = "readableType")]
        public string ReadableType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "roles")]
        public IList<EntityRole> Roles { get; set; }

        /// <summary>
        /// Gets or sets list of sublists.
        /// </summary>
        [JsonProperty(PropertyName = "subLists")]
        public IList<SubClosedListResponse> SubLists { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ReadableType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ReadableType");
            }
        }
    }
}
