// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Communication.ShortCodes.Models
{
    /// <summary> The ProgramDetails. </summary>
    public partial class ProgramDetails
    {
        /// <summary> Initializes a new instance of ProgramDetails. </summary>
        public ProgramDetails()
        {
            PreferredVanityNumbers = new ChangeTrackingList<string>();
            SignUpTypes = new ChangeTrackingList<ProgramSignUpType>();
        }

        /// <summary> Initializes a new instance of ProgramDetails. </summary>
        /// <param name="isVanity"> Set to true if the request is for a vanity number. </param>
        /// <param name="preferredVanityNumbers">
        /// Priority ordered list of preferred vanity numbers.
        /// Vanity numbers should be 5 or 6 digit when number type is ShortCode.
        /// e.g. 555555, 222222.
        /// </param>
        /// <param name="numberType"> Type for desired numbers e.g. &apos;shortCode&apos; or &apos;alphaId&apos;. </param>
        /// <param name="isPoliticalCampaign"> Indicates whether the number will be used for political campaigns or not. </param>
        /// <param name="name">
        /// A program name that indicates the purpose of filling the Program Brief and how the number will be used for messaging.
        /// e.g. &apos;CONTOSO Shipping&apos;
        /// </param>
        /// <param name="description"> Describes how and why the number will be used for messaging as part of the program. </param>
        /// <param name="url"> URL for the program or company. </param>
        /// <param name="signUpTypes"> Indicates how the consumer can sign up to the program e.g. &apos;website&apos;, &apos;pointOfSale&apos; and/or &apos;sms&apos;. </param>
        /// <param name="signUpUrl"> URL for &quot;call to action&quot; image for the program. </param>
        /// <param name="termsOfServiceUrl"> URL for program terms of service. </param>
        /// <param name="privacyPolicyUrl"> URL for privacy policy. </param>
        /// <param name="expectedDateOfService">
        /// Date in which SMS messages will start to be sent out.
        /// Should follow ISO 8601 internet format for datetimes.
        /// e.g. 2021-08-17T22:02:51.316Z, 2021-08-17T16:39:57-08:00, etc.
        /// </param>
        internal ProgramDetails(bool? isVanity, IList<string> preferredVanityNumbers, NumberType? numberType, bool? isPoliticalCampaign, string name, string description, string url, IList<ProgramSignUpType> signUpTypes, string signUpUrl, string termsOfServiceUrl, string privacyPolicyUrl, DateTimeOffset? expectedDateOfService)
        {
            IsVanity = isVanity;
            PreferredVanityNumbers = preferredVanityNumbers;
            NumberType = numberType;
            IsPoliticalCampaign = isPoliticalCampaign;
            Name = name;
            Description = description;
            Url = url;
            SignUpTypes = signUpTypes;
            SignUpUrl = signUpUrl;
            TermsOfServiceUrl = termsOfServiceUrl;
            PrivacyPolicyUrl = privacyPolicyUrl;
            ExpectedDateOfService = expectedDateOfService;
        }

        /// <summary> Set to true if the request is for a vanity number. </summary>
        public bool? IsVanity { get; set; }
        /// <summary>
        /// Priority ordered list of preferred vanity numbers.
        /// Vanity numbers should be 5 or 6 digit when number type is ShortCode.
        /// e.g. 555555, 222222.
        /// </summary>
        public IList<string> PreferredVanityNumbers { get; }
        /// <summary> Type for desired numbers e.g. &apos;shortCode&apos; or &apos;alphaId&apos;. </summary>
        public NumberType? NumberType { get; set; }
        /// <summary> Indicates whether the number will be used for political campaigns or not. </summary>
        public bool? IsPoliticalCampaign { get; set; }
        /// <summary>
        /// A program name that indicates the purpose of filling the Program Brief and how the number will be used for messaging.
        /// e.g. &apos;CONTOSO Shipping&apos;
        /// </summary>
        public string Name { get; set; }
        /// <summary> Describes how and why the number will be used for messaging as part of the program. </summary>
        public string Description { get; set; }
        /// <summary> URL for the program or company. </summary>
        public string Url { get; set; }
        /// <summary> Indicates how the consumer can sign up to the program e.g. &apos;website&apos;, &apos;pointOfSale&apos; and/or &apos;sms&apos;. </summary>
        public IList<ProgramSignUpType> SignUpTypes { get; }
        /// <summary> URL for &quot;call to action&quot; image for the program. </summary>
        public string SignUpUrl { get; set; }
        /// <summary> URL for program terms of service. </summary>
        public string TermsOfServiceUrl { get; set; }
        /// <summary> URL for privacy policy. </summary>
        public string PrivacyPolicyUrl { get; set; }
        /// <summary>
        /// Date in which SMS messages will start to be sent out.
        /// Should follow ISO 8601 internet format for datetimes.
        /// e.g. 2021-08-17T22:02:51.316Z, 2021-08-17T16:39:57-08:00, etc.
        /// </summary>
        public DateTimeOffset? ExpectedDateOfService { get; set; }
    }
}
