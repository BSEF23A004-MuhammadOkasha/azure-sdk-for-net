// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.ApplicationInsights.Query.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A query response table.
    /// </summary>
    /// <remarks>
    /// Contains the columns and rows for one table in a query response.
    /// </remarks>
    public partial class Table
    {
        /// <summary>
        /// Initializes a new instance of the Table class.
        /// </summary>
        public Table()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Table class.
        /// </summary>
        /// <param name="name">The name of the table.</param>
        /// <param name="columns">The list of columns in this table.</param>
        /// <param name="rows">The resulting rows from this query.</param>
        public Table(string name, IList<Column> columns, IList<IList<object>> rows)
        {
            Name = name;
            Columns = columns;
            Rows = rows;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the table.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the list of columns in this table.
        /// </summary>
        [JsonProperty(PropertyName = "columns")]
        public IList<Column> Columns { get; set; }

        /// <summary>
        /// Gets or sets the resulting rows from this query.
        /// </summary>
        [JsonProperty(PropertyName = "rows")]
        public IList<IList<object>> Rows { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (Columns == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Columns");
            }
            if (Rows == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Rows");
            }
        }
    }
}
