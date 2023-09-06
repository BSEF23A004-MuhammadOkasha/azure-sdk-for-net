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

namespace Azure.Communication.ShortCodes.Models
{
    public partial class USProgramBrief : IUtf8JsonSerializable, IModelJsonSerializable<USProgramBrief>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<USProgramBrief>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<USProgramBrief>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<USProgramBrief>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(Id);
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (Optional.IsDefined(Number))
            {
                writer.WritePropertyName("number"u8);
                writer.WriteStringValue(Number);
            }
            if (Optional.IsCollectionDefined(ReviewNotes))
            {
                writer.WritePropertyName("reviewNotes"u8);
                writer.WriteStartArray();
                foreach (var item in ReviewNotes)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<ReviewNote>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Costs))
            {
                writer.WritePropertyName("costs"u8);
                writer.WriteStartArray();
                foreach (var item in Costs)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<ShortCodeCost>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(SubmissionDate))
            {
                writer.WritePropertyName("submissionDate"u8);
                writer.WriteStringValue(SubmissionDate.Value, "O");
            }
            if (Optional.IsDefined(StatusUpdatedDate))
            {
                writer.WritePropertyName("statusUpdatedDate"u8);
                writer.WriteStringValue(StatusUpdatedDate.Value, "O");
            }
            if (Optional.IsDefined(ProgramDetails))
            {
                writer.WritePropertyName("programDetails"u8);
                if (ProgramDetails is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ProgramDetails>)ProgramDetails).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(CompanyInformation))
            {
                writer.WritePropertyName("companyInformation"u8);
                if (CompanyInformation is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<CompanyInformation>)CompanyInformation).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(MessageDetails))
            {
                writer.WritePropertyName("messageDetails"u8);
                if (MessageDetails is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<MessageDetails>)MessageDetails).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(TrafficDetails))
            {
                writer.WritePropertyName("trafficDetails"u8);
                if (TrafficDetails is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<TrafficDetails>)TrafficDetails).Serialize(writer, options);
                }
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

        internal static USProgramBrief DeserializeUSProgramBrief(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Guid id = default;
            Optional<ProgramBriefStatus> status = default;
            Optional<string> number = default;
            Optional<IList<ReviewNote>> reviewNotes = default;
            Optional<IList<ShortCodeCost>> costs = default;
            Optional<DateTimeOffset> submissionDate = default;
            Optional<DateTimeOffset> statusUpdatedDate = default;
            Optional<ProgramDetails> programDetails = default;
            Optional<CompanyInformation> companyInformation = default;
            Optional<MessageDetails> messageDetails = default;
            Optional<TrafficDetails> trafficDetails = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new ProgramBriefStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("number"u8))
                {
                    number = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("reviewNotes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ReviewNote> array = new List<ReviewNote>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ReviewNote.DeserializeReviewNote(item));
                    }
                    reviewNotes = array;
                    continue;
                }
                if (property.NameEquals("costs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ShortCodeCost> array = new List<ShortCodeCost>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ShortCodeCost.DeserializeShortCodeCost(item));
                    }
                    costs = array;
                    continue;
                }
                if (property.NameEquals("submissionDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    submissionDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("statusUpdatedDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    statusUpdatedDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("programDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    programDetails = ProgramDetails.DeserializeProgramDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("companyInformation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    companyInformation = CompanyInformation.DeserializeCompanyInformation(property.Value);
                    continue;
                }
                if (property.NameEquals("messageDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    messageDetails = MessageDetails.DeserializeMessageDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("trafficDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    trafficDetails = TrafficDetails.DeserializeTrafficDetails(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new USProgramBrief(id, Optional.ToNullable(status), number.Value, Optional.ToList(reviewNotes), Optional.ToList(costs), Optional.ToNullable(submissionDate), Optional.ToNullable(statusUpdatedDate), programDetails.Value, companyInformation.Value, messageDetails.Value, trafficDetails.Value, rawData);
        }

        USProgramBrief IModelJsonSerializable<USProgramBrief>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<USProgramBrief>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeUSProgramBrief(doc.RootElement, options);
        }

        BinaryData IModelSerializable<USProgramBrief>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<USProgramBrief>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        USProgramBrief IModelSerializable<USProgramBrief>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<USProgramBrief>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeUSProgramBrief(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="USProgramBrief"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="USProgramBrief"/> to convert. </param>
        public static implicit operator RequestContent(USProgramBrief model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="USProgramBrief"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator USProgramBrief(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeUSProgramBrief(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
