// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.BotService.Models
{
    internal static partial class RegenerateKeysChannelNameExtensions
    {
        public static string ToSerialString(this RegenerateKeysChannelName value) => value switch
        {
            RegenerateKeysChannelName.WebChatChannel => "WebChatChannel",
            RegenerateKeysChannelName.DirectLineChannel => "DirectLineChannel",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown RegenerateKeysChannelName value.")
        };

        public static RegenerateKeysChannelName ToRegenerateKeysChannelName(this string value)
        {
            if (string.Equals(value, "WebChatChannel", StringComparison.InvariantCultureIgnoreCase)) return RegenerateKeysChannelName.WebChatChannel;
            if (string.Equals(value, "DirectLineChannel", StringComparison.InvariantCultureIgnoreCase)) return RegenerateKeysChannelName.DirectLineChannel;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown RegenerateKeysChannelName value.");
        }
    }
}
