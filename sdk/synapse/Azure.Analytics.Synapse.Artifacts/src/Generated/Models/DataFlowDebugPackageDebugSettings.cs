// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Data flow debug settings. </summary>
    public partial class DataFlowDebugPackageDebugSettings
    {
        /// <summary> Initializes a new instance of DataFlowDebugPackageDebugSettings. </summary>
        public DataFlowDebugPackageDebugSettings()
        {
            SourceSettings = new ChangeTrackingList<DataFlowSourceSetting>();
            Parameters = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Source setting for data flow debug. </summary>
        public IList<DataFlowSourceSetting> SourceSettings { get; }
        /// <summary> Data flow parameters. </summary>
        public IDictionary<string, object> Parameters { get; }
        /// <summary> Parameters for dataset. </summary>
        public object DatasetParameters { get; set; }
    }
}
