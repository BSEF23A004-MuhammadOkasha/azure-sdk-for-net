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
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Management.ServiceBus.Models;

namespace Microsoft.WindowsAzure.Management.ServiceBus.Models
{
    /// <summary>
    /// A response to a request for a list of namespaces.
    /// </summary>
    public partial class ServiceBusNamespaceDescriptionResponse : OperationResponse, IEnumerable<NamespaceDescription>
    {
        private IList<NamespaceDescription> _namespaceDescriptions;
        
        /// <summary>
        /// The descriptions for the namespace.
        /// </summary>
        public IList<NamespaceDescription> NamespaceDescriptions
        {
            get { return this._namespaceDescriptions; }
            set { this._namespaceDescriptions = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// ServiceBusNamespaceDescriptionResponse class.
        /// </summary>
        public ServiceBusNamespaceDescriptionResponse()
        {
            this._namespaceDescriptions = new List<NamespaceDescription>();
        }
        
        /// <summary>
        /// Gets the sequence of NamespaceDescriptions.
        /// </summary>
        public IEnumerator<NamespaceDescription> GetEnumerator()
        {
            return this.NamespaceDescriptions.GetEnumerator();
        }
        
        /// <summary>
        /// Gets the sequence of NamespaceDescriptions.
        /// </summary>
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
