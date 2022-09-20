// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> Contains all the contact details of the customer. </summary>
    public partial class DataBoxEdgeContactDetails
    {
        /// <summary> Initializes a new instance of DataBoxEdgeContactDetails. </summary>
        /// <param name="contactPerson"> The contact person name. </param>
        /// <param name="companyName"> The name of the company. </param>
        /// <param name="phone"> The phone number. </param>
        /// <param name="emailList"> The email list. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="contactPerson"/>, <paramref name="companyName"/>, <paramref name="phone"/> or <paramref name="emailList"/> is null. </exception>
        public DataBoxEdgeContactDetails(string contactPerson, string companyName, string phone, IEnumerable<string> emailList)
        {
            if (contactPerson == null)
            {
                throw new ArgumentNullException(nameof(contactPerson));
            }
            if (companyName == null)
            {
                throw new ArgumentNullException(nameof(companyName));
            }
            if (phone == null)
            {
                throw new ArgumentNullException(nameof(phone));
            }
            if (emailList == null)
            {
                throw new ArgumentNullException(nameof(emailList));
            }

            ContactPerson = contactPerson;
            CompanyName = companyName;
            Phone = phone;
            EmailList = emailList.ToList();
        }

        /// <summary> Initializes a new instance of DataBoxEdgeContactDetails. </summary>
        /// <param name="contactPerson"> The contact person name. </param>
        /// <param name="companyName"> The name of the company. </param>
        /// <param name="phone"> The phone number. </param>
        /// <param name="emailList"> The email list. </param>
        internal DataBoxEdgeContactDetails(string contactPerson, string companyName, string phone, IList<string> emailList)
        {
            ContactPerson = contactPerson;
            CompanyName = companyName;
            Phone = phone;
            EmailList = emailList;
        }

        /// <summary> The contact person name. </summary>
        public string ContactPerson { get; set; }
        /// <summary> The name of the company. </summary>
        public string CompanyName { get; set; }
        /// <summary> The phone number. </summary>
        public string Phone { get; set; }
        /// <summary> The email list. </summary>
        public IList<string> EmailList { get; }
    }
}
