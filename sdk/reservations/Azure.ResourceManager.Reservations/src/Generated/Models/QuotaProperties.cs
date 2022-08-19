// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Reservations.Models
{
    /// <summary> Quota properties for the resource. </summary>
    public partial class QuotaProperties
    {
        /// <summary> Initializes a new instance of QuotaProperties. </summary>
        public QuotaProperties()
        {
        }

        /// <summary> Initializes a new instance of QuotaProperties. </summary>
        /// <param name="limit"> Quota properties. </param>
        /// <param name="currentValue"> Current usage value for the resource. </param>
        /// <param name="unit"> The limit units, such as **count** and **bytes**. Use the unit field provided in the response of the GET quota operation. </param>
        /// <param name="resourceName"> Name of the resource provide by the resource provider. Use this property for quotaRequests resource operations. </param>
        /// <param name="resourceTypeName"> The name of the resource type. </param>
        /// <param name="quotaPeriod"> The time period over which the quota usage values are summarized. For example, P1D (per one day), PT1M (per one minute), and PT1S (per one second). This parameter is optional because, for some resources such as compute, the time period is irrelevant. </param>
        /// <param name="properties"> Additional properties for the specified resource provider. </param>
        internal QuotaProperties(int? limit, int? currentValue, string unit, ReservationResourceName resourceName, ResourceTypeName? resourceTypeName, string quotaPeriod, BinaryData properties)
        {
            Limit = limit;
            CurrentValue = currentValue;
            Unit = unit;
            ResourceName = resourceName;
            ResourceTypeName = resourceTypeName;
            QuotaPeriod = quotaPeriod;
            Properties = properties;
        }

        /// <summary> Quota properties. </summary>
        public int? Limit { get; set; }
        /// <summary> Current usage value for the resource. </summary>
        public int? CurrentValue { get; }
        /// <summary> The limit units, such as **count** and **bytes**. Use the unit field provided in the response of the GET quota operation. </summary>
        public string Unit { get; set; }
        /// <summary> Name of the resource provide by the resource provider. Use this property for quotaRequests resource operations. </summary>
        public ReservationResourceName ResourceName { get; set; }
        /// <summary> The name of the resource type. </summary>
        public ResourceTypeName? ResourceTypeName { get; set; }
        /// <summary> The time period over which the quota usage values are summarized. For example, P1D (per one day), PT1M (per one minute), and PT1S (per one second). This parameter is optional because, for some resources such as compute, the time period is irrelevant. </summary>
        public string QuotaPeriod { get; }
        /// <summary>
        /// Additional properties for the specified resource provider.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
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
        public BinaryData Properties { get; set; }
    }
}
