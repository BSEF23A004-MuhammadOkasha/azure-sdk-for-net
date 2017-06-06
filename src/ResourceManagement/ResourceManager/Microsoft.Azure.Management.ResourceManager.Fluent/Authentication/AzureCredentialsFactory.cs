﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Microsoft.Rest;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Microsoft.Azure.Management.ResourceManager.Fluent.Authentication
{
    public class AzureCredentialsFactory
    {
        /// <summary>
        /// Creates a credentials object from a username/password combination.
        /// </summary>
        /// <param name="username">the user name</param>
        /// <param name="password">the associated password</param>
        /// <param name="clientId">the client ID of the application</param>
        /// <param name="tenantId">the tenant ID or domain the user is in</param>
        /// <param name="environment">the environment to authenticate to</param>
        /// <returns>an authenticated credentials object</returns>
        public AzureCredentials FromUser(string username, string password, string clientId, string tenantId, AzureEnvironment environment)
        {
            return new AzureCredentials(new UserLoginInformation
            {
                UserName = username,
                Password = password,
                ClientId = clientId
            }, tenantId, environment);
        }

#if PORTABLE
        /// <summary>
        /// Creates a credentials object through device flow.
        /// </summary>
        /// <param name="clientId">the client ID of the application</param>
        /// <param name="tenantId">the tenant ID or domain</param>
        /// <param name="environment">the environment to authenticate to</param>
        /// <param name="deviceCodeHandler">a user defined function to handle device flow</param>
        /// <returns>an authenticated credentials object</returns>
        public AzureCredentials FromDevice(string clientId, string tenantId, AzureEnvironment environment, Func<DeviceCodeResult, bool> deviceCodeFlowHandler = null)
        {
            AzureCredentials credentials = new AzureCredentials(new DeviceCredentialInformation {
                    ClientId = clientId,
                    DeviceCodeFlowHandler = deviceCodeFlowHandler
                }, tenantId, environment);
            return credentials;
        }
#endif

        /// <summary>
        /// Creates a credentials object from a service principal.
        /// </summary>
        /// <param name="clientId">the client ID of the application the service principal is associated with</param>
        /// <param name="clientSecret">the secret for the client ID</param>
        /// <param name="tenantId">the tenant ID or domain the application is in</param>
        /// <param name="environment">the environment to authenticate to</param>
        /// <returns>an authenticated credentials object</returns>
        public AzureCredentials FromServicePrincipal(string clientId, string clientSecret, string tenantId, AzureEnvironment environment)
        {
            return new AzureCredentials(new ServicePrincipalLoginInformation
            {
                ClientId = clientId,
                ClientSecret = clientSecret
            }, tenantId, environment);
        }

        /// <summary>
        /// Creates a credentials object from a service principal.
        /// </summary>
        /// <param name="clientId">the client ID of the application the service principal is associated with</param>
        /// <param name="certificatePath">the certificate file for the client ID</param>]
        /// <param name="certificatePassword">the password for the certificate</param>
        /// <param name="tenantId">the tenant ID or domain the application is in</param>
        /// <param name="environment">the environment to authenticate to</param>
        /// <returns>an authenticated credentials object</returns>
        public AzureCredentials FromServicePrincipal(string clientId, string certificatePath, string certificatePassword, string tenantId, AzureEnvironment environment)
        {
            var certBytes = File.ReadAllBytes(certificatePath);
            return new AzureCredentials(new ServicePrincipalLoginInformation
            {
                ClientId = clientId,
                Certificate = certBytes,
                CertificatePassword = certificatePassword
            }, tenantId, environment);
        }

        /// <summary>
        /// Creates a credentials object from a file in the following format:
        ///
        ///     subscription=&lt;subscription-id&gt;
        ///     tenant=&lt;tenant-id&gt;
        ///     client=&lt;client-id&gt;
        ///     key=&lt;client-key&gt;
        ///     managementURI=&lt;management-URI&gt;
        ///     baseURL=&lt;base-URL&gt;
        ///     authURL=&lt;authentication-URL&gt;
        /// </summary>
        /// <param name="authFile">the path to the file</param>
        /// <returns>an authenticated credentials object</returns>
        public virtual AzureCredentials FromFile(string authFile)
        {
            var config = new Dictionary<string, string>()
            {
                { "authurl", AzureEnvironment.AzureGlobalCloud.AuthenticationEndpoint },
                { "baseurl", AzureEnvironment.AzureGlobalCloud.ResourceManagerEndpoint },
                { "managementuri", AzureEnvironment.AzureGlobalCloud.ManagementEnpoint },
                { "graphurl", AzureEnvironment.AzureGlobalCloud.GraphEndpoint }
            };

            File.ReadLines(authFile)
                .All(line =>
                {
                    if (line.Trim().StartsWith("#"))
                        return true; // Ignore comments
                    var keyVal = line.Trim().Split(new char[] { '=' }, 2);
                    if(keyVal.Length < 2)
                        return true; // Ignore lines that don't look like $$$=$$$
                    config[keyVal[0].ToLowerInvariant()] = keyVal[1];
                    return true;
                });

            var env = new AzureEnvironment()
            {
                AuthenticationEndpoint = config["authurl"].Replace("\\", ""),
                ManagementEnpoint = config["managementuri"].Replace("\\", ""),
                ResourceManagerEndpoint = config["baseurl"].Replace("\\", ""),
                GraphEndpoint = config["graphurl"].Replace("\\", "")
            };

            AzureCredentials credentials;
            if (config.ContainsKey("key"))
            {
                credentials = FromServicePrincipal(config["client"], config["key"], config["tenant"], env);
            }
            else if (config.ContainsKey("certificate"))
            {
                string certificatePath = config["certificate"].Replace("\\:", ":").Replace("\\\\", "\\");
                if (!File.Exists(certificatePath))
                {
                    certificatePath = Path.Combine(Path.GetDirectoryName(authFile), certificatePath);
                }
                credentials = FromServicePrincipal(config["client"], certificatePath,
                    config.ContainsKey("certificatepassword") ? config["certificatepassword"] : "", config["tenant"], env);
            }
            else
            {
                throw new ValidationException("Please specify either a client key or a client certificate.");
            }
            credentials.WithDefaultSubscription(config["subscription"]);
            return credentials;
        }
    }
}