// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.Translation.Document.Models
{
    /// <summary> Translation job submission batch request. </summary>
    public partial class StartTranslationDetails
    {
        /// <summary> Initializes a new instance of StartTranslationDetails. </summary>
        /// <param name="inputs"> The input list of documents or folders containing documents. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="inputs"/> is null. </exception>
        public StartTranslationDetails(IEnumerable<BatchRequest> inputs)
        {
            if (inputs == null)
            {
                throw new ArgumentNullException(nameof(inputs));
            }

            Inputs = inputs.ToList();
        }

        /// <summary> The input list of documents or folders containing documents. </summary>
        public IList<BatchRequest> Inputs { get; }
    }
}
