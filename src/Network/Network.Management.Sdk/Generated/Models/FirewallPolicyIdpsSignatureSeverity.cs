// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Network.Models
{

    /// <summary>
    /// Defines values for FirewallPolicyIdpsSignatureSeverity.
    /// </summary>


    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum FirewallPolicyIdpsSignatureSeverity
    {
        [System.Runtime.Serialization.EnumMember(Value = "1")]
        One,
        [System.Runtime.Serialization.EnumMember(Value = "2")]
        Two,
        [System.Runtime.Serialization.EnumMember(Value = "3")]
        Three
    }
    internal static class FirewallPolicyIdpsSignatureSeverityEnumExtension
    {
        internal static string ToSerializedValue(this FirewallPolicyIdpsSignatureSeverity? value)
        {
            return value == null ? null : ((FirewallPolicyIdpsSignatureSeverity)value).ToSerializedValue();
        }
        internal static string ToSerializedValue(this FirewallPolicyIdpsSignatureSeverity value)
        {
            switch( value )
            {
                case FirewallPolicyIdpsSignatureSeverity.One:
                    return "1";
                case FirewallPolicyIdpsSignatureSeverity.Two:
                    return "2";
                case FirewallPolicyIdpsSignatureSeverity.Three:
                    return "3";
            }
            return null;
        }
        internal static FirewallPolicyIdpsSignatureSeverity? ParseFirewallPolicyIdpsSignatureSeverity(this string value)
        {
            switch( value )
            {
                case "1":
                    return FirewallPolicyIdpsSignatureSeverity.One;
                case "2":
                    return FirewallPolicyIdpsSignatureSeverity.Two;
                case "3":
                    return FirewallPolicyIdpsSignatureSeverity.Three;
            }
            return null;
        }
    }
}