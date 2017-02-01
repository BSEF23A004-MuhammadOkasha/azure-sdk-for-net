// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

//
// This file was autogenerated by a tool.
// Do not modify it.
//

namespace Microsoft.Azure.Batch
{
    using Models = Microsoft.Azure.Batch.Protocol.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A pool in the Azure Batch service.
    /// </summary>
    public partial class CloudPool : ITransportObjectProvider<Models.PoolAddParameter>, IInheritedBehaviors, IPropertyMetadata
    {
        private class PropertyContainer : PropertyCollection
        {
            public readonly PropertyAccessor<Common.AllocationState?> AllocationStateProperty;
            public readonly PropertyAccessor<DateTime?> AllocationStateTransitionTimeProperty;
            public readonly PropertyAccessor<IList<ApplicationPackageReference>> ApplicationPackageReferencesProperty;
            public readonly PropertyAccessor<bool?> AutoScaleEnabledProperty;
            public readonly PropertyAccessor<TimeSpan?> AutoScaleEvaluationIntervalProperty;
            public readonly PropertyAccessor<string> AutoScaleFormulaProperty;
            public readonly PropertyAccessor<AutoScaleRun> AutoScaleRunProperty;
            public readonly PropertyAccessor<IList<CertificateReference>> CertificateReferencesProperty;
            public readonly PropertyAccessor<CloudServiceConfiguration> CloudServiceConfigurationProperty;
            public readonly PropertyAccessor<DateTime?> CreationTimeProperty;
            public readonly PropertyAccessor<int?> CurrentDedicatedProperty;
            public readonly PropertyAccessor<string> DisplayNameProperty;
            public readonly PropertyAccessor<string> ETagProperty;
            public readonly PropertyAccessor<string> IdProperty;
            public readonly PropertyAccessor<bool?> InterComputeNodeCommunicationEnabledProperty;
            public readonly PropertyAccessor<DateTime?> LastModifiedProperty;
            public readonly PropertyAccessor<int?> MaxTasksPerComputeNodeProperty;
            public readonly PropertyAccessor<IList<MetadataItem>> MetadataProperty;
            public readonly PropertyAccessor<NetworkConfiguration> NetworkConfigurationProperty;
            public readonly PropertyAccessor<ResizeError> ResizeErrorProperty;
            public readonly PropertyAccessor<TimeSpan?> ResizeTimeoutProperty;
            public readonly PropertyAccessor<StartTask> StartTaskProperty;
            public readonly PropertyAccessor<Common.PoolState?> StateProperty;
            public readonly PropertyAccessor<DateTime?> StateTransitionTimeProperty;
            public readonly PropertyAccessor<PoolStatistics> StatisticsProperty;
            public readonly PropertyAccessor<int?> TargetDedicatedProperty;
            public readonly PropertyAccessor<TaskSchedulingPolicy> TaskSchedulingPolicyProperty;
            public readonly PropertyAccessor<string> UrlProperty;
            public readonly PropertyAccessor<IList<UserAccount>> UserAccountsProperty;
            public readonly PropertyAccessor<VirtualMachineConfiguration> VirtualMachineConfigurationProperty;
            public readonly PropertyAccessor<string> VirtualMachineSizeProperty;

