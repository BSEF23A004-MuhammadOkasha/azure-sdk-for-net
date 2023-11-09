// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Tag count. </summary>
    public partial class PredefinedTagCount
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="PredefinedTagCount"/>. </summary>
        internal PredefinedTagCount()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PredefinedTagCount"/>. </summary>
        /// <param name="predefinedTagCountType"> Type of count. </param>
        /// <param name="value"> Value of count. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PredefinedTagCount(string predefinedTagCountType, int? value, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PredefinedTagCountType = predefinedTagCountType;
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Type of count. </summary>
        public string PredefinedTagCountType { get; }
        /// <summary> Value of count. </summary>
        public int? Value { get; }
    }
}
