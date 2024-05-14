// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// The DataImportSource.
    /// Please note <see cref="DataImportSource"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="DatabaseSource"/> and <see cref="FileSystemSource"/>.
    /// </summary>
    public abstract partial class DataImportSource
    {
        /// <summary> Initializes a new instance of <see cref="DataImportSource"/>. </summary>
        protected DataImportSource()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DataImportSource"/>. </summary>
        /// <param name="connection"> Workspace connection for data import source storage. </param>
        /// <param name="sourceType"> [Required] Specifies the type of data. </param>
        internal DataImportSource(string connection, DataImportSourceType sourceType)
        {
            Connection = connection;
            SourceType = sourceType;
        }

        /// <summary> Workspace connection for data import source storage. </summary>
        public string Connection { get; set; }
        /// <summary> [Required] Specifies the type of data. </summary>
        internal DataImportSourceType SourceType { get; set; }
    }
}
