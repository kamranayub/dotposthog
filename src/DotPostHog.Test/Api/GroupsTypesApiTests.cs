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
    ///  Class for testing GroupsTypesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class GroupsTypesApiTests : IDisposable
    {
        private GroupsTypesApi instance;

        public GroupsTypesApiTests()
        {
            instance = new GroupsTypesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of GroupsTypesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' GroupsTypesApi
            //Assert.IsType<GroupsTypesApi>(instance);
        }

        /// <summary>
        /// Test GroupsTypesList
        /// </summary>
        [Fact]
        public void GroupsTypesListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectId = null;
            //var response = instance.GroupsTypesList(projectId);
            //Assert.IsType<List<PostHogGroupType>>(response);
        }

        /// <summary>
        /// Test GroupsTypesUpdateMetadataPartialUpdate
        /// </summary>
        [Fact]
        public void GroupsTypesUpdateMetadataPartialUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectId = null;
            //PostHogPatchedGroupType postHogPatchedGroupType = null;
            //var response = instance.GroupsTypesUpdateMetadataPartialUpdate(projectId, postHogPatchedGroupType);
            //Assert.IsType<PostHogGroupType>(response);
        }
    }
}
