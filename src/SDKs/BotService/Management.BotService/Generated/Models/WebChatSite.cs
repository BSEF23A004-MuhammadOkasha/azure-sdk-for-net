// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.BotService.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A site for the Webchat channel
    /// </summary>
    public partial class WebChatSite
    {
        /// <summary>
        /// Initializes a new instance of the WebChatSite class.
        /// </summary>
        public WebChatSite()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WebChatSite class.
        /// </summary>
        /// <param name="siteName">Site name</param>
        /// <param name="isEnabled">Whether this site is enabled for DirectLine
        /// channel</param>
        /// <param name="enablePreview">Whether this site is enabled for
        /// preview versions of Webchat</param>
        /// <param name="siteId">Site Id</param>
        /// <param name="key">Primary key. Value only returned through POST to
        /// the action Channel List API, otherwise empty.</param>
        /// <param name="key2">Secondary key. Value only returned through POST
        /// to the action Channel List API, otherwise empty.</param>
        public WebChatSite(string siteName, bool isEnabled, bool enablePreview, string siteId = default(string), string key = default(string), string key2 = default(string))
        {
            SiteId = siteId;
            SiteName = siteName;
            Key = key;
            Key2 = key2;
            IsEnabled = isEnabled;
            EnablePreview = enablePreview;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets site Id
        /// </summary>
        [JsonProperty(PropertyName = "siteId")]
        public string SiteId { get; private set; }

        /// <summary>
        /// Gets or sets site name
        /// </summary>
        [JsonProperty(PropertyName = "siteName")]
        public string SiteName { get; set; }

        /// <summary>
        /// Gets primary key. Value only returned through POST to the action
        /// Channel List API, otherwise empty.
        /// </summary>
        [JsonProperty(PropertyName = "key")]
        public string Key { get; private set; }

        /// <summary>
        /// Gets secondary key. Value only returned through POST to the action
        /// Channel List API, otherwise empty.
        /// </summary>
        [JsonProperty(PropertyName = "key2")]
        public string Key2 { get; private set; }

        /// <summary>
        /// Gets or sets whether this site is enabled for DirectLine channel
        /// </summary>
        [JsonProperty(PropertyName = "isEnabled")]
        public bool IsEnabled { get; set; }

        /// <summary>
        /// Gets or sets whether this site is enabled for preview versions of
        /// Webchat
        /// </summary>
        [JsonProperty(PropertyName = "enablePreview")]
        public bool EnablePreview { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (SiteName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SiteName");
            }
        }
    }
}
