// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Store.Models
{
    using Azure;
    using DataLake;
    using Management;
    using Azure;
    using Management;
    using DataLake;
    using Store;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Store;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for DataLakeStoreAccountStatus.
    /// </summary>
    [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DataLakeStoreAccountStatus
    {
        [EnumMember(Value = "Failed")]
        Failed,
        [EnumMember(Value = "Creating")]
        Creating,
        [EnumMember(Value = "Running")]
        Running,
        [EnumMember(Value = "Succeeded")]
        Succeeded,
        [EnumMember(Value = "Patching")]
        Patching,
        [EnumMember(Value = "Suspending")]
        Suspending,
        [EnumMember(Value = "Resuming")]
        Resuming,
        [EnumMember(Value = "Deleting")]
        Deleting,
        [EnumMember(Value = "Deleted")]
        Deleted
    }
}

