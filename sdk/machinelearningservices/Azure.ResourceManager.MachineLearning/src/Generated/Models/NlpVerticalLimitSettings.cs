// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Job execution constraints. </summary>
    public partial class NlpVerticalLimitSettings
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

        /// <summary> Initializes a new instance of <see cref="NlpVerticalLimitSettings"/>. </summary>
        public NlpVerticalLimitSettings()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NlpVerticalLimitSettings"/>. </summary>
<<<<<<< HEAD
        /// <param name="timeout"> AutoML job timeout. </param>
        /// <param name="maxTrials"> Number of AutoML iterations. </param>
        /// <param name="maxConcurrentTrials"> Maximum Concurrent AutoML iterations. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NlpVerticalLimitSettings(TimeSpan? timeout, int? maxTrials, int? maxConcurrentTrials, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Timeout = timeout;
            MaxTrials = maxTrials;
            MaxConcurrentTrials = maxConcurrentTrials;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> AutoML job timeout. </summary>
        public TimeSpan? Timeout { get; set; }
        /// <summary> Number of AutoML iterations. </summary>
        public int? MaxTrials { get; set; }
        /// <summary> Maximum Concurrent AutoML iterations. </summary>
        public int? MaxConcurrentTrials { get; set; }
=======
        /// <param name="maxConcurrentTrials"> Maximum Concurrent AutoML iterations. </param>
        /// <param name="maxTrials"> Number of AutoML iterations. </param>
        /// <param name="timeout"> AutoML job timeout. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NlpVerticalLimitSettings(int? maxConcurrentTrials, int? maxTrials, TimeSpan? timeout, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            MaxConcurrentTrials = maxConcurrentTrials;
            MaxTrials = maxTrials;
            Timeout = timeout;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Maximum Concurrent AutoML iterations. </summary>
        public int? MaxConcurrentTrials { get; set; }
        /// <summary> Number of AutoML iterations. </summary>
        public int? MaxTrials { get; set; }
        /// <summary> AutoML job timeout. </summary>
        public TimeSpan? Timeout { get; set; }
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
    }
}
