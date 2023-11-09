// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Quantum.Models
{
    /// <summary> Information about a specific quota dimension. </summary>
    public partial class QuotaDimension
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="QuotaDimension"/>. </summary>
        internal QuotaDimension()
        {
        }

        /// <summary> Initializes a new instance of <see cref="QuotaDimension"/>. </summary>
        /// <param name="id"> Unique id of this dimension. </param>
        /// <param name="scope"> The scope of this quota dimension. </param>
        /// <param name="period"> The reset period of this quota dimension. </param>
        /// <param name="quota"> The max limit of this dimension. </param>
        /// <param name="name"> The display name of this quota dimension. </param>
        /// <param name="description"> A description about this quota dimension. </param>
        /// <param name="unit"> The standard unit of measurement used for this quota dimension. </param>
        /// <param name="unitPlural"> The standard unit of measurement used for this quota dimension in plural form. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal QuotaDimension(string id, string scope, string period, float? quota, string name, string description, string unit, string unitPlural, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            Scope = scope;
            Period = period;
            Quota = quota;
            Name = name;
            Description = description;
            Unit = unit;
            UnitPlural = unitPlural;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Unique id of this dimension. </summary>
        public string Id { get; }
        /// <summary> The scope of this quota dimension. </summary>
        public string Scope { get; }
        /// <summary> The reset period of this quota dimension. </summary>
        public string Period { get; }
        /// <summary> The max limit of this dimension. </summary>
        public float? Quota { get; }
        /// <summary> The display name of this quota dimension. </summary>
        public string Name { get; }
        /// <summary> A description about this quota dimension. </summary>
        public string Description { get; }
        /// <summary> The standard unit of measurement used for this quota dimension. </summary>
        public string Unit { get; }
        /// <summary> The standard unit of measurement used for this quota dimension in plural form. </summary>
        public string UnitPlural { get; }
    }
}
