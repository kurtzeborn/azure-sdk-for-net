// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> The ManagedInstanceEncryptionProtectors service client. </summary>
    public partial class ManagedInstanceEncryptionProtectorsOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal ManagedInstanceEncryptionProtectorsRestOperations RestClient { get; }

        /// <summary> Initializes a new instance of ManagedInstanceEncryptionProtectorsOperations for mocking. </summary>
        protected ManagedInstanceEncryptionProtectorsOperations()
        {
        }

        /// <summary> Initializes a new instance of ManagedInstanceEncryptionProtectorsOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The subscription ID that identifies an Azure subscription. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal ManagedInstanceEncryptionProtectorsOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            RestClient = new ManagedInstanceEncryptionProtectorsRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Gets a managed instance encryption protector. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="encryptionProtectorName"> The name of the encryption protector to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ManagedInstanceEncryptionProtector>> GetAsync(string resourceGroupName, string managedInstanceName, EncryptionProtectorName encryptionProtectorName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceEncryptionProtectorsOperations.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceGroupName, managedInstanceName, encryptionProtectorName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a managed instance encryption protector. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="encryptionProtectorName"> The name of the encryption protector to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ManagedInstanceEncryptionProtector> Get(string resourceGroupName, string managedInstanceName, EncryptionProtectorName encryptionProtectorName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceEncryptionProtectorsOperations.Get");
            scope.Start();
            try
            {
                return RestClient.Get(resourceGroupName, managedInstanceName, encryptionProtectorName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a list of managed instance encryption protectors. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="managedInstanceName"/> is null. </exception>
        public virtual AsyncPageable<ManagedInstanceEncryptionProtector> ListByInstanceAsync(string resourceGroupName, string managedInstanceName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (managedInstanceName == null)
            {
                throw new ArgumentNullException(nameof(managedInstanceName));
            }

            async Task<Page<ManagedInstanceEncryptionProtector>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagedInstanceEncryptionProtectorsOperations.ListByInstance");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByInstanceAsync(resourceGroupName, managedInstanceName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ManagedInstanceEncryptionProtector>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagedInstanceEncryptionProtectorsOperations.ListByInstance");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByInstanceNextPageAsync(nextLink, resourceGroupName, managedInstanceName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets a list of managed instance encryption protectors. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="managedInstanceName"/> is null. </exception>
        public virtual Pageable<ManagedInstanceEncryptionProtector> ListByInstance(string resourceGroupName, string managedInstanceName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (managedInstanceName == null)
            {
                throw new ArgumentNullException(nameof(managedInstanceName));
            }

            Page<ManagedInstanceEncryptionProtector> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagedInstanceEncryptionProtectorsOperations.ListByInstance");
                scope.Start();
                try
                {
                    var response = RestClient.ListByInstance(resourceGroupName, managedInstanceName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ManagedInstanceEncryptionProtector> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagedInstanceEncryptionProtectorsOperations.ListByInstance");
                scope.Start();
                try
                {
                    var response = RestClient.ListByInstanceNextPage(nextLink, resourceGroupName, managedInstanceName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Revalidates an existing encryption protector. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="encryptionProtectorName"> The name of the encryption protector to be updated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="managedInstanceName"/> is null. </exception>
        public virtual async Task<ManagedInstanceEncryptionProtectorsRevalidateOperation> StartRevalidateAsync(string resourceGroupName, string managedInstanceName, EncryptionProtectorName encryptionProtectorName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (managedInstanceName == null)
            {
                throw new ArgumentNullException(nameof(managedInstanceName));
            }

            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceEncryptionProtectorsOperations.StartRevalidate");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.RevalidateAsync(resourceGroupName, managedInstanceName, encryptionProtectorName, cancellationToken).ConfigureAwait(false);
                return new ManagedInstanceEncryptionProtectorsRevalidateOperation(_clientDiagnostics, _pipeline, RestClient.CreateRevalidateRequest(resourceGroupName, managedInstanceName, encryptionProtectorName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Revalidates an existing encryption protector. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="encryptionProtectorName"> The name of the encryption protector to be updated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="managedInstanceName"/> is null. </exception>
        public virtual ManagedInstanceEncryptionProtectorsRevalidateOperation StartRevalidate(string resourceGroupName, string managedInstanceName, EncryptionProtectorName encryptionProtectorName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (managedInstanceName == null)
            {
                throw new ArgumentNullException(nameof(managedInstanceName));
            }

            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceEncryptionProtectorsOperations.StartRevalidate");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Revalidate(resourceGroupName, managedInstanceName, encryptionProtectorName, cancellationToken);
                return new ManagedInstanceEncryptionProtectorsRevalidateOperation(_clientDiagnostics, _pipeline, RestClient.CreateRevalidateRequest(resourceGroupName, managedInstanceName, encryptionProtectorName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates an existing encryption protector. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="encryptionProtectorName"> The name of the encryption protector to be updated. </param>
        /// <param name="parameters"> The requested encryption protector resource state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="managedInstanceName"/>, or <paramref name="parameters"/> is null. </exception>
        public virtual async Task<ManagedInstanceEncryptionProtectorsCreateOrUpdateOperation> StartCreateOrUpdateAsync(string resourceGroupName, string managedInstanceName, EncryptionProtectorName encryptionProtectorName, ManagedInstanceEncryptionProtector parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (managedInstanceName == null)
            {
                throw new ArgumentNullException(nameof(managedInstanceName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceEncryptionProtectorsOperations.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.CreateOrUpdateAsync(resourceGroupName, managedInstanceName, encryptionProtectorName, parameters, cancellationToken).ConfigureAwait(false);
                return new ManagedInstanceEncryptionProtectorsCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, managedInstanceName, encryptionProtectorName, parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates an existing encryption protector. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="encryptionProtectorName"> The name of the encryption protector to be updated. </param>
        /// <param name="parameters"> The requested encryption protector resource state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="managedInstanceName"/>, or <paramref name="parameters"/> is null. </exception>
        public virtual ManagedInstanceEncryptionProtectorsCreateOrUpdateOperation StartCreateOrUpdate(string resourceGroupName, string managedInstanceName, EncryptionProtectorName encryptionProtectorName, ManagedInstanceEncryptionProtector parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (managedInstanceName == null)
            {
                throw new ArgumentNullException(nameof(managedInstanceName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceEncryptionProtectorsOperations.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = RestClient.CreateOrUpdate(resourceGroupName, managedInstanceName, encryptionProtectorName, parameters, cancellationToken);
                return new ManagedInstanceEncryptionProtectorsCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, managedInstanceName, encryptionProtectorName, parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
