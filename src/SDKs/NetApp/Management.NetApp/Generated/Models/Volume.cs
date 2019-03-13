// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.NetApp.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Volume resource
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Volume : IResource
    {
        /// <summary>
        /// Initializes a new instance of the Volume class.
        /// </summary>
        public Volume()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Volume class.
        /// </summary>
        /// <param name="location">Resource location</param>
        /// <param name="creationToken">Creation Token or File Path</param>
        /// <param name="serviceLevel">serviceLevel</param>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="fileSystemId">FileSystem ID</param>
        /// <param name="usageThreshold">usageThreshold</param>
        /// <param name="exportPolicy">Export policy rule</param>
        /// <param name="provisioningState">Azure lifecycle management</param>
        /// <param name="subnetId">The Azure Resource URI for a delegated
        /// subnet. Must have the delegation Microsoft.NetApp/volumes</param>
        public Volume(string location, string creationToken, string serviceLevel, string id = default(string), string name = default(string), string type = default(string), object tags = default(object), string fileSystemId = default(string), long? usageThreshold = default(long?), ExportPolicyRule exportPolicy = default(ExportPolicyRule), string provisioningState = default(string), string subnetId = default(string))
        {
            Location = location;
            Id = id;
            Name = name;
            Type = type;
            Tags = tags;
            FileSystemId = fileSystemId;
            CreationToken = creationToken;
            ServiceLevel = serviceLevel;
            UsageThreshold = usageThreshold;
            ExportPolicy = exportPolicy;
            ProvisioningState = provisioningState;
            SubnetId = subnetId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets resource location
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets resource Id
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets resource name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets resource type
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets or sets resource tags
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public object Tags { get; set; }

        /// <summary>
        /// Gets fileSystem ID
        /// </summary>
        /// <remarks>
        /// Unique FileSystem Identifier.
        /// </remarks>
        [JsonProperty(PropertyName = "properties.fileSystemId")]
        public string FileSystemId { get; private set; }

        /// <summary>
        /// Gets or sets creation Token or File Path
        /// </summary>
        /// <remarks>
        /// A unique file path for the volume. Used when creating mount targets
        /// </remarks>
        [JsonProperty(PropertyName = "properties.creationToken")]
        public string CreationToken { get; set; }

        /// <summary>
        /// Gets or sets serviceLevel
        /// </summary>
        /// <remarks>
        /// The service level of the file system. Possible values include:
        /// 'Standard', 'Premium', 'Ultra'
        /// </remarks>
        [JsonProperty(PropertyName = "properties.serviceLevel")]
        public string ServiceLevel { get; set; }

        /// <summary>
        /// Gets or sets usageThreshold
        /// </summary>
        /// <remarks>
        /// Maximum storage quota allowed for a file system in bytes. This is a
        /// soft quota used for alerting only. Minimum size is 100 GiB. Upper
        /// limit is 100TiB.
        /// </remarks>
        [JsonProperty(PropertyName = "properties.usageThreshold")]
        public long? UsageThreshold { get; set; }

        /// <summary>
        /// Gets or sets export policy rule
        /// </summary>
        [JsonProperty(PropertyName = "properties.exportPolicy")]
        public ExportPolicyRule ExportPolicy { get; set; }

        /// <summary>
        /// Gets azure lifecycle management
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets the Azure Resource URI for a delegated subnet. Must
        /// have the delegation Microsoft.NetApp/volumes
        /// </summary>
        [JsonProperty(PropertyName = "properties.subnetId")]
        public string SubnetId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Location == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Location");
            }
            if (CreationToken == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "CreationToken");
            }
            if (ServiceLevel == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ServiceLevel");
            }
            if (FileSystemId != null)
            {
                if (FileSystemId.Length > 36)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "FileSystemId", 36);
                }
                if (FileSystemId.Length < 36)
                {
                    throw new ValidationException(ValidationRules.MinLength, "FileSystemId", 36);
                }
                if (!System.Text.RegularExpressions.Regex.IsMatch(FileSystemId, "^[a-fA-F0-9]{8}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{12}$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "FileSystemId", "^[a-fA-F0-9]{8}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{12}$");
                }
            }
            if (UsageThreshold > 109951162777600)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "UsageThreshold", 109951162777600);
            }
            if (UsageThreshold < 107374182400)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "UsageThreshold", 107374182400);
            }
        }
    }
}
