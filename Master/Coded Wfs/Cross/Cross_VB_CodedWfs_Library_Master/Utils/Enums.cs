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

namespace Cross_VB_CodedWfs_Library_Master.Utils
{
    public enum PetTypeEnum
    {
        Dog,
        Cat,
        Parrot,
        Hamster,
        GunieaPig,
        HummingBird,
        Iguana,
        Turtle,
        Farret,
        Rabbit
    }
    
    public enum DogSizeEnum
    {
        Small,
        Medium,
        Large,
        ExtraLarge
    }
    
    public enum PetGenderEnum
    {
        Male,
        Female,
        Hermaphrodite,
        Asexual
    }
}