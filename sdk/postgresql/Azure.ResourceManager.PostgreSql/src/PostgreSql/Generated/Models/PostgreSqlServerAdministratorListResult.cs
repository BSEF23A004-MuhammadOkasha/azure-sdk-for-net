// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.PostgreSql;

namespace Azure.ResourceManager.PostgreSql.Models
{
    /// <summary> The response to a list Active Directory Administrators request. </summary>
    internal partial class PostgreSqlServerAdministratorListResult
    {
        /// <summary> Initializes a new instance of PostgreSqlServerAdministratorListResult. </summary>
        internal PostgreSqlServerAdministratorListResult()
        {
            Value = new ChangeTrackingList<PostgreSqlServerAdministratorData>();
        }

        /// <summary> Initializes a new instance of PostgreSqlServerAdministratorListResult. </summary>
        /// <param name="value"> The list of server Active Directory Administrators for the server. </param>
        internal PostgreSqlServerAdministratorListResult(IReadOnlyList<PostgreSqlServerAdministratorData> value)
        {
            Value = value;
        }

        /// <summary> The list of server Active Directory Administrators for the server. </summary>
        public IReadOnlyList<PostgreSqlServerAdministratorData> Value { get; }
    }
}
