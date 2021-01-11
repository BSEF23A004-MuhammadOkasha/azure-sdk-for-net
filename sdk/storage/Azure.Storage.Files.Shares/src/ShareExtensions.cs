﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using Azure.Storage.Files.Shares.Models;

namespace Azure.Storage.Files.Shares
{
    internal static partial class ShareExtensions
    {
        internal static void AssertValidFilePermissionAndKey(string filePermission, string filePermissionKey)
        {
            if (filePermission != null && filePermissionKey != null)
            {
                throw Errors.CannotBothBeNotNull(nameof(filePermission), nameof(filePermissionKey));
            }

            if (filePermission != null && Encoding.UTF8.GetByteCount(filePermission) > Constants.File.MaxFilePermissionHeaderSize)
            {
                throw Errors.MustBeLessThanOrEqualTo(nameof(filePermission), Constants.File.MaxFilePermissionHeaderSize);
            }
        }

        // TODO fix this.
        //internal static Response<ShareFileLease> ToLease(this Response<BrokenLease> response)
        //    => Response.FromValue(
        //        new ShareFileLease
        //        {
        //            ETag = response.Value.ETag,
        //            LastModified = response.Value.LastModified,
        //            LeaseId = response.Value.LeaseId,
        //            LeaseTime = response.Value.LeaseTime
        //        }, response.GetRawResponse());

        internal static string ToFileDateTimeString(this DateTimeOffset? dateTimeOffset)
            => dateTimeOffset.HasValue ? ToFileDateTimeString(dateTimeOffset.Value) : null;

        private static string ToFileDateTimeString(this DateTimeOffset dateTimeOffset)
            => dateTimeOffset.UtcDateTime.ToString(Constants.File.FileTimeFormat, CultureInfo.InvariantCulture);

        internal static string ToShareEnableProtocolsString(this ShareProtocols? shareEnabledProtocols)
        {
            if (shareEnabledProtocols == null)
            {
                return null;
            }

            return shareEnabledProtocols switch
                {
                    ShareProtocols.Smb => Constants.File.SmbProtocol,
                    ShareProtocols.Nfs => Constants.File.NfsProtocol,
                    _ => throw new ArgumentException($"Unknown share protocol: {shareEnabledProtocols}"),
                };
        }

        internal static DeleteSnapshotsOptionType? ToShareSnapshotsDeleteOptionInternal(this ShareSnapshotsDeleteOption? option)
        {
            if (option == null)
            {
                return null;
            }
            return option switch
            {
                ShareSnapshotsDeleteOption.Include => DeleteSnapshotsOptionType.Include,
                ShareSnapshotsDeleteOption.IncludeWithLeased => DeleteSnapshotsOptionType.IncludeLeased,
                _ => throw new ArgumentException($"Invalid {nameof(ShareSnapshotsDeleteOption)}: {option}"),
            };
        }

        internal static ShareProtocols? ToShareEnabledProtocols(string rawProtocols)
        {
            if (rawProtocols == null)
            {
                return null;
            }

            string[] split = rawProtocols.Split(',');

            int result = 0;

            foreach (string s in split)
            {
                switch (s)
                {
                    case Constants.File.SmbProtocol:
                        result |= (int)ShareProtocols.Smb;
                        break;
                    case Constants.File.NfsProtocol:
                        result |= (int)ShareProtocols.Nfs;
                        break;
                }
            }

            if (result == 0)
            {
                return null;
            }

            return (ShareProtocols)result;
        }

        // TODO
        internal static ShareDirectoryInfo ToShareDirectoryInfo(this DirectoryCreateHeaders directoryCreateHeaders)
        {
            return null;
        }

        // TODO
        internal static ShareDirectoryProperties ToShareDirectoryProperties(this DirectoryGetPropertiesHeaders directoryGetPropertiesHeaders)
        {
            return null;
        }

        // TODO
        internal static ShareDirectoryInfo ToShareDirectoryInfo(this DirectorySetPropertiesHeaders directorySetPropertiesHeaders)
        {
            return null;
        }

        // TODO
        internal static ShareDirectoryInfo ToShareDirectoryInfo(this DirectorySetMetadataHeaders directorySetMetadataHeaders)
        {
            return null;
        }

        // TODO
        internal static StorageHandlesSegment ToStorageHandlesSegment(this ListHandlesResponse listHandlesResponse)
        {
            return null;
        }

        // TODO
        internal static StorageClosedHandlesSegment ToStorageClosedHandlesSegment(this DirectoryForceCloseHandlesHeaders directoryForceCloseHandlesHeaders)
        {
            return null;
        }

