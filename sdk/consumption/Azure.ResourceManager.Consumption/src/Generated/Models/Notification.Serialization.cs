// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Consumption.Models
{
    public partial class Notification : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("enabled");
            writer.WriteBooleanValue(Enabled);
            writer.WritePropertyName("operator");
            writer.WriteStringValue(Operator.ToString());
            writer.WritePropertyName("threshold");
            writer.WriteNumberValue(Threshold);
            writer.WritePropertyName("contactEmails");
            writer.WriteStartArray();
            foreach (var item in ContactEmails)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsCollectionDefined(ContactRoles))
            {
                writer.WritePropertyName("contactRoles");
                writer.WriteStartArray();
                foreach (var item in ContactRoles)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ContactGroups))
            {
                writer.WritePropertyName("contactGroups");
                writer.WriteStartArray();
                foreach (var item in ContactGroups)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ThresholdType))
            {
                writer.WritePropertyName("thresholdType");
                writer.WriteStringValue(ThresholdType.Value.ToString());
            }
            if (Optional.IsDefined(Locale))
            {
                writer.WritePropertyName("locale");
                writer.WriteStringValue(Locale.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static Notification DeserializeNotification(JsonElement element)
        {
            bool enabled = default;
            OperatorType @operator = default;
            decimal threshold = default;
            IList<string> contactEmails = default;
            Optional<IList<string>> contactRoles = default;
            Optional<IList<string>> contactGroups = default;
            Optional<ThresholdType> thresholdType = default;
            Optional<CultureCode> locale = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"))
                {
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("operator"))
                {
                    @operator = new OperatorType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("threshold"))
                {
                    threshold = property.Value.GetDecimal();
                    continue;
                }
                if (property.NameEquals("contactEmails"))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    contactEmails = array;
                    continue;
                }
                if (property.NameEquals("contactRoles"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    contactRoles = array;
                    continue;
                }
                if (property.NameEquals("contactGroups"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    contactGroups = array;
                    continue;
                }
                if (property.NameEquals("thresholdType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    thresholdType = new ThresholdType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("locale"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    locale = new CultureCode(property.Value.GetString());
                    continue;
                }
            }
            return new Notification(enabled, @operator, threshold, contactEmails, Optional.ToList(contactRoles), Optional.ToList(contactGroups), Optional.ToNullable(thresholdType), Optional.ToNullable(locale));
        }
    }
}
