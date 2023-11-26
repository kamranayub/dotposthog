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
    ///  Class for testing ExperimentsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ExperimentsApiTests : IDisposable
    {
        private ExperimentsApi instance;

        public ExperimentsApiTests()
        {
            instance = new ExperimentsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ExperimentsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ExperimentsApi
            //Assert.IsType<ExperimentsApi>(instance);
        }

        /// <summary>
        /// Test ExperimentsCreate
        /// </summary>
        [Fact]
        public void ExperimentsCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectId = null;
            //PostHogExperiment postHogExperiment = null;
            //var response = instance.ExperimentsCreate(projectId, postHogExperiment);
            //Assert.IsType<PostHogExperiment>(response);
        }

        /// <summary>
        /// Test ExperimentsDestroy
        /// </summary>
        [Fact]
        public void ExperimentsDestroyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //string projectId = null;
            //instance.ExperimentsDestroy(id, projectId);
        }

        /// <summary>
        /// Test ExperimentsList
        /// </summary>
        [Fact]
        public void ExperimentsListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectId = null;
            //int? limit = null;
            //int? offset = null;
            //var response = instance.ExperimentsList(projectId, limit, offset);
            //Assert.IsType<PostHogPaginatedExperimentList>(response);
        }

        /// <summary>
        /// Test ExperimentsPartialUpdate
        /// </summary>
        [Fact]
        public void ExperimentsPartialUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //string projectId = null;
            //PostHogPatchedExperiment postHogPatchedExperiment = null;
            //var response = instance.ExperimentsPartialUpdate(id, projectId, postHogPatchedExperiment);
            //Assert.IsType<PostHogExperiment>(response);
        }

        /// <summary>
        /// Test ExperimentsRequiresFlagImplementationRetrieve
        /// </summary>
        [Fact]
        public void ExperimentsRequiresFlagImplementationRetrieveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectId = null;
            //var response = instance.ExperimentsRequiresFlagImplementationRetrieve(projectId);
            //Assert.IsType<PostHogExperiment>(response);
        }

        /// <summary>
        /// Test ExperimentsResultsRetrieve
        /// </summary>
        [Fact]
        public void ExperimentsResultsRetrieveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //string projectId = null;
            //var response = instance.ExperimentsResultsRetrieve(id, projectId);
            //Assert.IsType<PostHogExperiment>(response);
        }

        /// <summary>
        /// Test ExperimentsRetrieve
        /// </summary>
        [Fact]
        public void ExperimentsRetrieveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //string projectId = null;
            //var response = instance.ExperimentsRetrieve(id, projectId);
            //Assert.IsType<PostHogExperiment>(response);
        }

        /// <summary>
        /// Test ExperimentsSecondaryResultsRetrieve
        /// </summary>
        [Fact]
        public void ExperimentsSecondaryResultsRetrieveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //string projectId = null;
            //var response = instance.ExperimentsSecondaryResultsRetrieve(id, projectId);
            //Assert.IsType<PostHogExperiment>(response);
        }

        /// <summary>
        /// Test ExperimentsUpdate
        /// </summary>
        [Fact]
        public void ExperimentsUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //string projectId = null;
            //PostHogExperiment postHogExperiment = null;
            //var response = instance.ExperimentsUpdate(id, projectId, postHogExperiment);
            //Assert.IsType<PostHogExperiment>(response);
        }
    }
}
