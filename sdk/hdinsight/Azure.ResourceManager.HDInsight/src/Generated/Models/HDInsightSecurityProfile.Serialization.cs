// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    public partial class HDInsightSecurityProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DirectoryType))
            {
                writer.WritePropertyName("directoryType");
                writer.WriteStringValue(DirectoryType.Value.ToString());
            }
            if (Optional.IsDefined(Domain))
            {
                writer.WritePropertyName("domain");
                writer.WriteStringValue(Domain);
            }
            if (Optional.IsDefined(OrganizationalUnitDN))
            {
                writer.WritePropertyName("organizationalUnitDN");
                writer.WriteStringValue(OrganizationalUnitDN);
            }
            if (Optional.IsCollectionDefined(LdapsUrls))
            {
                writer.WritePropertyName("ldapsUrls");
                writer.WriteStartArray();
                foreach (var item in LdapsUrls)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DomainUsername))
            {
                writer.WritePropertyName("domainUsername");
                writer.WriteStringValue(DomainUsername);
            }
            if (Optional.IsDefined(DomainUserPassword))
            {
                writer.WritePropertyName("domainUserPassword");
                writer.WriteStringValue(DomainUserPassword);
            }
            if (Optional.IsCollectionDefined(ClusterUsersGroupDNs))
            {
                writer.WritePropertyName("clusterUsersGroupDNs");
                writer.WriteStartArray();
                foreach (var item in ClusterUsersGroupDNs)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(AaddsResourceId))
            {
                writer.WritePropertyName("aaddsResourceId");
                writer.WriteStringValue(AaddsResourceId);
            }
            if (Optional.IsDefined(MsiResourceId))
            {
                writer.WritePropertyName("msiResourceId");
                writer.WriteStringValue(MsiResourceId);
            }
            writer.WriteEndObject();
        }

        internal static HDInsightSecurityProfile DeserializeHDInsightSecurityProfile(JsonElement element)
        {
            Optional<AuthenticationDirectoryType> directoryType = default;
            Optional<string> domain = default;
            Optional<string> organizationalUnitDN = default;
            Optional<IList<string>> ldapsUrls = default;
            Optional<string> domainUsername = default;
            Optional<string> domainUserPassword = default;
            Optional<IList<string>> clusterUsersGroupDNs = default;
            Optional<ResourceIdentifier> aaddsResourceId = default;
            Optional<ResourceIdentifier> msiResourceId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("directoryType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    directoryType = new AuthenticationDirectoryType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("domain"))
                {
                    domain = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("organizationalUnitDN"))
                {
                    organizationalUnitDN = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ldapsUrls"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    ldapsUrls = array;
                    continue;
                }
                if (property.NameEquals("domainUsername"))
                {
                    domainUsername = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("domainUserPassword"))
                {
                    domainUserPassword = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clusterUsersGroupDNs"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    clusterUsersGroupDNs = array;
                    continue;
                }
                if (property.NameEquals("aaddsResourceId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    aaddsResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("msiResourceId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    msiResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
            }
            return new HDInsightSecurityProfile(Optional.ToNullable(directoryType), domain.Value, organizationalUnitDN.Value, Optional.ToList(ldapsUrls), domainUsername.Value, domainUserPassword.Value, Optional.ToList(clusterUsersGroupDNs), aaddsResourceId.Value, msiResourceId.Value);
        }
    }
}
