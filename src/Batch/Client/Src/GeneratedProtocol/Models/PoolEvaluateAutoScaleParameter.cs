// Copyright (c) Microsoft and contributors.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//
// See the License for the specific language governing permissions and
// limitations under the License.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System.Linq;

    /// <summary>
    /// Options for evaluating an automatic scaling formula on a pool.
    /// </summary>
    public partial class PoolEvaluateAutoScaleParameter
    {
        /// <summary>
        /// Initializes a new instance of the PoolEvaluateAutoScaleParameter
        /// class.
        /// </summary>
        public PoolEvaluateAutoScaleParameter() { }

        /// <summary>
        /// Initializes a new instance of the PoolEvaluateAutoScaleParameter
        /// class.
        /// </summary>
        /// <param name="autoScaleFormula">The formula for the desired number
        /// of compute nodes in the pool.</param>
        public PoolEvaluateAutoScaleParameter(string autoScaleFormula)
        {
            AutoScaleFormula = autoScaleFormula;
        }

        /// <summary>
        /// Gets or sets the formula for the desired number of compute nodes in
        /// the pool.
        /// </summary>
        /// <remarks>
        /// The formula is validated and its results calculated, but it is not
        /// applied to the pool. To apply the formula to the pool, 'Enable
        /// automatic scaling on a pool'. For more information about specifying
        /// this formula, see Automatically scale compute nodes in an Azure
        /// Batch pool
        /// (https://azure.microsoft.com/en-us/documentation/articles/batch-automatic-scaling).
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "autoScaleFormula")]
        public string AutoScaleFormula { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (AutoScaleFormula == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "AutoScaleFormula");
            }
        }
    }
}
