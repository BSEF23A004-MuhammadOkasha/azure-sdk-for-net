// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;
using System.ComponentModel;

namespace Azure.Provisioning.ServiceBus;

/// <summary>
/// ServiceBusQueue.
/// </summary>
public partial class ServiceBusQueue : Resource
{
    /// <summary>
    /// The queue name.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// ISO 8061 timeSpan idle interval after which the queue is automatically
    /// deleted. The minimum duration is 5 minutes.
    /// </summary>
    public BicepValue<TimeSpan> AutoDeleteOnIdle { get => _autoDeleteOnIdle; set => _autoDeleteOnIdle.Assign(value); }
    private readonly BicepValue<TimeSpan> _autoDeleteOnIdle;

    /// <summary>
    /// A value that indicates whether this queue has dead letter support when
    /// a message expires.
    /// </summary>
    public BicepValue<bool> DeadLetteringOnMessageExpiration { get => _deadLetteringOnMessageExpiration; set => _deadLetteringOnMessageExpiration.Assign(value); }
    private readonly BicepValue<bool> _deadLetteringOnMessageExpiration;

    /// <summary>
    /// ISO 8601 default message timespan to live value. This is the duration
    /// after which the message expires, starting from when the message is
    /// sent to Service Bus. This is the default value used when TimeToLive is
    /// not set on a message itself.
    /// </summary>
    public BicepValue<TimeSpan> DefaultMessageTimeToLive { get => _defaultMessageTimeToLive; set => _defaultMessageTimeToLive.Assign(value); }
    private readonly BicepValue<TimeSpan> _defaultMessageTimeToLive;

    /// <summary>
    /// ISO 8601 timeSpan structure that defines the duration of the duplicate
    /// detection history. The default value is 10 minutes.
    /// </summary>
    public BicepValue<TimeSpan> DuplicateDetectionHistoryTimeWindow { get => _duplicateDetectionHistoryTimeWindow; set => _duplicateDetectionHistoryTimeWindow.Assign(value); }
    private readonly BicepValue<TimeSpan> _duplicateDetectionHistoryTimeWindow;

    /// <summary>
    /// Value that indicates whether server-side batched operations are enabled.
    /// </summary>
    public BicepValue<bool> EnableBatchedOperations { get => _enableBatchedOperations; set => _enableBatchedOperations.Assign(value); }
    private readonly BicepValue<bool> _enableBatchedOperations;

    /// <summary>
    /// A value that indicates whether Express Entities are enabled. An express
    /// queue holds a message in memory temporarily before writing it to
    /// persistent storage.
    /// </summary>
    public BicepValue<bool> EnableExpress { get => _enableExpress; set => _enableExpress.Assign(value); }
    private readonly BicepValue<bool> _enableExpress;

    /// <summary>
    /// A value that indicates whether the queue is to be partitioned across
    /// multiple message brokers.
    /// </summary>
    public BicepValue<bool> EnablePartitioning { get => _enablePartitioning; set => _enablePartitioning.Assign(value); }
    private readonly BicepValue<bool> _enablePartitioning;

    /// <summary>
    /// Queue/Topic name to forward the Dead Letter message.
    /// </summary>
    public BicepValue<string> ForwardDeadLetteredMessagesTo { get => _forwardDeadLetteredMessagesTo; set => _forwardDeadLetteredMessagesTo.Assign(value); }
    private readonly BicepValue<string> _forwardDeadLetteredMessagesTo;

    /// <summary>
    /// Queue/Topic name to forward the messages.
    /// </summary>
    public BicepValue<string> ForwardTo { get => _forwardTo; set => _forwardTo.Assign(value); }
    private readonly BicepValue<string> _forwardTo;

    /// <summary>
    /// ISO 8601 timespan duration of a peek-lock; that is, the amount of time
    /// that the message is locked for other receivers. The maximum value for
    /// LockDuration is 5 minutes; the default value is 1 minute.
    /// </summary>
    public BicepValue<TimeSpan> LockDuration { get => _lockDuration; set => _lockDuration.Assign(value); }
    private readonly BicepValue<TimeSpan> _lockDuration;

    /// <summary>
    /// The maximum delivery count. A message is automatically deadlettered
    /// after this number of deliveries. default value is 10.
    /// </summary>
    public BicepValue<int> MaxDeliveryCount { get => _maxDeliveryCount; set => _maxDeliveryCount.Assign(value); }
    private readonly BicepValue<int> _maxDeliveryCount;

