// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Synapse
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// SqlPoolDataWarehouseUserActivities operations.
    /// </summary>
    public partial interface ISqlPoolDataWarehouseUserActivities
    {
        /// <summary>
        /// Get SQL pool user activities
        /// </summary>
        /// <remarks>
        /// Gets the user activities of a SQL pool which includes running and
        /// suspended queries
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='workspaceName'>
        /// The name of the workspace
        /// </param>
        /// <param name='sqlPoolName'>
        /// SQL pool name
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<DataWarehouseUserActivities>> GetWithHttpMessagesAsync(string resourceGroupName, string workspaceName, string sqlPoolName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
