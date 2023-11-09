// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SignalR.Models
{
    public partial class SignalRNetworkAcls : IUtf8JsonSerializable, IJsonModel<SignalRNetworkAcls>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SignalRNetworkAcls>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<SignalRNetworkAcls>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DefaultAction))
            {
                writer.WritePropertyName("defaultAction"u8);
                writer.WriteStringValue(DefaultAction.Value.ToString());
            }
            if (Optional.IsDefined(PublicNetwork))
            {
                writer.WritePropertyName("publicNetwork"u8);
                writer.WriteObjectValue(PublicNetwork);
            }
            if (Optional.IsCollectionDefined(PrivateEndpoints))
            {
                writer.WritePropertyName("privateEndpoints"u8);
                writer.WriteStartArray();
                foreach (var item in PrivateEndpoints)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
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

        SignalRNetworkAcls IJsonModel<SignalRNetworkAcls>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SignalRNetworkAcls)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSignalRNetworkAcls(document.RootElement, options);
        }

        internal static SignalRNetworkAcls DeserializeSignalRNetworkAcls(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<SignalRNetworkAclAction> defaultAction = default;
            Optional<SignalRNetworkAcl> publicNetwork = default;
            Optional<IList<SignalRPrivateEndpointAcl>> privateEndpoints = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("defaultAction"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    defaultAction = new SignalRNetworkAclAction(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("publicNetwork"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publicNetwork = SignalRNetworkAcl.DeserializeSignalRNetworkAcl(property.Value);
                    continue;
                }
                if (property.NameEquals("privateEndpoints"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SignalRPrivateEndpointAcl> array = new List<SignalRPrivateEndpointAcl>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SignalRPrivateEndpointAcl.DeserializeSignalRPrivateEndpointAcl(item));
                    }
                    privateEndpoints = array;
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SignalRNetworkAcls(Optional.ToNullable(defaultAction), publicNetwork.Value, Optional.ToList(privateEndpoints), serializedAdditionalRawData);
        }

        BinaryData IModel<SignalRNetworkAcls>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SignalRNetworkAcls)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        SignalRNetworkAcls IModel<SignalRNetworkAcls>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SignalRNetworkAcls)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeSignalRNetworkAcls(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<SignalRNetworkAcls>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
