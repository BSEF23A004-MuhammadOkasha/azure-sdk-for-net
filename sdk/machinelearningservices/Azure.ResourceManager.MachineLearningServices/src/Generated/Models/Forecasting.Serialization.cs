// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    public partial class Forecasting : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(AllowedModels))
            {
                if (AllowedModels != null)
                {
                    writer.WritePropertyName("allowedModels");
                    writer.WriteStartArray();
                    foreach (var item in AllowedModels)
                    {
                        writer.WriteStringValue(item.ToString());
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("allowedModels");
                }
            }
            if (Optional.IsCollectionDefined(BlockedModels))
            {
                if (BlockedModels != null)
                {
                    writer.WritePropertyName("blockedModels");
                    writer.WriteStartArray();
                    foreach (var item in BlockedModels)
                    {
                        writer.WriteStringValue(item.ToString());
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("blockedModels");
                }
            }
            if (Optional.IsDefined(ForecastingSettings))
            {
                if (ForecastingSettings != null)
                {
                    writer.WritePropertyName("forecastingSettings");
                    writer.WriteObjectValue(ForecastingSettings);
                }
                else
                {
                    writer.WriteNull("forecastingSettings");
                }
            }
            if (Optional.IsDefined(PrimaryMetric))
            {
                writer.WritePropertyName("primaryMetric");
                writer.WriteStringValue(PrimaryMetric.Value.ToString());
            }
            if (Optional.IsDefined(DataSettings))
            {
                if (DataSettings != null)
                {
                    writer.WritePropertyName("dataSettings");
                    writer.WriteObjectValue(DataSettings);
                }
                else
                {
                    writer.WriteNull("dataSettings");
                }
            }
            if (Optional.IsDefined(FeaturizationSettings))
            {
                if (FeaturizationSettings != null)
                {
                    writer.WritePropertyName("featurizationSettings");
                    writer.WriteObjectValue(FeaturizationSettings);
                }
                else
                {
                    writer.WriteNull("featurizationSettings");
                }
            }
            if (Optional.IsDefined(LimitSettings))
            {
                if (LimitSettings != null)
                {
                    writer.WritePropertyName("limitSettings");
                    writer.WriteObjectValue(LimitSettings);
                }
                else
                {
                    writer.WriteNull("limitSettings");
                }
            }
            if (Optional.IsDefined(TrainingSettings))
            {
                if (TrainingSettings != null)
                {
                    writer.WritePropertyName("trainingSettings");
                    writer.WriteObjectValue(TrainingSettings);
                }
                else
                {
                    writer.WriteNull("trainingSettings");
                }
            }
            if (Optional.IsDefined(LogVerbosity))
            {
                writer.WritePropertyName("logVerbosity");
                writer.WriteStringValue(LogVerbosity.Value.ToString());
            }
            writer.WritePropertyName("taskType");
            writer.WriteStringValue(TaskType.ToString());
            writer.WriteEndObject();
        }

        internal static Forecasting DeserializeForecasting(JsonElement element)
        {
            Optional<IList<ForecastingModels>> allowedModels = default;
            Optional<IList<ForecastingModels>> blockedModels = default;
            Optional<ForecastingSettings> forecastingSettings = default;
            Optional<ForecastingPrimaryMetrics> primaryMetric = default;
            Optional<TableVerticalDataSettings> dataSettings = default;
            Optional<TableVerticalFeaturizationSettings> featurizationSettings = default;
            Optional<TableVerticalLimitSettings> limitSettings = default;
            Optional<TrainingSettings> trainingSettings = default;
            Optional<LogVerbosity> logVerbosity = default;
            TaskType taskType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("allowedModels"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        allowedModels = null;
                        continue;
                    }
                    List<ForecastingModels> array = new List<ForecastingModels>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new ForecastingModels(item.GetString()));
                    }
                    allowedModels = array;
                    continue;
                }
                if (property.NameEquals("blockedModels"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        blockedModels = null;
                        continue;
                    }
                    List<ForecastingModels> array = new List<ForecastingModels>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new ForecastingModels(item.GetString()));
                    }
                    blockedModels = array;
                    continue;
                }
                if (property.NameEquals("forecastingSettings"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        forecastingSettings = null;
                        continue;
                    }
                    forecastingSettings = ForecastingSettings.DeserializeForecastingSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("primaryMetric"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    primaryMetric = new ForecastingPrimaryMetrics(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dataSettings"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        dataSettings = null;
                        continue;
                    }
                    dataSettings = TableVerticalDataSettings.DeserializeTableVerticalDataSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("featurizationSettings"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        featurizationSettings = null;
                        continue;
                    }
                    featurizationSettings = TableVerticalFeaturizationSettings.DeserializeTableVerticalFeaturizationSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("limitSettings"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        limitSettings = null;
                        continue;
                    }
                    limitSettings = TableVerticalLimitSettings.DeserializeTableVerticalLimitSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("trainingSettings"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        trainingSettings = null;
                        continue;
                    }
                    trainingSettings = TrainingSettings.DeserializeTrainingSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("logVerbosity"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    logVerbosity = new LogVerbosity(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("taskType"))
                {
                    taskType = new TaskType(property.Value.GetString());
                    continue;
                }
            }
            return new Forecasting(Optional.ToNullable(logVerbosity), taskType, Optional.ToList(allowedModels), Optional.ToList(blockedModels), forecastingSettings.Value, Optional.ToNullable(primaryMetric), dataSettings.Value, featurizationSettings.Value, limitSettings.Value, trainingSettings.Value);
        }
    }
}
