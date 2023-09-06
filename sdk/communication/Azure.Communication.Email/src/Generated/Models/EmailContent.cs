// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Communication.Email
{
    /// <summary> Content of the email. </summary>
    public partial class EmailContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="EmailContent"/>. </summary>
        /// <param name="subject"> Subject of the email message. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subject"/> is null. </exception>
        public EmailContent(string subject)
        {
            Argument.AssertNotNull(subject, nameof(subject));

            Subject = subject;
        }

        /// <summary> Initializes a new instance of <see cref="EmailContent"/>. </summary>
        /// <param name="subject"> Subject of the email message. </param>
        /// <param name="plainText"> Plain text version of the email message. </param>
        /// <param name="html"> Html version of the email message. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal EmailContent(string subject, string plainText, string html, Dictionary<string, BinaryData> rawData)
        {
            Subject = subject;
            PlainText = plainText;
            Html = html;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="EmailContent"/> for deserialization. </summary>
        internal EmailContent()
        {
        }

        /// <summary> Subject of the email message. </summary>
        public string Subject { get; }
        /// <summary> Plain text version of the email message. </summary>
        public string PlainText { get; set; }
        /// <summary> Html version of the email message. </summary>
        public string Html { get; set; }
    }
}
