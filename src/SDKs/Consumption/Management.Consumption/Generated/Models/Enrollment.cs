// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Consumption.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Current entity level details
    /// </summary>
    public partial class Enrollment
    {
        /// <summary>
        /// Initializes a new instance of the Enrollment class.
        /// </summary>
        public Enrollment()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Enrollment class.
        /// </summary>
        /// <param name="startDate">Enrollment Start Date</param>
        /// <param name="endDate">Enrollment End Date</param>
        /// <param name="currency">The currency associated with
        /// enrollment</param>
        /// <param name="channel">The channel for Enrollment</param>
        /// <param name="policies">The attributes associated with legacy
        /// enrollment.</param>
        /// <param name="language">The language for Enrollment</param>
        /// <param name="countryCode">The countryCode for Enrollment</param>
        /// <param name="status">Enrollment status</param>
        /// <param name="billingCycle">Enrollment billing cycle</param>
        public Enrollment(System.DateTime? startDate = default(System.DateTime?), System.DateTime? endDate = default(System.DateTime?), string currency = default(string), string channel = default(string), EnrollmentPolicies policies = default(EnrollmentPolicies), string language = default(string), string countryCode = default(string), string status = default(string), string billingCycle = default(string))
        {
            StartDate = startDate;
            EndDate = endDate;
            Currency = currency;
            Channel = channel;
            Policies = policies;
            Language = language;
            CountryCode = countryCode;
            Status = status;
            BillingCycle = billingCycle;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets enrollment Start Date
        /// </summary>
        [JsonProperty(PropertyName = "startDate")]
        public System.DateTime? StartDate { get; private set; }

        /// <summary>
        /// Gets enrollment End Date
        /// </summary>
        [JsonProperty(PropertyName = "endDate")]
        public System.DateTime? EndDate { get; private set; }

        /// <summary>
        /// Gets the currency associated with enrollment
        /// </summary>
        [JsonProperty(PropertyName = "currency")]
        public string Currency { get; private set; }

        /// <summary>
        /// Gets the channel for Enrollment
        /// </summary>
        [JsonProperty(PropertyName = "channel")]
        public string Channel { get; private set; }

        /// <summary>
        /// Gets the attributes associated with legacy enrollment.
        /// </summary>
        [JsonProperty(PropertyName = "policies")]
        public EnrollmentPolicies Policies { get; private set; }

        /// <summary>
        /// Gets the language for Enrollment
        /// </summary>
        [JsonProperty(PropertyName = "language")]
        public string Language { get; private set; }

        /// <summary>
        /// Gets the countryCode for Enrollment
        /// </summary>
        [JsonProperty(PropertyName = "countryCode")]
        public string CountryCode { get; private set; }

        /// <summary>
        /// Gets enrollment status
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; private set; }

        /// <summary>
        /// Gets enrollment billing cycle
        /// </summary>
        [JsonProperty(PropertyName = "billingCycle")]
        public string BillingCycle { get; private set; }

    }
}
