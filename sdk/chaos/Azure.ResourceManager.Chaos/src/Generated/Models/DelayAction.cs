// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Chaos.Models
{
    /// <summary> Model that represents a delay action. </summary>
    public partial class DelayAction : Action
    {
        /// <summary> Initializes a new instance of <see cref="DelayAction"/>. </summary>
        /// <param name="name"> String that represents a Capability URN. </param>
        /// <param name="duration"> ISO8601 formatted string that represents a duration. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public DelayAction(string name, TimeSpan duration) : base(name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Duration = duration;
            ActionType = "delay";
        }

        /// <summary> Initializes a new instance of <see cref="DelayAction"/>. </summary>
        /// <param name="actionType"> Enum that discriminates between action models. </param>
        /// <param name="name"> String that represents a Capability URN. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="duration"> ISO8601 formatted string that represents a duration. </param>
        internal DelayAction(string actionType, string name, IDictionary<string, BinaryData> serializedAdditionalRawData, TimeSpan duration) : base(actionType, name, serializedAdditionalRawData)
        {
            Duration = duration;
            ActionType = actionType ?? "delay";
        }

        /// <summary> Initializes a new instance of <see cref="DelayAction"/> for deserialization. </summary>
        internal DelayAction()
        {
        }

        /// <summary> ISO8601 formatted string that represents a duration. </summary>
        public TimeSpan Duration { get; set; }
    }
}
