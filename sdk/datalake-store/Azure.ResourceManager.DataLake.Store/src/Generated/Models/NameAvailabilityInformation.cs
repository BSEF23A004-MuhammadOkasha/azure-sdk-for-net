// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataLake.Store.Models
{
    /// <summary> Data Lake Store account name availability result information. </summary>
    public partial class NameAvailabilityInformation
    {
        /// <summary> Initializes a new instance of NameAvailabilityInformation. </summary>
        internal NameAvailabilityInformation()
        {
        }

        /// <summary> Initializes a new instance of NameAvailabilityInformation. </summary>
        /// <param name="nameAvailable"> The Boolean value of true or false to indicate whether the Data Lake Store account name is available or not. </param>
        /// <param name="reason"> The reason why the Data Lake Store account name is not available, if nameAvailable is false. </param>
        /// <param name="message"> The message describing why the Data Lake Store account name is not available, if nameAvailable is false. </param>
        internal NameAvailabilityInformation(bool? nameAvailable, string reason, string message)
        {
            NameAvailable = nameAvailable;
            Reason = reason;
            Message = message;
        }

        /// <summary> The Boolean value of true or false to indicate whether the Data Lake Store account name is available or not. </summary>
        public bool? NameAvailable { get; }
        /// <summary> The reason why the Data Lake Store account name is not available, if nameAvailable is false. </summary>
        public string Reason { get; }
        /// <summary> The message describing why the Data Lake Store account name is not available, if nameAvailable is false. </summary>
        public string Message { get; }
    }
}
