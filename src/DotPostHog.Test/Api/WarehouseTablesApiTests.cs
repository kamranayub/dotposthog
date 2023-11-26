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
    ///  Class for testing WarehouseTablesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class WarehouseTablesApiTests : IDisposable
    {
        private WarehouseTablesApi instance;

        public WarehouseTablesApiTests()
        {
            instance = new WarehouseTablesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of WarehouseTablesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' WarehouseTablesApi
            //Assert.IsType<WarehouseTablesApi>(instance);
        }

        /// <summary>
        /// Test WarehouseTablesCreate
        /// </summary>
        [Fact]
        public void WarehouseTablesCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectId = null;
            //Table table = null;
            //var response = instance.WarehouseTablesCreate(projectId, table);
            //Assert.IsType<Table>(response);
        }

        /// <summary>
        /// Test WarehouseTablesDestroy
        /// </summary>
        [Fact]
        public void WarehouseTablesDestroyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //string projectId = null;
            //instance.WarehouseTablesDestroy(id, projectId);
        }

        /// <summary>
        /// Test WarehouseTablesList
        /// </summary>
        [Fact]
        public void WarehouseTablesListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectId = null;
            //int? limit = null;
            //int? offset = null;
            //string search = null;
            //var response = instance.WarehouseTablesList(projectId, limit, offset, search);
            //Assert.IsType<PaginatedTableList>(response);
        }

        /// <summary>
        /// Test WarehouseTablesPartialUpdate
        /// </summary>
        [Fact]
        public void WarehouseTablesPartialUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //string projectId = null;
            //PatchedTable patchedTable = null;
            //var response = instance.WarehouseTablesPartialUpdate(id, projectId, patchedTable);
            //Assert.IsType<Table>(response);
        }

        /// <summary>
        /// Test WarehouseTablesRetrieve
        /// </summary>
        [Fact]
        public void WarehouseTablesRetrieveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //string projectId = null;
            //var response = instance.WarehouseTablesRetrieve(id, projectId);
            //Assert.IsType<Table>(response);
        }

        /// <summary>
        /// Test WarehouseTablesUpdate
        /// </summary>
        [Fact]
        public void WarehouseTablesUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //string projectId = null;
            //Table table = null;
            //var response = instance.WarehouseTablesUpdate(id, projectId, table);
            //Assert.IsType<Table>(response);
        }
    }
}