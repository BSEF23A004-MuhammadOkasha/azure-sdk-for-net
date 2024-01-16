// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.PhoneNumbers
{
    /// <summary> Capabilities of a phone number. </summary>
    public partial class PurchasedPhoneNumberCapabilities
    {
        /// <summary> Initializes a new instance of <see cref="PurchasedPhoneNumberCapabilities"/>. </summary>
        /// <param name="calling"> Capability value for calling. </param>
        /// <param name="sms"> Capability value for SMS. </param>
        internal PurchasedPhoneNumberCapabilities(PhoneNumberCapabilityType calling, PhoneNumberCapabilityType sms)
        {
            Calling = calling;
            Sms = sms;
        }

        /// <summary> Initializes a new instance of <see cref="PurchasedPhoneNumberCapabilities"/>. </summary>
        /// <param name="calling"> Capability value for calling. </param>
        /// <param name="sms"> Capability value for SMS. </param>
        /// <param name="tenDLCCampaignBriefId"> Ten DLC campaign brief id attached to the number. </param>
        internal PurchasedPhoneNumberCapabilities(PhoneNumberCapabilityType calling, PhoneNumberCapabilityType sms, string tenDLCCampaignBriefId)
        {
            Calling = calling;
            Sms = sms;
            TenDLCCampaignBriefId = tenDLCCampaignBriefId;
        }

        /// <summary> Capability value for calling. </summary>
        public PhoneNumberCapabilityType Calling { get; }
        /// <summary> Capability value for SMS. </summary>
        public PhoneNumberCapabilityType Sms { get; }
        /// <summary> Ten DLC campaign brief id attached to the number. </summary>
        public string TenDLCCampaignBriefId { get; }
    }
}
