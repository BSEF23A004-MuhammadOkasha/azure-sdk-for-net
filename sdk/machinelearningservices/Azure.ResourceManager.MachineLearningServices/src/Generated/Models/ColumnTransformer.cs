// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> Column transformer parameters. </summary>
    public partial class ColumnTransformer
    {
        /// <summary> Initializes a new instance of ColumnTransformer. </summary>
        public ColumnTransformer()
        {
            Fields = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of ColumnTransformer. </summary>
        /// <param name="fields"> Fields to apply transformer logic on. </param>
        /// <param name="parameters">
        /// Different properties to be passed to transformer.
        /// Input expected is dictionary of key,value pairs in JSON format.
        /// </param>
        internal ColumnTransformer(IList<string> fields, object parameters)
        {
            Fields = fields;
            Parameters = parameters;
        }

        /// <summary> Fields to apply transformer logic on. </summary>
        public IList<string> Fields { get; set; }
        /// <summary>
        /// Different properties to be passed to transformer.
        /// Input expected is dictionary of key,value pairs in JSON format.
        /// </summary>
        public object Parameters { get; set; }
    }
}
