// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.CosmosDB.Models;

namespace Azure.ResourceManager.CosmosDB
{
    internal class BackupInformationSource : IOperationSource<BackupInformation>
    {
        private readonly ArmClient _client;

        internal BackupInformationSource(ArmClient client)
        {
            _client = client;
        }

        BackupInformation IOperationSource<BackupInformation>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return BackupInformation.DeserializeBackupInformation(document.RootElement);
        }

        async ValueTask<BackupInformation> IOperationSource<BackupInformation>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return BackupInformation.DeserializeBackupInformation(document.RootElement);
        }
    }
}
