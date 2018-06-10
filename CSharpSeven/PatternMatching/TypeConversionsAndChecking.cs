using System;

namespace CSharpSeven
{ 
    public class TypeConversionsAndChecking
    {

        private void OldSchoolTypeCheckingAndConversion(object input)
        {
            // conversion using "is" and explicit cast
            if (input is int)
            {
                int i = (int) input;
            }

            // conversion using  "as" operator (nullable types only)
            string text = input as string;
            if (text != null)
            {
                Console.WriteLine(text);
            }

        }

        private void CSharp7TypeCheckingAndConversion(object input)
        {
            // Awesome type matching
            if (input is int i || (input is string s && int.TryParse(s, out i)))
            {
                Console.WriteLine($"is int {i}");
            }

            if (input is 42) // Constant matching. Pfffh. How is this better than input == 42?
            {
                Console.WriteLine("Is 42");
            }

            if (input is var x) // Var matching. Huh? Always true, no type conversion either. Useful how?
            {
                Console.WriteLine($"Is type {x?.GetType().Name ?? "(null)"}");
            }

            
        }

        public void Run()
        {
            OldSchoolTypeCheckingAndConversion(1);
            OldSchoolTypeCheckingAndConversion("test");
            OldSchoolTypeCheckingAndConversion(null);
            OldSchoolTypeCheckingAndConversion(new Object());
            CSharp7TypeCheckingAndConversion(21);
            CSharp7TypeCheckingAndConversion("21");
            CSharp7TypeCheckingAndConversion(null);
        }

    }

}
