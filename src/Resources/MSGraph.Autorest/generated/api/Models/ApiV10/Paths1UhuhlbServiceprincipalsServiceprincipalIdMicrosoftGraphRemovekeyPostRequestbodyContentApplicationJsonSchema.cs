// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Extensions;

    public partial class Paths1UhuhlbServiceprincipalsServiceprincipalIdMicrosoftGraphRemovekeyPostRequestbodyContentApplicationJsonSchema :
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IPaths1UhuhlbServiceprincipalsServiceprincipalIdMicrosoftGraphRemovekeyPostRequestbodyContentApplicationJsonSchema,
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IPaths1UhuhlbServiceprincipalsServiceprincipalIdMicrosoftGraphRemovekeyPostRequestbodyContentApplicationJsonSchemaInternal
    {

        /// <summary>Backing field for <see cref="KeyId" /> property.</summary>
        private string _keyId;

        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public string KeyId { get => this._keyId; set => this._keyId = value; }

        /// <summary>Backing field for <see cref="Proof" /> property.</summary>
        private string _proof;

        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public string Proof { get => this._proof; set => this._proof = value; }

        /// <summary>
        /// Creates an new <see cref="Paths1UhuhlbServiceprincipalsServiceprincipalIdMicrosoftGraphRemovekeyPostRequestbodyContentApplicationJsonSchema"
        /// /> instance.
        /// </summary>
        public Paths1UhuhlbServiceprincipalsServiceprincipalIdMicrosoftGraphRemovekeyPostRequestbodyContentApplicationJsonSchema()
        {

        }
    }
    public partial interface IPaths1UhuhlbServiceprincipalsServiceprincipalIdMicrosoftGraphRemovekeyPostRequestbodyContentApplicationJsonSchema :
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IAssociativeArray<global::System.Object>
    {
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"keyId",
        PossibleTypes = new [] { typeof(string) })]
        string KeyId { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"proof",
        PossibleTypes = new [] { typeof(string) })]
        string Proof { get; set; }

    }
    internal partial interface IPaths1UhuhlbServiceprincipalsServiceprincipalIdMicrosoftGraphRemovekeyPostRequestbodyContentApplicationJsonSchemaInternal

    {
        string KeyId { get; set; }

        string Proof { get; set; }

    }
}