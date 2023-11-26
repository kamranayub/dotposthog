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
    ///  Class for testing ActionsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ActionsApiTests : IDisposable
    {
        private ActionsApi instance;

        public ActionsApiTests()
        {
            instance = new ActionsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ActionsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ActionsApi
            //Assert.IsType<ActionsApi>(instance);
        }

        /// <summary>
        /// Test ActionsCountRetrieve
        /// </summary>
        [Fact]
        public void ActionsCountRetrieveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //string projectId = null;
            //string format = null;
            //var response = instance.ActionsCountRetrieve(id, projectId, format);
            //Assert.IsType<Action>(response);
        }

        /// <summary>
        /// Test ActionsCreate
        /// </summary>
        [Fact]
        public void ActionsCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectId = null;
            //string format = null;
            //Action action = null;
            //var response = instance.ActionsCreate(projectId, format, action);
            //Assert.IsType<Action>(response);
        }

        /// <summary>
        /// Test ActionsDestroy
        /// </summary>
        [Fact]
        public void ActionsDestroyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //string projectId = null;
            //string format = null;
            //instance.ActionsDestroy(id, projectId, format);
        }

        /// <summary>
        /// Test ActionsList
        /// </summary>
        [Fact]
        public void ActionsListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectId = null;
            //string format = null;
            //int? limit = null;
            //int? offset = null;
            //var response = instance.ActionsList(projectId, format, limit, offset);
            //Assert.IsType<PaginatedActionList>(response);
        }

        /// <summary>
        /// Test ActionsPartialUpdate
        /// </summary>
        [Fact]
        public void ActionsPartialUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //string projectId = null;
            //string format = null;
            //PatchedAction patchedAction = null;
            //var response = instance.ActionsPartialUpdate(id, projectId, format, patchedAction);
            //Assert.IsType<Action>(response);
        }

        /// <summary>
        /// Test ActionsPeopleRetrieve
        /// </summary>
        [Fact]
        public void ActionsPeopleRetrieveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectId = null;
            //string format = null;
            //var response = instance.ActionsPeopleRetrieve(projectId, format);
            //Assert.IsType<Action>(response);
        }

        /// <summary>
        /// Test ActionsRetrieve
        /// </summary>
        [Fact]
        public void ActionsRetrieveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //string projectId = null;
            //string format = null;
            //var response = instance.ActionsRetrieve(id, projectId, format);
            //Assert.IsType<Action>(response);
        }

        /// <summary>
        /// Test ActionsUpdate
        /// </summary>
        [Fact]
        public void ActionsUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //string projectId = null;
            //string format = null;
            //Action action = null;
            //var response = instance.ActionsUpdate(id, projectId, format, action);
            //Assert.IsType<Action>(response);
        }
    }
}
