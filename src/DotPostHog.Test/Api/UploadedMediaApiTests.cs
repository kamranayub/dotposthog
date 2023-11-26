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
    ///  Class for testing UploadedMediaApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class UploadedMediaApiTests : IDisposable
    {
        private UploadedMediaApi instance;

        public UploadedMediaApiTests()
        {
            instance = new UploadedMediaApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UploadedMediaApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' UploadedMediaApi
            //Assert.IsType<UploadedMediaApi>(instance);
        }

        /// <summary>
        /// Test UploadedMediaCreate
        /// </summary>
        [Fact]
        public void UploadedMediaCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectId = null;
            //instance.UploadedMediaCreate(projectId);
        }
    }
}
