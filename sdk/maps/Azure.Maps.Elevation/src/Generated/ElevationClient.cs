// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Maps.Elevation.Models;

namespace Azure.Maps.Elevation
{
    /// <summary> The Elevation service client. </summary>
    public partial class ElevationClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal ElevationRestClient RestClient { get; }

        /// <summary> Initializes a new instance of ElevationClient for mocking. </summary>
        protected ElevationClient()
        {
        }

        /// <summary> Initializes a new instance of ElevationClient. </summary>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="geography"> This parameter specifies where the Azure Maps Creator resource is located.  Valid values are us and eu. </param>
        /// <param name="xMsClientId"> Specifies which account is intended for usage in conjunction with the Azure AD security model.  It represents a unique ID for the Azure Maps account and can be retrieved from the Azure Maps management  plane Account API. To use Azure AD security in Azure Maps see the following [articles](https://aka.ms/amauthdetails) for guidance. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public ElevationClient(TokenCredential credential, Geography? geography = default, string xMsClientId = null, ElevationClientOptions options = null)
        {
            if (credential == null)
            {
                throw new ArgumentNullException(nameof(credential));
            }
            geography ??= Geography.Us;

            options ??= new ElevationClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            string[] scopes = { "https://atlas.microsoft.com/.default" };
            _pipeline = HttpPipelineBuilder.Build(options, new BearerTokenAuthenticationPolicy(credential, scopes));
            RestClient = new ElevationRestClient(_clientDiagnostics, _pipeline, geography, xMsClientId, options.Version);
        }

        /// <summary> Initializes a new instance of ElevationClient. </summary>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="geography"> This parameter specifies where the Azure Maps Creator resource is located.  Valid values are us and eu. </param>
        /// <param name="xMsClientId"> Specifies which account is intended for usage in conjunction with the Azure AD security model.  It represents a unique ID for the Azure Maps account and can be retrieved from the Azure Maps management  plane Account API. To use Azure AD security in Azure Maps see the following [articles](https://aka.ms/amauthdetails) for guidance. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public ElevationClient(AzureKeyCredential credential, Geography? geography = default, string xMsClientId = null, ElevationClientOptions options = null)
        {
            if (credential == null)
            {
                throw new ArgumentNullException(nameof(credential));
            }
            geography ??= Geography.Us;

            options ??= new ElevationClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            _pipeline = HttpPipelineBuilder.Build(options, new AzureKeyCredentialPolicy(credential, "subscription-key"));
            RestClient = new ElevationRestClient(_clientDiagnostics, _pipeline, geography, xMsClientId, options.Version);
        }

