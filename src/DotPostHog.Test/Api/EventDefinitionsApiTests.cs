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
    ///  Class for testing EventDefinitionsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class EventDefinitionsApiTests : IDisposable
    {
        private EventDefinitionsApi instance;

        public EventDefinitionsApiTests()
        {
            instance = new EventDefinitionsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of EventDefinitionsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' EventDefinitionsApi
            //Assert.IsType<EventDefinitionsApi>(instance);
        }

        /// <summary>
        /// Test EventDefinitionsDestroy
        /// </summary>
        [Fact]
        public void EventDefinitionsDestroyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string projectId = null;
            //instance.EventDefinitionsDestroy(id, projectId);
        }

        /// <summary>
        /// Test EventDefinitionsList
        /// </summary>
        [Fact]
        public void EventDefinitionsListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectId = null;
            //int? limit = null;
            //int? offset = null;
            //var response = instance.EventDefinitionsList(projectId, limit, offset);
            //Assert.IsType<PostHogPaginatedEnterpriseEventDefinitionList>(response);
        }

        /// <summary>
        /// Test EventDefinitionsPartialUpdate
        /// </summary>
        [Fact]
        public void EventDefinitionsPartialUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string projectId = null;
            //PostHogPatchedEnterpriseEventDefinition postHogPatchedEnterpriseEventDefinition = null;
            //var response = instance.EventDefinitionsPartialUpdate(id, projectId, postHogPatchedEnterpriseEventDefinition);
            //Assert.IsType<PostHogEnterpriseEventDefinition>(response);
        }

        /// <summary>
        /// Test EventDefinitionsRetrieve
        /// </summary>
        [Fact]
        public void EventDefinitionsRetrieveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string projectId = null;
            //var response = instance.EventDefinitionsRetrieve(id, projectId);
            //Assert.IsType<PostHogEnterpriseEventDefinition>(response);
        }

        /// <summary>
        /// Test EventDefinitionsUpdate
        /// </summary>
        [Fact]
        public void EventDefinitionsUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string projectId = null;
            //PostHogEnterpriseEventDefinition postHogEnterpriseEventDefinition = null;
            //var response = instance.EventDefinitionsUpdate(id, projectId, postHogEnterpriseEventDefinition);
            //Assert.IsType<PostHogEnterpriseEventDefinition>(response);
        }
    }
}