    /// <summary>
    /// Maximum size (in KB) of the message payload that can be accepted by the
    /// queue. This property is only used in Premium today and default is 1024.
    /// </summary>
    public BicepValue<long> MaxMessageSizeInKilobytes { get => _maxMessageSizeInKilobytes; set => _maxMessageSizeInKilobytes.Assign(value); }
    private readonly BicepValue<long> _maxMessageSizeInKilobytes;

    /// <summary>
    /// The maximum size of the queue in megabytes, which is the size of memory
    /// allocated for the queue. Default is 1024.
    /// </summary>
    public BicepValue<int> MaxSizeInMegabytes { get => _maxSizeInMegabytes; set => _maxSizeInMegabytes.Assign(value); }
    private readonly BicepValue<int> _maxSizeInMegabytes;

    /// <summary>
    /// A value indicating if this queue requires duplicate detection.
    /// </summary>
    public BicepValue<bool> RequiresDuplicateDetection { get => _requiresDuplicateDetection; set => _requiresDuplicateDetection.Assign(value); }
    private readonly BicepValue<bool> _requiresDuplicateDetection;

    /// <summary>
    /// A value that indicates whether the queue supports the concept of
    /// sessions.
    /// </summary>
    public BicepValue<bool> RequiresSession { get => _requiresSession; set => _requiresSession.Assign(value); }
    private readonly BicepValue<bool> _requiresSession;

    /// <summary>
    /// Enumerates the possible values for the status of a messaging entity.
    /// </summary>
    public BicepValue<ServiceBusMessagingEntityStatus> Status { get => _status; set => _status.Assign(value); }
    private readonly BicepValue<ServiceBusMessagingEntityStatus> _status;

    /// <summary>
    /// Last time a message was sent, or the last time there was a receive
    /// request to this queue.
    /// </summary>
    public BicepValue<DateTimeOffset> AccessedOn { get => _accessedOn; }
    private readonly BicepValue<DateTimeOffset> _accessedOn;

    /// <summary>
    /// Message Count Details.
    /// </summary>
    public BicepValue<MessageCountDetails> CountDetails { get => _countDetails; }
    private readonly BicepValue<MessageCountDetails> _countDetails;

    /// <summary>
    /// The exact time the message was created.
    /// </summary>
    public BicepValue<DateTimeOffset> CreatedOn { get => _createdOn; }
    private readonly BicepValue<DateTimeOffset> _createdOn;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// The geo-location where the resource lives.
    /// </summary>
    public BicepValue<AzureLocation> Location { get => _location; }
    private readonly BicepValue<AzureLocation> _location;

    /// <summary>
    /// The number of messages in the queue.
    /// </summary>
    public BicepValue<long> MessageCount { get => _messageCount; }
    private readonly BicepValue<long> _messageCount;

    /// <summary>
    /// The size of the queue, in bytes.
    /// </summary>
    public BicepValue<long> SizeInBytes { get => _sizeInBytes; }
    private readonly BicepValue<long> _sizeInBytes;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// The exact time the message was updated.
    /// </summary>
    public BicepValue<DateTimeOffset> UpdatedOn { get => _updatedOn; }
    private readonly BicepValue<DateTimeOffset> _updatedOn;

    /// <summary>
    /// Gets or sets a reference to the parent ServiceBusNamespace.
    /// </summary>
    public ServiceBusNamespace? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<ServiceBusNamespace> _parent;

