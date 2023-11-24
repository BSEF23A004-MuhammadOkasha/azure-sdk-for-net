// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.MixedReality.RemoteRendering
{
    /// <summary> The properties of a rendering session. </summary>
    public partial class RenderingSession
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

        /// <summary> Initializes a new instance of <see cref="RenderingSession"/>. </summary>
        /// <param name="sessionId"> The ID of the session supplied when the session was created. </param>
        /// <param name="size"> The size of the server used for the rendering session. The size impacts the number of polygons the server can render. Refer to https://docs.microsoft.com/azure/remote-rendering/reference/vm-sizes for details. </param>
        /// <param name="status"> The status of the rendering session. Terminal states are 'Error', 'Expired', and 'Stopped'. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sessionId"/> is null. </exception>
        internal RenderingSession(string sessionId, RenderingServerSize size, RenderingSessionStatus status)
        {
            Argument.AssertNotNull(sessionId, nameof(sessionId));

            SessionId = sessionId;
            Size = size;
            Status = status;
        }

        /// <summary> Initializes a new instance of <see cref="RenderingSession"/>. </summary>
        /// <param name="sessionId"> The ID of the session supplied when the session was created. </param>
        /// <param name="arrInspectorPort"> The TCP port at which the Azure Remote Rendering Inspector tool is hosted. </param>
        /// <param name="handshakePort"> The TCP port used for the handshake when establishing a connection. </param>
        /// <param name="elapsedTimeMinutes"> Amount of time in minutes the session is or was in the 'Ready' state. Time is rounded down to a full minute. </param>
        /// <param name="host"> The hostname under which the rendering session is reachable. </param>
        /// <param name="maxLeaseTimeMinutes"> The time in minutes the session will run after reaching the 'Ready' state. </param>
        /// <param name="size"> The size of the server used for the rendering session. The size impacts the number of polygons the server can render. Refer to https://docs.microsoft.com/azure/remote-rendering/reference/vm-sizes for details. </param>
        /// <param name="status"> The status of the rendering session. Terminal states are 'Error', 'Expired', and 'Stopped'. </param>
        /// <param name="teraflops"> The computational power of the rendering session GPU measured in teraflops. </param>
        /// <param name="error"> The error object containing details about the rendering session startup failure. </param>
        /// <param name="createdOn"> The time when the rendering session was created. Date and time in ISO 8601 format. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RenderingSession(string sessionId, int? arrInspectorPort, int? handshakePort, int? elapsedTimeMinutes, string host, int? maxLeaseTimeMinutes, RenderingServerSize size, RenderingSessionStatus status, float? teraflops, RemoteRenderingServiceError error, DateTimeOffset? createdOn, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SessionId = sessionId;
            ArrInspectorPort = arrInspectorPort;
            HandshakePort = handshakePort;
            ElapsedTimeMinutes = elapsedTimeMinutes;
            Host = host;
            MaxLeaseTimeMinutes = maxLeaseTimeMinutes;
            Size = size;
            Status = status;
            Teraflops = teraflops;
            Error = error;
            CreatedOn = createdOn;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="RenderingSession"/> for deserialization. </summary>
        internal RenderingSession()
        {
        }
        /// <summary> The TCP port at which the Azure Remote Rendering Inspector tool is hosted. </summary>
        public int? ArrInspectorPort { get; }
        /// <summary> The TCP port used for the handshake when establishing a connection. </summary>
        public int? HandshakePort { get; }
        /// <summary> Amount of time in minutes the session is or was in the 'Ready' state. Time is rounded down to a full minute. </summary>
        public int? ElapsedTimeMinutes { get; }
        /// <summary> The size of the server used for the rendering session. The size impacts the number of polygons the server can render. Refer to https://docs.microsoft.com/azure/remote-rendering/reference/vm-sizes for details. </summary>
        public RenderingServerSize Size { get; }
        /// <summary> The status of the rendering session. Terminal states are 'Error', 'Expired', and 'Stopped'. </summary>
        public RenderingSessionStatus Status { get; }
        /// <summary> The computational power of the rendering session GPU measured in teraflops. </summary>
        public float? Teraflops { get; }
        /// <summary> The error object containing details about the rendering session startup failure. </summary>
        public RemoteRenderingServiceError Error { get; }
    }
}
