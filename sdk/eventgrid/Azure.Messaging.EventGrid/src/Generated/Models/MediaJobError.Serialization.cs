// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.Messaging.EventGrid.SystemEvents;

namespace Azure.Messaging.EventGrid.Models.SystemEvents
{
    public partial class MediaJobError
    {
        internal static MediaJobError DeserializeMediaJobError(JsonElement element)
        {
            Optional<MediaJobErrorCode> code = default;
            Optional<string> message = default;
            Optional<MediaJobErrorCategory> category = default;
            Optional<MediaJobRetry> retry = default;
            Optional<IReadOnlyList<MediaJobErrorDetail>> details = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"))
                {
                    code = property.Value.GetString().ToMediaJobErrorCode();
                    continue;
                }
                if (property.NameEquals("message"))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("category"))
                {
                    category = property.Value.GetString().ToMediaJobErrorCategory();
                    continue;
                }
                if (property.NameEquals("retry"))
                {
                    retry = property.Value.GetString().ToMediaJobRetry();
                    continue;
                }
                if (property.NameEquals("details"))
                {
                    List<MediaJobErrorDetail> array = new List<MediaJobErrorDetail>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MediaJobErrorDetail.DeserializeMediaJobErrorDetail(item));
                    }
                    details = array;
                    continue;
                }
            }
            return new MediaJobError(Optional.ToNullable(code), message.Value, Optional.ToNullable(category), Optional.ToNullable(retry), Optional.ToList(details));
        }
    }
}
