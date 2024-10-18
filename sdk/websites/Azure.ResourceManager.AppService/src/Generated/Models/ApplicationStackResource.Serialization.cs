// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class ApplicationStackResource : IUtf8JsonSerializable, IJsonModel<ApplicationStackResource>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ApplicationStackResource>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ApplicationStackResource>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationStackResource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApplicationStackResource)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(StackName))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(StackName);
            }
            if (Optional.IsDefined(Display))
            {
                writer.WritePropertyName("display"u8);
                writer.WriteStringValue(Display);
            }
            if (Optional.IsDefined(Dependency))
            {
                writer.WritePropertyName("dependency"u8);
                writer.WriteStringValue(Dependency);
            }
            if (Optional.IsCollectionDefined(MajorVersions))
            {
                writer.WritePropertyName("majorVersions"u8);
                writer.WriteStartArray();
                foreach (var item in MajorVersions)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Frameworks))
            {
                writer.WritePropertyName("frameworks"u8);
                writer.WriteStartArray();
                foreach (var item in Frameworks)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(IsDeprecated))
            {
                writer.WritePropertyName("isDeprecated"u8);
                writer.WriteStartArray();
                foreach (var item in IsDeprecated)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        ApplicationStackResource IJsonModel<ApplicationStackResource>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationStackResource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApplicationStackResource)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeApplicationStackResource(document.RootElement, options);
        }

        internal static ApplicationStackResource DeserializeApplicationStackResource(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string name0 = default;
            string display = default;
            string dependency = default;
            IList<StackMajorVersion> majorVersions = default;
            IList<ApplicationStack> frameworks = default;
            IList<ApplicationStack> isDeprecated = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("name"u8))
                        {
                            name0 = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("display"u8))
                        {
                            display = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("dependency"u8))
                        {
                            dependency = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("majorVersions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<StackMajorVersion> array = new List<StackMajorVersion>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(StackMajorVersion.DeserializeStackMajorVersion(item, options));
                            }
                            majorVersions = array;
                            continue;
                        }
                        if (property0.NameEquals("frameworks"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ApplicationStack> array = new List<ApplicationStack>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ApplicationStack.DeserializeApplicationStack(item, options));
                            }
                            frameworks = array;
                            continue;
                        }
                        if (property0.NameEquals("isDeprecated"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ApplicationStack> array = new List<ApplicationStack>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ApplicationStack.DeserializeApplicationStack(item, options));
                            }
                            isDeprecated = array;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ApplicationStackResource(
                id,
                name,
                type,
                systemData,
                name0,
                display,
                dependency,
                majorVersions ?? new ChangeTrackingList<StackMajorVersion>(),
                frameworks ?? new ChangeTrackingList<ApplicationStack>(),
                isDeprecated ?? new ChangeTrackingList<ApplicationStack>(),
                kind,
                serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Name), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  name: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Name))
                {
                    builder.Append("  name: ");
                    if (Name.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Name}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Name}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Kind), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  kind: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Kind))
                {
                    builder.Append("  kind: ");
                    if (Kind.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Kind}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Kind}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Id), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  id: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Id))
                {
                    builder.Append("  id: ");
                    builder.AppendLine($"'{Id.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SystemData), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  systemData: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SystemData))
                {
                    builder.Append("  systemData: ");
                    builder.AppendLine($"'{SystemData.ToString()}'");
                }
            }

            builder.Append("  properties:");
            builder.AppendLine(" {");
            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(StackName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    name: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(StackName))
                {
                    builder.Append("    name: ");
                    if (StackName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{StackName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{StackName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Display), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    display: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Display))
                {
                    builder.Append("    display: ");
                    if (Display.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Display}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Display}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Dependency), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    dependency: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Dependency))
                {
                    builder.Append("    dependency: ");
                    if (Dependency.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Dependency}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Dependency}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(MajorVersions), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    majorVersions: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(MajorVersions))
                {
                    if (MajorVersions.Any())
                    {
                        builder.Append("    majorVersions: ");
                        builder.AppendLine("[");
                        foreach (var item in MajorVersions)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 6, true, "    majorVersions: ");
                        }
                        builder.AppendLine("    ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Frameworks), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    frameworks: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Frameworks))
                {
                    if (Frameworks.Any())
                    {
                        builder.Append("    frameworks: ");
                        builder.AppendLine("[");
                        foreach (var item in Frameworks)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 6, true, "    frameworks: ");
                        }
                        builder.AppendLine("    ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsDeprecated), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    isDeprecated: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(IsDeprecated))
                {
                    if (IsDeprecated.Any())
                    {
                        builder.Append("    isDeprecated: ");
                        builder.AppendLine("[");
                        foreach (var item in IsDeprecated)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 6, true, "    isDeprecated: ");
                        }
                        builder.AppendLine("    ]");
                    }
                }
            }

            builder.AppendLine("  }");
            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ApplicationStackResource>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationStackResource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ApplicationStackResource)} does not support writing '{options.Format}' format.");
            }
        }

        ApplicationStackResource IPersistableModel<ApplicationStackResource>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationStackResource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeApplicationStackResource(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ApplicationStackResource)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ApplicationStackResource>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
