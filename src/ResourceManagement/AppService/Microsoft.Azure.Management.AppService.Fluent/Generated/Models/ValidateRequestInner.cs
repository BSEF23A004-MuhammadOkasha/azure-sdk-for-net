// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.AppService.Fluent.Models
{
    using System.Linq;

    /// <summary>
    /// Resource validation request content.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class ValidateRequestInner
    {
        /// <summary>
        /// Initializes a new instance of the ValidateRequestInner class.
        /// </summary>
        public ValidateRequestInner() { }

        /// <summary>
        /// Initializes a new instance of the ValidateRequestInner class.
        /// </summary>
        /// <param name="name">Resource name to verify.</param>
        /// <param name="type">Resource type used for verification. Possible
        /// values include: 'ServerFarm', 'Site'</param>
        /// <param name="location">Expected location of the resource.</param>
        /// <param name="serverFarmId">ARM resource ID of an App Service plan
        /// that would host the app.</param>
        /// <param name="skuName">Name of the target SKU for the App Service
        /// plan.</param>
        /// <param name="needLinuxWorkers"><code>true</code> if App Service
        /// plan is for Linux workers; otherwise, <code>false</code>.</param>
        /// <param name="capacity">Target capacity of the App Service plan
        /// (number of VM's).</param>
        /// <param name="hostingEnvironment">Name of App Service Environment
        /// where app or App Service plan should be created.</param>
        public ValidateRequestInner(string name, string type, string location, string serverFarmId = default(string), string skuName = default(string), bool? needLinuxWorkers = default(bool?), int? capacity = default(int?), string hostingEnvironment = default(string))
        {
            Name = name;
            Type = type;
            Location = location;
            ServerFarmId = serverFarmId;
            SkuName = skuName;
            NeedLinuxWorkers = needLinuxWorkers;
            Capacity = capacity;
            HostingEnvironment = hostingEnvironment;
        }

        /// <summary>
        /// Gets or sets resource name to verify.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets resource type used for verification. Possible values
        /// include: 'ServerFarm', 'Site'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets expected location of the resource.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets ARM resource ID of an App Service plan that would
        /// host the app.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.serverFarmId")]
        public string ServerFarmId { get; set; }

        /// <summary>
        /// Gets or sets name of the target SKU for the App Service plan.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.skuName")]
        public string SkuName { get; set; }

        /// <summary>
        /// Gets or sets &lt;code&gt;true&lt;/code&gt; if App Service plan is
        /// for Linux workers; otherwise, &lt;code&gt;false&lt;/code&gt;.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.needLinuxWorkers")]
        public bool? NeedLinuxWorkers { get; set; }

        /// <summary>
        /// Gets or sets target capacity of the App Service plan (number of
        /// VM's).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.capacity")]
        public int? Capacity { get; set; }

        /// <summary>
        /// Gets or sets name of App Service Environment where app or App
        /// Service plan should be created.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.hostingEnvironment")]
        public string HostingEnvironment { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Name");
            }
            if (Type == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Type");
            }
            if (Location == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Location");
            }
            if (this.Capacity < 1)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.InclusiveMinimum, "Capacity", 1);
            }
        }
    }
}
