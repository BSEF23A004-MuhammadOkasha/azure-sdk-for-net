// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ArcScVmm.Models
{
    public partial class Checkpoint : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ParentCheckpointId))
            {
                writer.WritePropertyName("parentCheckpointID");
                writer.WriteStringValue(ParentCheckpointId);
            }
            if (Optional.IsDefined(CheckpointId))
            {
                writer.WritePropertyName("checkpointID");
                writer.WriteStringValue(CheckpointId);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            writer.WriteEndObject();
        }

        internal static Checkpoint DeserializeCheckpoint(JsonElement element)
        {
            Optional<string> parentCheckpointID = default;
            Optional<string> checkpointID = default;
            Optional<string> name = default;
            Optional<string> description = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("parentCheckpointID"))
                {
                    parentCheckpointID = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("checkpointID"))
                {
                    checkpointID = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
            }
            return new Checkpoint(parentCheckpointID.Value, checkpointID.Value, name.Value, description.Value);
        }
    }
}
