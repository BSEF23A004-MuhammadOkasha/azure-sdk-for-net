// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Network.Fluent
{
    using Models;
    using Microsoft.Azure.Management.Resource.Fluent.Core;

    /// <summary>
    /// An immutable client-side representation of an application gateway IP configuration.
    /// </summary>
    public interface IApplicationGatewayIpConfiguration  :
        IWrapper<Models.ApplicationGatewayIPConfigurationInner>,
        IChildResource<Microsoft.Azure.Management.Network.Fluent.IApplicationGateway>
    {
        Microsoft.Azure.Management.Network.Fluent.ISubnet GetSubnet();

        string NetworkId { get; }

        string SubnetName { get; }
    }
}