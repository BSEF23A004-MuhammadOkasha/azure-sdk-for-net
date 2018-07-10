﻿using Microsoft.IdentityModel.Clients.ActiveDirectory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Azure.Services.AppAuthentication
{
    /// <summary>
    /// Contains access token and other results from a token request call
    /// </summary>
    public class AppAuthenticationResult
    {
        /// <summary>
        /// The access token returned from the token request
        /// </summary>
        [DataMember]
        public string AccessToken { get; private set; }

        /// <summary>
        /// When the token is valid to
        /// </summary>
        [DataMember]
        public DateTimeOffset ExpiresOn { get; private set; }

        /// <summary>
        /// The resource the token request is authorized for
        /// </summary>
        [DataMember]
        public string Resource { get; private set; }

        /// <summary>
        /// The type of access token returned
        /// </summary>
        [DataMember]
        public string TokenType { get; private set; }

        /// <summary>
        /// Return true when access token is near expiration
        /// </summary>
        /// <returns></returns>
        public bool IsNearExpiry()
        {
            // If the expiration time is within the next 5 minutes, the token is about to expire
            return ExpiresOn < DateTimeOffset.Now.AddMinutes(5);
        }

        internal static AppAuthenticationResult Create(TokenResponse response, TokenResponse.DateFormat dateFormat)
        {
            if (response == null)
            {
                throw new ArgumentNullException(nameof(response));
            }

            string expiresOnString = response.ExpiresOn ?? response.ExpiresOn2;
            DateTimeOffset expiresOn = DateTimeOffset.MinValue;

            switch (dateFormat)
            {
                case TokenResponse.DateFormat.DateTimeString:
                    expiresOn = DateTimeOffset.Parse(expiresOnString);
                    break;
                case TokenResponse.DateFormat.Unix:
                    double seconds = double.Parse(expiresOnString);
                    expiresOn = AppAuthentication.AccessToken.UnixTimeEpoch.AddSeconds(seconds);
                    break;
            }

            var result = new AppAuthenticationResult()
            {
                AccessToken = response.AccessToken ?? response.AccessToken2,
                ExpiresOn = expiresOn,
                Resource = response.Resource,
                TokenType = response.TokenType ?? response.TokenType2
            };

            return result;
        }

        internal static AppAuthenticationResult Create(AuthenticationResult authResult)
        {
            if (authResult == null)
            {
                throw new ArgumentNullException(nameof(authResult));
            }

            var result = new AppAuthenticationResult()
            {
                AccessToken = authResult.AccessToken,
                ExpiresOn = authResult.ExpiresOn
            };

            return result;
        }

        // for unit testing
        internal static AppAuthenticationResult Create(string accessToken)
        {
            if (string.IsNullOrEmpty(accessToken))
            {
                throw new ArgumentNullException(nameof(accessToken));
            }

            var tokenObj = AppAuthentication.AccessToken.Parse(accessToken);

            var result = new AppAuthenticationResult()
            {
                AccessToken = accessToken,
                ExpiresOn = AppAuthentication.AccessToken.UnixTimeEpoch.AddSeconds(tokenObj.ExpiryTime)
            };

            return result;
        }
    }
}
