// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Communication.CallAutomation
{
    /// <summary>
    /// The BaseDialog.
    /// Please note <see cref="BaseDialog"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="AzureOpenAIDialog"/> and <see cref="PowerVirtualAgentsDialog"/>.
    /// </summary>
    public abstract partial class BaseDialog
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

        /// <summary> Initializes a new instance of <see cref="BaseDialog"/>. </summary>
        /// <param name="context"> Dialog context. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="context"/> is null. </exception>
        protected BaseDialog(IDictionary<string, object> context)
        {
            Argument.AssertNotNull(context, nameof(context));

            Context = context;
        }

        /// <summary> Initializes a new instance of <see cref="BaseDialog"/>. </summary>
        /// <param name="kind"> Determines the type of the dialog. </param>
        /// <param name="context"> Dialog context. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BaseDialog(DialogInputType kind, IDictionary<string, object> context, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Kind = kind;
            Context = context;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="BaseDialog"/> for deserialization. </summary>
        internal BaseDialog()
        {
        }
    }
}
