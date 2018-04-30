using System;
using System.Collections.Generic;
using System.Text;

namespace ClasAndObj
{
    class Dog
    {
        private string name;
        private string breed;
        private int legs;

        public Dog () //constructors
        {

        }
        public Dog(string name, string breed, int kraka)
        {
            this.name = name;
            this.breed = breed;
            this.legs = kraka;

        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Breed
        {
            
            get { return this.breed; }
            set { this.breed = value; }
        }
        public int Legs
        {
            get { return this.Legs; }
            set { this.legs = value; }
        }

        public void SayBau()
        {
            Console.WriteLine("Hello! -> {0} said : BAUUUUU! and is breeding:{1} and walks na {2} legs",this.name ?? "[unanemed dog]",this.breed, this.legs);
        }
    }
}
