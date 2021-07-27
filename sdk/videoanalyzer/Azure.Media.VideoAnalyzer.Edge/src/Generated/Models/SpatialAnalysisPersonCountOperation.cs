// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> Defines a Spatial Analysis person count operation. This requires the Azure Cognitive Services Spatial analysis module to be deployed alongside the Video Analyzer module, please see https://aka.ms/ava-spatial-analysis for more information. </summary>
    public partial class SpatialAnalysisPersonCountOperation : SpatialAnalysisTypedOperationBase
    {
        /// <summary> Initializes a new instance of SpatialAnalysisPersonCountOperation. </summary>
        /// <param name="zones"> The list of zones and optional events. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="zones"/> is null. </exception>
        public SpatialAnalysisPersonCountOperation(IEnumerable<SpatialAnalysisPersonCountZoneEvents> zones)
        {
            if (zones == null)
            {
                throw new ArgumentNullException(nameof(zones));
            }

            Zones = zones.ToList();
            Type = "#Microsoft.VideoAnalyzer.SpatialAnalysisPersonCountOperation";
        }

        /// <summary> Initializes a new instance of SpatialAnalysisPersonCountOperation. </summary>
        /// <param name="type"> The Type discriminator for the derived types. </param>
        /// <param name="debug"> If set to &apos;true&apos;, enables debugging mode for this operation. </param>
        /// <param name="cameraConfiguration"> Advanced camera configuration. </param>
        /// <param name="detectorNodeConfiguration"> Advanced detector node configuration. </param>
        /// <param name="enableFaceMaskClassifier"> If set to &apos;true&apos;, enables face mask detection for this operation. </param>
        /// <param name="zones"> The list of zones and optional events. </param>
        internal SpatialAnalysisPersonCountOperation(string type, string debug, string cameraConfiguration, string detectorNodeConfiguration, string enableFaceMaskClassifier, IList<SpatialAnalysisPersonCountZoneEvents> zones) : base(type, debug, cameraConfiguration, detectorNodeConfiguration, enableFaceMaskClassifier)
        {
            Zones = zones;
            Type = type ?? "#Microsoft.VideoAnalyzer.SpatialAnalysisPersonCountOperation";
        }

        /// <summary> The list of zones and optional events. </summary>
        public IList<SpatialAnalysisPersonCountZoneEvents> Zones { get; }
    }
}
