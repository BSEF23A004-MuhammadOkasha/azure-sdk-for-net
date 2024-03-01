// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.FrontDoor;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.FrontDoor.Models
{
    /// <summary> Defines the LatencyScorecard. </summary>
    public partial class LatencyScorecard : TrackedResourceData
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

        /// <summary> Initializes a new instance of <see cref="LatencyScorecard"/>. </summary>
        /// <param name="location"> The location. </param>
        public LatencyScorecard(AzureLocation location) : base(location)
        {
            LatencyMetrics = new ChangeTrackingList<LatencyMetric>();
        }

        /// <summary> Initializes a new instance of <see cref="LatencyScorecard"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="latencyScorecardId"> The unique identifier of the Latency Scorecard. </param>
        /// <param name="latencyScorecardName"> The name of the Latency Scorecard. </param>
        /// <param name="description"> The description of the Latency Scorecard. </param>
        /// <param name="scorecardEndpointA"> The A endpoint in the scorecard. </param>
        /// <param name="scorecardEndpointB"> The B endpoint in the scorecard. </param>
        /// <param name="startOn"> The start time of the Latency Scorecard in UTC. </param>
        /// <param name="endOn"> The end time of the Latency Scorecard in UTC. </param>
        /// <param name="country"> The country associated with the Latency Scorecard. Values are country ISO codes as specified here- https://www.iso.org/iso-3166-country-codes.html. </param>
        /// <param name="latencyMetrics"> The latency metrics of the Latency Scorecard. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal LatencyScorecard(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string latencyScorecardId, string latencyScorecardName, string description, Uri scorecardEndpointA, Uri scorecardEndpointB, DateTimeOffset? startOn, DateTimeOffset? endOn, string country, IList<LatencyMetric> latencyMetrics, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            LatencyScorecardId = latencyScorecardId;
            LatencyScorecardName = latencyScorecardName;
            Description = description;
            ScorecardEndpointA = scorecardEndpointA;
            ScorecardEndpointB = scorecardEndpointB;
            StartOn = startOn;
            EndOn = endOn;
            Country = country;
            LatencyMetrics = latencyMetrics;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="LatencyScorecard"/> for deserialization. </summary>
        internal LatencyScorecard()
        {
        }

        /// <summary> The unique identifier of the Latency Scorecard. </summary>
        public string LatencyScorecardId { get; }
        /// <summary> The name of the Latency Scorecard. </summary>
        public string LatencyScorecardName { get; }
        /// <summary> The description of the Latency Scorecard. </summary>
        public string Description { get; }
        /// <summary> The A endpoint in the scorecard. </summary>
        public Uri ScorecardEndpointA { get; }
        /// <summary> The B endpoint in the scorecard. </summary>
        public Uri ScorecardEndpointB { get; }
        /// <summary> The start time of the Latency Scorecard in UTC. </summary>
        public DateTimeOffset? StartOn { get; }
        /// <summary> The end time of the Latency Scorecard in UTC. </summary>
        public DateTimeOffset? EndOn { get; }
        /// <summary> The country associated with the Latency Scorecard. Values are country ISO codes as specified here- https://www.iso.org/iso-3166-country-codes.html. </summary>
        public string Country { get; }
        /// <summary> The latency metrics of the Latency Scorecard. </summary>
        public IList<LatencyMetric> LatencyMetrics { get; }
    }
}
