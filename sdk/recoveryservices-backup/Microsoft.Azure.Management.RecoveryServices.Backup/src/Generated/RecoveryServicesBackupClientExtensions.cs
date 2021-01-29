// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Backup
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for RecoveryServicesBackupClient.
    /// </summary>
    public static partial class RecoveryServicesBackupClientExtensions
    {
            /// <summary>
            /// Fetches operation status for data move operation on vault
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the recovery services vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the recovery services vault is
            /// present.
            /// </param>
            /// <param name='operationId'>
            /// </param>
            public static OperationStatus GetOperationStatus(this IRecoveryServicesBackupClient operations, string vaultName, string resourceGroupName, string operationId)
            {
                return operations.GetOperationStatusAsync(vaultName, resourceGroupName, operationId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Fetches operation status for data move operation on vault
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the recovery services vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the recovery services vault is
            /// present.
            /// </param>
            /// <param name='operationId'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<OperationStatus> GetOperationStatusAsync(this IRecoveryServicesBackupClient operations, string vaultName, string resourceGroupName, string operationId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetOperationStatusWithHttpMessagesAsync(vaultName, resourceGroupName, operationId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Prepares source vault for Data Move operation
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the recovery services vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the recovery services vault is
            /// present.
            /// </param>
            /// <param name='parameters'>
            /// Prepare data move request
            /// </param>
            public static void BMSPrepareDataMove(this IRecoveryServicesBackupClient operations, string vaultName, string resourceGroupName, PrepareDataMoveRequest parameters)
            {
                operations.BMSPrepareDataMoveAsync(vaultName, resourceGroupName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Prepares source vault for Data Move operation
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the recovery services vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the recovery services vault is
            /// present.
            /// </param>
            /// <param name='parameters'>
            /// Prepare data move request
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BMSPrepareDataMoveAsync(this IRecoveryServicesBackupClient operations, string vaultName, string resourceGroupName, PrepareDataMoveRequest parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BMSPrepareDataMoveWithHttpMessagesAsync(vaultName, resourceGroupName, parameters, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Triggers Data Move Operation on target vault
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the recovery services vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the recovery services vault is
            /// present.
            /// </param>
            /// <param name='parameters'>
            /// Trigger data move request
            /// </param>
            public static void BMSTriggerDataMove(this IRecoveryServicesBackupClient operations, string vaultName, string resourceGroupName, TriggerDataMoveRequest parameters)
            {
                operations.BMSTriggerDataMoveAsync(vaultName, resourceGroupName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Triggers Data Move Operation on target vault
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the recovery services vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the recovery services vault is
            /// present.
            /// </param>
            /// <param name='parameters'>
            /// Trigger data move request
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BMSTriggerDataMoveAsync(this IRecoveryServicesBackupClient operations, string vaultName, string resourceGroupName, TriggerDataMoveRequest parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BMSTriggerDataMoveWithHttpMessagesAsync(vaultName, resourceGroupName, parameters, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Triggers Data Move Operation on target vault
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the recovery services vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the recovery services vault is
            /// present.
            /// </param>
            /// <param name='parameters'>
            /// Trigger data move request
            /// </param>
            public static void BeginBMSTriggerDataMove(this IRecoveryServicesBackupClient operations, string vaultName, string resourceGroupName, TriggerDataMoveRequest parameters)
            {
                operations.BeginBMSTriggerDataMoveAsync(vaultName, resourceGroupName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Triggers Data Move Operation on target vault
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the recovery services vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the recovery services vault is
            /// present.
            /// </param>
            /// <param name='parameters'>
            /// Trigger data move request
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginBMSTriggerDataMoveAsync(this IRecoveryServicesBackupClient operations, string vaultName, string resourceGroupName, TriggerDataMoveRequest parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginBMSTriggerDataMoveWithHttpMessagesAsync(vaultName, resourceGroupName, parameters, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
