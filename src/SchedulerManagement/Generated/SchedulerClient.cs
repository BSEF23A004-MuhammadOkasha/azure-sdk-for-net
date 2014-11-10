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
using System.Net.Http;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Common;
using Microsoft.WindowsAzure.Scheduler;
using Microsoft.WindowsAzure.Scheduler.Models;

namespace Microsoft.WindowsAzure.Scheduler
{
    public partial class SchedulerClient : ServiceClient<SchedulerClient>, ISchedulerClient
    {
        private string _apiVersion;
        
        /// <summary>
        /// Gets the API version.
        /// </summary>
        public string ApiVersion
        {
            get { return this._apiVersion; }
        }
        
        private Uri _baseUri;
        
        /// <summary>
        /// Gets the URI used as the base for all cloud service requests.
        /// </summary>
        public Uri BaseUri
        {
            get { return this._baseUri; }
        }
        
        private string _cloudServiceName;
        
        public string CloudServiceName
        {
            get { return this._cloudServiceName; }
            set { this._cloudServiceName = value; }
        }
        
        private SubscriptionCloudCredentials _credentials;
        
        /// <summary>
        /// Gets subscription credentials which uniquely identify Microsoft
        /// Azure subscription. The subscription ID forms part of the URI for
        /// every service call.
        /// </summary>
        public SubscriptionCloudCredentials Credentials
        {
            get { return this._credentials; }
        }
        
        private string _jobCollectionName;
        
        public string JobCollectionName
        {
            get { return this._jobCollectionName; }
            set { this._jobCollectionName = value; }
        }
        
        private int _longRunningOperationInitialTimeout;
        
        /// <summary>
        /// Gets or sets the initial timeout for Long Running Operations.
        /// </summary>
        public int LongRunningOperationInitialTimeout
        {
            get { return this._longRunningOperationInitialTimeout; }
            set { this._longRunningOperationInitialTimeout = value; }
        }
        
        private int _longRunningOperationRetryTimeout;
        
        /// <summary>
        /// Gets or sets the retry timeout for Long Running Operations.
        /// </summary>
        public int LongRunningOperationRetryTimeout
        {
            get { return this._longRunningOperationRetryTimeout; }
            set { this._longRunningOperationRetryTimeout = value; }
        }
        
        private IJobOperations _jobs;
        
        public virtual IJobOperations Jobs
        {
            get { return this._jobs; }
        }
        
        /// <summary>
        /// Initializes a new instance of the SchedulerClient class.
        /// </summary>
        private SchedulerClient()
            : base()
        {
            this._jobs = new JobOperations(this);
            this._apiVersion = "2013-03-01";
            this._longRunningOperationInitialTimeout = -1;
            this._longRunningOperationRetryTimeout = -1;
            this.HttpClient.Timeout = TimeSpan.FromSeconds(300);
        }
        
