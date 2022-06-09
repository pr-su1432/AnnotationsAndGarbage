using System;
namespace AnnotationsAndGarbage
{
    class program
    {
        static void Main(string[] args)
        {
            NewAttribute.AttributeDisplay(typeof(Employer));
            Console.WriteLine();
            NewAttribute.AttributeDisplay(typeof(Employee));
            Console.WriteLine();

        }
    }
}
