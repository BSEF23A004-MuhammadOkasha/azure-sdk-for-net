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
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Mount Target
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class MountTarget
    {
        /// <summary>
        /// Initializes a new instance of the MountTarget class.
        /// </summary>
        public MountTarget()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MountTarget class.
        /// </summary>
        /// <param name="location">Resource location</param>
        /// <param name="fileSystemId">fileSystemId</param>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="mountTargetId">mountTargetId</param>
        /// <param name="ipAddress">ipAddress</param>
        /// <param name="vlanId">vlanid</param>
        /// <param name="startIp">startIp</param>
        /// <param name="endIp">startIp</param>
        /// <param name="gateway">gateway</param>
        /// <param name="netmask">netmask</param>
        /// <param name="provisioningState">Azure lifecycle management</param>
        public MountTarget(string location, string fileSystemId, string id = default(string), string name = default(string), object tags = default(object), string mountTargetId = default(string), string ipAddress = default(string), int? vlanId = default(int?), string startIp = default(string), string endIp = default(string), string gateway = default(string), string netmask = default(string), string provisioningState = default(string))
        {
            Location = location;
            Id = id;
            Name = name;
            Tags = tags;
            MountTargetId = mountTargetId;
            FileSystemId = fileSystemId;
            IpAddress = ipAddress;
            VlanId = vlanId;
            StartIp = startIp;
            EndIp = endIp;
            Gateway = gateway;
            Netmask = netmask;
            ProvisioningState = provisioningState;
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
        /// Gets or sets resource tags
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public object Tags { get; set; }

        /// <summary>
        /// Gets mountTargetId
        /// </summary>
        /// <remarks>
        /// UUID v4 used to identify the MountTarget
        /// </remarks>
        [JsonProperty(PropertyName = "properties.mountTargetId")]
        public string MountTargetId { get; private set; }

        /// <summary>
        /// Gets or sets fileSystemId
        /// </summary>
        /// <remarks>
        /// UUID v4 used to identify the MountTarget
        /// </remarks>
        [JsonProperty(PropertyName = "properties.fileSystemId")]
        public string FileSystemId { get; set; }

        /// <summary>
        /// Gets ipAddress
        /// </summary>
        /// <remarks>
        /// The mount target's IPv4 address
        /// </remarks>
        [JsonProperty(PropertyName = "properties.ipAddress")]
        public string IpAddress { get; private set; }

        /// <summary>
        /// Gets or sets vlanid
        /// </summary>
        /// <remarks>
        /// Vlan Id
        /// </remarks>
        [JsonProperty(PropertyName = "properties.vlanId")]
        public int? VlanId { get; set; }

        /// <summary>
        /// Gets or sets startIp
        /// </summary>
        /// <remarks>
        /// The start of IPv4 address range to use when creating a new mount
        /// target
        /// </remarks>
        [JsonProperty(PropertyName = "properties.startIp")]
        public string StartIp { get; set; }

        /// <summary>
        /// Gets or sets startIp
        /// </summary>
        /// <remarks>
        /// The end of IPv4 address range to use when creating a new mount
        /// target
        /// </remarks>
        [JsonProperty(PropertyName = "properties.endIp")]
        public string EndIp { get; set; }

        /// <summary>
        /// Gets or sets gateway
        /// </summary>
        /// <remarks>
        /// The gateway of the IPv4 address range to use when creating a new
        /// mount target
        /// </remarks>
        [JsonProperty(PropertyName = "properties.gateway")]
        public string Gateway { get; set; }

        /// <summary>
        /// Gets or sets netmask
        /// </summary>
        /// <remarks>
        /// The netmask of the IPv4 address range to use when creating a new
        /// mount target
        /// </remarks>
        [JsonProperty(PropertyName = "properties.netmask")]
        public string Netmask { get; set; }

        /// <summary>
        /// Gets azure lifecycle management
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

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
            if (FileSystemId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "FileSystemId");
            }
            if (MountTargetId != null)
            {
                if (MountTargetId.Length > 36)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "MountTargetId", 36);
                }
                if (MountTargetId.Length < 36)
                {
                    throw new ValidationException(ValidationRules.MinLength, "MountTargetId", 36);
                }
                if (!System.Text.RegularExpressions.Regex.IsMatch(MountTargetId, "^[a-fA-F0-9]{8}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{12}$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "MountTargetId", "^[a-fA-F0-9]{8}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{12}$");
                }
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
        }
    }
}
