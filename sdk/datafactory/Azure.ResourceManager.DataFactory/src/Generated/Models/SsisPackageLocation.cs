// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Expressions.DataFactory;
using Azure.ResourceManager.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> SSIS package location. </summary>
    public partial class SsisPackageLocation
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SsisPackageLocation"/>. </summary>
        public SsisPackageLocation()
        {
            ChildPackages = new ChangeTrackingList<SsisChildPackage>();
        }

        /// <summary> Initializes a new instance of <see cref="SsisPackageLocation"/>. </summary>
        /// <param name="packagePath"> The SSIS package path. Type: string (or Expression with resultType string). </param>
        /// <param name="locationType"> The type of SSIS package location. </param>
        /// <param name="packagePassword"> Password of the package. </param>
        /// <param name="accessCredential"> The package access credential. </param>
        /// <param name="configurationPath"> The configuration file of the package execution. Type: string (or Expression with resultType string). </param>
        /// <param name="configurationAccessCredential"> The configuration file access credential. </param>
        /// <param name="packageName"> The package name. </param>
        /// <param name="packageContent"> The embedded package content. Type: string (or Expression with resultType string). </param>
        /// <param name="packageLastModifiedDate"> The embedded package last modified date. </param>
        /// <param name="childPackages"> The embedded child package list. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SsisPackageLocation(DataFactoryElement<string> packagePath, SsisPackageLocationType? locationType, DataFactorySecret packagePassword, SsisAccessCredential accessCredential, DataFactoryElement<string> configurationPath, SsisAccessCredential configurationAccessCredential, string packageName, DataFactoryElement<string> packageContent, string packageLastModifiedDate, IList<SsisChildPackage> childPackages, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PackagePath = packagePath;
            LocationType = locationType;
            PackagePassword = packagePassword;
            AccessCredential = accessCredential;
            ConfigurationPath = configurationPath;
            ConfigurationAccessCredential = configurationAccessCredential;
            PackageName = packageName;
            PackageContent = packageContent;
            PackageLastModifiedDate = packageLastModifiedDate;
            ChildPackages = childPackages;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The SSIS package path. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> PackagePath { get; set; }
        /// <summary> The type of SSIS package location. </summary>
        public SsisPackageLocationType? LocationType { get; set; }
        /// <summary> Password of the package. </summary>
        public DataFactorySecret PackagePassword { get; set; }
        /// <summary> The package access credential. </summary>
        public SsisAccessCredential AccessCredential { get; set; }
        /// <summary> The configuration file of the package execution. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> ConfigurationPath { get; set; }
        /// <summary> The configuration file access credential. </summary>
        public SsisAccessCredential ConfigurationAccessCredential { get; set; }
        /// <summary> The package name. </summary>
        public string PackageName { get; set; }
        /// <summary> The embedded package content. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> PackageContent { get; set; }
        /// <summary> The embedded package last modified date. </summary>
        public string PackageLastModifiedDate { get; set; }
        /// <summary> The embedded child package list. </summary>
        public IList<SsisChildPackage> ChildPackages { get; }
    }
}
