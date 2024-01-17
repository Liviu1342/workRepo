using System;
using System.Collections.Generic;
using UiPath.CodedWorkflows;

// NOTICE: The Coded Automations feature is available as a preview feature and APIs may be subject to change. 
//         No warranty or technical support is provided for this preview feature.
//         Missing features or encountering bugs? Please click the feedback button in the top-right corner and let us know!
// Please delete these comments after you've read and acknowledged them. For more information, please visit the documentation over at https://docs.uipath.com/studio/lang-en/v2023.10/docs/coded-automations.
namespace Debug_Master_Windows_CS_TAP
{
    public class Dog : Pet
    {
        public String dogBreed {get; private set;}
        public String dogSize {get; private set;}
        public bool isVaccinated {get; private set;}
        
        /// <summary>
        /// Constructor with full set of arguments
        /// </summary>
        /// <param name="dogName"></param>
        /// <param name="dogAge"></param>
        /// <param name="dogBreed"></param>
        /// <param name="dogSize"></param>
        /// <param name="isVaccinated"></param>
        public Dog(String dogName, int? dogAge, string dogBreed, string dogSize, bool isVaccinated) : base(dogName, PetTypeEnum.Dog, dogAge)
        {
            this.dogBreed = dogBreed;
            this.dogSize = dogSize;
            this.isVaccinated = isVaccinated;
        }
        
        /// <summary>
        /// Generic constructor with limited set of defaults. Requires using the setter methods to have a fully-defined Dog object
        /// </summary>
        /// <param name="dogName"></param>
        /// <param name="dogAge"></param>
        public Dog(String dogName, int? dogAge) : base (dogName, PetTypeEnum.Dog, dogAge) {}
        
        /// <summary>
        /// Generic constructor with no default settings. Requires using the setter methods to have a fully defined Dog object
        /// </summary>
        public Dog() : base(PetTypeEnum.Dog) 
		{
			Console.WriteLine("Creating new dog");
			Console.WriteLine("Adding a generic pet");
		}
        
        /// <summary>
        /// Returns the size of the dog
        /// </summary>
        /// <returns></returns>
        public string GetSize() => this.dogSize;
        
        /// <summary>
        /// Returns the breed of the dog
        /// </summary>
        /// <returns></returns>
        public string GetBreed() => this.dogBreed;
        
        /// <summary>
        /// Returns the vaccination status of the dog
        /// </summary>
        /// <returns></returns>
        public bool IsVaccinated() => this.isVaccinated;
        
        /// <summary>
        /// Sets the size of the dog
        /// </summary>
        /// <param name="dogSize"></param>
        public void SetSize(DogSizeEnum dogSize) => this.dogSize = GetSize(dogSize);
        
        /// <summary>
        /// Sets the breed of the dog
        /// </summary>
        /// <param name="dogBreed"></param>
        public void SetBreed(String dogBreed) => this.dogBreed = dogBreed;
        
        /// <summary>
        /// Sets the vaccination status of the dog
        /// </summary>
        /// <param name="isVaccinated"></param>
        public void IsVaccinated(bool isVaccinated) => this.isVaccinated = isVaccinated;
        
        /// <summary>
        /// Generates dog sound
        /// </summary>
        public void MakeSound()
        {
            Console.WriteLine("Ham Ham");
        }

        
        private string GetSize(DogSizeEnum dogSize)
        {
            string talie = "talie ";
            switch(dogSize) 
            {
                case DogSizeEnum.Small:
                    talie += "mica";
                    break;
                case DogSizeEnum.Medium:
                    talie += "medie";
                    break;
                case DogSizeEnum.Large:
                    talie += "mare";
                    break;
                case DogSizeEnum.ExtraLarge:
                    talie += "foarte mare";
                    break;
                default:
                    throw new ArgumentException("Invalid value: " + dogSize.ToString());
            }
            return talie;
        }
    }
}