// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> The CustomModelJobInput. </summary>
    public partial class CustomModelJobInput : JobInput
    {
        /// <summary> Initializes a new instance of CustomModelJobInput. </summary>
        /// <param name="uri"> Input Asset URI. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="uri"/> is null. </exception>
        public CustomModelJobInput(Uri uri)
        {
            if (uri == null)
            {
                throw new ArgumentNullException(nameof(uri));
            }

            Uri = uri;
            JobInputType = JobInputType.CustomModel;
        }

        /// <summary> Initializes a new instance of CustomModelJobInput. </summary>
        /// <param name="description"> Description for the input. </param>
        /// <param name="jobInputType"> Specifies the type of job. </param>
        /// <param name="mode"> Input Asset Delivery Mode. </param>
        /// <param name="uri"> Input Asset URI. </param>
        internal CustomModelJobInput(string description, JobInputType jobInputType, InputDeliveryMode? mode, Uri uri) : base(description, jobInputType)
        {
            Mode = mode;
            Uri = uri;
            JobInputType = jobInputType;
        }

        /// <summary> Input Asset Delivery Mode. </summary>
        public InputDeliveryMode? Mode { get; set; }
        /// <summary> Input Asset URI. </summary>
        public Uri Uri { get; set; }
    }
}
