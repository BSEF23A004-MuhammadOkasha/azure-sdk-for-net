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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class ServiceBusQueueMessage : ServiceBusMessage
    {
        /// <summary>
        /// Initializes a new instance of the ServiceBusQueueMessage class.
        /// </summary>
        public ServiceBusQueueMessage()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServiceBusQueueMessage class.
        /// </summary>
        /// <param name="authentication">Gets or sets the Service Bus
        /// authentication.</param>
        /// <param name="brokeredMessageProperties">Gets or sets the brokered
        /// message properties.</param>
        /// <param name="customMessageProperties">Gets or sets the custom
        /// message properties.</param>
        /// <param name="message">Gets or sets the message.</param>
        /// <param name="namespaceProperty">Gets or sets the namespace.</param>
        /// <param name="transportType">Gets or sets the transport type.
        /// Possible values include: 'NotSpecified', 'NetMessaging',
        /// 'AMQP'</param>
        /// <param name="queueName">Gets or sets the queue name.</param>
        public ServiceBusQueueMessage(ServiceBusAuthentication authentication = default(ServiceBusAuthentication), ServiceBusBrokeredMessageProperties brokeredMessageProperties = default(ServiceBusBrokeredMessageProperties), IDictionary<string, string> customMessageProperties = default(IDictionary<string, string>), string message = default(string), string namespaceProperty = default(string), ServiceBusTransportType? transportType = default(ServiceBusTransportType?), string queueName = default(string))
            : base(authentication, brokeredMessageProperties, customMessageProperties, message, namespaceProperty, transportType)
        {
            QueueName = queueName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the queue name.
        /// </summary>
        [JsonProperty(PropertyName = "queueName")]
        public string QueueName { get; set; }

    }
}
