// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Information about packet capture session.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class PacketCaptureResult
    {
        /// <summary>
        /// Initializes a new instance of the PacketCaptureResult class.
        /// </summary>
        public PacketCaptureResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PacketCaptureResult class.
        /// </summary>
        /// <param name="target">The ID of the targeted resource, only VM is
        /// currently supported.</param>
        /// <param name="storageLocation">The storage location for a packet
        /// capture session.</param>
        /// <param name="name">Name of the packet capture session.</param>
        /// <param name="id">ID of the packet capture operation.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        /// <param name="bytesToCapturePerPacket">Number of bytes captured per
        /// packet, the remaining bytes are truncated.</param>
        /// <param name="totalBytesPerSession">Maximum size of the capture
        /// output.</param>
        /// <param name="timeLimitInSeconds">Maximum duration of the capture
        /// session in seconds.</param>
        /// <param name="filters">A list of packet capture filters.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// packet capture session. Possible values include: 'Succeeded',
        /// 'Updating', 'Deleting', 'Failed'</param>
        public PacketCaptureResult(string target, PacketCaptureStorageLocation storageLocation, string name = default(string), string id = default(string), string etag = default(string), long? bytesToCapturePerPacket = default(long?), long? totalBytesPerSession = default(long?), int? timeLimitInSeconds = default(int?), IList<PacketCaptureFilter> filters = default(IList<PacketCaptureFilter>), string provisioningState = default(string))
        {
            Name = name;
            Id = id;
            Etag = etag;
            Target = target;
            BytesToCapturePerPacket = bytesToCapturePerPacket;
            TotalBytesPerSession = totalBytesPerSession;
            TimeLimitInSeconds = timeLimitInSeconds;
            StorageLocation = storageLocation;
            Filters = filters;
            ProvisioningState = provisioningState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets name of the packet capture session.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets ID of the packet capture operation.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource
        /// is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; private set; }

        /// <summary>
        /// Gets or sets the ID of the targeted resource, only VM is currently
        /// supported.
        /// </summary>
        [JsonProperty(PropertyName = "properties.target")]
        public string Target { get; set; }

        /// <summary>
        /// Gets or sets number of bytes captured per packet, the remaining
        /// bytes are truncated.
        /// </summary>
        [JsonProperty(PropertyName = "properties.bytesToCapturePerPacket")]
        public long? BytesToCapturePerPacket { get; set; }

        /// <summary>
        /// Gets or sets maximum size of the capture output.
        /// </summary>
        [JsonProperty(PropertyName = "properties.totalBytesPerSession")]
        public long? TotalBytesPerSession { get; set; }

        /// <summary>
        /// Gets or sets maximum duration of the capture session in seconds.
        /// </summary>
        [JsonProperty(PropertyName = "properties.timeLimitInSeconds")]
        public int? TimeLimitInSeconds { get; set; }

        /// <summary>
        /// Gets or sets the storage location for a packet capture session.
        /// </summary>
        [JsonProperty(PropertyName = "properties.storageLocation")]
        public PacketCaptureStorageLocation StorageLocation { get; set; }

        /// <summary>
        /// Gets or sets a list of packet capture filters.
        /// </summary>
        [JsonProperty(PropertyName = "properties.filters")]
        public IList<PacketCaptureFilter> Filters { get; set; }

        /// <summary>
        /// Gets the provisioning state of the packet capture session. Possible
        /// values include: 'Succeeded', 'Updating', 'Deleting', 'Failed'
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
            if (Target == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Target");
            }
            if (StorageLocation == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "StorageLocation");
            }
            if (BytesToCapturePerPacket != null)
            {
                if (BytesToCapturePerPacket > 4294967295)
                {
                    throw new ValidationException(ValidationRules.InclusiveMaximum, "BytesToCapturePerPacket", 4294967295);
                }
                if (BytesToCapturePerPacket < 0)
                {
                    throw new ValidationException(ValidationRules.InclusiveMinimum, "BytesToCapturePerPacket", 0);
                }
            }
            if (TotalBytesPerSession != null)
            {
                if (TotalBytesPerSession > 4294967295)
                {
                    throw new ValidationException(ValidationRules.InclusiveMaximum, "TotalBytesPerSession", 4294967295);
                }
                if (TotalBytesPerSession < 0)
                {
                    throw new ValidationException(ValidationRules.InclusiveMinimum, "TotalBytesPerSession", 0);
                }
            }
            if (TimeLimitInSeconds != null)
            {
                if (TimeLimitInSeconds > 18000)
                {
                    throw new ValidationException(ValidationRules.InclusiveMaximum, "TimeLimitInSeconds", 18000);
                }
                if (TimeLimitInSeconds < 0)
                {
                    throw new ValidationException(ValidationRules.InclusiveMinimum, "TimeLimitInSeconds", 0);
                }
            }
        }
    }
}
