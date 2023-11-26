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
    ///  Class for testing ExplicitMembersApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ExplicitMembersApiTests : IDisposable
    {
        private ExplicitMembersApi instance;

        public ExplicitMembersApiTests()
        {
            instance = new ExplicitMembersApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ExplicitMembersApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ExplicitMembersApi
            //Assert.IsType<ExplicitMembersApi>(instance);
        }

        /// <summary>
        /// Test ExplicitMembersCreate
        /// </summary>
        [Fact]
        public void ExplicitMembersCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectId = null;
            //ExplicitTeamMember explicitTeamMember = null;
            //var response = instance.ExplicitMembersCreate(projectId, explicitTeamMember);
            //Assert.IsType<ExplicitTeamMember>(response);
        }

        /// <summary>
        /// Test ExplicitMembersDestroy
        /// </summary>
        [Fact]
        public void ExplicitMembersDestroyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid parentMembershipUserUuid = null;
            //string projectId = null;
            //instance.ExplicitMembersDestroy(parentMembershipUserUuid, projectId);
        }

        /// <summary>
        /// Test ExplicitMembersList
        /// </summary>
        [Fact]
        public void ExplicitMembersListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectId = null;
            //var response = instance.ExplicitMembersList(projectId);
            //Assert.IsType<List<ExplicitTeamMember>>(response);
        }

        /// <summary>
        /// Test ExplicitMembersPartialUpdate
        /// </summary>
        [Fact]
        public void ExplicitMembersPartialUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid parentMembershipUserUuid = null;
            //string projectId = null;
            //PatchedExplicitTeamMember patchedExplicitTeamMember = null;
            //var response = instance.ExplicitMembersPartialUpdate(parentMembershipUserUuid, projectId, patchedExplicitTeamMember);
            //Assert.IsType<ExplicitTeamMember>(response);
        }

        /// <summary>
        /// Test ExplicitMembersRetrieve
        /// </summary>
        [Fact]
        public void ExplicitMembersRetrieveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid parentMembershipUserUuid = null;
            //string projectId = null;
            //var response = instance.ExplicitMembersRetrieve(parentMembershipUserUuid, projectId);
            //Assert.IsType<ExplicitTeamMember>(response);
        }

        /// <summary>
        /// Test ExplicitMembersUpdate
        /// </summary>
        [Fact]
        public void ExplicitMembersUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid parentMembershipUserUuid = null;
            //string projectId = null;
            //ExplicitTeamMember explicitTeamMember = null;
            //var response = instance.ExplicitMembersUpdate(parentMembershipUserUuid, projectId, explicitTeamMember);
            //Assert.IsType<ExplicitTeamMember>(response);
        }
    }
}