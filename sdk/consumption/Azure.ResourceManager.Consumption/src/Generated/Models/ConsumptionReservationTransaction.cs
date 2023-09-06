// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Consumption.Models
{
    /// <summary> Reservation transaction resource. </summary>
    public partial class ConsumptionReservationTransaction : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ConsumptionReservationTransaction"/>. </summary>
        internal ConsumptionReservationTransaction()
        {
            Tags = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="ConsumptionReservationTransaction"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="transactOn"> The date of the transaction. </param>
        /// <param name="reservationOrderId"> The reservation order ID is the identifier for a reservation purchase. Each reservation order ID represents a single purchase transaction. A reservation order contains reservations. The reservation order specifies the VM size and region for the reservations. </param>
        /// <param name="description"> The description of the transaction. </param>
        /// <param name="eventType"> The type of the transaction (Purchase, Cancel or Refund). </param>
        /// <param name="quantity"> The quantity of the transaction. </param>
        /// <param name="amount"> The charge of the transaction. </param>
        /// <param name="currency"> The ISO currency in which the transaction is charged, for example, USD. </param>
        /// <param name="reservationOrderName"> The name of the reservation order. </param>
        /// <param name="purchasingEnrollment"> The purchasing enrollment. </param>
        /// <param name="purchasingSubscriptionGuid"> The subscription guid that makes the transaction. </param>
        /// <param name="purchasingSubscriptionName"> The subscription name that makes the transaction. </param>
        /// <param name="armSkuName"> This is the ARM Sku name. It can be used to join with the serviceType field in additional info in usage records. </param>
        /// <param name="term"> This is the term of the transaction. </param>
        /// <param name="region"> The region of the transaction. </param>
        /// <param name="accountName"> The name of the account that makes the transaction. </param>
        /// <param name="accountOwnerEmail"> The email of the account owner that makes the transaction. </param>
        /// <param name="departmentName"> The department name. </param>
        /// <param name="costCenter"> The cost center of this department if it is a department and a cost center is provided. </param>
        /// <param name="currentEnrollment"> The current enrollment. </param>
        /// <param name="billingFrequency"> The billing frequency, which can be either one-time or recurring. </param>
        /// <param name="billingMonth"> The billing month(yyyyMMdd), on which the event initiated. </param>
        /// <param name="monetaryCommitment"> The monetary commitment amount at the enrollment scope. </param>
        /// <param name="overage"> The overage amount at the enrollment scope. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ConsumptionReservationTransaction(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DateTimeOffset? transactOn, string reservationOrderId, string description, string eventType, decimal? quantity, decimal? amount, string currency, string reservationOrderName, string purchasingEnrollment, Guid? purchasingSubscriptionGuid, string purchasingSubscriptionName, string armSkuName, string term, string region, string accountName, string accountOwnerEmail, string departmentName, string costCenter, string currentEnrollment, string billingFrequency, int? billingMonth, decimal? monetaryCommitment, decimal? overage, IReadOnlyList<string> tags, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            TransactOn = transactOn;
            ReservationOrderId = reservationOrderId;
            Description = description;
            EventType = eventType;
            Quantity = quantity;
            Amount = amount;
            Currency = currency;
            ReservationOrderName = reservationOrderName;
            PurchasingEnrollment = purchasingEnrollment;
            PurchasingSubscriptionGuid = purchasingSubscriptionGuid;
            PurchasingSubscriptionName = purchasingSubscriptionName;
            ArmSkuName = armSkuName;
            Term = term;
            Region = region;
            AccountName = accountName;
            AccountOwnerEmail = accountOwnerEmail;
            DepartmentName = departmentName;
            CostCenter = costCenter;
            CurrentEnrollment = currentEnrollment;
            BillingFrequency = billingFrequency;
            BillingMonth = billingMonth;
            MonetaryCommitment = monetaryCommitment;
            Overage = overage;
            Tags = tags;
            _rawData = rawData;
        }

        /// <summary> The date of the transaction. </summary>
        public DateTimeOffset? TransactOn { get; }
        /// <summary> The reservation order ID is the identifier for a reservation purchase. Each reservation order ID represents a single purchase transaction. A reservation order contains reservations. The reservation order specifies the VM size and region for the reservations. </summary>
        public string ReservationOrderId { get; }
        /// <summary> The description of the transaction. </summary>
        public string Description { get; }
        /// <summary> The type of the transaction (Purchase, Cancel or Refund). </summary>
        public string EventType { get; }
        /// <summary> The quantity of the transaction. </summary>
        public decimal? Quantity { get; }
        /// <summary> The charge of the transaction. </summary>
        public decimal? Amount { get; }
        /// <summary> The ISO currency in which the transaction is charged, for example, USD. </summary>
        public string Currency { get; }
        /// <summary> The name of the reservation order. </summary>
        public string ReservationOrderName { get; }
        /// <summary> The purchasing enrollment. </summary>
        public string PurchasingEnrollment { get; }
        /// <summary> The subscription guid that makes the transaction. </summary>
        public Guid? PurchasingSubscriptionGuid { get; }
        /// <summary> The subscription name that makes the transaction. </summary>
        public string PurchasingSubscriptionName { get; }
        /// <summary> This is the ARM Sku name. It can be used to join with the serviceType field in additional info in usage records. </summary>
        public string ArmSkuName { get; }
        /// <summary> This is the term of the transaction. </summary>
        public string Term { get; }
        /// <summary> The region of the transaction. </summary>
        public string Region { get; }
        /// <summary> The name of the account that makes the transaction. </summary>
        public string AccountName { get; }
        /// <summary> The email of the account owner that makes the transaction. </summary>
        public string AccountOwnerEmail { get; }
        /// <summary> The department name. </summary>
        public string DepartmentName { get; }
        /// <summary> The cost center of this department if it is a department and a cost center is provided. </summary>
        public string CostCenter { get; }
        /// <summary> The current enrollment. </summary>
        public string CurrentEnrollment { get; }
        /// <summary> The billing frequency, which can be either one-time or recurring. </summary>
        public string BillingFrequency { get; }
        /// <summary> The billing month(yyyyMMdd), on which the event initiated. </summary>
        public int? BillingMonth { get; }
        /// <summary> The monetary commitment amount at the enrollment scope. </summary>
        public decimal? MonetaryCommitment { get; }
        /// <summary> The overage amount at the enrollment scope. </summary>
        public decimal? Overage { get; }
        /// <summary> Resource tags. </summary>
        public IReadOnlyList<string> Tags { get; }
    }
}
