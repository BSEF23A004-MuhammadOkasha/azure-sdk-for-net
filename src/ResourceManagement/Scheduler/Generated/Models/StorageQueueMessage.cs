// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Scheduler.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Scheduler;
    using Microsoft.Azure.Management.Scheduler.Fluent;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class StorageQueueMessage
    {
        /// <summary>
        /// Initializes a new instance of the StorageQueueMessage class.
        /// </summary>
        public StorageQueueMessage()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StorageQueueMessage class.
        /// </summary>
        /// <param name="storageAccount">Gets or sets the storage account
        /// name.</param>
        /// <param name="queueName">Gets or sets the queue name.</param>
        /// <param name="sasToken">Gets or sets the SAS key.</param>
        /// <param name="message">Gets or sets the message.</param>
        public StorageQueueMessage(string storageAccount = default(string), string queueName = default(string), string sasToken = default(string), string message = default(string))
        {
            StorageAccount = storageAccount;
            QueueName = queueName;
            SasToken = sasToken;
            Message = message;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the storage account name.
        /// </summary>
        [JsonProperty(PropertyName = "storageAccount")]
        public string StorageAccount { get; set; }

        /// <summary>
        /// Gets or sets the queue name.
        /// </summary>
        [JsonProperty(PropertyName = "queueName")]
        public string QueueName { get; set; }

        /// <summary>
        /// Gets or sets the SAS key.
        /// </summary>
        [JsonProperty(PropertyName = "sasToken")]
        public string SasToken { get; set; }

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

    }
}
