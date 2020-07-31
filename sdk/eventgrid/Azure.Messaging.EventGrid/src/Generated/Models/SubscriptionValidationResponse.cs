// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Messaging.EventGrid.Models.SystemEvents
{
    /// <summary> To complete an event subscription validation handshake, a subscriber can use either the validationCode or the validationUrl received in a SubscriptionValidationEvent. When the validationCode is used, the SubscriptionValidationResponse can be used to build the response. </summary>
    public partial class SubscriptionValidationResponse
    {
        /// <summary> Initializes a new instance of SubscriptionValidationResponse. </summary>
        internal SubscriptionValidationResponse()
        {
        }

        /// <summary> Initializes a new instance of SubscriptionValidationResponse. </summary>
        /// <param name="validationResponse"> The validation response sent by the subscriber to Azure Event Grid to complete the validation of an event subscription. </param>
        internal SubscriptionValidationResponse(string validationResponse)
        {
            ValidationResponse = validationResponse;
        }

        /// <summary> The validation response sent by the subscriber to Azure Event Grid to complete the validation of an event subscription. </summary>
        public string ValidationResponse { get; }
    }
}
