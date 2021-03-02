// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Iot.TimeSeriesInsights
{
    /// <summary> Property of an event that is either stored or computed. Properties are identified by both name and type. Different events can have properties with same name, but different type. </summary>
    public partial class EventProperty
    {
        /// <summary> Initializes a new instance of EventProperty. </summary>
        public EventProperty()
        {
        }

        /// <summary> Initializes a new instance of EventProperty. </summary>
        /// <param name="name"> The name of the property. </param>
        /// <param name="type"> The type of the property. </param>
        internal EventProperty(string name, PropertyTypes? type)
        {
            Name = name;
            Type = type;
        }

        /// <summary> The name of the property. </summary>
        public string Name { get; set; }
        /// <summary> The type of the property. </summary>
        public PropertyTypes? Type { get; set; }
    }
}
