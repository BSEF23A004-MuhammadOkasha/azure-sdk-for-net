// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The properties for updating triggers. </summary>
    public partial class ContainerRegistryTriggerUpdateContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryTriggerUpdateContent"/>. </summary>
        public ContainerRegistryTriggerUpdateContent()
        {
            TimerTriggers = new ChangeTrackingList<ContainerRegistryTimerTriggerUpdateContent>();
            SourceTriggers = new ChangeTrackingList<ContainerRegistrySourceTriggerUpdateContent>();
        }

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryTriggerUpdateContent"/>. </summary>
        /// <param name="timerTriggers"> The collection of timer triggers. </param>
        /// <param name="sourceTriggers"> The collection of triggers based on source code repository. </param>
        /// <param name="baseImageTrigger"> The trigger based on base image dependencies. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerRegistryTriggerUpdateContent(IList<ContainerRegistryTimerTriggerUpdateContent> timerTriggers, IList<ContainerRegistrySourceTriggerUpdateContent> sourceTriggers, ContainerRegistryBaseImageTriggerUpdateContent baseImageTrigger, Dictionary<string, BinaryData> rawData)
        {
            TimerTriggers = timerTriggers;
            SourceTriggers = sourceTriggers;
            BaseImageTrigger = baseImageTrigger;
            _rawData = rawData;
        }

        /// <summary> The collection of timer triggers. </summary>
        public IList<ContainerRegistryTimerTriggerUpdateContent> TimerTriggers { get; }
        /// <summary> The collection of triggers based on source code repository. </summary>
        public IList<ContainerRegistrySourceTriggerUpdateContent> SourceTriggers { get; }
        /// <summary> The trigger based on base image dependencies. </summary>
        public ContainerRegistryBaseImageTriggerUpdateContent BaseImageTrigger { get; set; }
    }
}
