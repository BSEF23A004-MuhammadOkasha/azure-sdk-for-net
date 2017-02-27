// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Sql.Models
{
    using System.Linq;

    /// <summary>
    /// Represents a database replication link.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class ReplicationLink : SqlSubResource
    {
        /// <summary>
        /// Initializes a new instance of the ReplicationLink class.
        /// </summary>
        public ReplicationLink() { }

        /// <summary>
        /// Initializes a new instance of the ReplicationLink class.
        /// </summary>
        /// <param name="name">Resource name</param>
        /// <param name="id">The resource ID.</param>
        /// <param name="location">Location of the server that contains this
        /// firewall rule.</param>
        /// <param name="type">Type of resource this is.</param>
        /// <param name="isTerminationAllowed">Legacy value indicating whether
        /// termination is allowed.  Currently always returns true.</param>
        /// <param name="replicationMode">Replication mode of this replication
        /// link.</param>
        /// <param name="partnerServer">The name of the server hosting the
        /// partner database.</param>
        /// <param name="partnerDatabase">The name of the partner
        /// database.</param>
        /// <param name="partnerLocation">The Azure Region of the partner
        /// database.</param>
        /// <param name="role">The role of the database in the replication
        /// link. Possible values include: 'Primary', 'Secondary',
        /// 'NonReadableSecondary', 'Source', 'Copy'</param>
        /// <param name="partnerRole">The role of the partner database in the
        /// replication link. Possible values include: 'Primary',
        /// 'Secondary', 'NonReadableSecondary', 'Source', 'Copy'</param>
        /// <param name="startTime">The start time for the replication
        /// link.</param>
        /// <param name="percentComplete">The percentage of seeding complete
        /// for the replication link.</param>
        /// <param name="replicationState">The replication state for the
        /// replication link. Possible values include: 'PENDING', 'SEEDING',
        /// 'CATCH_UP', 'SUSPENDED'</param>
        public ReplicationLink(string name = default(string), string id = default(string), string location = default(string), string type = default(string), bool? isTerminationAllowed = default(bool?), string replicationMode = default(string), string partnerServer = default(string), string partnerDatabase = default(string), string partnerLocation = default(string), ReplicationRole? role = default(ReplicationRole?), ReplicationRole? partnerRole = default(ReplicationRole?), System.DateTime? startTime = default(System.DateTime?), int? percentComplete = default(int?), string replicationState = default(string))
            : base(name, id)
        {
            Location = location;
            Type = type;
            IsTerminationAllowed = isTerminationAllowed;
            ReplicationMode = replicationMode;
            PartnerServer = partnerServer;
            PartnerDatabase = partnerDatabase;
            PartnerLocation = partnerLocation;
            Role = role;
            PartnerRole = partnerRole;
            StartTime = startTime;
            PercentComplete = percentComplete;
            ReplicationState = replicationState;
        }

        /// <summary>
        /// Gets location of the server that contains this firewall rule.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "location")]
        public string Location { get; private set; }

        /// <summary>
        /// Gets type of resource this is.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets legacy value indicating whether termination is allowed.
        /// Currently always returns true.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.isTerminationAllowed")]
        public bool? IsTerminationAllowed { get; private set; }

        /// <summary>
        /// Gets replication mode of this replication link.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.replicationMode")]
        public string ReplicationMode { get; private set; }

        /// <summary>
        /// Gets the name of the server hosting the partner database.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.partnerServer")]
        public string PartnerServer { get; private set; }

        /// <summary>
        /// Gets the name of the partner database.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.partnerDatabase")]
        public string PartnerDatabase { get; private set; }

        /// <summary>
        /// Gets the Azure Region of the partner database.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.partnerLocation")]
        public string PartnerLocation { get; private set; }

        /// <summary>
        /// Gets the role of the database in the replication link. Possible
        /// values include: 'Primary', 'Secondary', 'NonReadableSecondary',
        /// 'Source', 'Copy'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.role")]
        public ReplicationRole? Role { get; private set; }

        /// <summary>
        /// Gets the role of the partner database in the replication link.
        /// Possible values include: 'Primary', 'Secondary',
        /// 'NonReadableSecondary', 'Source', 'Copy'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.partnerRole")]
        public ReplicationRole? PartnerRole { get; private set; }

        /// <summary>
        /// Gets the start time for the replication link.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.startTime")]
        public System.DateTime? StartTime { get; private set; }

        /// <summary>
        /// Gets the percentage of seeding complete for the replication link.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.percentComplete")]
        public int? PercentComplete { get; private set; }

        /// <summary>
        /// Gets the replication state for the replication link. Possible
        /// values include: 'PENDING', 'SEEDING', 'CATCH_UP', 'SUSPENDED'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.replicationState")]
        public string ReplicationState { get; private set; }

    }
}
