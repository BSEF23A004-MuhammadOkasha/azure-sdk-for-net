// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Orbital.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Contact Profile link
    /// </summary>
    public partial class ContactProfileLink
    {
        /// <summary>
        /// Initializes a new instance of the ContactProfileLink class.
        /// </summary>
        public ContactProfileLink()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ContactProfileLink class.
        /// </summary>
        /// <param name="polarization">polarization. eg (RHCP, LHCP). Possible
        /// values include: 'RHCP', 'LHCP', 'dualRhcpLhcp', 'linearVertical',
        /// 'linearHorizontal'</param>
        /// <param name="direction">Direction (uplink or downlink). Possible
        /// values include: 'uplink', 'downlink'</param>
        /// <param name="channels">Contact Profile Link Channel</param>
        /// <param name="gainOverTemperature">Gain To Noise Temperature in
        /// db/K.</param>
        /// <param name="eirpdBW">Effective Isotropic Radiated Power (EIRP) in
        /// dBW.</param>
        public ContactProfileLink(string polarization, string direction, IList<ContactProfileLinkChannel> channels, double? gainOverTemperature = default(double?), double? eirpdBW = default(double?))
        {
            Polarization = polarization;
            Direction = direction;
            GainOverTemperature = gainOverTemperature;
            EirpdBW = eirpdBW;
            Channels = channels;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets polarization. eg (RHCP, LHCP). Possible values
        /// include: 'RHCP', 'LHCP', 'dualRhcpLhcp', 'linearVertical',
        /// 'linearHorizontal'
        /// </summary>
        [JsonProperty(PropertyName = "polarization")]
        public string Polarization { get; set; }

        /// <summary>
        /// Gets or sets direction (uplink or downlink). Possible values
        /// include: 'uplink', 'downlink'
        /// </summary>
        [JsonProperty(PropertyName = "direction")]
        public string Direction { get; set; }

        /// <summary>
        /// Gets or sets gain To Noise Temperature in db/K.
        /// </summary>
        [JsonProperty(PropertyName = "gainOverTemperature")]
        public double? GainOverTemperature { get; set; }

        /// <summary>
        /// Gets or sets effective Isotropic Radiated Power (EIRP) in dBW.
        /// </summary>
        [JsonProperty(PropertyName = "eirpdBW")]
        public double? EirpdBW { get; set; }

        /// <summary>
        /// Gets or sets contact Profile Link Channel
        /// </summary>
        [JsonProperty(PropertyName = "channels")]
        public IList<ContactProfileLinkChannel> Channels { get; set; }

    }
}
