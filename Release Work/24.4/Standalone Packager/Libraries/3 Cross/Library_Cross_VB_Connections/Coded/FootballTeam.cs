using System;
using System.Collections.Generic;
using System.Data;
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

namespace Library_Cross_VB_Connections.Coded
{
    public class FootballTeam
    {
        public String name {get; set;}
        public String league {get; set;}
        public String country {get; set;}
        public int position {get; set;}
        public bool isQualifiedForUCL {get; set;}
        
        public FootballTeam(string name, string league, string country, int position) {
            SetName(name);
            this.league = league;
            this.country = country;
            this.position = position;
            this.isQualifiedForUCL = SetUCLQualification(position);
        }
        
        public void SetName(string name) {
            if (name != null)
                this.name = name;
            else throw new Exception("name is invalid!");
        }
        
        public bool SetUCLQualification(int position) {
            if (position < 3)
                return true;
            else
                return false;
        }
        
        public bool GetUCLQualification() {
            return this.isQualifiedForUCL;
        }
    }
}