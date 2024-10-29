// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.CosmosDB;

/// <summary>
/// Resource for a regional service location.
/// </summary>
public partial class GraphApiComputeRegionalService : ProvisionableConstruct
{
    /// <summary>
    /// The regional endpoint for GraphAPICompute.
    /// </summary>
    public BicepValue<string> GraphApiComputeEndpoint 
    {
        get { Initialize(); return _graphApiComputeEndpoint!; }
    }
    private BicepValue<string>? _graphApiComputeEndpoint;

    /// <summary>
    /// The regional service name.
    /// </summary>
    public BicepValue<string> Name 
    {
        get { Initialize(); return _name!; }
    }
    private BicepValue<string>? _name;

    /// <summary>
    /// The location name.
    /// </summary>
    public BicepValue<AzureLocation> Location 
    {
        get { Initialize(); return _location!; }
    }
    private BicepValue<AzureLocation>? _location;

    /// <summary>
    /// Describes the status of a service.
    /// </summary>
    public BicepValue<CosmosDBServiceStatus> Status 
    {
        get { Initialize(); return _status!; }
    }
    private BicepValue<CosmosDBServiceStatus>? _status;

    /// <summary>
    /// Creates a new GraphApiComputeRegionalService.
    /// </summary>
    public GraphApiComputeRegionalService()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// GraphApiComputeRegionalService.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _graphApiComputeEndpoint = DefineProperty<string>("GraphApiComputeEndpoint", ["graphApiComputeEndpoint"], isOutput: true);
        _name = DefineProperty<string>("Name", ["name"], isOutput: true);
        _location = DefineProperty<AzureLocation>("Location", ["location"], isOutput: true);
        _status = DefineProperty<CosmosDBServiceStatus>("Status", ["status"], isOutput: true);
    }
}
