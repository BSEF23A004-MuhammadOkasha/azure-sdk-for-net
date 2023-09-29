// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading.Tasks;
using Azure;
using Azure.Identity;
using Azure.Security.ConfidentialLedger.Certificate;
using NUnit.Framework;

namespace Azure.Security.ConfidentialLedger.Samples
{
    public partial class Samples_ConfidentialLedgerCertificateClient
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetLedgerIdentity_ShortVersion()
        {
            ConfidentialLedgerCertificateClient client = new ConfidentialLedgerCertificateClient(new Uri("http://localhost:3000"));

            Response response = client.GetLedgerIdentity("<ledgerId>");

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("ledgerTlsCertificate").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetLedgerIdentity_ShortVersion_Async()
        {
            ConfidentialLedgerCertificateClient client = new ConfidentialLedgerCertificateClient(new Uri("http://localhost:3000"));

            Response response = await client.GetLedgerIdentityAsync("<ledgerId>");

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("ledgerTlsCertificate").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetLedgerIdentity_AllParameters()
        {
            ConfidentialLedgerCertificateClient client = new ConfidentialLedgerCertificateClient(new Uri("http://localhost:3000"));

            Response response = client.GetLedgerIdentity("<ledgerId>");

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("ledgerId").ToString());
            Console.WriteLine(result.GetProperty("ledgerTlsCertificate").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetLedgerIdentity_AllParameters_Async()
        {
            ConfidentialLedgerCertificateClient client = new ConfidentialLedgerCertificateClient(new Uri("http://localhost:3000"));

            Response response = await client.GetLedgerIdentityAsync("<ledgerId>");

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("ledgerId").ToString());
            Console.WriteLine(result.GetProperty("ledgerTlsCertificate").ToString());
        }
    }
}
