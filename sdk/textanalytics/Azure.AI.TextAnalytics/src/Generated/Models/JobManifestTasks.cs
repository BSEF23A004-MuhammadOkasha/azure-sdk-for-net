// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.TextAnalytics
{
    /// <summary> The set of tasks to execute on the input documents. Cannot specify the same task more than once. </summary>
    internal partial class JobManifestTasks
    {
        /// <summary> Initializes a new instance of JobManifestTasks. </summary>
        public JobManifestTasks()
        {
            EntityRecognitionTasks = new ChangeTrackingList<EntitiesTask>();
            EntityRecognitionPiiTasks = new ChangeTrackingList<PiiTask>();
            KeyPhraseExtractionTasks = new ChangeTrackingList<KeyPhrasesTask>();
        }
    }
}