        // TODO
        internal static ShareFileInfo ToShareFileInfo(this FileCreateHeaders fileCreateHeaders)
        {
            return null;
        }

        // TODO
        internal static ShareFileCopyInfo ToShareFileCopyInfo(this FileStartCopyHeaders fileStartCopyHeaders)
        {
            return null;
        }

        // TODO
        internal static ShareFileProperties ToShareFileProperties(this FileGetPropertiesHeaders fileGetPropertiesHeaders)
        {
            return null;
        }

        // TODO
        internal static ShareFileInfo ToShareFileInfo(this FileSetHttpHeadersHeaders fileSetHttpHeadersHeaders)
        {
            return null;
        }

        // TODO
        internal static ShareFileInfo ToShareFileInfo(this FileSetMetadataHeaders fileSetMetadataHeaders)
        {
            return null;
        }

        // TODOs
        internal static ShareFileUploadInfo ToShareFileUploadInfo(this FileUploadRangeHeaders fileUploadRangeHeaders)
        {
            return null;
        }

        // TODO
        internal static ShareFileUploadInfo ToShareFileUploadInfo(this FileUploadRangeFromURLHeaders fileUploadRangeFromURLHeaders)
        {
            return null;
        }

        // TODO
        internal static ShareFileRangeInfo ToShareFileRangeInfo(this ShareFileRangeList shareFileRangeList)
        {
            return null;
        }

        // TODO
        internal static StorageClosedHandlesSegment ToStorageClosedHandlesSegment(this FileForceCloseHandlesHeaders fileForceCloseHandlesHeaders)
        {
            return null;
        }

        // TODO
        internal static ShareFileLease ToShareFileLease(this FileAcquireLeaseHeaders fileAcquireLeaseHeaders)
        {
            return null;
        }

        // TODO
        internal static ShareFileLease ToShareFileLease(this ShareAcquireLeaseHeaders shareAcquireLeaseHeaders)
        {
            return null;
        }

        // TODO
        internal static FileLeaseReleaseInfo ToFileLeaseReleaseInfo(this FileReleaseLeaseHeaders fileReleaseLeaseHeaders)
        {
            return null;
        }

        // TODO
        internal static FileLeaseReleaseInfo ToFileLeaseReleaseInfo(this ShareReleaseLeaseHeaders shareReleaseLeaseHeaders)
        {
            return null;
        }

        // TODO
        internal static ShareFileLease ToShareFileLease(this FileChangeLeaseHeaders fileChangeLeaseHeaders)
        {
            return null;
        }

        // TODO
        internal static ShareFileLease ToShareFileLease(this ShareChangeLeaseHeaders shareChangeLeaseHeaders)
        {
            return null;
        }

        // TODO
        internal static ShareFileLease ToShareFileLease(this FileBreakLeaseHeaders fileBreakLeaseHeaders)
        {
            return null;
        }

        // TODO
        internal static ShareFileLease ToShareFileLease(this ShareBreakLeaseHeaders fileBreakLeaseHeaders)
        {
            return null;
        }

        // TODO
        internal static ShareFileLease ToShareFileLease(this FileReleaseLeaseHeaders fileReleaseLeaseHeaders)
        {
            return null;
        }

        // TODO
        internal static ShareInfo ToShareInfo(this ShareCreateHeaders shareCreateHeaders)
        {
            return null;
        }

        // TODO
        internal static ShareSnapshotInfo ToShareSnapshotInfo(this ShareCreateSnapshotHeaders shareCreateSnapshotHeaders)
        {
            return null;
        }

        // TODO
        internal static ShareProperties ToShareProperties(this ShareGetPropertiesHeaders shareGetPropertiesHeaders)
        {
            return null;
        }

        // TODO
        internal static ShareInfo ToShareInfo(this ShareSetPropertiesHeaders shareSetPropertiesHeaders)
        {
            return null;
        }

        // TODO
        internal static ShareInfo ToShareInfo(this ShareSetMetadataHeaders shareSetMetadataHeaders)
        {
            return null;
        }

        // TODO
        internal static ShareInfo ToShareInfo(this ShareSetAccessPolicyHeaders shareSetAccessPolicyHeaders)
        {
            return null;
        }

        // TODO
        internal static PermissionInfo ToPermissionInfo(this ShareCreatePermissionHeaders shareCreatePermissionHeaders)
        {
            return null;
        }

        // TODO
        internal static ShareItem[] ToShareItems(this IReadOnlyList<ShareItemInternal> shareItemInternals)
        {
            return null;
        }

        // TODO
        internal static ShareFileDownloadInfo ToShareFileDownloadInfo(this FileDownloadHeaders fileDownloadHeaders)
        {
            return null;
        }
    }
}
