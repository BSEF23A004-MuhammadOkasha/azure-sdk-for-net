// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Datadog.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class DatadogLogsAgent
    {
        /// <summary>
        /// Initializes a new instance of the DatadogLogsAgent class.
        /// </summary>
        public DatadogLogsAgent()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DatadogLogsAgent class.
        /// </summary>
        /// <param name="transport">The transport.</param>
        public DatadogLogsAgent(string transport = default(string))
        {
            Transport = transport;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the transport.
        /// </summary>
        [JsonProperty(PropertyName = "transport")]
        public string Transport { get; set; }

    }
}
