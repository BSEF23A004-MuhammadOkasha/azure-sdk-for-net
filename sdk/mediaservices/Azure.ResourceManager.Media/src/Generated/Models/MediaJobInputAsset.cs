// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> Represents an Asset for input into a Job. </summary>
    public partial class MediaJobInputAsset : MediaJobInputClip
    {
        /// <summary> Initializes a new instance of MediaJobInputAsset. </summary>
        /// <param name="assetName"> The name of the input Asset. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="assetName"/> is null. </exception>
        public MediaJobInputAsset(string assetName)
        {
            if (assetName == null)
            {
                throw new ArgumentNullException(nameof(assetName));
            }

            AssetName = assetName;
            OdataType = "#Microsoft.Media.JobInputAsset";
        }

        /// <summary> Initializes a new instance of MediaJobInputAsset. </summary>
        /// <param name="odataType"> The discriminator for derived types. </param>
        /// <param name="files"> List of files. Required for JobInputHttp. Maximum of 4000 characters each. Query strings will not be returned in service responses to prevent sensitive data exposure. </param>
        /// <param name="start">
        /// Defines a point on the timeline of the input media at which processing will start. Defaults to the beginning of the input media.
        /// Please note <see cref="ClipTime"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AbsoluteClipTime"/> and <see cref="UtcClipTime"/>.
        /// </param>
        /// <param name="end">
        /// Defines a point on the timeline of the input media at which processing will end. Defaults to the end of the input media.
        /// Please note <see cref="ClipTime"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AbsoluteClipTime"/> and <see cref="UtcClipTime"/>.
        /// </param>
        /// <param name="label"> A label that is assigned to a JobInputClip, that is used to satisfy a reference used in the Transform. For example, a Transform can be authored so as to take an image file with the label &apos;xyz&apos; and apply it as an overlay onto the input video before it is encoded. When submitting a Job, exactly one of the JobInputs should be the image file, and it should have the label &apos;xyz&apos;. </param>
        /// <param name="inputDefinitions">
        /// Defines a list of InputDefinitions. For each InputDefinition, it defines a list of track selections and related metadata.
        /// Please note <see cref="MediaJobInputDefinition"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="FromAllInputFile"/>, <see cref="FromEachInputFile"/> and <see cref="MediaJobInputFile"/>.
        /// </param>
        /// <param name="assetName"> The name of the input Asset. </param>
        internal MediaJobInputAsset(string odataType, IList<string> files, ClipTime start, ClipTime end, string label, IList<MediaJobInputDefinition> inputDefinitions, string assetName) : base(odataType, files, start, end, label, inputDefinitions)
        {
            AssetName = assetName;
            OdataType = odataType ?? "#Microsoft.Media.JobInputAsset";
        }

        /// <summary> The name of the input Asset. </summary>
        public string AssetName { get; set; }
    }
}
