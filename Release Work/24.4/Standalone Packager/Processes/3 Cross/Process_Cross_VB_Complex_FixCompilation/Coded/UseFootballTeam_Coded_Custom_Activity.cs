using System;
using System.Collections.Generic;
using System.Data;
using Process_Cross_VB_Complex.Coded;
using UiPath.CodedWorkflows;
using UiPath.Core;
using UiPath.Core.Activities.Storage;
using UiPath.Orchestrator.Client.Models;
using UiPath.Testing;
using UiPath.Testing.Activities.TestData;
using UiPath.Testing.Activities.TestDataQueues.Enums;
using UiPath.Testing.Enums;
using UiPath.UIAutomationNext.API.Contracts;
using UiPath.UIAutomationNext.API.Models;
using UiPath.UIAutomationNext.Enums;

namespace Process_Cross_VB_Complex_FixCompilation.Coded
{
    public class UseFootballTeam_Coded_Custom_Activity : CodedWorkflow
    {
        [Workflow]
        public void Execute()
        {
            string teamName = "FCSB";
            string teamLeague = "Superliga";
            string teamCountry = "Romania";
            int position = 1;
            var team = new FootballTeam(teamName, teamLeague, teamCountry, position);
            
            if (team.isQualifiedForUCL) {
                Log(team.name + " is qualified for next year's UEFA Champions League");   
            }
            else {
                Log(team.name + " failed to qualify for next year's UEFA Champions League");
            }
        }
    }
}