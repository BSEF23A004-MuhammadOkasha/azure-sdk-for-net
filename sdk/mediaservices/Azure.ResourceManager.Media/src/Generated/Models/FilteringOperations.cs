// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Media;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> Describes all the filtering operations, such as de-interlacing, rotation etc. that are to be applied to the input media before encoding. </summary>
    public partial class FilteringOperations
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="FilteringOperations"/>. </summary>
        public FilteringOperations()
        {
            Overlays = new ChangeTrackingList<MediaOverlayBase>();
        }

        /// <summary> Initializes a new instance of <see cref="FilteringOperations"/>. </summary>
        /// <param name="deinterlace"> The de-interlacing settings. </param>
        /// <param name="rotation"> The rotation, if any, to be applied to the input video, before it is encoded. Default is Auto. </param>
        /// <param name="crop"> The parameters for the rectangular window with which to crop the input video. </param>
        /// <param name="fadeIn"> Describes the properties of a Fade effect applied to the input media. </param>
        /// <param name="fadeOut"> Describes the properties of a Fade effect applied to the input media. </param>
        /// <param name="overlays">
        /// The properties of overlays to be applied to the input video. These could be audio, image or video overlays.
        /// Please note <see cref="MediaOverlayBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AudioOverlay"/> and <see cref="VideoOverlay"/>.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FilteringOperations(DeinterlaceSettings deinterlace, RotationSetting? rotation, RectangularWindow crop, FadeOptions fadeIn, FadeOptions fadeOut, IList<MediaOverlayBase> overlays, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Deinterlace = deinterlace;
            Rotation = rotation;
            Crop = crop;
            FadeIn = fadeIn;
            FadeOut = fadeOut;
            Overlays = overlays;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The de-interlacing settings. </summary>
        public DeinterlaceSettings Deinterlace { get; set; }
        /// <summary> The rotation, if any, to be applied to the input video, before it is encoded. Default is Auto. </summary>
        public RotationSetting? Rotation { get; set; }
        /// <summary> The parameters for the rectangular window with which to crop the input video. </summary>
        public RectangularWindow Crop { get; set; }
        /// <summary> Describes the properties of a Fade effect applied to the input media. </summary>
        public FadeOptions FadeIn { get; set; }
        /// <summary> Describes the properties of a Fade effect applied to the input media. </summary>
        public FadeOptions FadeOut { get; set; }
        /// <summary>
        /// The properties of overlays to be applied to the input video. These could be audio, image or video overlays.
        /// Please note <see cref="MediaOverlayBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AudioOverlay"/> and <see cref="VideoOverlay"/>.
        /// </summary>
        public IList<MediaOverlayBase> Overlays { get; }
    }
}
