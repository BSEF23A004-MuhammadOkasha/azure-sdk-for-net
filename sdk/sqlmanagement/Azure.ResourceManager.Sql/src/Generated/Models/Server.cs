// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> An Azure SQL Database server. </summary>
    public partial class Server : TrackedResource
    {
        /// <summary> Initializes a new instance of Server. </summary>
        /// <param name="location"> Resource location. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        public Server(string location) : base(location)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }

            PrivateEndpointConnections = new ChangeTrackingList<ServerPrivateEndpointConnection>();
        }

        /// <summary> Initializes a new instance of Server. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="identity"> The Azure Active Directory identity of the server. </param>
        /// <param name="kind"> Kind of sql server. This is metadata used for the Azure portal experience. </param>
        /// <param name="administratorLogin"> Administrator username for the server. Once created it cannot be changed. </param>
        /// <param name="administratorLoginPassword"> The administrator login password (required for server creation). </param>
        /// <param name="version"> The version of the server. </param>
        /// <param name="state"> The state of the server. </param>
        /// <param name="fullyQualifiedDomainName"> The fully qualified domain name of the server. </param>
        /// <param name="privateEndpointConnections"> List of private endpoint connections on a server. </param>
        /// <param name="minimalTlsVersion"> Minimal TLS version. Allowed values: &apos;1.0&apos;, &apos;1.1&apos;, &apos;1.2&apos;. </param>
        /// <param name="publicNetworkAccess"> Whether or not public endpoint access is allowed for this server.  Value is optional but if passed in, must be &apos;Enabled&apos; or &apos;Disabled&apos;. </param>
        internal Server(string id, string name, string type, string location, IDictionary<string, string> tags, ResourceIdentity identity, string kind, string administratorLogin, string administratorLoginPassword, string version, string state, string fullyQualifiedDomainName, IReadOnlyList<ServerPrivateEndpointConnection> privateEndpointConnections, string minimalTlsVersion, ServerPublicNetworkAccess? publicNetworkAccess) : base(id, name, type, location, tags)
        {
            Identity = identity;
            Kind = kind;
            AdministratorLogin = administratorLogin;
            AdministratorLoginPassword = administratorLoginPassword;
            Version = version;
            State = state;
            FullyQualifiedDomainName = fullyQualifiedDomainName;
            PrivateEndpointConnections = privateEndpointConnections;
            MinimalTlsVersion = minimalTlsVersion;
            PublicNetworkAccess = publicNetworkAccess;
        }

        /// <summary> The Azure Active Directory identity of the server. </summary>
        public ResourceIdentity Identity { get; set; }
        /// <summary> Kind of sql server. This is metadata used for the Azure portal experience. </summary>
        public string Kind { get; }
        /// <summary> Administrator username for the server. Once created it cannot be changed. </summary>
        public string AdministratorLogin { get; set; }
        /// <summary> The administrator login password (required for server creation). </summary>
        public string AdministratorLoginPassword { get; set; }
        /// <summary> The version of the server. </summary>
        public string Version { get; set; }
        /// <summary> The state of the server. </summary>
        public string State { get; }
        /// <summary> The fully qualified domain name of the server. </summary>
        public string FullyQualifiedDomainName { get; }
        /// <summary> List of private endpoint connections on a server. </summary>
        public IReadOnlyList<ServerPrivateEndpointConnection> PrivateEndpointConnections { get; }
        /// <summary> Minimal TLS version. Allowed values: &apos;1.0&apos;, &apos;1.1&apos;, &apos;1.2&apos;. </summary>
        public string MinimalTlsVersion { get; set; }
        /// <summary> Whether or not public endpoint access is allowed for this server.  Value is optional but if passed in, must be &apos;Enabled&apos; or &apos;Disabled&apos;. </summary>
        public ServerPublicNetworkAccess? PublicNetworkAccess { get; set; }
    }
}
