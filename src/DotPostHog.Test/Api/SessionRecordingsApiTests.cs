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
    ///  Class for testing SessionRecordingsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class SessionRecordingsApiTests : IDisposable
    {
        private SessionRecordingsApi instance;

        public SessionRecordingsApiTests()
        {
            instance = new SessionRecordingsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SessionRecordingsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' SessionRecordingsApi
            //Assert.IsType<SessionRecordingsApi>(instance);
        }

        /// <summary>
        /// Test SessionRecordingsDestroy
        /// </summary>
        [Fact]
        public void SessionRecordingsDestroyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //string projectId = null;
            //instance.SessionRecordingsDestroy(id, projectId);
        }

        /// <summary>
        /// Test SessionRecordingsList
        /// </summary>
        [Fact]
        public void SessionRecordingsListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectId = null;
            //int? limit = null;
            //int? offset = null;
            //var response = instance.SessionRecordingsList(projectId, limit, offset);
            //Assert.IsType<PaginatedSessionRecordingList>(response);
        }

        /// <summary>
        /// Test SessionRecordingsMatchingEventsRetrieve
        /// </summary>
        [Fact]
        public void SessionRecordingsMatchingEventsRetrieveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectId = null;
            //var response = instance.SessionRecordingsMatchingEventsRetrieve(projectId);
            //Assert.IsType<SessionRecording>(response);
        }

        /// <summary>
        /// Test SessionRecordingsPersistCreate
        /// </summary>
        [Fact]
        public void SessionRecordingsPersistCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //string projectId = null;
            //SessionRecording sessionRecording = null;
            //var response = instance.SessionRecordingsPersistCreate(id, projectId, sessionRecording);
            //Assert.IsType<SessionRecording>(response);
        }

        /// <summary>
        /// Test SessionRecordingsPropertiesRetrieve
        /// </summary>
        [Fact]
        public void SessionRecordingsPropertiesRetrieveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectId = null;
            //var response = instance.SessionRecordingsPropertiesRetrieve(projectId);
            //Assert.IsType<SessionRecording>(response);
        }

        /// <summary>
        /// Test SessionRecordingsRetrieve
        /// </summary>
        [Fact]
        public void SessionRecordingsRetrieveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //string projectId = null;
            //var response = instance.SessionRecordingsRetrieve(id, projectId);
            //Assert.IsType<SessionRecording>(response);
        }

        /// <summary>
        /// Test SessionRecordingsSnapshotsRetrieve
        /// </summary>
        [Fact]
        public void SessionRecordingsSnapshotsRetrieveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //string projectId = null;
            //var response = instance.SessionRecordingsSnapshotsRetrieve(id, projectId);
            //Assert.IsType<SessionRecording>(response);
        }
    }
}