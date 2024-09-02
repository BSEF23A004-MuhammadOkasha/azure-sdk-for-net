// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// Data version base definition
    /// Please note <see cref="MachineLearningDataVersionProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="MachineLearningTable"/>, <see cref="MachineLearningUriFileDataVersion"/> and <see cref="MachineLearningUriFolderDataVersion"/>.
    /// </summary>
    public partial class MachineLearningDataVersionProperties : MachineLearningAssetBase
    {
        /// <summary> Initializes a new instance of <see cref="MachineLearningDataVersionProperties"/>. </summary>
        /// <param name="dataUri"> [Required] Uri of the data. Example: https://go.microsoft.com/fwlink/?linkid=2202330. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataUri"/> is null. </exception>
        public MachineLearningDataVersionProperties(Uri dataUri)
        {
            Argument.AssertNotNull(dataUri, nameof(dataUri));

            DataUri = dataUri;
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningDataVersionProperties"/>. </summary>
        /// <param name="description"> The asset description text. </param>
        /// <param name="tags"> Tag dictionary. Tags can be added, removed, and updated. </param>
        /// <param name="properties"> The asset property dictionary. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
<<<<<<< HEAD
        /// <param name="isArchived"> Is the asset archived?. </param>
        /// <param name="isAnonymous"> If the name version are system generated (anonymous registration). </param>
        /// <param name="dataType"> [Required] Specifies the type of data. </param>
        /// <param name="dataUri"> [Required] Uri of the data. Example: https://go.microsoft.com/fwlink/?linkid=2202330. </param>
        internal MachineLearningDataVersionProperties(string description, IDictionary<string, string> tags, IDictionary<string, string> properties, IDictionary<string, BinaryData> serializedAdditionalRawData, bool? isArchived, bool? isAnonymous, MachineLearningDataType dataType, Uri dataUri) : base(description, tags, properties, serializedAdditionalRawData, isArchived, isAnonymous)
=======
        /// <param name="isAnonymous"> If the name version are system generated (anonymous registration). </param>
        /// <param name="isArchived"> Is the asset archived?. </param>
        /// <param name="dataType"> [Required] Specifies the type of data. </param>
        /// <param name="dataUri"> [Required] Uri of the data. Example: https://go.microsoft.com/fwlink/?linkid=2202330. </param>
        internal MachineLearningDataVersionProperties(string description, IDictionary<string, string> properties, IDictionary<string, string> tags, IDictionary<string, BinaryData> serializedAdditionalRawData, bool? isAnonymous, bool? isArchived, MachineLearningDataType dataType, Uri dataUri) : base(description, properties, tags, serializedAdditionalRawData, isAnonymous, isArchived)
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
        {
            DataType = dataType;
            DataUri = dataUri;
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningDataVersionProperties"/> for deserialization. </summary>
        internal MachineLearningDataVersionProperties()
        {
        }

        /// <summary> [Required] Specifies the type of data. </summary>
        internal MachineLearningDataType DataType { get; set; }
        /// <summary> [Required] Uri of the data. Example: https://go.microsoft.com/fwlink/?linkid=2202330. </summary>
        public Uri DataUri { get; set; }
    }
}
