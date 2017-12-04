// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Execute SSIS package activity.
    /// </summary>
    [Newtonsoft.Json.JsonObject("ExecuteSSISPackage")]
    [Rest.Serialization.JsonTransformation]
    public partial class ExecuteSSISPackageActivity : ExecutionActivity
    {
        /// <summary>
        /// Initializes a new instance of the ExecuteSSISPackageActivity class.
        /// </summary>
        public ExecuteSSISPackageActivity()
        {
            ConnectVia = new IntegrationRuntimeReference();
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ExecuteSSISPackageActivity class.
        /// </summary>
        /// <param name="name">Activity name.</param>
        /// <param name="packageLocation">SSIS package location.</param>
        /// <param name="connectVia">The integration runtime reference.</param>
        /// <param name="description">Activity description.</param>
        /// <param name="dependsOn">Activity depends on condition.</param>
        /// <param name="linkedServiceName">Linked service reference.</param>
        /// <param name="policy">Activity policy.</param>
        /// <param name="use32bitRuntime">Specifies whether to use 32 bit
        /// runtime to execute SSIS package. Possible values include: 'True',
        /// 'False'</param>
        /// <param name="loggingLevel">The logging level of SSIS package
        /// execution. Possible values include: 'None', 'Basic', 'Performance',
        /// 'Verbose'</param>
        /// <param name="customizedLoggingLevel">The customized logging level
        /// of SSIS package execution.</param>
        /// <param name="environmentPath">The environment path to execution the
        /// SSIS package.</param>
        public ExecuteSSISPackageActivity(string name, SsisPackageLocation packageLocation, IntegrationRuntimeReference connectVia, string description = default(string), IList<ActivityDependency> dependsOn = default(IList<ActivityDependency>), LinkedServiceReference linkedServiceName = default(LinkedServiceReference), ActivityPolicy policy = default(ActivityPolicy), string use32bitRuntime = default(string), string loggingLevel = default(string), string customizedLoggingLevel = default(string), string environmentPath = default(string))
            : base(name, description, dependsOn, linkedServiceName, policy)
        {
            PackageLocation = packageLocation;
            Use32bitRuntime = use32bitRuntime;
            LoggingLevel = loggingLevel;
            CustomizedLoggingLevel = customizedLoggingLevel;
            EnvironmentPath = environmentPath;
            ConnectVia = connectVia;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets SSIS package location.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.packageLocation")]
        public SsisPackageLocation PackageLocation { get; set; }

        /// <summary>
        /// Gets or sets specifies whether to use 32 bit runtime to execute
        /// SSIS package. Possible values include: 'True', 'False'
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.use32bitRuntime")]
        public string Use32bitRuntime { get; set; }

        /// <summary>
        /// Gets or sets the logging level of SSIS package execution. Possible
        /// values include: 'None', 'Basic', 'Performance', 'Verbose'
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.loggingLevel")]
        public string LoggingLevel { get; set; }

        /// <summary>
        /// Gets or sets the customized logging level of SSIS package
        /// execution.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.customizedLoggingLevel")]
        public string CustomizedLoggingLevel { get; set; }

        /// <summary>
        /// Gets or sets the environment path to execution the SSIS package.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.environmentPath")]
        public string EnvironmentPath { get; set; }

        /// <summary>
        /// Gets or sets the integration runtime reference.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.connectVia")]
        public IntegrationRuntimeReference ConnectVia { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (PackageLocation == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PackageLocation");
            }
            if (ConnectVia == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ConnectVia");
            }
            if (PackageLocation != null)
            {
                PackageLocation.Validate();
            }
            if (ConnectVia != null)
            {
                ConnectVia.Validate();
            }
        }
    }
}
