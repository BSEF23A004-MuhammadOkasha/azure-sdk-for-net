// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.MixedReality.RemoteRendering
{
    /// <summary> Conversion input settings describe the origin of conversion input. </summary>
    public partial class AssetConversionInputOptions
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AssetConversionInputOptions"/>. </summary>
        /// <param name="storageContainerUri"> The URI of the Azure blob storage container containing the input model. </param>
        /// <param name="relativeInputAssetPath"> The relative path starting at blobPrefix (or at the container root if blobPrefix is not provided) to the input model. Must point to a file with a supported file format ending. See https://docs.microsoft.com/azure/remote-rendering/how-tos/conversion/model-conversion for details. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="storageContainerUri"/> or <paramref name="relativeInputAssetPath"/> is null. </exception>
        public AssetConversionInputOptions(Uri storageContainerUri, string relativeInputAssetPath)
        {
            Argument.AssertNotNull(storageContainerUri, nameof(storageContainerUri));
            Argument.AssertNotNull(relativeInputAssetPath, nameof(relativeInputAssetPath));

            StorageContainerUri = storageContainerUri;
            RelativeInputAssetPath = relativeInputAssetPath;
        }

        /// <summary> Initializes a new instance of <see cref="AssetConversionInputOptions"/>. </summary>
        /// <param name="storageContainerUri"> The URI of the Azure blob storage container containing the input model. </param>
        /// <param name="storageContainerReadListSas"> An Azure blob storage container shared access signature giving read and list access to the storage container. Optional. If not provided, the Azure Remote Rendering account needs to be linked with the storage account containing the blob container. See https://docs.microsoft.com/azure/remote-rendering/how-tos/create-an-account#link-storage-accounts for details. For security purposes this field will never be filled out in responses bodies. </param>
        /// <param name="blobPrefix"> Only Blobs starting with this prefix will be downloaded to perform the conversion. Optional. If not provided, all Blobs from the container will be downloaded. </param>
        /// <param name="relativeInputAssetPath"> The relative path starting at blobPrefix (or at the container root if blobPrefix is not provided) to the input model. Must point to a file with a supported file format ending. See https://docs.microsoft.com/azure/remote-rendering/how-tos/conversion/model-conversion for details. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AssetConversionInputOptions(Uri storageContainerUri, string storageContainerReadListSas, string blobPrefix, string relativeInputAssetPath, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            StorageContainerUri = storageContainerUri;
            StorageContainerReadListSas = storageContainerReadListSas;
            BlobPrefix = blobPrefix;
            RelativeInputAssetPath = relativeInputAssetPath;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AssetConversionInputOptions"/> for deserialization. </summary>
        internal AssetConversionInputOptions()
        {
        }
        /// <summary> An Azure blob storage container shared access signature giving read and list access to the storage container. Optional. If not provided, the Azure Remote Rendering account needs to be linked with the storage account containing the blob container. See https://docs.microsoft.com/azure/remote-rendering/how-tos/create-an-account#link-storage-accounts for details. For security purposes this field will never be filled out in responses bodies. </summary>
        public string StorageContainerReadListSas { get; set; }
        /// <summary> Only Blobs starting with this prefix will be downloaded to perform the conversion. Optional. If not provided, all Blobs from the container will be downloaded. </summary>
        public string BlobPrefix { get; set; }
    }
}
