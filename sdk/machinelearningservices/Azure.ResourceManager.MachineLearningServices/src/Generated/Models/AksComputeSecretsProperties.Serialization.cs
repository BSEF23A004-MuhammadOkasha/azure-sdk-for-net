// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    internal partial class AksComputeSecretsProperties
    {
        internal static AksComputeSecretsProperties DeserializeAksComputeSecretsProperties(JsonElement element)
        {
            Optional<string> userKubeConfig = default;
            Optional<string> adminKubeConfig = default;
            Optional<string> imagePullSecretName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("userKubeConfig"))
                {
                    userKubeConfig = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("adminKubeConfig"))
                {
                    adminKubeConfig = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("imagePullSecretName"))
                {
                    imagePullSecretName = property.Value.GetString();
                    continue;
                }
            }
            return new AksComputeSecretsProperties(userKubeConfig.Value, adminKubeConfig.Value, imagePullSecretName.Value);
        }
    }
}
