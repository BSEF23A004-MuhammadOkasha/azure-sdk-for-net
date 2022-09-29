// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    public partial class BlobReferenceInputDataSource : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type");
            writer.WriteStringValue(ReferenceInputDataSourceType);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(StorageAccounts))
            {
                writer.WritePropertyName("storageAccounts");
                writer.WriteStartArray();
                foreach (var item in StorageAccounts)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Container))
            {
                writer.WritePropertyName("container");
                writer.WriteStringValue(Container);
            }
            if (Optional.IsDefined(PathPattern))
            {
                writer.WritePropertyName("pathPattern");
                writer.WriteStringValue(PathPattern);
            }
            if (Optional.IsDefined(DateFormat))
            {
                writer.WritePropertyName("dateFormat");
                writer.WriteStringValue(DateFormat);
            }
            if (Optional.IsDefined(TimeFormat))
            {
                writer.WritePropertyName("timeFormat");
                writer.WriteStringValue(TimeFormat);
            }
            if (Optional.IsDefined(AuthenticationMode))
            {
                writer.WritePropertyName("authenticationMode");
                writer.WriteStringValue(AuthenticationMode.Value.ToString());
            }
            if (Optional.IsDefined(BlobName))
            {
                writer.WritePropertyName("blobName");
                writer.WriteStringValue(BlobName);
            }
            if (Optional.IsDefined(DeltaPathPattern))
            {
                writer.WritePropertyName("deltaPathPattern");
                writer.WriteStringValue(DeltaPathPattern);
            }
            if (Optional.IsDefined(SourcePartitionCount))
            {
                writer.WritePropertyName("sourcePartitionCount");
                writer.WriteNumberValue(SourcePartitionCount.Value);
            }
            if (Optional.IsDefined(FullSnapshotRefreshInterval))
            {
                writer.WritePropertyName("fullSnapshotRefreshRate");
                writer.WriteStringValue(FullSnapshotRefreshInterval.Value, "T");
            }
            if (Optional.IsDefined(DeltaSnapshotRefreshInterval))
            {
                writer.WritePropertyName("deltaSnapshotRefreshRate");
                writer.WriteStringValue(DeltaSnapshotRefreshInterval.Value, "T");
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static BlobReferenceInputDataSource DeserializeBlobReferenceInputDataSource(JsonElement element)
        {
            string type = default;
            Optional<IList<StreamAnalyticsStorageAccount>> storageAccounts = default;
            Optional<string> container = default;
            Optional<string> pathPattern = default;
            Optional<string> dateFormat = default;
            Optional<string> timeFormat = default;
            Optional<StreamAnalyticsAuthenticationMode> authenticationMode = default;
            Optional<string> blobName = default;
            Optional<string> deltaPathPattern = default;
            Optional<int> sourcePartitionCount = default;
            Optional<TimeSpan> fullSnapshotRefreshRate = default;
            Optional<TimeSpan> deltaSnapshotRefreshRate = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("storageAccounts"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<StreamAnalyticsStorageAccount> array = new List<StreamAnalyticsStorageAccount>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(StreamAnalyticsStorageAccount.DeserializeStreamAnalyticsStorageAccount(item));
                            }
                            storageAccounts = array;
                            continue;
                        }
                        if (property0.NameEquals("container"))
                        {
                            container = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("pathPattern"))
                        {
                            pathPattern = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("dateFormat"))
                        {
                            dateFormat = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("timeFormat"))
                        {
                            timeFormat = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("authenticationMode"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            authenticationMode = new StreamAnalyticsAuthenticationMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("blobName"))
                        {
                            blobName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("deltaPathPattern"))
                        {
                            deltaPathPattern = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sourcePartitionCount"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            sourcePartitionCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("fullSnapshotRefreshRate"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            fullSnapshotRefreshRate = property0.Value.GetTimeSpan("T");
                            continue;
                        }
                        if (property0.NameEquals("deltaSnapshotRefreshRate"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            deltaSnapshotRefreshRate = property0.Value.GetTimeSpan("T");
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new BlobReferenceInputDataSource(type, Optional.ToList(storageAccounts), container.Value, pathPattern.Value, dateFormat.Value, timeFormat.Value, Optional.ToNullable(authenticationMode), blobName.Value, deltaPathPattern.Value, Optional.ToNullable(sourcePartitionCount), Optional.ToNullable(fullSnapshotRefreshRate), Optional.ToNullable(deltaSnapshotRefreshRate));
        }
    }
}
