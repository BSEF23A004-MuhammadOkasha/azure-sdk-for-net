// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Xml.Linq;
using Azure.Core;

namespace Azure.Storage.Queues.Models
{
    internal partial class PeekedMessageItem
    {
        internal static PeekedMessageItem DeserializePeekedMessageItem(XElement element)
        {
            string messageId = default;
            DateTimeOffset insertionTime = default;
            DateTimeOffset expirationTime = default;
            long dequeueCount = default;
            string messageText = default;
            if (element.Element("MessageId") is XElement messageIdElement)
            {
                messageId = (string)messageIdElement;
            }
            if (element.Element("InsertionTime") is XElement insertionTimeElement)
            {
                insertionTime = insertionTimeElement.GetDateTimeOffsetValue("R");
            }
            if (element.Element("ExpirationTime") is XElement expirationTimeElement)
            {
                expirationTime = expirationTimeElement.GetDateTimeOffsetValue("R");
            }
            if (element.Element("DequeueCount") is XElement dequeueCountElement)
            {
                dequeueCount = (long)dequeueCountElement;
            }
            if (element.Element("MessageText") is XElement messageTextElement)
            {
                messageText = (string)messageTextElement;
            }
            return new PeekedMessageItem(messageId, insertionTime, expirationTime, dequeueCount, messageText);
        }
    }
}
