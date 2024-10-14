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
public partial class StaticSiteCustomDomainOverview : Resource
{
    /// <summary>
    /// The custom domain to create.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Kind of resource.
    /// </summary>
    public BicepValue<string> Kind { get => _kind; set => _kind.Assign(value); }
    private readonly BicepValue<string> _kind;

    /// <summary>
    /// Validation method for adding a custom domain.
    /// </summary>
    public BicepValue<string> ValidationMethod { get => _validationMethod; set => _validationMethod.Assign(value); }
    private readonly BicepValue<string> _validationMethod;

    /// <summary>
    /// The date and time on which the custom domain was created for the static
    /// site.
    /// </summary>
    public BicepValue<DateTimeOffset> CreatedOn { get => _createdOn; }
    private readonly BicepValue<DateTimeOffset> _createdOn;

    /// <summary>
    /// The domain name for the static site custom domain.
    /// </summary>
    public BicepValue<string> DomainName { get => _domainName; }
    private readonly BicepValue<string> _domainName;

    /// <summary>
    /// Gets the error message.
    /// </summary>
    public BicepValue<string> ErrorMessage { get => _errorMessage; }
    private readonly BicepValue<string> _errorMessage;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// The status of the custom domain.
    /// </summary>
    public BicepValue<CustomDomainStatus> Status { get => _status; }
    private readonly BicepValue<CustomDomainStatus> _status;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// The TXT record validation token.
    /// </summary>
    public BicepValue<string> ValidationToken { get => _validationToken; }
    private readonly BicepValue<string> _validationToken;

    /// <summary>
    /// Gets or sets a reference to the parent StaticSite.
    /// </summary>
    public StaticSite? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<StaticSite> _parent;

    /// <summary>
    /// Creates a new StaticSiteCustomDomainOverview.
    /// </summary>
    /// <param name="identifierName">
    /// The the Bicep identifier name of the StaticSiteCustomDomainOverview
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the StaticSiteCustomDomainOverview.</param>
    public StaticSiteCustomDomainOverview(string identifierName, string? resourceVersion = default)
        : base(identifierName, "Microsoft.Web/staticSites/customDomains", resourceVersion ?? "2024-04-01")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _kind = BicepValue<string>.DefineProperty(this, "Kind", ["kind"]);
        _validationMethod = BicepValue<string>.DefineProperty(this, "ValidationMethod", ["properties", "validationMethod"]);
        _createdOn = BicepValue<DateTimeOffset>.DefineProperty(this, "CreatedOn", ["properties", "createdOn"], isOutput: true);
        _domainName = BicepValue<string>.DefineProperty(this, "DomainName", ["properties", "domainName"], isOutput: true);
        _errorMessage = BicepValue<string>.DefineProperty(this, "ErrorMessage", ["properties", "errorMessage"], isOutput: true);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _status = BicepValue<CustomDomainStatus>.DefineProperty(this, "Status", ["properties", "status"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _validationToken = BicepValue<string>.DefineProperty(this, "ValidationToken", ["properties", "validationToken"], isOutput: true);
        _parent = ResourceReference<StaticSite>.DefineResource(this, "Parent", ["parent"], isRequired: true);
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
    /// <param name="identifierName">
    /// The the Bicep identifier name of the StaticSiteCustomDomainOverview
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the StaticSiteCustomDomainOverview.</param>
    /// <returns>The existing StaticSiteCustomDomainOverview resource.</returns>
    public static StaticSiteCustomDomainOverview FromExisting(string identifierName, string? resourceVersion = default) =>
        new(identifierName, resourceVersion) { IsExistingResource = true };
}
