// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of common properties of all SMS events. </summary>
    public partial class AcsSmsEventBaseProperties
    {
        protected internal Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AcsSmsEventBaseProperties"/>. </summary>
        internal AcsSmsEventBaseProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AcsSmsEventBaseProperties"/>. </summary>
        /// <param name="messageId"> The identity of the SMS message. </param>
        /// <param name="from"> The identity of SMS message sender. </param>
        /// <param name="to"> The identity of SMS message receiver. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AcsSmsEventBaseProperties(string messageId, string @from, string to, Dictionary<string, BinaryData> rawData)
        {
            MessageId = messageId;
            From = @from;
            To = to;
            _rawData = rawData;
        }

        /// <summary> The identity of the SMS message. </summary>
        public string MessageId { get; }
        /// <summary> The identity of SMS message sender. </summary>
        public string From { get; }
        /// <summary> The identity of SMS message receiver. </summary>
        public string To { get; }
    }
}
