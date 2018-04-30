using System;
using System.Collections.Generic;
using System.Text;

namespace Dice
{
    class Dice
    {
        int sides;
        string type;
        public int Sides1  //Property
        {
            get { return this.sides; }
            set { sides = value; }
        }

        public void Roll()
        {

        }

        public void SetSides(int setedSides)
        {
            if (setedSides < 3)
            {
                throw new Exception("Invalid Sides Bound");

            }

            sides = setedSides;
        }
    }

    class Person
    {
        string firstName;
        string lastName;
        public string FirstName
        {
            get { return firstName;  }
            set { firstName = value; }
        }
        public string SecondName //property
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string FullName
        {
            get
            {
                return firstName +" " + lastName;
            }
        }
    }
}
