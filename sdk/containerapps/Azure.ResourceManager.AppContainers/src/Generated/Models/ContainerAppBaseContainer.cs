// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Container App base container definition. </summary>
    public partial class ContainerAppBaseContainer
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
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ContainerAppBaseContainer"/>. </summary>
        public ContainerAppBaseContainer()
        {
            Command = new ChangeTrackingList<string>();
            Args = new ChangeTrackingList<string>();
            Env = new ChangeTrackingList<ContainerAppEnvironmentVariable>();
            VolumeMounts = new ChangeTrackingList<ContainerAppVolumeMount>();
        }

        /// <summary> Initializes a new instance of <see cref="ContainerAppBaseContainer"/>. </summary>
        /// <param name="image"> Container image tag. </param>
        /// <param name="name"> Custom container name. </param>
        /// <param name="command"> Container start command. </param>
        /// <param name="args"> Container start command arguments. </param>
        /// <param name="env"> Container environment variables. </param>
        /// <param name="resources"> Container resource requirements. </param>
        /// <param name="volumeMounts"> Container volume mounts. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerAppBaseContainer(string image, string name, IList<string> command, IList<string> args, IList<ContainerAppEnvironmentVariable> env, AppContainerResources resources, IList<ContainerAppVolumeMount> volumeMounts, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Image = image;
            Name = name;
            Command = command;
            Args = args;
            Env = env;
            Resources = resources;
            VolumeMounts = volumeMounts;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Container image tag. </summary>
        public string Image { get; set; }
        /// <summary> Custom container name. </summary>
        public string Name { get; set; }
        /// <summary> Container start command. </summary>
        public IList<string> Command { get; }
        /// <summary> Container start command arguments. </summary>
        public IList<string> Args { get; }
        /// <summary> Container environment variables. </summary>
        public IList<ContainerAppEnvironmentVariable> Env { get; }
        /// <summary> Container resource requirements. </summary>
        public AppContainerResources Resources { get; set; }
        /// <summary> Container volume mounts. </summary>
        public IList<ContainerAppVolumeMount> VolumeMounts { get; }
    }
}
