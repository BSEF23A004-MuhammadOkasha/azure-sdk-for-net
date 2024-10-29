// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;
using System.ComponentModel;

namespace Azure.Provisioning.EventGrid;

/// <summary>
/// EventSubscription.
/// </summary>
public partial class EventSubscription : ProvisionableResource
{
    /// <summary>
    /// Name of the event subscription to be created. Event subscription names
    /// must be between 3 and 64 characters in length and should use
    /// alphanumeric letters only.
    /// </summary>
    public BicepValue<string> Name 
    {
        get { Initialize(); return _name!; }
        set { Initialize(); _name!.Assign(value); }
    }
    private BicepValue<string>? _name;

    /// <summary>
    /// The dead letter destination of the event subscription. Any event that
    /// cannot be delivered to its&apos; destination is sent to the dead
    /// letter destination.             Uses Azure Event Grid&apos;s identity
    /// to acquire the authentication tokens being used during delivery /
    /// dead-lettering.             Please note
    /// Azure.ResourceManager.EventGrid.Models.DeadLetterDestination is the
    /// base class. According to the scenario, a derived class of the base
    /// class might need to be assigned here, or this property needs to be
    /// casted to one of the possible derived classes.             The
    /// available derived classes include
    /// Azure.ResourceManager.EventGrid.Models.StorageBlobDeadLetterDestination.
    /// </summary>
    public DeadLetterDestination DeadLetterDestination 
    {
        get { Initialize(); return _deadLetterDestination!; }
        set { Initialize(); AssignOrReplace(ref _deadLetterDestination, value); }
    }
    private DeadLetterDestination? _deadLetterDestination;

    /// <summary>
    /// The dead letter destination of the event subscription. Any event that
    /// cannot be delivered to its&apos; destination is sent to the dead
    /// letter destination.             Uses the managed identity setup on the
    /// parent resource (namely, topic or domain) to acquire the
    /// authentication tokens being used during delivery / dead-lettering.
    /// </summary>
    public DeadLetterWithResourceIdentity DeadLetterWithResourceIdentity 
    {
        get { Initialize(); return _deadLetterWithResourceIdentity!; }
        set { Initialize(); AssignOrReplace(ref _deadLetterWithResourceIdentity, value); }
    }
    private DeadLetterWithResourceIdentity? _deadLetterWithResourceIdentity;

    /// <summary>
    /// Information about the destination where events have to be delivered for
    /// the event subscription.             Uses the managed identity setup on
    /// the parent resource (namely, topic or domain) to acquire the
    /// authentication tokens being used during delivery / dead-lettering.
    /// </summary>
    public DeliveryWithResourceIdentity DeliveryWithResourceIdentity 
    {
        get { Initialize(); return _deliveryWithResourceIdentity!; }
        set { Initialize(); AssignOrReplace(ref _deliveryWithResourceIdentity, value); }
    }
    private DeliveryWithResourceIdentity? _deliveryWithResourceIdentity;

    /// <summary>
    /// Information about the destination where events have to be delivered for
    /// the event subscription.             Uses Azure Event Grid&apos;s
    /// identity to acquire the authentication tokens being used during
    /// delivery / dead-lettering.             Please note
    /// Azure.ResourceManager.EventGrid.Models.EventSubscriptionDestination is
    /// the base class. According to the scenario, a derived class of the base
    /// class might need to be assigned here, or this property needs to be
    /// casted to one of the possible derived classes.             The
    /// available derived classes include
    /// Azure.ResourceManager.EventGrid.Models.AzureFunctionEventSubscriptionDestination,
    /// Azure.ResourceManager.EventGrid.Models.EventHubEventSubscriptionDestination,
    /// Azure.ResourceManager.EventGrid.Models.HybridConnectionEventSubscriptionDestination,
    /// Azure.ResourceManager.EventGrid.Models.MonitorAlertEventSubscriptionDestination,
    /// Azure.ResourceManager.EventGrid.Models.NamespaceTopicEventSubscriptionDestination,
    /// Azure.ResourceManager.EventGrid.Models.PartnerEventSubscriptionDestination,
    /// Azure.ResourceManager.EventGrid.Models.ServiceBusQueueEventSubscriptionDestination,
    /// Azure.ResourceManager.EventGrid.Models.ServiceBusTopicEventSubscriptionDestination,
    /// Azure.ResourceManager.EventGrid.Models.StorageQueueEventSubscriptionDestination
    /// and
    /// Azure.ResourceManager.EventGrid.Models.WebHookEventSubscriptionDestination.
    /// </summary>
    public EventSubscriptionDestination Destination 
    {
        get { Initialize(); return _destination!; }
        set { Initialize(); AssignOrReplace(ref _destination, value); }
    }
    private EventSubscriptionDestination? _destination;

    /// <summary>
    /// The event delivery schema for the event subscription.
    /// </summary>
    public BicepValue<EventDeliverySchema> EventDeliverySchema 
    {
        get { Initialize(); return _eventDeliverySchema!; }
        set { Initialize(); _eventDeliverySchema!.Assign(value); }
    }
    private BicepValue<EventDeliverySchema>? _eventDeliverySchema;

    /// <summary>
    /// Expiration time of the event subscription.
    /// </summary>
    public BicepValue<DateTimeOffset> ExpireOn 
    {
        get { Initialize(); return _expireOn!; }
        set { Initialize(); _expireOn!.Assign(value); }
    }
    private BicepValue<DateTimeOffset>? _expireOn;

