// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Datadog.Models
{
    /// <summary> Terms properties. </summary>
    public partial class DatadogAgreementProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DatadogAgreementProperties"/>. </summary>
        public DatadogAgreementProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DatadogAgreementProperties"/>. </summary>
        /// <param name="publisher"> Publisher identifier string. </param>
        /// <param name="product"> Product identifier string. </param>
        /// <param name="plan"> Plan identifier string. </param>
        /// <param name="licenseTextLink"> Link to HTML with Microsoft and Publisher terms. </param>
        /// <param name="privacyPolicyLink"> Link to the privacy policy of the publisher. </param>
        /// <param name="retrieveDatetime"> Date and time in UTC of when the terms were accepted. This is empty if Accepted is false. </param>
        /// <param name="signature"> Terms signature. </param>
        /// <param name="accepted"> If any version of the terms have been accepted, otherwise false. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DatadogAgreementProperties(string publisher, string product, string plan, string licenseTextLink, string privacyPolicyLink, DateTimeOffset? retrieveDatetime, string signature, bool? accepted, Dictionary<string, BinaryData> rawData)
        {
            Publisher = publisher;
            Product = product;
            Plan = plan;
            LicenseTextLink = licenseTextLink;
            PrivacyPolicyLink = privacyPolicyLink;
            RetrieveDatetime = retrieveDatetime;
            Signature = signature;
            Accepted = accepted;
            _rawData = rawData;
        }

        /// <summary> Publisher identifier string. </summary>
        public string Publisher { get; set; }
        /// <summary> Product identifier string. </summary>
        public string Product { get; set; }
        /// <summary> Plan identifier string. </summary>
        public string Plan { get; set; }
        /// <summary> Link to HTML with Microsoft and Publisher terms. </summary>
        public string LicenseTextLink { get; set; }
        /// <summary> Link to the privacy policy of the publisher. </summary>
        public string PrivacyPolicyLink { get; set; }
        /// <summary> Date and time in UTC of when the terms were accepted. This is empty if Accepted is false. </summary>
        public DateTimeOffset? RetrieveDatetime { get; set; }
        /// <summary> Terms signature. </summary>
        public string Signature { get; set; }
        /// <summary> If any version of the terms have been accepted, otherwise false. </summary>
        public bool? Accepted { get; set; }
    }
}
