// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.AppService;

/// <summary>
/// Application logs azure blob storage configuration.
/// </summary>
public partial class AppServiceBlobStorageApplicationLogsConfig : ProvisionableConstruct
{
    /// <summary>
    /// Log level.
    /// </summary>
    public BicepValue<WebAppLogLevel> Level 
    {
        get { Initialize(); return _level!; }
        set { Initialize(); _level!.Assign(value); }
    }
    private BicepValue<WebAppLogLevel>? _level;

    /// <summary>
    /// SAS url to a azure blob container with read/write/list/delete
    /// permissions.
    /// </summary>
    public BicepValue<Uri> SasUri 
    {
        get { Initialize(); return _sasUri!; }
        set { Initialize(); _sasUri!.Assign(value); }
    }
    private BicepValue<Uri>? _sasUri;

    /// <summary>
    /// Retention in days.             Remove blobs older than X days.
    /// 0 or lower means no retention.
    /// </summary>
    public BicepValue<int> RetentionInDays 
    {
        get { Initialize(); return _retentionInDays!; }
        set { Initialize(); _retentionInDays!.Assign(value); }
    }
    private BicepValue<int>? _retentionInDays;

    /// <summary>
    /// Creates a new AppServiceBlobStorageApplicationLogsConfig.
    /// </summary>
    public AppServiceBlobStorageApplicationLogsConfig()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// AppServiceBlobStorageApplicationLogsConfig.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _level = DefineProperty<WebAppLogLevel>("Level", ["level"]);
        _sasUri = DefineProperty<Uri>("SasUri", ["sasUrl"]);
        _retentionInDays = DefineProperty<int>("RetentionInDays", ["retentionInDays"]);
    }
}
