// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Communication.PhoneNumbers
{
    /// <summary> Represents a search request for operator information for the given phone numbers. </summary>
    internal partial class OperatorInformationRequest
    {
        /// <summary> Initializes a new instance of <see cref="OperatorInformationRequest"/>. </summary>
        public OperatorInformationRequest()
        {
            PhoneNumbers = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="OperatorInformationRequest"/>. </summary>
        /// <param name="phoneNumbers"> Phone number(s) whose operator information is being requested. </param>
        internal OperatorInformationRequest(IList<string> phoneNumbers)
        {
            PhoneNumbers = phoneNumbers;
        }

        /// <summary> Phone number(s) whose operator information is being requested. </summary>
        public IList<string> PhoneNumbers { get; }
    }
}
