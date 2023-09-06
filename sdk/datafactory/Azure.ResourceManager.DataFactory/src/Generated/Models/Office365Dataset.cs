// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> The Office365 account. </summary>
    public partial class Office365Dataset : DataFactoryDatasetProperties
    {
        /// <summary> Initializes a new instance of <see cref="Office365Dataset"/>. </summary>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="tableName"> Name of the dataset to extract from Office 365. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="linkedServiceName"/> or <paramref name="tableName"/> is null. </exception>
        public Office365Dataset(DataFactoryLinkedServiceReference linkedServiceName, DataFactoryElement<string> tableName) : base(linkedServiceName)
        {
            Argument.AssertNotNull(linkedServiceName, nameof(linkedServiceName));
            Argument.AssertNotNull(tableName, nameof(tableName));

            TableName = tableName;
            DatasetType = "Office365Table";
        }

        /// <summary> Initializes a new instance of <see cref="Office365Dataset"/>. </summary>
        /// <param name="datasetType"> Type of dataset. </param>
        /// <param name="description"> Dataset description. </param>
        /// <param name="structure"> Columns that define the structure of the dataset. Type: array (or Expression with resultType array), itemType: DatasetDataElement. </param>
        /// <param name="schema"> Columns that define the physical type schema of the dataset. Type: array (or Expression with resultType array), itemType: DatasetSchemaDataElement. </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="parameters"> Parameters for dataset. </param>
        /// <param name="annotations"> List of tags that can be used for describing the Dataset. </param>
        /// <param name="folder"> The folder that this Dataset is in. If not specified, Dataset will appear at the root level. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="tableName"> Name of the dataset to extract from Office 365. Type: string (or Expression with resultType string). </param>
        /// <param name="predicate"> A predicate expression that can be used to filter the specific rows to extract from Office 365. Type: string (or Expression with resultType string). </param>
        internal Office365Dataset(string datasetType, string description, DataFactoryElement<IList<DatasetDataElement>> structure, DataFactoryElement<IList<DatasetSchemaDataElement>> schema, DataFactoryLinkedServiceReference linkedServiceName, IDictionary<string, EntityParameterSpecification> parameters, IList<BinaryData> annotations, DatasetFolder folder, IDictionary<string, BinaryData> additionalProperties, DataFactoryElement<string> tableName, DataFactoryElement<string> predicate) : base(datasetType, description, structure, schema, linkedServiceName, parameters, annotations, folder, additionalProperties)
        {
            TableName = tableName;
            Predicate = predicate;
            DatasetType = datasetType ?? "Office365Table";
        }

        /// <summary> Initializes a new instance of <see cref="Office365Dataset"/> for deserialization. </summary>
        internal Office365Dataset()
        {
        }

        /// <summary> Name of the dataset to extract from Office 365. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> TableName { get; set; }
        /// <summary> A predicate expression that can be used to filter the specific rows to extract from Office 365. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Predicate { get; set; }
    }
}
