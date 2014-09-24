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
using Microsoft.WindowsAzure.Management.SiteRecovery.Models;

namespace Microsoft.WindowsAzure.Management.SiteRecovery.Models
{
    /// <summary>
    /// The response model for the list recoveryplans operation.
    /// </summary>
    public partial class RecoveryPlanListResponse : OperationResponse, IEnumerable<RecoveryPlan>
    {
        private IList<RecoveryPlan> _recoveryPlans;
        
        /// <summary>
        /// Optional. The list of recoveryplans for the given cloud service and
        /// resource.
        /// </summary>
        public IList<RecoveryPlan> RecoveryPlans
        {
            get { return this._recoveryPlans; }
            set { this._recoveryPlans = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the RecoveryPlanListResponse class.
        /// </summary>
        public RecoveryPlanListResponse()
        {
            this.RecoveryPlans = new List<RecoveryPlan>();
        }
        
        /// <summary>
        /// Gets the sequence of RecoveryPlans.
        /// </summary>
        public IEnumerator<RecoveryPlan> GetEnumerator()
        {
            return this.RecoveryPlans.GetEnumerator();
        }
        
        /// <summary>
        /// Gets the sequence of RecoveryPlans.
        /// </summary>
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
