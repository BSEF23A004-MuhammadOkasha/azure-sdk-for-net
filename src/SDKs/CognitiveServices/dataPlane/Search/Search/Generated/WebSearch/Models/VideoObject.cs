// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Search.WebSearch.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Defines a video object that is relevant to the query.
    /// </summary>
    public partial class VideoObject : MediaObject
    {
        /// <summary>
        /// Initializes a new instance of the VideoObject class.
        /// </summary>
        public VideoObject()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VideoObject class.
        /// </summary>
        /// <param name="id">A String identifier.</param>
        /// <param name="webSearchUrl">The URL To Bing's search result for this
        /// item.</param>
        /// <param name="name">The name of the thing represented by this
        /// object.The name of the thing represented by this object.</param>
        /// <param name="url">The URL to get more information about the thing
        /// represented by this object.</param>
        /// <param name="description">A short description of the item.</param>
        /// <param name="bingId">An ID that uniquely identifies this
        /// item.</param>
        /// <param name="thumbnailUrl">The URL to a thumbnail of the
        /// item.</param>
        /// <param name="provider">The source of the creative work.</param>
        /// <param name="contentUrl">Original URL to retrieve the source (file)
        /// for the media object (e.g the source URL for the image).</param>
        /// <param name="hostPageUrl">URL of the page that hosts the media
        /// object.</param>
        /// <param name="width">The width of the source media object, in
        /// pixels.</param>
        /// <param name="height">The height of the source media object, in
        /// pixels.</param>
        public VideoObject(string id = default(string), string webSearchUrl = default(string), string name = default(string), string url = default(string), ImageObject image = default(ImageObject), string description = default(string), string bingId = default(string), string thumbnailUrl = default(string), IList<Thing> provider = default(IList<Thing>), string text = default(string), string contentUrl = default(string), string hostPageUrl = default(string), int? width = default(int?), int? height = default(int?), string motionThumbnailUrl = default(string), string motionThumbnailId = default(string), string embedHtml = default(string), bool? allowHttpsEmbed = default(bool?), int? viewCount = default(int?), ImageObject thumbnail = default(ImageObject), string videoId = default(string), bool? allowMobileEmbed = default(bool?), bool? isSuperfresh = default(bool?))
            : base(id, webSearchUrl, name, url, image, description, bingId, thumbnailUrl, provider, text, contentUrl, hostPageUrl, width, height)
        {
            MotionThumbnailUrl = motionThumbnailUrl;
            MotionThumbnailId = motionThumbnailId;
            EmbedHtml = embedHtml;
            AllowHttpsEmbed = allowHttpsEmbed;
            ViewCount = viewCount;
            Thumbnail = thumbnail;
            VideoId = videoId;
            AllowMobileEmbed = allowMobileEmbed;
            IsSuperfresh = isSuperfresh;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "motionThumbnailUrl")]
        public string MotionThumbnailUrl { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "motionThumbnailId")]
        public string MotionThumbnailId { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "embedHtml")]
        public string EmbedHtml { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "allowHttpsEmbed")]
        public bool? AllowHttpsEmbed { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "viewCount")]
        public int? ViewCount { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "thumbnail")]
        public ImageObject Thumbnail { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "videoId")]
        public string VideoId { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "allowMobileEmbed")]
        public bool? AllowMobileEmbed { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isSuperfresh")]
        public bool? IsSuperfresh { get; private set; }

    }
}
