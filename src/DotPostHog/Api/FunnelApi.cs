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
    public interface IFunnelApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DotPostHog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="projectId">Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/.</param>
        /// <param name="format"> (optional)</param>
        /// <param name="funnel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>FunnelStepsResults</returns>
        FunnelStepsResults Funnels(string projectId, string format = default(string), Funnel funnel = default(Funnel), int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DotPostHog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="projectId">Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/.</param>
        /// <param name="format"> (optional)</param>
        /// <param name="funnel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of FunnelStepsResults</returns>
        ApiResponse<FunnelStepsResults> FunnelsWithHttpInfo(string projectId, string format = default(string), Funnel funnel = default(Funnel), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IFunnelApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DotPostHog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="projectId">Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/.</param>
        /// <param name="format"> (optional)</param>
        /// <param name="funnel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of FunnelStepsResults</returns>
        System.Threading.Tasks.Task<FunnelStepsResults> FunnelsAsync(string projectId, string format = default(string), Funnel funnel = default(Funnel), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DotPostHog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="projectId">Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/.</param>
        /// <param name="format"> (optional)</param>
        /// <param name="funnel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (FunnelStepsResults)</returns>
        System.Threading.Tasks.Task<ApiResponse<FunnelStepsResults>> FunnelsWithHttpInfoAsync(string projectId, string format = default(string), Funnel funnel = default(Funnel), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IFunnelApi : IFunnelApiSync, IFunnelApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class FunnelApi : IFunnelApi
    {
        private DotPostHog.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="FunnelApi"/> class.
        /// </summary>
        /// <returns></returns>
        public FunnelApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunnelApi"/> class.
        /// </summary>
        /// <returns></returns>
        public FunnelApi(string basePath)
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
        /// Initializes a new instance of the <see cref="FunnelApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public FunnelApi(DotPostHog.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="FunnelApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public FunnelApi(DotPostHog.Client.ISynchronousClient client, DotPostHog.Client.IAsynchronousClient asyncClient, DotPostHog.Client.IReadableConfiguration configuration)
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
        ///  
        /// </summary>
        /// <exception cref="DotPostHog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="projectId">Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/.</param>
        /// <param name="format"> (optional)</param>
        /// <param name="funnel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>FunnelStepsResults</returns>
        public FunnelStepsResults Funnels(string projectId, string format = default(string), Funnel funnel = default(Funnel), int operationIndex = 0)
        {
            DotPostHog.Client.ApiResponse<FunnelStepsResults> localVarResponse = FunnelsWithHttpInfo(projectId, format, funnel);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="DotPostHog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="projectId">Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/.</param>
        /// <param name="format"> (optional)</param>
        /// <param name="funnel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of FunnelStepsResults</returns>
        public DotPostHog.Client.ApiResponse<FunnelStepsResults> FunnelsWithHttpInfo(string projectId, string format = default(string), Funnel funnel = default(Funnel), int operationIndex = 0)
        {
            // verify the required parameter 'projectId' is set
            if (projectId == null)
            {
                throw new DotPostHog.Client.ApiException(400, "Missing required parameter 'projectId' when calling FunnelApi->Funnels");
            }

            DotPostHog.Client.RequestOptions localVarRequestOptions = new DotPostHog.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json",
                "text/csv"
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

            localVarRequestOptions.PathParameters.Add("project_id", DotPostHog.Client.ClientUtils.ParameterToString(projectId)); // path parameter
            if (format != null)
            {
                localVarRequestOptions.QueryParameters.Add(DotPostHog.Client.ClientUtils.ParameterToMultiMap("", "format", format));
            }
            localVarRequestOptions.Data = funnel;

            localVarRequestOptions.Operation = "FunnelApi.Funnels";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Post<FunnelStepsResults>("/api/projects/{project_id}/insights/funnel/", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Funnels", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="DotPostHog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="projectId">Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/.</param>
        /// <param name="format"> (optional)</param>
        /// <param name="funnel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of FunnelStepsResults</returns>
        public async System.Threading.Tasks.Task<FunnelStepsResults> FunnelsAsync(string projectId, string format = default(string), Funnel funnel = default(Funnel), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            DotPostHog.Client.ApiResponse<FunnelStepsResults> localVarResponse = await FunnelsWithHttpInfoAsync(projectId, format, funnel, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="DotPostHog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="projectId">Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/.</param>
        /// <param name="format"> (optional)</param>
        /// <param name="funnel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (FunnelStepsResults)</returns>
        public async System.Threading.Tasks.Task<DotPostHog.Client.ApiResponse<FunnelStepsResults>> FunnelsWithHttpInfoAsync(string projectId, string format = default(string), Funnel funnel = default(Funnel), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'projectId' is set
            if (projectId == null)
            {
                throw new DotPostHog.Client.ApiException(400, "Missing required parameter 'projectId' when calling FunnelApi->Funnels");
            }


            DotPostHog.Client.RequestOptions localVarRequestOptions = new DotPostHog.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json",
                "text/csv"
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

            localVarRequestOptions.PathParameters.Add("project_id", DotPostHog.Client.ClientUtils.ParameterToString(projectId)); // path parameter
            if (format != null)
            {
                localVarRequestOptions.QueryParameters.Add(DotPostHog.Client.ClientUtils.ParameterToMultiMap("", "format", format));
            }
            localVarRequestOptions.Data = funnel;

            localVarRequestOptions.Operation = "FunnelApi.Funnels";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<FunnelStepsResults>("/api/projects/{project_id}/insights/funnel/", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Funnels", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
