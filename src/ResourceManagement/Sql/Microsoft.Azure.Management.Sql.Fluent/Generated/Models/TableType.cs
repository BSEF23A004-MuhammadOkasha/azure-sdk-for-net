// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Sql.Fluent.Models
{

    /// <summary>
    /// Defines values for TableType.
    /// </summary>
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TableType
    {
        [System.Runtime.Serialization.EnumMember(Value = "BaseTable")]
        BaseTable,
        [System.Runtime.Serialization.EnumMember(Value = "View")]
        View
    }
}
