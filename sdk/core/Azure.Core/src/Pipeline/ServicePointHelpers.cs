﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Net;
using System.Net.Http;
using System.Threading;

namespace Azure.Core.Pipeline
{
    internal static class ServicePointHelpers
    {
        private const int RuntimeDefaultConnectionLimit = 2;
        private const int IncreasedConnectionLimit = 50;

#if NETFRAMEWORK || NETSTANDARD
        private const int DefaultConnectionLeaseTimeout = Timeout.Infinite;
        private const int IncreasedConnectionLeaseTimeout = 300 * 1000;

        public static void SetLimits(ServicePoint requestServicePoint)
        {
            // Only change when the default runtime limit is used
            if (requestServicePoint.ConnectionLimit == RuntimeDefaultConnectionLimit)
            {
                requestServicePoint.ConnectionLimit = IncreasedConnectionLimit;
            }

            if (requestServicePoint.ConnectionLeaseTimeout == DefaultConnectionLeaseTimeout)
            {
                requestServicePoint.ConnectionLeaseTimeout = IncreasedConnectionLeaseTimeout;
            }
        }

        public static void SetLimits(HttpClientHandler httpClientHandler)
        {
            // Only change when the default runtime limit is used
            if (httpClientHandler.MaxConnectionsPerServer == RuntimeDefaultConnectionLimit)
            {
                httpClientHandler.MaxConnectionsPerServer = IncreasedConnectionLimit;
            }
        }
#else // NETCOREAPP +
        private static TimeSpan DefaultConnectionLeaseTimeoutTimeSpan = Timeout.InfiniteTimeSpan;
        private static TimeSpan IncreasedConnectionLeaseTimeoutTimeSpan = TimeSpan.FromSeconds(300);

        public static void SetLimits(SocketsHttpHandler socketsHttpHandler)
        {
            if (socketsHttpHandler.MaxConnectionsPerServer == RuntimeDefaultConnectionLimit)
            {
                socketsHttpHandler.MaxConnectionsPerServer = IncreasedConnectionLimit;
            }
            if (socketsHttpHandler.PooledConnectionLifetime == DefaultConnectionLeaseTimeoutTimeSpan)
            {
                socketsHttpHandler.PooledConnectionLifetime = IncreasedConnectionLeaseTimeoutTimeSpan;
            }
        }
#endif
    }
}