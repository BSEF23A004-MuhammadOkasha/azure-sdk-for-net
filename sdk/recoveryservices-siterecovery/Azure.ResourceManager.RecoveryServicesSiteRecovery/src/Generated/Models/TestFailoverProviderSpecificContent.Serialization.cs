// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    [ModelReaderProxy(typeof(UnknownTestFailoverProviderSpecificContent))]
    public partial class TestFailoverProviderSpecificContent : IUtf8JsonSerializable, IJsonModel<TestFailoverProviderSpecificContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TestFailoverProviderSpecificContent>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<TestFailoverProviderSpecificContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
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

        TestFailoverProviderSpecificContent IJsonModel<TestFailoverProviderSpecificContent>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(TestFailoverProviderSpecificContent)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTestFailoverProviderSpecificContent(document.RootElement, options);
        }

        internal static TestFailoverProviderSpecificContent DeserializeTestFailoverProviderSpecificContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("instanceType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "A2A": return A2ATestFailoverContent.DeserializeA2ATestFailoverContent(element);
                    case "HyperVReplicaAzure": return HyperVReplicaAzureTestFailoverContent.DeserializeHyperVReplicaAzureTestFailoverContent(element);
                    case "InMage": return InMageTestFailoverContent.DeserializeInMageTestFailoverContent(element);
                    case "InMageAzureV2": return InMageAzureV2TestFailoverContent.DeserializeInMageAzureV2TestFailoverContent(element);
                    case "InMageRcm": return InMageRcmTestFailoverContent.DeserializeInMageRcmTestFailoverContent(element);
                }
            }
            return UnknownTestFailoverProviderSpecificContent.DeserializeUnknownTestFailoverProviderSpecificContent(element);
        }

        BinaryData IModel<TestFailoverProviderSpecificContent>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(TestFailoverProviderSpecificContent)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        TestFailoverProviderSpecificContent IModel<TestFailoverProviderSpecificContent>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(TestFailoverProviderSpecificContent)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeTestFailoverProviderSpecificContent(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<TestFailoverProviderSpecificContent>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
