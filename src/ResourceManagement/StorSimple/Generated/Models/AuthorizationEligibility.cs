// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.StorSimple.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.StorSimple;
    using Microsoft.Azure.Management.StorSimple.Fluent;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for AuthorizationEligibility.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AuthorizationEligibility
    {
        [EnumMember(Value = "InEligible")]
        InEligible,
        [EnumMember(Value = "Eligible")]
        Eligible
    }
    internal static class AuthorizationEligibilityEnumExtension
    {
        internal static string ToSerializedValue(this AuthorizationEligibility? value)
        {
            return value == null ? null : ((AuthorizationEligibility)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this AuthorizationEligibility value)
        {
            switch( value )
            {
                case AuthorizationEligibility.InEligible:
                    return "InEligible";
                case AuthorizationEligibility.Eligible:
                    return "Eligible";
            }
            return null;
        }

        internal static AuthorizationEligibility? ParseAuthorizationEligibility(this string value)
        {
            switch( value )
            {
                case "InEligible":
                    return AuthorizationEligibility.InEligible;
                case "Eligible":
                    return AuthorizationEligibility.Eligible;
            }
            return null;
        }
    }
}