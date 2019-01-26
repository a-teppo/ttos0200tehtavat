using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jamk.It.OO
{
    public enum Gender
    {
        Unknown,
        Female,
        Male
    }
    public class Dog
    {
        // field variables
        private string breed; //rotu taustamuuttuja
        // properties
        public string Name { get; set; }
        public string Color { get; set; }
        //vain luettavissa
        public Gender DogGender { get; }
        //Rotu ominaisuus on vain luettavissa, sitä ei pysty muuttamaan
        //asetetaan konstruktorissa
        public string Breed
        {
            get
            {
                return breed;
            }
        }
        // constructors
        public Dog()
        {
            //oletuskonstruktori
            //asetetaan niin että koira syntyy mustana
            Color = "musta";
            //rotu
            breed = "unknown";
        }
        public Dog(Gender gender)
        {
            Color = "musta";
            //asetetaan koiran sukupuoli olion luonnin aikana "syntymän" aikana.
            DogGender = gender;
            breed = "unknown";
        }
        public Dog(string name, string color, Gender gender)
        {
            Name = name;
            Color = color;
            DogGender = gender;
            breed = "unknown";
        }
        public Dog(string name, string color, Gender gender, string breed) :
            this(name, color, gender)
        {
            this.breed = breed;
        }
        // methods
        public string Growl()
        {
            return "murr murr";
        }
        public string Bark(int times)
        {
            // some interesting barking action happens here
            string bark = "";
            for (int i = 0; i < times; i++)
            {
                bark += i+1 + ". vuh ";
            }
            return bark;
        }
        // events
        // indexer
        // destructor
    }
}
