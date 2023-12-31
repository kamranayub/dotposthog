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
    ///  Class for testing DashboardTemplatesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class DashboardTemplatesApiTests : IDisposable
    {
        private DashboardTemplatesApi instance;

        public DashboardTemplatesApiTests()
        {
            instance = new DashboardTemplatesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DashboardTemplatesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' DashboardTemplatesApi
            //Assert.IsType<DashboardTemplatesApi>(instance);
        }

        /// <summary>
        /// Test DashboardTemplatesCreate
        /// </summary>
        [Fact]
        public void DashboardTemplatesCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectId = null;
            //PostHogDashboardTemplate postHogDashboardTemplate = null;
            //var response = instance.DashboardTemplatesCreate(projectId, postHogDashboardTemplate);
            //Assert.IsType<PostHogDashboardTemplate>(response);
        }

        /// <summary>
        /// Test DashboardTemplatesDestroy
        /// </summary>
        [Fact]
        public void DashboardTemplatesDestroyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string projectId = null;
            //instance.DashboardTemplatesDestroy(id, projectId);
        }

        /// <summary>
        /// Test DashboardTemplatesJsonSchemaRetrieve
        /// </summary>
        [Fact]
        public void DashboardTemplatesJsonSchemaRetrieveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectId = null;
            //var response = instance.DashboardTemplatesJsonSchemaRetrieve(projectId);
            //Assert.IsType<PostHogDashboardTemplate>(response);
        }

        /// <summary>
        /// Test DashboardTemplatesList
        /// </summary>
        [Fact]
        public void DashboardTemplatesListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectId = null;
            //int? limit = null;
            //int? offset = null;
            //var response = instance.DashboardTemplatesList(projectId, limit, offset);
            //Assert.IsType<PostHogPaginatedDashboardTemplateList>(response);
        }

        /// <summary>
        /// Test DashboardTemplatesPartialUpdate
        /// </summary>
        [Fact]
        public void DashboardTemplatesPartialUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string projectId = null;
            //PostHogPatchedDashboardTemplate postHogPatchedDashboardTemplate = null;
            //var response = instance.DashboardTemplatesPartialUpdate(id, projectId, postHogPatchedDashboardTemplate);
            //Assert.IsType<PostHogDashboardTemplate>(response);
        }

        /// <summary>
        /// Test DashboardTemplatesRetrieve
        /// </summary>
        [Fact]
        public void DashboardTemplatesRetrieveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string projectId = null;
            //var response = instance.DashboardTemplatesRetrieve(id, projectId);
            //Assert.IsType<PostHogDashboardTemplate>(response);
        }

        /// <summary>
        /// Test DashboardTemplatesUpdate
        /// </summary>
        [Fact]
        public void DashboardTemplatesUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string projectId = null;
            //PostHogDashboardTemplate postHogDashboardTemplate = null;
            //var response = instance.DashboardTemplatesUpdate(id, projectId, postHogDashboardTemplate);
            //Assert.IsType<PostHogDashboardTemplate>(response);
        }
    }
}
