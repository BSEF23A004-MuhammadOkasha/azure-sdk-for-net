// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DevTestLabs.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Status information about a virtual machine.
    /// </summary>
    public partial class ComputeVmInstanceViewStatusFragment
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ComputeVmInstanceViewStatusFragment class.
        /// </summary>
        public ComputeVmInstanceViewStatusFragment()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ComputeVmInstanceViewStatusFragment class.
        /// </summary>
        /// <param name="code">Gets the status Code.</param>
        /// <param name="displayStatus">Gets the short localizable label for
        /// the status.</param>
        /// <param name="message">Gets the message associated with the
        /// status.</param>
        public ComputeVmInstanceViewStatusFragment(string code = default(string), string displayStatus = default(string), string message = default(string))
        {
            Code = code;
            DisplayStatus = displayStatus;
            Message = message;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the status Code.
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets the short localizable label for the status.
        /// </summary>
        [JsonProperty(PropertyName = "displayStatus")]
        public string DisplayStatus { get; set; }

        /// <summary>
        /// Gets the message associated with the status.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

    }
}
