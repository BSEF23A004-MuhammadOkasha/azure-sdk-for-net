// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Migrate.Models
{
    /// <summary> Defines the dependency of the move resource. </summary>
    public partial class MoveResourceDependency
    {
        /// <summary> Initializes a new instance of MoveResourceDependency. </summary>
        internal MoveResourceDependency()
        {
        }

        /// <summary> Initializes a new instance of MoveResourceDependency. </summary>
        /// <param name="id"> Gets the source ARM ID of the dependent resource. </param>
        /// <param name="resolutionStatus"> Gets the dependency resolution status. </param>
        /// <param name="resolutionType"> Defines the resolution type. </param>
        /// <param name="dependencyType"> Defines the dependency type. </param>
        /// <param name="manualResolution"> Defines the properties for manual resolution. </param>
        /// <param name="automaticResolution"> Defines the properties for automatic resolution. </param>
        /// <param name="isOptional"> Gets or sets a value indicating whether the dependency is optional. </param>
        internal MoveResourceDependency(string id, string resolutionStatus, ResolutionType? resolutionType, DependencyType? dependencyType, ManualResolutionProperties manualResolution, AutomaticResolutionProperties automaticResolution, string isOptional)
        {
            Id = id;
            ResolutionStatus = resolutionStatus;
            ResolutionType = resolutionType;
            DependencyType = dependencyType;
            ManualResolution = manualResolution;
            AutomaticResolution = automaticResolution;
            IsOptional = isOptional;
        }

        /// <summary> Gets the source ARM ID of the dependent resource. </summary>
        public string Id { get; }
        /// <summary> Gets the dependency resolution status. </summary>
        public string ResolutionStatus { get; }
        /// <summary> Defines the resolution type. </summary>
        public ResolutionType? ResolutionType { get; }
        /// <summary> Defines the dependency type. </summary>
        public DependencyType? DependencyType { get; }
        /// <summary> Defines the properties for manual resolution. </summary>
        internal ManualResolutionProperties ManualResolution { get; }
        /// <summary> Gets or sets the target resource ARM ID of the dependent resource if the resource type is Manual. </summary>
        public string ManualResolutionTargetId
        {
            get => ManualResolution?.TargetId;
        }

        /// <summary> Defines the properties for automatic resolution. </summary>
        internal AutomaticResolutionProperties AutomaticResolution { get; }
        /// <summary>
        /// Gets the MoveResource ARM ID of
        /// the dependent resource if the resolution type is Automatic.
        /// </summary>
        public string AutomaticResolutionMoveResourceId
        {
            get => AutomaticResolution?.MoveResourceId;
        }

        /// <summary> Gets or sets a value indicating whether the dependency is optional. </summary>
        public string IsOptional { get; }
    }
}
