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

namespace Cross_VB_CodedWfs_Library_Master.SourceFiles.Pet.Pets
{
    public class Cat : Pet
    {
        protected String catBreed {get; private set;}
        protected String catColor {get; private set;}
        protected bool isSterilized {get; private set;}
        protected String catGender {get; private set;}
        
        /// <summary>
        /// Generic constructor. Requires definition for all attributes
        /// </summary>
        public Cat() : base(PetTypeEnum.Cat) 
        {
            Console.WriteLine("Creating a new cat");
        }
        
        /// <summary>
        /// Specific consturctor. Defines all attributes
        /// </summary>
        /// <param name="catName"></param>
        /// <param name="catAge"></param>
        /// <param name="catBreed"></param>
        /// <param name="catColor"></param>
        /// <param name="isSterilized"></param>
        /// <param name="catGender"></param>
        public Cat(String catName, int? catAge, String catBreed, String catColor, bool isSterilized, PetGenderEnum catGender) : base(catName, PetTypeEnum.Cat, catAge)
        {
            this.catBreed = catBreed;
            this.catColor = catColor;
            this.isSterilized = isSterilized;
            this.catGender = GetGender(catGender);
        }
        
        /// <summary>
        /// Partial constructor. Requires definition for cat specific attributes
        /// </summary>
        /// <param name="catName"></param>
        /// <param name="catAge"></param>
        public Cat(String catName, int? catAge) : base(catName, PetTypeEnum.Cat, catAge) {}
        
        /// <summary>
        /// Gets the breed of the cat
        /// </summary>
        /// <returns></returns>
        public String GetBreed() => this.catBreed;
        
        /// <summary>
        /// Gets the color of the cat
        /// </summary>
        /// <returns></returns>
        public String GetColor() => this.catColor;
        
        /// <summary>
        /// Gets the sterilization status of the cat
        /// If true, then the cat is sterilized and cannot reproduce
        /// If false, the cat is not sterilized and it can reproduce
        /// </summary>
        /// <returns></returns>
        public bool IsSterilized() => this.isSterilized;
        
        /// <summary>
        /// Gets the gender of the cat
        /// </summary>
        /// <returns></returns>
        public String GetGender() => this.catGender;
        
        /// <summary>
        /// Sets the breed of the cat
        /// </summary>
        /// <param name="catBreed"></param>
        public void SetBreed(String catBreed)
        {
            this.catBreed = catBreed;
        }
        
        /// <summary>
        /// Sets the color of the cat
        /// </summary>
        /// <param name="catColor"></param>
        public void SetColor(String catColor)
        {
            this.catColor = catColor;
        }
        
        /// <summary>
        /// Sets the reproduction ability of the cat
        /// Choose true if the cat can reproduce
        /// Choose false if the cat cannot reproduce
        /// </summary>
        /// <param name="isSterilized"></param>
        public void SetReproductionAbility(bool isSterilized)
        {
            this.isSterilized = !isSterilized;
        }
        
        /// <summary>
        /// Sets the gender of the cat
        /// </summary>
        /// <param name="catGender"></param>
        public void SetGender(PetGenderEnum catGender) 
        {
            this.catGender = GetGender(catGender);
        }
        
        public void MakeSound() 
        {
            Console.WriteLine("Miau");
        }

        private string GetGender(PetGenderEnum catGender)
        {
            switch (catGender)
            {
                case PetGenderEnum.Male:
                    return "Mascul";
                case PetGenderEnum.Female:
                    return "Femela";
                case PetGenderEnum.Asexual:
                    return "Asexual";
                case PetGenderEnum.Hermaphrodite:
                    return "Hermafrodit";
                default:
                    throw new ArgumentException("Invalid Argument: " + catGender.ToString());
            }
        }
    }
}