        /// <summary>
        /// Initializes a new instance of the SchedulerClient class.
        /// </summary>
        /// <param name='cloudServiceName'>
        /// Required.
        /// </param>
        /// <param name='jobCollectionName'>
        /// Required.
        /// </param>
        /// <param name='credentials'>
        /// Required. Gets subscription credentials which uniquely identify
        /// Microsoft Azure subscription. The subscription ID forms part of
        /// the URI for every service call.
        /// </param>
        /// <param name='baseUri'>
        /// Optional. Gets the URI used as the base for all cloud service
        /// requests.
        /// </param>
        public SchedulerClient(string cloudServiceName, string jobCollectionName, SubscriptionCloudCredentials credentials, Uri baseUri)
            : this()
        {
            if (cloudServiceName == null)
            {
                throw new ArgumentNullException("cloudServiceName");
            }
            if (jobCollectionName == null)
            {
                throw new ArgumentNullException("jobCollectionName");
            }
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            this._cloudServiceName = cloudServiceName;
            this._jobCollectionName = jobCollectionName;
            this._credentials = credentials;
            this._baseUri = baseUri;
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Initializes a new instance of the SchedulerClient class.
        /// </summary>
        /// <param name='cloudServiceName'>
        /// Required.
        /// </param>
        /// <param name='jobCollectionName'>
        /// Required.
        /// </param>
        /// <param name='credentials'>
        /// Required. Gets subscription credentials which uniquely identify
        /// Microsoft Azure subscription. The subscription ID forms part of
        /// the URI for every service call.
        /// </param>
        public SchedulerClient(string cloudServiceName, string jobCollectionName, SubscriptionCloudCredentials credentials)
            : this()
        {
            if (cloudServiceName == null)
            {
                throw new ArgumentNullException("cloudServiceName");
            }
            if (jobCollectionName == null)
            {
                throw new ArgumentNullException("jobCollectionName");
            }
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            this._cloudServiceName = cloudServiceName;
            this._jobCollectionName = jobCollectionName;
            this._credentials = credentials;
            this._baseUri = new Uri("https://management.core.windows.net/");
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Initializes a new instance of the SchedulerClient class.
        /// </summary>
        /// <param name='httpClient'>
        /// The Http client
        /// </param>
        private SchedulerClient(HttpClient httpClient)
            : base(httpClient)
        {
            this._jobs = new JobOperations(this);
            this._apiVersion = "2013-03-01";
            this._longRunningOperationInitialTimeout = -1;
            this._longRunningOperationRetryTimeout = -1;
            this.HttpClient.Timeout = TimeSpan.FromSeconds(300);
        }
        
        /// <summary>
        /// Initializes a new instance of the SchedulerClient class.
        /// </summary>
        /// <param name='cloudServiceName'>
        /// Required.
        /// </param>
        /// <param name='jobCollectionName'>
        /// Required.
        /// </param>
        /// <param name='credentials'>
        /// Required. Gets subscription credentials which uniquely identify
        /// Microsoft Azure subscription. The subscription ID forms part of
        /// the URI for every service call.
        /// </param>
        /// <param name='baseUri'>
        /// Optional. Gets the URI used as the base for all cloud service
        /// requests.
        /// </param>
        /// <param name='httpClient'>
        /// The Http client
        /// </param>
        public SchedulerClient(string cloudServiceName, string jobCollectionName, SubscriptionCloudCredentials credentials, Uri baseUri, HttpClient httpClient)
            : this(httpClient)
        {
            if (cloudServiceName == null)
            {
                throw new ArgumentNullException("cloudServiceName");
            }
            if (jobCollectionName == null)
            {
                throw new ArgumentNullException("jobCollectionName");
            }
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            this._cloudServiceName = cloudServiceName;
            this._jobCollectionName = jobCollectionName;
            this._credentials = credentials;
            this._baseUri = baseUri;
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Initializes a new instance of the SchedulerClient class.
        /// </summary>
        /// <param name='cloudServiceName'>
        /// Required.
        /// </param>
        /// <param name='jobCollectionName'>
        /// Required.
        /// </param>
        /// <param name='credentials'>
        /// Required. Gets subscription credentials which uniquely identify
        /// Microsoft Azure subscription. The subscription ID forms part of
        /// the URI for every service call.
        /// </param>
        /// <param name='httpClient'>
        /// The Http client
        /// </param>
        public SchedulerClient(string cloudServiceName, string jobCollectionName, SubscriptionCloudCredentials credentials, HttpClient httpClient)
            : this(httpClient)
        {
            if (cloudServiceName == null)
            {
                throw new ArgumentNullException("cloudServiceName");
            }
            if (jobCollectionName == null)
            {
                throw new ArgumentNullException("jobCollectionName");
            }
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            this._cloudServiceName = cloudServiceName;
            this._jobCollectionName = jobCollectionName;
            this._credentials = credentials;
            this._baseUri = new Uri("https://management.core.windows.net/");
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Clones properties from current instance to another SchedulerClient
        /// instance
        /// </summary>
        /// <param name='client'>
        /// Instance of SchedulerClient to clone to
        /// </param>
        protected override void Clone(ServiceClient<SchedulerClient> client)
        {
            base.Clone(client);
            
            if (client is SchedulerClient)
            {
                SchedulerClient clonedClient = ((SchedulerClient)client);
                
                clonedClient._cloudServiceName = this._cloudServiceName;
                clonedClient._jobCollectionName = this._jobCollectionName;
                clonedClient._credentials = this._credentials;
                clonedClient._baseUri = this._baseUri;
                clonedClient._apiVersion = this._apiVersion;
                clonedClient._longRunningOperationInitialTimeout = this._longRunningOperationInitialTimeout;
                clonedClient._longRunningOperationRetryTimeout = this._longRunningOperationRetryTimeout;
                
                clonedClient.Credentials.InitializeServiceClient(clonedClient);
            }
        }
        
        /// <summary>
        /// Parse enum values for type HttpAuthenticationType.
        /// </summary>
        /// <param name='value'>
        /// The value to parse.
        /// </param>
        /// <returns>
        /// The enum value.
        /// </returns>
        internal static HttpAuthenticationType ParseHttpAuthenticationType(string value)
        {
            if ("notspecified".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return HttpAuthenticationType.NotSpecified;
            }
            if ("basic".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return HttpAuthenticationType.Basic;
            }
            if ("clientcertificate".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return HttpAuthenticationType.ClientCertificate;
            }
            throw new ArgumentOutOfRangeException("value");
        }
        
        /// <summary>
        /// Convert an enum of type HttpAuthenticationType to a string.
        /// </summary>
        /// <param name='value'>
        /// The value to convert to a string.
        /// </param>
        /// <returns>
        /// The enum value as a string.
        /// </returns>
        internal static string HttpAuthenticationTypeToString(HttpAuthenticationType value)
        {
            if (value == HttpAuthenticationType.NotSpecified)
            {
                return "notspecified";
            }
            if (value == HttpAuthenticationType.Basic)
            {
                return "basic";
            }
            if (value == HttpAuthenticationType.ClientCertificate)
            {
                return "clientcertificate";
            }
            throw new ArgumentOutOfRangeException("value");
        }
        
        /// <summary>
        /// Parse enum values for type JobActionType.
        /// </summary>
        /// <param name='value'>
        /// The value to parse.
        /// </param>
        /// <returns>
        /// The enum value.
        /// </returns>
        internal static JobActionType ParseJobActionType(string value)
        {
            if ("http".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return JobActionType.Http;
            }
            if ("https".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return JobActionType.Https;
            }
            if ("storageQueue".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return JobActionType.StorageQueue;
            }
            throw new ArgumentOutOfRangeException("value");
        }
        
        /// <summary>
        /// Convert an enum of type JobActionType to a string.
        /// </summary>
        /// <param name='value'>
        /// The value to convert to a string.
        /// </param>
        /// <returns>
        /// The enum value as a string.
        /// </returns>
        internal static string JobActionTypeToString(JobActionType value)
        {
            if (value == JobActionType.Http)
            {
                return "http";
            }
            if (value == JobActionType.Https)
            {
                return "https";
            }
            if (value == JobActionType.StorageQueue)
            {
                return "storageQueue";
            }
            throw new ArgumentOutOfRangeException("value");
        }
        
        /// <summary>
        /// Parse enum values for type JobHistoryActionName.
        /// </summary>
        /// <param name='value'>
        /// The value to parse.
        /// </param>
        /// <returns>
        /// The enum value.
        /// </returns>
        internal static JobHistoryActionName ParseJobHistoryActionName(string value)
        {
            if ("MainAction".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return JobHistoryActionName.MainAction;
            }
            if ("ErrorAction".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return JobHistoryActionName.ErrorAction;
            }
            throw new ArgumentOutOfRangeException("value");
        }
        
        /// <summary>
        /// Convert an enum of type JobHistoryActionName to a string.
        /// </summary>
        /// <param name='value'>
        /// The value to convert to a string.
        /// </param>
        /// <returns>
        /// The enum value as a string.
        /// </returns>
        internal static string JobHistoryActionNameToString(JobHistoryActionName value)
        {
            if (value == JobHistoryActionName.MainAction)
            {
                return "MainAction";
            }
            if (value == JobHistoryActionName.ErrorAction)
            {
                return "ErrorAction";
            }
            throw new ArgumentOutOfRangeException("value");
        }
        
        /// <summary>
        /// Parse enum values for type JobHistoryStatus.
        /// </summary>
        /// <param name='value'>
        /// The value to parse.
        /// </param>
        /// <returns>
        /// The enum value.
        /// </returns>
        internal static JobHistoryStatus ParseJobHistoryStatus(string value)
        {
            if ("completed".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return JobHistoryStatus.Completed;
            }
            if ("failed".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return JobHistoryStatus.Failed;
            }
            if ("postponed".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return JobHistoryStatus.Postponed;
            }
            throw new ArgumentOutOfRangeException("value");
        }
        
        /// <summary>
        /// Convert an enum of type JobHistoryStatus to a string.
        /// </summary>
        /// <param name='value'>
        /// The value to convert to a string.
        /// </param>
        /// <returns>
        /// The enum value as a string.
        /// </returns>
        internal static string JobHistoryStatusToString(JobHistoryStatus value)
        {
            if (value == JobHistoryStatus.Completed)
            {
                return "completed";
            }
            if (value == JobHistoryStatus.Failed)
            {
                return "failed";
            }
            if (value == JobHistoryStatus.Postponed)
            {
                return "postponed";
            }
            throw new ArgumentOutOfRangeException("value");
        }
        
        /// <summary>
        /// Parse enum values for type JobRecurrenceFrequency.
        /// </summary>
        /// <param name='value'>
        /// The value to parse.
        /// </param>
        /// <returns>
        /// The enum value.
        /// </returns>
        internal static JobRecurrenceFrequency ParseJobRecurrenceFrequency(string value)
        {
            if ("minute".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return JobRecurrenceFrequency.Minute;
            }
            if ("hour".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return JobRecurrenceFrequency.Hour;
            }
            if ("day".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return JobRecurrenceFrequency.Day;
            }
            if ("week".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return JobRecurrenceFrequency.Week;
            }
            if ("month".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return JobRecurrenceFrequency.Month;
            }
            if ("year".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return JobRecurrenceFrequency.Year;
            }
            throw new ArgumentOutOfRangeException("value");
        }
        
        /// <summary>
        /// Convert an enum of type JobRecurrenceFrequency to a string.
        /// </summary>
        /// <param name='value'>
        /// The value to convert to a string.
        /// </param>
        /// <returns>
        /// The enum value as a string.
        /// </returns>
        internal static string JobRecurrenceFrequencyToString(JobRecurrenceFrequency value)
        {
            if (value == JobRecurrenceFrequency.Minute)
            {
                return "minute";
            }
            if (value == JobRecurrenceFrequency.Hour)
            {
                return "hour";
            }
            if (value == JobRecurrenceFrequency.Day)
            {
                return "day";
            }
            if (value == JobRecurrenceFrequency.Week)
            {
                return "week";
            }
            if (value == JobRecurrenceFrequency.Month)
            {
                return "month";
            }
            if (value == JobRecurrenceFrequency.Year)
            {
                return "year";
            }
            throw new ArgumentOutOfRangeException("value");
        }
        
        /// <summary>
        /// Parse enum values for type JobScheduleDay.
        /// </summary>
        /// <param name='value'>
        /// The value to parse.
        /// </param>
        /// <returns>
        /// The enum value.
        /// </returns>
        internal static JobScheduleDay ParseJobScheduleDay(string value)
        {
            if ("monday".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return JobScheduleDay.Monday;
            }
            if ("tuesday".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return JobScheduleDay.Tuesday;
            }
            if ("wednesday".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return JobScheduleDay.Wednesday;
            }
            if ("thursday".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return JobScheduleDay.Thursday;
            }
            if ("friday".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return JobScheduleDay.Friday;
            }
            if ("saturday".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return JobScheduleDay.Saturday;
            }
            if ("sunday".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return JobScheduleDay.Sunday;
            }
            throw new ArgumentOutOfRangeException("value");
        }
        
        /// <summary>
        /// Convert an enum of type JobScheduleDay to a string.
        /// </summary>
        /// <param name='value'>
        /// The value to convert to a string.
        /// </param>
        /// <returns>
        /// The enum value as a string.
        /// </returns>
        internal static string JobScheduleDayToString(JobScheduleDay value)
        {
            if (value == JobScheduleDay.Monday)
            {
                return "monday";
            }
            if (value == JobScheduleDay.Tuesday)
            {
                return "tuesday";
            }
            if (value == JobScheduleDay.Wednesday)
            {
                return "wednesday";
            }
            if (value == JobScheduleDay.Thursday)
            {
                return "thursday";
            }
            if (value == JobScheduleDay.Friday)
            {
                return "friday";
            }
            if (value == JobScheduleDay.Saturday)
            {
                return "saturday";
            }
            if (value == JobScheduleDay.Sunday)
            {
                return "sunday";
            }
            throw new ArgumentOutOfRangeException("value");
        }
        
        /// <summary>
        /// Parse enum values for type JobState.
        /// </summary>
        /// <param name='value'>
        /// The value to parse.
        /// </param>
        /// <returns>
        /// The enum value.
        /// </returns>
        internal static JobState ParseJobState(string value)
        {
            if ("enabled".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return JobState.Enabled;
            }
            if ("disabled".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return JobState.Disabled;
            }
            if ("faulted".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return JobState.Faulted;
            }
            if ("completed".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return JobState.Completed;
            }
            throw new ArgumentOutOfRangeException("value");
        }
        
        /// <summary>
        /// Convert an enum of type JobState to a string.
        /// </summary>
        /// <param name='value'>
        /// The value to convert to a string.
        /// </param>
        /// <returns>
        /// The enum value as a string.
        /// </returns>
        internal static string JobStateToString(JobState value)
        {
            if (value == JobState.Enabled)
            {
                return "enabled";
            }
            if (value == JobState.Disabled)
            {
                return "disabled";
            }
            if (value == JobState.Faulted)
            {
                return "faulted";
            }
            if (value == JobState.Completed)
            {
                return "completed";
            }
            throw new ArgumentOutOfRangeException("value");
        }
        
        /// <summary>
        /// Parse enum values for type RetryType.
        /// </summary>
        /// <param name='value'>
        /// The value to parse.
        /// </param>
        /// <returns>
        /// The enum value.
        /// </returns>
        internal static RetryType ParseRetryType(string value)
        {
            if ("none".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return RetryType.None;
            }
            if ("fixed".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return RetryType.Fixed;
            }
            throw new ArgumentOutOfRangeException("value");
        }
        
        /// <summary>
        /// Convert an enum of type RetryType to a string.
        /// </summary>
        /// <param name='value'>
        /// The value to convert to a string.
        /// </param>
        /// <returns>
        /// The enum value as a string.
        /// </returns>
        internal static string RetryTypeToString(RetryType value)
        {
            if (value == RetryType.None)
            {
                return "none";
            }
            if (value == RetryType.Fixed)
            {
                return "fixed";
            }
            throw new ArgumentOutOfRangeException("value");
        }
    }
}
