// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Support.Models;

namespace Azure.ResourceManager.Support
{
    public partial class SupportTicketData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(SupportTicketId))
            {
                writer.WritePropertyName("supportTicketId");
                writer.WriteStringValue(SupportTicketId);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(ProblemClassificationId))
            {
                writer.WritePropertyName("problemClassificationId");
                writer.WriteStringValue(ProblemClassificationId);
            }
            if (Optional.IsDefined(Severity))
            {
                writer.WritePropertyName("severity");
                writer.WriteStringValue(Severity.Value.ToString());
            }
            if (Optional.IsDefined(Require24X7Response))
            {
                writer.WritePropertyName("require24X7Response");
                writer.WriteBooleanValue(Require24X7Response.Value);
            }
            if (Optional.IsDefined(ContactDetails))
            {
                writer.WritePropertyName("contactDetails");
                writer.WriteObjectValue(ContactDetails);
            }
            if (Optional.IsDefined(ServiceLevelAgreement))
            {
                writer.WritePropertyName("serviceLevelAgreement");
                writer.WriteObjectValue(ServiceLevelAgreement);
            }
            if (Optional.IsDefined(SupportEngineer))
            {
                writer.WritePropertyName("supportEngineer");
                writer.WriteObjectValue(SupportEngineer);
            }
            if (Optional.IsDefined(Title))
            {
                writer.WritePropertyName("title");
                writer.WriteStringValue(Title);
            }
            if (Optional.IsDefined(ProblemStartOn))
            {
                writer.WritePropertyName("problemStartTime");
                writer.WriteStringValue(ProblemStartOn.Value, "O");
            }
            if (Optional.IsDefined(ServiceId))
            {
                writer.WritePropertyName("serviceId");
                writer.WriteStringValue(ServiceId);
            }
            if (Optional.IsDefined(TechnicalTicketDetails))
            {
                writer.WritePropertyName("technicalTicketDetails");
                writer.WriteObjectValue(TechnicalTicketDetails);
            }
            if (Optional.IsDefined(QuotaTicketDetails))
            {
                writer.WritePropertyName("quotaTicketDetails");
                writer.WriteObjectValue(QuotaTicketDetails);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static SupportTicketData DeserializeSupportTicketData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> supportTicketId = default;
            Optional<string> description = default;
            Optional<string> problemClassificationId = default;
            Optional<string> problemClassificationDisplayName = default;
            Optional<SupportSeverityLevel> severity = default;
            Optional<string> enrollmentId = default;
            Optional<bool> require24X7Response = default;
            Optional<SupportContactProfile> contactDetails = default;
            Optional<SupportServiceLevelAgreement> serviceLevelAgreement = default;
            Optional<SupportEngineer> supportEngineer = default;
            Optional<string> supportPlanType = default;
            Optional<string> title = default;
            Optional<DateTimeOffset> problemStartTime = default;
            Optional<string> serviceId = default;
            Optional<string> serviceDisplayName = default;
            Optional<string> status = default;
            Optional<DateTimeOffset> createdDate = default;
            Optional<DateTimeOffset> modifiedDate = default;
            Optional<TechnicalTicketDetails> technicalTicketDetails = default;
            Optional<QuotaTicketDetails> quotaTicketDetails = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("supportTicketId"))
                        {
                            supportTicketId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("description"))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("problemClassificationId"))
                        {
                            problemClassificationId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("problemClassificationDisplayName"))
                        {
                            problemClassificationDisplayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("severity"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            severity = new SupportSeverityLevel(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("enrollmentId"))
                        {
                            enrollmentId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("require24X7Response"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            require24X7Response = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("contactDetails"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            contactDetails = SupportContactProfile.DeserializeSupportContactProfile(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("serviceLevelAgreement"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            serviceLevelAgreement = SupportServiceLevelAgreement.DeserializeSupportServiceLevelAgreement(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("supportEngineer"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            supportEngineer = SupportEngineer.DeserializeSupportEngineer(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("supportPlanType"))
                        {
                            supportPlanType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("title"))
                        {
                            title = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("problemStartTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            problemStartTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("serviceId"))
                        {
                            serviceId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("serviceDisplayName"))
                        {
                            serviceDisplayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("status"))
                        {
                            status = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("createdDate"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            createdDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("modifiedDate"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            modifiedDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("technicalTicketDetails"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            technicalTicketDetails = TechnicalTicketDetails.DeserializeTechnicalTicketDetails(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("quotaTicketDetails"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            quotaTicketDetails = QuotaTicketDetails.DeserializeQuotaTicketDetails(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new SupportTicketData(id, name, type, systemData.Value, supportTicketId.Value, description.Value, problemClassificationId.Value, problemClassificationDisplayName.Value, Optional.ToNullable(severity), enrollmentId.Value, Optional.ToNullable(require24X7Response), contactDetails.Value, serviceLevelAgreement.Value, supportEngineer.Value, supportPlanType.Value, title.Value, Optional.ToNullable(problemStartTime), serviceId.Value, serviceDisplayName.Value, status.Value, Optional.ToNullable(createdDate), Optional.ToNullable(modifiedDate), technicalTicketDetails.Value, quotaTicketDetails.Value);
        }
    }
}
