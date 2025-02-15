﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Commands.RecoveryServices.Backup.Cmdlets.Models;
using Microsoft.WindowsAzure.Commands.ScenarioTest;
using Microsoft.WindowsAzure.Commands.Utilities.Common;
using Xunit;

namespace Microsoft.Azure.Commands.RecoveryServices.Backup.Test.ScenarioTests
{
    public partial class PolicyTests : RecoveryServicesBackupTestRunner
    {
        private readonly string _AzureFilescommonModule = $"ScenarioTests/{PsBackupProviderTypes.AzureFiles}/Common.ps1";
        private readonly string _AzureFilestestModule = $"ScenarioTests/{PsBackupProviderTypes.AzureFiles}/PolicyTests.ps1";

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(TestConstants.Workload, TestConstants.AzureFS)]
        public void TestAzureFSPolicy()
        {
            TestRunner.RunTestScript(
                $"Import-Module {_AzureFilescommonModule.AsAbsoluteLocation()}",
                $"Import-Module {_AzureFilestestModule.AsAbsoluteLocation()}",
                "Test-AzureFSPolicy"
            );
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(TestConstants.Workload, TestConstants.AzureFS)]
        public void TestAzureFSHourlyPolicy()
        {
            TestRunner.RunTestScript(
                $"Import-Module {_AzureFilescommonModule.AsAbsoluteLocation()}",
                $"Import-Module {_AzureFilestestModule.AsAbsoluteLocation()}",
                "Test-AzureFSHourlyPolicy"
            );
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(TestConstants.Workload, TestConstants.AzureFS)]
        public void TestAzureFSVaultPolicy()
        {
            TestRunner.RunTestScript(
                $"Import-Module {_AzureFilescommonModule.AsAbsoluteLocation()}",
                $"Import-Module {_AzureFilestestModule.AsAbsoluteLocation()}",
                "Test-AzureFSVaultPolicy"
            );
        }
    }
}
