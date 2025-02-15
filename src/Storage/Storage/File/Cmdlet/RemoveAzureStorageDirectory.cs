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

namespace Microsoft.WindowsAzure.Commands.Storage.File.Cmdlet
{
    using global::Azure.Storage.Files.Shares;
    using Microsoft.WindowsAzure.Commands.Common.Storage.ResourceModel;
    using Microsoft.WindowsAzure.Commands.Storage.Common;
    using System.Globalization;
    using System.Management.Automation;

    [Cmdlet("Remove", Azure.Commands.ResourceManager.Common.AzureRMConstants.AzurePrefix + "StorageDirectory",SupportsShouldProcess = true,DefaultParameterSetName = Constants.ShareNameParameterSetName), OutputType(typeof(AzureStorageFileDirectory))]
    public class RemoveAzureStorageDirectory : AzureStorageFileCmdletBase
    {
        [Parameter(
            Position = 0,
            Mandatory = true,
            ParameterSetName = Constants.ShareNameParameterSetName,
            HelpMessage = "Name of the file share where the directory would be removed.")]
        [ValidateNotNullOrEmpty]
        public string ShareName { get; set; }

        [Parameter(
            Position = 0,
            Mandatory = true,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true,
            ParameterSetName = Constants.ShareParameterSetName,
            HelpMessage = "ShareClient object indicated the share where the directory would be removed.")]
        [ValidateNotNull]
        public ShareClient ShareClient { get; set; }

        [Parameter(
            Position = 0,
            Mandatory = true,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true,
            ParameterSetName = Constants.DirectoryParameterSetName,
            HelpMessage = "ShareDirectoryClient object indicated the base folder where the directory would be removed.")]
        [ValidateNotNull]
        public ShareDirectoryClient ShareDirectoryClient { get; set; }

        [Parameter(
            Position = 1,
            Mandatory = true,
            ParameterSetName = Constants.ShareParameterSetName,
            HelpMessage = "Path to the directory to be removed.")]
        [Parameter(
            Position = 1,
            Mandatory = true,
            ParameterSetName = Constants.ShareNameParameterSetName,
            HelpMessage = "Path to the directory to be removed.")]
        [Parameter(
            Position = 1,
            ValueFromPipelineByPropertyName = true,
            ParameterSetName = Constants.DirectoryParameterSetName,
            HelpMessage = "Path to the directory to be removed.")]
        [ValidateNotNullOrEmpty]
        public string Path { get; set; }

        [Parameter(HelpMessage = "Returns an object representing the removed directory. By default, this cmdlet does not generate any output.")]
        public SwitchParameter PassThru { get; set; }

        public override void ExecuteCmdlet()
        {
            ShareDirectoryClient baseDirClient;
            switch (this.ParameterSetName)
            {
                case Constants.DirectoryParameterSetName:
                    CheckContextForObjectInput((AzureStorageContext)this.Context);
                    baseDirClient = this.ShareDirectoryClient;
                    break;

                case Constants.ShareNameParameterSetName:
                    // TODO: Share snapshot for oauth
                    NamingUtil.ValidateShareName(this.ShareName, false);
                    ShareServiceClient fileserviceClient = Util.GetTrack2FileServiceClient((AzureStorageContext)this.Context, ClientOptions);
                    baseDirClient = fileserviceClient.GetShareClient(this.ShareName).GetRootDirectoryClient();
                    break;

                case Constants.ShareParameterSetName:
                    CheckContextForObjectInput((AzureStorageContext)this.Context);
                    baseDirClient = this.ShareClient.GetRootDirectoryClient();
                    break;

                default:
                    throw new PSArgumentException(string.Format(CultureInfo.InvariantCulture, "Invalid parameter set name: {0}", this.ParameterSetName));
            }
            ShareDirectoryClient directoryToBeRemoved = baseDirClient.GetSubdirectoryClient(this.Path);

            if (this.ShouldProcess(Util.GetSnapshotQualifiedUri(directoryToBeRemoved.Uri), "Remove directory"))
            {
                directoryToBeRemoved.Delete(cancellationToken: this.CmdletCancellationToken);
            }

            if (this.PassThru)
            {
                WriteObject(new AzureStorageFileDirectory(directoryToBeRemoved, (AzureStorageContext)this.Context, shareDirectoryProperties: null, ClientOptions));
            }
        }
    }
}
