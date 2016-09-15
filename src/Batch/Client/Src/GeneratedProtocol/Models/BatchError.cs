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
    /// An error response received from the Azure Batch service.
    /// </summary>
    public partial class BatchError
    {
        /// <summary>
        /// Initializes a new instance of the BatchError class.
        /// </summary>
        public BatchError() { }

        /// <summary>
        /// Initializes a new instance of the BatchError class.
        /// </summary>
        /// <param name="code">An identifier for the error. Codes are
        /// invariant and are intended to be consumed
        /// programmatically.</param>
        /// <param name="message">A message describing the error, intended to
        /// be suitable for display in a user interface.</param>
        /// <param name="values">A collection of key-value pairs containing
        /// additional details about the error.</param>
        public BatchError(string code = default(string), ErrorMessage message = default(ErrorMessage), System.Collections.Generic.IList<BatchErrorDetail> values = default(System.Collections.Generic.IList<BatchErrorDetail>))
        {
            Code = code;
            Message = message;
            Values = values;
        }

        /// <summary>
        /// Gets or sets an identifier for the error. Codes are invariant and
        /// are intended to be consumed programmatically.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets a message describing the error, intended to be
        /// suitable for display in a user interface.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "message")]
        public ErrorMessage Message { get; set; }

        /// <summary>
        /// Gets or sets a collection of key-value pairs containing additional
        /// details about the error.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "values")]
        public System.Collections.Generic.IList<BatchErrorDetail> Values { get; set; }

    }
}
