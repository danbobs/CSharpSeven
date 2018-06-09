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
            // pros: can convert value types
            // cons: we accessed input twice

            // conversion using  "as" operator
            string text = input as string;
            if (text != null)
            {
                Console.WriteLine(text);
            }
            else
            {
                // did we end up here because input was null or not a string?
            }
            // cons: we accessed input twice, not for non-nullable types, confusion around null
        }

        private void CSharp7TypeCheckingAndConversion(object input)
        {
            if (input is int i || (input is string s && int.TryParse(s, out i)))
            {
                Console.WriteLine(i);
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
        }

    }

}
