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
    ///  Class for testing ResourceAccessApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ResourceAccessApiTests : IDisposable
    {
        private ResourceAccessApi instance;

        public ResourceAccessApiTests()
        {
            instance = new ResourceAccessApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ResourceAccessApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ResourceAccessApi
            //Assert.IsType<ResourceAccessApi>(instance);
        }

        /// <summary>
        /// Test ResourceAccessCreate
        /// </summary>
        [Fact]
        public void ResourceAccessCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string parentLookupOrganizationId = null;
            //OrganizationResourceAccess organizationResourceAccess = null;
            //var response = instance.ResourceAccessCreate(parentLookupOrganizationId, organizationResourceAccess);
            //Assert.IsType<OrganizationResourceAccess>(response);
        }

        /// <summary>
        /// Test ResourceAccessDestroy
        /// </summary>
        [Fact]
        public void ResourceAccessDestroyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //string parentLookupOrganizationId = null;
            //instance.ResourceAccessDestroy(id, parentLookupOrganizationId);
        }

        /// <summary>
        /// Test ResourceAccessList
        /// </summary>
        [Fact]
        public void ResourceAccessListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string parentLookupOrganizationId = null;
            //int? limit = null;
            //int? offset = null;
            //var response = instance.ResourceAccessList(parentLookupOrganizationId, limit, offset);
            //Assert.IsType<PaginatedOrganizationResourceAccessList>(response);
        }

        /// <summary>
        /// Test ResourceAccessPartialUpdate
        /// </summary>
        [Fact]
        public void ResourceAccessPartialUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //string parentLookupOrganizationId = null;
            //PatchedOrganizationResourceAccess patchedOrganizationResourceAccess = null;
            //var response = instance.ResourceAccessPartialUpdate(id, parentLookupOrganizationId, patchedOrganizationResourceAccess);
            //Assert.IsType<OrganizationResourceAccess>(response);
        }

        /// <summary>
        /// Test ResourceAccessRetrieve
        /// </summary>
        [Fact]
        public void ResourceAccessRetrieveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //string parentLookupOrganizationId = null;
            //var response = instance.ResourceAccessRetrieve(id, parentLookupOrganizationId);
            //Assert.IsType<OrganizationResourceAccess>(response);
        }

        /// <summary>
        /// Test ResourceAccessUpdate
        /// </summary>
        [Fact]
        public void ResourceAccessUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //string parentLookupOrganizationId = null;
            //OrganizationResourceAccess organizationResourceAccess = null;
            //var response = instance.ResourceAccessUpdate(id, parentLookupOrganizationId, organizationResourceAccess);
            //Assert.IsType<OrganizationResourceAccess>(response);
        }
    }
}