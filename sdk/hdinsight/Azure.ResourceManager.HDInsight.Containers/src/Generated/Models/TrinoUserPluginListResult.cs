// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> Trino user plugins spec. </summary>
    internal partial class TrinoUserPluginListResult
    {
        /// <summary> Initializes a new instance of TrinoUserPluginListResult. </summary>
        public TrinoUserPluginListResult()
        {
            Plugins = new ChangeTrackingList<TrinoUserPlugin>();
        }

        /// <summary> Initializes a new instance of TrinoUserPluginListResult. </summary>
        /// <param name="plugins"> Trino user plugins. </param>
        internal TrinoUserPluginListResult(IList<TrinoUserPlugin> plugins)
        {
            Plugins = plugins;
        }

        /// <summary> Trino user plugins. </summary>
        public IList<TrinoUserPlugin> Plugins { get; }
    }
}
