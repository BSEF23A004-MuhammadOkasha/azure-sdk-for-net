// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    public partial class Compute : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("computeType");
            writer.WriteStringValue(ComputeType.ToString());
            if (Optional.IsDefined(ComputeLocation))
            {
                writer.WritePropertyName("computeLocation");
                writer.WriteStringValue(ComputeLocation);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(ResourceId))
            {
                writer.WritePropertyName("resourceId");
                writer.WriteStringValue(ResourceId);
            }
            if (Optional.IsDefined(DisableLocalAuth))
            {
                writer.WritePropertyName("disableLocalAuth");
                writer.WriteBooleanValue(DisableLocalAuth.Value);
            }
            writer.WriteEndObject();
        }

        internal static Compute DeserializeCompute(JsonElement element)
        {
            if (element.TryGetProperty("computeType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AKS": return AKS.DeserializeAKS(element);
                    case "AmlCompute": return AmlCompute.DeserializeAmlCompute(element);
                    case "ComputeInstance": return ComputeInstance.DeserializeComputeInstance(element);
                    case "DataFactory": return DataFactory.DeserializeDataFactory(element);
                    case "DataLakeAnalytics": return DataLakeAnalytics.DeserializeDataLakeAnalytics(element);
                    case "Databricks": return Databricks.DeserializeDatabricks(element);
                    case "HDInsight": return HDInsight.DeserializeHDInsight(element);
                    case "Kubernetes": return Kubernetes.DeserializeKubernetes(element);
                    case "SynapseSpark": return SynapseSpark.DeserializeSynapseSpark(element);
                    case "VirtualMachine": return VirtualMachine.DeserializeVirtualMachine(element);
                }
            }
            ComputeType computeType = default;
            Optional<string> computeLocation = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<string> description = default;
            Optional<DateTimeOffset> createdOn = default;
            Optional<DateTimeOffset> modifiedOn = default;
            Optional<string> resourceId = default;
            Optional<IReadOnlyList<ErrorResponse>> provisioningErrors = default;
            Optional<bool> isAttachedCompute = default;
            Optional<bool> disableLocalAuth = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("computeType"))
                {
                    computeType = new ComputeType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("computeLocation"))
                {
                    computeLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    provisioningState = new ProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createdOn"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    createdOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("modifiedOn"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    modifiedOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("resourceId"))
                {
                    resourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningErrors"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ErrorResponse> array = new List<ErrorResponse>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ErrorResponse.DeserializeErrorResponse(item));
                    }
                    provisioningErrors = array;
                    continue;
                }
                if (property.NameEquals("isAttachedCompute"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isAttachedCompute = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("disableLocalAuth"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    disableLocalAuth = property.Value.GetBoolean();
                    continue;
                }
            }
            return new Compute(computeType, computeLocation.Value, Optional.ToNullable(provisioningState), description.Value, Optional.ToNullable(createdOn), Optional.ToNullable(modifiedOn), resourceId.Value, Optional.ToList(provisioningErrors), Optional.ToNullable(isAttachedCompute), Optional.ToNullable(disableLocalAuth));
        }
    }
}
