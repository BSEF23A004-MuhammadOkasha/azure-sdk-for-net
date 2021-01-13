// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.MixedReality.RemoteRendering.Models
{
    /// <summary> The Conversion. </summary>
    public partial class ConversionInformation
    {
        /// <summary> Initializes a new instance of ConversionInformation. </summary>
        /// <param name="id"> . </param>
        /// <param name="settings"> Settings for where to retrieve input files from and where to write output files. </param>
        /// <param name="error"> The error object containing details about the conversion failure. </param>
        /// <param name="status"> . </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="settings"/> is null. </exception>
        internal ConversionInformation(string id, ConversionSettings settings, ErrorDetails error, CreatedByType status)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (settings == null)
            {
                throw new ArgumentNullException(nameof(settings));
            }

            Id = id;
            Settings = settings;
            Error = error;
            Status = status;
        }

        /// <summary> Initializes a new instance of ConversionInformation. </summary>
        /// <param name="id"> . </param>
        /// <param name="settings"> Settings for where to retrieve input files from and where to write output files. </param>
        /// <param name="output"> . </param>
        /// <param name="error"> The error object containing details about the conversion failure. </param>
        /// <param name="status"> . </param>
        /// <param name="creationTime"> . </param>
        internal ConversionInformation(string id, ConversionSettings settings, ConversionOutput output, ErrorDetails error, CreatedByType status, DateTimeOffset? creationTime)
        {
            Id = id;
            Settings = settings;
            Output = output;
            Error = error;
            Status = status;
            CreationTime = creationTime;
        }

        public string Id { get; }
        /// <summary> Settings for where to retrieve input files from and where to write output files. </summary>
        public ConversionSettings Settings { get; }
        public ConversionOutput Output { get; }
        /// <summary> The error object containing details about the conversion failure. </summary>
        public ErrorDetails Error { get; }
        public CreatedByType Status { get; }
        public DateTimeOffset? CreationTime { get; }
    }
}
