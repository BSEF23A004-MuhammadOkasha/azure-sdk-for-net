﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Microsoft.Azure.Management.Compute.Models;
using Microsoft.Azure.Management.V2.Resource.Core;
using System.Collections.Generic;

namespace Microsoft.Azure.Management.V2.Compute
{
    internal partial class VirtualMachineImageImpl : IndexableWrapper<VirtualMachineImageInner>, IVirtualMachineImage
    {
        internal VirtualMachineImageImpl(Region location, string publisher, string offer, string sku, string version, VirtualMachineImageInner inner) 
            : base(inner.Name, inner)
        {
            Location = location;
            ImageReference = new ImageReference
            {
                Publisher = publisher,
                Offer = offer,
                Sku = sku,
                Version = version
            };
        }

        public List<DataDiskImage> DataDiskImages
        {
            get
            {
                return Inner.DataDiskImages as List<DataDiskImage>;
            }
        }

        public ImageReference ImageReference
        {
            get;
            private set;
        }

        public Region? Location
        {
            get;
            private set;
        }

        public string Offer
        {
            get
            {
                return ImageReference.Offer;
            }
        }

        public OSDiskImage OsDiskImage
        {
            get
            {
                return Inner.OsDiskImage;
            }
        }

        public PurchasePlan Plan
        {
            get
            {
                return Inner.Plan;
            }
        }

        public string PublisherName
        {
            get
            {
                return ImageReference.Publisher;
            }
        }

        public string Sku
        {
            get
            {
                return ImageReference.Sku;
            }
        }

        public string Version
        {
            get
            {
                return ImageReference.Version;
            }
        }
    }
}
