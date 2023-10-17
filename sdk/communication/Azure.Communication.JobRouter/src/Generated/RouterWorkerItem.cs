// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Communication.JobRouter
{
    /// <summary> Paged instance of RouterWorker. </summary>
    public partial class RouterWorkerItem
    {
        /// <summary> Initializes a new instance of RouterWorkerItem. </summary>
        /// <param name="worker"> An entity for jobs to be routed to. </param>
        /// <param name="etag"> (Optional) The Concurrency Token. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="worker"/> or <paramref name="etag"/> is null. </exception>
        internal RouterWorkerItem(RouterWorker worker, string etag)
        {
            Argument.AssertNotNull(worker, nameof(worker));
            Argument.AssertNotNull(etag, nameof(etag));

            Worker = worker;
            _etag = etag;
        }

        /// <summary> An entity for jobs to be routed to. </summary>
        public RouterWorker Worker { get; }
    }
}
