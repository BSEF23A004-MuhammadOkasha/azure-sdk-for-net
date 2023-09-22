// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.OpenAI
{
    /// <summary> The type of Azure Cognitive Search retrieval query that should be executed when using it as an Azure OpenAI chat extension. </summary>
    public readonly partial struct AzureCognitiveSearchQueryType : IEquatable<AzureCognitiveSearchQueryType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AzureCognitiveSearchQueryType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AzureCognitiveSearchQueryType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SimpleValue = "simple";
        private const string SemanticValue = "semantic";
        private const string VectorValue = "vector";
        private const string VectorSimpleHybridValue = "vectorSimpleHybrid";
        private const string VectorSemanticHybridValue = "vectorSemanticHybrid";

        /// <summary> Represents the default, simple query parser. </summary>
        public static AzureCognitiveSearchQueryType Simple { get; } = new AzureCognitiveSearchQueryType(SimpleValue);
        /// <summary> Represents the semantic query parser for advanced semantic modeling. </summary>
        public static AzureCognitiveSearchQueryType Semantic { get; } = new AzureCognitiveSearchQueryType(SemanticValue);
        /// <summary> Represents vector search over computed data. </summary>
        public static AzureCognitiveSearchQueryType Vector { get; } = new AzureCognitiveSearchQueryType(VectorValue);
        /// <summary> Represents a combination of the simple query strategy with vector data. </summary>
        public static AzureCognitiveSearchQueryType VectorSimpleHybrid { get; } = new AzureCognitiveSearchQueryType(VectorSimpleHybridValue);
        /// <summary> Represents a combination of semantic search and vector data querying. </summary>
        public static AzureCognitiveSearchQueryType VectorSemanticHybrid { get; } = new AzureCognitiveSearchQueryType(VectorSemanticHybridValue);
        /// <summary> Determines if two <see cref="AzureCognitiveSearchQueryType"/> values are the same. </summary>
        public static bool operator ==(AzureCognitiveSearchQueryType left, AzureCognitiveSearchQueryType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AzureCognitiveSearchQueryType"/> values are not the same. </summary>
        public static bool operator !=(AzureCognitiveSearchQueryType left, AzureCognitiveSearchQueryType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AzureCognitiveSearchQueryType"/>. </summary>
        public static implicit operator AzureCognitiveSearchQueryType(string value) => new AzureCognitiveSearchQueryType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AzureCognitiveSearchQueryType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AzureCognitiveSearchQueryType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