            public PropertyContainer() : base(BindingState.Unbound)
            {
                this.AllocationStateProperty = this.CreatePropertyAccessor<Common.AllocationState?>("AllocationState", BindingAccess.None);
                this.AllocationStateTransitionTimeProperty = this.CreatePropertyAccessor<DateTime?>("AllocationStateTransitionTime", BindingAccess.None);
                this.ApplicationPackageReferencesProperty = this.CreatePropertyAccessor<IList<ApplicationPackageReference>>("ApplicationPackageReferences", BindingAccess.Read | BindingAccess.Write);
                this.AutoScaleEnabledProperty = this.CreatePropertyAccessor<bool?>("AutoScaleEnabled", BindingAccess.Read | BindingAccess.Write);
                this.AutoScaleEvaluationIntervalProperty = this.CreatePropertyAccessor<TimeSpan?>("AutoScaleEvaluationInterval", BindingAccess.Read | BindingAccess.Write);
                this.AutoScaleFormulaProperty = this.CreatePropertyAccessor<string>("AutoScaleFormula", BindingAccess.Read | BindingAccess.Write);
                this.AutoScaleRunProperty = this.CreatePropertyAccessor<AutoScaleRun>("AutoScaleRun", BindingAccess.None);
                this.CertificateReferencesProperty = this.CreatePropertyAccessor<IList<CertificateReference>>("CertificateReferences", BindingAccess.Read | BindingAccess.Write);
                this.CloudServiceConfigurationProperty = this.CreatePropertyAccessor<CloudServiceConfiguration>("CloudServiceConfiguration", BindingAccess.Read | BindingAccess.Write);
                this.CreationTimeProperty = this.CreatePropertyAccessor<DateTime?>("CreationTime", BindingAccess.None);
                this.CurrentDedicatedProperty = this.CreatePropertyAccessor<int?>("CurrentDedicated", BindingAccess.None);
                this.DisplayNameProperty = this.CreatePropertyAccessor<string>("DisplayName", BindingAccess.Read | BindingAccess.Write);
                this.ETagProperty = this.CreatePropertyAccessor<string>("ETag", BindingAccess.None);
                this.IdProperty = this.CreatePropertyAccessor<string>("Id", BindingAccess.Read | BindingAccess.Write);
                this.InterComputeNodeCommunicationEnabledProperty = this.CreatePropertyAccessor<bool?>("InterComputeNodeCommunicationEnabled", BindingAccess.Read | BindingAccess.Write);
                this.LastModifiedProperty = this.CreatePropertyAccessor<DateTime?>("LastModified", BindingAccess.None);
                this.MaxTasksPerComputeNodeProperty = this.CreatePropertyAccessor<int?>("MaxTasksPerComputeNode", BindingAccess.Read | BindingAccess.Write);
                this.MetadataProperty = this.CreatePropertyAccessor<IList<MetadataItem>>("Metadata", BindingAccess.Read | BindingAccess.Write);
                this.NetworkConfigurationProperty = this.CreatePropertyAccessor<NetworkConfiguration>("NetworkConfiguration", BindingAccess.Read | BindingAccess.Write);
                this.ResizeErrorProperty = this.CreatePropertyAccessor<ResizeError>("ResizeError", BindingAccess.None);
                this.ResizeTimeoutProperty = this.CreatePropertyAccessor<TimeSpan?>("ResizeTimeout", BindingAccess.Read | BindingAccess.Write);
                this.StartTaskProperty = this.CreatePropertyAccessor<StartTask>("StartTask", BindingAccess.Read | BindingAccess.Write);
                this.StateProperty = this.CreatePropertyAccessor<Common.PoolState?>("State", BindingAccess.None);
                this.StateTransitionTimeProperty = this.CreatePropertyAccessor<DateTime?>("StateTransitionTime", BindingAccess.None);
                this.StatisticsProperty = this.CreatePropertyAccessor<PoolStatistics>("Statistics", BindingAccess.None);
                this.TargetDedicatedProperty = this.CreatePropertyAccessor<int?>("TargetDedicated", BindingAccess.Read | BindingAccess.Write);
                this.TaskSchedulingPolicyProperty = this.CreatePropertyAccessor<TaskSchedulingPolicy>("TaskSchedulingPolicy", BindingAccess.Read | BindingAccess.Write);
                this.UrlProperty = this.CreatePropertyAccessor<string>("Url", BindingAccess.None);
                this.UserAccountsProperty = this.CreatePropertyAccessor<IList<UserAccount>>("UserAccounts", BindingAccess.Read | BindingAccess.Write);
                this.VirtualMachineConfigurationProperty = this.CreatePropertyAccessor<VirtualMachineConfiguration>("VirtualMachineConfiguration", BindingAccess.Read | BindingAccess.Write);
                this.VirtualMachineSizeProperty = this.CreatePropertyAccessor<string>("VirtualMachineSize", BindingAccess.Read | BindingAccess.Write);
            }

