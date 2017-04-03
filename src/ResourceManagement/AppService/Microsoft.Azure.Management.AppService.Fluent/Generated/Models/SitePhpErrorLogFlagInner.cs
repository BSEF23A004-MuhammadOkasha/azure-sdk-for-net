// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.AppService.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.AppService;
    using Microsoft.Azure.Management.AppService.Fluent;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Used for getting PHP error logging flag.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class SitePhpErrorLogFlagInner : Microsoft.Azure.Management.ResourceManager.Fluent.Resource
    {
        /// <summary>
        /// Initializes a new instance of the SitePhpErrorLogFlagInner class.
        /// </summary>
        public SitePhpErrorLogFlagInner()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SitePhpErrorLogFlagInner class.
        /// </summary>
        /// <param name="localLogErrors">Local log_errors setting.</param>
        /// <param name="masterLogErrors">Master log_errors setting.</param>
        /// <param name="localLogErrorsMaxLength">Local log_errors_max_len
        /// setting.</param>
        /// <param name="masterLogErrorsMaxLength">Master log_errors_max_len
        /// setting.</param>
        public SitePhpErrorLogFlagInner(string location = default(string), string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string localLogErrors = default(string), string masterLogErrors = default(string), string localLogErrorsMaxLength = default(string), string masterLogErrorsMaxLength = default(string))
            : base(location, id, name, type, tags)
        {
            LocalLogErrors = localLogErrors;
            MasterLogErrors = masterLogErrors;
            LocalLogErrorsMaxLength = localLogErrorsMaxLength;
            MasterLogErrorsMaxLength = masterLogErrorsMaxLength;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets local log_errors setting.
        /// </summary>
        [JsonProperty(PropertyName = "properties.localLogErrors")]
        public string LocalLogErrors { get; set; }

        /// <summary>
        /// Gets or sets master log_errors setting.
        /// </summary>
        [JsonProperty(PropertyName = "properties.masterLogErrors")]
        public string MasterLogErrors { get; set; }

        /// <summary>
        /// Gets or sets local log_errors_max_len setting.
        /// </summary>
        [JsonProperty(PropertyName = "properties.localLogErrorsMaxLength")]
        public string LocalLogErrorsMaxLength { get; set; }

        /// <summary>
        /// Gets or sets master log_errors_max_len setting.
        /// </summary>
        [JsonProperty(PropertyName = "properties.masterLogErrorsMaxLength")]
        public string MasterLogErrorsMaxLength { get; set; }

    }
}
