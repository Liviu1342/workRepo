using Debug_Master_Windows_CS_TAP.ObjectRepository;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace Debug_Master_Windows_CS_TAP.Coded.CodedWfs
{
    public class PetActivity : CodedWorkflow
    {
        [Workflow]
        public void Execute()
        {
			
            // To start using services, use IntelliSense (CTRL + Space) to discover the available services:
            // e.g. system.GetAsset(...)
            Log("Hello from Coded Workflows!");
            
            // throw new Exception("Manually configured exception inside coded workflow. Testing Continue on Exception");
			
			var petNames = new List<String>(){"Felix", "Polly", "Mitica", "Gogu", null};
			var petAges = new List<int?>(){1, 3, -5, 7, null};
			var petClasses = new List<PetTypeEnum>(){PetTypeEnum.Cat, PetTypeEnum.Parrot, PetTypeEnum.Hamster, PetTypeEnum.Farret, PetTypeEnum.HummingBird};
			
			var counter = 0;
			
			foreach(var name in petNames)
			{
			    var myPet = new Pet(name, petClasses[counter], petAges[counter]);
            
				counter++;
            	Log(String.Format("{0}. {1} este {2} si are {3} ani", counter.ToString(), myPet.getName(), myPet.getClass(), myPet.getAge().ToString()), LogLevel.Error);	
			}
            
            var myCat = new Cat();
            myCat.SetName("Luna");
            myCat.SetAge((int) testing.RandomNumber(0, 10));
            myCat.SetBreed("Persana");
            myCat.SetColor("Portocalie cu Maro si cu pete albe");   
            myCat.SetGender(PetGenderEnum.Female);
            myCat.SetReproductionAbility(false);
            
            var reproductionAbility = string.Empty;
            if(myCat.IsSterilized())
                reproductionAbility = "Pisica este strilizata";
            else
                reproductionAbility = "Pisica nu este strilizata";
            
            Log(String.Format("{0} este {1} si are {2} ani. Este din rasa {3}, are culoarea {4} si este {5}. {6}",
                                        myCat.getName(), myCat.getClass().ToLower(), myCat.getAge().ToString(),
                                        myCat.GetBreed().ToLower(), myCat.GetColor().ToLower(), myCat.GetGender().ToLower(),
                                        reproductionAbility));
            
			
			var dogNames = new List<String>(){"Astro", "Dino", "Spike", "Azorel", "Zdreanta"};
			var dogBreeds = new List<String>(){ "Labrador", "Akita", "Pudel", "Buldog Francez", "Caine de apa Spaniol" };
			var dogSizes = new List<DogSizeEnum>(){DogSizeEnum.Large, DogSizeEnum.ExtraLarge, DogSizeEnum.Small, DogSizeEnum.Small, DogSizeEnum.Medium};
			var dogVaccinatedStatus = new List<bool>(){true, true, false, true, false};
			
			counter = 0;
			
			foreach(var name in dogNames)
			{
				var myDog = new Dog();
            
            	myDog.SetName(name);
            	myDog.SetAge((int) testing.RandomNumber(0, 10));
            	myDog.SetBreed(dogBreeds[counter]);
            	myDog.SetSize(dogSizes[counter]);
				myDog.IsVaccinated(dogVaccinatedStatus[counter]);
            
            	var vaccinationStatus = String.Empty;
            	if(myDog.IsVaccinated())
                	vaccinationStatus = "este vaccinat";
            	else
                	vaccinationStatus = "nu este vaccinat";
				
				counter++;
            
            	Log(String.Format("{0}. {1} este {2} de rasa {3}, de {4} si are {5} ani si {6}", counter.ToString(),
                                    myDog.getName(), myDog.getClass().ToLower(), myDog.GetBreed().ToLower(), 
                                    myDog.GetSize().ToLower(), myDog.getAge().ToString(), vaccinationStatus.ToLower()), 
                                    LogLevel.Warn);
			}
            
            var arguments = new Dictionary<String, Object>();
            arguments.Add("in_Message", "Running TestCase.xaml from PetActivity.cs!!");
            
            // Running a workflow in isolated mode
            RunWorkflow("TestCase.xaml", arguments, null, true);
            
        }
    }
}