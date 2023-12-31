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
    ///  Class for testing EventsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class EventsApiTests : IDisposable
    {
        private EventsApi instance;

        public EventsApiTests()
        {
            instance = new EventsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of EventsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' EventsApi
            //Assert.IsType<EventsApi>(instance);
        }

        /// <summary>
        /// Test EventsList
        /// </summary>
        [Fact]
        public void EventsListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectId = null;
            //DateTime? after = null;
            //DateTime? before = null;
            //int? distinctId = null;
            //string varEvent = null;
            //string format = null;
            //int? limit = null;
            //int? offset = null;
            //int? personId = null;
            //List<PostHogProperty> properties = null;
            //List<string> select = null;
            //List<string> where = null;
            //var response = instance.EventsList(projectId, after, before, distinctId, varEvent, format, limit, offset, personId, properties, select, where);
            //Assert.IsType<PostHogPaginatedClickhouseEventList>(response);
        }

        /// <summary>
        /// Test EventsRetrieve
        /// </summary>
        [Fact]
        public void EventsRetrieveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string projectId = null;
            //string format = null;
            //var response = instance.EventsRetrieve(id, projectId, format);
            //Assert.IsType<PostHogClickhouseEvent>(response);
        }

        /// <summary>
        /// Test EventsValuesRetrieve
        /// </summary>
        [Fact]
        public void EventsValuesRetrieveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectId = null;
            //string format = null;
            //var response = instance.EventsValuesRetrieve(projectId, format);
            //Assert.IsType<PostHogClickhouseEvent>(response);
        }
    }
}
