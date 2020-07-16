// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    public partial class OperationAutoGenerated2
    {
        internal static OperationAutoGenerated2 DeserializeOperationAutoGenerated2(JsonElement element)
        {
            Optional<string> name = default;
            Optional<OperationDisplayAutoGenerated2> display = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("display"))
                {
                    display = OperationDisplayAutoGenerated2.DeserializeOperationDisplayAutoGenerated2(property.Value);
                    continue;
                }
            }
            return new OperationAutoGenerated2(name.Value, display.Value);
        }
    }
}
