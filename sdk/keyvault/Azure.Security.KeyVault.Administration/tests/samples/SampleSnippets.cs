// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core.TestFramework;
using Azure.Identity;
using Azure.Security.KeyVault.Administration.Models;
using Azure.Security.KeyVault.Tests;
using NUnit.Framework;

namespace Azure.Security.KeyVault.Administration.Samples
{
    /// <summary>
    /// Samples that are used in the associated README.md file.
    /// </summary>
    public partial class Snippets : SamplesBase<KeyVaultTestEnvironment>
    {
#pragma warning disable IDE1006 // Naming Styles
        private KeyVaultAccessControlClient client;
        private string objectId;
        private string roleDefinitionId;
#pragma warning restore IDE1006 // Naming Styles

        [OneTimeSetUp]
        public void CreateClient()
        {
            // Environment variable with the Key Vault endpoint.
            string keyVaultUrl = TestEnvironment.KeyVaultUrl;

            #region Snippet:CreateKeyVaultAccessControlClient
            // Create a new access control client using the default credential from Azure.Identity using environment variables previously set,
            // including AZURE_CLIENT_ID, AZURE_CLIENT_SECRET, and AZURE_TENANT_ID.
            KeyVaultAccessControlClient client = new KeyVaultAccessControlClient(vaultUri: new Uri(keyVaultUrl), credential: new DefaultAzureCredential());

            // Retrieve all the role definitions.
            List<RoleDefinition> roleDefinitions = client.GetRoleDefinitions(RoleAssignmentScope.Global).ToList();

            // Retrieve all the role assignments.
            List<RoleAssignment> roleAssignments = client.GetRoleAssignments(RoleAssignmentScope.Global).ToList();

            #endregion
            this.client = client;
            objectId = TestEnvironment.ClientObjectId;
            roleDefinitionId = roleDefinitions.FirstOrDefault(d => d.RoleName.Equals("Azure Key Vault Managed HSM Crypto User")).Name;
        }

        [Ignore("These tests can't run until the service features are available")]
        public void GetRoleDefinitions()
        {
            #region Snippet:GetRoleDefinitions
            Pageable<RoleDefinition> allDefinitions = client.GetRoleDefinitions(RoleAssignmentScope.Global);

            foreach (RoleDefinition roleDefinition in allDefinitions)
            {
                Console.WriteLine(roleDefinition.Id);
                Console.WriteLine(roleDefinition.RoleName);
                Console.WriteLine(roleDefinition.Description);
                Console.WriteLine();
            }
            #endregion
        }

        [Ignore("These tests can't run until the service features are available")]
        public void CreateRoleAssignment()
        {
            #region Snippet:CreateRoleAssignment

            // Replace roleDefinitionId with a role definition Id from the definitions returned from the List the role definitions section above
            string definitionIdToAssign = roleDefinitionId;

            // Replace objectId with the service principal object id from the Create/Get credentials section above
            string servicePrincipalObjectId = objectId;

            RoleAssignmentProperties properties = new RoleAssignmentProperties(definitionIdToAssign, servicePrincipalObjectId);
            RoleAssignment createdAssignment = client.CreateRoleAssignment(RoleAssignmentScope.Global, properties);

            Console.WriteLine(createdAssignment.Name);
            Console.WriteLine(createdAssignment.Properties.PrincipalId);
            Console.WriteLine(createdAssignment.Properties.RoleDefinitionId);

            RoleAssignment fetchedAssignment = client.GetRoleAssignment(RoleAssignmentScope.Global, createdAssignment.Name);

            Console.WriteLine(fetchedAssignment.Name);
            Console.WriteLine(fetchedAssignment.Properties.PrincipalId);
            Console.WriteLine(fetchedAssignment.Properties.RoleDefinitionId);

            RoleAssignment deletedAssignment = client.DeleteRoleAssignment(RoleAssignmentScope.Global, createdAssignment.Name);

            Console.WriteLine(deletedAssignment.Name);
            Console.WriteLine(deletedAssignment.Properties.PrincipalId);
            Console.WriteLine(deletedAssignment.Properties.RoleDefinitionId);

            #endregion
        }

        [Ignore("These tests can't run until the service features are available")]
        public void RoleAssignmentNotFound()
        {
            #region Snippet:RoleAssignmentNotFound
            try
            {
                RoleAssignment roleAssignment = client.GetRoleAssignment(RoleAssignmentScope.Global, "invalid-name");
            }
            catch (RequestFailedException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            #endregion
        }
    }
}
