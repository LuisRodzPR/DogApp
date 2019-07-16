using System;
using System.Collections.Generic;
using System.Text;

namespace DogApp
{
    //class Dog
    //{
    //    private string name;
    //    private string owner;

    //    public string GetName()
    //    {
    //        return name;
    //    }

    //    public string GetOwner()
    //    {
    //        return owner;
    //    }

    //    public void SetOwner(string owner)
    //    {
    //        if (owner == null)
    //        {
    //            throw new ArgumentNullException("owner");
    //        }
    //        this.owner = owner;
    //    }
    // this is an "auto-property"
    // a "backing field" is automatically
    // added for it
        public string Name { get; set; }

        private string owner;

        public string Owner
    {

    }

        // every class has at leats one constructor
        // if you do not code one, it gets
        // a default contructor with no parameters
        // and no extra behavior
        
        public Dog(string name)
        {
            //setting the fields value
            // from the constructor parameter
            this.name = name;
        }

        // acess modifiers;
        // private: visible only inside the class
        // aqll class members are private by default
        //public = visible to all
        public void Bark()
        {
            Console.WriteLine("Bark");
        }
    }
}
