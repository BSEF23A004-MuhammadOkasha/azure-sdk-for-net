// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary>
    /// Data connector requirements properties.
    /// Please note <see cref="DataConnectorsCheckRequirements"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="AwsCloudTrailCheckRequirements"/>, <see cref="AwsS3CheckRequirements"/>, <see cref="AADCheckRequirements"/>, <see cref="AatpCheckRequirements"/>, <see cref="ASCCheckRequirements"/>, <see cref="Dynamics365CheckRequirements"/>, <see cref="IoTCheckRequirements"/>, <see cref="McasCheckRequirements"/>, <see cref="MdatpCheckRequirements"/>, <see cref="MstiCheckRequirements"/>, <see cref="MtpCheckRequirements"/>, <see cref="Office365ProjectCheckRequirements"/>, <see cref="OfficeATPCheckRequirements"/>, <see cref="OfficeIRMCheckRequirements"/>, <see cref="OfficePowerBICheckRequirements"/>, <see cref="TICheckRequirements"/> and <see cref="TiTaxiiCheckRequirements"/>.
    /// </summary>
    public abstract partial class DataConnectorsCheckRequirements
    {
        /// <summary> Initializes a new instance of DataConnectorsCheckRequirements. </summary>
        protected DataConnectorsCheckRequirements()
        {
        }

        /// <summary> Describes the kind of connector to be checked. </summary>
        internal DataConnectorKind Kind { get; set; }
    }
}
