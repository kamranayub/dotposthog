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
    ///  Class for testing OrganizationsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class OrganizationsApiTests : IDisposable
    {
        private OrganizationsApi instance;

        public OrganizationsApiTests()
        {
            instance = new OrganizationsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of OrganizationsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' OrganizationsApi
            //Assert.IsType<OrganizationsApi>(instance);
        }

        /// <summary>
        /// Test DomainsCreate
        /// </summary>
        [Fact]
        public void DomainsCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string parentLookupOrganizationId = null;
            //OrganizationDomain organizationDomain = null;
            //var response = instance.DomainsCreate(parentLookupOrganizationId, organizationDomain);
            //Assert.IsType<OrganizationDomain>(response);
        }

        /// <summary>
        /// Test DomainsDestroy
        /// </summary>
        [Fact]
        public void DomainsDestroyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //string parentLookupOrganizationId = null;
            //instance.DomainsDestroy(id, parentLookupOrganizationId);
        }

        /// <summary>
        /// Test DomainsList
        /// </summary>
        [Fact]
        public void DomainsListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string parentLookupOrganizationId = null;
            //int? limit = null;
            //int? offset = null;
            //var response = instance.DomainsList(parentLookupOrganizationId, limit, offset);
            //Assert.IsType<PaginatedOrganizationDomainList>(response);
        }

        /// <summary>
        /// Test DomainsPartialUpdate
        /// </summary>
        [Fact]
        public void DomainsPartialUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //string parentLookupOrganizationId = null;
            //PatchedOrganizationDomain patchedOrganizationDomain = null;
            //var response = instance.DomainsPartialUpdate(id, parentLookupOrganizationId, patchedOrganizationDomain);
            //Assert.IsType<OrganizationDomain>(response);
        }

        /// <summary>
        /// Test DomainsRetrieve
        /// </summary>
        [Fact]
        public void DomainsRetrieveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //string parentLookupOrganizationId = null;
            //var response = instance.DomainsRetrieve(id, parentLookupOrganizationId);
            //Assert.IsType<OrganizationDomain>(response);
        }

        /// <summary>
        /// Test DomainsUpdate
        /// </summary>
        [Fact]
        public void DomainsUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //string parentLookupOrganizationId = null;
            //OrganizationDomain organizationDomain = null;
            //var response = instance.DomainsUpdate(id, parentLookupOrganizationId, organizationDomain);
            //Assert.IsType<OrganizationDomain>(response);
        }

        /// <summary>
        /// Test DomainsVerifyCreate
        /// </summary>
        [Fact]
        public void DomainsVerifyCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //string parentLookupOrganizationId = null;
            //OrganizationDomain organizationDomain = null;
            //var response = instance.DomainsVerifyCreate(id, parentLookupOrganizationId, organizationDomain);
            //Assert.IsType<OrganizationDomain>(response);
        }

        /// <summary>
        /// Test FeatureFlagsCopyFlagsCreate
        /// </summary>
        [Fact]
        public void FeatureFlagsCopyFlagsCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string parentLookupOrganizationId = null;
            //instance.FeatureFlagsCopyFlagsCreate(parentLookupOrganizationId);
        }

        /// <summary>
        /// Test FeatureFlagsRetrieve
        /// </summary>
        [Fact]
        public void FeatureFlagsRetrieveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string featureFlagKey = null;
            //string parentLookupOrganizationId = null;
            //instance.FeatureFlagsRetrieve(featureFlagKey, parentLookupOrganizationId);
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

        /// <summary>
        /// Test MembersDestroy
        /// </summary>
        [Fact]
        public void MembersDestroyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string parentLookupOrganizationId = null;
            //Guid userUuid = null;
            //instance.MembersDestroy(parentLookupOrganizationId, userUuid);
        }

        /// <summary>
        /// Test MembersList
        /// </summary>
        [Fact]
        public void MembersListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string parentLookupOrganizationId = null;
            //int? limit = null;
            //int? offset = null;
            //var response = instance.MembersList(parentLookupOrganizationId, limit, offset);
            //Assert.IsType<PaginatedOrganizationMemberList>(response);
        }

        /// <summary>
        /// Test MembersPartialUpdate
        /// </summary>
        [Fact]
        public void MembersPartialUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string parentLookupOrganizationId = null;
            //Guid userUuid = null;
            //PatchedOrganizationMember patchedOrganizationMember = null;
            //var response = instance.MembersPartialUpdate(parentLookupOrganizationId, userUuid, patchedOrganizationMember);
            //Assert.IsType<OrganizationMember>(response);
        }

        /// <summary>
        /// Test MembersUpdate
        /// </summary>
        [Fact]
        public void MembersUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string parentLookupOrganizationId = null;
            //Guid userUuid = null;
            //OrganizationMember organizationMember = null;
            //var response = instance.MembersUpdate(parentLookupOrganizationId, userUuid, organizationMember);
            //Assert.IsType<OrganizationMember>(response);
        }

        /// <summary>
        /// Test PipelineTransformationsActivityRetrieve
        /// </summary>
        [Fact]
        public void PipelineTransformationsActivityRetrieveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string parentLookupOrganizationId = null;
            //var response = instance.PipelineTransformationsActivityRetrieve(parentLookupOrganizationId);
            //Assert.IsType<Plugin>(response);
        }

        /// <summary>
        /// Test PipelineTransformationsCheckForUpdatesRetrieve
        /// </summary>
        [Fact]
        public void PipelineTransformationsCheckForUpdatesRetrieveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //string parentLookupOrganizationId = null;
            //var response = instance.PipelineTransformationsCheckForUpdatesRetrieve(id, parentLookupOrganizationId);
            //Assert.IsType<Plugin>(response);
        }

        /// <summary>
        /// Test PipelineTransformationsCreate
        /// </summary>
        [Fact]
        public void PipelineTransformationsCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string parentLookupOrganizationId = null;
            //Plugin plugin = null;
            //var response = instance.PipelineTransformationsCreate(parentLookupOrganizationId, plugin);
            //Assert.IsType<Plugin>(response);
        }

        /// <summary>
        /// Test PipelineTransformationsDestroy
        /// </summary>
        [Fact]
        public void PipelineTransformationsDestroyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //string parentLookupOrganizationId = null;
            //instance.PipelineTransformationsDestroy(id, parentLookupOrganizationId);
        }

        /// <summary>
        /// Test PipelineTransformationsList
        /// </summary>
        [Fact]
        public void PipelineTransformationsListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string parentLookupOrganizationId = null;
            //int? limit = null;
            //int? offset = null;
            //var response = instance.PipelineTransformationsList(parentLookupOrganizationId, limit, offset);
            //Assert.IsType<PaginatedPluginList>(response);
        }

        /// <summary>
        /// Test PipelineTransformationsPartialUpdate
        /// </summary>
        [Fact]
        public void PipelineTransformationsPartialUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //string parentLookupOrganizationId = null;
            //PatchedPlugin patchedPlugin = null;
            //var response = instance.PipelineTransformationsPartialUpdate(id, parentLookupOrganizationId, patchedPlugin);
            //Assert.IsType<Plugin>(response);
        }

        /// <summary>
        /// Test PipelineTransformationsRepositoryRetrieve
        /// </summary>
        [Fact]
        public void PipelineTransformationsRepositoryRetrieveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string parentLookupOrganizationId = null;
            //var response = instance.PipelineTransformationsRepositoryRetrieve(parentLookupOrganizationId);
            //Assert.IsType<Plugin>(response);
        }

        /// <summary>
        /// Test PipelineTransformationsRetrieve
        /// </summary>
        [Fact]
        public void PipelineTransformationsRetrieveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //string parentLookupOrganizationId = null;
            //var response = instance.PipelineTransformationsRetrieve(id, parentLookupOrganizationId);
            //Assert.IsType<Plugin>(response);
        }

        /// <summary>
        /// Test PipelineTransformationsSourceRetrieve
        /// </summary>
        [Fact]
        public void PipelineTransformationsSourceRetrieveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //string parentLookupOrganizationId = null;
            //var response = instance.PipelineTransformationsSourceRetrieve(id, parentLookupOrganizationId);
            //Assert.IsType<Plugin>(response);
        }

        /// <summary>
        /// Test PipelineTransformationsUnusedRetrieve
        /// </summary>
        [Fact]
        public void PipelineTransformationsUnusedRetrieveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string parentLookupOrganizationId = null;
            //var response = instance.PipelineTransformationsUnusedRetrieve(parentLookupOrganizationId);
            //Assert.IsType<Plugin>(response);
        }

        /// <summary>
        /// Test PipelineTransformationsUpdate
        /// </summary>
        [Fact]
        public void PipelineTransformationsUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //string parentLookupOrganizationId = null;
            //Plugin plugin = null;
            //var response = instance.PipelineTransformationsUpdate(id, parentLookupOrganizationId, plugin);
            //Assert.IsType<Plugin>(response);
        }

        /// <summary>
        /// Test PipelineTransformationsUpdateSourcePartialUpdate
        /// </summary>
        [Fact]
        public void PipelineTransformationsUpdateSourcePartialUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //string parentLookupOrganizationId = null;
            //PatchedPlugin patchedPlugin = null;
            //var response = instance.PipelineTransformationsUpdateSourcePartialUpdate(id, parentLookupOrganizationId, patchedPlugin);
            //Assert.IsType<Plugin>(response);
        }

        /// <summary>
        /// Test PipelineTransformationsUpgradeCreate
        /// </summary>
        [Fact]
        public void PipelineTransformationsUpgradeCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //string parentLookupOrganizationId = null;
            //Plugin plugin = null;
            //var response = instance.PipelineTransformationsUpgradeCreate(id, parentLookupOrganizationId, plugin);
            //Assert.IsType<Plugin>(response);
        }

        /// <summary>
        /// Test PluginsActivityRetrieve
        /// </summary>
        [Fact]
        public void PluginsActivityRetrieveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string parentLookupOrganizationId = null;
            //var response = instance.PluginsActivityRetrieve(parentLookupOrganizationId);
            //Assert.IsType<Plugin>(response);
        }

        /// <summary>
        /// Test PluginsCheckForUpdatesRetrieve
        /// </summary>
        [Fact]
        public void PluginsCheckForUpdatesRetrieveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //string parentLookupOrganizationId = null;
            //var response = instance.PluginsCheckForUpdatesRetrieve(id, parentLookupOrganizationId);
            //Assert.IsType<Plugin>(response);
        }

        /// <summary>
        /// Test PluginsCreate
        /// </summary>
        [Fact]
        public void PluginsCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string parentLookupOrganizationId = null;
            //Plugin plugin = null;
            //var response = instance.PluginsCreate(parentLookupOrganizationId, plugin);
            //Assert.IsType<Plugin>(response);
        }

        /// <summary>
        /// Test PluginsDestroy
        /// </summary>
        [Fact]
        public void PluginsDestroyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //string parentLookupOrganizationId = null;
            //instance.PluginsDestroy(id, parentLookupOrganizationId);
        }

        /// <summary>
        /// Test PluginsList
        /// </summary>
        [Fact]
        public void PluginsListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string parentLookupOrganizationId = null;
            //int? limit = null;
            //int? offset = null;
            //var response = instance.PluginsList(parentLookupOrganizationId, limit, offset);
            //Assert.IsType<PaginatedPluginList>(response);
        }

        /// <summary>
        /// Test PluginsPartialUpdate
        /// </summary>
        [Fact]
        public void PluginsPartialUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //string parentLookupOrganizationId = null;
            //PatchedPlugin patchedPlugin = null;
            //var response = instance.PluginsPartialUpdate(id, parentLookupOrganizationId, patchedPlugin);
            //Assert.IsType<Plugin>(response);
        }

        /// <summary>
        /// Test PluginsRepositoryRetrieve
        /// </summary>
        [Fact]
        public void PluginsRepositoryRetrieveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string parentLookupOrganizationId = null;
            //var response = instance.PluginsRepositoryRetrieve(parentLookupOrganizationId);
            //Assert.IsType<Plugin>(response);
        }

        /// <summary>
        /// Test PluginsRetrieve
        /// </summary>
        [Fact]
        public void PluginsRetrieveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //string parentLookupOrganizationId = null;
            //var response = instance.PluginsRetrieve(id, parentLookupOrganizationId);
            //Assert.IsType<Plugin>(response);
        }

        /// <summary>
        /// Test PluginsSourceRetrieve
        /// </summary>
        [Fact]
        public void PluginsSourceRetrieveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //string parentLookupOrganizationId = null;
            //var response = instance.PluginsSourceRetrieve(id, parentLookupOrganizationId);
            //Assert.IsType<Plugin>(response);
        }

        /// <summary>
        /// Test PluginsUnusedRetrieve
        /// </summary>
        [Fact]
        public void PluginsUnusedRetrieveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string parentLookupOrganizationId = null;
            //var response = instance.PluginsUnusedRetrieve(parentLookupOrganizationId);
            //Assert.IsType<Plugin>(response);
        }

        /// <summary>
        /// Test PluginsUpdate
        /// </summary>
        [Fact]
        public void PluginsUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //string parentLookupOrganizationId = null;
            //Plugin plugin = null;
            //var response = instance.PluginsUpdate(id, parentLookupOrganizationId, plugin);
            //Assert.IsType<Plugin>(response);
        }

        /// <summary>
        /// Test PluginsUpdateSourcePartialUpdate
        /// </summary>
        [Fact]
        public void PluginsUpdateSourcePartialUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //string parentLookupOrganizationId = null;
            //PatchedPlugin patchedPlugin = null;
            //var response = instance.PluginsUpdateSourcePartialUpdate(id, parentLookupOrganizationId, patchedPlugin);
            //Assert.IsType<Plugin>(response);
        }

        /// <summary>
        /// Test PluginsUpgradeCreate
        /// </summary>
        [Fact]
        public void PluginsUpgradeCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //string parentLookupOrganizationId = null;
            //Plugin plugin = null;
            //var response = instance.PluginsUpgradeCreate(id, parentLookupOrganizationId, plugin);
            //Assert.IsType<Plugin>(response);
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

        /// <summary>
        /// Test RolesCreate
        /// </summary>
        [Fact]
        public void RolesCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string parentLookupOrganizationId = null;
            //Role role = null;
            //var response = instance.RolesCreate(parentLookupOrganizationId, role);
            //Assert.IsType<Role>(response);
        }

        /// <summary>
        /// Test RolesDestroy
        /// </summary>
        [Fact]
        public void RolesDestroyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //string parentLookupOrganizationId = null;
            //instance.RolesDestroy(id, parentLookupOrganizationId);
        }

        /// <summary>
        /// Test RolesList
        /// </summary>
        [Fact]
        public void RolesListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string parentLookupOrganizationId = null;
            //int? limit = null;
            //int? offset = null;
            //var response = instance.RolesList(parentLookupOrganizationId, limit, offset);
            //Assert.IsType<PaginatedRoleList>(response);
        }

        /// <summary>
        /// Test RolesPartialUpdate
        /// </summary>
        [Fact]
        public void RolesPartialUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //string parentLookupOrganizationId = null;
            //PatchedRole patchedRole = null;
            //var response = instance.RolesPartialUpdate(id, parentLookupOrganizationId, patchedRole);
            //Assert.IsType<Role>(response);
        }

        /// <summary>
        /// Test RolesRetrieve
        /// </summary>
        [Fact]
        public void RolesRetrieveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //string parentLookupOrganizationId = null;
            //var response = instance.RolesRetrieve(id, parentLookupOrganizationId);
            //Assert.IsType<Role>(response);
        }

        /// <summary>
        /// Test RolesRoleMembershipsCreate
        /// </summary>
        [Fact]
        public void RolesRoleMembershipsCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string parentLookupOrganizationId = null;
            //string parentLookupRoleId = null;
            //RoleMembership roleMembership = null;
            //var response = instance.RolesRoleMembershipsCreate(parentLookupOrganizationId, parentLookupRoleId, roleMembership);
            //Assert.IsType<RoleMembership>(response);
        }

        /// <summary>
        /// Test RolesRoleMembershipsDestroy
        /// </summary>
        [Fact]
        public void RolesRoleMembershipsDestroyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //string parentLookupOrganizationId = null;
            //string parentLookupRoleId = null;
            //instance.RolesRoleMembershipsDestroy(id, parentLookupOrganizationId, parentLookupRoleId);
        }

        /// <summary>
        /// Test RolesRoleMembershipsList
        /// </summary>
        [Fact]
        public void RolesRoleMembershipsListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string parentLookupOrganizationId = null;
            //string parentLookupRoleId = null;
            //int? limit = null;
            //int? offset = null;
            //var response = instance.RolesRoleMembershipsList(parentLookupOrganizationId, parentLookupRoleId, limit, offset);
            //Assert.IsType<PaginatedRoleMembershipList>(response);
        }

        /// <summary>
        /// Test RolesUpdate
        /// </summary>
        [Fact]
        public void RolesUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //string parentLookupOrganizationId = null;
            //Role role = null;
            //var response = instance.RolesUpdate(id, parentLookupOrganizationId, role);
            //Assert.IsType<Role>(response);
        }
    }
}