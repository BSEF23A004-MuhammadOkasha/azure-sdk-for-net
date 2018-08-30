// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.CognitiveServices.ContentModerator.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class Body
    {
        /// <summary>
        /// Initializes a new instance of the Body class.
        /// </summary>
        public Body()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Body class.
        /// </summary>
        /// <param name="name">Name of the list.</param>
        /// <param name="description">Description of the list.</param>
        /// <param name="metadata">Metadata of the list.</param>
        public Body(string name = default(string), string description = default(string), IDictionary<string, string> metadata = default(IDictionary<string, string>))
        {
            Name = name;
            Description = description;
            Metadata = metadata;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the list.
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets description of the list.
        /// </summary>
        [JsonProperty(PropertyName = "Description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets metadata of the list.
        /// </summary>
        [JsonProperty(PropertyName = "Metadata")]
        public IDictionary<string, string> Metadata { get; set; }

    }
}
