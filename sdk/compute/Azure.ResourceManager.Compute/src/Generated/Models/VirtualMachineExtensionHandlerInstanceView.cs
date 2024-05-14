// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The instance view of a virtual machine extension handler. </summary>
    public partial class VirtualMachineExtensionHandlerInstanceView
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

        /// <summary> Initializes a new instance of <see cref="VirtualMachineExtensionHandlerInstanceView"/>. </summary>
        internal VirtualMachineExtensionHandlerInstanceView()
        {
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineExtensionHandlerInstanceView"/>. </summary>
        /// <param name="virtualMachineExtensionHandlerInstanceViewType"> Specifies the type of the extension; an example is "CustomScriptExtension". </param>
        /// <param name="typeHandlerVersion"> Specifies the version of the script handler. </param>
        /// <param name="status"> The extension handler status. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VirtualMachineExtensionHandlerInstanceView(string virtualMachineExtensionHandlerInstanceViewType, string typeHandlerVersion, InstanceViewStatus status, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            VirtualMachineExtensionHandlerInstanceViewType = virtualMachineExtensionHandlerInstanceViewType;
            TypeHandlerVersion = typeHandlerVersion;
            Status = status;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Specifies the type of the extension; an example is "CustomScriptExtension". </summary>
        public string VirtualMachineExtensionHandlerInstanceViewType { get; }
        /// <summary> Specifies the version of the script handler. </summary>
        public string TypeHandlerVersion { get; }
        /// <summary> The extension handler status. </summary>
        public InstanceViewStatus Status { get; }
    }
}
