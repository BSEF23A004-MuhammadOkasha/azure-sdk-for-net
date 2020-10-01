// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> Legacy similarity algorithm which uses the Lucene TFIDFSimilarity implementation of TF-IDF. This variation of TF-IDF introduces static document length normalization as well as coordinating factors that penalize documents that only partially match the searched queries. </summary>
    public partial class ClassicSimilarity : SimilarityAlgorithm
    {
        /// <summary> Initializes a new instance of ClassicSimilarity. </summary>
        public ClassicSimilarity()
        {
            ODataType = "#Microsoft.Azure.Search.ClassicSimilarity";
        }

        /// <summary> Initializes a new instance of ClassicSimilarity. </summary>
        /// <param name="oDataType"> . </param>
        internal ClassicSimilarity(string oDataType) : base(oDataType)
        {
            ODataType = oDataType ?? "#Microsoft.Azure.Search.ClassicSimilarity";
        }
    }
}
