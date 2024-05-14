// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Monitor.OpenTelemetry.LiveMetrics.Models
{
    /// <summary> Trace type name. </summary>
    internal partial class Trace : DocumentIngress
    {
        /// <summary> Initializes a new instance of <see cref="Trace"/>. </summary>
        public Trace()
        {
            DocumentType = DocumentIngressDocumentType.Trace;
        }

        /// <summary> Initializes a new instance of <see cref="Trace"/>. </summary>
        /// <param name="documentType"> Telemetry type. Types not defined in enum will get replaced with a 'Unknown' type. </param>
        /// <param name="documentStreamIds"> An array of document streaming ids. Each id identifies a flow of documents customized by UX customers. </param>
        /// <param name="properties"> Collection of custom properties. </param>
        /// <param name="message"> Trace message. </param>
        internal Trace(DocumentIngressDocumentType documentType, IList<string> documentStreamIds, IList<KeyValuePairString> properties, string message) : base(documentType, documentStreamIds, properties)
        {
            Message = message;
            DocumentType = documentType;
        }

        /// <summary> Trace message. </summary>
        public string Message { get; set; }
    }
}
