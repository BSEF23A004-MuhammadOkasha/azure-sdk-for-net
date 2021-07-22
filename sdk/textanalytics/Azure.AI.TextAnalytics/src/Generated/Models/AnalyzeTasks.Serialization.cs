// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    internal partial class AnalyzeTasks
    {
        internal static AnalyzeTasks DeserializeAnalyzeTasks(JsonElement element)
        {
            int completed = default;
            int failed = default;
            int inProgress = default;
            int total = default;
            Optional<IReadOnlyList<EntityRecognitionTasksItem>> entityRecognitionTasks = default;
            Optional<IReadOnlyList<EntityRecognitionPiiTasksItem>> entityRecognitionPiiTasks = default;
            Optional<IReadOnlyList<KeyPhraseExtractionTasksItem>> keyPhraseExtractionTasks = default;
            Optional<IReadOnlyList<EntityLinkingTasksItem>> entityLinkingTasks = default;
            Optional<IReadOnlyList<SentimentAnalysisTasksItem>> sentimentAnalysisTasks = default;
            Optional<IReadOnlyList<TasksStateTasksExtractiveSummarizationTasksItem>> extractiveSummarizationTasks = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("completed"))
                {
                    completed = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("failed"))
                {
                    failed = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("inProgress"))
                {
                    inProgress = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("total"))
                {
                    total = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("entityRecognitionTasks"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<EntityRecognitionTasksItem> array = new List<EntityRecognitionTasksItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EntityRecognitionTasksItem.DeserializeEntityRecognitionTasksItem(item));
                    }
                    entityRecognitionTasks = array;
                    continue;
                }
                if (property.NameEquals("entityRecognitionPiiTasks"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<EntityRecognitionPiiTasksItem> array = new List<EntityRecognitionPiiTasksItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EntityRecognitionPiiTasksItem.DeserializeEntityRecognitionPiiTasksItem(item));
                    }
                    entityRecognitionPiiTasks = array;
                    continue;
                }
                if (property.NameEquals("keyPhraseExtractionTasks"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<KeyPhraseExtractionTasksItem> array = new List<KeyPhraseExtractionTasksItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(KeyPhraseExtractionTasksItem.DeserializeKeyPhraseExtractionTasksItem(item));
                    }
                    keyPhraseExtractionTasks = array;
                    continue;
                }
                if (property.NameEquals("entityLinkingTasks"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<EntityLinkingTasksItem> array = new List<EntityLinkingTasksItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EntityLinkingTasksItem.DeserializeEntityLinkingTasksItem(item));
                    }
                    entityLinkingTasks = array;
                    continue;
                }
                if (property.NameEquals("sentimentAnalysisTasks"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<SentimentAnalysisTasksItem> array = new List<SentimentAnalysisTasksItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SentimentAnalysisTasksItem.DeserializeSentimentAnalysisTasksItem(item));
                    }
                    sentimentAnalysisTasks = array;
                    continue;
                }
                if (property.NameEquals("extractiveSummarizationTasks"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<TasksStateTasksExtractiveSummarizationTasksItem> array = new List<TasksStateTasksExtractiveSummarizationTasksItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TasksStateTasksExtractiveSummarizationTasksItem.DeserializeTasksStateTasksExtractiveSummarizationTasksItem(item));
                    }
                    extractiveSummarizationTasks = array;
                    continue;
                }
            }
            return new AnalyzeTasks(completed, failed, inProgress, total, Optional.ToList(entityRecognitionTasks), Optional.ToList(entityRecognitionPiiTasks), Optional.ToList(keyPhraseExtractionTasks), Optional.ToList(entityLinkingTasks), Optional.ToList(sentimentAnalysisTasks), Optional.ToList(extractiveSummarizationTasks));
        }
    }
}
