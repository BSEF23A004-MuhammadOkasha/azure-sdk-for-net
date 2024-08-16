// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    /// <summary>
    /// The reason or list of reasons why a packet core has not been installed or requires a reinstall.
    /// Serialized Name: InstallationReason
    /// </summary>
    public readonly partial struct MobileNetworkInstallationReason : IEquatable<MobileNetworkInstallationReason>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MobileNetworkInstallationReason"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MobileNetworkInstallationReason(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoSlicesValue = "NoSlices";
        private const string NoPacketCoreDataPlaneValue = "NoPacketCoreDataPlane";
        private const string NoAttachedDataNetworksValue = "NoAttachedDataNetworks";
        private const string PublicLandMobileNetworkIdentifierHasChangedValue = "PublicLandMobileNetworkIdentifierHasChanged";
        private const string ControlPlaneAccessInterfaceHasChangedValue = "ControlPlaneAccessInterfaceHasChanged";
        private const string UserPlaneAccessInterfaceHasChangedValue = "UserPlaneAccessInterfaceHasChanged";
        private const string UserPlaneDataInterfaceHasChangedValue = "UserPlaneDataInterfaceHasChanged";
        private const string ControlPlaneAccessVirtualIPv4AddressesHasChangedValue = "ControlPlaneAccessVirtualIpv4AddressesHasChanged";
        private const string UserPlaneAccessVirtualIPv4AddressesHasChangedValue = "UserPlaneAccessVirtualIpv4AddressesHasChanged";

        /// <summary>
        /// The packet core has not been installed as the mobile network does not have any applicable configured slices.
        /// Serialized Name: InstallationReason.NoSlices
        /// </summary>
        public static MobileNetworkInstallationReason NoSlices { get; } = new MobileNetworkInstallationReason(NoSlicesValue);
        /// <summary>
        /// The packet core has not been installed as there is no configured data plane for this packet core.
        /// Serialized Name: InstallationReason.NoPacketCoreDataPlane
        /// </summary>
        public static MobileNetworkInstallationReason NoPacketCoreDataPlane { get; } = new MobileNetworkInstallationReason(NoPacketCoreDataPlaneValue);
        /// <summary>
        /// The packet core has not been installed as the packet core has no attached data networks.
        /// Serialized Name: InstallationReason.NoAttachedDataNetworks
        /// </summary>
        public static MobileNetworkInstallationReason NoAttachedDataNetworks { get; } = new MobileNetworkInstallationReason(NoAttachedDataNetworksValue);
        /// <summary>
        /// A reinstall is required as the packet core is running with out-of-date PLMN ID.
        /// Serialized Name: InstallationReason.PublicLandMobileNetworkIdentifierHasChanged
        /// </summary>
        public static MobileNetworkInstallationReason PublicLandMobileNetworkIdentifierHasChanged { get; } = new MobileNetworkInstallationReason(PublicLandMobileNetworkIdentifierHasChangedValue);
        /// <summary>
        /// A reinstall is required as the packet core is running with out-of-date control plane access interface information.
        /// Serialized Name: InstallationReason.ControlPlaneAccessInterfaceHasChanged
        /// </summary>
        public static MobileNetworkInstallationReason ControlPlaneAccessInterfaceHasChanged { get; } = new MobileNetworkInstallationReason(ControlPlaneAccessInterfaceHasChangedValue);
        /// <summary>
        /// A reinstall is required as the packet core is running with out-of-date user plane core interface.
        /// Serialized Name: InstallationReason.UserPlaneAccessInterfaceHasChanged
        /// </summary>
        public static MobileNetworkInstallationReason UserPlaneAccessInterfaceHasChanged { get; } = new MobileNetworkInstallationReason(UserPlaneAccessInterfaceHasChangedValue);
        /// <summary>
        /// A reinstall is required as the packet core is running with out-of-date user plane access interface.
        /// Serialized Name: InstallationReason.UserPlaneDataInterfaceHasChanged
        /// </summary>
        public static MobileNetworkInstallationReason UserPlaneDataInterfaceHasChanged { get; } = new MobileNetworkInstallationReason(UserPlaneDataInterfaceHasChangedValue);
        /// <summary>
        /// A reinstall is required as the packet core is running with out-of-date control plane access network virtual IP address.
        /// Serialized Name: InstallationReason.ControlPlaneAccessVirtualIpv4AddressesHasChanged
        /// </summary>
        public static MobileNetworkInstallationReason ControlPlaneAccessVirtualIPv4AddressesHasChanged { get; } = new MobileNetworkInstallationReason(ControlPlaneAccessVirtualIPv4AddressesHasChangedValue);
        /// <summary>
        /// A reinstall is required as the packet core is running with out-of-date user plane access network virtual IP address.
        /// Serialized Name: InstallationReason.UserPlaneAccessVirtualIpv4AddressesHasChanged
        /// </summary>
        public static MobileNetworkInstallationReason UserPlaneAccessVirtualIPv4AddressesHasChanged { get; } = new MobileNetworkInstallationReason(UserPlaneAccessVirtualIPv4AddressesHasChangedValue);
        /// <summary> Determines if two <see cref="MobileNetworkInstallationReason"/> values are the same. </summary>
        public static bool operator ==(MobileNetworkInstallationReason left, MobileNetworkInstallationReason right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MobileNetworkInstallationReason"/> values are not the same. </summary>
        public static bool operator !=(MobileNetworkInstallationReason left, MobileNetworkInstallationReason right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MobileNetworkInstallationReason"/>. </summary>
        public static implicit operator MobileNetworkInstallationReason(string value) => new MobileNetworkInstallationReason(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MobileNetworkInstallationReason other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MobileNetworkInstallationReason other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
