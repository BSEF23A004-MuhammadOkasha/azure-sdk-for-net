// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Information of community gallery if current gallery is shared to community. </summary>
    public partial class CommunityGalleryInfo
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="CommunityGalleryInfo"/>. </summary>
        public CommunityGalleryInfo()
        {
            PublicNames = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="CommunityGalleryInfo"/>. </summary>
        /// <param name="publisherUri"> The link to the publisher website. Visible to all users. </param>
        /// <param name="publisherContact"> Community gallery publisher support email. The email address of the publisher. Visible to all users. </param>
        /// <param name="eula"> End-user license agreement for community gallery image. </param>
        /// <param name="publicNamePrefix"> The prefix of the gallery name that will be displayed publicly. Visible to all users. </param>
        /// <param name="communityGalleryEnabled"> Contains info about whether community gallery sharing is enabled. </param>
        /// <param name="publicNames"> Community gallery public name list. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal CommunityGalleryInfo(Uri publisherUri, string publisherContact, string eula, string publicNamePrefix, bool? communityGalleryEnabled, IReadOnlyList<string> publicNames, Dictionary<string, BinaryData> rawData)
        {
            PublisherUri = publisherUri;
            PublisherContact = publisherContact;
            Eula = eula;
            PublicNamePrefix = publicNamePrefix;
            CommunityGalleryEnabled = communityGalleryEnabled;
            PublicNames = publicNames;
            _rawData = rawData;
        }

        /// <summary> The link to the publisher website. Visible to all users. </summary>
        public Uri PublisherUri { get; set; }
        /// <summary> Community gallery publisher support email. The email address of the publisher. Visible to all users. </summary>
        public string PublisherContact { get; set; }
        /// <summary> End-user license agreement for community gallery image. </summary>
        public string Eula { get; set; }
        /// <summary> The prefix of the gallery name that will be displayed publicly. Visible to all users. </summary>
        public string PublicNamePrefix { get; set; }
        /// <summary> Contains info about whether community gallery sharing is enabled. </summary>
        public bool? CommunityGalleryEnabled { get; }
        /// <summary> Community gallery public name list. </summary>
        public IReadOnlyList<string> PublicNames { get; }
    }
}
