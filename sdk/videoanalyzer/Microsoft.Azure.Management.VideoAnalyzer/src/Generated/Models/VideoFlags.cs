// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.VideoAnalyzer.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Video flags contain information about the available video actions and
    /// its dynamic properties based on the current video state.
    /// </summary>
    public partial class VideoFlags
    {
        /// <summary>
        /// Initializes a new instance of the VideoFlags class.
        /// </summary>
        public VideoFlags()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VideoFlags class.
        /// </summary>
        /// <param name="canStream">Value indicating whether or not the video
        /// can be streamed. Only "archive" type videos can be
        /// streamed.</param>
        /// <param name="hasData">Value indicating whether or not there has
        /// ever been data recorded or uploaded into the video. Newly created
        /// videos have this value set to false.</param>
        /// <param name="isInUse">Value indicating whether or not the video is
        /// currently being referenced be an active pipeline. The fact that is
        /// being referenced, doesn't necessarily indicate that data is being
        /// received. For example, video recording may be gated on events or
        /// camera may not be accessible at the time.</param>
        public VideoFlags(bool canStream, bool hasData, bool isInUse)
        {
            CanStream = canStream;
            HasData = hasData;
            IsInUse = isInUse;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets value indicating whether or not the video can be
        /// streamed. Only "archive" type videos can be streamed.
        /// </summary>
        [JsonProperty(PropertyName = "canStream")]
        public bool CanStream { get; set; }

        /// <summary>
        /// Gets or sets value indicating whether or not there has ever been
        /// data recorded or uploaded into the video. Newly created videos have
        /// this value set to false.
        /// </summary>
        [JsonProperty(PropertyName = "hasData")]
        public bool HasData { get; set; }

        /// <summary>
        /// Gets or sets value indicating whether or not the video is currently
        /// being referenced be an active pipeline. The fact that is being
        /// referenced, doesn't necessarily indicate that data is being
        /// received. For example, video recording may be gated on events or
        /// camera may not be accessible at the time.
        /// </summary>
        [JsonProperty(PropertyName = "isInUse")]
        public bool IsInUse { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}
