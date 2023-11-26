/*
 * PostHog API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using DotPostHog.Client;
using DotPostHog.Model;

namespace DotPostHog.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IResetTokenApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Projects for the current organization.
        /// </remarks>
        /// <exception cref="DotPostHog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">A unique integer value identifying this team.</param>
        /// <param name="patchedTeam"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Team</returns>
        Team ResetTokenPartialUpdate(int id, PatchedTeam patchedTeam = default(PatchedTeam), int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Projects for the current organization.
        /// </remarks>
        /// <exception cref="DotPostHog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">A unique integer value identifying this team.</param>
        /// <param name="patchedTeam"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Team</returns>
        ApiResponse<Team> ResetTokenPartialUpdateWithHttpInfo(int id, PatchedTeam patchedTeam = default(PatchedTeam), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IResetTokenApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Projects for the current organization.
        /// </remarks>
        /// <exception cref="DotPostHog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">A unique integer value identifying this team.</param>
        /// <param name="patchedTeam"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Team</returns>
        System.Threading.Tasks.Task<Team> ResetTokenPartialUpdateAsync(int id, PatchedTeam patchedTeam = default(PatchedTeam), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Projects for the current organization.
        /// </remarks>
        /// <exception cref="DotPostHog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">A unique integer value identifying this team.</param>
        /// <param name="patchedTeam"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Team)</returns>
        System.Threading.Tasks.Task<ApiResponse<Team>> ResetTokenPartialUpdateWithHttpInfoAsync(int id, PatchedTeam patchedTeam = default(PatchedTeam), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IResetTokenApi : IResetTokenApiSync, IResetTokenApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ResetTokenApi : IResetTokenApi
    {
        private DotPostHog.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ResetTokenApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ResetTokenApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResetTokenApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ResetTokenApi(string basePath)
        {
            this.Configuration = DotPostHog.Client.Configuration.MergeConfigurations(
                DotPostHog.Client.GlobalConfiguration.Instance,
                new DotPostHog.Client.Configuration { BasePath = basePath }
            );
            this.Client = new DotPostHog.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new DotPostHog.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = DotPostHog.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResetTokenApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ResetTokenApi(DotPostHog.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = DotPostHog.Client.Configuration.MergeConfigurations(
                DotPostHog.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new DotPostHog.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new DotPostHog.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = DotPostHog.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResetTokenApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public ResetTokenApi(DotPostHog.Client.ISynchronousClient client, DotPostHog.Client.IAsynchronousClient asyncClient, DotPostHog.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = DotPostHog.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public DotPostHog.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public DotPostHog.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public DotPostHog.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public DotPostHog.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        ///  Projects for the current organization.
        /// </summary>
        /// <exception cref="DotPostHog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">A unique integer value identifying this team.</param>
        /// <param name="patchedTeam"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Team</returns>
        public Team ResetTokenPartialUpdate(int id, PatchedTeam patchedTeam = default(PatchedTeam), int operationIndex = 0)
        {
            DotPostHog.Client.ApiResponse<Team> localVarResponse = ResetTokenPartialUpdateWithHttpInfo(id, patchedTeam);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Projects for the current organization.
        /// </summary>
        /// <exception cref="DotPostHog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">A unique integer value identifying this team.</param>
        /// <param name="patchedTeam"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Team</returns>
        public DotPostHog.Client.ApiResponse<Team> ResetTokenPartialUpdateWithHttpInfo(int id, PatchedTeam patchedTeam = default(PatchedTeam), int operationIndex = 0)
        {
            DotPostHog.Client.RequestOptions localVarRequestOptions = new DotPostHog.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json",
                "application/x-www-form-urlencoded",
                "multipart/form-data"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = DotPostHog.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = DotPostHog.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("id", DotPostHog.Client.ClientUtils.ParameterToString(id)); // path parameter
            localVarRequestOptions.Data = patchedTeam;

            localVarRequestOptions.Operation = "ResetTokenApi.ResetTokenPartialUpdate";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Patch<Team>("/api/projects/{id}/reset_token/", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ResetTokenPartialUpdate", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Projects for the current organization.
        /// </summary>
        /// <exception cref="DotPostHog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">A unique integer value identifying this team.</param>
        /// <param name="patchedTeam"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Team</returns>
        public async System.Threading.Tasks.Task<Team> ResetTokenPartialUpdateAsync(int id, PatchedTeam patchedTeam = default(PatchedTeam), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            DotPostHog.Client.ApiResponse<Team> localVarResponse = await ResetTokenPartialUpdateWithHttpInfoAsync(id, patchedTeam, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Projects for the current organization.
        /// </summary>
        /// <exception cref="DotPostHog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">A unique integer value identifying this team.</param>
        /// <param name="patchedTeam"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Team)</returns>
        public async System.Threading.Tasks.Task<DotPostHog.Client.ApiResponse<Team>> ResetTokenPartialUpdateWithHttpInfoAsync(int id, PatchedTeam patchedTeam = default(PatchedTeam), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            DotPostHog.Client.RequestOptions localVarRequestOptions = new DotPostHog.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json", 
                "application/x-www-form-urlencoded", 
                "multipart/form-data"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = DotPostHog.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = DotPostHog.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("id", DotPostHog.Client.ClientUtils.ParameterToString(id)); // path parameter
            localVarRequestOptions.Data = patchedTeam;

            localVarRequestOptions.Operation = "ResetTokenApi.ResetTokenPartialUpdate";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PatchAsync<Team>("/api/projects/{id}/reset_token/", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ResetTokenPartialUpdate", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}