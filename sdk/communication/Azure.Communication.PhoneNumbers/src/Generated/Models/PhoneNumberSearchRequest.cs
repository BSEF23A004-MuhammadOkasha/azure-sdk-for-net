// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Communication.PhoneNumbers
{
    /// <summary> Represents a phone number search request to find phone numbers. Found phone numbers are temporarily held for a following purchase. </summary>
    internal partial class PhoneNumberSearchRequest
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PhoneNumberSearchRequest"/>. </summary>
        /// <param name="phoneNumberType"> The type of phone numbers to search for, e.g. geographic, or tollFree. </param>
        /// <param name="assignmentType"> The assignment type of the phone numbers to search for. A phone number can be assigned to a person, or to an application. </param>
        /// <param name="capabilities"> Capabilities of a phone number. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="capabilities"/> is null. </exception>
        public PhoneNumberSearchRequest(PhoneNumberType phoneNumberType, PhoneNumberAssignmentType assignmentType, PhoneNumberCapabilities capabilities)
        {
            Argument.AssertNotNull(capabilities, nameof(capabilities));

            PhoneNumberType = phoneNumberType;
            AssignmentType = assignmentType;
            Capabilities = capabilities;
        }

        /// <summary> Initializes a new instance of <see cref="PhoneNumberSearchRequest"/>. </summary>
        /// <param name="phoneNumberType"> The type of phone numbers to search for, e.g. geographic, or tollFree. </param>
        /// <param name="assignmentType"> The assignment type of the phone numbers to search for. A phone number can be assigned to a person, or to an application. </param>
        /// <param name="capabilities"> Capabilities of a phone number. </param>
        /// <param name="areaCode"> The area code of the desired phone number, e.g. 425. </param>
        /// <param name="quantity"> The quantity of desired phone numbers. The default value is 1. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PhoneNumberSearchRequest(PhoneNumberType phoneNumberType, PhoneNumberAssignmentType assignmentType, PhoneNumberCapabilities capabilities, string areaCode, int? quantity, Dictionary<string, BinaryData> rawData)
        {
            PhoneNumberType = phoneNumberType;
            AssignmentType = assignmentType;
            Capabilities = capabilities;
            AreaCode = areaCode;
            Quantity = quantity;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="PhoneNumberSearchRequest"/> for deserialization. </summary>
        internal PhoneNumberSearchRequest()
        {
        }

        /// <summary> The type of phone numbers to search for, e.g. geographic, or tollFree. </summary>
        public PhoneNumberType PhoneNumberType { get; }
        /// <summary> The assignment type of the phone numbers to search for. A phone number can be assigned to a person, or to an application. </summary>
        public PhoneNumberAssignmentType AssignmentType { get; }
        /// <summary> Capabilities of a phone number. </summary>
        public PhoneNumberCapabilities Capabilities { get; }
        /// <summary> The area code of the desired phone number, e.g. 425. </summary>
        public string AreaCode { get; set; }
        /// <summary> The quantity of desired phone numbers. The default value is 1. </summary>
        public int? Quantity { get; set; }
    }
}
