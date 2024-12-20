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

using Microsoft.Azure.Commands.Common.Authentication.Models;
using Microsoft.Azure.Commands.Profile.Models;
// TODO: Remove IfDef
#if NETSTANDARD
using Microsoft.Azure.Commands.Profile.Models.Core;
#endif
using Microsoft.Azure.Commands.Profile.Properties;
using Microsoft.Azure.Commands.ResourceManager.Common;
using Microsoft.WindowsAzure.Commands.Common;
using System;
using System.Management.Automation;
using Microsoft.Azure.Commands.Common.Authentication;
using Microsoft.Azure.Commands.Common.Authentication.Abstractions;
using Microsoft.Azure.Commands.Common;

namespace Microsoft.Azure.Commands.Profile
{
    /// <summary>
    /// Saves Microsoft Azure profile.
    /// </summary>
    [Cmdlet("Save", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "Context", SupportsShouldProcess = true), OutputType(typeof(PSAzureProfile))]
    [Alias("Save-" + ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "Profile")]
    public class SaveAzureRMContextCommand : AzureRMCmdlet
    {
        [Parameter(Mandatory = false, Position = 0, ValueFromPipeline = true)]
        public AzureRmProfile Profile { get; set; }

        [Parameter(Mandatory = true, Position = 1)]
        public string Path { get; set; }

        [Parameter(Mandatory=false, HelpMessage="Overwrite the given file if it exists")]
        public SwitchParameter Force { get; set; }

        [Parameter(Mandatory = false, HelpMessage = "Export the credentials to the file")]
        public SwitchParameter WithCredential { get; set; }

        public override void ExecuteCmdlet()
        {
            Path = this.ResolveUserPath(Path);
            if (Profile != null)
            {
                if (ShouldProcess(string.Format(Resources.ProfileArgumentWrite, Path),
                    string.Format(Resources.ProfileWriteWarning, Path),
                    string.Empty))
                {
                    if (!AzureSession.Instance.DataStore.FileExists(Path) || Force ||
                        ShouldContinue(string.Format(Resources.FileOverwriteMessage, Path), 
                        Resources.FileOverwriteCaption))
                    {
                        var profile = Profile;
                        if (WithCredential.IsPresent)
                        {
                            WriteWarning(string.Format(Resources.ProfileCredentialsWriteWarning, Path));
                            profile = profile.RefillCredentialsFromKeyStore();
                        }
                        profile.Save(Path);
                        WriteVerbose(string.Format(Resources.ProfileArgumentSaved, Path));
                    }
                }
            }
            else
            {
                if (ShouldProcess(string.Format(Resources.ProfileCurrentWrite, Path),
                    string.Format(Resources.ProfileWriteWarning, Path), string.Empty))
                {
                    if (AzureRmProfileProvider.Instance.Profile == null)
                    {
                        throw new ArgumentException(Resources.AzureProfileMustNotBeNull);
                    }

                    if (!AzureSession.Instance.DataStore.FileExists(Path) || Force.IsPresent ||
                        ShouldContinue(string.Format(Resources.FileOverwriteMessage, Path), 
                        Resources.FileOverwriteCaption))
                    {
                        var profile = AzureRmProfileProvider.Instance.GetProfile<AzureRmProfile>();
                        if (WithCredential.IsPresent)
                        {
                            WriteWarning(string.Format(Resources.ProfileCredentialsWriteWarning, Path));
                            profile = profile.RefillCredentialsFromKeyStore();
                        }
                        profile.Save(Path);
                        WriteVerbose(string.Format(Resources.ProfileCurrentSaved, Path));
                    }
                }
            }

        }

    }
}
