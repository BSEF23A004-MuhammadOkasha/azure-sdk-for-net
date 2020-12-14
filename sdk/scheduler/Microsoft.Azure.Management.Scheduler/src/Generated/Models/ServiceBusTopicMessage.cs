// <auto-generated>
//
// </auto-generated>

namespace Microsoft.Azure.Management.Scheduler.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class ServiceBusTopicMessage : ServiceBusMessage
    {
        /// <summary>
        /// Initializes a new instance of the ServiceBusTopicMessage class.
        /// </summary>
        public ServiceBusTopicMessage()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServiceBusTopicMessage class.
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
        /// <param name="topicPath">Gets or sets the topic path.</param>
        public ServiceBusTopicMessage(ServiceBusAuthentication authentication = default(ServiceBusAuthentication), ServiceBusBrokeredMessageProperties brokeredMessageProperties = default(ServiceBusBrokeredMessageProperties), IDictionary<string, string> customMessageProperties = default(IDictionary<string, string>), string message = default(string), string namespaceProperty = default(string), ServiceBusTransportType? transportType = default(ServiceBusTransportType?), string topicPath = default(string))
            : base(authentication, brokeredMessageProperties, customMessageProperties, message, namespaceProperty, transportType)
        {
            TopicPath = topicPath;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the topic path.
        /// </summary>
        [JsonProperty(PropertyName = "topicPath")]
        public string TopicPath { get; set; }

    }
}
