// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Management.Network.Models
{
    /// <summary> Customer error of an application gateway. </summary>
    public partial class ApplicationGatewayCustomError
    {
        /// <summary> Initializes a new instance of ApplicationGatewayCustomError. </summary>
        public ApplicationGatewayCustomError()
        {
        }

        /// <summary> Initializes a new instance of ApplicationGatewayCustomError. </summary>
        /// <param name="statusCode"> Status code of the application gateway customer error. </param>
        /// <param name="customErrorPageUrl"> Error page URL of the application gateway customer error. </param>
        internal ApplicationGatewayCustomError(ApplicationGatewayCustomErrorStatusCode? statusCode, string customErrorPageUrl)
        {
            StatusCode = statusCode;
            CustomErrorPageUrl = customErrorPageUrl;
        }

        /// <summary> Status code of the application gateway customer error. </summary>
        public ApplicationGatewayCustomErrorStatusCode? StatusCode { get; set; }
        /// <summary> Error page URL of the application gateway customer error. </summary>
        public string CustomErrorPageUrl { get; set; }
    }
}
