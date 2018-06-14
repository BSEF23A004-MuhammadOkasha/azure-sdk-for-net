// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 2.4.36.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Azure ML WebService Input/Output file
    /// </summary>
    public partial class AzureMLWebServiceFile
    {
        /// <summary>
        /// Initializes a new instance of the AzureMLWebServiceFile class.
        /// </summary>
        public AzureMLWebServiceFile()
        {
            LinkedServiceName = new LinkedServiceReference();
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureMLWebServiceFile class.
        /// </summary>
        /// <param name="filePath">The relative file path, including container
        /// name, in the Azure Blob Storage specified by the LinkedService.
        /// Type: string (or Expression with resultType string).</param>
        /// <param name="linkedServiceName">Reference to an Azure Storage
        /// LinkedService, where Azure ML WebService Input/Output file
        /// located.</param>
        public AzureMLWebServiceFile(object filePath, LinkedServiceReference linkedServiceName)
        {
            FilePath = filePath;
            LinkedServiceName = linkedServiceName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the relative file path, including container name, in
        /// the Azure Blob Storage specified by the LinkedService. Type: string
        /// (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "filePath")]
        public object FilePath { get; set; }

        /// <summary>
        /// Gets or sets reference to an Azure Storage LinkedService, where
        /// Azure ML WebService Input/Output file located.
        /// </summary>
        [JsonProperty(PropertyName = "linkedServiceName")]
        public LinkedServiceReference LinkedServiceName { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (FilePath == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "FilePath");
            }
            if (LinkedServiceName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "LinkedServiceName");
            }
            if (LinkedServiceName != null)
            {
                LinkedServiceName.Validate();
            }
        }
    }
}
