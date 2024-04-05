using Library_Win_CS_Complex.ObjectRepository;
using System;
using System.Collections.Generic;
using System.Data;
using UiPath.CodedWorkflows;
using UiPath.Core;
using UiPath.Core.Activities.Storage;
using UiPath.Excel;
using UiPath.Excel.Activities;
using UiPath.Excel.Activities.API;
using UiPath.Excel.Activities.API.Models;
using UiPath.GSuite.Activities.Api;
using UiPath.Mail.Activities.Api;
using UiPath.MicrosoftOffice365.Activities.Api;
using UiPath.Orchestrator.Client.Models;
using UiPath.Testing;
using UiPath.Testing.Activities.TestData;
using UiPath.Testing.Activities.TestDataQueues.Enums;
using UiPath.Testing.Enums;
using UiPath.UIAutomationNext.API.Contracts;
using UiPath.UIAutomationNext.API.Models;
using UiPath.UIAutomationNext.Enums;

namespace Library_Win_CS_Complex.Coded
{
    public class UseFootballTeam_Custom_Activity_Coded : CodedWorkflow
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