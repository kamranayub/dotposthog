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
    ///  Class for testing AnnotationsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AnnotationsApiTests : IDisposable
    {
        private AnnotationsApi instance;

        public AnnotationsApiTests()
        {
            instance = new AnnotationsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AnnotationsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' AnnotationsApi
            //Assert.IsType<AnnotationsApi>(instance);
        }

        /// <summary>
        /// Test AnnotationsCreate
        /// </summary>
        [Fact]
        public void AnnotationsCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectId = null;
            //PostHogAnnotation postHogAnnotation = null;
            //var response = instance.AnnotationsCreate(projectId, postHogAnnotation);
            //Assert.IsType<PostHogAnnotation>(response);
        }

        /// <summary>
        /// Test AnnotationsDestroy
        /// </summary>
        [Fact]
        public void AnnotationsDestroyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //string projectId = null;
            //instance.AnnotationsDestroy(id, projectId);
        }

        /// <summary>
        /// Test AnnotationsList
        /// </summary>
        [Fact]
        public void AnnotationsListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectId = null;
            //int? limit = null;
            //int? offset = null;
            //string search = null;
            //var response = instance.AnnotationsList(projectId, limit, offset, search);
            //Assert.IsType<PostHogPaginatedAnnotationList>(response);
        }

        /// <summary>
        /// Test AnnotationsPartialUpdate
        /// </summary>
        [Fact]
        public void AnnotationsPartialUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //string projectId = null;
            //PostHogPatchedAnnotation postHogPatchedAnnotation = null;
            //var response = instance.AnnotationsPartialUpdate(id, projectId, postHogPatchedAnnotation);
            //Assert.IsType<PostHogAnnotation>(response);
        }

        /// <summary>
        /// Test AnnotationsRetrieve
        /// </summary>
        [Fact]
        public void AnnotationsRetrieveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //string projectId = null;
            //var response = instance.AnnotationsRetrieve(id, projectId);
            //Assert.IsType<PostHogAnnotation>(response);
        }

        /// <summary>
        /// Test AnnotationsUpdate
        /// </summary>
        [Fact]
        public void AnnotationsUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //string projectId = null;
            //PostHogAnnotation postHogAnnotation = null;
            //var response = instance.AnnotationsUpdate(id, projectId, postHogAnnotation);
            //Assert.IsType<PostHogAnnotation>(response);
        }
    }
}
