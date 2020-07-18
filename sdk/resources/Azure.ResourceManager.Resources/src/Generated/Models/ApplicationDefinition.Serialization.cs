// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    public partial class ApplicationDefinition : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (ManagedBy != null)
            {
                writer.WritePropertyName("managedBy");
                writer.WriteStringValue(ManagedBy);
            }
            if (Sku != null)
            {
                writer.WritePropertyName("sku");
                writer.WriteObjectValue(Sku);
            }
            if (Identity != null)
            {
                writer.WritePropertyName("identity");
                writer.WriteObjectValue(Identity);
            }
            if (Id != null)
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            if (Name != null)
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Type != null)
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(Type);
            }
            if (Location != null)
            {
                writer.WritePropertyName("location");
                writer.WriteStringValue(Location);
            }
            if (Tags != null)
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            writer.WritePropertyName("lockLevel");
            writer.WriteStringValue(LockLevel.ToSerialString());
            if (DisplayName != null)
            {
                writer.WritePropertyName("displayName");
                writer.WriteStringValue(DisplayName);
            }
            if (IsEnabled != null)
            {
                writer.WritePropertyName("isEnabled");
                writer.WriteStringValue(IsEnabled);
            }
            writer.WritePropertyName("authorizations");
            writer.WriteStartArray();
            foreach (var item in Authorizations)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (Artifacts != null)
            {
                writer.WritePropertyName("artifacts");
                writer.WriteStartArray();
                foreach (var item in Artifacts)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Description != null)
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (PackageFileUri != null)
            {
                writer.WritePropertyName("packageFileUri");
                writer.WriteStringValue(PackageFileUri);
            }
            if (MainTemplate != null)
            {
                writer.WritePropertyName("mainTemplate");
                writer.WriteObjectValue(MainTemplate);
            }
            if (CreateUiDefinition != null)
            {
                writer.WritePropertyName("createUiDefinition");
                writer.WriteObjectValue(CreateUiDefinition);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ApplicationDefinition DeserializeApplicationDefinition(JsonElement element)
        {
            string managedBy = default;
            SkuAutoGenerated sku = default;
            IdentityAutoGenerated2 identity = default;
            string id = default;
            string name = default;
            string type = default;
            string location = default;
            IDictionary<string, string> tags = default;
            ApplicationLockLevel lockLevel = default;
            string displayName = default;
            string isEnabled = default;
            IList<ApplicationProviderAuthorization> authorizations = default;
            IList<ApplicationArtifact> artifacts = default;
            string description = default;
            string packageFileUri = default;
            object mainTemplate = default;
            object createUiDefinition = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("managedBy"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    managedBy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sku"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = SkuAutoGenerated.DeserializeSkuAutoGenerated(property.Value);
                    continue;
                }
                if (property.NameEquals("identity"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = IdentityAutoGenerated2.DeserializeIdentityAutoGenerated2(property.Value);
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, property0.Value.GetString());
                        }
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("lockLevel"))
                        {
                            lockLevel = property0.Value.GetString().ToApplicationLockLevel();
                            continue;
                        }
                        if (property0.NameEquals("displayName"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("isEnabled"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isEnabled = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("authorizations"))
                        {
                            List<ApplicationProviderAuthorization> array = new List<ApplicationProviderAuthorization>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(ApplicationProviderAuthorization.DeserializeApplicationProviderAuthorization(item));
                                }
                            }
                            authorizations = array;
                            continue;
                        }
                        if (property0.NameEquals("artifacts"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ApplicationArtifact> array = new List<ApplicationArtifact>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(ApplicationArtifact.DeserializeApplicationArtifact(item));
                                }
                            }
                            artifacts = array;
                            continue;
                        }
                        if (property0.NameEquals("description"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("packageFileUri"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            packageFileUri = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("mainTemplate"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            mainTemplate = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("createUiDefinition"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createUiDefinition = property0.Value.GetObject();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ApplicationDefinition(id, name, type, location, tags, managedBy, sku, identity, lockLevel, displayName, isEnabled, authorizations, artifacts, description, packageFileUri, mainTemplate, createUiDefinition);
        }
    }
}
