// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core.TestFramework;

namespace Azure.AI.Inference.Tests
{
    public class InferenceClientTestEnvironment : TestEnvironment
    {
        public string MistralSmallEndpoint => GetRecordedVariable("AZUREAI_MISTRAL_SMALL_URL");
        public string MistralSmallApiKey => GetRecordedVariable("AZUREAI_MISTRAL_SMALL_KEY", options => options.IsSecret());
        public string GithubEndpoint => GetRecordedVariable("AZUREAI_GITHUB_URL");
        public string GithubToken => GetRecordedVariable("AZUREAI_GITHUB_TOKEN", options => options.IsSecret());

        // Add other client paramters here as above.
    }
}
