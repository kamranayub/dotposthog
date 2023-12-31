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
    public interface IGroupsTypesApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DotPostHog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="projectId">Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;PostHogGroupType&gt;</returns>
        List<PostHogGroupType> GroupsTypesList(string projectId, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DotPostHog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="projectId">Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;PostHogGroupType&gt;</returns>
        ApiResponse<List<PostHogGroupType>> GroupsTypesListWithHttpInfo(string projectId, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DotPostHog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="projectId">Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/.</param>
        /// <param name="postHogPatchedGroupType"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>PostHogGroupType</returns>
        PostHogGroupType GroupsTypesUpdateMetadataPartialUpdate(string projectId, PostHogPatchedGroupType postHogPatchedGroupType = default(PostHogPatchedGroupType), int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DotPostHog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="projectId">Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/.</param>
        /// <param name="postHogPatchedGroupType"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of PostHogGroupType</returns>
        ApiResponse<PostHogGroupType> GroupsTypesUpdateMetadataPartialUpdateWithHttpInfo(string projectId, PostHogPatchedGroupType postHogPatchedGroupType = default(PostHogPatchedGroupType), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IGroupsTypesApiAsync : IApiAccessor
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
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;PostHogGroupType&gt;</returns>
        System.Threading.Tasks.Task<List<PostHogGroupType>> GroupsTypesListAsync(string projectId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DotPostHog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="projectId">Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;PostHogGroupType&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<PostHogGroupType>>> GroupsTypesListWithHttpInfoAsync(string projectId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DotPostHog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="projectId">Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/.</param>
        /// <param name="postHogPatchedGroupType"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PostHogGroupType</returns>
        System.Threading.Tasks.Task<PostHogGroupType> GroupsTypesUpdateMetadataPartialUpdateAsync(string projectId, PostHogPatchedGroupType postHogPatchedGroupType = default(PostHogPatchedGroupType), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DotPostHog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="projectId">Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/.</param>
        /// <param name="postHogPatchedGroupType"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PostHogGroupType)</returns>
        System.Threading.Tasks.Task<ApiResponse<PostHogGroupType>> GroupsTypesUpdateMetadataPartialUpdateWithHttpInfoAsync(string projectId, PostHogPatchedGroupType postHogPatchedGroupType = default(PostHogPatchedGroupType), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IGroupsTypesApi : IGroupsTypesApiSync, IGroupsTypesApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class GroupsTypesApi : IGroupsTypesApi
    {
        private DotPostHog.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupsTypesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GroupsTypesApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupsTypesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GroupsTypesApi(string basePath)
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
        /// Initializes a new instance of the <see cref="GroupsTypesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public GroupsTypesApi(DotPostHog.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="GroupsTypesApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public GroupsTypesApi(DotPostHog.Client.ISynchronousClient client, DotPostHog.Client.IAsynchronousClient asyncClient, DotPostHog.Client.IReadableConfiguration configuration)
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
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;PostHogGroupType&gt;</returns>
        public List<PostHogGroupType> GroupsTypesList(string projectId, int operationIndex = 0)
        {
            DotPostHog.Client.ApiResponse<List<PostHogGroupType>> localVarResponse = GroupsTypesListWithHttpInfo(projectId);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="DotPostHog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="projectId">Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;PostHogGroupType&gt;</returns>
        public DotPostHog.Client.ApiResponse<List<PostHogGroupType>> GroupsTypesListWithHttpInfo(string projectId, int operationIndex = 0)
        {
            // verify the required parameter 'projectId' is set
            if (projectId == null)
            {
                throw new DotPostHog.Client.ApiException(400, "Missing required parameter 'projectId' when calling GroupsTypesApi->GroupsTypesList");
            }

            DotPostHog.Client.RequestOptions localVarRequestOptions = new DotPostHog.Client.RequestOptions();

            string[] _contentTypes = new string[] {
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

            localVarRequestOptions.PathParameters.Add("project_id", DotPostHog.Client.ClientUtils.ParameterToString(projectId)); // path parameter

            localVarRequestOptions.Operation = "GroupsTypesApi.GroupsTypesList";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Get<List<PostHogGroupType>>("/api/projects/{project_id}/groups_types/", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GroupsTypesList", localVarResponse);
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
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;PostHogGroupType&gt;</returns>
        public async System.Threading.Tasks.Task<List<PostHogGroupType>> GroupsTypesListAsync(string projectId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            DotPostHog.Client.ApiResponse<List<PostHogGroupType>> localVarResponse = await GroupsTypesListWithHttpInfoAsync(projectId, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="DotPostHog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="projectId">Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;PostHogGroupType&gt;)</returns>
        public async System.Threading.Tasks.Task<DotPostHog.Client.ApiResponse<List<PostHogGroupType>>> GroupsTypesListWithHttpInfoAsync(string projectId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'projectId' is set
            if (projectId == null)
            {
                throw new DotPostHog.Client.ApiException(400, "Missing required parameter 'projectId' when calling GroupsTypesApi->GroupsTypesList");
            }


            DotPostHog.Client.RequestOptions localVarRequestOptions = new DotPostHog.Client.RequestOptions();

            string[] _contentTypes = new string[] {
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

            localVarRequestOptions.PathParameters.Add("project_id", DotPostHog.Client.ClientUtils.ParameterToString(projectId)); // path parameter

            localVarRequestOptions.Operation = "GroupsTypesApi.GroupsTypesList";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<List<PostHogGroupType>>("/api/projects/{project_id}/groups_types/", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GroupsTypesList", localVarResponse);
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
        /// <param name="postHogPatchedGroupType"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>PostHogGroupType</returns>
        public PostHogGroupType GroupsTypesUpdateMetadataPartialUpdate(string projectId, PostHogPatchedGroupType postHogPatchedGroupType = default(PostHogPatchedGroupType), int operationIndex = 0)
        {
            DotPostHog.Client.ApiResponse<PostHogGroupType> localVarResponse = GroupsTypesUpdateMetadataPartialUpdateWithHttpInfo(projectId, postHogPatchedGroupType);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="DotPostHog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="projectId">Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/.</param>
        /// <param name="postHogPatchedGroupType"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of PostHogGroupType</returns>
        public DotPostHog.Client.ApiResponse<PostHogGroupType> GroupsTypesUpdateMetadataPartialUpdateWithHttpInfo(string projectId, PostHogPatchedGroupType postHogPatchedGroupType = default(PostHogPatchedGroupType), int operationIndex = 0)
        {
            // verify the required parameter 'projectId' is set
            if (projectId == null)
            {
                throw new DotPostHog.Client.ApiException(400, "Missing required parameter 'projectId' when calling GroupsTypesApi->GroupsTypesUpdateMetadataPartialUpdate");
            }

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

            localVarRequestOptions.PathParameters.Add("project_id", DotPostHog.Client.ClientUtils.ParameterToString(projectId)); // path parameter
            localVarRequestOptions.Data = postHogPatchedGroupType;

            localVarRequestOptions.Operation = "GroupsTypesApi.GroupsTypesUpdateMetadataPartialUpdate";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Patch<PostHogGroupType>("/api/projects/{project_id}/groups_types/update_metadata/", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GroupsTypesUpdateMetadataPartialUpdate", localVarResponse);
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
        /// <param name="postHogPatchedGroupType"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PostHogGroupType</returns>
        public async System.Threading.Tasks.Task<PostHogGroupType> GroupsTypesUpdateMetadataPartialUpdateAsync(string projectId, PostHogPatchedGroupType postHogPatchedGroupType = default(PostHogPatchedGroupType), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            DotPostHog.Client.ApiResponse<PostHogGroupType> localVarResponse = await GroupsTypesUpdateMetadataPartialUpdateWithHttpInfoAsync(projectId, postHogPatchedGroupType, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="DotPostHog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="projectId">Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/.</param>
        /// <param name="postHogPatchedGroupType"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PostHogGroupType)</returns>
        public async System.Threading.Tasks.Task<DotPostHog.Client.ApiResponse<PostHogGroupType>> GroupsTypesUpdateMetadataPartialUpdateWithHttpInfoAsync(string projectId, PostHogPatchedGroupType postHogPatchedGroupType = default(PostHogPatchedGroupType), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'projectId' is set
            if (projectId == null)
            {
                throw new DotPostHog.Client.ApiException(400, "Missing required parameter 'projectId' when calling GroupsTypesApi->GroupsTypesUpdateMetadataPartialUpdate");
            }


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

            localVarRequestOptions.PathParameters.Add("project_id", DotPostHog.Client.ClientUtils.ParameterToString(projectId)); // path parameter
            localVarRequestOptions.Data = postHogPatchedGroupType;

            localVarRequestOptions.Operation = "GroupsTypesApi.GroupsTypesUpdateMetadataPartialUpdate";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PatchAsync<PostHogGroupType>("/api/projects/{project_id}/groups_types/update_metadata/", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GroupsTypesUpdateMetadataPartialUpdate", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
