// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.AppComplianceAutomation.Models
{
    /// <summary> Report's properties. </summary>
    public partial class ReportProperties
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ReportProperties"/>. </summary>
        /// <param name="timeZone">
        /// Report collection trigger time's time zone, the available list can be obtained by executing "Get-TimeZone -ListAvailable" in PowerShell.
        /// An example of valid timezone id is "Pacific Standard Time".
        /// </param>
        /// <param name="triggerOn"> Report collection trigger time. </param>
        /// <param name="resources"> List of resource data. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="timeZone"/> or <paramref name="resources"/> is null. </exception>
        public ReportProperties(string timeZone, DateTimeOffset triggerOn, IEnumerable<ResourceMetadata> resources)
        {
            Argument.AssertNotNull(timeZone, nameof(timeZone));
            Argument.AssertNotNull(resources, nameof(resources));

            TimeZone = timeZone;
            TriggerOn = triggerOn;
            Subscriptions = new ChangeTrackingList<string>();
            Resources = resources.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="ReportProperties"/>. </summary>
        /// <param name="id"> Report id in database. </param>
        /// <param name="status"> Report status. </param>
        /// <param name="tenantId"> Report's tenant id. </param>
        /// <param name="reportName"> Report name. </param>
        /// <param name="offerGuid"> Report offer Guid. </param>
        /// <param name="timeZone">
        /// Report collection trigger time's time zone, the available list can be obtained by executing "Get-TimeZone -ListAvailable" in PowerShell.
        /// An example of valid timezone id is "Pacific Standard Time".
        /// </param>
        /// <param name="triggerOn"> Report collection trigger time. </param>
        /// <param name="nextTriggerOn"> Report next collection trigger time. </param>
        /// <param name="lastTriggerOn"> Report last collection trigger time. </param>
        /// <param name="subscriptions"> List of subscription Ids. </param>
        /// <param name="resources"> List of resource data. </param>
        /// <param name="complianceStatus"> Report compliance status. </param>
        /// <param name="provisioningState"> Azure lifecycle management. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ReportProperties(string id, ReportStatus? status, Guid? tenantId, string reportName, string offerGuid, string timeZone, DateTimeOffset triggerOn, DateTimeOffset? nextTriggerOn, DateTimeOffset? lastTriggerOn, IReadOnlyList<string> subscriptions, IList<ResourceMetadata> resources, ReportComplianceStatus complianceStatus, ProvisioningState? provisioningState, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            Status = status;
            TenantId = tenantId;
            ReportName = reportName;
            OfferGuid = offerGuid;
            TimeZone = timeZone;
            TriggerOn = triggerOn;
            NextTriggerOn = nextTriggerOn;
            LastTriggerOn = lastTriggerOn;
            Subscriptions = subscriptions;
            Resources = resources;
            ComplianceStatus = complianceStatus;
            ProvisioningState = provisioningState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ReportProperties"/> for deserialization. </summary>
        internal ReportProperties()
        {
        }

        /// <summary> Report id in database. </summary>
        public string Id { get; }
        /// <summary> Report status. </summary>
        public ReportStatus? Status { get; }
        /// <summary> Report's tenant id. </summary>
        public Guid? TenantId { get; }
        /// <summary> Report name. </summary>
        public string ReportName { get; }
        /// <summary> Report offer Guid. </summary>
        public string OfferGuid { get; set; }
        /// <summary>
        /// Report collection trigger time's time zone, the available list can be obtained by executing "Get-TimeZone -ListAvailable" in PowerShell.
        /// An example of valid timezone id is "Pacific Standard Time".
        /// </summary>
        public string TimeZone { get; set; }
        /// <summary> Report collection trigger time. </summary>
        public DateTimeOffset TriggerOn { get; set; }
        /// <summary> Report next collection trigger time. </summary>
        public DateTimeOffset? NextTriggerOn { get; }
        /// <summary> Report last collection trigger time. </summary>
        public DateTimeOffset? LastTriggerOn { get; }
        /// <summary> List of subscription Ids. </summary>
        public IReadOnlyList<string> Subscriptions { get; }
        /// <summary> List of resource data. </summary>
        public IList<ResourceMetadata> Resources { get; }
        /// <summary> Report compliance status. </summary>
        internal ReportComplianceStatus ComplianceStatus { get; }
        /// <summary> The Microsoft 365 certification name. </summary>
        public OverviewStatus ComplianceStatusM365
        {
            get => ComplianceStatus?.M365;
        }

        /// <summary> Azure lifecycle management. </summary>
        public ProvisioningState? ProvisioningState { get; }
    }
}
