﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.Tracing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Diagnostics;
using Azure.Core.Pipeline;
using Azure.Core.TestFramework;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using static System.Net.WebRequestMethods;

namespace Azure.AI.Inference.Tests
{
    public class InferenceClientTest: RecordedTestBase<InferenceClientTestEnvironment>
    {
        public enum ToolChoiceTestType
        {
            DoNotSpecifyToolChoice,
            UseAutoPresetToolChoice,
            UseNonePresetToolChoice,
            UseRequiredPresetToolChoice,
            UseFunctionByExplicitToolDefinitionForToolChoice,
            UseFunctionByImplicitToolDefinitionForToolChoice,
        }

        public InferenceClientTest(bool isAsync) : base(isAsync, RecordedTestMode.Live)
        {
        }

        /* please refer to https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/template/Azure.Template/tests/TemplateClientLiveTests.cs to write tests. */

        [RecordedTest]
        public async Task TestChatCompletions()
        {
            var mistralSmallEndpoint = new Uri(TestEnvironment.MistralSmallEndpoint);
            var mistralSmallCredential = new AzureKeyCredential(TestEnvironment.MistralSmallApiKey);

            // var client = CreateClient(endpoint, credential);
            var client = new ChatCompletionsClient(mistralSmallEndpoint, mistralSmallCredential, new ChatCompletionsClientOptions());

            var requestOptions = new ChatCompletionsOptions()
            {
                Messages =
                {
                    new ChatRequestSystemMessage("You are a helpful assistant."),
                    new ChatRequestUserMessage("How many feet are in a mile?"),
                },
            };

            Response<ChatCompletions> response = await client.CompleteAsync(requestOptions);

            Assert.That(response, Is.Not.Null);
            Assert.That(response.Value, Is.InstanceOf<ChatCompletions>());
            Assert.That(response.Value.Id, Is.Not.Null.Or.Empty);
            Assert.That(response.Value.Created, Is.Not.Null.Or.Empty);
            Assert.That(response.Value.Choices, Is.Not.Null.Or.Empty);
            Assert.That(response.Value.Choices.Count, Is.EqualTo(1));
            ChatChoice choice = response.Value.Choices[0];
            Assert.That(choice.Index, Is.EqualTo(0));
            Assert.That(choice.FinishReason, Is.EqualTo(CompletionsFinishReason.Stopped));
            Assert.That(choice.Message.Role, Is.EqualTo(ChatRole.Assistant));
            Assert.That(choice.Message.Content, Is.Not.Null.Or.Empty);
        }

        [RecordedTest]
        public async Task TestStreamingChatCompletions()
        {
            var mistralSmallEndpoint = new Uri(TestEnvironment.MistralSmallEndpoint);
            var mistralSmallCredential = new AzureKeyCredential(TestEnvironment.MistralSmallApiKey);

            // var client = CreateClient(endpoint, credential);
            var clientOptions = new ChatCompletionsClientOptions();
            var client = new ChatCompletionsClient(mistralSmallEndpoint, mistralSmallCredential, clientOptions);

            var requestOptions = new ChatCompletionsOptions()
            {
                Messages =
                {
                    new ChatRequestSystemMessage("You are a helpful assistant."),
                    new ChatRequestUserMessage("How many feet are in a mile?"),
                },
                MaxTokens = 512,
            };

            StreamingResponse<StreamingChatCompletionsUpdate> response
                = await client.CompleteStreamingAsync(requestOptions);
            Assert.That(response, Is.Not.Null);

            StringBuilder contentBuilder = new();
            string id = null;
            string model = null;
            bool gotRole = false;

            await foreach (StreamingChatCompletionsUpdate chatUpdate in response)
            {
                Assert.That(chatUpdate, Is.Not.Null);

                Assert.That(chatUpdate.Id, Is.Not.Null.Or.Empty);
                Assert.That(chatUpdate.Created, Is.GreaterThan(new DateTimeOffset(new DateTime(2023, 1, 1))));
                Assert.That(chatUpdate.Created, Is.LessThan(DateTimeOffset.UtcNow.AddDays(7)));

                if (!string.IsNullOrEmpty(chatUpdate.Id))
                {
                    Assert.That((id is null) || (id == chatUpdate.Id));
                    id = chatUpdate.Id;
                }
                if (!string.IsNullOrEmpty(chatUpdate.Model))
                {
                    Assert.That((model is null) || (model == chatUpdate.Model));
                    model = chatUpdate.Model;
                }
                if (chatUpdate.Role.HasValue)
                {
                    Assert.IsFalse(gotRole);
                    Assert.That(chatUpdate.Role.Value, Is.EqualTo(ChatRole.Assistant));
                    gotRole = true;
                }
                if (!string.IsNullOrEmpty(chatUpdate.ContentUpdate))
                {
                    contentBuilder.Append(chatUpdate.ContentUpdate);
                }
            }

            Assert.IsTrue(!string.IsNullOrEmpty(id));
            Assert.IsTrue(!string.IsNullOrEmpty(model));
            Assert.IsTrue(gotRole);
            var result = contentBuilder.ToString();
            Assert.That(contentBuilder.ToString(), Is.Not.Null.Or.Empty);
        }

