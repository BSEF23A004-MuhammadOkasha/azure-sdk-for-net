// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.AppService;

/// <summary>
/// StaticSiteUserProvidedFunctionApp.
/// </summary>
public partial class StaticSiteUserProvidedFunctionApp : Resource
{
    /// <summary>
    /// Gets or sets the Name.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// The region of the function app registered with the static site.
    /// </summary>
    public BicepValue<string> FunctionAppRegion { get => _functionAppRegion; set => _functionAppRegion.Assign(value); }
    private readonly BicepValue<string> _functionAppRegion;

    /// <summary>
    /// The resource id of the function app registered with the static site.
    /// </summary>
    public BicepValue<ResourceIdentifier> FunctionAppResourceId { get => _functionAppResourceId; set => _functionAppResourceId.Assign(value); }
    private readonly BicepValue<ResourceIdentifier> _functionAppResourceId;

    /// <summary>
    /// Kind of resource.
    /// </summary>
    public BicepValue<string> Kind { get => _kind; set => _kind.Assign(value); }
    private readonly BicepValue<string> _kind;

    /// <summary>
    /// The date and time on which the function app was registered with the
    /// static site.
    /// </summary>
    public BicepValue<DateTimeOffset> CreatedOn { get => _createdOn; }
    private readonly BicepValue<DateTimeOffset> _createdOn;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent StaticSite.
    /// </summary>
    public StaticSite? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<StaticSite> _parent;

    /// <summary>
    /// Creates a new StaticSiteUserProvidedFunctionApp.
    /// </summary>
    /// <param name="identifierName">
    /// The the Bicep identifier name of the StaticSiteUserProvidedFunctionApp
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the StaticSiteUserProvidedFunctionApp.</param>
    public StaticSiteUserProvidedFunctionApp(string identifierName, string? resourceVersion = default)
        : base(identifierName, "Microsoft.Web/staticSites/userProvidedFunctionApps", resourceVersion ?? "2024-04-01")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _functionAppRegion = BicepValue<string>.DefineProperty(this, "FunctionAppRegion", ["properties", "functionAppRegion"]);
        _functionAppResourceId = BicepValue<ResourceIdentifier>.DefineProperty(this, "FunctionAppResourceId", ["properties", "functionAppResourceId"]);
        _kind = BicepValue<string>.DefineProperty(this, "Kind", ["kind"]);
        _createdOn = BicepValue<DateTimeOffset>.DefineProperty(this, "CreatedOn", ["properties", "createdOn"], isOutput: true);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<StaticSite>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported StaticSiteUserProvidedFunctionApp resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2024-04-01.
        /// </summary>
        public static readonly string V2024_04_01 = "2024-04-01";

        /// <summary>
        /// 2023-12-01.
        /// </summary>
        public static readonly string V2023_12_01 = "2023-12-01";

        /// <summary>
        /// 2023-01-01.
        /// </summary>
        public static readonly string V2023_01_01 = "2023-01-01";

        /// <summary>
        /// 2022-09-01.
        /// </summary>
        public static readonly string V2022_09_01 = "2022-09-01";

        /// <summary>
        /// 2022-03-01.
        /// </summary>
        public static readonly string V2022_03_01 = "2022-03-01";

        /// <summary>
        /// 2021-03-01.
        /// </summary>
        public static readonly string V2021_03_01 = "2021-03-01";

        /// <summary>
        /// 2021-02-01.
        /// </summary>
        public static readonly string V2021_02_01 = "2021-02-01";

        /// <summary>
        /// 2021-01-15.
        /// </summary>
        public static readonly string V2021_01_15 = "2021-01-15";

        /// <summary>
        /// 2021-01-01.
        /// </summary>
        public static readonly string V2021_01_01 = "2021-01-01";

        /// <summary>
        /// 2020-12-01.
        /// </summary>
        public static readonly string V2020_12_01 = "2020-12-01";
    }

    /// <summary>
    /// Creates a reference to an existing StaticSiteUserProvidedFunctionApp.
    /// </summary>
    /// <param name="identifierName">
    /// The the Bicep identifier name of the StaticSiteUserProvidedFunctionApp
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the StaticSiteUserProvidedFunctionApp.</param>
    /// <returns>The existing StaticSiteUserProvidedFunctionApp resource.</returns>
    public static StaticSiteUserProvidedFunctionApp FromExisting(string identifierName, string? resourceVersion = default) =>
        new(identifierName, resourceVersion) { IsExistingResource = true };
}
