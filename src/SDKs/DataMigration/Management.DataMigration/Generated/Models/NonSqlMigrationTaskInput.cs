// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataMigration.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Base class for non sql migration task input
    /// </summary>
    public partial class NonSqlMigrationTaskInput
    {
        /// <summary>
        /// Initializes a new instance of the NonSqlMigrationTaskInput class.
        /// </summary>
        public NonSqlMigrationTaskInput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NonSqlMigrationTaskInput class.
        /// </summary>
        /// <param name="targetConnectionInfo">Information for connecting to
        /// target</param>
        /// <param name="targetDatabaseName">Target database name</param>
        /// <param name="projectName">Name of the migration project</param>
        /// <param name="projectLocation">A URL that points to the drop
        /// location to access project artifacts</param>
        /// <param name="selectedTables">Metadata of the tables selected for
        /// migration</param>
        public NonSqlMigrationTaskInput(SqlConnectionInfo targetConnectionInfo, string targetDatabaseName, string projectName, string projectLocation, IList<NonSqlDataMigrationTable> selectedTables)
        {
            TargetConnectionInfo = targetConnectionInfo;
            TargetDatabaseName = targetDatabaseName;
            ProjectName = projectName;
            ProjectLocation = projectLocation;
            SelectedTables = selectedTables;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets information for connecting to target
        /// </summary>
        [JsonProperty(PropertyName = "targetConnectionInfo")]
        public SqlConnectionInfo TargetConnectionInfo { get; set; }

        /// <summary>
        /// Gets or sets target database name
        /// </summary>
        [JsonProperty(PropertyName = "targetDatabaseName")]
        public string TargetDatabaseName { get; set; }

        /// <summary>
        /// Gets or sets name of the migration project
        /// </summary>
        [JsonProperty(PropertyName = "projectName")]
        public string ProjectName { get; set; }

        /// <summary>
        /// Gets or sets a URL that points to the drop location to access
        /// project artifacts
        /// </summary>
        [JsonProperty(PropertyName = "projectLocation")]
        public string ProjectLocation { get; set; }

        /// <summary>
        /// Gets or sets metadata of the tables selected for migration
        /// </summary>
        [JsonProperty(PropertyName = "selectedTables")]
        public IList<NonSqlDataMigrationTable> SelectedTables { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (TargetConnectionInfo == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TargetConnectionInfo");
            }
            if (TargetDatabaseName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TargetDatabaseName");
            }
            if (ProjectName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ProjectName");
            }
            if (ProjectLocation == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ProjectLocation");
            }
            if (SelectedTables == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SelectedTables");
            }
            if (TargetConnectionInfo != null)
            {
                TargetConnectionInfo.Validate();
            }
        }
    }
}
