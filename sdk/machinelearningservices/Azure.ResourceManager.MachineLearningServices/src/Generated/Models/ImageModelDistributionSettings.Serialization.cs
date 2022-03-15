// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    public partial class ImageModelDistributionSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(AmsGradient))
            {
                if (AmsGradient != null)
                {
                    writer.WritePropertyName("amsGradient");
                    writer.WriteStringValue(AmsGradient);
                }
                else
                {
                    writer.WriteNull("amsGradient");
                }
            }
            if (Optional.IsDefined(Augmentations))
            {
                if (Augmentations != null)
                {
                    writer.WritePropertyName("augmentations");
                    writer.WriteStringValue(Augmentations);
                }
                else
                {
                    writer.WriteNull("augmentations");
                }
            }
            if (Optional.IsDefined(Beta1))
            {
                if (Beta1 != null)
                {
                    writer.WritePropertyName("beta1");
                    writer.WriteStringValue(Beta1);
                }
                else
                {
                    writer.WriteNull("beta1");
                }
            }
            if (Optional.IsDefined(Beta2))
            {
                if (Beta2 != null)
                {
                    writer.WritePropertyName("beta2");
                    writer.WriteStringValue(Beta2);
                }
                else
                {
                    writer.WriteNull("beta2");
                }
            }
            if (Optional.IsDefined(Distributed))
            {
                if (Distributed != null)
                {
                    writer.WritePropertyName("distributed");
                    writer.WriteStringValue(Distributed);
                }
                else
                {
                    writer.WriteNull("distributed");
                }
            }
            if (Optional.IsDefined(EarlyStopping))
            {
                if (EarlyStopping != null)
                {
                    writer.WritePropertyName("earlyStopping");
                    writer.WriteStringValue(EarlyStopping);
                }
                else
                {
                    writer.WriteNull("earlyStopping");
                }
            }
            if (Optional.IsDefined(EarlyStoppingDelay))
            {
                if (EarlyStoppingDelay != null)
                {
                    writer.WritePropertyName("earlyStoppingDelay");
                    writer.WriteStringValue(EarlyStoppingDelay);
                }
                else
                {
                    writer.WriteNull("earlyStoppingDelay");
                }
            }
            if (Optional.IsDefined(EarlyStoppingPatience))
            {
                if (EarlyStoppingPatience != null)
                {
                    writer.WritePropertyName("earlyStoppingPatience");
                    writer.WriteStringValue(EarlyStoppingPatience);
                }
                else
                {
                    writer.WriteNull("earlyStoppingPatience");
                }
            }
            if (Optional.IsDefined(EnableOnnxNormalization))
            {
                if (EnableOnnxNormalization != null)
                {
                    writer.WritePropertyName("enableOnnxNormalization");
                    writer.WriteStringValue(EnableOnnxNormalization);
                }
                else
                {
                    writer.WriteNull("enableOnnxNormalization");
                }
            }
            if (Optional.IsDefined(EvaluationFrequency))
            {
                if (EvaluationFrequency != null)
                {
                    writer.WritePropertyName("evaluationFrequency");
                    writer.WriteStringValue(EvaluationFrequency);
                }
                else
                {
                    writer.WriteNull("evaluationFrequency");
                }
            }
            if (Optional.IsDefined(GradientAccumulationStep))
            {
                if (GradientAccumulationStep != null)
                {
                    writer.WritePropertyName("gradientAccumulationStep");
                    writer.WriteStringValue(GradientAccumulationStep);
                }
                else
                {
                    writer.WriteNull("gradientAccumulationStep");
                }
            }
            if (Optional.IsDefined(LayersToFreeze))
            {
                if (LayersToFreeze != null)
                {
                    writer.WritePropertyName("layersToFreeze");
                    writer.WriteStringValue(LayersToFreeze);
                }
                else
                {
                    writer.WriteNull("layersToFreeze");
                }
            }
            if (Optional.IsDefined(LearningRate))
            {
                if (LearningRate != null)
                {
                    writer.WritePropertyName("learningRate");
                    writer.WriteStringValue(LearningRate);
                }
                else
                {
                    writer.WriteNull("learningRate");
                }
            }
            if (Optional.IsDefined(LearningRateScheduler))
            {
                if (LearningRateScheduler != null)
                {
                    writer.WritePropertyName("learningRateScheduler");
                    writer.WriteStringValue(LearningRateScheduler);
                }
                else
                {
                    writer.WriteNull("learningRateScheduler");
                }
            }
            if (Optional.IsDefined(ModelName))
            {
                if (ModelName != null)
                {
                    writer.WritePropertyName("modelName");
                    writer.WriteStringValue(ModelName);
                }
                else
                {
                    writer.WriteNull("modelName");
                }
            }
            if (Optional.IsDefined(Momentum))
            {
                if (Momentum != null)
                {
                    writer.WritePropertyName("momentum");
                    writer.WriteStringValue(Momentum);
                }
                else
                {
                    writer.WriteNull("momentum");
                }
            }
            if (Optional.IsDefined(Nesterov))
            {
                if (Nesterov != null)
                {
                    writer.WritePropertyName("nesterov");
                    writer.WriteStringValue(Nesterov);
                }
                else
                {
                    writer.WriteNull("nesterov");
                }
            }
            if (Optional.IsDefined(NumberOfEpochs))
            {
                if (NumberOfEpochs != null)
                {
                    writer.WritePropertyName("numberOfEpochs");
                    writer.WriteStringValue(NumberOfEpochs);
                }
                else
                {
                    writer.WriteNull("numberOfEpochs");
                }
            }
            if (Optional.IsDefined(NumberOfWorkers))
            {
                if (NumberOfWorkers != null)
                {
                    writer.WritePropertyName("numberOfWorkers");
                    writer.WriteStringValue(NumberOfWorkers);
                }
                else
                {
                    writer.WriteNull("numberOfWorkers");
                }
            }
            if (Optional.IsDefined(Optimizer))
            {
                if (Optimizer != null)
                {
                    writer.WritePropertyName("optimizer");
                    writer.WriteStringValue(Optimizer);
                }
                else
                {
                    writer.WriteNull("optimizer");
                }
            }
            if (Optional.IsDefined(RandomSeed))
            {
                if (RandomSeed != null)
                {
                    writer.WritePropertyName("randomSeed");
                    writer.WriteStringValue(RandomSeed);
                }
                else
                {
                    writer.WriteNull("randomSeed");
                }
            }
            if (Optional.IsDefined(SplitRatio))
            {
                if (SplitRatio != null)
                {
                    writer.WritePropertyName("splitRatio");
                    writer.WriteStringValue(SplitRatio);
                }
                else
                {
                    writer.WriteNull("splitRatio");
                }
            }
            if (Optional.IsDefined(StepLRGamma))
            {
                if (StepLRGamma != null)
                {
                    writer.WritePropertyName("stepLRGamma");
                    writer.WriteStringValue(StepLRGamma);
                }
                else
                {
                    writer.WriteNull("stepLRGamma");
                }
            }
            if (Optional.IsDefined(StepLRStepSize))
            {
                if (StepLRStepSize != null)
                {
                    writer.WritePropertyName("stepLRStepSize");
                    writer.WriteStringValue(StepLRStepSize);
                }
                else
                {
                    writer.WriteNull("stepLRStepSize");
                }
            }
            if (Optional.IsDefined(TrainingBatchSize))
            {
                if (TrainingBatchSize != null)
                {
                    writer.WritePropertyName("trainingBatchSize");
                    writer.WriteStringValue(TrainingBatchSize);
                }
                else
                {
                    writer.WriteNull("trainingBatchSize");
                }
            }
            if (Optional.IsDefined(ValidationBatchSize))
            {
                if (ValidationBatchSize != null)
                {
                    writer.WritePropertyName("validationBatchSize");
                    writer.WriteStringValue(ValidationBatchSize);
                }
                else
                {
                    writer.WriteNull("validationBatchSize");
                }
            }
            if (Optional.IsDefined(WarmupCosineLRCycles))
            {
                if (WarmupCosineLRCycles != null)
                {
                    writer.WritePropertyName("warmupCosineLRCycles");
                    writer.WriteStringValue(WarmupCosineLRCycles);
                }
                else
                {
                    writer.WriteNull("warmupCosineLRCycles");
                }
            }
            if (Optional.IsDefined(WarmupCosineLRWarmupEpochs))
            {
                if (WarmupCosineLRWarmupEpochs != null)
                {
                    writer.WritePropertyName("warmupCosineLRWarmupEpochs");
                    writer.WriteStringValue(WarmupCosineLRWarmupEpochs);
                }
                else
                {
                    writer.WriteNull("warmupCosineLRWarmupEpochs");
                }
            }
            if (Optional.IsDefined(WeightDecay))
            {
                if (WeightDecay != null)
                {
                    writer.WritePropertyName("weightDecay");
                    writer.WriteStringValue(WeightDecay);
                }
                else
                {
                    writer.WriteNull("weightDecay");
                }
            }
            writer.WriteEndObject();
        }

        internal static ImageModelDistributionSettings DeserializeImageModelDistributionSettings(JsonElement element)
        {
            Optional<string> amsGradient = default;
            Optional<string> augmentations = default;
            Optional<string> beta1 = default;
            Optional<string> beta2 = default;
            Optional<string> distributed = default;
            Optional<string> earlyStopping = default;
            Optional<string> earlyStoppingDelay = default;
            Optional<string> earlyStoppingPatience = default;
            Optional<string> enableOnnxNormalization = default;
            Optional<string> evaluationFrequency = default;
            Optional<string> gradientAccumulationStep = default;
            Optional<string> layersToFreeze = default;
            Optional<string> learningRate = default;
            Optional<string> learningRateScheduler = default;
            Optional<string> modelName = default;
            Optional<string> momentum = default;
            Optional<string> nesterov = default;
            Optional<string> numberOfEpochs = default;
            Optional<string> numberOfWorkers = default;
            Optional<string> optimizer = default;
            Optional<string> randomSeed = default;
            Optional<string> splitRatio = default;
            Optional<string> stepLRGamma = default;
            Optional<string> stepLRStepSize = default;
            Optional<string> trainingBatchSize = default;
            Optional<string> validationBatchSize = default;
            Optional<string> warmupCosineLRCycles = default;
            Optional<string> warmupCosineLRWarmupEpochs = default;
            Optional<string> weightDecay = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("amsGradient"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        amsGradient = null;
                        continue;
                    }
                    amsGradient = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("augmentations"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        augmentations = null;
                        continue;
                    }
                    augmentations = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("beta1"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        beta1 = null;
                        continue;
                    }
                    beta1 = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("beta2"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        beta2 = null;
                        continue;
                    }
                    beta2 = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("distributed"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        distributed = null;
                        continue;
                    }
                    distributed = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("earlyStopping"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        earlyStopping = null;
                        continue;
                    }
                    earlyStopping = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("earlyStoppingDelay"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        earlyStoppingDelay = null;
                        continue;
                    }
                    earlyStoppingDelay = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("earlyStoppingPatience"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        earlyStoppingPatience = null;
                        continue;
                    }
                    earlyStoppingPatience = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("enableOnnxNormalization"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        enableOnnxNormalization = null;
                        continue;
                    }
                    enableOnnxNormalization = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("evaluationFrequency"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        evaluationFrequency = null;
                        continue;
                    }
                    evaluationFrequency = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("gradientAccumulationStep"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        gradientAccumulationStep = null;
                        continue;
                    }
                    gradientAccumulationStep = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("layersToFreeze"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        layersToFreeze = null;
                        continue;
                    }
                    layersToFreeze = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("learningRate"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        learningRate = null;
                        continue;
                    }
                    learningRate = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("learningRateScheduler"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        learningRateScheduler = null;
                        continue;
                    }
                    learningRateScheduler = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("modelName"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        modelName = null;
                        continue;
                    }
                    modelName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("momentum"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        momentum = null;
                        continue;
                    }
                    momentum = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("nesterov"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        nesterov = null;
                        continue;
                    }
                    nesterov = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("numberOfEpochs"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        numberOfEpochs = null;
                        continue;
                    }
                    numberOfEpochs = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("numberOfWorkers"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        numberOfWorkers = null;
                        continue;
                    }
                    numberOfWorkers = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("optimizer"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        optimizer = null;
                        continue;
                    }
                    optimizer = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("randomSeed"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        randomSeed = null;
                        continue;
                    }
                    randomSeed = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("splitRatio"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        splitRatio = null;
                        continue;
                    }
                    splitRatio = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("stepLRGamma"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        stepLRGamma = null;
                        continue;
                    }
                    stepLRGamma = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("stepLRStepSize"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        stepLRStepSize = null;
                        continue;
                    }
                    stepLRStepSize = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("trainingBatchSize"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        trainingBatchSize = null;
                        continue;
                    }
                    trainingBatchSize = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("validationBatchSize"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        validationBatchSize = null;
                        continue;
                    }
                    validationBatchSize = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("warmupCosineLRCycles"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        warmupCosineLRCycles = null;
                        continue;
                    }
                    warmupCosineLRCycles = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("warmupCosineLRWarmupEpochs"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        warmupCosineLRWarmupEpochs = null;
                        continue;
                    }
                    warmupCosineLRWarmupEpochs = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("weightDecay"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        weightDecay = null;
                        continue;
                    }
                    weightDecay = property.Value.GetString();
                    continue;
                }
            }
            return new ImageModelDistributionSettings(amsGradient.Value, augmentations.Value, beta1.Value, beta2.Value, distributed.Value, earlyStopping.Value, earlyStoppingDelay.Value, earlyStoppingPatience.Value, enableOnnxNormalization.Value, evaluationFrequency.Value, gradientAccumulationStep.Value, layersToFreeze.Value, learningRate.Value, learningRateScheduler.Value, modelName.Value, momentum.Value, nesterov.Value, numberOfEpochs.Value, numberOfWorkers.Value, optimizer.Value, randomSeed.Value, splitRatio.Value, stepLRGamma.Value, stepLRStepSize.Value, trainingBatchSize.Value, validationBatchSize.Value, warmupCosineLRCycles.Value, warmupCosineLRWarmupEpochs.Value, weightDecay.Value);
        }
    }
}
