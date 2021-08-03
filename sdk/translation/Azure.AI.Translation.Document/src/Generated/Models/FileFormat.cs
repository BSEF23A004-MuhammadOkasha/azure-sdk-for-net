// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.AI.Translation.Document.Models
{
    /// <summary> The FileFormat. </summary>
    public partial class FileFormat
    {
        /// <summary> Initializes a new instance of FileFormat. </summary>
        /// <param name="format"> Name of the format. </param>
        /// <param name="fileExtensions"> Supported file extension for this format. </param>
        /// <param name="contentTypes"> Supported Content-Types for this format. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="format"/>, <paramref name="fileExtensions"/>, or <paramref name="contentTypes"/> is null. </exception>
        internal FileFormat(string format, IEnumerable<string> fileExtensions, IEnumerable<string> contentTypes)
        {
            if (format == null)
            {
                throw new ArgumentNullException(nameof(format));
            }
            if (fileExtensions == null)
            {
                throw new ArgumentNullException(nameof(fileExtensions));
            }
            if (contentTypes == null)
            {
                throw new ArgumentNullException(nameof(contentTypes));
            }

            Format = format;
            FileExtensions = fileExtensions.ToList();
            ContentTypes = contentTypes.ToList();
            Versions = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of FileFormat. </summary>
        /// <param name="format"> Name of the format. </param>
        /// <param name="fileExtensions"> Supported file extension for this format. </param>
        /// <param name="contentTypes"> Supported Content-Types for this format. </param>
        /// <param name="defaultVersion"> Default version if none is specified. </param>
        /// <param name="versions"> Supported Version. </param>
        internal FileFormat(string format, IReadOnlyList<string> fileExtensions, IReadOnlyList<string> contentTypes, string defaultVersion, IReadOnlyList<string> versions)
        {
            Format = format;
            FileExtensions = fileExtensions;
            ContentTypes = contentTypes;
            DefaultVersion = defaultVersion;
            Versions = versions;
        }

        /// <summary> Name of the format. </summary>
        public string Format { get; }
        /// <summary> Supported file extension for this format. </summary>
        public IReadOnlyList<string> FileExtensions { get; }
        /// <summary> Supported Content-Types for this format. </summary>
        public IReadOnlyList<string> ContentTypes { get; }
        /// <summary> Default version if none is specified. </summary>
        public string DefaultVersion { get; }
        /// <summary> Supported Version. </summary>
        public IReadOnlyList<string> Versions { get; }
    }
}
