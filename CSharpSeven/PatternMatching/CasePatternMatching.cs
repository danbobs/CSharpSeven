using System;
using System.Collections.Generic;

namespace CSharpSeven
{
    public class CasePatternMatching
    {

        private static void SwitchPattern(object o)
        {
            // can now switch on something other than primitive types, in this case an object
            // also note that order is now important
            switch (o)
            {
                case 42: // constant pattern (no change here)
                    Console.WriteLine("it's 42");
                    break;         
                case int i: // type pattern: test that the input has type T, and if so, extracts the value of the input into a fresh variable of type T
                    Console.WriteLine($"it's an int of value {i}");
                    break;
                case Person p when p.FirstName.StartsWith("Dan"):   // type pattern with a when filter
                    Console.WriteLine($"a Dan of some sort: {p.FirstName}");
                    break;
                case Person p:
                    Console.WriteLine($"any other person {p.FirstName}");
                    break;
                case var x: // var pattern: always match, and put the value of the input into a fresh variable with the same type as the input (object)
                    Console.WriteLine($"it's a var pattern with the type {x?.GetType().Name ?? "(null)"}");    // not that this case will match null
                    break;
                default: //default is alway evaluated last regardless of order
                    break;
            }
        }

        public void PatternMatch()
        {
            SwitchPattern(42);
            SwitchPattern(43);
            SwitchPattern(new Person() { FirstName = "Daniel", LastName = "Poxton" } );
            SwitchPattern(new Person() { FirstName = "Matt", LastName = "Bill" });
            SwitchPattern(new List<int>());
            SwitchPattern(null);
        }

        class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }


    }
}
