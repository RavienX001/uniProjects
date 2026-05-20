using System;
using System.Collections.Generic;
using System.Text;

namespace animalSounds
{
    internal class Cat : Animal
    {
        public override void MakSound()
        {
            Console.WriteLine("meow...");
        }
    }
}

}
