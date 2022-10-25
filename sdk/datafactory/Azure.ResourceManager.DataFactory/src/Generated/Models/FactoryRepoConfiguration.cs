// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary>
    /// Factory&apos;s git repo information.
    /// Please note <see cref="FactoryRepoConfiguration"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="FactoryGitHubConfiguration"/> and <see cref="FactoryVstsConfiguration"/>.
    /// </summary>
    public abstract partial class FactoryRepoConfiguration
    {
        /// <summary> Initializes a new instance of FactoryRepoConfiguration. </summary>
        /// <param name="accountName"> Account name. </param>
        /// <param name="repositoryName"> Repository name. </param>
        /// <param name="collaborationBranch"> Collaboration branch. </param>
        /// <param name="rootFolder"> Root folder. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/>, <paramref name="repositoryName"/>, <paramref name="collaborationBranch"/> or <paramref name="rootFolder"/> is null. </exception>
        protected FactoryRepoConfiguration(string accountName, string repositoryName, string collaborationBranch, string rootFolder)
        {
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }
            if (repositoryName == null)
            {
                throw new ArgumentNullException(nameof(repositoryName));
            }
            if (collaborationBranch == null)
            {
                throw new ArgumentNullException(nameof(collaborationBranch));
            }
            if (rootFolder == null)
            {
                throw new ArgumentNullException(nameof(rootFolder));
            }

            AccountName = accountName;
            RepositoryName = repositoryName;
            CollaborationBranch = collaborationBranch;
            RootFolder = rootFolder;
        }

        /// <summary> Initializes a new instance of FactoryRepoConfiguration. </summary>
        /// <param name="factoryRepoConfigurationType"> Type of repo configuration. </param>
        /// <param name="accountName"> Account name. </param>
        /// <param name="repositoryName"> Repository name. </param>
        /// <param name="collaborationBranch"> Collaboration branch. </param>
        /// <param name="rootFolder"> Root folder. </param>
        /// <param name="lastCommitId"> Last commit id. </param>
        internal FactoryRepoConfiguration(string factoryRepoConfigurationType, string accountName, string repositoryName, string collaborationBranch, string rootFolder, string lastCommitId)
        {
            FactoryRepoConfigurationType = factoryRepoConfigurationType;
            AccountName = accountName;
            RepositoryName = repositoryName;
            CollaborationBranch = collaborationBranch;
            RootFolder = rootFolder;
            LastCommitId = lastCommitId;
        }

        /// <summary> Type of repo configuration. </summary>
        internal string FactoryRepoConfigurationType { get; set; }
        /// <summary> Account name. </summary>
        public string AccountName { get; set; }
        /// <summary> Repository name. </summary>
        public string RepositoryName { get; set; }
        /// <summary> Collaboration branch. </summary>
        public string CollaborationBranch { get; set; }
        /// <summary> Root folder. </summary>
        public string RootFolder { get; set; }
        /// <summary> Last commit id. </summary>
        public string LastCommitId { get; set; }
    }
}
