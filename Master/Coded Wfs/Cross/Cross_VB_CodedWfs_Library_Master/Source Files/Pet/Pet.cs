using Cross_VB_CodedWfs_Library_Master.Utils;
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

namespace Cross_VB_CodedWfs_Library_Master.SourceFiles.Pet
{
    public class Pet
    {
        public String petName {get; set;}
        public String petClass {get; set;}
        public int? petAge {get; set;}
        
        /// <summary>
        /// Constructor for fully-defined pet
        /// </summary>
        /// <param name="petName"></param>
        /// <param name="petClass"></param>
        /// <param name="petAge"></param>
        public Pet(String petName, PetTypeEnum petClass, int? petAge)
        {
            if ((petAge==null) || (petAge <= 0))
                    this.petAge = 0;
                else 
                    this.petAge = petAge;
            this.petName = petName;
            this.petClass = GetType(petClass);
        }
        
        /// <summary>
        /// Generic constructor. Requires using the setter methods to define the pet
        /// </summary>
        public Pet() {}
        
        /// <summary>
        /// Generic constructor by pet classs
        /// </summary>
        /// <param name="petClasee"></param>
        public Pet(PetTypeEnum petClasee)
        {
            this.petClass = GetType(petClasee);
        }

        private string GetType(PetTypeEnum petClass)
        {
            switch (petClass)
            {
                case PetTypeEnum.Cat:
                    return "Pisica";
                case PetTypeEnum.Dog:
                    return "Caine";
                case PetTypeEnum.Farret:
                    return "Dihor";
                case PetTypeEnum.GunieaPig:
                    return "Porcusor de Guineea";
                case PetTypeEnum.Hamster:
                    return "Hamster";
                case PetTypeEnum.HummingBird:
                    return "Colibri";
                case PetTypeEnum.Iguana:
                    return "Iguana";
                case PetTypeEnum.Parrot:
                    return "Papagal";
                case PetTypeEnum.Rabbit:
                    return "Iepure";
                case PetTypeEnum.Turtle:
                    return "Testoasa";
                default:
                    throw new ArgumentException("Invalid vale: " + petClass.ToString());
            }
        }

        /// <summary>
        /// Returns the name of the pet
        /// </summary>
        /// <returns></returns>
        public String getName() => this.petName;
        
        /// <summary>
        /// Returns the class of the pet
        /// </summary>
        /// <returns></returns>
        public String getClass() => this.petClass;
        
        /// <summary>
        /// Returns the age of the pet
        /// </summary>
        /// <returns></returns>
        public int? getAge() => this.petAge;
        
        /// <summary>
        /// Sets the name of the pet
        /// </summary>
        /// <param name="petName"></param>
        public void SetName(string petName) => this.petName = petName;
        
        /// <summary>
        /// Sets the class of the pet
        /// </summary>
        /// <param name="petClass"></param>
        public void SetClass(PetTypeEnum petClass) => this.petClass = GetType(petClass);
        
        /// <summary>
        /// Sets the age of the pet
        /// </summary>
        /// <param name="petAge"></param>
        public void SetAge(int? petAge)
        {
            if ((petAge==null) || (petAge <= 0))
                    this.petAge = 0;
                else 
                    this.petAge = petAge;
        }
        
        /// <summary>
        /// Generic sound for pets
        /// </summary>
        public void MakeSound() 
        {
            Console.WriteLine("Generic Pet Sound");
        }
    }
}