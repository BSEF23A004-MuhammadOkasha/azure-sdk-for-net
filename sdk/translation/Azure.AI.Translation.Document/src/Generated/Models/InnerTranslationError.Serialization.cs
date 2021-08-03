// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Translation.Document.Models
{
    public partial class InnerTranslationError
    {
        internal static InnerTranslationError DeserializeInnerTranslationError(JsonElement element)
        {
            string code = default;
            string message = default;
            Optional<string> target = default;
            Optional<InnerTranslationError> innerError = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"))
                {
                    code = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("message"))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("target"))
                {
                    target = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("innerError"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    innerError = DeserializeInnerTranslationError(property.Value);
                    continue;
                }
            }
            return new InnerTranslationError(code, message, target.Value, innerError.Value);
        }
    }
}
