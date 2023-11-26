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
    ///  Class for testing InvitesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class InvitesApiTests : IDisposable
    {
        private InvitesApi instance;

        public InvitesApiTests()
        {
            instance = new InvitesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of InvitesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' InvitesApi
            //Assert.IsType<InvitesApi>(instance);
        }

        /// <summary>
        /// Test InvitesBulkCreate
        /// </summary>
        [Fact]
        public void InvitesBulkCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string parentLookupOrganizationId = null;
            //OrganizationInvite organizationInvite = null;
            //var response = instance.InvitesBulkCreate(parentLookupOrganizationId, organizationInvite);
            //Assert.IsType<OrganizationInvite>(response);
        }

        /// <summary>
        /// Test InvitesCreate
        /// </summary>
        [Fact]
        public void InvitesCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string parentLookupOrganizationId = null;
            //OrganizationInvite organizationInvite = null;
            //var response = instance.InvitesCreate(parentLookupOrganizationId, organizationInvite);
            //Assert.IsType<OrganizationInvite>(response);
        }

        /// <summary>
        /// Test InvitesDestroy
        /// </summary>
        [Fact]
        public void InvitesDestroyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //string parentLookupOrganizationId = null;
            //instance.InvitesDestroy(id, parentLookupOrganizationId);
        }

        /// <summary>
        /// Test InvitesList
        /// </summary>
        [Fact]
        public void InvitesListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string parentLookupOrganizationId = null;
            //int? limit = null;
            //int? offset = null;
            //var response = instance.InvitesList(parentLookupOrganizationId, limit, offset);
            //Assert.IsType<PaginatedOrganizationInviteList>(response);
        }
    }
}