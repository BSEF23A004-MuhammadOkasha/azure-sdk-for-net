// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Logic.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The AS2 agreement security settings.
    /// </summary>
    public partial class AS2SecuritySettings
    {
        /// <summary>
        /// Initializes a new instance of the AS2SecuritySettings class.
        /// </summary>
        public AS2SecuritySettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AS2SecuritySettings class.
        /// </summary>
        /// <param name="overrideGroupSigningCertificate">The value indicating
        /// whether to send or request a MDN.</param>
        /// <param name="enableNRRForInboundEncodedMessages">The value
        /// indicating whether to enable NRR for inbound encoded
        /// messages.</param>
        /// <param name="enableNRRForInboundDecodedMessages">The value
        /// indicating whether to enable NRR for inbound decoded
        /// messages.</param>
        /// <param name="enableNRRForOutboundMDN">The value indicating whether
        /// to enable NRR for outbound MDN.</param>
        /// <param name="enableNRRForOutboundEncodedMessages">The value
        /// indicating whether to enable NRR for outbound encoded
        /// messages.</param>
        /// <param name="enableNRRForOutboundDecodedMessages">The value
        /// indicating whether to enable NRR for outbound decoded
        /// messages.</param>
        /// <param name="enableNRRForInboundMDN">The value indicating whether
        /// to enable NRR for inbound MDN.</param>
        /// <param name="signingCertificateName">The name of the signing
        /// certificate.</param>
        /// <param name="encryptionCertificateName">The name of the encryption
        /// certificate.</param>
        /// <param name="sha2AlgorithmFormat">The Sha2 algorithm format. Valid
        /// values are Sha2, ShaHashSize, ShaHyphenHashSize,
        /// Sha2UnderscoreHashSize.</param>
        public AS2SecuritySettings(bool overrideGroupSigningCertificate, bool enableNRRForInboundEncodedMessages, bool enableNRRForInboundDecodedMessages, bool enableNRRForOutboundMDN, bool enableNRRForOutboundEncodedMessages, bool enableNRRForOutboundDecodedMessages, bool enableNRRForInboundMDN, string signingCertificateName = default(string), string encryptionCertificateName = default(string), string sha2AlgorithmFormat = default(string))
        {
            OverrideGroupSigningCertificate = overrideGroupSigningCertificate;
            SigningCertificateName = signingCertificateName;
            EncryptionCertificateName = encryptionCertificateName;
            EnableNRRForInboundEncodedMessages = enableNRRForInboundEncodedMessages;
            EnableNRRForInboundDecodedMessages = enableNRRForInboundDecodedMessages;
            EnableNRRForOutboundMDN = enableNRRForOutboundMDN;
            EnableNRRForOutboundEncodedMessages = enableNRRForOutboundEncodedMessages;
            EnableNRRForOutboundDecodedMessages = enableNRRForOutboundDecodedMessages;
            EnableNRRForInboundMDN = enableNRRForInboundMDN;
            Sha2AlgorithmFormat = sha2AlgorithmFormat;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the value indicating whether to send or request a MDN.
        /// </summary>
        [JsonProperty(PropertyName = "overrideGroupSigningCertificate")]
        public bool OverrideGroupSigningCertificate { get; set; }

        /// <summary>
        /// Gets or sets the name of the signing certificate.
        /// </summary>
        [JsonProperty(PropertyName = "signingCertificateName")]
        public string SigningCertificateName { get; set; }

        /// <summary>
        /// Gets or sets the name of the encryption certificate.
        /// </summary>
        [JsonProperty(PropertyName = "encryptionCertificateName")]
        public string EncryptionCertificateName { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether to enable NRR for inbound
        /// encoded messages.
        /// </summary>
        [JsonProperty(PropertyName = "enableNRRForInboundEncodedMessages")]
        public bool EnableNRRForInboundEncodedMessages { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether to enable NRR for inbound
        /// decoded messages.
        /// </summary>
        [JsonProperty(PropertyName = "enableNRRForInboundDecodedMessages")]
        public bool EnableNRRForInboundDecodedMessages { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether to enable NRR for
        /// outbound MDN.
        /// </summary>
        [JsonProperty(PropertyName = "enableNRRForOutboundMDN")]
        public bool EnableNRRForOutboundMDN { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether to enable NRR for
        /// outbound encoded messages.
        /// </summary>
        [JsonProperty(PropertyName = "enableNRRForOutboundEncodedMessages")]
        public bool EnableNRRForOutboundEncodedMessages { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether to enable NRR for
        /// outbound decoded messages.
        /// </summary>
        [JsonProperty(PropertyName = "enableNRRForOutboundDecodedMessages")]
        public bool EnableNRRForOutboundDecodedMessages { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether to enable NRR for inbound
        /// MDN.
        /// </summary>
        [JsonProperty(PropertyName = "enableNRRForInboundMDN")]
        public bool EnableNRRForInboundMDN { get; set; }

        /// <summary>
        /// Gets or sets the Sha2 algorithm format. Valid values are Sha2,
        /// ShaHashSize, ShaHyphenHashSize, Sha2UnderscoreHashSize.
        /// </summary>
        [JsonProperty(PropertyName = "sha2AlgorithmFormat")]
        public string Sha2AlgorithmFormat { get; set; }

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
