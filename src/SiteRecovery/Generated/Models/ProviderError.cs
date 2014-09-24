// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;

namespace Microsoft.WindowsAzure.Management.SiteRecovery.Models
{
    /// <summary>
    /// The definition of a ProviderError object.
    /// </summary>
    public partial class ProviderError
    {
        private DateTime _creationTimeUtc;
        
        /// <summary>
        /// Required. Time, when error was generated.
        /// </summary>
        public DateTime CreationTimeUtc
        {
            get { return this._creationTimeUtc; }
            set { this._creationTimeUtc = value; }
        }
        
        private int _errorCode;
        
        /// <summary>
        /// Required. Error code.
        /// </summary>
        public int ErrorCode
        {
            get { return this._errorCode; }
            set { this._errorCode = value; }
        }
        
        private string _errorId;
        
        /// <summary>
        /// Required. Error ID.
        /// </summary>
        public string ErrorId
        {
            get { return this._errorId; }
            set { this._errorId = value; }
        }
        
        private string _errorLevel;
        
        /// <summary>
        /// Required. Error level.
        /// </summary>
        public string ErrorLevel
        {
            get { return this._errorLevel; }
            set { this._errorLevel = value; }
        }
        
        private string _errorMessage;
        
        /// <summary>
        /// Required. Error message.
        /// </summary>
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }
        
        private string _hVClusterId;
        
        /// <summary>
        /// Required. HyperV cluster Id.
        /// </summary>
        public string HVClusterId
        {
            get { return this._hVClusterId; }
            set { this._hVClusterId = value; }
        }
        
        private string _hVHostId;
        
        /// <summary>
        /// Required. HyperV host Id.
        /// </summary>
        public string HVHostId
        {
            get { return this._hVHostId; }
            set { this._hVHostId = value; }
        }
        
        private string _networkId;
        
        /// <summary>
        /// Required. Network Id.
        /// </summary>
        public string NetworkId
        {
            get { return this._networkId; }
            set { this._networkId = value; }
        }
        
        private string _protectionContainerId;
        
        /// <summary>
        /// Required. ProtectionContainer Id.
        /// </summary>
        public string ProtectionContainerId
        {
            get { return this._protectionContainerId; }
            set { this._protectionContainerId = value; }
        }
        
        private string _serverId;
        
        /// <summary>
        /// Required. Server Id.
        /// </summary>
        public string ServerId
        {
            get { return this._serverId; }
            set { this._serverId = value; }
        }
        
        private string _vmId;
        
        /// <summary>
        /// Required. Task Id.
        /// </summary>
        public string VmId
        {
            get { return this._vmId; }
            set { this._vmId = value; }
        }
        
        private string _workflowId;
        
        /// <summary>
        /// Required. Workflow Id
        /// </summary>
        public string WorkflowId
        {
            get { return this._workflowId; }
            set { this._workflowId = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ProviderError class.
        /// </summary>
        public ProviderError()
        {
        }
    }
}
