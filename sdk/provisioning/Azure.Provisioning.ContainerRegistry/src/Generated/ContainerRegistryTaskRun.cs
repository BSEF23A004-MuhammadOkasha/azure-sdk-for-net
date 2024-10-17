// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.ContainerRegistry;

/// <summary>
/// ContainerRegistryTaskRun.
/// </summary>
public partial class ContainerRegistryTaskRun : Resource
{
    /// <summary>
    /// The name of the task run.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// How the run should be forced to rerun even if the run request
    /// configuration has not changed.
    /// </summary>
    public BicepValue<string> ForceUpdateTag { get => _forceUpdateTag; set => _forceUpdateTag.Assign(value); }
    private readonly BicepValue<string> _forceUpdateTag;

    /// <summary>
    /// Identity for the resource.
    /// </summary>
    public BicepValue<ManagedServiceIdentity> Identity { get => _identity; set => _identity.Assign(value); }
    private readonly BicepValue<ManagedServiceIdentity> _identity;

    /// <summary>
    /// The location of the resource.
    /// </summary>
    public BicepValue<AzureLocation> Location { get => _location; set => _location.Assign(value); }
    private readonly BicepValue<AzureLocation> _location;

    /// <summary>
    /// The request (parameters) for the run             Please note
    /// Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryRunContent
    /// is the base class. According to the scenario, a derived class of the
    /// base class might need to be assigned here, or this property needs to
    /// be casted to one of the possible derived classes.             The
    /// available derived classes include
    /// Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryDockerBuildContent,
    /// Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryEncodedTaskRunContent,
    /// Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryFileTaskRunContent
    /// and
    /// Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryTaskRunContent.
    /// </summary>
    public BicepValue<ContainerRegistryRunContent> RunRequest { get => _runRequest; set => _runRequest.Assign(value); }
    private readonly BicepValue<ContainerRegistryRunContent> _runRequest;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// The provisioning state of this task run.
    /// </summary>
    public BicepValue<ContainerRegistryProvisioningState> ProvisioningState { get => _provisioningState; }
    private readonly BicepValue<ContainerRegistryProvisioningState> _provisioningState;

    /// <summary>
    /// The result of this task run.
    /// </summary>
    public BicepValue<ContainerRegistryRunData> RunResult { get => _runResult; }
    private readonly BicepValue<ContainerRegistryRunData> _runResult;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent ContainerRegistryService.
    /// </summary>
    public ContainerRegistryService? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<ContainerRegistryService> _parent;

    /// <summary>
    /// Creates a new ContainerRegistryTaskRun.
    /// </summary>
    /// <param name="identifierName">
    /// The the Bicep identifier name of the ContainerRegistryTaskRun resource.
    /// This can be used to refer to the resource in expressions, but is not
    /// the Azure name of the resource.  This value can contain letters,
    /// numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the ContainerRegistryTaskRun.</param>
    public ContainerRegistryTaskRun(string identifierName, string? resourceVersion = default)
        : base(identifierName, "Microsoft.ContainerRegistry/registries/taskRuns", resourceVersion ?? "2019-06-01-preview")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _forceUpdateTag = BicepValue<string>.DefineProperty(this, "ForceUpdateTag", ["properties", "forceUpdateTag"]);
        _identity = BicepValue<ManagedServiceIdentity>.DefineProperty(this, "Identity", ["identity"]);
        _location = BicepValue<AzureLocation>.DefineProperty(this, "Location", ["location"]);
        _runRequest = BicepValue<ContainerRegistryRunContent>.DefineProperty(this, "RunRequest", ["properties", "runRequest"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _provisioningState = BicepValue<ContainerRegistryProvisioningState>.DefineProperty(this, "ProvisioningState", ["properties", "provisioningState"], isOutput: true);
        _runResult = BicepValue<ContainerRegistryRunData>.DefineProperty(this, "RunResult", ["properties", "runResult"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<ContainerRegistryService>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported ContainerRegistryTaskRun resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2019-06-01-preview.
        /// </summary>
        public static readonly string V2019_06_01_preview = "2019-06-01-preview";
    }

    /// <summary>
    /// Creates a reference to an existing ContainerRegistryTaskRun.
    /// </summary>
    /// <param name="identifierName">
    /// The the Bicep identifier name of the ContainerRegistryTaskRun resource.
    /// This can be used to refer to the resource in expressions, but is not
    /// the Azure name of the resource.  This value can contain letters,
    /// numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the ContainerRegistryTaskRun.</param>
    /// <returns>The existing ContainerRegistryTaskRun resource.</returns>
    public static ContainerRegistryTaskRun FromExisting(string identifierName, string? resourceVersion = default) =>
        new(identifierName, resourceVersion) { IsExistingResource = true };
}
