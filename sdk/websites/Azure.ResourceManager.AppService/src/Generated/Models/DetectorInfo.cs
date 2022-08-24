// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary>
    /// Definition of Detector
    /// Serialized Name: DetectorInfo
    /// </summary>
    public partial class DetectorInfo
    {
        /// <summary> Initializes a new instance of DetectorInfo. </summary>
        public DetectorInfo()
        {
            SupportTopicList = new ChangeTrackingList<SupportTopic>();
            AnalysisType = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of DetectorInfo. </summary>
        /// <param name="id">
        /// Id of detector
        /// Serialized Name: DetectorInfo.id
        /// </param>
        /// <param name="name">
        /// Name of detector
        /// Serialized Name: DetectorInfo.name
        /// </param>
        /// <param name="description">
        /// Short description of the detector and its purpose.
        /// Serialized Name: DetectorInfo.description
        /// </param>
        /// <param name="author">
        /// Author of the detector.
        /// Serialized Name: DetectorInfo.author
        /// </param>
        /// <param name="category">
        /// Problem category. This serves for organizing group for detectors.
        /// Serialized Name: DetectorInfo.category
        /// </param>
        /// <param name="supportTopicList">
        /// List of Support Topics for which this detector is enabled.
        /// Serialized Name: DetectorInfo.supportTopicList
        /// </param>
        /// <param name="analysisType">
        /// Analysis Types for which this detector should apply to.
        /// Serialized Name: DetectorInfo.analysisType
        /// </param>
        /// <param name="detectorType">
        /// Whether this detector is an Analysis Detector or not.
        /// Serialized Name: DetectorInfo.type
        /// </param>
        /// <param name="score">
        /// Defines score of a detector to power ML based matching.
        /// Serialized Name: DetectorInfo.score
        /// </param>
        internal DetectorInfo(string id, string name, string description, string author, string category, IReadOnlyList<SupportTopic> supportTopicList, IReadOnlyList<string> analysisType, DetectorType? detectorType, float? score)
        {
            Id = id;
            Name = name;
            Description = description;
            Author = author;
            Category = category;
            SupportTopicList = supportTopicList;
            AnalysisType = analysisType;
            DetectorType = detectorType;
            Score = score;
        }

        /// <summary>
        /// Id of detector
        /// Serialized Name: DetectorInfo.id
        /// </summary>
        public string Id { get; }
        /// <summary>
        /// Name of detector
        /// Serialized Name: DetectorInfo.name
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// Short description of the detector and its purpose.
        /// Serialized Name: DetectorInfo.description
        /// </summary>
        public string Description { get; }
        /// <summary>
        /// Author of the detector.
        /// Serialized Name: DetectorInfo.author
        /// </summary>
        public string Author { get; }
        /// <summary>
        /// Problem category. This serves for organizing group for detectors.
        /// Serialized Name: DetectorInfo.category
        /// </summary>
        public string Category { get; }
        /// <summary>
        /// List of Support Topics for which this detector is enabled.
        /// Serialized Name: DetectorInfo.supportTopicList
        /// </summary>
        public IReadOnlyList<SupportTopic> SupportTopicList { get; }
        /// <summary>
        /// Analysis Types for which this detector should apply to.
        /// Serialized Name: DetectorInfo.analysisType
        /// </summary>
        public IReadOnlyList<string> AnalysisType { get; }
        /// <summary>
        /// Whether this detector is an Analysis Detector or not.
        /// Serialized Name: DetectorInfo.type
        /// </summary>
        public DetectorType? DetectorType { get; }
        /// <summary>
        /// Defines score of a detector to power ML based matching.
        /// Serialized Name: DetectorInfo.score
        /// </summary>
        public float? Score { get; }
    }
}
