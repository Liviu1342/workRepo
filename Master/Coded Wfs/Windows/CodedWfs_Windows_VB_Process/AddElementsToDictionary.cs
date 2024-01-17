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

namespace CodedWfs_Windows_VB_Process
{
    public class AddElementsToDictionary
    {
        public Dictionary<String, Object> arguments;
        public String argument1_Name;
        public Object argument1_Value;
        public String argument2_Name;
        public Object argument2_Value;
        public String argument3_Name;
        public Object argument4_Value;
        
        public Dictionary<String, Object> AddArguments(string arg1_Name, Object arg1_Value, string arg2_Name, 
                            Object arg2_Value, string arg3_Name, Object arg3_Value)
        {
            this.arguments.Add(arg1_Name, arg1_Value);
            this.arguments.Add(arg2_Name, arg2_Value);
            this.arguments.Add(arg3_Name, arg3_Value);
            
            return arguments;
        }
        
    }
}