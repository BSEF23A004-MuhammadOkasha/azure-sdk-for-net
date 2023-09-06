// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Communication.Sms.Models
{
    /// <summary> Recipient details for sending SMS messages. </summary>
    internal partial class SmsRecipient
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SmsRecipient"/>. </summary>
        /// <param name="to"> The recipient's phone number in E.164 format. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="to"/> is null. </exception>
        public SmsRecipient(string to)
        {
            Argument.AssertNotNull(to, nameof(to));

            To = to;
        }

        /// <summary> Initializes a new instance of <see cref="SmsRecipient"/>. </summary>
        /// <param name="to"> The recipient's phone number in E.164 format. </param>
        /// <param name="repeatabilityRequestId"> If specified, the client directs that the request is repeatable; that is, the client can make the request multiple times with the same Repeatability-Request-ID and get back an appropriate response without the server executing the request multiple times. The value of the Repeatability-Request-ID is an opaque string representing a client-generated, 36-character hexadecimal case-insensitive encoding of a UUID (GUID), identifier for the request. </param>
        /// <param name="repeatabilityFirstSent"> MUST be sent by clients to specify that a request is repeatable. Repeatability-First-Sent is used to specify the date and time at which the request was first created.eg- Tue, 26 Mar 2019 16:06:51 GMT. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SmsRecipient(string to, string repeatabilityRequestId, string repeatabilityFirstSent, Dictionary<string, BinaryData> rawData)
        {
            To = to;
            RepeatabilityRequestId = repeatabilityRequestId;
            RepeatabilityFirstSent = repeatabilityFirstSent;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="SmsRecipient"/> for deserialization. </summary>
        internal SmsRecipient()
        {
        }

        /// <summary> The recipient's phone number in E.164 format. </summary>
        public string To { get; }
        /// <summary> If specified, the client directs that the request is repeatable; that is, the client can make the request multiple times with the same Repeatability-Request-ID and get back an appropriate response without the server executing the request multiple times. The value of the Repeatability-Request-ID is an opaque string representing a client-generated, 36-character hexadecimal case-insensitive encoding of a UUID (GUID), identifier for the request. </summary>
        public string RepeatabilityRequestId { get; set; }
        /// <summary> MUST be sent by clients to specify that a request is repeatable. Repeatability-First-Sent is used to specify the date and time at which the request was first created.eg- Tue, 26 Mar 2019 16:06:51 GMT. </summary>
        public string RepeatabilityFirstSent { get; set; }
    }
}
