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
    /// <summary> Sap Business Warehouse Open Hub Destination Table properties. </summary>
    public partial class SapOpenHubTableDataset : DataFactoryDatasetProperties
    {
        /// <summary> Initializes a new instance of <see cref="SapOpenHubTableDataset"/>. </summary>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="openHubDestinationName"> The name of the Open Hub Destination with destination type as Database Table. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="linkedServiceName"/> or <paramref name="openHubDestinationName"/> is null. </exception>
        public SapOpenHubTableDataset(DataFactoryLinkedServiceReference linkedServiceName, DataFactoryElement<string> openHubDestinationName) : base(linkedServiceName)
        {
            Argument.AssertNotNull(linkedServiceName, nameof(linkedServiceName));
            Argument.AssertNotNull(openHubDestinationName, nameof(openHubDestinationName));

            OpenHubDestinationName = openHubDestinationName;
            DatasetType = "SapOpenHubTable";
        }

        /// <summary> Initializes a new instance of <see cref="SapOpenHubTableDataset"/>. </summary>
        /// <param name="datasetType"> Type of dataset. </param>
        /// <param name="description"> Dataset description. </param>
        /// <param name="structure"> Columns that define the structure of the dataset. Type: array (or Expression with resultType array), itemType: DatasetDataElement. </param>
        /// <param name="schema"> Columns that define the physical type schema of the dataset. Type: array (or Expression with resultType array), itemType: DatasetSchemaDataElement. </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="parameters"> Parameters for dataset. </param>
        /// <param name="annotations"> List of tags that can be used for describing the Dataset. </param>
        /// <param name="folder"> The folder that this Dataset is in. If not specified, Dataset will appear at the root level. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="openHubDestinationName"> The name of the Open Hub Destination with destination type as Database Table. Type: string (or Expression with resultType string). </param>
        /// <param name="excludeLastRequest"> Whether to exclude the records of the last request. The default value is true. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="baseRequestId"> The ID of request for delta loading. Once it is set, only data with requestId larger than the value of this property will be retrieved. The default value is 0. Type: integer (or Expression with resultType integer ). </param>
        internal SapOpenHubTableDataset(string datasetType, string description, DataFactoryElement<IList<DatasetDataElement>> structure, DataFactoryElement<IList<DatasetSchemaDataElement>> schema, DataFactoryLinkedServiceReference linkedServiceName, IDictionary<string, EntityParameterSpecification> parameters, IList<BinaryData> annotations, DatasetFolder folder, IDictionary<string, BinaryData> additionalProperties, DataFactoryElement<string> openHubDestinationName, DataFactoryElement<bool> excludeLastRequest, DataFactoryElement<int> baseRequestId) : base(datasetType, description, structure, schema, linkedServiceName, parameters, annotations, folder, additionalProperties)
        {
            OpenHubDestinationName = openHubDestinationName;
            ExcludeLastRequest = excludeLastRequest;
            BaseRequestId = baseRequestId;
            DatasetType = datasetType ?? "SapOpenHubTable";
        }

        /// <summary> The name of the Open Hub Destination with destination type as Database Table. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> OpenHubDestinationName { get; set; }
        /// <summary> Whether to exclude the records of the last request. The default value is true. Type: boolean (or Expression with resultType boolean). </summary>
        public DataFactoryElement<bool> ExcludeLastRequest { get; set; }
        /// <summary> The ID of request for delta loading. Once it is set, only data with requestId larger than the value of this property will be retrieved. The default value is 0. Type: integer (or Expression with resultType integer ). </summary>
        public DataFactoryElement<int> BaseRequestId { get; set; }
    }
}
