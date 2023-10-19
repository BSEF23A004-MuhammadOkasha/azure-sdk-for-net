// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Defender.Easm
{
    /// <summary> The AsAsset. </summary>
    public partial class AsAsset : InventoryAsset
    {
        /// <summary> Initializes a new instance of AsAsset. </summary>
        public AsAsset()
        {
            AsNames = new ChangeTrackingList<ObservedString>();
            OrgNames = new ChangeTrackingList<ObservedString>();
            OrgIds = new ChangeTrackingList<ObservedString>();
            Countries = new ChangeTrackingList<ObservedString>();
            Registries = new ChangeTrackingList<ObservedString>();
            Sources = new ChangeTrackingList<Source>();
            RegistrarCreatedAt = new ChangeTrackingList<ObservedLong>();
            RegistrarUpdatedAt = new ChangeTrackingList<ObservedLong>();
            RegistrantContacts = new ChangeTrackingList<ObservedString>();
            AdminContacts = new ChangeTrackingList<ObservedString>();
            TechnicalContacts = new ChangeTrackingList<ObservedString>();
            RegistrarNames = new ChangeTrackingList<ObservedString>();
            RegistrantNames = new ChangeTrackingList<ObservedString>();
            AdminNames = new ChangeTrackingList<ObservedString>();
            TechnicalNames = new ChangeTrackingList<ObservedString>();
            AdminOrgs = new ChangeTrackingList<ObservedString>();
            TechnicalOrgs = new ChangeTrackingList<ObservedString>();
            RegistrantPhones = new ChangeTrackingList<ObservedString>();
            AdminPhones = new ChangeTrackingList<ObservedString>();
            TechnicalPhones = new ChangeTrackingList<ObservedString>();
        }

        /// <summary> Initializes a new instance of AsAsset. </summary>
        /// <param name="asn"></param>
        /// <param name="asNames"></param>
        /// <param name="orgNames"></param>
        /// <param name="orgIds"></param>
        /// <param name="countries"></param>
        /// <param name="registries"></param>
        /// <param name="sources"></param>
        /// <param name="firstSeen"></param>
        /// <param name="lastSeen"></param>
        /// <param name="count"></param>
        /// <param name="registrarCreatedAt"></param>
        /// <param name="registrarUpdatedAt"></param>
        /// <param name="registrantContacts"></param>
        /// <param name="adminContacts"></param>
        /// <param name="technicalContacts"></param>
        /// <param name="registrarNames"></param>
        /// <param name="registrantNames"></param>
        /// <param name="adminNames"></param>
        /// <param name="technicalNames"></param>
        /// <param name="adminOrgs"></param>
        /// <param name="technicalOrgs"></param>
        /// <param name="registrantPhones"></param>
        /// <param name="adminPhones"></param>
        /// <param name="technicalPhones"></param>
        /// <param name="detailedFromWhoisAt"></param>
        internal AsAsset(long? asn, IList<ObservedString> asNames, IList<ObservedString> orgNames, IList<ObservedString> orgIds, IList<ObservedString> countries, IList<ObservedString> registries, IList<Source> sources, DateTimeOffset? firstSeen, DateTimeOffset? lastSeen, long? count, IList<ObservedLong> registrarCreatedAt, IList<ObservedLong> registrarUpdatedAt, IList<ObservedString> registrantContacts, IList<ObservedString> adminContacts, IList<ObservedString> technicalContacts, IList<ObservedString> registrarNames, IList<ObservedString> registrantNames, IList<ObservedString> adminNames, IList<ObservedString> technicalNames, IList<ObservedString> adminOrgs, IList<ObservedString> technicalOrgs, IList<ObservedString> registrantPhones, IList<ObservedString> adminPhones, IList<ObservedString> technicalPhones, DateTimeOffset? detailedFromWhoisAt)
        {
            Asn = asn;
            AsNames = asNames;
            OrgNames = orgNames;
            OrgIds = orgIds;
            Countries = countries;
            Registries = registries;
            Sources = sources;
            FirstSeen = firstSeen;
            LastSeen = lastSeen;
            Count = count;
            RegistrarCreatedAt = registrarCreatedAt;
            RegistrarUpdatedAt = registrarUpdatedAt;
            RegistrantContacts = registrantContacts;
            AdminContacts = adminContacts;
            TechnicalContacts = technicalContacts;
            RegistrarNames = registrarNames;
            RegistrantNames = registrantNames;
            AdminNames = adminNames;
            TechnicalNames = technicalNames;
            AdminOrgs = adminOrgs;
            TechnicalOrgs = technicalOrgs;
            RegistrantPhones = registrantPhones;
            AdminPhones = adminPhones;
            TechnicalPhones = technicalPhones;
            DetailedFromWhoisAt = detailedFromWhoisAt;
        }

        /// <summary> Gets or sets the asn. </summary>
        public long? Asn { get; set; }
        /// <summary> Gets the as names. </summary>
        public IList<ObservedString> AsNames { get; }
        /// <summary> Gets the org names. </summary>
        public IList<ObservedString> OrgNames { get; }
        /// <summary> Gets the org ids. </summary>
        public IList<ObservedString> OrgIds { get; }
        /// <summary> Gets the countries. </summary>
        public IList<ObservedString> Countries { get; }
        /// <summary> Gets the registries. </summary>
        public IList<ObservedString> Registries { get; }
        /// <summary> Gets the sources. </summary>
        public IList<Source> Sources { get; }
        /// <summary> Gets or sets the first seen. </summary>
        public DateTimeOffset? FirstSeen { get; set; }
        /// <summary> Gets or sets the last seen. </summary>
        public DateTimeOffset? LastSeen { get; set; }
        /// <summary> Gets or sets the count. </summary>
        public long? Count { get; set; }
        /// <summary> Gets the registrar created at. </summary>
        public IList<ObservedLong> RegistrarCreatedAt { get; }
        /// <summary> Gets the registrar updated at. </summary>
        public IList<ObservedLong> RegistrarUpdatedAt { get; }
        /// <summary> Gets the registrant contacts. </summary>
        public IList<ObservedString> RegistrantContacts { get; }
        /// <summary> Gets the admin contacts. </summary>
        public IList<ObservedString> AdminContacts { get; }
        /// <summary> Gets the technical contacts. </summary>
        public IList<ObservedString> TechnicalContacts { get; }
        /// <summary> Gets the registrar names. </summary>
        public IList<ObservedString> RegistrarNames { get; }
        /// <summary> Gets the registrant names. </summary>
        public IList<ObservedString> RegistrantNames { get; }
        /// <summary> Gets the admin names. </summary>
        public IList<ObservedString> AdminNames { get; }
        /// <summary> Gets the technical names. </summary>
        public IList<ObservedString> TechnicalNames { get; }
        /// <summary> Gets the admin orgs. </summary>
        public IList<ObservedString> AdminOrgs { get; }
        /// <summary> Gets the technical orgs. </summary>
        public IList<ObservedString> TechnicalOrgs { get; }
        /// <summary> Gets the registrant phones. </summary>
        public IList<ObservedString> RegistrantPhones { get; }
        /// <summary> Gets the admin phones. </summary>
        public IList<ObservedString> AdminPhones { get; }
        /// <summary> Gets the technical phones. </summary>
        public IList<ObservedString> TechnicalPhones { get; }
        /// <summary> Gets or sets the detailed from whois at. </summary>
        public DateTimeOffset? DetailedFromWhoisAt { get; set; }
    }
}