        [RecordedTest]
        public async Task TestSendModelExtras()
        {
            var mistralSmallEndpoint = new Uri(TestEnvironment.MistralSmallEndpoint);
            var mistralSmallCredential = new AzureKeyCredential(TestEnvironment.MistralSmallApiKey);

            CaptureRequestPayloadPolicy captureRequestPayloadPolicy = new CaptureRequestPayloadPolicy();
            ChatCompletionsClientOptions clientOptions = new ChatCompletionsClientOptions();
            clientOptions.AddPolicy(captureRequestPayloadPolicy, HttpPipelinePosition.PerCall);

            // var client = CreateClient(endpoint, credential);
            var client = new ChatCompletionsClient(mistralSmallEndpoint, mistralSmallCredential, clientOptions);
            List<ChatRequestMessage> messages = new List<ChatRequestMessage>
            {
                new ChatRequestSystemMessage("You are a helpful assistant."),
                new ChatRequestUserMessage("How many feet are in a mile?"),
            };
            Dictionary<string, BinaryData> additionalProperties = new Dictionary<string, BinaryData>() { { "foo", BinaryData.FromString("\"bar\"") } };

            var requestOptions = new ChatCompletionsOptions()
            {
                Messages =
                {
                    new ChatRequestSystemMessage("You are a helpful assistant."),
                    new ChatRequestUserMessage("How many feet are in a mile?"),
                },
                AdditionalProperties = { { "foo", BinaryData.FromString("\"bar\"") } },
            };

            var exceptionThrown = false;

            try
            {
                await client.CompleteAsync(requestOptions);
            }
            catch (Exception e)
            {
                exceptionThrown = true;
                Assert.IsTrue(e.Message.Contains("Extra inputs are not permitted"));
                Assert.IsTrue(captureRequestPayloadPolicy._requestContent.Contains("foo"));
                Assert.IsTrue(captureRequestPayloadPolicy._requestHeaders.ContainsKey("extra-parameters"));
                Assert.IsTrue(captureRequestPayloadPolicy._requestHeaders["extra-parameters"] == ExtraParams.PassThrough);
            }
            Assert.IsTrue(exceptionThrown);

            exceptionThrown = false;
            try
            {
                 await client.CompleteAsync(requestOptions, ExtraParams.PassThrough);
            }
            catch (Exception e)
            {
                exceptionThrown = true;
                Assert.IsTrue(e.Message.Contains("Extra inputs are not permitted"));
                Assert.IsTrue(captureRequestPayloadPolicy._requestContent.Contains("foo"));
            }
            Assert.IsTrue(exceptionThrown);

            /*
            // To be enabled once ExtraParams is implemented in the service
            var response = await client.CompleteAsync(requestOptions, ExtraParams.Drop);

            Assert.IsTrue(captureRequestPayloadPolicy._requestContent.Contains("foo"));

            Assert.That(response, Is.Not.Null);
            Assert.That(response.Value, Is.InstanceOf<ChatCompletions>());
            Assert.That(response.Value.Id, Is.Not.Null.Or.Empty);
            Assert.That(response.Value.Created, Is.Not.Null.Or.Empty);
            Assert.That(response.Value.Choices, Is.Not.Null.Or.Empty);
            Assert.That(response.Value.Choices.Count, Is.EqualTo(1));
            ChatChoice choice = response.Value.Choices[0];
            Assert.That(choice.Index, Is.EqualTo(0));
            Assert.That(choice.FinishReason, Is.EqualTo(CompletionsFinishReason.Stopped));
            Assert.That(choice.Message.Role, Is.EqualTo(ChatRole.Assistant));
            Assert.That(choice.Message.Content, Is.Not.Null.Or.Empty);
            */
        }

