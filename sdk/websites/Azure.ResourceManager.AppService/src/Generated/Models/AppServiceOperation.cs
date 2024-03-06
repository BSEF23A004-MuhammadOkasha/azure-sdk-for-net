// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.ResourceManager.AppService;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> An operation on a resource. </summary>
    public partial class AppServiceOperation
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

        /// <summary> Initializes a new instance of <see cref="AppServiceOperation"/>. </summary>
        internal AppServiceOperation()
        {
            Errors = new ChangeTrackingList<ResponseError>();
        }

        /// <summary> Initializes a new instance of <see cref="AppServiceOperation"/>. </summary>
        /// <param name="id"> Operation ID. </param>
        /// <param name="name"> Operation name. </param>
        /// <param name="status"> The current status of the operation. </param>
        /// <param name="errors"> Any errors associate with the operation. </param>
        /// <param name="createdOn"> Time when operation has started. </param>
        /// <param name="modifiedOn"> Time when operation has been updated. </param>
        /// <param name="expireOn"> Time when operation will expire. </param>
        /// <param name="geoMasterOperationId"> Applicable only for stamp operation ids. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AppServiceOperation(string id, string name, AppServiceOperationStatus? status, IReadOnlyList<ResponseError> errors, DateTimeOffset? createdOn, DateTimeOffset? modifiedOn, DateTimeOffset? expireOn, Guid? geoMasterOperationId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            Name = name;
            Status = status;
            Errors = errors;
            CreatedOn = createdOn;
            ModifiedOn = modifiedOn;
            ExpireOn = expireOn;
            GeoMasterOperationId = geoMasterOperationId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Operation ID. </summary>
        public string Id { get; }
        /// <summary> Operation name. </summary>
        public string Name { get; }
        /// <summary> The current status of the operation. </summary>
        public AppServiceOperationStatus? Status { get; }
        /// <summary> Any errors associate with the operation. </summary>
        public IReadOnlyList<ResponseError> Errors { get; }
        /// <summary> Time when operation has started. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> Time when operation has been updated. </summary>
        public DateTimeOffset? ModifiedOn { get; }
        /// <summary> Time when operation will expire. </summary>
        public DateTimeOffset? ExpireOn { get; }
        /// <summary> Applicable only for stamp operation ids. </summary>
        public Guid? GeoMasterOperationId { get; }
    }
}
