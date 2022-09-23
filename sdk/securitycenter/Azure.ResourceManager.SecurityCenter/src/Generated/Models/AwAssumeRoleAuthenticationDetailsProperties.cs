// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> AWS cloud account connector based assume role, the role enables delegating access to your AWS resources. The role is composed of role Amazon Resource Name (ARN) and external ID. For more details, refer to &lt;a href=&quot;https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_create_for-user.html&quot;&gt;Creating a Role to Delegate Permissions to an IAM User (write only)&lt;/a&gt;. </summary>
    public partial class AwAssumeRoleAuthenticationDetailsProperties : AuthenticationDetailsProperties
    {
        /// <summary> Initializes a new instance of AwAssumeRoleAuthenticationDetailsProperties. </summary>
        /// <param name="awsAssumeRoleArn"> Assumed role ID is an identifier that you can use to create temporary security credentials. </param>
        /// <param name="awsExternalId"> A unique identifier that is required when you assume a role in another account. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="awsAssumeRoleArn"/> or <paramref name="awsExternalId"/> is null. </exception>
        public AwAssumeRoleAuthenticationDetailsProperties(string awsAssumeRoleArn, string awsExternalId)
        {
            if (awsAssumeRoleArn == null)
            {
                throw new ArgumentNullException(nameof(awsAssumeRoleArn));
            }
            if (awsExternalId == null)
            {
                throw new ArgumentNullException(nameof(awsExternalId));
            }

            AwsAssumeRoleArn = awsAssumeRoleArn;
            AwsExternalId = awsExternalId;
            AuthenticationType = AuthenticationType.AwsAssumeRole;
        }

        /// <summary> Initializes a new instance of AwAssumeRoleAuthenticationDetailsProperties. </summary>
        /// <param name="authenticationProvisioningState"> State of the multi-cloud connector. </param>
        /// <param name="grantedPermissions"> The permissions detected in the cloud account. </param>
        /// <param name="authenticationType"> Connect to your cloud account, for AWS use either account credentials or role-based authentication. For GCP use account organization credentials. </param>
        /// <param name="accountId"> The ID of the cloud account. </param>
        /// <param name="awsAssumeRoleArn"> Assumed role ID is an identifier that you can use to create temporary security credentials. </param>
        /// <param name="awsExternalId"> A unique identifier that is required when you assume a role in another account. </param>
        internal AwAssumeRoleAuthenticationDetailsProperties(AuthenticationProvisioningState? authenticationProvisioningState, IReadOnlyList<PermissionProperty> grantedPermissions, AuthenticationType authenticationType, string accountId, string awsAssumeRoleArn, string awsExternalId) : base(authenticationProvisioningState, grantedPermissions, authenticationType)
        {
            AccountId = accountId;
            AwsAssumeRoleArn = awsAssumeRoleArn;
            AwsExternalId = awsExternalId;
            AuthenticationType = authenticationType;
        }

        /// <summary> The ID of the cloud account. </summary>
        public string AccountId { get; }
        /// <summary> Assumed role ID is an identifier that you can use to create temporary security credentials. </summary>
        public string AwsAssumeRoleArn { get; set; }
        /// <summary> A unique identifier that is required when you assume a role in another account. </summary>
        public string AwsExternalId { get; set; }
    }
}
