// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.EventHub.Models
{
    internal static partial class EncodingCaptureDescriptionExtensions
    {
        public static string ToSerialString(this EncodingCaptureDescription value) => value switch
        {
            EncodingCaptureDescription.Avro => "Avro",
            EncodingCaptureDescription.AvroDeflate => "AvroDeflate",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown EncodingCaptureDescription value.")
        };

        public static EncodingCaptureDescription ToEncodingCaptureDescription(this string value)
        {
            if (string.Equals(value, "Avro", StringComparison.InvariantCultureIgnoreCase)) return EncodingCaptureDescription.Avro;
            if (string.Equals(value, "AvroDeflate", StringComparison.InvariantCultureIgnoreCase)) return EncodingCaptureDescription.AvroDeflate;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown EncodingCaptureDescription value.");
        }
    }
}
