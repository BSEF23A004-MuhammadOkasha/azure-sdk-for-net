// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.Messages
{
    /// <summary> The message template's quick action value information. </summary>
    internal partial class MessageTemplateValueQuickAction
    {
        /// <summary> Initializes a new instance of <see cref="MessageTemplateValueQuickAction"/>. </summary>
        public MessageTemplateValueQuickAction()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MessageTemplateValueQuickAction"/>. </summary>
        /// <param name="text"> The [Optional] quick action text. </param>
        /// <param name="payload"> The [Optional] quick action payload. </param>
        internal MessageTemplateValueQuickAction(string text, string payload)
        {
            Text = text;
            Payload = payload;
        }

        /// <summary> The [Optional] quick action text. </summary>
        public string Text { get; set; }
        /// <summary> The [Optional] quick action payload. </summary>
        public string Payload { get; set; }
    }
}
