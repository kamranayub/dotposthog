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

namespace DotPostHog.Test.Api
{
    /// <summary>
    ///  Class for testing DataManagementApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class DataManagementApiTests : IDisposable
    {
        private DataManagementApi instance;

        public DataManagementApiTests()
        {
            instance = new DataManagementApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DataManagementApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' DataManagementApi
            //Assert.IsType<DataManagementApi>(instance);
        }

        /// <summary>
        /// Test DataManagementActivityRetrieve
        /// </summary>
        [Fact]
        public void DataManagementActivityRetrieveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectId = null;
            //instance.DataManagementActivityRetrieve(projectId);
        }
    }
}
