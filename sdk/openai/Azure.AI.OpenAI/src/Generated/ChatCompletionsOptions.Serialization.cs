// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.AI.OpenAI
{
    public partial class ChatCompletionsOptions : IUtf8JsonSerializable, IJsonModel<ChatCompletionsOptions>
    {
        void IJsonModel<ChatCompletionsOptions>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChatCompletionsOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ChatCompletionsOptions)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("messages"u8);
            writer.WriteStartArray();
            foreach (var item in Messages)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsCollectionDefined(Functions))
            {
                writer.WritePropertyName("functions"u8);
                writer.WriteStartArray();
                foreach (var item in Functions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(FunctionCall))
            {
                writer.WritePropertyName("function_call"u8);
                writer.WriteObjectValue(FunctionCall);
            }
            if (Optional.IsDefined(MaxTokens))
            {
                writer.WritePropertyName("max_tokens"u8);
                writer.WriteNumberValue(MaxTokens.Value);
            }
            if (Optional.IsDefined(Temperature))
            {
                writer.WritePropertyName("temperature"u8);
                writer.WriteNumberValue(Temperature.Value);
            }
            if (Optional.IsDefined(NucleusSamplingFactor))
            {
                writer.WritePropertyName("top_p"u8);
                writer.WriteNumberValue(NucleusSamplingFactor.Value);
            }
            if (Optional.IsCollectionDefined(InternalStringKeyedTokenSelectionBiases))
            {
                writer.WritePropertyName("logit_bias"u8);
                writer.WriteStartObject();
                foreach (var item in InternalStringKeyedTokenSelectionBiases)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteNumberValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(User))
            {
                writer.WritePropertyName("user"u8);
                writer.WriteStringValue(User);
            }
            if (Optional.IsDefined(ChoiceCount))
            {
                writer.WritePropertyName("n"u8);
                writer.WriteNumberValue(ChoiceCount.Value);
            }
            if (Optional.IsCollectionDefined(StopSequences))
            {
                writer.WritePropertyName("stop"u8);
                writer.WriteStartArray();
                foreach (var item in StopSequences)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(PresencePenalty))
            {
                writer.WritePropertyName("presence_penalty"u8);
                writer.WriteNumberValue(PresencePenalty.Value);
            }
            if (Optional.IsDefined(FrequencyPenalty))
            {
                writer.WritePropertyName("frequency_penalty"u8);
                writer.WriteNumberValue(FrequencyPenalty.Value);
            }
            if (Optional.IsDefined(InternalShouldStreamResponse))
            {
                writer.WritePropertyName("stream"u8);
                writer.WriteBooleanValue(InternalShouldStreamResponse.Value);
            }
            if (Optional.IsDefined(DeploymentName))
            {
                writer.WritePropertyName("model"u8);
                writer.WriteStringValue(DeploymentName);
            }
            if (Optional.IsCollectionDefined(InternalAzureExtensionsDataSources))
            {
                writer.WritePropertyName("dataSources"u8);
                writer.WriteStartArray();
                foreach (var item in InternalAzureExtensionsDataSources)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        ChatCompletionsOptions IJsonModel<ChatCompletionsOptions>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChatCompletionsOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ChatCompletionsOptions)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeChatCompletionsOptions(document.RootElement, options);
        }

        internal static ChatCompletionsOptions DeserializeChatCompletionsOptions(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<ChatMessage> messages = default;
            Optional<IList<FunctionDefinition>> functions = default;
            Optional<FunctionDefinition> functionCall = default;
            Optional<int> maxTokens = default;
            Optional<float> temperature = default;
            Optional<float> topP = default;
            Optional<IDictionary<string, int>> logitBias = default;
            Optional<string> user = default;
            Optional<int> n = default;
            Optional<IList<string>> stop = default;
            Optional<float> presencePenalty = default;
            Optional<float> frequencyPenalty = default;
            Optional<bool> stream = default;
            Optional<string> model = default;
            Optional<IList<AzureChatExtensionConfiguration>> dataSources = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("messages"u8))
                {
                    List<ChatMessage> array = new List<ChatMessage>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ChatMessage.DeserializeChatMessage(item));
                    }
                    messages = array;
                    continue;
                }
                if (property.NameEquals("functions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FunctionDefinition> array = new List<FunctionDefinition>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FunctionDefinition.DeserializeFunctionDefinition(item));
                    }
                    functions = array;
                    continue;
                }
                if (property.NameEquals("function_call"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    functionCall = FunctionDefinition.DeserializeFunctionDefinition(property.Value);
                    continue;
                }
                if (property.NameEquals("max_tokens"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxTokens = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("temperature"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    temperature = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("top_p"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    topP = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("logit_bias"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, int> dictionary = new Dictionary<string, int>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetInt32());
                    }
                    logitBias = dictionary;
                    continue;
                }
                if (property.NameEquals("user"u8))
                {
                    user = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("n"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    n = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("stop"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    stop = array;
                    continue;
                }
                if (property.NameEquals("presence_penalty"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    presencePenalty = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("frequency_penalty"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    frequencyPenalty = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("stream"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    stream = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("model"u8))
                {
                    model = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataSources"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AzureChatExtensionConfiguration> array = new List<AzureChatExtensionConfiguration>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AzureChatExtensionConfiguration.DeserializeAzureChatExtensionConfiguration(item));
                    }
                    dataSources = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ChatCompletionsOptions(messages, Optional.ToList(functions), functionCall.Value, Optional.ToNullable(maxTokens), Optional.ToNullable(temperature), Optional.ToNullable(topP), Optional.ToDictionary(logitBias), user.Value, Optional.ToNullable(n), Optional.ToList(stop), Optional.ToNullable(presencePenalty), Optional.ToNullable(frequencyPenalty), Optional.ToNullable(stream), model.Value, Optional.ToList(dataSources), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ChatCompletionsOptions>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChatCompletionsOptions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(ChatCompletionsOptions)} does not support '{options.Format}' format.");
            }
        }

        ChatCompletionsOptions IPersistableModel<ChatCompletionsOptions>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChatCompletionsOptions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeChatCompletionsOptions(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(ChatCompletionsOptions)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ChatCompletionsOptions>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ChatCompletionsOptions FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeChatCompletionsOptions(document.RootElement, new ModelReaderWriterOptions("W"));
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