        [RecordedTest]
        [TestCase(ToolChoiceTestType.DoNotSpecifyToolChoice)]
        [TestCase(ToolChoiceTestType.UseAutoPresetToolChoice)]
        [TestCase(ToolChoiceTestType.UseNonePresetToolChoice)]
        [TestCase(ToolChoiceTestType.UseRequiredPresetToolChoice)]
        [TestCase(ToolChoiceTestType.UseFunctionByExplicitToolDefinitionForToolChoice)]
        [TestCase(ToolChoiceTestType.UseFunctionByImplicitToolDefinitionForToolChoice)]
        public async Task TestChatCompletionsFunctionToolHandling(ToolChoiceTestType toolChoiceType = ToolChoiceTestType.DoNotSpecifyToolChoice)
        {
            FunctionDefinition futureTemperatureFunction = new FunctionDefinition("get_future_temperature")
            {
                Description = "requests the anticipated future temperature at a provided location to help inform "
                + "advice about topics like choice of attire",
                Parameters = BinaryData.FromObjectAsJson(new
                {
                    Type = "object",
                    Properties = new
                    {
                        LocationName = new
                        {
                            Type = "string",
                            Description = "the name or brief description of a location for weather information"
                        },
                        DaysInAdvance = new
                        {
                            Type = "integer",
                            Description = "the number of days in the future for which to retrieve weather information"
                        }
                    }
                },
                new JsonSerializerOptions() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase })
            };

            ChatCompletionsFunctionToolDefinition functionToolDef = new ChatCompletionsFunctionToolDefinition(futureTemperatureFunction);

            // var mistralSmallEndpoint = new Uri(TestEnvironment.MistralSmallEndpoint);
            // var mistralSmallCredential = new AzureKeyCredential(TestEnvironment.MistralSmallApiKey);

            var githubEndpoint = new Uri(TestEnvironment.GithubEndpoint);
            var githubModelName = "gpt-4o";
            var githubCredential = new AzureKeyCredential(TestEnvironment.GithubToken);

            /// AzureEventSourceListener listener = AzureEventSourceListener.CreateConsoleLogger(EventLevel.Verbose);

            // var client = CreateClient(endpoint, credential);
            CaptureRequestPayloadPolicy captureRequestPayloadPolicy = new CaptureRequestPayloadPolicy();
            ChatCompletionsClientOptions clientOptions = new ChatCompletionsClientOptions();
            clientOptions.AddPolicy(captureRequestPayloadPolicy, HttpPipelinePosition.PerCall);
            // clientOptions.Diagnostics.IsLoggingContentEnabled = true;
            //var client = new ChatCompletionsClient(mistralSmallEndpoint, mistralSmallCredential, clientOptions);

            var client = new ChatCompletionsClient(githubEndpoint, githubCredential, clientOptions);

            var requestOptions = new ChatCompletionsOptions()
            {
                Messages =
                {
                    new ChatRequestSystemMessage("You are a helpful assistant."),
                    new ChatRequestUserMessage("What should I wear in Honolulu in 3 days?"),
                },
                MaxTokens = 512,
                Tools = { functionToolDef },
                Model = githubModelName,
            };

            requestOptions.ToolChoice = toolChoiceType switch
            {
                ToolChoiceTestType.UseAutoPresetToolChoice => ChatCompletionsToolChoice.Auto,
                ToolChoiceTestType.UseNonePresetToolChoice => ChatCompletionsToolChoice.None,
                ToolChoiceTestType.UseRequiredPresetToolChoice => ChatCompletionsToolChoice.Required,
                ToolChoiceTestType.UseFunctionByExplicitToolDefinitionForToolChoice => new ChatCompletionsToolChoice(functionToolDef),
                ToolChoiceTestType.UseFunctionByImplicitToolDefinitionForToolChoice => functionToolDef,
                _ => null,
            };

            Response<ChatCompletions> response = null;
            try
            {
                response = await client.CompleteAsync(requestOptions);
            }
            catch (Exception ex)
            {
                var requestPayload = captureRequestPayloadPolicy._requestContent;
                var requestHeaders = captureRequestPayloadPolicy._requestHeaders;
                Assert.True(false, $"Request failed with the following exception:\n {ex}\n Request headers: {requestHeaders}\n Request payload: {requestPayload}");
            }

            Assert.That(response, Is.Not.Null);

            Assert.That(response.Value, Is.Not.Null);
            Assert.That(response.Value.Choices, Is.Not.Null.Or.Empty);

            ChatChoice choice = response.Value.Choices[0];

            if (toolChoiceType == ToolChoiceTestType.UseNonePresetToolChoice)
            {
                Assert.That(choice.FinishReason, Is.EqualTo(CompletionsFinishReason.Stopped));
                Assert.That(choice.Message.ToolCalls, Is.Null.Or.Empty);
                // We finish the test here as there's no further exercise for 'none' beyond ensuring we didn't do what we
                // weren't meant to
                return;
            }
            else if (toolChoiceType == ToolChoiceTestType.UseAutoPresetToolChoice || toolChoiceType == ToolChoiceTestType.DoNotSpecifyToolChoice)
            {
                // Assert.That(choice.FinishReason, Is.EqualTo(CompletionsFinishReason.ToolCalls));
                // and continue the test
            }
            else
            {
                Assert.That(choice.FinishReason, Is.EqualTo(CompletionsFinishReason.Stopped));
                // and continue the test, as we will have tool_calls
            }

