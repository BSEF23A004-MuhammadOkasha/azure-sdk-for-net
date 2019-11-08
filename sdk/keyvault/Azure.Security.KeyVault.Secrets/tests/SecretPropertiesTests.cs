﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Security.KeyVault.Tests;
using NUnit.Framework;

namespace Azure.Security.KeyVault.Secrets.Tests
{
    public class SecretPropertiesTests
    {
        [TestCase(@"{""kid"":""https://vault/secret/secret-name""}", false)]
        [TestCase(@"{""kid"":""https://vault/secret/secret-name"",""managed"":false}", false)]
        [TestCase(@"{""kid"":""https://vault/secret/secret-name"",""managed"":true}", true)]
        public void DeserializesManaged(string content, bool expected)
        {
            SecretProperties properties = new SecretProperties();
            using (JsonStream json = new JsonStream(content))
            {
                properties.Deserialize(json.AsStream());
            }

            Assert.AreEqual(expected, properties.Managed);
        }
    }
}
