// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Consumption
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ChargesByBillingAccountOperations.
    /// </summary>
    public static partial class ChargesByBillingAccountOperationsExtensions
    {
            /// <summary>
            /// Lists the charges by billingAccountId for given start and end date. Start
            /// and end date are used to determine the billing period. For current month,
            /// the data will be provided from month to date. If there are no charges for a
            /// month then that month will show all zeroes.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/consumption/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountId'>
            /// BillingAccount ID
            /// </param>
            /// <param name='startDate'>
            /// Start date
            /// </param>
            /// <param name='endDate'>
            /// End date
            /// </param>
            /// <param name='apply'>
            /// May be used to group charges by properties/billingProfileId, or
            /// properties/invoiceSectionId.
            /// </param>
            public static ChargesListByBillingAccount List(this IChargesByBillingAccountOperations operations, string billingAccountId, string startDate, string endDate, string apply = default(string))
            {
                return operations.ListAsync(billingAccountId, startDate, endDate, apply).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the charges by billingAccountId for given start and end date. Start
            /// and end date are used to determine the billing period. For current month,
            /// the data will be provided from month to date. If there are no charges for a
            /// month then that month will show all zeroes.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/consumption/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountId'>
            /// BillingAccount ID
            /// </param>
            /// <param name='startDate'>
            /// Start date
            /// </param>
            /// <param name='endDate'>
            /// End date
            /// </param>
            /// <param name='apply'>
            /// May be used to group charges by properties/billingProfileId, or
            /// properties/invoiceSectionId.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ChargesListByBillingAccount> ListAsync(this IChargesByBillingAccountOperations operations, string billingAccountId, string startDate, string endDate, string apply = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(billingAccountId, startDate, endDate, apply, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
