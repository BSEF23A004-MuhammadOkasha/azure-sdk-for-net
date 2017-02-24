// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Sql.Models
{
    using System.Linq;

    /// <summary>
    /// Represents the properties of a recommended Azure SQL Database being
    /// upgraded.
    /// </summary>
    public partial class RecommendedDatabaseProperties
    {
        /// <summary>
        /// Initializes a new instance of the RecommendedDatabaseProperties
        /// class.
        /// </summary>
        public RecommendedDatabaseProperties() { }

        /// <summary>
        /// Initializes a new instance of the RecommendedDatabaseProperties
        /// class.
        /// </summary>
        /// <param name="name">The name of the Azure SQL Database being
        /// upgraded.</param>
        /// <param name="targetEdition">The target edition for the Azure SQL
        /// Database being upgraded. Possible values include: 'Basic',
        /// 'Standard', 'Premium', 'Free', 'Stretch', 'DataWarehouse'</param>
        /// <param name="targetServiceLevelObjective">The target Service Level
        /// Objective for the Azure SQL Database being upgraded.</param>
        public RecommendedDatabaseProperties(string name = default(string), string targetEdition = default(string), string targetServiceLevelObjective = default(string))
        {
            Name = name;
            TargetEdition = targetEdition;
            TargetServiceLevelObjective = targetServiceLevelObjective;
        }

        /// <summary>
        /// Gets or sets the name of the Azure SQL Database being upgraded.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the target edition for the Azure SQL Database being
        /// upgraded. Possible values include: 'Basic', 'Standard',
        /// 'Premium', 'Free', 'Stretch', 'DataWarehouse'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "TargetEdition")]
        public string TargetEdition { get; set; }

        /// <summary>
        /// Gets or sets the target Service Level Objective for the Azure SQL
        /// Database being upgraded.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "TargetServiceLevelObjective")]
        public string TargetServiceLevelObjective { get; set; }

    }
}
