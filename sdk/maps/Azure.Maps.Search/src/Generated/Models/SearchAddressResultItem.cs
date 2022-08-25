// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Maps.Search.Models
{
    /// <summary> Result object for a Search API response. </summary>
    public partial class SearchAddressResultItem
    {
        /// <summary> Initializes a new instance of SearchAddressResultItem. </summary>
        internal SearchAddressResultItem()
        {
            EntryPoints = new ChangeTrackingList<FacilityEntryPoint>();
        }

        /// <summary> Initializes a new instance of SearchAddressResultItem. </summary>
        /// <param name="type">
        /// One of:
        /// * POI
        /// * Street
        /// * Geography
        /// * Point Address
        /// * Address Range
        /// * Cross Street
        /// </param>
        /// <param name="id"> Id property. </param>
        /// <param name="score"> The value within a result set to indicate the relative matching score between results.  You can use this to  determine that result x is twice as likely to be as relevant as result y if the value of x is 2x the value of y.   The values vary between queries and is only meant as a relative value for one result set. </param>
        /// <param name="distanceInMeters"> Straight line distance between the result and geobias location in meters. </param>
        /// <param name="dataSourceInfo"> Information about the original data source of the Result. Used for support requests. </param>
        /// <param name="entityType"></param>
        /// <param name="pointOfInterest"> Details of the returned POI including information such as the name, phone, url address, and classifications. </param>
        /// <param name="address"> The address of the result. </param>
        /// <param name="positionInternal"> A location represented as a latitude and longitude using short names &apos;lat&apos; &amp; &apos;lon&apos;. </param>
        /// <param name="viewportInternal"> The viewport that covers the result represented by the top-left and bottom-right coordinates of the viewport. </param>
        /// <param name="entryPoints"> Array of EntryPoints. Those describe the types of entrances available at the location. The type can be &quot;main&quot; for main entrances such as a front door, or a lobby, and &quot;minor&quot;, for side and back doors. </param>
        /// <param name="addressRanges"> Describes the address range on both sides of the street for a search result. Coordinates for the start and end locations of the address range are included. </param>
        /// <param name="dataSources"> Optional section. Reference geometry id for use with the [Get Search Polygon](https://docs.microsoft.com/rest/api/maps/search/getsearchpolygon) API. </param>
        /// <param name="matchType">
        /// Information on the type of match.
        /// 
        /// One of:
        ///   * AddressPoint
        ///   * HouseNumberRange
        ///   * Street
        /// </param>
        /// <param name="detourTime"> Detour time in seconds. Only returned for calls to the Search Along Route API. </param>
        internal SearchAddressResultItem(SearchAddressResultType? type, string id, double? score, double? distanceInMeters, string dataSourceInfo, GeographicEntityType? entityType, PointOfInterest pointOfInterest, MapsAddress address, LatLongPairAbbreviated positionInternal, BoundingBox viewportInternal, IReadOnlyList<FacilityEntryPoint> entryPoints, AddressRanges addressRanges, DataSource dataSources, MapsSearchMatchType? matchType, int? detourTime)
        {
            Type = type;
            Id = id;
            Score = score;
            DistanceInMeters = distanceInMeters;
            DataSourceInfo = dataSourceInfo;
            EntityType = entityType;
            PointOfInterest = pointOfInterest;
            Address = address;
            PositionInternal = positionInternal;
            ViewportInternal = viewportInternal;
            EntryPoints = entryPoints;
            AddressRanges = addressRanges;
            DataSources = dataSources;
            MatchType = matchType;
            DetourTime = detourTime;
        }

        /// <summary>
        /// One of:
        /// * POI
        /// * Street
        /// * Geography
        /// * Point Address
        /// * Address Range
        /// * Cross Street
        /// </summary>
        public SearchAddressResultType? Type { get; }
        /// <summary> Id property. </summary>
        public string Id { get; }
        /// <summary> The value within a result set to indicate the relative matching score between results.  You can use this to  determine that result x is twice as likely to be as relevant as result y if the value of x is 2x the value of y.   The values vary between queries and is only meant as a relative value for one result set. </summary>
        public double? Score { get; }
        /// <summary> Straight line distance between the result and geobias location in meters. </summary>
        public double? DistanceInMeters { get; }
        /// <summary> Gets the entity type. </summary>
        public GeographicEntityType? EntityType { get; }
        /// <summary> Details of the returned POI including information such as the name, phone, url address, and classifications. </summary>
        public PointOfInterest PointOfInterest { get; }
        /// <summary> The address of the result. </summary>
        public MapsAddress Address { get; }
        /// <summary> Array of EntryPoints. Those describe the types of entrances available at the location. The type can be &quot;main&quot; for main entrances such as a front door, or a lobby, and &quot;minor&quot;, for side and back doors. </summary>
        public IReadOnlyList<FacilityEntryPoint> EntryPoints { get; }
        /// <summary> Describes the address range on both sides of the street for a search result. Coordinates for the start and end locations of the address range are included. </summary>
        public AddressRanges AddressRanges { get; }
        /// <summary> Optional section. Reference geometry id for use with the [Get Search Polygon](https://docs.microsoft.com/rest/api/maps/search/getsearchpolygon) API. </summary>
        public DataSource DataSources { get; }
        /// <summary>
        /// Information on the type of match.
        /// 
        /// One of:
        ///   * AddressPoint
        ///   * HouseNumberRange
        ///   * Street
        /// </summary>
        public MapsSearchMatchType? MatchType { get; }
        /// <summary> Detour time in seconds. Only returned for calls to the Search Along Route API. </summary>
        public int? DetourTime { get; }
    }
}
