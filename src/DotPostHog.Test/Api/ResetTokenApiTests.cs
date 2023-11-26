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
    ///  Class for testing ResetTokenApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ResetTokenApiTests : IDisposable
    {
        private ResetTokenApi instance;

        public ResetTokenApiTests()
        {
            instance = new ResetTokenApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ResetTokenApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ResetTokenApi
            //Assert.IsType<ResetTokenApi>(instance);
        }

        /// <summary>
        /// Test ResetTokenPartialUpdate
        /// </summary>
        [Fact]
        public void ResetTokenPartialUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //PostHogPatchedTeam postHogPatchedTeam = null;
            //var response = instance.ResetTokenPartialUpdate(id, postHogPatchedTeam);
            //Assert.IsType<PostHogTeam>(response);
        }
    }
}
