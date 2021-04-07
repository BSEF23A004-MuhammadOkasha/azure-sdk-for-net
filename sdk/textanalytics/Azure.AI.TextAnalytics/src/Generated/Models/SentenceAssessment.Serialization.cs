// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    internal partial class SentenceAssessment
    {
        internal static SentenceAssessment DeserializeSentenceAssessment(JsonElement element)
        {
            string sentiment = default;
            TargetConfidenceScoreLabel confidenceScores = default;
            int offset = default;
            int length = default;
            string text = default;
            bool isNegated = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sentiment"))
                {
                    sentiment = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("confidenceScores"))
                {
                    confidenceScores = TargetConfidenceScoreLabel.DeserializeTargetConfidenceScoreLabel(property.Value);
                    continue;
                }
                if (property.NameEquals("offset"))
                {
                    offset = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("length"))
                {
                    length = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("text"))
                {
                    text = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isNegated"))
                {
                    isNegated = property.Value.GetBoolean();
                    continue;
                }
            }
            return new SentenceAssessment(sentiment, confidenceScores, offset, length, text, isNegated);
        }
    }
}
