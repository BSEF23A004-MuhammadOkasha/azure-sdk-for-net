// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> Datastore SAS secrets. </summary>
    public partial class SasDatastoreSecrets : DatastoreSecrets
    {
        /// <summary> Initializes a new instance of SasDatastoreSecrets. </summary>
        public SasDatastoreSecrets()
        {
            SecretsType = SecretsType.Sas;
        }

        /// <summary> Initializes a new instance of SasDatastoreSecrets. </summary>
        /// <param name="secretsType"> Credential type used to authentication with storage. </param>
        /// <param name="sasToken"> Storage container SAS token. </param>
        internal SasDatastoreSecrets(SecretsType secretsType, string sasToken) : base(secretsType)
        {
            SasToken = sasToken;
            SecretsType = secretsType;
        }

        /// <summary> Storage container SAS token. </summary>
        public string SasToken { get; set; }
    }
}
