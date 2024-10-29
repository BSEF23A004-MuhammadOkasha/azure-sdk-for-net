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
/// StaticSiteCustomDomainOverview.
/// </summary>
public partial class StaticSiteCustomDomainOverview : ProvisionableResource
{
    /// <summary>
    /// The custom domain to create.
    /// </summary>
    public BicepValue<string> Name 
    {
        get { Initialize(); return _name!; }
        set { Initialize(); _name!.Assign(value); }
    }
    private BicepValue<string>? _name;

    /// <summary>
    /// Kind of resource.
    /// </summary>
    public BicepValue<string> Kind 
    {
        get { Initialize(); return _kind!; }
        set { Initialize(); _kind!.Assign(value); }
    }
    private BicepValue<string>? _kind;

    /// <summary>
    /// Validation method for adding a custom domain.
    /// </summary>
    public BicepValue<string> ValidationMethod 
    {
        get { Initialize(); return _validationMethod!; }
        set { Initialize(); _validationMethod!.Assign(value); }
    }
    private BicepValue<string>? _validationMethod;

    /// <summary>
    /// The date and time on which the custom domain was created for the static
    /// site.
    /// </summary>
    public BicepValue<DateTimeOffset> CreatedOn 
    {
        get { Initialize(); return _createdOn!; }
    }
    private BicepValue<DateTimeOffset>? _createdOn;

    /// <summary>
    /// The domain name for the static site custom domain.
    /// </summary>
    public BicepValue<string> DomainName 
    {
        get { Initialize(); return _domainName!; }
    }
    private BicepValue<string>? _domainName;

    /// <summary>
    /// Gets the error message.
    /// </summary>
    public BicepValue<string> ErrorMessage 
    {
        get { Initialize(); return _errorMessage!; }
    }
    private BicepValue<string>? _errorMessage;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id 
    {
        get { Initialize(); return _id!; }
    }
    private BicepValue<ResourceIdentifier>? _id;

    /// <summary>
    /// The status of the custom domain.
    /// </summary>
    public BicepValue<CustomDomainStatus> Status 
    {
        get { Initialize(); return _status!; }
    }
    private BicepValue<CustomDomainStatus>? _status;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public SystemData SystemData 
    {
        get { Initialize(); return _systemData!; }
    }
    private SystemData? _systemData;

    /// <summary>
    /// The TXT record validation token.
    /// </summary>
    public BicepValue<string> ValidationToken 
    {
        get { Initialize(); return _validationToken!; }
    }
    private BicepValue<string>? _validationToken;

    /// <summary>
    /// Gets or sets a reference to the parent StaticSite.
    /// </summary>
    public StaticSite? Parent
    {
        get { Initialize(); return _parent!.Value; }
        set { Initialize(); _parent!.Value = value; }
    }
    private ResourceReference<StaticSite>? _parent;

    /// <summary>
    /// Creates a new StaticSiteCustomDomainOverview.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the StaticSiteCustomDomainOverview
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the StaticSiteCustomDomainOverview.</param>
    public StaticSiteCustomDomainOverview(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.Web/staticSites/customDomains", resourceVersion ?? "2024-04-01")
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// StaticSiteCustomDomainOverview.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        _name = DefineProperty<string>("Name", ["name"], isRequired: true);
        _kind = DefineProperty<string>("Kind", ["kind"]);
        _validationMethod = DefineProperty<string>("ValidationMethod", ["properties", "validationMethod"]);
        _createdOn = DefineProperty<DateTimeOffset>("CreatedOn", ["properties", "createdOn"], isOutput: true);
        _domainName = DefineProperty<string>("DomainName", ["properties", "domainName"], isOutput: true);
        _errorMessage = DefineProperty<string>("ErrorMessage", ["properties", "errorMessage"], isOutput: true);
        _id = DefineProperty<ResourceIdentifier>("Id", ["id"], isOutput: true);
        _status = DefineProperty<CustomDomainStatus>("Status", ["properties", "status"], isOutput: true);
        _systemData = DefineModelProperty<SystemData>("SystemData", ["systemData"], isOutput: true);
        _validationToken = DefineProperty<string>("ValidationToken", ["properties", "validationToken"], isOutput: true);
        _parent = DefineResource<StaticSite>("Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported StaticSiteCustomDomainOverview resource versions.
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

        /// <summary>
        /// 2020-10-01.
        /// </summary>
        public static readonly string V2020_10_01 = "2020-10-01";

        /// <summary>
        /// 2020-09-01.
        /// </summary>
        public static readonly string V2020_09_01 = "2020-09-01";

        /// <summary>
        /// 2020-06-01.
        /// </summary>
        public static readonly string V2020_06_01 = "2020-06-01";

        /// <summary>
        /// 2019-08-01.
        /// </summary>
        public static readonly string V2019_08_01 = "2019-08-01";
    }

    /// <summary>
    /// Creates a reference to an existing StaticSiteCustomDomainOverview.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the StaticSiteCustomDomainOverview
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the StaticSiteCustomDomainOverview.</param>
    /// <returns>The existing StaticSiteCustomDomainOverview resource.</returns>
    public static StaticSiteCustomDomainOverview FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
