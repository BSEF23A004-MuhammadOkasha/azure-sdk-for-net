// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    public partial class UpdatableClusterProfile : IUtf8JsonSerializable, IModelJsonSerializable<UpdatableClusterProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<UpdatableClusterProfile>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<UpdatableClusterProfile>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(ServiceConfigsProfiles))
            {
                writer.WritePropertyName("serviceConfigsProfiles"u8);
                writer.WriteStartArray();
                foreach (var item in ServiceConfigsProfiles)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<ClusterServiceConfigsProfile>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(SshProfile))
            {
                writer.WritePropertyName("sshProfile"u8);
                if (SshProfile is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ClusterSshProfile>)SshProfile).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(AutoscaleProfile))
            {
                writer.WritePropertyName("autoscaleProfile"u8);
                if (AutoscaleProfile is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ClusterAutoscaleProfile>)AutoscaleProfile).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(AuthorizationProfile))
            {
                writer.WritePropertyName("authorizationProfile"u8);
                if (AuthorizationProfile is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<AuthorizationProfile>)AuthorizationProfile).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(LogAnalyticsProfile))
            {
                writer.WritePropertyName("logAnalyticsProfile"u8);
                if (LogAnalyticsProfile is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ClusterLogAnalyticsProfile>)LogAnalyticsProfile).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(PrometheusProfile))
            {
                writer.WritePropertyName("prometheusProfile"u8);
                if (PrometheusProfile is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ClusterPrometheusProfile>)PrometheusProfile).Serialize(writer, options);
                }
            }
            if (Optional.IsCollectionDefined(ScriptActionProfiles))
            {
                writer.WritePropertyName("scriptActionProfiles"u8);
                writer.WriteStartArray();
                foreach (var item in ScriptActionProfiles)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<ScriptActionProfile>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static UpdatableClusterProfile DeserializeUpdatableClusterProfile(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<ClusterServiceConfigsProfile>> serviceConfigsProfiles = default;
            Optional<ClusterSshProfile> sshProfile = default;
            Optional<ClusterAutoscaleProfile> autoscaleProfile = default;
            Optional<AuthorizationProfile> authorizationProfile = default;
            Optional<ClusterLogAnalyticsProfile> logAnalyticsProfile = default;
            Optional<ClusterPrometheusProfile> prometheusProfile = default;
            Optional<IList<ScriptActionProfile>> scriptActionProfiles = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("serviceConfigsProfiles"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ClusterServiceConfigsProfile> array = new List<ClusterServiceConfigsProfile>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ClusterServiceConfigsProfile.DeserializeClusterServiceConfigsProfile(item));
                    }
                    serviceConfigsProfiles = array;
                    continue;
                }
                if (property.NameEquals("sshProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sshProfile = ClusterSshProfile.DeserializeClusterSshProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("autoscaleProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    autoscaleProfile = ClusterAutoscaleProfile.DeserializeClusterAutoscaleProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("authorizationProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    authorizationProfile = AuthorizationProfile.DeserializeAuthorizationProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("logAnalyticsProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    logAnalyticsProfile = ClusterLogAnalyticsProfile.DeserializeClusterLogAnalyticsProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("prometheusProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    prometheusProfile = ClusterPrometheusProfile.DeserializeClusterPrometheusProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("scriptActionProfiles"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ScriptActionProfile> array = new List<ScriptActionProfile>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ScriptActionProfile.DeserializeScriptActionProfile(item));
                    }
                    scriptActionProfiles = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new UpdatableClusterProfile(Optional.ToList(serviceConfigsProfiles), sshProfile.Value, autoscaleProfile.Value, authorizationProfile.Value, logAnalyticsProfile.Value, prometheusProfile.Value, Optional.ToList(scriptActionProfiles), rawData);
        }

        UpdatableClusterProfile IModelJsonSerializable<UpdatableClusterProfile>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeUpdatableClusterProfile(doc.RootElement, options);
        }

        BinaryData IModelSerializable<UpdatableClusterProfile>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        UpdatableClusterProfile IModelSerializable<UpdatableClusterProfile>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeUpdatableClusterProfile(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="UpdatableClusterProfile"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="UpdatableClusterProfile"/> to convert. </param>
        public static implicit operator RequestContent(UpdatableClusterProfile model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="UpdatableClusterProfile"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator UpdatableClusterProfile(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeUpdatableClusterProfile(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