        /// <summary> Initializes a new instance of ElevationClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="geography"> This parameter specifies where the Azure Maps Creator resource is located.  Valid values are us and eu. </param>
        /// <param name="xMsClientId"> Specifies which account is intended for usage in conjunction with the Azure AD security model.  It represents a unique ID for the Azure Maps account and can be retrieved from the Azure Maps management  plane Account API. To use Azure AD security in Azure Maps see the following [articles](https://aka.ms/amauthdetails) for guidance. </param>
        /// <param name="apiVersion"> Api Version. </param>
        internal ElevationClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Geography? geography = default, string xMsClientId = null, string apiVersion = "1.0")
        {
            RestClient = new ElevationRestClient(clientDiagnostics, pipeline, geography, xMsClientId, apiVersion);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary>
        /// **Applies to**: S1 pricing tier.
        /// 
        /// The Get Data for Points API provides elevation data for one or more points.  A point is defined in lat,long coordinate format.
        /// 
        ///  Due to the URL character  length limit of 2048, it&apos;s not possible to pass more than 100 coordinates  as a pipeline delimited string in a URL GET request. If you intend to pass  more than 100 coordinates as a pipeline delimited string, use the [POST Data
        ///  For Points](https://docs.microsoft.com/en-us/rest/api/maps/elevation/postdataforpoints).
        /// </summary>
        /// <param name="format"> Desired format of the response. Only `json` format is supported. </param>
        /// <param name="points"> The string representation of a list of points. A point is defined in lon/lat WGS84 coordinate reference system format.  If multiple points are requested, each of the points in a list should be separated by the pipe (&apos;|&apos;) character.  The maximum number of points that can be requested in a single request is 2,000. The resolution of the elevation  data will be the highest for a single point and will decrease if multiple points are spread further apart. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<PointsResult>> GetDataForPointsAsync(ResponseFormat format, IEnumerable<string> points, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ElevationClient.GetDataForPoints");
            scope.Start();
            try
            {
                return await RestClient.GetDataForPointsAsync(format, points, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// **Applies to**: S1 pricing tier.
        /// 
        /// The Get Data for Points API provides elevation data for one or more points.  A point is defined in lat,long coordinate format.
        /// 
        ///  Due to the URL character  length limit of 2048, it&apos;s not possible to pass more than 100 coordinates  as a pipeline delimited string in a URL GET request. If you intend to pass  more than 100 coordinates as a pipeline delimited string, use the [POST Data
        ///  For Points](https://docs.microsoft.com/en-us/rest/api/maps/elevation/postdataforpoints).
        /// </summary>
        /// <param name="format"> Desired format of the response. Only `json` format is supported. </param>
        /// <param name="points"> The string representation of a list of points. A point is defined in lon/lat WGS84 coordinate reference system format.  If multiple points are requested, each of the points in a list should be separated by the pipe (&apos;|&apos;) character.  The maximum number of points that can be requested in a single request is 2,000. The resolution of the elevation  data will be the highest for a single point and will decrease if multiple points are spread further apart. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PointsResult> GetDataForPoints(ResponseFormat format, IEnumerable<string> points, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ElevationClient.GetDataForPoints");
            scope.Start();
            try
            {
                return RestClient.GetDataForPoints(format, points, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// **Applies to**: S1 pricing tier.
        /// 
        /// The Post Data for Points API provides elevation data for multiple points.  A point is defined lon/lat coordinate format. Use the POST endpoint only  if you intend to pass multiple points in the request. If you intend to pass  a single coordinate into the API, use the [GET Data For Points API](https://docs.microsoft.com/en-us/rest/api/maps/elevation/getdataforpoints).
        /// </summary>
        /// <param name="format"> Desired format of the response. Only `json` format is supported. </param>
        /// <param name="pointsRequestBody"> The string representation of a list of points. A point is defined in lon/lat WGS84 coordinate reference system format.  Each points in a list should be separated by the pipe (&apos;|&apos;) character. The number of points that can be requested in  a POST request ranges from 2 to 2,000. The resolution of the elevation data will be the highest for a single point  and will decrease if multiple points are spread further apart. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<PointsResult>> PostDataForPointsAsync(ResponseFormat format, IEnumerable<CoordinatesPairAbbreviated> pointsRequestBody, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ElevationClient.PostDataForPoints");
            scope.Start();
            try
            {
                return await RestClient.PostDataForPointsAsync(format, pointsRequestBody, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// **Applies to**: S1 pricing tier.
        /// 
        /// The Post Data for Points API provides elevation data for multiple points.  A point is defined lon/lat coordinate format. Use the POST endpoint only  if you intend to pass multiple points in the request. If you intend to pass  a single coordinate into the API, use the [GET Data For Points API](https://docs.microsoft.com/en-us/rest/api/maps/elevation/getdataforpoints).
        /// </summary>
        /// <param name="format"> Desired format of the response. Only `json` format is supported. </param>
        /// <param name="pointsRequestBody"> The string representation of a list of points. A point is defined in lon/lat WGS84 coordinate reference system format.  Each points in a list should be separated by the pipe (&apos;|&apos;) character. The number of points that can be requested in  a POST request ranges from 2 to 2,000. The resolution of the elevation data will be the highest for a single point  and will decrease if multiple points are spread further apart. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PointsResult> PostDataForPoints(ResponseFormat format, IEnumerable<CoordinatesPairAbbreviated> pointsRequestBody, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ElevationClient.PostDataForPoints");
            scope.Start();
            try
            {
                return RestClient.PostDataForPoints(format, pointsRequestBody, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// **Applies to**: S1 pricing tier.
        /// 
        /// The Get Data for Polyline API provides elevation data along a polyline.
        /// 
        ///  A polyline is defined by  passing in between 2 and N endpoint coordinates separated by a pipe (&apos;|&apos;) character. In addition  to passing in endpoints, customers can specify the number of sample points that will be used to divide  polyline into equally spaced segments. Elevation data at both start and endpoints and equally spaced  points along the polyline will be returned.
        /// 
        ///  A line between two endpoints is a straight Cartesian line, the  shortest line between those two points in the coordinate reference system. Note that the point is  chosen based on Euclidean distance and may markedly differ from the geodesic path along the curved  surface of the reference ellipsoid.
        /// </summary>
        /// <param name="format"> Desired format of the response. Only `json` format is supported. </param>
        /// <param name="lines">
        /// The string representation of a polyline path. A polyline is defined by endpoint coordinates,  with each endpoint separated by a pipe (&apos;|&apos;) character. The polyline should be defined in the  following format: `[longitude_point1, latitude_point1 | longitude_point2, latitude_point2, ...,  longitude_pointN, latitude_pointN]`.
        /// 
        ///  The longitude and latitude values refer to the World Geodetic  System (WGS84) coordinate reference system. The resolution of the data used to compute the  elevation depends on the distance between the endpoints.
        /// </param>
        /// <param name="samples"> The samples parameter specifies the number of equally spaced points at which elevation values  should be provided along a polyline path. The number of samples should range from 2 to 2,000. Default value is 10. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<LinesResult>> GetDataForPolylineAsync(ResponseFormat format, IEnumerable<string> lines, int? samples = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ElevationClient.GetDataForPolyline");
            scope.Start();
            try
            {
                return await RestClient.GetDataForPolylineAsync(format, lines, samples, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// **Applies to**: S1 pricing tier.
        /// 
        /// The Get Data for Polyline API provides elevation data along a polyline.
        /// 
        ///  A polyline is defined by  passing in between 2 and N endpoint coordinates separated by a pipe (&apos;|&apos;) character. In addition  to passing in endpoints, customers can specify the number of sample points that will be used to divide  polyline into equally spaced segments. Elevation data at both start and endpoints and equally spaced  points along the polyline will be returned.
        /// 
        ///  A line between two endpoints is a straight Cartesian line, the  shortest line between those two points in the coordinate reference system. Note that the point is  chosen based on Euclidean distance and may markedly differ from the geodesic path along the curved  surface of the reference ellipsoid.
        /// </summary>
        /// <param name="format"> Desired format of the response. Only `json` format is supported. </param>
        /// <param name="lines">
        /// The string representation of a polyline path. A polyline is defined by endpoint coordinates,  with each endpoint separated by a pipe (&apos;|&apos;) character. The polyline should be defined in the  following format: `[longitude_point1, latitude_point1 | longitude_point2, latitude_point2, ...,  longitude_pointN, latitude_pointN]`.
        /// 
        ///  The longitude and latitude values refer to the World Geodetic  System (WGS84) coordinate reference system. The resolution of the data used to compute the  elevation depends on the distance between the endpoints.
        /// </param>
        /// <param name="samples"> The samples parameter specifies the number of equally spaced points at which elevation values  should be provided along a polyline path. The number of samples should range from 2 to 2,000. Default value is 10. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<LinesResult> GetDataForPolyline(ResponseFormat format, IEnumerable<string> lines, int? samples = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ElevationClient.GetDataForPolyline");
            scope.Start();
            try
            {
                return RestClient.GetDataForPolyline(format, lines, samples, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// **Applies to**: S1 pricing tier.
        /// 
        ///  The Post Data for Polyline API provides elevation data along a polyline. A polyline is defined by  passing in between 2 and N endpoint coordinates separated by a pipe (&apos;|&apos;) character. In addition  to passing in endpoints, customers can specify the number of sample points that will be used to divide  polyline into equally spaced segments.
        /// 
        ///  Elevation data at both start and end points and equally spaced  points along the polyline will be returned. A line between two endpoints is a straight Cartesian line, the  shortest line between those two points in the coordinate reference system. Note that the point is  chosen based on Euclidean distance and may markedly differ from the geodesic path along the curved  surface of the reference ellipsoid.
        /// </summary>
        /// <param name="format"> Desired format of the response. Only `json` format is supported. </param>
        /// <param name="linesRequestBody"> The string representation of a polyline path. A polyline is defined by endpoint coordinates,  with each endpoint separated by a pipe (&apos;|&apos;) character. The polyline should be defined in the  following format: `[longitude_point1, latitude_point1 | longitude_point2, latitude_point2, ...,  longitude_pointN, latitude_pointN]`. The longitude and latitude values refer to the World Geodetic  System (WGS84) coordinate reference system. The resolution of the data used to compute the  elevation will depend on the distance between the endpoints. </param>
        /// <param name="samples"> The samples parameter specifies the number of equally spaced points at which elevation values  should be provided along a polyline path. The number of samples should range from 2 to 2,000. Default value is 10. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<LinesResult>> PostDataForPolylineAsync(ResponseFormat format, IEnumerable<CoordinatesPairAbbreviated> linesRequestBody, int? samples = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ElevationClient.PostDataForPolyline");
            scope.Start();
            try
            {
                return await RestClient.PostDataForPolylineAsync(format, linesRequestBody, samples, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// **Applies to**: S1 pricing tier.
        /// 
        ///  The Post Data for Polyline API provides elevation data along a polyline. A polyline is defined by  passing in between 2 and N endpoint coordinates separated by a pipe (&apos;|&apos;) character. In addition  to passing in endpoints, customers can specify the number of sample points that will be used to divide  polyline into equally spaced segments.
        /// 
        ///  Elevation data at both start and end points and equally spaced  points along the polyline will be returned. A line between two endpoints is a straight Cartesian line, the  shortest line between those two points in the coordinate reference system. Note that the point is  chosen based on Euclidean distance and may markedly differ from the geodesic path along the curved  surface of the reference ellipsoid.
        /// </summary>
        /// <param name="format"> Desired format of the response. Only `json` format is supported. </param>
        /// <param name="linesRequestBody"> The string representation of a polyline path. A polyline is defined by endpoint coordinates,  with each endpoint separated by a pipe (&apos;|&apos;) character. The polyline should be defined in the  following format: `[longitude_point1, latitude_point1 | longitude_point2, latitude_point2, ...,  longitude_pointN, latitude_pointN]`. The longitude and latitude values refer to the World Geodetic  System (WGS84) coordinate reference system. The resolution of the data used to compute the  elevation will depend on the distance between the endpoints. </param>
        /// <param name="samples"> The samples parameter specifies the number of equally spaced points at which elevation values  should be provided along a polyline path. The number of samples should range from 2 to 2,000. Default value is 10. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<LinesResult> PostDataForPolyline(ResponseFormat format, IEnumerable<CoordinatesPairAbbreviated> linesRequestBody, int? samples = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ElevationClient.PostDataForPolyline");
            scope.Start();
            try
            {
                return RestClient.PostDataForPolyline(format, linesRequestBody, samples, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// **Applies to**: S1 pricing tier.
        /// 
        /// The Get Data for Bounding Box API provides elevation data at equally spaced locations within a bounding box. A bounding box is defined by the coordinates for two corners (southwest, northeast) and then subsequently  divided into rows and columns.
        /// 
        ///  Elevations are returned for the vertices of the grid created by the rows and  columns. Up to 2,000 elevations can be returned in a single request. The returned elevation values are ordered,  starting at the southwest corner, and then proceeding west to east along the row. At the end of the row,  it moves north to the next row, and repeats the process until it reaches the far northeast corner.
        /// </summary>
        /// <param name="format"> Desired format of the response. Only `json` format is supported. </param>
        /// <param name="bounds"> The string that represents the rectangular area of a bounding box. The bounds parameter is defined by the 4 bounding box coordinates, with WGS84 longitude and latitude of the southwest corner followed by  WGS84 longitude and latitude of the northeast corner. The string is presented in the following  format: `[SouthwestCorner_Longitude, SouthwestCorner_Latitude, NortheastCorner_Longitude,  NortheastCorner_Latitude]`. </param>
        /// <param name="rows"> Specifies the number of rows to use to divide the bounding box area into a grid. The number of vertices  in the grid should be less than 2,000. </param>
        /// <param name="columns"> Specifies the number of columns to use to divide the bounding box area into a grid. The number of vertices  in the grid should be less than 2,000. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<BoundingBoxResult>> GetDataForBoundingBoxAsync(ResponseFormat format, IEnumerable<string> bounds, int rows, int columns, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ElevationClient.GetDataForBoundingBox");
            scope.Start();
            try
            {
                return await RestClient.GetDataForBoundingBoxAsync(format, bounds, rows, columns, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// **Applies to**: S1 pricing tier.
        /// 
        /// The Get Data for Bounding Box API provides elevation data at equally spaced locations within a bounding box. A bounding box is defined by the coordinates for two corners (southwest, northeast) and then subsequently  divided into rows and columns.
        /// 
        ///  Elevations are returned for the vertices of the grid created by the rows and  columns. Up to 2,000 elevations can be returned in a single request. The returned elevation values are ordered,  starting at the southwest corner, and then proceeding west to east along the row. At the end of the row,  it moves north to the next row, and repeats the process until it reaches the far northeast corner.
        /// </summary>
        /// <param name="format"> Desired format of the response. Only `json` format is supported. </param>
        /// <param name="bounds"> The string that represents the rectangular area of a bounding box. The bounds parameter is defined by the 4 bounding box coordinates, with WGS84 longitude and latitude of the southwest corner followed by  WGS84 longitude and latitude of the northeast corner. The string is presented in the following  format: `[SouthwestCorner_Longitude, SouthwestCorner_Latitude, NortheastCorner_Longitude,  NortheastCorner_Latitude]`. </param>
        /// <param name="rows"> Specifies the number of rows to use to divide the bounding box area into a grid. The number of vertices  in the grid should be less than 2,000. </param>
        /// <param name="columns"> Specifies the number of columns to use to divide the bounding box area into a grid. The number of vertices  in the grid should be less than 2,000. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<BoundingBoxResult> GetDataForBoundingBox(ResponseFormat format, IEnumerable<string> bounds, int rows, int columns, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ElevationClient.GetDataForBoundingBox");
            scope.Start();
            try
            {
                return RestClient.GetDataForBoundingBox(format, bounds, rows, columns, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