            public PropertyContainer(Models.CloudPool protocolObject) : base(BindingState.Bound)
            {
                this.AllocationStateProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.MapNullableEnum<Models.AllocationState, Common.AllocationState>(protocolObject.AllocationState),
                    "AllocationState",
                    BindingAccess.Read);
                this.AllocationStateTransitionTimeProperty = this.CreatePropertyAccessor(
                    protocolObject.AllocationStateTransitionTime,
                    "AllocationStateTransitionTime",
                    BindingAccess.Read);
                this.ApplicationPackageReferencesProperty = this.CreatePropertyAccessor(
                    ApplicationPackageReference.ConvertFromProtocolCollection(protocolObject.ApplicationPackageReferences),
                    "ApplicationPackageReferences",
                    BindingAccess.Read | BindingAccess.Write);
                this.AutoScaleEnabledProperty = this.CreatePropertyAccessor(
                    protocolObject.EnableAutoScale,
                    "AutoScaleEnabled",
                    BindingAccess.Read);
                this.AutoScaleEvaluationIntervalProperty = this.CreatePropertyAccessor(
                    protocolObject.AutoScaleEvaluationInterval,
                    "AutoScaleEvaluationInterval",
                    BindingAccess.Read);
                this.AutoScaleFormulaProperty = this.CreatePropertyAccessor(
                    protocolObject.AutoScaleFormula,
                    "AutoScaleFormula",
                    BindingAccess.Read);
                this.AutoScaleRunProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.AutoScaleRun, o => new AutoScaleRun(o).Freeze()),
                    "AutoScaleRun",
                    BindingAccess.Read);
                this.CertificateReferencesProperty = this.CreatePropertyAccessor(
                    CertificateReference.ConvertFromProtocolCollection(protocolObject.CertificateReferences),
                    "CertificateReferences",
                    BindingAccess.Read | BindingAccess.Write);
                this.CloudServiceConfigurationProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.CloudServiceConfiguration, o => new CloudServiceConfiguration(o).Freeze()),
                    "CloudServiceConfiguration",
                    BindingAccess.Read);
                this.CreationTimeProperty = this.CreatePropertyAccessor(
                    protocolObject.CreationTime,
                    "CreationTime",
                    BindingAccess.Read);
                this.CurrentDedicatedProperty = this.CreatePropertyAccessor(
                    protocolObject.CurrentDedicated,
                    "CurrentDedicated",
                    BindingAccess.Read);
                this.DisplayNameProperty = this.CreatePropertyAccessor(
                    protocolObject.DisplayName,
                    "DisplayName",
                    BindingAccess.Read);
                this.ETagProperty = this.CreatePropertyAccessor(
                    protocolObject.ETag,
                    "ETag",
                    BindingAccess.Read);
                this.IdProperty = this.CreatePropertyAccessor(
                    protocolObject.Id,
                    "Id",
                    BindingAccess.Read);
                this.InterComputeNodeCommunicationEnabledProperty = this.CreatePropertyAccessor(
                    protocolObject.EnableInterNodeCommunication,
                    "InterComputeNodeCommunicationEnabled",
                    BindingAccess.Read);
                this.LastModifiedProperty = this.CreatePropertyAccessor(
                    protocolObject.LastModified,
                    "LastModified",
                    BindingAccess.Read);
                this.MaxTasksPerComputeNodeProperty = this.CreatePropertyAccessor(
                    protocolObject.MaxTasksPerNode,
                    "MaxTasksPerComputeNode",
                    BindingAccess.Read);
                this.MetadataProperty = this.CreatePropertyAccessor(
                    MetadataItem.ConvertFromProtocolCollection(protocolObject.Metadata),
                    "Metadata",
                    BindingAccess.Read | BindingAccess.Write);
                this.NetworkConfigurationProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.NetworkConfiguration, o => new NetworkConfiguration(o).Freeze()),
                    "NetworkConfiguration",
                    BindingAccess.Read);
                this.ResizeErrorProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.ResizeError, o => new ResizeError(o).Freeze()),
                    "ResizeError",
                    BindingAccess.Read);
                this.ResizeTimeoutProperty = this.CreatePropertyAccessor(
                    protocolObject.ResizeTimeout,
                    "ResizeTimeout",
                    BindingAccess.Read);
                this.StartTaskProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.StartTask, o => new StartTask(o)),
                    "StartTask",
                    BindingAccess.Read | BindingAccess.Write);
                this.StateProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.MapNullableEnum<Models.PoolState, Common.PoolState>(protocolObject.State),
                    "State",
                    BindingAccess.Read);
                this.StateTransitionTimeProperty = this.CreatePropertyAccessor(
                    protocolObject.StateTransitionTime,
                    "StateTransitionTime",
                    BindingAccess.Read);
                this.StatisticsProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.Stats, o => new PoolStatistics(o).Freeze()),
                    "Statistics",
                    BindingAccess.Read);
                this.TargetDedicatedProperty = this.CreatePropertyAccessor(
                    protocolObject.TargetDedicated,
                    "TargetDedicated",
                    BindingAccess.Read);
                this.TaskSchedulingPolicyProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.TaskSchedulingPolicy, o => new TaskSchedulingPolicy(o).Freeze()),
                    "TaskSchedulingPolicy",
                    BindingAccess.Read);
                this.UrlProperty = this.CreatePropertyAccessor(
                    protocolObject.Url,
                    "Url",
                    BindingAccess.Read);
                this.UserAccountsProperty = this.CreatePropertyAccessor(
                    UserAccount.ConvertFromProtocolCollectionAndFreeze(protocolObject.UserAccounts),
                    "UserAccounts",
                    BindingAccess.Read);
                this.VirtualMachineConfigurationProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.VirtualMachineConfiguration, o => new VirtualMachineConfiguration(o).Freeze()),
                    "VirtualMachineConfiguration",
                    BindingAccess.Read);
                this.VirtualMachineSizeProperty = this.CreatePropertyAccessor(
                    protocolObject.VmSize,
                    "VirtualMachineSize",
                    BindingAccess.Read);
            }
        }

        private PropertyContainer propertyContainer;

        private readonly BatchClient parentBatchClient;

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CloudPool"/> class.
        /// </summary>
        /// <param name='parentBatchClient'>The parent <see cref="BatchClient"/> to use.</param>
        /// <param name='baseBehaviors'>The base behaviors to use.</param>
        internal CloudPool(
            BatchClient parentBatchClient,
            IEnumerable<BatchClientBehavior> baseBehaviors)
        {
            this.propertyContainer = new PropertyContainer();
            this.parentBatchClient = parentBatchClient;
            InheritUtil.InheritClientBehaviorsAndSetPublicProperty(this, baseBehaviors);
        }

        internal CloudPool(
            BatchClient parentBatchClient,
            Models.CloudPool protocolObject,
            IEnumerable<BatchClientBehavior> baseBehaviors)
        {
            this.parentBatchClient = parentBatchClient;
            InheritUtil.InheritClientBehaviorsAndSetPublicProperty(this, baseBehaviors);
            this.propertyContainer = new PropertyContainer(protocolObject);
        }

        #endregion Constructors

        #region IInheritedBehaviors

        /// <summary>
        /// Gets or sets a list of behaviors that modify or customize requests to the Batch service
        /// made via this <see cref="CloudPool"/>.
        /// </summary>
        /// <remarks>
        /// <para>These behaviors are inherited by child objects.</para>
        /// <para>Modifications are applied in the order of the collection. The last write wins.</para>
        /// </remarks>
        public IList<BatchClientBehavior> CustomBehaviors { get; set; }

        #endregion IInheritedBehaviors

        #region CloudPool

        /// <summary>
        /// Gets an <see cref="Common.AllocationState"/> which indicates what node allocation activity is occurring on the 
        /// pool.
        /// </summary>
        public Common.AllocationState? AllocationState
        {
            get { return this.propertyContainer.AllocationStateProperty.Value; }
        }

        /// <summary>
        /// Gets the time at which the pool entered its current <see cref="AllocationState"/>.
        /// </summary>
        public DateTime? AllocationStateTransitionTime
        {
            get { return this.propertyContainer.AllocationStateTransitionTimeProperty.Value; }
        }

        /// <summary>
        /// Gets or sets a list of application packages to be installed on each compute node in the pool.
        /// </summary>
        public IList<ApplicationPackageReference> ApplicationPackageReferences
        {
            get { return this.propertyContainer.ApplicationPackageReferencesProperty.Value; }
            set
            {
                this.propertyContainer.ApplicationPackageReferencesProperty.Value = ConcurrentChangeTrackedModifiableList<ApplicationPackageReference>.TransformEnumerableToConcurrentModifiableList(value);
            }
        }

        /// <summary>
        /// Gets or sets whether the pool size should automatically adjust according to the <see cref="AutoScaleFormula"/>.
        /// </summary>
        /// <remarks>
        /// <para>If false, the <see cref="TargetDedicated"/> property is required, and <see cref="AutoScaleFormula"/> must 
        /// be null.</para> <para>If true, the <see cref="AutoScaleFormula"/> property is required, and <see cref="TargetDedicated"/> 
        /// must be null. The pool automatically resizes according to the formula.</para><para>The default value is false.</para>
        /// </remarks>
        public bool? AutoScaleEnabled
        {
            get { return this.propertyContainer.AutoScaleEnabledProperty.Value; }
            set { this.propertyContainer.AutoScaleEnabledProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets a time interval at which to automatically adjust the pool size according to the <see cref="AutoScaleFormula"/>.
        /// </summary>
        /// <remarks>
        /// The default value is 15 minutes. The minimum allowed value is 5 minutes.
        /// </remarks>
        public TimeSpan? AutoScaleEvaluationInterval
        {
            get { return this.propertyContainer.AutoScaleEvaluationIntervalProperty.Value; }
            set { this.propertyContainer.AutoScaleEvaluationIntervalProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets a formula for the desired number of compute nodes in the pool.
        /// </summary>
        /// <remarks>
        /// <para>For how to write autoscale formulas, see https://azure.microsoft.com/documentation/articles/batch-automatic-scaling/. 
        /// This property is required if <see cref="AutoScaleEnabled"/> is set to true. It must be null if AutoScaleEnabled 
        /// is false.</para><para>The formula is checked for validity before the pool is created. If the formula is not valid, 
        /// an exception is thrown when you try to commit the <see cref="CloudPool"/>.</para>
        /// </remarks>
        public string AutoScaleFormula
        {
            get { return this.propertyContainer.AutoScaleFormulaProperty.Value; }
            set { this.propertyContainer.AutoScaleFormulaProperty.Value = value; }
        }

        /// <summary>
        /// Gets the results and errors from the last execution of the <see cref="AutoScaleFormula"/>.
        /// </summary>
        public AutoScaleRun AutoScaleRun
        {
            get { return this.propertyContainer.AutoScaleRunProperty.Value; }
        }

        /// <summary>
        /// Gets or sets a list of certificates to be installed on each compute node in the pool.
        /// </summary>
        public IList<CertificateReference> CertificateReferences
        {
            get { return this.propertyContainer.CertificateReferencesProperty.Value; }
            set
            {
                this.propertyContainer.CertificateReferencesProperty.Value = ConcurrentChangeTrackedModifiableList<CertificateReference>.TransformEnumerableToConcurrentModifiableList(value);
            }
        }

        /// <summary>
        /// Gets or sets the <see cref="CloudServiceConfiguration"/> for the pool.
        /// </summary>
        public CloudServiceConfiguration CloudServiceConfiguration
        {
            get { return this.propertyContainer.CloudServiceConfigurationProperty.Value; }
            set { this.propertyContainer.CloudServiceConfigurationProperty.Value = value; }
        }

        /// <summary>
        /// Gets the creation time for the pool.
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this.propertyContainer.CreationTimeProperty.Value; }
        }

        /// <summary>
        /// Gets the number of compute nodes currently in the pool.
        /// </summary>
        public int? CurrentDedicated
        {
            get { return this.propertyContainer.CurrentDedicatedProperty.Value; }
        }

        /// <summary>
        /// Gets or sets the display name of the pool.
        /// </summary>
        public string DisplayName
        {
            get { return this.propertyContainer.DisplayNameProperty.Value; }
            set { this.propertyContainer.DisplayNameProperty.Value = value; }
        }

        /// <summary>
        /// Gets the ETag for the pool.
        /// </summary>
        public string ETag
        {
            get { return this.propertyContainer.ETagProperty.Value; }
        }

        /// <summary>
        /// Gets or sets the id of the pool.
        /// </summary>
        public string Id
        {
            get { return this.propertyContainer.IdProperty.Value; }
            set { this.propertyContainer.IdProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets whether the pool permits direct communication between its compute nodes.
        /// </summary>
        /// <remarks>
        /// Enabling inter-node communication limits the maximum size of the pool due to deployment restrictions on the nodes 
        /// of the pool. This may result in the pool not reaching its desired size.
        /// </remarks>
        public bool? InterComputeNodeCommunicationEnabled
        {
            get { return this.propertyContainer.InterComputeNodeCommunicationEnabledProperty.Value; }
            set { this.propertyContainer.InterComputeNodeCommunicationEnabledProperty.Value = value; }
        }

        /// <summary>
        /// Gets the last modified time of the pool.
        /// </summary>
        public DateTime? LastModified
        {
            get { return this.propertyContainer.LastModifiedProperty.Value; }
        }

        /// <summary>
        /// Gets or sets the maximum number of tasks that can run concurrently on a single compute node in the pool.
        /// </summary>
        /// <remarks>
        /// The default value is 1. The maximum value of this setting depends on the size of the compute nodes in the pool 
        /// (the <see cref="VirtualMachineSize"/> property).
        /// </remarks>
        public int? MaxTasksPerComputeNode
        {
            get { return this.propertyContainer.MaxTasksPerComputeNodeProperty.Value; }
            set { this.propertyContainer.MaxTasksPerComputeNodeProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets a list of name-value pairs associated with the pool as metadata.
        /// </summary>
        public IList<MetadataItem> Metadata
        {
            get { return this.propertyContainer.MetadataProperty.Value; }
            set
            {
                this.propertyContainer.MetadataProperty.Value = ConcurrentChangeTrackedModifiableList<MetadataItem>.TransformEnumerableToConcurrentModifiableList(value);
            }
        }

        /// <summary>
        /// Gets or sets the network configuration of the pool.
        /// </summary>
        public NetworkConfiguration NetworkConfiguration
        {
            get { return this.propertyContainer.NetworkConfigurationProperty.Value; }
            set { this.propertyContainer.NetworkConfigurationProperty.Value = value; }
        }

        /// <summary>
        /// Gets the resize error encountered while performing the last resize on the <see cref="CloudPool"/>. This error 
        /// is returned only when the Batch service encountered an error while resizing the pool, and when the pool's <see 
        /// cref="CloudPool.AllocationState"/> is <see cref="AllocationState">Steady</see>.
        /// </summary>
        public ResizeError ResizeError
        {
            get { return this.propertyContainer.ResizeErrorProperty.Value; }
        }

        /// <summary>
        /// Gets or sets the timeout for allocation of compute nodes to the pool.
        /// </summary>
        public TimeSpan? ResizeTimeout
        {
            get { return this.propertyContainer.ResizeTimeoutProperty.Value; }
            set { this.propertyContainer.ResizeTimeoutProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets a task to run on each compute node as it joins the pool. The task runs when the node is added to 
        /// the pool or when the node is restarted.
        /// </summary>
        public StartTask StartTask
        {
            get { return this.propertyContainer.StartTaskProperty.Value; }
            set { this.propertyContainer.StartTaskProperty.Value = value; }
        }

        /// <summary>
        /// Gets the current state of the pool.
        /// </summary>
        public Common.PoolState? State
        {
            get { return this.propertyContainer.StateProperty.Value; }
        }

        /// <summary>
        /// Gets the time at which the pool entered its current state.
        /// </summary>
        public DateTime? StateTransitionTime
        {
            get { return this.propertyContainer.StateTransitionTimeProperty.Value; }
        }

        /// <summary>
        /// Gets the resource usage statistics for the pool.
        /// </summary>
        /// <remarks>
        /// This property is populated only if the <see cref="CloudPool"/> was retrieved with an <see cref="ODATADetailLevel.ExpandClause"/> 
        /// including the 'stats' attribute; otherwise it is null.
        /// </remarks>
        public PoolStatistics Statistics
        {
            get { return this.propertyContainer.StatisticsProperty.Value; }
        }

        /// <summary>
        /// Gets or sets the desired number of compute nodes in the pool.
        /// </summary>
        /// <remarks>
        /// This property must be null if <see cref="AutoScaleEnabled"/> is set to true. It is required if AutoScaleEnabled 
        /// is set to false.
        /// </remarks>
        public int? TargetDedicated
        {
            get { return this.propertyContainer.TargetDedicatedProperty.Value; }
            set { this.propertyContainer.TargetDedicatedProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets how tasks are distributed among compute nodes in the pool.
        /// </summary>
        public TaskSchedulingPolicy TaskSchedulingPolicy
        {
            get { return this.propertyContainer.TaskSchedulingPolicyProperty.Value; }
            set { this.propertyContainer.TaskSchedulingPolicyProperty.Value = value; }
        }

        /// <summary>
        /// Gets the URL of the pool.
        /// </summary>
        public string Url
        {
            get { return this.propertyContainer.UrlProperty.Value; }
        }

        /// <summary>
        /// Gets or sets the list of user accounts to be created on each node in the pool.
        /// </summary>
        public IList<UserAccount> UserAccounts
        {
            get { return this.propertyContainer.UserAccountsProperty.Value; }
            set
            {
                this.propertyContainer.UserAccountsProperty.Value = ConcurrentChangeTrackedModifiableList<UserAccount>.TransformEnumerableToConcurrentModifiableList(value);
            }
        }

        /// <summary>
        /// Gets or sets the <see cref="VirtualMachineConfiguration"/> of the pool.
        /// </summary>
        public VirtualMachineConfiguration VirtualMachineConfiguration
        {
            get { return this.propertyContainer.VirtualMachineConfigurationProperty.Value; }
            set { this.propertyContainer.VirtualMachineConfigurationProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets the size of the virtual machines in the pool.  All virtual machines in a pool are the same size.
        /// </summary>
        /// <remarks>
        /// <para>For information about available sizes of virtual machines for Cloud Services pools (pools created with 
        /// a <see cref="CloudServiceConfiguration"/>), see https://azure.microsoft.com/documentation/articles/cloud-services-sizes-specs/. 
        /// Batch supports all Cloud Services VM sizes except ExtraSmall.</para><para>For information about available VM 
        /// sizes for pools using images from the Virtual Machines Marketplace (pools created with a <see cref="VirtualMachineConfiguration"/>) 
        /// see https://azure.microsoft.com/documentation/articles/virtual-machines-linux-sizes/ or https://azure.microsoft.com/documentation/articles/virtual-machines-windows-sizes/. 
        /// Batch supports all Azure VM sizes except STANDARD_A0 and those with premium storage (for example STANDARD_GS, 
        /// STANDARD_DS, and STANDARD_DSV2 series).</para>
        /// </remarks>
        public string VirtualMachineSize
        {
            get { return this.propertyContainer.VirtualMachineSizeProperty.Value; }
            set { this.propertyContainer.VirtualMachineSizeProperty.Value = value; }
        }

        #endregion // CloudPool

        #region IPropertyMetadata

        bool IModifiable.HasBeenModified
        {
            get { return this.propertyContainer.HasBeenModified; }
        }

        bool IReadOnly.IsReadOnly
        {
            get { return this.propertyContainer.IsReadOnly; }
            set { this.propertyContainer.IsReadOnly = value; }
        }

        #endregion //IPropertyMetadata

        #region Internal/private methods
        /// <summary>
        /// Return a protocol object of the requested type.
        /// </summary>
        /// <returns>The protocol object of the requested type.</returns>
        Models.PoolAddParameter ITransportObjectProvider<Models.PoolAddParameter>.GetTransportObject()
        {
            Models.PoolAddParameter result = new Models.PoolAddParameter()
            {
                ApplicationPackageReferences = UtilitiesInternal.ConvertToProtocolCollection(this.ApplicationPackageReferences),
                EnableAutoScale = this.AutoScaleEnabled,
                AutoScaleEvaluationInterval = this.AutoScaleEvaluationInterval,
                AutoScaleFormula = this.AutoScaleFormula,
                CertificateReferences = UtilitiesInternal.ConvertToProtocolCollection(this.CertificateReferences),
                CloudServiceConfiguration = UtilitiesInternal.CreateObjectWithNullCheck(this.CloudServiceConfiguration, (o) => o.GetTransportObject()),
                DisplayName = this.DisplayName,
                Id = this.Id,
                EnableInterNodeCommunication = this.InterComputeNodeCommunicationEnabled,
                MaxTasksPerNode = this.MaxTasksPerComputeNode,
                Metadata = UtilitiesInternal.ConvertToProtocolCollection(this.Metadata),
                NetworkConfiguration = UtilitiesInternal.CreateObjectWithNullCheck(this.NetworkConfiguration, (o) => o.GetTransportObject()),
                ResizeTimeout = this.ResizeTimeout,
                StartTask = UtilitiesInternal.CreateObjectWithNullCheck(this.StartTask, (o) => o.GetTransportObject()),
                TargetDedicated = this.TargetDedicated,
                TaskSchedulingPolicy = UtilitiesInternal.CreateObjectWithNullCheck(this.TaskSchedulingPolicy, (o) => o.GetTransportObject()),
                UserAccounts = UtilitiesInternal.ConvertToProtocolCollection(this.UserAccounts),
                VirtualMachineConfiguration = UtilitiesInternal.CreateObjectWithNullCheck(this.VirtualMachineConfiguration, (o) => o.GetTransportObject()),
                VmSize = this.VirtualMachineSize,
            };

            return result;
        }


        #endregion // Internal/private methods
    }
}