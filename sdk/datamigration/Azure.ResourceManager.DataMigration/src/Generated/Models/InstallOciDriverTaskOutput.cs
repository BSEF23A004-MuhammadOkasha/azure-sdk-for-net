// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Output for the service task to install an OCI driver. </summary>
    public partial class InstallOciDriverTaskOutput
    {
        /// <summary> Initializes a new instance of InstallOciDriverTaskOutput. </summary>
        internal InstallOciDriverTaskOutput()
        {
            ValidationErrors = new ChangeTrackingList<ReportableException>();
        }

        /// <summary> Initializes a new instance of InstallOciDriverTaskOutput. </summary>
        /// <param name="validationErrors"> Validation errors. </param>
        internal InstallOciDriverTaskOutput(IReadOnlyList<ReportableException> validationErrors)
        {
            ValidationErrors = validationErrors;
        }

        /// <summary> Validation errors. </summary>
        public IReadOnlyList<ReportableException> ValidationErrors { get; }
    }
}
