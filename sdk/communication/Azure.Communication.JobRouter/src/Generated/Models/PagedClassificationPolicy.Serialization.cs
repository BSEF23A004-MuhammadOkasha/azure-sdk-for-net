// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.JobRouter
{
    public partial class PagedClassificationPolicy
    {
        internal static PagedClassificationPolicy DeserializePagedClassificationPolicy(JsonElement element)
        {
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> fallbackQueueId = default;
            Optional<IReadOnlyList<QueueSelectorAttachment>> queueSelectors = default;
            Optional<RouterRule> prioritizationRule = default;
            Optional<IReadOnlyList<WorkerSelectorAttachment>> workerSelectors = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fallbackQueueId"))
                {
                    fallbackQueueId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("queueSelectors"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<QueueSelectorAttachment> array = new List<QueueSelectorAttachment>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(QueueSelectorAttachment.DeserializeQueueSelectorAttachment(item));
                    }
                    queueSelectors = array;
                    continue;
                }
                if (property.NameEquals("prioritizationRule"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    prioritizationRule = RouterRule.DeserializeRouterRule(property.Value);
                    continue;
                }
                if (property.NameEquals("workerSelectors"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<WorkerSelectorAttachment> array = new List<WorkerSelectorAttachment>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(WorkerSelectorAttachment.DeserializeWorkerSelectorAttachment(item));
                    }
                    workerSelectors = array;
                    continue;
                }
            }
            return new PagedClassificationPolicy(id.Value, name.Value, fallbackQueueId.Value, Optional.ToList(queueSelectors), prioritizationRule.Value, Optional.ToList(workerSelectors));
        }
    }
}
