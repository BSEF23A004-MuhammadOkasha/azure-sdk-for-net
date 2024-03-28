// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Language.AnalyzeText
{
    public partial class AnalyzeTextEntityRecognitionInput : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(AnalysisInput))
            {
                writer.WritePropertyName("analysisInput"u8);
                writer.WriteObjectValue(AnalysisInput);
            }
            if (Optional.IsDefined(Parameters))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteObjectValue(Parameters);
            }
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            writer.WriteEndObject();
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