            ChatResponseMessage message = choice.Message;
            Assert.That(message.Role, Is.EqualTo(ChatRole.Assistant));
            Assert.That(message.Content, Is.Null.Or.Empty);
            Assert.That(message.ToolCalls, Is.Not.Null.Or.Empty);
            Assert.That(message.ToolCalls.Count, Is.EqualTo(1));
            ChatCompletionsFunctionToolCall functionToolCall = message.ToolCalls[0] as ChatCompletionsFunctionToolCall;
            Assert.That(functionToolCall, Is.Not.Null);
            Assert.That(functionToolCall.Name, Is.EqualTo(futureTemperatureFunction.Name));
            Assert.That(functionToolCall.Arguments, Is.Not.Null.Or.Empty);

            Dictionary<string, string> arguments
                = JsonConvert.DeserializeObject<Dictionary<string, string>>(functionToolCall.Arguments);
            Assert.That(arguments.ContainsKey("locationName"));
            Assert.That(arguments.ContainsKey("daysInAdvance"));

            ChatCompletionsOptions followupOptions = new()
            {
                Tools = { functionToolDef },
                MaxTokens = 512,
                Model = githubModelName,
            };

            // Include all original messages
            foreach (ChatRequestMessage originalMessage in requestOptions.Messages)
            {
                followupOptions.Messages.Add(originalMessage);
            }
            // And the tool call message just received back from the assistant
            followupOptions.Messages.Add(new ChatRequestAssistantMessage(choice.Message));

            // And also the tool message that resolves the tool call
            followupOptions.Messages.Add(new ChatRequestToolMessage(
                toolCallId: functionToolCall.Id,
                content: "31 celsius"));

            Response<ChatCompletions> followupResponse = null;
            try
            {
                followupResponse = await client.CompleteAsync(followupOptions);
            }
            catch (Exception ex)
            {
                var requestPayload = captureRequestPayloadPolicy._requestContent;
                var requestHeaders = captureRequestPayloadPolicy._requestHeaders;
                Assert.True(false, $"Request failed with the following exception:\n {ex}\n Request headers: {requestHeaders}\n Request payload: {requestPayload}");
            }

            Assert.That(followupResponse, Is.Not.Null);
            Assert.That(followupResponse.Value, Is.Not.Null);
            Assert.That(followupResponse.Value.Choices, Is.Not.Null.Or.Empty);
            Assert.That(followupResponse.Value.Choices[0], Is.Not.Null);
            Assert.That(followupResponse.Value.Choices[0].Message, Is.Not.Null);
            Assert.That(followupResponse.Value.Choices[0].Message.Role, Is.EqualTo(ChatRole.Assistant));
            Assert.That(followupResponse.Value.Choices[0].Message.Content, Is.Not.Null.Or.Empty);
        }

        #region Helpers
        private class CaptureRequestPayloadPolicy : HttpPipelinePolicy
        {
            public string _requestContent;
            public Dictionary<string, string> _requestHeaders;

            public override void Process(HttpMessage message, ReadOnlyMemory<HttpPipelinePolicy> pipeline)
            {
                var memStream = new MemoryStream();
                message.Request.Content.WriteTo(memStream, new System.Threading.CancellationToken());
                _requestContent = Encoding.UTF8.GetString(memStream.ToArray());

                _requestHeaders = message.Request.Headers.ToDictionary(a => a.Name, a => a.Value);

                ProcessNext(message, pipeline);
            }

            public override ValueTask ProcessAsync(HttpMessage message, ReadOnlyMemory<HttpPipelinePolicy> pipeline)
            {
                var memStream = new MemoryStream();
                message.Request.Content.WriteTo(memStream, new System.Threading.CancellationToken());
                _requestContent = Encoding.UTF8.GetString(memStream.ToArray());

                _requestHeaders = message.Request.Headers.ToDictionary(a=>a.Name, a=>a.Value);

                return ProcessNextAsync(message, pipeline);
            }
        }

        private ChatCompletionsClient CreateClient(Uri endpoint, AzureKeyCredential credential)
        {
            return InstrumentClient(new ChatCompletionsClient(endpoint, credential, InstrumentClientOptions(new ChatCompletionsClientOptions())));
        }

        private static BinaryData GetContentFromResponse(Response r)
        {
            // Workaround azure/azure-sdk-for-net#21048, which prevents .Content from working when dealing with responses
            // from the playback system.

            MemoryStream ms = new MemoryStream();
            r.ContentStream.CopyTo(ms);
            return new BinaryData(ms.ToArray());
        }
        #endregion
    }
}
