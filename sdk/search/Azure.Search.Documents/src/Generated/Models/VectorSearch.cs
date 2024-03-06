// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Search.Documents;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> Contains configuration options related to vector search. </summary>
    public partial class VectorSearch
    {
        /// <summary> Initializes a new instance of <see cref="VectorSearch"/>. </summary>
        public VectorSearch()
        {
            Profiles = new ChangeTrackingList<VectorSearchProfile>();
            Algorithms = new ChangeTrackingList<VectorSearchAlgorithmConfiguration>();
            Vectorizers = new ChangeTrackingList<VectorSearchVectorizer>();
            Compressions = new ChangeTrackingList<VectorSearchCompressionConfiguration>();
        }

        /// <summary> Initializes a new instance of <see cref="VectorSearch"/>. </summary>
        /// <param name="profiles"> Defines combinations of configurations to use with vector search. </param>
        /// <param name="algorithms">
        /// Contains configuration options specific to the algorithm used during indexing or querying.
        /// Please note <see cref="VectorSearchAlgorithmConfiguration"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ExhaustiveKnnAlgorithmConfiguration"/> and <see cref="HnswAlgorithmConfiguration"/>.
        /// </param>
        /// <param name="vectorizers">
        /// Contains configuration options on how to vectorize text vector queries.
        /// Please note <see cref="VectorSearchVectorizer"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureOpenAIVectorizer"/> and <see cref="CustomVectorizer"/>.
        /// </param>
        /// <param name="compressions">
        /// Contains configuration options specific to the compression method used during indexing or querying.
        /// Please note <see cref="VectorSearchCompressionConfiguration"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ScalarQuantizationCompressionConfiguration"/>.
        /// </param>
        internal VectorSearch(IList<VectorSearchProfile> profiles, IList<VectorSearchAlgorithmConfiguration> algorithms, IList<VectorSearchVectorizer> vectorizers, IList<VectorSearchCompressionConfiguration> compressions)
        {
            Profiles = profiles;
            Algorithms = algorithms;
            Vectorizers = vectorizers;
            Compressions = compressions;
        }

        /// <summary> Defines combinations of configurations to use with vector search. </summary>
        public IList<VectorSearchProfile> Profiles { get; }
        /// <summary>
        /// Contains configuration options specific to the algorithm used during indexing or querying.
        /// Please note <see cref="VectorSearchAlgorithmConfiguration"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ExhaustiveKnnAlgorithmConfiguration"/> and <see cref="HnswAlgorithmConfiguration"/>.
        /// </summary>
        public IList<VectorSearchAlgorithmConfiguration> Algorithms { get; }
        /// <summary>
        /// Contains configuration options on how to vectorize text vector queries.
        /// Please note <see cref="VectorSearchVectorizer"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureOpenAIVectorizer"/> and <see cref="CustomVectorizer"/>.
        /// </summary>
        public IList<VectorSearchVectorizer> Vectorizers { get; }
        /// <summary>
        /// Contains configuration options specific to the compression method used during indexing or querying.
        /// Please note <see cref="VectorSearchCompressionConfiguration"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ScalarQuantizationCompressionConfiguration"/>.
        /// </summary>
        public IList<VectorSearchCompressionConfiguration> Compressions { get; }
    }
}
