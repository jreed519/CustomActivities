﻿//-----------------------------------------------------------------------
// <copyright file="MockIBuildDefinition.cs">(c) http://TfsBuildExtensions.codeplex.com/. This source is subject to the Microsoft Permissive License. See http://www.microsoft.com/resources/sharedsource/licensingbasics/sharedsourcelicenses.mspx. All other rights reserved.</copyright>
//-----------------------------------------------------------------------
// <autogenerated/>
namespace TfsBuildExtensions.Activities.Tests
{
    using System;
    using System.Collections.Generic;
    using Microsoft.TeamFoundation.Build.Client;

    class MockIBuildDefinition : IBuildDefinition
    {
        public void Refresh()
        {
            throw new NotImplementedException();
        }

        public Uri Uri
        {
            get { throw new NotImplementedException(); }
        }

        public string Name { get; set; }

        public string TeamProject
        {
            get { throw new NotImplementedException(); }
        }

        public string FullPath
        {
            get { throw new NotImplementedException(); }
        }

        public IRetentionPolicy AddRetentionPolicy(BuildReason reason, BuildStatus status, int numberToKeep, DeleteOptions deleteOptions)
        {
            throw new NotImplementedException();
        }

        public ISchedule AddSchedule()
        {
            throw new NotImplementedException();
        }

        public IBuildRequest CreateBuildRequest()
        {
            throw new NotImplementedException();
        }

        public IBuildDetail CreateManualBuild(string buildNumber)
        {
            throw new NotImplementedException();
        }

        public IBuildDetail CreateManualBuild(string buildNumber, string dropLocation)
        {
            throw new NotImplementedException();
        }

        public IBuildDetail CreateManualBuild(string buildNumber, string dropLocation, BuildStatus buildStatus, IBuildController controller, string requestedFor)
        {
            throw new NotImplementedException();
        }

        [Obsolete("This method has been deprecated. Please remove all references.", true)]
        public IProjectFile CreateProjectFile()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public IBuildDefinitionSpec CreateSpec()
        {
            throw new NotImplementedException();
        }

        public IBuildDetail[] QueryBuilds()
        {
            throw new NotImplementedException();
        }

        public IBuildController BuildController
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public Uri BuildControllerUri
        {
            get { throw new NotImplementedException(); }
        }

        public string ConfigurationFolderPath
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public string Description
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public string DefaultDropLocation
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public IBuildAgent DefaultBuildAgent
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public Uri DefaultBuildAgentUri
        {
            get { throw new NotImplementedException(); }
        }

        public bool Enabled
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public string Id
        {
            get { throw new NotImplementedException(); }
        }

        public Dictionary<BuildStatus, IRetentionPolicy> RetentionPolicies
        {
            get { throw new NotImplementedException(); }
        }

        public List<IRetentionPolicy> RetentionPolicyList
        {
            get { throw new NotImplementedException(); }
        }

        public List<ISchedule> Schedules
        {
            get { throw new NotImplementedException(); }
        }

        public IWorkspaceTemplate Workspace
        {
            get { throw new NotImplementedException(); }
        }

        public Uri LastBuildUri
        {
            get { throw new NotImplementedException(); }
        }

        public Uri LastGoodBuildUri
        {
            get { throw new NotImplementedException(); }
        }

        public string LastGoodBuildLabel
        {
            get { throw new NotImplementedException(); }
        }

        public IProcessTemplate Process
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public string ProcessParameters
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public ContinuousIntegrationType ContinuousIntegrationType
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public int ContinuousIntegrationQuietPeriod
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public IBuildServer BuildServer
        {
            get { throw new NotImplementedException(); }
        }
    }
}
