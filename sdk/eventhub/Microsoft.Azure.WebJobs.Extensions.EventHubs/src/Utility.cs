﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using Azure;
using Azure.Messaging.EventHubs;
using Microsoft.Extensions.Logging;
using LogLevel = Microsoft.Extensions.Logging.LogLevel;

namespace Microsoft.Azure.WebJobs.EventHubs
{
    internal class Utility
    {
        public static void LogException(Exception ex, string message, ILogger logger)
        {
            try
            {
                // Sometimes EventHub SDK aggregates an exception
                AggregateException ae = ex as AggregateException;
                if (ae != null && ae.InnerExceptions != null && ae.InnerExceptions.Count == 1)
                {
                    ex = ae.InnerExceptions[0];
                }

                LogLevel logLevel = GetLevel(ex);
                if (logLevel == LogLevel.Information)
                {
                    message = $"{message} An exception of type '{ex.GetType().Name}' was thrown. This exception type is typically a result of Event Hub processor rebalancing or a transient error and can be safely ignored.";
                }
                logger?.Log(logLevel, 0, message, ex, (s, exc) => message);
            }
            catch
            {
                // best effort logging
            }
        }

        private static LogLevel GetLevel(Exception ex)
        {
            if (ex == null)
            {
                throw new ArgumentNullException(nameof(ex));
            }


            if (IsConflictLeaseIdMismatchWithLeaseOperation(ex))
            {
                // For EventProcessorHost these exceptions can happen as part
                // of normal partition balancing across instances, so we want to
                // trace them, but not treat them as errors.
                return LogLevel.Information;
            }

            var ehex = ex as EventHubsException;
            if (!(ex is OperationCanceledException) && (ehex == null || !ehex.IsTransient))
            {
                // any non-transient exceptions or unknown exception types
                // we want to log as errors
                return LogLevel.Error;
            }
            else
            {
                // transient messaging errors we log as info so we have a record
                // of them, but we don't treat them as actual errors
                return LogLevel.Information;
            }
        }

        public static bool IsConflictLeaseIdMismatchWithLeaseOperation(Exception ex)
        {
            RequestFailedException exception = ex as RequestFailedException;
            if (exception == null)
            {
                return false;
            }
            if (exception.Status != 409)
            {
                return false;
            }

            return exception.ErrorCode == "LeaseIdMismatchWithLeaseOperation";
        }
    }
}
