// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.Language.AnalyzeText
{
    /// <summary> Base parameters object for a text analysis task. </summary>
    public partial class TaskParameters
    {
        /// <summary> Initializes a new instance of <see cref="TaskParameters"/>. </summary>
        internal TaskParameters()
        {
        }

        /// <summary> Initializes a new instance of <see cref="TaskParameters"/>. </summary>
        /// <param name="loggingOptOut"> logging opt out. </param>
        internal TaskParameters(bool? loggingOptOut)
        {
            LoggingOptOut = loggingOptOut;
        }

        /// <summary> logging opt out. </summary>
        public bool? LoggingOptOut { get; }
    }
}
