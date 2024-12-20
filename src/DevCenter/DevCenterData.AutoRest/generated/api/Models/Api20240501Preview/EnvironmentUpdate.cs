// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Runtime.Extensions;

    /// <summary>Properties of an environment.</summary>
    public partial class EnvironmentUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IEnvironmentUpdate,
        Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IEnvironmentUpdateInternal
    {

        /// <summary>Backing field for <see cref="ExpirationDate" /> property.</summary>
        private global::System.DateTime? _expirationDate;

        /// <summary>
        /// The time the expiration date will be triggered (UTC), after which the
        /// environment and associated resources will be deleted.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.PropertyOrigin.Owned)]
        public global::System.DateTime? ExpirationDate { get => this._expirationDate; set => this._expirationDate = value; }

        /// <summary>Backing field for <see cref="Parameter" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IEnvironmentUpdateParameters _parameter;

        /// <summary>Parameters object for the environment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IEnvironmentUpdateParameters Parameter { get => (this._parameter = this._parameter ?? new Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.EnvironmentUpdateParameters()); set => this._parameter = value; }

        /// <summary>Creates an new <see cref="EnvironmentUpdate" /> instance.</summary>
        public EnvironmentUpdate()
        {

        }
    }
    /// Properties of an environment.
    public partial interface IEnvironmentUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The time the expiration date will be triggered (UTC), after which the
        /// environment and associated resources will be deleted.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The time the expiration date will be triggered (UTC), after which the
        environment and associated resources will be deleted.",
        SerializedName = @"expirationDate",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? ExpirationDate { get; set; }
        /// <summary>Parameters object for the environment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Parameters object for the environment.",
        SerializedName = @"parameters",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IEnvironmentUpdateParameters) })]
        Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IEnvironmentUpdateParameters Parameter { get; set; }

    }
    /// Properties of an environment.
    internal partial interface IEnvironmentUpdateInternal

    {
        /// <summary>
        /// The time the expiration date will be triggered (UTC), after which the
        /// environment and associated resources will be deleted.
        /// </summary>
        global::System.DateTime? ExpirationDate { get; set; }
        /// <summary>Parameters object for the environment.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IEnvironmentUpdateParameters Parameter { get; set; }

    }
}