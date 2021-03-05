// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Containers.ContainerRegistry
{
    /// <summary> The RefreshToken. </summary>
    public partial class RefreshToken
    {
        /// <summary> Initializes a new instance of RefreshToken. </summary>
        internal RefreshToken()
        {
        }

        /// <summary> Initializes a new instance of RefreshToken. </summary>
        /// <param name="refreshTokenValue"> The refresh token to be used for generating access tokens. </param>
        internal RefreshToken(string refreshTokenValue)
        {
            RefreshTokenValue = refreshTokenValue;
        }

        /// <summary> The refresh token to be used for generating access tokens. </summary>
        public string RefreshTokenValue { get; }
    }
}
