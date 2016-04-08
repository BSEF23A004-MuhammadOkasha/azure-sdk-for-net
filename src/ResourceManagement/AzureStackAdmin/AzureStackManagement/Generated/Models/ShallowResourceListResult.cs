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
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.Azure;
using Microsoft.AzureStack.Management.Models;

namespace Microsoft.AzureStack.Management.Models
{
    /// <summary>
    /// Your documentation here.
    /// </summary>
    public partial class ShallowResourceListResult : AzureOperationResponse
    {
        private string _nextLink;
        
        /// <summary>
        /// Required. Gets or sets the URL to get the next set of results.
        /// </summary>
        public string NextLink
        {
            get { return this._nextLink; }
            set { this._nextLink = value; }
        }
        
        private IList<ResourceBase> _shallowResources;
        
        /// <summary>
        /// Optional. Your documentation here.
        /// </summary>
        public IList<ResourceBase> ShallowResources
        {
            get { return this._shallowResources; }
            set { this._shallowResources = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ShallowResourceListResult class.
        /// </summary>
        public ShallowResourceListResult()
        {
            this.ShallowResources = new LazyList<ResourceBase>();
        }
        
        /// <summary>
        /// Initializes a new instance of the ShallowResourceListResult class
        /// with required arguments.
        /// </summary>
        public ShallowResourceListResult(string nextLink)
            : this()
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException("nextLink");
            }
            this.NextLink = nextLink;
        }
    }
}
