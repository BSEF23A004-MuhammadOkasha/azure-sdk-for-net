// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Billing
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using Newtonsoft.Json;

    /// <summary>
    /// Billing client provides access to billing resources for Azure
    /// subscriptions.
    /// </summary>
    public partial interface IBillingManagementClient : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Credentials needed for the client to connect to Azure.
        /// </summary>
        ServiceClientCredentials Credentials { get; }

        /// <summary>
        /// Version of the API to be used with the client request. The current
        /// version is 2018-11-01-preview.
        /// </summary>
        string ApiVersion { get; }

        /// <summary>
        /// Azure Subscription ID.
        /// </summary>
        string SubscriptionId { get; set; }

        /// <summary>
        /// The preferred language for the response.
        /// </summary>
        string AcceptLanguage { get; set; }

        /// <summary>
        /// The retry timeout in seconds for Long Running Operations. Default
        /// value is 30.
        /// </summary>
        int? LongRunningOperationRetryTimeout { get; set; }

        /// <summary>
        /// Whether a unique x-ms-client-request-id should be generated. When
        /// set to true a unique x-ms-client-request-id value is generated and
        /// included in each request. Default is true.
        /// </summary>
        bool? GenerateClientRequestId { get; set; }


        /// <summary>
        /// Gets the IBillingAccountsOperations.
        /// </summary>
        IBillingAccountsOperations BillingAccounts { get; }

        /// <summary>
        /// Gets the IAvailableBalancesOperations.
        /// </summary>
        IAvailableBalancesOperations AvailableBalances { get; }

        /// <summary>
        /// Gets the IPaymentMethodsOperations.
        /// </summary>
        IPaymentMethodsOperations PaymentMethods { get; }

        /// <summary>
        /// Gets the IBillingProfilesOperations.
        /// </summary>
        IBillingProfilesOperations BillingProfiles { get; }

        /// <summary>
        /// Gets the IInvoiceSectionsOperations.
        /// </summary>
        IInvoiceSectionsOperations InvoiceSections { get; }

        /// <summary>
        /// Gets the IDepartmentsOperations.
        /// </summary>
        IDepartmentsOperations Departments { get; }

        /// <summary>
        /// Gets the IEnrollmentAccountsOperations.
        /// </summary>
        IEnrollmentAccountsOperations EnrollmentAccounts { get; }

        /// <summary>
        /// Gets the IInvoicesOperations.
        /// </summary>
        IInvoicesOperations Invoices { get; }

        /// <summary>
        /// Gets the IPriceSheetOperations.
        /// </summary>
        IPriceSheetOperations PriceSheet { get; }

        /// <summary>
        /// Gets the IBillingSubscriptionsOperations.
        /// </summary>
        IBillingSubscriptionsOperations BillingSubscriptions { get; }

        /// <summary>
        /// Gets the IProductsOperations.
        /// </summary>
        IProductsOperations Products { get; }

        /// <summary>
        /// Gets the ITransactionsOperations.
        /// </summary>
        ITransactionsOperations Transactions { get; }

        /// <summary>
        /// Gets the IPoliciesOperations.
        /// </summary>
        IPoliciesOperations Policies { get; }

        /// <summary>
        /// Gets the IBillingPropertyOperations.
        /// </summary>
        IBillingPropertyOperations BillingProperty { get; }

        /// <summary>
        /// Gets the ITransfersOperations.
        /// </summary>
        ITransfersOperations Transfers { get; }

        /// <summary>
        /// Gets the IRecipientTransfersOperations.
        /// </summary>
        IRecipientTransfersOperations RecipientTransfers { get; }

        /// <summary>
        /// Gets the IOperations.
        /// </summary>
        IOperations Operations { get; }

        /// <summary>
        /// Gets the IBillingPermissionsOperations.
        /// </summary>
        IBillingPermissionsOperations BillingPermissions { get; }

        /// <summary>
        /// Gets the IBillingRoleDefinitionsOperations.
        /// </summary>
        IBillingRoleDefinitionsOperations BillingRoleDefinitions { get; }

        /// <summary>
        /// Gets the IBillingRoleAssignmentsOperations.
        /// </summary>
        IBillingRoleAssignmentsOperations BillingRoleAssignments { get; }

        /// <summary>
        /// Gets the IAgreementsOperations.
        /// </summary>
        IAgreementsOperations Agreements { get; }

    }
}
