// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    public partial class DocumentModelCopyToOperationDetails
    {
        internal static DocumentModelCopyToOperationDetails DeserializeDocumentModelCopyToOperationDetails(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DocumentModelDetails result = default;
            string operationId = default;
            DocumentOperationStatus status = default;
            int? percentCompleted = default;
            DateTimeOffset createdDateTime = default;
            DateTimeOffset lastUpdatedDateTime = default;
            DocumentOperationKind kind = default;
            Uri resourceLocation = default;
            string apiVersion = default;
            IReadOnlyDictionary<string, string> tags = default;
            JsonElement error = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("result"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result = DocumentModelDetails.DeserializeDocumentModelDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("operationId"u8))
                {
                    operationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString().ToDocumentOperationStatus();
                    continue;
                }
                if (property.NameEquals("percentCompleted"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    percentCompleted = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("createdDateTime"u8))
                {
                    createdDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastUpdatedDateTime"u8))
                {
                    lastUpdatedDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = new DocumentOperationKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resourceLocation"u8))
                {
                    resourceLocation = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("apiVersion"u8))
                {
                    apiVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    error = property.Value.Clone();
                    continue;
                }
            }
            return new DocumentModelCopyToOperationDetails(
                operationId,
                status,
                percentCompleted,
                createdDateTime,
                lastUpdatedDateTime,
                kind,
                resourceLocation,
                apiVersion,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                error,
                result);
        }
    }
}
