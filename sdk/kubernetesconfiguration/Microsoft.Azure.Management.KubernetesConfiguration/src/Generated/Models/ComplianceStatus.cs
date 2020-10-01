// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.KubernetesConfiguration.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Compliance Status details
    /// </summary>
    public partial class ComplianceStatus
    {
        /// <summary>
        /// Initializes a new instance of the ComplianceStatus class.
        /// </summary>
        public ComplianceStatus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ComplianceStatus class.
        /// </summary>
        /// <param name="complianceState">The compliance state of the
        /// configuration. Possible values include: 'Pending', 'Compliant',
        /// 'Noncompliant'</param>
        /// <param name="lastConfigApplied">Datetime the configuration was last
        /// applied.</param>
        /// <param name="message">Message from when the configuration was
        /// applied.</param>
        /// <param name="messageLevel">Level of the message. Possible values
        /// include: 'Error', 'Warning', 'Information'</param>
        public ComplianceStatus(ComplianceState? complianceState = default(ComplianceState?), System.DateTime? lastConfigApplied = default(System.DateTime?), string message = default(string), MessageLevel? messageLevel = default(MessageLevel?))
        {
            ComplianceState = complianceState;
            LastConfigApplied = lastConfigApplied;
            Message = message;
            MessageLevel = messageLevel;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the compliance state of the configuration. Possible values
        /// include: 'Pending', 'Compliant', 'Noncompliant'
        /// </summary>
        [JsonProperty(PropertyName = "complianceState")]
        public ComplianceState? ComplianceState { get; private set; }

        /// <summary>
        /// Gets or sets datetime the configuration was last applied.
        /// </summary>
        [JsonProperty(PropertyName = "lastConfigApplied")]
        public System.DateTime? LastConfigApplied { get; set; }

        /// <summary>
        /// Gets or sets message from when the configuration was applied.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets level of the message. Possible values include:
        /// 'Error', 'Warning', 'Information'
        /// </summary>
        [JsonProperty(PropertyName = "messageLevel")]
        public MessageLevel? MessageLevel { get; set; }

    }
}
