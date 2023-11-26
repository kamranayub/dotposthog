/*
 * PostHog API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using DotPostHog.Client;
using DotPostHog.Api;
// uncomment below to import models
//using DotPostHog.Model;

namespace DotPostHog.Test.Api
{
    /// <summary>
    ///  Class for testing PluginConfigsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class PluginConfigsApiTests : IDisposable
    {
        private PluginConfigsApi instance;

        public PluginConfigsApiTests()
        {
            instance = new PluginConfigsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PluginConfigsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' PluginConfigsApi
            //Assert.IsType<PluginConfigsApi>(instance);
        }

        /// <summary>
        /// Test PluginConfigsCreate
        /// </summary>
        [Fact]
        public void PluginConfigsCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectId = null;
            //PostHogPluginConfig postHogPluginConfig = null;
            //var response = instance.PluginConfigsCreate(projectId, postHogPluginConfig);
            //Assert.IsType<PostHogPluginConfig>(response);
        }

        /// <summary>
        /// Test PluginConfigsDestroy
        /// </summary>
        [Fact]
        public void PluginConfigsDestroyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //string projectId = null;
            //instance.PluginConfigsDestroy(id, projectId);
        }

        /// <summary>
        /// Test PluginConfigsFrontendRetrieve
        /// </summary>
        [Fact]
        public void PluginConfigsFrontendRetrieveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //string projectId = null;
            //var response = instance.PluginConfigsFrontendRetrieve(id, projectId);
            //Assert.IsType<PostHogPluginConfig>(response);
        }

        /// <summary>
        /// Test PluginConfigsJobCreate
        /// </summary>
        [Fact]
        public void PluginConfigsJobCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //string projectId = null;
            //PostHogPluginConfig postHogPluginConfig = null;
            //var response = instance.PluginConfigsJobCreate(id, projectId, postHogPluginConfig);
            //Assert.IsType<PostHogPluginConfig>(response);
        }

        /// <summary>
        /// Test PluginConfigsList
        /// </summary>
        [Fact]
        public void PluginConfigsListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectId = null;
            //int? limit = null;
            //int? offset = null;
            //var response = instance.PluginConfigsList(projectId, limit, offset);
            //Assert.IsType<PostHogPaginatedPluginConfigList>(response);
        }

        /// <summary>
        /// Test PluginConfigsLogsList
        /// </summary>
        [Fact]
        public void PluginConfigsLogsListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string parentLookupPluginConfigId = null;
            //string projectId = null;
            //int? limit = null;
            //int? offset = null;
            //var response = instance.PluginConfigsLogsList(parentLookupPluginConfigId, projectId, limit, offset);
            //Assert.IsType<PostHogPaginatedPluginLogEntryList>(response);
        }

        /// <summary>
        /// Test PluginConfigsPartialUpdate
        /// </summary>
        [Fact]
        public void PluginConfigsPartialUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //string projectId = null;
            //PostHogPatchedPluginConfig postHogPatchedPluginConfig = null;
            //var response = instance.PluginConfigsPartialUpdate(id, projectId, postHogPatchedPluginConfig);
            //Assert.IsType<PostHogPluginConfig>(response);
        }

        /// <summary>
        /// Test PluginConfigsRearrangePartialUpdate
        /// </summary>
        [Fact]
        public void PluginConfigsRearrangePartialUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectId = null;
            //PostHogPatchedPluginConfig postHogPatchedPluginConfig = null;
            //var response = instance.PluginConfigsRearrangePartialUpdate(projectId, postHogPatchedPluginConfig);
            //Assert.IsType<PostHogPluginConfig>(response);
        }

        /// <summary>
        /// Test PluginConfigsRetrieve
        /// </summary>
        [Fact]
        public void PluginConfigsRetrieveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //string projectId = null;
            //var response = instance.PluginConfigsRetrieve(id, projectId);
            //Assert.IsType<PostHogPluginConfig>(response);
        }

        /// <summary>
        /// Test PluginConfigsUpdate
        /// </summary>
        [Fact]
        public void PluginConfigsUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //string projectId = null;
            //PostHogPluginConfig postHogPluginConfig = null;
            //var response = instance.PluginConfigsUpdate(id, projectId, postHogPluginConfig);
            //Assert.IsType<PostHogPluginConfig>(response);
        }
    }
}
