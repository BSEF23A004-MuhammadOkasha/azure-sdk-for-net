// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Graph.RBAC.Models
{
    using System.Linq;

    /// <summary>
    /// Server response for GetMemberGroups API call
    /// </summary>
    public partial class UserGetMemberGroupsResultInner
    {
        /// <summary>
        /// Initializes a new instance of the UserGetMemberGroupsResultInner
        /// class.
        /// </summary>
        public UserGetMemberGroupsResultInner() { }

        /// <summary>
        /// Initializes a new instance of the UserGetMemberGroupsResultInner
        /// class.
        /// </summary>
        /// <param name="value">Group Ids of which the user is a member</param>
        public UserGetMemberGroupsResultInner(System.Collections.Generic.IList<string> value = default(System.Collections.Generic.IList<string>))
        {
            Value = value;
        }

        /// <summary>
        /// Gets or sets group Ids of which the user is a member
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "value")]
        public System.Collections.Generic.IList<string> Value { get; set; }

    }
}
