// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.AI.OpenAI;

public partial class AzureChatExtensionsMessageContext
{
    // CUSTOM CODE NOTE:
    //   These changes facilitate the consolidation and re-exposure of Azure-specific extensions to chat messages
    //   like content filter results.

    public ContentFilterResultsForPrompt RequestContentFilterResults { get; internal set; }
    public ContentFilterResultsForChoice ResponseContentFilterResults { get; internal set; }
}