    /// <summary>
    /// Creates a new ServiceBusQueue.
    /// </summary>
    /// <param name="identifierName">
    /// The the Bicep identifier name of the ServiceBusQueue resource.  This
    /// can be used to refer to the resource in expressions, but is not the
    /// Azure name of the resource.  This value can contain letters, numbers,
    /// and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the ServiceBusQueue.</param>
    public ServiceBusQueue(string identifierName, string? resourceVersion = default)
        : base(identifierName, "Microsoft.ServiceBus/namespaces/queues", resourceVersion ?? "2024-01-01")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _autoDeleteOnIdle = BicepValue<TimeSpan>.DefineProperty(this, "AutoDeleteOnIdle", ["properties", "autoDeleteOnIdle"]);
        _deadLetteringOnMessageExpiration = BicepValue<bool>.DefineProperty(this, "DeadLetteringOnMessageExpiration", ["properties", "deadLetteringOnMessageExpiration"]);
        _defaultMessageTimeToLive = BicepValue<TimeSpan>.DefineProperty(this, "DefaultMessageTimeToLive", ["properties", "defaultMessageTimeToLive"]);
        _duplicateDetectionHistoryTimeWindow = BicepValue<TimeSpan>.DefineProperty(this, "DuplicateDetectionHistoryTimeWindow", ["properties", "duplicateDetectionHistoryTimeWindow"]);
        _enableBatchedOperations = BicepValue<bool>.DefineProperty(this, "EnableBatchedOperations", ["properties", "enableBatchedOperations"]);
        _enableExpress = BicepValue<bool>.DefineProperty(this, "EnableExpress", ["properties", "enableExpress"]);
        _enablePartitioning = BicepValue<bool>.DefineProperty(this, "EnablePartitioning", ["properties", "enablePartitioning"]);
        _forwardDeadLetteredMessagesTo = BicepValue<string>.DefineProperty(this, "ForwardDeadLetteredMessagesTo", ["properties", "forwardDeadLetteredMessagesTo"]);
        _forwardTo = BicepValue<string>.DefineProperty(this, "ForwardTo", ["properties", "forwardTo"]);
        _lockDuration = BicepValue<TimeSpan>.DefineProperty(this, "LockDuration", ["properties", "lockDuration"]);
        _maxDeliveryCount = BicepValue<int>.DefineProperty(this, "MaxDeliveryCount", ["properties", "maxDeliveryCount"]);
        _maxMessageSizeInKilobytes = BicepValue<long>.DefineProperty(this, "MaxMessageSizeInKilobytes", ["properties", "maxMessageSizeInKilobytes"]);
        _maxSizeInMegabytes = BicepValue<int>.DefineProperty(this, "MaxSizeInMegabytes", ["properties", "maxSizeInMegabytes"]);
        _requiresDuplicateDetection = BicepValue<bool>.DefineProperty(this, "RequiresDuplicateDetection", ["properties", "requiresDuplicateDetection"]);
        _requiresSession = BicepValue<bool>.DefineProperty(this, "RequiresSession", ["properties", "requiresSession"]);
        _status = BicepValue<ServiceBusMessagingEntityStatus>.DefineProperty(this, "Status", ["properties", "status"]);
        _accessedOn = BicepValue<DateTimeOffset>.DefineProperty(this, "AccessedOn", ["properties", "accessedAt"], isOutput: true);
        _countDetails = BicepValue<MessageCountDetails>.DefineProperty(this, "CountDetails", ["properties", "countDetails"], isOutput: true);
        _createdOn = BicepValue<DateTimeOffset>.DefineProperty(this, "CreatedOn", ["properties", "createdAt"], isOutput: true);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _location = BicepValue<AzureLocation>.DefineProperty(this, "Location", ["location"], isOutput: true);
        _messageCount = BicepValue<long>.DefineProperty(this, "MessageCount", ["properties", "messageCount"], isOutput: true);
        _sizeInBytes = BicepValue<long>.DefineProperty(this, "SizeInBytes", ["properties", "sizeInBytes"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _updatedOn = BicepValue<DateTimeOffset>.DefineProperty(this, "UpdatedOn", ["properties", "updatedAt"], isOutput: true);
        _parent = ResourceReference<ServiceBusNamespace>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported ServiceBusQueue resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2024-01-01.
        /// </summary>
        public static readonly string V2024_01_01 = "2024-01-01";

        /// <summary>
        /// 2021-11-01.
        /// </summary>
        public static readonly string V2021_11_01 = "2021-11-01";

        /// <summary>
        /// 2017-04-01.
        /// </summary>
        public static readonly string V2017_04_01 = "2017-04-01";
    }

    /// <summary>
    /// Creates a reference to an existing ServiceBusQueue.
    /// </summary>
    /// <param name="identifierName">
    /// The the Bicep identifier name of the ServiceBusQueue resource.  This
    /// can be used to refer to the resource in expressions, but is not the
    /// Azure name of the resource.  This value can contain letters, numbers,
    /// and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the ServiceBusQueue.</param>
    /// <returns>The existing ServiceBusQueue resource.</returns>
    public static ServiceBusQueue FromExisting(string identifierName, string? resourceVersion = default) =>
        new(identifierName, resourceVersion) { IsExistingResource = true };

    /// <summary>
    /// Get the requirements for naming this ServiceBusQueue resource.
    /// </summary>
    /// <returns>Naming requirements.</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override ResourceNameRequirements GetResourceNameRequirements() =>
        new(minLength: 1, maxLength: 260, validCharacters: ResourceNameCharacters.LowercaseLetters | ResourceNameCharacters.UppercaseLetters | ResourceNameCharacters.Numbers | ResourceNameCharacters.Hyphen | ResourceNameCharacters.Underscore | ResourceNameCharacters.Period);
}
