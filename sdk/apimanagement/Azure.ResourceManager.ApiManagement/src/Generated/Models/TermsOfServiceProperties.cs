// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Terms of service contract properties. </summary>
    public partial class TermsOfServiceProperties
    {
        /// <summary> Initializes a new instance of TermsOfServiceProperties. </summary>
        public TermsOfServiceProperties()
        {
        }

        /// <summary> Initializes a new instance of TermsOfServiceProperties. </summary>
        /// <param name="text"> A terms of service text. </param>
        /// <param name="isDisplayEnabled"> Display terms of service during a sign-up process. </param>
        /// <param name="isConsentRequired"> Ask user for consent to the terms of service. </param>
        internal TermsOfServiceProperties(string text, bool? isDisplayEnabled, bool? isConsentRequired)
        {
            Text = text;
            IsDisplayEnabled = isDisplayEnabled;
            IsConsentRequired = isConsentRequired;
        }

        /// <summary> A terms of service text. </summary>
        public string Text { get; set; }
        /// <summary> Display terms of service during a sign-up process. </summary>
        public bool? IsDisplayEnabled { get; set; }
        /// <summary> Ask user for consent to the terms of service. </summary>
        public bool? IsConsentRequired { get; set; }
    }
}
