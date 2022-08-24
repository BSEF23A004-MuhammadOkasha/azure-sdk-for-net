// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Template.Models
{
    public partial class BaseClass : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("baseClassProperty");
            writer.WriteStringValue(BaseClassProperty);
            writer.WriteEndObject();
        }

        //internal static BaseClass DeserializeBaseClass(JsonElement element)
        //{
        //    string baseClassProperty = default;
        //    foreach (var property in element.EnumerateObject())
        //    {
        //        if (property.NameEquals("baseClassProperty"))
        //        {
        //            baseClassProperty = property.Value.GetString();
        //            continue;
        //        }
        //    }

        //    // TODO: Cannot instantiate derived type because we don't have a discriminator
        //    return new BaseClass(baseClassProperty);
        //}
    }
}
