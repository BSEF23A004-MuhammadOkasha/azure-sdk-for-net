// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Search.WebSearch.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    [Newtonsoft.Json.JsonObject("Web/WebGrouping")]
    public partial class WebWebGrouping
    {
        /// <summary>
        /// Initializes a new instance of the WebWebGrouping class.
        /// </summary>
        public WebWebGrouping()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WebWebGrouping class.
        /// </summary>
        public WebWebGrouping(IList<WebPage> webPages)
        {
            WebPages = webPages;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "webPages")]
        public IList<WebPage> WebPages { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (WebPages == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "WebPages");
            }
        }
    }
}
