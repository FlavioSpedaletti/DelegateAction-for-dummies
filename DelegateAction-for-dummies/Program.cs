using System;

namespace DelegateAction_for_dummies
{
    class Program
    {
        static Action hello = () => Console.WriteLine("Hello");

        static void Main(string[] args)
        {
            hello += () => Console.WriteLine("Dummy");
            hello += () => Console.WriteLine("Chaining actions like a boss 😎");

            hello();
        }
    }
}
