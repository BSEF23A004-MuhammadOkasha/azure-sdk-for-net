// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Properties of a active directory administrator. </summary>
    public partial class ManagedInstanceExternalAdministrator
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ManagedInstanceExternalAdministrator"/>. </summary>
        public ManagedInstanceExternalAdministrator()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ManagedInstanceExternalAdministrator"/>. </summary>
        /// <param name="administratorType"> Type of the sever administrator. </param>
        /// <param name="principalType"> Principal Type of the sever administrator. </param>
        /// <param name="login"> Login name of the server administrator. </param>
        /// <param name="sid"> SID (object ID) of the server administrator. </param>
        /// <param name="tenantId"> Tenant ID of the administrator. </param>
        /// <param name="isAzureADOnlyAuthenticationEnabled"> Azure Active Directory only Authentication enabled. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedInstanceExternalAdministrator(SqlAdministratorType? administratorType, SqlServerPrincipalType? principalType, string login, Guid? sid, Guid? tenantId, bool? isAzureADOnlyAuthenticationEnabled, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AdministratorType = administratorType;
            PrincipalType = principalType;
            Login = login;
            Sid = sid;
            TenantId = tenantId;
            IsAzureADOnlyAuthenticationEnabled = isAzureADOnlyAuthenticationEnabled;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Type of the sever administrator. </summary>
        public SqlAdministratorType? AdministratorType { get; set; }
        /// <summary> Principal Type of the sever administrator. </summary>
        public SqlServerPrincipalType? PrincipalType { get; set; }
        /// <summary> Login name of the server administrator. </summary>
        public string Login { get; set; }
        /// <summary> SID (object ID) of the server administrator. </summary>
        public Guid? Sid { get; set; }
        /// <summary> Tenant ID of the administrator. </summary>
        public Guid? TenantId { get; set; }
        /// <summary> Azure Active Directory only Authentication enabled. </summary>
        public bool? IsAzureADOnlyAuthenticationEnabled { get; set; }
    }
}
