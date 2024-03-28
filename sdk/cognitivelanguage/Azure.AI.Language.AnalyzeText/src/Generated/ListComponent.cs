// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.Language.AnalyzeText
{
    /// <summary> This object contains information of the list component of the detected entity. </summary>
    public partial class ListComponent : EntityComponentInformation
    {
        /// <summary> Initializes a new instance of <see cref="ListComponent"/>. </summary>
        internal ListComponent()
        {
            EntityComponentKind = EntityComponentKind.ListComponent;
        }

        /// <summary> Initializes a new instance of <see cref="ListComponent"/>. </summary>
        /// <param name="entityComponentKind"></param>
        /// <param name="value"> The list key of an extracted entity type. </param>
        internal ListComponent(EntityComponentKind entityComponentKind, string value) : base(entityComponentKind)
        {
            Value = value;
        }

        /// <summary> The list key of an extracted entity type. </summary>
        public string Value { get; }
    }
}
