// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Radius Server Settings. </summary>
    public partial class RadiusServer
    {
        /// <summary> Initializes a new instance of RadiusServer. </summary>
        /// <param name="radiusServerAddress"> The address of this radius server. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="radiusServerAddress"/> is null. </exception>
        public RadiusServer(string radiusServerAddress)
        {
            if (radiusServerAddress == null)
            {
                throw new ArgumentNullException(nameof(radiusServerAddress));
            }

            RadiusServerAddress = radiusServerAddress;
        }

        /// <summary> Initializes a new instance of RadiusServer. </summary>
        /// <param name="radiusServerAddress"> The address of this radius server. </param>
        /// <param name="radiusServerScore"> The initial score assigned to this radius server. </param>
        /// <param name="radiusServerSecret"> The secret used for this radius server. </param>
        internal RadiusServer(string radiusServerAddress, long? radiusServerScore, string radiusServerSecret)
        {
            RadiusServerAddress = radiusServerAddress;
            RadiusServerScore = radiusServerScore;
            RadiusServerSecret = radiusServerSecret;
        }

        /// <summary> The address of this radius server. </summary>
        public string RadiusServerAddress { get; set; }
        /// <summary> The initial score assigned to this radius server. </summary>
        public long? RadiusServerScore { get; set; }
        /// <summary> The secret used for this radius server. </summary>
        public string RadiusServerSecret { get; set; }
    }
}
