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

namespace Azure.ResourceManager.AppConfiguration
{
    internal class ConfigurationStoreOperationSource : IOperationSource<ConfigurationStore>
    {
        private readonly ArmClient _client;

        internal ConfigurationStoreOperationSource(ArmClient client)
        {
            _client = client;
        }

        ConfigurationStore IOperationSource<ConfigurationStore>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ConfigurationStoreData.DeserializeConfigurationStoreData(document.RootElement);
            return new ConfigurationStore(_client, data);
        }

        async ValueTask<ConfigurationStore> IOperationSource<ConfigurationStore>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ConfigurationStoreData.DeserializeConfigurationStoreData(document.RootElement);
            return new ConfigurationStore(_client, data);
        }
    }
}
