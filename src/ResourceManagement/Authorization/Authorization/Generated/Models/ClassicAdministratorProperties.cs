// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;

namespace Microsoft.Azure.Management.Authorization.Models
{
    /// <summary>
    /// Classic Administrator properties.
    /// </summary>
    public partial class ClassicAdministratorProperties
    {
        private string _emailAddress;
        
        /// <summary>
        /// Optional. Gets or sets the email address
        /// </summary>
        public string EmailAddress
        {
            get { return this._emailAddress; }
            set { this._emailAddress = value; }
        }
        
        private string _role;
        
        /// <summary>
        /// Optional. Gets or sets the role
        /// </summary>
        public string Role
        {
            get { return this._role; }
            set { this._role = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ClassicAdministratorProperties
        /// class.
        /// </summary>
        public ClassicAdministratorProperties()
        {
        }
    }
}
