// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityCenter.Models;

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A class representing the SecurityTask data model.
    /// Security task that we recommend to do in order to strengthen security
    /// </summary>
    public partial class SecurityTaskData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SecurityTaskData"/>. </summary>
        public SecurityTaskData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SecurityTaskData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="state"> State of the task (Active, Resolved etc.). </param>
        /// <param name="createdOn"> The time this task was discovered in UTC. </param>
        /// <param name="securityTaskParameters"> Changing set of properties, depending on the task type that is derived from the name field. </param>
        /// <param name="lastStateChangedOn"> The time this task's details were last changed in UTC. </param>
        /// <param name="subState"> Additional data on the state of the task. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SecurityTaskData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string state, DateTimeOffset? createdOn, SecurityTaskProperties securityTaskParameters, DateTimeOffset? lastStateChangedOn, string subState, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            State = state;
            CreatedOn = createdOn;
            SecurityTaskParameters = securityTaskParameters;
            LastStateChangedOn = lastStateChangedOn;
            SubState = subState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> State of the task (Active, Resolved etc.). </summary>
        public string State { get; }
        /// <summary> The time this task was discovered in UTC. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> Changing set of properties, depending on the task type that is derived from the name field. </summary>
        public SecurityTaskProperties SecurityTaskParameters { get; set; }
        /// <summary> The time this task's details were last changed in UTC. </summary>
        public DateTimeOffset? LastStateChangedOn { get; }
        /// <summary> Additional data on the state of the task. </summary>
        public string SubState { get; }
    }
}
