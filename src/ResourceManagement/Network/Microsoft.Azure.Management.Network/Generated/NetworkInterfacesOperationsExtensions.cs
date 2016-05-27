// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for NetworkInterfacesOperations.
    /// </summary>
    public static partial class NetworkInterfacesOperationsExtensions
    {
            /// <summary>
            /// The delete netwokInterface operation deletes the specified netwokInterface.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkInterfaceName'>
            /// The name of the network interface.
            /// </param>
            public static void Delete(this INetworkInterfacesOperations operations, string resourceGroupName, string networkInterfaceName)
            {
                Task.Factory.StartNew(s => ((INetworkInterfacesOperations)s).DeleteAsync(resourceGroupName, networkInterfaceName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The delete netwokInterface operation deletes the specified netwokInterface.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkInterfaceName'>
            /// The name of the network interface.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this INetworkInterfacesOperations operations, string resourceGroupName, string networkInterfaceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteWithHttpMessagesAsync(resourceGroupName, networkInterfaceName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// The delete netwokInterface operation deletes the specified netwokInterface.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkInterfaceName'>
            /// The name of the network interface.
            /// </param>
            public static void BeginDelete(this INetworkInterfacesOperations operations, string resourceGroupName, string networkInterfaceName)
            {
                Task.Factory.StartNew(s => ((INetworkInterfacesOperations)s).BeginDeleteAsync(resourceGroupName, networkInterfaceName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The delete netwokInterface operation deletes the specified netwokInterface.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkInterfaceName'>
            /// The name of the network interface.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this INetworkInterfacesOperations operations, string resourceGroupName, string networkInterfaceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, networkInterfaceName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// The Get ntework interface operation retreives information about the
            /// specified network interface.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkInterfaceName'>
            /// The name of the network interface.
            /// </param>
            /// <param name='expand'>
            /// expand references resources.
            /// </param>
            public static NetworkInterface Get(this INetworkInterfacesOperations operations, string resourceGroupName, string networkInterfaceName, string expand = default(string))
            {
                return Task.Factory.StartNew(s => ((INetworkInterfacesOperations)s).GetAsync(resourceGroupName, networkInterfaceName, expand), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The Get ntework interface operation retreives information about the
            /// specified network interface.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkInterfaceName'>
            /// The name of the network interface.
            /// </param>
            /// <param name='expand'>
            /// expand references resources.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<NetworkInterface> GetAsync(this INetworkInterfacesOperations operations, string resourceGroupName, string networkInterfaceName, string expand = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, networkInterfaceName, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The Put NetworkInterface operation creates/updates a networkInterface
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkInterfaceName'>
            /// The name of the network interface.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create/update NetworkInterface operation
            /// </param>
            public static NetworkInterface CreateOrUpdate(this INetworkInterfacesOperations operations, string resourceGroupName, string networkInterfaceName, NetworkInterface parameters)
            {
                return Task.Factory.StartNew(s => ((INetworkInterfacesOperations)s).CreateOrUpdateAsync(resourceGroupName, networkInterfaceName, parameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The Put NetworkInterface operation creates/updates a networkInterface
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkInterfaceName'>
            /// The name of the network interface.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create/update NetworkInterface operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<NetworkInterface> CreateOrUpdateAsync(this INetworkInterfacesOperations operations, string resourceGroupName, string networkInterfaceName, NetworkInterface parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, networkInterfaceName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The Put NetworkInterface operation creates/updates a networkInterface
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkInterfaceName'>
            /// The name of the network interface.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create/update NetworkInterface operation
            /// </param>
            public static NetworkInterface BeginCreateOrUpdate(this INetworkInterfacesOperations operations, string resourceGroupName, string networkInterfaceName, NetworkInterface parameters)
            {
                return Task.Factory.StartNew(s => ((INetworkInterfacesOperations)s).BeginCreateOrUpdateAsync(resourceGroupName, networkInterfaceName, parameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The Put NetworkInterface operation creates/updates a networkInterface
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkInterfaceName'>
            /// The name of the network interface.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create/update NetworkInterface operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<NetworkInterface> BeginCreateOrUpdateAsync(this INetworkInterfacesOperations operations, string resourceGroupName, string networkInterfaceName, NetworkInterface parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, networkInterfaceName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The list network interface operation retrieves information about all
            /// network interfaces in a virtual machine from a virtual machine scale set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualMachineScaleSetName'>
            /// The name of the virtual machine scale set.
            /// </param>
            /// <param name='virtualmachineIndex'>
            /// The virtual machine index.
            /// </param>
            public static IPage<NetworkInterface> ListVirtualMachineScaleSetVMNetworkInterfaces(this INetworkInterfacesOperations operations, string resourceGroupName, string virtualMachineScaleSetName, string virtualmachineIndex)
            {
                return Task.Factory.StartNew(s => ((INetworkInterfacesOperations)s).ListVirtualMachineScaleSetVMNetworkInterfacesAsync(resourceGroupName, virtualMachineScaleSetName, virtualmachineIndex), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The list network interface operation retrieves information about all
            /// network interfaces in a virtual machine from a virtual machine scale set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualMachineScaleSetName'>
            /// The name of the virtual machine scale set.
            /// </param>
            /// <param name='virtualmachineIndex'>
            /// The virtual machine index.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<NetworkInterface>> ListVirtualMachineScaleSetVMNetworkInterfacesAsync(this INetworkInterfacesOperations operations, string resourceGroupName, string virtualMachineScaleSetName, string virtualmachineIndex, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListVirtualMachineScaleSetVMNetworkInterfacesWithHttpMessagesAsync(resourceGroupName, virtualMachineScaleSetName, virtualmachineIndex, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The list network interface operation retrieves information about all
            /// network interfaces in a virtual machine scale set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualMachineScaleSetName'>
            /// The name of the virtual machine scale set.
            /// </param>
            public static IPage<NetworkInterface> ListVirtualMachineScaleSetNetworkInterfaces(this INetworkInterfacesOperations operations, string resourceGroupName, string virtualMachineScaleSetName)
            {
                return Task.Factory.StartNew(s => ((INetworkInterfacesOperations)s).ListVirtualMachineScaleSetNetworkInterfacesAsync(resourceGroupName, virtualMachineScaleSetName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The list network interface operation retrieves information about all
            /// network interfaces in a virtual machine scale set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualMachineScaleSetName'>
            /// The name of the virtual machine scale set.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<NetworkInterface>> ListVirtualMachineScaleSetNetworkInterfacesAsync(this INetworkInterfacesOperations operations, string resourceGroupName, string virtualMachineScaleSetName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListVirtualMachineScaleSetNetworkInterfacesWithHttpMessagesAsync(resourceGroupName, virtualMachineScaleSetName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The Get ntework interface operation retreives information about the
            /// specified network interface in a virtual machine scale set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualMachineScaleSetName'>
            /// The name of the virtual machine scale set.
            /// </param>
            /// <param name='virtualmachineIndex'>
            /// The virtual machine index.
            /// </param>
            /// <param name='networkInterfaceName'>
            /// The name of the network interface.
            /// </param>
            /// <param name='expand'>
            /// expand references resources.
            /// </param>
            public static NetworkInterface GetVirtualMachineScaleSetNetworkInterface(this INetworkInterfacesOperations operations, string resourceGroupName, string virtualMachineScaleSetName, string virtualmachineIndex, string networkInterfaceName, string expand = default(string))
            {
                return Task.Factory.StartNew(s => ((INetworkInterfacesOperations)s).GetVirtualMachineScaleSetNetworkInterfaceAsync(resourceGroupName, virtualMachineScaleSetName, virtualmachineIndex, networkInterfaceName, expand), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The Get ntework interface operation retreives information about the
            /// specified network interface in a virtual machine scale set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualMachineScaleSetName'>
            /// The name of the virtual machine scale set.
            /// </param>
            /// <param name='virtualmachineIndex'>
            /// The virtual machine index.
            /// </param>
            /// <param name='networkInterfaceName'>
            /// The name of the network interface.
            /// </param>
            /// <param name='expand'>
            /// expand references resources.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<NetworkInterface> GetVirtualMachineScaleSetNetworkInterfaceAsync(this INetworkInterfacesOperations operations, string resourceGroupName, string virtualMachineScaleSetName, string virtualmachineIndex, string networkInterfaceName, string expand = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetVirtualMachineScaleSetNetworkInterfaceWithHttpMessagesAsync(resourceGroupName, virtualMachineScaleSetName, virtualmachineIndex, networkInterfaceName, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The List networkInterfaces opertion retrieves all the networkInterfaces in
            /// a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<NetworkInterface> ListAll(this INetworkInterfacesOperations operations)
            {
                return Task.Factory.StartNew(s => ((INetworkInterfacesOperations)s).ListAllAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The List networkInterfaces opertion retrieves all the networkInterfaces in
            /// a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<NetworkInterface>> ListAllAsync(this INetworkInterfacesOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAllWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The List networkInterfaces opertion retrieves all the networkInterfaces in
            /// a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            public static IPage<NetworkInterface> List(this INetworkInterfacesOperations operations, string resourceGroupName)
            {
                return Task.Factory.StartNew(s => ((INetworkInterfacesOperations)s).ListAsync(resourceGroupName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The List networkInterfaces opertion retrieves all the networkInterfaces in
            /// a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<NetworkInterface>> ListAsync(this INetworkInterfacesOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The list network interface operation retrieves information about all
            /// network interfaces in a virtual machine from a virtual machine scale set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<NetworkInterface> ListVirtualMachineScaleSetVMNetworkInterfacesNext(this INetworkInterfacesOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((INetworkInterfacesOperations)s).ListVirtualMachineScaleSetVMNetworkInterfacesNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The list network interface operation retrieves information about all
            /// network interfaces in a virtual machine from a virtual machine scale set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<NetworkInterface>> ListVirtualMachineScaleSetVMNetworkInterfacesNextAsync(this INetworkInterfacesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListVirtualMachineScaleSetVMNetworkInterfacesNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The list network interface operation retrieves information about all
            /// network interfaces in a virtual machine scale set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<NetworkInterface> ListVirtualMachineScaleSetNetworkInterfacesNext(this INetworkInterfacesOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((INetworkInterfacesOperations)s).ListVirtualMachineScaleSetNetworkInterfacesNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The list network interface operation retrieves information about all
            /// network interfaces in a virtual machine scale set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<NetworkInterface>> ListVirtualMachineScaleSetNetworkInterfacesNextAsync(this INetworkInterfacesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListVirtualMachineScaleSetNetworkInterfacesNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The List networkInterfaces opertion retrieves all the networkInterfaces in
            /// a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<NetworkInterface> ListAllNext(this INetworkInterfacesOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((INetworkInterfacesOperations)s).ListAllNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The List networkInterfaces opertion retrieves all the networkInterfaces in
            /// a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<NetworkInterface>> ListAllNextAsync(this INetworkInterfacesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAllNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The List networkInterfaces opertion retrieves all the networkInterfaces in
            /// a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<NetworkInterface> ListNext(this INetworkInterfacesOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((INetworkInterfacesOperations)s).ListNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The List networkInterfaces opertion retrieves all the networkInterfaces in
            /// a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<NetworkInterface>> ListNextAsync(this INetworkInterfacesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
