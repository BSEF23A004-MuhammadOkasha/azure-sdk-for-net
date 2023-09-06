// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.CostManagement.Models
{
    /// <summary> The properties of the scheduled action notification. </summary>
    public partial class NotificationProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="NotificationProperties"/>. </summary>
        /// <param name="to"> Array of email addresses. </param>
        /// <param name="subject"> Subject of the email. Length is limited to 70 characters. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="to"/> or <paramref name="subject"/> is null. </exception>
        public NotificationProperties(IEnumerable<string> to, string subject)
        {
            Argument.AssertNotNull(to, nameof(to));
            Argument.AssertNotNull(subject, nameof(subject));

            To = to.ToList();
            Subject = subject;
        }

        /// <summary> Initializes a new instance of <see cref="NotificationProperties"/>. </summary>
        /// <param name="to"> Array of email addresses. </param>
        /// <param name="language"> Locale of the email. </param>
        /// <param name="message"> Optional message to be added in the email. Length is limited to 250 characters. </param>
        /// <param name="regionalFormat"> Regional format used for formatting date/time and currency values in the email. </param>
        /// <param name="subject"> Subject of the email. Length is limited to 70 characters. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal NotificationProperties(IList<string> to, string language, string message, string regionalFormat, string subject, Dictionary<string, BinaryData> rawData)
        {
            To = to;
            Language = language;
            Message = message;
            RegionalFormat = regionalFormat;
            Subject = subject;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="NotificationProperties"/> for deserialization. </summary>
        internal NotificationProperties()
        {
        }

        /// <summary> Array of email addresses. </summary>
        public IList<string> To { get; }
        /// <summary> Locale of the email. </summary>
        public string Language { get; set; }
        /// <summary> Optional message to be added in the email. Length is limited to 250 characters. </summary>
        public string Message { get; set; }
        /// <summary> Regional format used for formatting date/time and currency values in the email. </summary>
        public string RegionalFormat { get; set; }
        /// <summary> Subject of the email. Length is limited to 70 characters. </summary>
        public string Subject { get; set; }
    }
}
