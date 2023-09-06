// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CostManagement.Models
{
    /// <summary> The order by expression to be used in the report. </summary>
    public partial class ReportConfigSorting
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ReportConfigSorting"/>. </summary>
        /// <param name="name"> The name of the column to sort. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public ReportConfigSorting(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="ReportConfigSorting"/>. </summary>
        /// <param name="direction"> Direction of sort. </param>
        /// <param name="name"> The name of the column to sort. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ReportConfigSorting(ReportConfigSortingType? direction, string name, Dictionary<string, BinaryData> rawData)
        {
            Direction = direction;
            Name = name;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="ReportConfigSorting"/> for deserialization. </summary>
        internal ReportConfigSorting()
        {
        }

        /// <summary> Direction of sort. </summary>
        public ReportConfigSortingType? Direction { get; set; }
        /// <summary> The name of the column to sort. </summary>
        public string Name { get; set; }
    }
}
