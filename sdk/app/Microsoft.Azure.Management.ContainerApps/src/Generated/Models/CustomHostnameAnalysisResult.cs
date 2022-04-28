// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerApps.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Custom domain analysis.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class CustomHostnameAnalysisResult : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the CustomHostnameAnalysisResult
        /// class.
        /// </summary>
        public CustomHostnameAnalysisResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CustomHostnameAnalysisResult
        /// class.
        /// </summary>
        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. E.g.
        /// "Microsoft.Compute/virtualMachines" or
        /// "Microsoft.Storage/storageAccounts"</param>
        /// <param name="systemData">Azure Resource Manager metadata containing
        /// createdBy and modifiedBy information.</param>
        /// <param name="hostName">Host name that was analyzed</param>
        /// <param
        /// name="isHostnameAlreadyVerified">&lt;code&gt;true&lt;/code&gt; if
        /// hostname is already verified; otherwise,
        /// &lt;code&gt;false&lt;/code&gt;.</param>
        /// <param name="customDomainVerificationTest">DNS verification test
        /// result. Possible values include: 'Passed', 'Failed',
        /// 'Skipped'</param>
        /// <param name="customDomainVerificationFailureInfo">Raw failure
        /// information if DNS verification fails.</param>
        /// <param
        /// name="hasConflictOnManagedEnvironment">&lt;code&gt;true&lt;/code&gt;
        /// if there is a conflict on the Container App's managed environment;
        /// otherwise, &lt;code&gt;false&lt;/code&gt;.</param>
        /// <param name="conflictingContainerAppResourceId">Name of the
        /// conflicting Container App on the Managed Environment if it's within
        /// the same subscription.</param>
        /// <param name="cNameRecords">CName records visible for this
        /// hostname.</param>
        /// <param name="txtRecords">TXT records visible for this
        /// hostname.</param>
        /// <param name="aRecords">A records visible for this hostname.</param>
        /// <param name="alternateCNameRecords">Alternate CName records visible
        /// for this hostname.</param>
        /// <param name="alternateTxtRecords">Alternate TXT records visible for
        /// this hostname.</param>
        public CustomHostnameAnalysisResult(string id = default(string), string name = default(string), string type = default(string), SystemData systemData = default(SystemData), string hostName = default(string), bool? isHostnameAlreadyVerified = default(bool?), DnsVerificationTestResult? customDomainVerificationTest = default(DnsVerificationTestResult?), DefaultErrorResponse customDomainVerificationFailureInfo = default(DefaultErrorResponse), bool? hasConflictOnManagedEnvironment = default(bool?), string conflictingContainerAppResourceId = default(string), IList<string> cNameRecords = default(IList<string>), IList<string> txtRecords = default(IList<string>), IList<string> aRecords = default(IList<string>), IList<string> alternateCNameRecords = default(IList<string>), IList<string> alternateTxtRecords = default(IList<string>))
            : base(id, name, type, systemData)
        {
            HostName = hostName;
            IsHostnameAlreadyVerified = isHostnameAlreadyVerified;
            CustomDomainVerificationTest = customDomainVerificationTest;
            CustomDomainVerificationFailureInfo = customDomainVerificationFailureInfo;
            HasConflictOnManagedEnvironment = hasConflictOnManagedEnvironment;
            ConflictingContainerAppResourceId = conflictingContainerAppResourceId;
            CNameRecords = cNameRecords;
            TxtRecords = txtRecords;
            ARecords = aRecords;
            AlternateCNameRecords = alternateCNameRecords;
            AlternateTxtRecords = alternateTxtRecords;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets host name that was analyzed
        /// </summary>
        [JsonProperty(PropertyName = "properties.hostName")]
        public string HostName { get; private set; }

        /// <summary>
        /// Gets &amp;lt;code&amp;gt;true&amp;lt;/code&amp;gt; if hostname is
        /// already verified; otherwise,
        /// &amp;lt;code&amp;gt;false&amp;lt;/code&amp;gt;.
        /// </summary>
        [JsonProperty(PropertyName = "properties.isHostnameAlreadyVerified")]
        public bool? IsHostnameAlreadyVerified { get; private set; }

        /// <summary>
        /// Gets DNS verification test result. Possible values include:
        /// 'Passed', 'Failed', 'Skipped'
        /// </summary>
        [JsonProperty(PropertyName = "properties.customDomainVerificationTest")]
        public DnsVerificationTestResult? CustomDomainVerificationTest { get; private set; }

        /// <summary>
        /// Gets raw failure information if DNS verification fails.
        /// </summary>
        [JsonProperty(PropertyName = "properties.customDomainVerificationFailureInfo")]
        public DefaultErrorResponse CustomDomainVerificationFailureInfo { get; private set; }

        /// <summary>
        /// Gets &amp;lt;code&amp;gt;true&amp;lt;/code&amp;gt; if there is a
        /// conflict on the Container App's managed environment; otherwise,
        /// &amp;lt;code&amp;gt;false&amp;lt;/code&amp;gt;.
        /// </summary>
        [JsonProperty(PropertyName = "properties.hasConflictOnManagedEnvironment")]
        public bool? HasConflictOnManagedEnvironment { get; private set; }

        /// <summary>
        /// Gets name of the conflicting Container App on the Managed
        /// Environment if it's within the same subscription.
        /// </summary>
        [JsonProperty(PropertyName = "properties.conflictingContainerAppResourceId")]
        public string ConflictingContainerAppResourceId { get; private set; }

        /// <summary>
        /// Gets or sets cName records visible for this hostname.
        /// </summary>
        [JsonProperty(PropertyName = "properties.cNameRecords")]
        public IList<string> CNameRecords { get; set; }

        /// <summary>
        /// Gets or sets TXT records visible for this hostname.
        /// </summary>
        [JsonProperty(PropertyName = "properties.txtRecords")]
        public IList<string> TxtRecords { get; set; }

        /// <summary>
        /// Gets or sets a records visible for this hostname.
        /// </summary>
        [JsonProperty(PropertyName = "properties.aRecords")]
        public IList<string> ARecords { get; set; }

        /// <summary>
        /// Gets or sets alternate CName records visible for this hostname.
        /// </summary>
        [JsonProperty(PropertyName = "properties.alternateCNameRecords")]
        public IList<string> AlternateCNameRecords { get; set; }

        /// <summary>
        /// Gets or sets alternate TXT records visible for this hostname.
        /// </summary>
        [JsonProperty(PropertyName = "properties.alternateTxtRecords")]
        public IList<string> AlternateTxtRecords { get; set; }

    }
}
