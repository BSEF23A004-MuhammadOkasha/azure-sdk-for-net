// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Network.Fluent.HasBackendPort.Update
{
    /// <summary>
    /// The stage of an update allowing to modify the backend port.
    /// </summary>
    public interface IWithBackendPort<ReturnT> 
    {
        /// <summary>
        /// Specifies the backend port.
        /// </summary>
        /// <param name="port">A port number.</param>
        ReturnT WithBackendPort(int port);
    }
}