    /// <summary>
    /// Information about the filter for the event subscription.
    /// </summary>
    public EventSubscriptionFilter Filter 
    {
        get { Initialize(); return _filter!; }
        set { Initialize(); AssignOrReplace(ref _filter, value); }
    }
    private EventSubscriptionFilter? _filter;

    /// <summary>
    /// List of user defined labels.
    /// </summary>
    public BicepList<string> Labels 
    {
        get { Initialize(); return _labels!; }
        set { Initialize(); _labels!.Assign(value); }
    }
    private BicepList<string>? _labels;

    /// <summary>
    /// The retry policy for events. This can be used to configure maximum
    /// number of delivery attempts and time to live for events.
    /// </summary>
    public EventSubscriptionRetryPolicy RetryPolicy 
    {
        get { Initialize(); return _retryPolicy!; }
        set { Initialize(); AssignOrReplace(ref _retryPolicy, value); }
    }
    private EventSubscriptionRetryPolicy? _retryPolicy;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id 
    {
        get { Initialize(); return _id!; }
    }
    private BicepValue<ResourceIdentifier>? _id;

    /// <summary>
    /// Provisioning state of the event subscription.
    /// </summary>
    public BicepValue<EventSubscriptionProvisioningState> ProvisioningState 
    {
        get { Initialize(); return _provisioningState!; }
    }
    private BicepValue<EventSubscriptionProvisioningState>? _provisioningState;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public SystemData SystemData 
    {
        get { Initialize(); return _systemData!; }
    }
    private SystemData? _systemData;

    /// <summary>
    /// Name of the topic of the event subscription.
    /// </summary>
    public BicepValue<string> Topic 
    {
        get { Initialize(); return _topic!; }
    }
    private BicepValue<string>? _topic;

    /// <summary>
    /// Creates a new EventSubscription.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the EventSubscription resource.  This
    /// can be used to refer to the resource in expressions, but is not the
    /// Azure name of the resource.  This value can contain letters, numbers,
    /// and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the EventSubscription.</param>
    public EventSubscription(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.EventGrid/eventSubscriptions", resourceVersion ?? "2022-06-15")
    {
    }

    /// <summary>
    /// Define all the provisionable properties of EventSubscription.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        _name = DefineProperty<string>("Name", ["name"], isRequired: true);
        _deadLetterDestination = DefineModelProperty<DeadLetterDestination>("DeadLetterDestination", ["properties", "deadLetterDestination"]);
        _deadLetterWithResourceIdentity = DefineModelProperty<DeadLetterWithResourceIdentity>("DeadLetterWithResourceIdentity", ["properties", "deadLetterWithResourceIdentity"]);
        _deliveryWithResourceIdentity = DefineModelProperty<DeliveryWithResourceIdentity>("DeliveryWithResourceIdentity", ["properties", "deliveryWithResourceIdentity"]);
        _destination = DefineModelProperty<EventSubscriptionDestination>("Destination", ["properties", "destination"]);
        _eventDeliverySchema = DefineProperty<EventDeliverySchema>("EventDeliverySchema", ["properties", "eventDeliverySchema"]);
        _expireOn = DefineProperty<DateTimeOffset>("ExpireOn", ["properties", "expirationTimeUtc"]);
        _filter = DefineModelProperty<EventSubscriptionFilter>("Filter", ["properties", "filter"]);
        _labels = DefineListProperty<string>("Labels", ["properties", "labels"]);
        _retryPolicy = DefineModelProperty<EventSubscriptionRetryPolicy>("RetryPolicy", ["properties", "retryPolicy"]);
        _id = DefineProperty<ResourceIdentifier>("Id", ["id"], isOutput: true);
        _provisioningState = DefineProperty<EventSubscriptionProvisioningState>("ProvisioningState", ["properties", "provisioningState"], isOutput: true);
        _systemData = DefineModelProperty<SystemData>("SystemData", ["systemData"], isOutput: true);
        _topic = DefineProperty<string>("Topic", ["properties", "topic"], isOutput: true);
    }

    /// <summary>
    /// Supported EventSubscription resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2022-06-15.
        /// </summary>
        public static readonly string V2022_06_15 = "2022-06-15";

        /// <summary>
        /// 2021-12-01.
        /// </summary>
        public static readonly string V2021_12_01 = "2021-12-01";

        /// <summary>
        /// 2020-06-01.
        /// </summary>
        public static readonly string V2020_06_01 = "2020-06-01";

        /// <summary>
        /// 2019-06-01.
        /// </summary>
        public static readonly string V2019_06_01 = "2019-06-01";

        /// <summary>
        /// 2019-01-01.
        /// </summary>
        public static readonly string V2019_01_01 = "2019-01-01";

        /// <summary>
        /// 2018-01-01.
        /// </summary>
        public static readonly string V2018_01_01 = "2018-01-01";
    }

    /// <summary>
    /// Creates a reference to an existing EventSubscription.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the EventSubscription resource.  This
    /// can be used to refer to the resource in expressions, but is not the
    /// Azure name of the resource.  This value can contain letters, numbers,
    /// and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the EventSubscription.</param>
    /// <returns>The existing EventSubscription resource.</returns>
    public static EventSubscription FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };

    /// <summary>
    /// Get the requirements for naming this EventSubscription resource.
    /// </summary>
    /// <returns>Naming requirements.</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override ResourceNameRequirements GetResourceNameRequirements() =>
        new(minLength: 3, maxLength: 64, validCharacters: ResourceNameCharacters.LowercaseLetters | ResourceNameCharacters.UppercaseLetters | ResourceNameCharacters.Numbers | ResourceNameCharacters.Hyphen);
}
