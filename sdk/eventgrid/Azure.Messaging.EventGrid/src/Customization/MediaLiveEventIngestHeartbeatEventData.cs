﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Globalization;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    public partial class MediaLiveEventIngestHeartbeatEventData
    {
        internal string IngestDriftValueInternal { get; }

        /// <summary>
        /// Gets the channel latency.
        /// </summary>
        public int? IngestDriftValue
            => _ingestDriftValue ??= IngestDriftValueInternal == "n/a"
                ? null
                : int.Parse(IngestDriftValueInternal, CultureInfo.InvariantCulture);

        private int? _ingestDriftValue;
    }
}