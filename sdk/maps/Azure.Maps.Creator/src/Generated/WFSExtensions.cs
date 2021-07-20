// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Azure.Maps.Creator
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for WFS.
    /// </summary>
    public static partial class WFSExtensions
    {
            /// <summary>
            /// **Applies to:** see pricing [tiers](https://aka.ms/AzureMapsPricingTier).
            ///
            /// Creator makes it possible to develop applications based on your private
            /// indoor map data using Azure Maps API and SDK.
            /// [This](https://docs.microsoft.com/azure/azure-maps/creator-indoor-maps)
            /// article introduces concepts and tools that apply to Azure Maps Creator.
            ///
            /// The Web Feature Service (WFS) API is part of  Creator. WFS API follows the
            /// [Open Geospatial Consortium API standard for
            /// Features](http://docs.opengeospatial.org/is/17-069r3/17-069r3.html) to
            /// query
            /// [Datasets](https://docs.microsoft.com/en-us/rest/api/maps/dataset/createpreview).
            /// A dataset consists of multiple feature collections. A feature collection is
            /// a collection of features of a similar type, based on a common schema.
            /// The Get Landing Page API provides links to the API definition, the
            /// Conformance statements  and the metadata about the feature data in this
            /// dataset.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='datasetId'>
            /// The identifier for the dataset to query from.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LandingPageResponse> GetLandingPageAsync(this IWFS operations, string datasetId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetLandingPageWithHttpMessagesAsync(datasetId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// **Applies to:** see pricing [tiers](https://aka.ms/AzureMapsPricingTier).
            ///
            /// Creator makes it possible to develop applications based on your private
            /// indoor map data using Azure Maps API and SDK.
            /// [This](https://docs.microsoft.com/azure/azure-maps/creator-indoor-maps)
            /// article introduces concepts and tools that apply to Azure Maps Creator.
            ///
            /// The Web Feature Service (WFS) API is part of  Creator. WFS API follows the
            /// [Open Geospatial Consortium API standard for
            /// Features](http://docs.opengeospatial.org/is/17-069r3/17-069r3.html) to
            /// query
            /// [Datasets](https://docs.microsoft.com/en-us/rest/api/maps/dataset/createpreview).
            /// A dataset consists of multiple feature collections. A feature collection is
            /// a collection of features of a similar type, based on a common schema.
            /// The Get Requirements Classes lists all requirements classes specified in
            /// the standard that the server conforms to.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='datasetId'>
            /// The identifier for the dataset to query from.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ConformanceResponse> GetConformanceAsync(this IWFS operations, string datasetId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetConformanceWithHttpMessagesAsync(datasetId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// **Applies to:** see pricing [tiers](https://aka.ms/AzureMapsPricingTier).
            ///
            /// Creator makes it possible to develop applications based on your private
            /// indoor map data using Azure Maps API and SDK.
            /// [This](https://docs.microsoft.com/azure/azure-maps/creator-indoor-maps)
            /// article introduces concepts and tools that apply to Azure Maps Creator.
            ///
            /// The Web Feature Service (WFS) API is part of  Creator. WFS API follows the
            /// [Open Geospatial Consortium API standard for
            /// Features](http://docs.opengeospatial.org/is/17-069r3/17-069r3.html) to
            /// query
            /// [Datasets](https://docs.microsoft.com/en-us/rest/api/maps/dataset/createpreview).
            /// A dataset consists of multiple feature collections. A feature collection is
            /// a collection of features of a similar type, based on a common schema.
            /// The Collections Description API provides descriptions of all the
            /// collections in a given dataset.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='datasetId'>
            /// The identifier for the dataset to query from.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CollectionsResponse> GetCollectionsAsync(this IWFS operations, string datasetId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetCollectionsWithHttpMessagesAsync(datasetId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// **Applies to:** see pricing [tiers](https://aka.ms/AzureMapsPricingTier).
            ///
            /// Creator makes it possible to develop applications based on your private
            /// indoor map data using Azure Maps API and SDK.
            /// [This](https://docs.microsoft.com/azure/azure-maps/creator-indoor-maps)
            /// article introduces concepts and tools that apply to Azure Maps Creator.
            ///
            /// The Web Feature Service (WFS) API is part of  Creator. WFS API follows the
            /// [Open Geospatial Consortium API standard for
            /// Features](http://docs.opengeospatial.org/is/17-069r3/17-069r3.html) to
            /// query
            /// [Datasets](https://docs.microsoft.com/en-us/rest/api/maps/dataset/createpreview).
            /// A dataset consists of multiple feature collections. A feature collection is
            /// a collection of features of a similar type, based on a common schema.
            ///
            /// The Collection Description API provides the description of a given
            /// collection. It includes the links to the operations that can be performed
            /// on the collection.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='datasetId'>
            /// The identifier for the dataset to query from.
            /// </param>
            /// <param name='collectionId'>
            /// Identifier (name) of a specific collection
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CollectionInfo> GetCollectionAsync(this IWFS operations, string datasetId, string collectionId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetCollectionWithHttpMessagesAsync(datasetId, collectionId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// **Applies to:** see pricing [tiers](https://aka.ms/AzureMapsPricingTier).
            ///
            /// Creator makes it possible to develop applications based on your private
            /// indoor map data using Azure Maps API and SDK.
            /// [This](https://docs.microsoft.com/azure/azure-maps/creator-indoor-maps)
            /// article introduces concepts and tools that apply to Azure Maps Creator.
            ///
            /// [This](https://docs.microsoft.com/en-us/azure/azure-maps/creator-indoor-maps)
            /// article introduces concepts and tools that apply to Azure Maps Creator. WFS
            /// API follows the [Open Geospatial Consortium API standard for
            /// Features](http://docs.opengeospatial.org/is/17-069r3/17-069r3.html) to
            /// query
            /// [Datasets](https://docs.microsoft.com/en-us/rest/api/maps/dataset/createpreview).
            /// A dataset consists of multiple feature collections. A feature collection is
            /// a collection of features of a similar type, based on a common schema.
            ///
            /// The Collection Definition API provides the detailed data model of a given
            /// collection.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='datasetId'>
            /// The identifier for the dataset to query from.
            /// </param>
            /// <param name='collectionId'>
            /// Identifier (name) of a specific collection
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CollectionDefinitionResponse> GetCollectionDefinitionAsync(this IWFS operations, string datasetId, string collectionId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetCollectionDefinitionWithHttpMessagesAsync(datasetId, collectionId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// **Applies to:** see pricing [tiers](https://aka.ms/AzureMapsPricingTier).
            ///
            /// Creator makes it possible to develop applications based on your private
            /// indoor map data using Azure Maps API and SDK.
            /// [This](https://docs.microsoft.com/azure/azure-maps/creator-indoor-maps)
            /// article introduces concepts and tools that apply to Azure Maps Creator.
            ///
            /// The Web Feature Service (WFS) API is part of  Creator. WFS API follows the
            /// [Open Geospatial Consortium API standard for
            /// Features](http://docs.opengeospatial.org/is/17-069r3/17-069r3.html) to
            /// query
            /// [Datasets](https://docs.microsoft.com/en-us/rest/api/maps/dataset/createpreview).
            /// A dataset consists of multiple feature collections. A feature collection is
            /// a collection of features of a similar type, based on a common schema.
            /// The Get Features API returns the list of features in the given collection.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='datasetId'>
            /// The identifier for the dataset to query from.
            /// </param>
            /// <param name='collectionId'>
            /// Identifier (name) of a specific collection
            /// </param>
            /// <param name='limit'>
            /// The optional limit parameter limits the number of features that are
            /// presented in the response document.
            /// Only features that are on the first level of the collection in the response
            /// document are counted. Nested objects contained within the explicitly
            /// requested features shall not be counted.
            /// * Minimum = 1 * Maximum = 50 * Default = 10
            /// </param>
            /// <param name='bbox'>
            /// Only features that have a geometry that intersects the supplied bounding
            /// box are selected.
            /// * Lower left corner, coordinate axis 1 * Lower left corner, coordinate axis
            /// 2 * Upper right corner, coordinate axis 1 * Upper right corner, coordinate
            /// axis 2
            /// The coordinate reference system of the values is WGS84 longitude/latitude
            /// (http://www.opengis.net/def/crs/OGC/1.3/CRS84) unless a different
            /// coordinate reference system is specified in the parameter `bbox-crs`.
            /// For WGS84 longitude/latitude the values are in most cases the sequence of
            /// minimum longitude, minimum latitude, maximum longitude and maximum
            /// latitude. However, in cases where the box spans the antimeridian the first
            /// value (west-most box edge) is larger than the third value (east-most box
            /// edge).
            /// </param>
            /// <param name='filter'>
            /// Filter expression to search for features with specific property values in a
            /// given collection. Only feature properties of scalar type and equals
            /// operator are supported.
            /// This is a special parameter where the parameter name is a case sensitive
            /// property name. The scheme for this parameter is {property name}={property
            /// value}. Unless "filter" is one of the property names in the collection,
            /// "filter" should not be used as a parameter name. To search for features
            /// with "name" property value "21N13", use "name=21N13".
            /// Multiple filters are supported and should be represented as multiple query
            /// parameters. E.g.,
            /// &lt;property1&gt;=&lt;value1&gt;&amp;&lt;property2&gt;=&lt;value2&gt;
            /// String values are case sensitive.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ExtendedGeoJsonFeatureCollection> GetFeaturesAsync(this IWFS operations, string datasetId, string collectionId, int? limit = default(int?), string bbox = default(string), string filter = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetFeaturesWithHttpMessagesAsync(datasetId, collectionId, limit, bbox, filter, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// **Applies to:** see pricing [tiers](https://aka.ms/AzureMapsPricingTier).
            ///
            /// Creator makes it possible to develop applications based on your private
            /// indoor map data using Azure Maps API and SDK.
            /// [This](https://docs.microsoft.com/azure/azure-maps/creator-indoor-maps)
            /// article introduces concepts and tools that apply to Azure Maps Creator.
            ///
            /// The Web Feature Service (WFS) API is part of  Creator. WFS API follows the
            /// [Open Geospatial Consortium API standard for
            /// Features](http://docs.opengeospatial.org/is/17-069r3/17-069r3.html) to
            /// query
            /// [Datasets](https://docs.microsoft.com/en-us/rest/api/maps/dataset/createpreview).
            /// A dataset consists of multiple feature collections. A feature collection is
            /// a collection of features of a similar type, based on a common schema.
            /// The Get Feature API returns the feature identified by the provided id in
            /// the given collection.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='datasetId'>
            /// The identifier for the dataset to query from.
            /// </param>
            /// <param name='collectionId'>
            /// Identifier (name) of a specific collection
            /// </param>
            /// <param name='featureId'>
            /// Local identifier of a specific feature
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<FeatureResponse> GetFeatureAsync(this IWFS operations, string datasetId, string collectionId, string featureId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetFeatureWithHttpMessagesAsync(datasetId, collectionId, featureId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// **Applies to:** see pricing [tiers](https://aka.ms/AzureMapsPricingTier).
            ///
            /// Creator makes it possible to develop applications based on your private
            /// indoor map data using Azure Maps API and SDK.
            /// [This](https://docs.microsoft.com/azure/azure-maps/creator-indoor-maps)
            /// article introduces concepts and tools that apply to Azure Maps Creator.
            ///
            /// The Web Feature Service (WFS) API is part of  Creator. WFS API follows the
            /// [Open Geospatial Consortium API standard for
            /// Features](http://docs.opengeospatial.org/is/17-069r3/17-069r3.html) to
            /// query
            /// [Datasets](https://docs.microsoft.com/en-us/rest/api/maps/dataset/createpreview).
            /// A dataset consists of multiple feature collections. A feature collection is
            /// a collection of features of a similar type, based on a common schema.
            /// The Delete Feature API deletes the feature identified by the provided id in
            /// the given collection. At this point this API supports only facility
            /// features. Deleting a facility feature deletes all the child features of
            /// that facility recursively.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='datasetId'>
            /// The identifier for the dataset to query from.
            /// </param>
            /// <param name='collectionId'>
            /// Identifier (name) of a specific collection
            /// </param>
            /// <param name='featureId'>
            /// Local identifier of a specific feature
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteFeatureAsync(this IWFS operations, string datasetId, string collectionId, string featureId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteFeatureWithHttpMessagesAsync(datasetId, collectionId, featureId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
