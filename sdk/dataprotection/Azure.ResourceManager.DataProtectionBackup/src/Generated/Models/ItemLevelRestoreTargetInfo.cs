// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> Restore target info for Item level restore operation. </summary>
    public partial class ItemLevelRestoreTargetInfo : RestoreTargetInfoBase
    {
        /// <summary> Initializes a new instance of <see cref="ItemLevelRestoreTargetInfo"/>. </summary>
        /// <param name="recoverySetting"> Recovery Option. </param>
        /// <param name="restoreCriteria">
        /// Restore Criteria
        /// Please note <see cref="ItemLevelRestoreCriteria"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ItemPathBasedRestoreCriteria"/>, <see cref="KubernetesClusterRestoreCriteria"/>, <see cref="KubernetesPVRestoreCriteria"/>, <see cref="KubernetesStorageClassRestoreCriteria"/> and <see cref="RangeBasedItemLevelRestoreCriteria"/>.
        /// </param>
        /// <param name="datasourceInfo"> Information of target DS. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="restoreCriteria"/> or <paramref name="datasourceInfo"/> is null. </exception>
        public ItemLevelRestoreTargetInfo(RecoverySetting recoverySetting, IEnumerable<ItemLevelRestoreCriteria> restoreCriteria, DataSourceInfo datasourceInfo) : base(recoverySetting)
        {
            Argument.AssertNotNull(restoreCriteria, nameof(restoreCriteria));
            Argument.AssertNotNull(datasourceInfo, nameof(datasourceInfo));

            RestoreCriteria = restoreCriteria.ToList();
            DatasourceInfo = datasourceInfo;
            ObjectType = "ItemLevelRestoreTargetInfo";
        }

        /// <summary> Initializes a new instance of <see cref="ItemLevelRestoreTargetInfo"/>. </summary>
        /// <param name="objectType"> Type of Datasource object, used to initialize the right inherited type. </param>
        /// <param name="recoverySetting"> Recovery Option. </param>
        /// <param name="restoreLocation"> Target Restore region. </param>
        /// <param name="restoreCriteria">
        /// Restore Criteria
        /// Please note <see cref="ItemLevelRestoreCriteria"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ItemPathBasedRestoreCriteria"/>, <see cref="KubernetesClusterRestoreCriteria"/>, <see cref="KubernetesPVRestoreCriteria"/>, <see cref="KubernetesStorageClassRestoreCriteria"/> and <see cref="RangeBasedItemLevelRestoreCriteria"/>.
        /// </param>
        /// <param name="datasourceInfo"> Information of target DS. </param>
        /// <param name="datasourceSetInfo"> Information of target DS Set. </param>
        /// <param name="datasourceAuthCredentials">
        /// Credentials to use to authenticate with data source provider.
        /// Please note <see cref="DataProtectionBackupAuthCredentials"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SecretStoreBasedAuthCredentials"/>.
        /// </param>
        internal ItemLevelRestoreTargetInfo(string objectType, RecoverySetting recoverySetting, AzureLocation? restoreLocation, IList<ItemLevelRestoreCriteria> restoreCriteria, DataSourceInfo datasourceInfo, DataSourceSetInfo datasourceSetInfo, DataProtectionBackupAuthCredentials datasourceAuthCredentials) : base(objectType, recoverySetting, restoreLocation)
        {
            RestoreCriteria = restoreCriteria;
            DatasourceInfo = datasourceInfo;
            DatasourceSetInfo = datasourceSetInfo;
            DatasourceAuthCredentials = datasourceAuthCredentials;
            ObjectType = objectType ?? "ItemLevelRestoreTargetInfo";
        }

        /// <summary>
        /// Restore Criteria
        /// Please note <see cref="ItemLevelRestoreCriteria"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ItemPathBasedRestoreCriteria"/>, <see cref="KubernetesClusterRestoreCriteria"/>, <see cref="KubernetesPVRestoreCriteria"/>, <see cref="KubernetesStorageClassRestoreCriteria"/> and <see cref="RangeBasedItemLevelRestoreCriteria"/>.
        /// </summary>
        public IList<ItemLevelRestoreCriteria> RestoreCriteria { get; }
        /// <summary> Information of target DS. </summary>
        public DataSourceInfo DatasourceInfo { get; }
        /// <summary> Information of target DS Set. </summary>
        public DataSourceSetInfo DatasourceSetInfo { get; set; }
        /// <summary>
        /// Credentials to use to authenticate with data source provider.
        /// Please note <see cref="DataProtectionBackupAuthCredentials"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SecretStoreBasedAuthCredentials"/>.
        /// </summary>
        public DataProtectionBackupAuthCredentials DatasourceAuthCredentials { get; set; }
    }
}
