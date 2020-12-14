// <auto-generated>
//
// </auto-generated>

namespace Microsoft.Azure.Management.Scheduler.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class HttpRequest
    {
        /// <summary>
        /// Initializes a new instance of the HttpRequest class.
        /// </summary>
        public HttpRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HttpRequest class.
        /// </summary>
        /// <param name="authentication">Gets or sets the authentication method
        /// of the request.</param>
        /// <param name="uri">Gets or sets the URI of the request.</param>
        /// <param name="method">Gets or sets the method of the
        /// request.</param>
        /// <param name="body">Gets or sets the request body.</param>
        /// <param name="headers">Gets or sets the headers.</param>
        public HttpRequest(HttpAuthentication authentication = default(HttpAuthentication), string uri = default(string), string method = default(string), string body = default(string), IDictionary<string, string> headers = default(IDictionary<string, string>))
        {
            Authentication = authentication;
            Uri = uri;
            Method = method;
            Body = body;
            Headers = headers;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the authentication method of the request.
        /// </summary>
        [JsonProperty(PropertyName = "authentication")]
        public HttpAuthentication Authentication { get; set; }

        /// <summary>
        /// Gets or sets the URI of the request.
        /// </summary>
        [JsonProperty(PropertyName = "uri")]
        public string Uri { get; set; }

        /// <summary>
        /// Gets or sets the method of the request.
        /// </summary>
        [JsonProperty(PropertyName = "method")]
        public string Method { get; set; }

        /// <summary>
        /// Gets or sets the request body.
        /// </summary>
        [JsonProperty(PropertyName = "body")]
        public string Body { get; set; }

        /// <summary>
        /// Gets or sets the headers.
        /// </summary>
        [JsonProperty(PropertyName = "headers")]
        public IDictionary<string, string> Headers { get; set; }

    }
}
