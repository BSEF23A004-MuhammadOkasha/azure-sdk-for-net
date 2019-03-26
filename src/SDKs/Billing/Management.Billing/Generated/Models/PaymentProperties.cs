// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Billing.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The properties of the payment.
    /// </summary>
    public partial class PaymentProperties
    {
        /// <summary>
        /// Initializes a new instance of the PaymentProperties class.
        /// </summary>
        public PaymentProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PaymentProperties class.
        /// </summary>
        /// <param name="paymentType">The type of payment.</param>
        /// <param name="amount">The paid amount.</param>
        /// <param name="date">The date of the payment.</param>
        public PaymentProperties(string paymentType = default(string), Amount amount = default(Amount), System.DateTime? date = default(System.DateTime?))
        {
            PaymentType = paymentType;
            Amount = amount;
            Date = date;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the type of payment.
        /// </summary>
        [JsonProperty(PropertyName = "paymentType")]
        public string PaymentType { get; private set; }

        /// <summary>
        /// Gets the paid amount.
        /// </summary>
        [JsonProperty(PropertyName = "amount")]
        public Amount Amount { get; private set; }

        /// <summary>
        /// Gets the date of the payment.
        /// </summary>
        [JsonProperty(PropertyName = "date")]
        public System.DateTime? Date { get; private set; }

    }
}
