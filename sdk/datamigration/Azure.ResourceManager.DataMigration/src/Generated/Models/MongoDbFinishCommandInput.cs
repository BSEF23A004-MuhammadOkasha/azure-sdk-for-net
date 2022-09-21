// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Describes the input to the &apos;finish&apos; MongoDB migration command. </summary>
    public partial class MongoDbFinishCommandInput : MongoDbCommandInput
    {
        /// <summary> Initializes a new instance of MongoDbFinishCommandInput. </summary>
        /// <param name="immediate"> If true, replication for the affected objects will be stopped immediately. If false, the migrator will finish replaying queued events before finishing the replication. </param>
        public MongoDbFinishCommandInput(bool immediate)
        {
            Immediate = immediate;
        }

        /// <summary> Initializes a new instance of MongoDbFinishCommandInput. </summary>
        /// <param name="objectName"> The qualified name of a database or collection to act upon, or null to act upon the entire migration. </param>
        /// <param name="immediate"> If true, replication for the affected objects will be stopped immediately. If false, the migrator will finish replaying queued events before finishing the replication. </param>
        internal MongoDbFinishCommandInput(string objectName, bool immediate) : base(objectName)
        {
            Immediate = immediate;
        }

        /// <summary> If true, replication for the affected objects will be stopped immediately. If false, the migrator will finish replaying queued events before finishing the replication. </summary>
        public bool Immediate { get; set; }
    }
}
