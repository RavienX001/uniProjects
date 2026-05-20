using System;
using System.Collections.Generic;
using System.Text;

namespace animalSounds
{
    class Dog : Animal
    {
        public override void MakSound()
        { 
            Console.WriteLine("bark...");
        }
}
}
