// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

//
// This file was autogenerated by a tool.
// Do not modify it.
//

namespace Microsoft.Azure.Batch
{
    using Models = Microsoft.Azure.Batch.Protocol.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A reference to an Azure Virtual Machines Marketplace Image or a custom Azure Virtual Machine Image. To get the list 
    /// of all Azure Marketplace Image references verified by Azure Batch, see <see cref="PoolOperations.ListSupportedImages"/>.
    /// </summary>
    public partial class ImageReference : ITransportObjectProvider<Models.ImageReference>, IPropertyMetadata
    {
        #region Constructors

        internal ImageReference(Models.ImageReference protocolObject)
        {
            this.Offer = protocolObject.Offer;
            this.Publisher = protocolObject.Publisher;
            this.Sku = protocolObject.Sku;
            this.Version = protocolObject.Version;
            this.VirtualMachineImageId = protocolObject.VirtualMachineImageId;
        }

        #endregion Constructors

        #region ImageReference

        /// <summary>
        /// Gets the offer type of the Azure Virtual Machines Marketplace Image.
        /// </summary>
        /// <remarks>
        /// For example, UbuntuServer or WindowsServer.
        /// </remarks>
        public string Offer { get; }

        /// <summary>
        /// Gets the publisher of the Azure Virtual Machines Marketplace Image.
        /// </summary>
        /// <remarks>
        /// For example, Canonical or MicrosoftWindowsServer.
        /// </remarks>
        public string Publisher { get; }

        /// <summary>
        /// Gets the SKU of the Azure Virtual Machines Marketplace Image.
        /// </summary>
        /// <remarks>
        /// For example, 18.04-LTS or 2019-Datacenter.
        /// </remarks>
        public string Sku { get; }

        /// <summary>
        /// Gets the version of the Azure Virtual Machines Marketplace Image.
        /// </summary>
        /// <remarks>
        /// If this property is not specified, it defaults to 'latest', which is the latest version of the image.
        /// </remarks>
        public string Version { get; }

        /// <summary>
        /// Gets the ARM resource identifier of the Virtual Machine Image or Shared Image Gallery Image. Computes Compute 
        /// Nodes of the Pool will be created using this Image Id. This is of either the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.Compute/images/{imageName} 
        /// for Virtual Machine Image or /subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.Compute/galleries/{galleryName}/images/{imageDefinitionName}/versions/{versionId} 
        /// for SIG image.
        /// </summary>
        /// <remarks>
        /// This property is mutually exclusive with other <see cref="ImageReference"/> properties. For Virtual Machine Image 
        /// it must be in the same region and subscription as the Azure Batch account. For SIG image it must have replicas 
        /// in the same region as the Azure Batch account. For information about the firewall settings for the Batch Compute 
        /// Node agent to communicate with the Batch service see https://docs.microsoft.com/en-us/azure/batch/batch-api-basics#virtual-network-vnet-and-firewall-configuration.
        /// </remarks>
        public string VirtualMachineImageId { get; }

        #endregion // ImageReference

        #region IPropertyMetadata

        bool IModifiable.HasBeenModified
        {
            //This class is compile time readonly so it cannot have been modified
            get { return false; }
        }

        bool IReadOnly.IsReadOnly
        {
            get { return true; }
            set
            {
                // This class is compile time readonly already
            }
        }

        #endregion // IPropertyMetadata

        #region Internal/private methods

        /// <summary>
        /// Return a protocol object of the requested type.
        /// </summary>
        /// <returns>The protocol object of the requested type.</returns>
        Models.ImageReference ITransportObjectProvider<Models.ImageReference>.GetTransportObject()
        {
            Models.ImageReference result = new Models.ImageReference()
            {
                Offer = this.Offer,
                Publisher = this.Publisher,
                Sku = this.Sku,
                Version = this.Version,
                VirtualMachineImageId = this.VirtualMachineImageId,
            };

            return result;
        }

        /// <summary>
        /// Converts a collection of protocol layer objects to object layer collection objects.
        /// </summary>
        internal static IList<ImageReference> ConvertFromProtocolCollection(IEnumerable<Models.ImageReference> protoCollection)
        {
            ConcurrentChangeTrackedModifiableList<ImageReference> converted = UtilitiesInternal.CollectionToThreadSafeCollectionIModifiable(
                items: protoCollection,
                objectCreationFunc: o => new ImageReference(o));

            return converted;
        }

        /// <summary>
        /// Converts a collection of protocol layer objects to object layer collection objects, in a frozen state.
        /// </summary>
        internal static IList<ImageReference> ConvertFromProtocolCollectionAndFreeze(IEnumerable<Models.ImageReference> protoCollection)
        {
            ConcurrentChangeTrackedModifiableList<ImageReference> converted = UtilitiesInternal.CollectionToThreadSafeCollectionIModifiable(
                items: protoCollection,
                objectCreationFunc: o => new ImageReference(o).Freeze());

            converted = UtilitiesInternal.CreateObjectWithNullCheck(converted, o => o.Freeze());

            return converted;
        }

        /// <summary>
        /// Converts a collection of protocol layer objects to object layer collection objects, with each object marked readonly
        /// and returned as a readonly collection.
        /// </summary>
        internal static IReadOnlyList<ImageReference> ConvertFromProtocolCollectionReadOnly(IEnumerable<Models.ImageReference> protoCollection)
        {
            IReadOnlyList<ImageReference> converted =
                UtilitiesInternal.CreateObjectWithNullCheck(
                    UtilitiesInternal.CollectionToNonThreadSafeCollection(
                        items: protoCollection,
                        objectCreationFunc: o => new ImageReference(o).Freeze()), o => o.AsReadOnly());

            return converted;
        }

        #endregion // Internal/private methods
    }
}