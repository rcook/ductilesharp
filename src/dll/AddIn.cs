using System;

namespace Mono.DuctileSharp
{
    public sealed class AddIn
    {
        public AddIn()
        {
            Console.WriteLine("AddIn..ctor");
        }

        public void DoSomething()
        {
            Console.WriteLine("AddIn.DoSomething");
        }
    }
}

