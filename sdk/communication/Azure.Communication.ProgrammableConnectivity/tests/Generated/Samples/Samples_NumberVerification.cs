// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.Communication.ProgrammableConnectivity.Samples
{
    public partial class Samples_NumberVerification
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_NumberVerification_VerifyWithoutCode_NumberVerificationVerifyWithoutCode()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            NumberVerification client = new ProgrammableConnectivityClient(endpoint, credential).GetNumberVerificationClient(apiVersion: "2024-02-09-preview");

            using RequestContent content = RequestContent.Create(new
            {
                networkIdentifier = new
                {
                    identifierType = "ipv4",
                    identifier = "12.12.12.12",
                },
                phoneNumber = "+14424318793",
                hashedPhoneNumber = "bwsl",
                redirectUri = "https://www.contoso.com",
            });
            Response response = client.VerifyWithoutCode("zdgrzzaxlodrvewbksn", content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_NumberVerification_VerifyWithoutCode_NumberVerificationVerifyWithoutCode_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            NumberVerification client = new ProgrammableConnectivityClient(endpoint, credential).GetNumberVerificationClient(apiVersion: "2024-02-09-preview");

            using RequestContent content = RequestContent.Create(new
            {
                networkIdentifier = new
                {
                    identifierType = "ipv4",
                    identifier = "12.12.12.12",
                },
                phoneNumber = "+14424318793",
                hashedPhoneNumber = "bwsl",
                redirectUri = "https://www.contoso.com",
            });
            Response response = await client.VerifyWithoutCodeAsync("zdgrzzaxlodrvewbksn", content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_NumberVerification_VerifyWithoutCode_NumberVerificationVerifyWithoutCode_Convenience()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            NumberVerification client = new ProgrammableConnectivityClient(endpoint, credential).GetNumberVerificationClient(apiVersion: "2024-02-09-preview");

            NumberVerificationWithoutCodeContent body = new NumberVerificationWithoutCodeContent(new NetworkIdentifier("ipv4", "12.12.12.12"), new Uri("https://www.contoso.com"))
            {
                PhoneNumber = "+14424318793",
                HashedPhoneNumber = "bwsl",
            };
            Response response = client.VerifyWithoutCode("zdgrzzaxlodrvewbksn", body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_NumberVerification_VerifyWithoutCode_NumberVerificationVerifyWithoutCode_Convenience_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            NumberVerification client = new ProgrammableConnectivityClient(endpoint, credential).GetNumberVerificationClient(apiVersion: "2024-02-09-preview");

            NumberVerificationWithoutCodeContent body = new NumberVerificationWithoutCodeContent(new NetworkIdentifier("ipv4", "12.12.12.12"), new Uri("https://www.contoso.com"))
            {
                PhoneNumber = "+14424318793",
                HashedPhoneNumber = "bwsl",
            };
            Response response = await client.VerifyWithoutCodeAsync("zdgrzzaxlodrvewbksn", body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_NumberVerification_VerifyWithCode_NumberVerificationVerifyWithCode()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            NumberVerification client = new ProgrammableConnectivityClient(endpoint, credential).GetNumberVerificationClient(apiVersion: "2024-02-09-preview");

            using RequestContent content = RequestContent.Create(new
            {
                apcCode = "yn",
            });
            Response response = client.VerifyWithCode("zdgrzzaxlodrvewbksn", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("verificationResult").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_NumberVerification_VerifyWithCode_NumberVerificationVerifyWithCode_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            NumberVerification client = new ProgrammableConnectivityClient(endpoint, credential).GetNumberVerificationClient(apiVersion: "2024-02-09-preview");

            using RequestContent content = RequestContent.Create(new
            {
                apcCode = "yn",
            });
            Response response = await client.VerifyWithCodeAsync("zdgrzzaxlodrvewbksn", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("verificationResult").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_NumberVerification_VerifyWithCode_NumberVerificationVerifyWithCode_Convenience()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            NumberVerification client = new ProgrammableConnectivityClient(endpoint, credential).GetNumberVerificationClient(apiVersion: "2024-02-09-preview");

            NumberVerificationWithCodeContent body = new NumberVerificationWithCodeContent("yn");
            Response<NumberVerificationResult> response = client.VerifyWithCode("zdgrzzaxlodrvewbksn", body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_NumberVerification_VerifyWithCode_NumberVerificationVerifyWithCode_Convenience_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            NumberVerification client = new ProgrammableConnectivityClient(endpoint, credential).GetNumberVerificationClient(apiVersion: "2024-02-09-preview");

            NumberVerificationWithCodeContent body = new NumberVerificationWithCodeContent("yn");
            Response<NumberVerificationResult> response = await client.VerifyWithCodeAsync("zdgrzzaxlodrvewbksn", body);
        }
    }
}
