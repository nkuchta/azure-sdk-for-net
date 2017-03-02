// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Microsoft.Azure.Management.Compute;
using Microsoft.Azure.Management.Compute.Models;
using Microsoft.Azure.Management.Resources;
using Microsoft.Rest.Azure;
using Microsoft.Rest.ClientRuntime.Azure.TestFramework;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Xunit;

namespace Compute.Tests
{
    public class IdentityTests : VMTestBase
    {
        [Fact]
        public void TestVMWithManagedIdentity()
        {
            using (MockContext context = MockContext.Start(this.GetType().FullName))
            {
                EnsureClientsInitialized(context);
                m_location = "WestUS"; // TODO: For now, MSI service is not available in SoutheastAsia

                ImageReference imageRef = GetPlatformVMImage(useWindowsImage: true);
                // Create resource group
                var rgName = ComputeManagementTestUtilities.GenerateName(TestPrefix);
                string storageAccountName = ComputeManagementTestUtilities.GenerateName(TestPrefix);
                string asName = ComputeManagementTestUtilities.GenerateName("as");
                VirtualMachine inputVM;
                try
                {
                    // Create Storage Account, so that both the VMs can share it
                    var storageAccountOutput = CreateStorageAccount(rgName, storageAccountName);

                    var vm = CreateVM_NoAsyncTracking(rgName, asName, storageAccountOutput, imageRef, out inputVM, hasManagedIdentity: true);
                }
                finally
                {
                    m_ResourcesClient.ResourceGroups.Delete(rgName);
                }
            }
        }
    }
}
