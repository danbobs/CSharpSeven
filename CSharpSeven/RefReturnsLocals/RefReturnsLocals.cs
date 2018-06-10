using System;


namespace CSharpSeven
{
    public class RefReturnsLocals
    {
        // courtesy of Mads Torgeson https://blogs.msdn.microsoft.com/dotnet/2017/03/09/new-features-in-c-7-0/

        // This example uses array of ints but imagine if we we using array of structs of 500mb each
        public ref int Find(int number, int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == number)
                {
                    return ref numbers[i]; // return the storage location, not the value
                }
            }
            throw new IndexOutOfRangeException($"{nameof(number)} not found");
        }

        public void Run()
        {
            int[] array = { 1, 15, -39, 0, 7, 14, -12 };
            ref int place = ref Find(7, array); // wow! this is like a pointer! int* place = &array[4] 
            place = 9; // replaces 7 with 9 in the array
            Console.WriteLine(array[4]); // prints 9
        }



        public void Experiments()
        {
            int x = 1;
            ref int pointer = ref x; // I got me a clunky pointer!
            pointer = 2;
            Console.WriteLine(x);   // prints 2
            int y = 1;
            //pointer = ref y;       // not allowed, ref locals are not mutable.
        }


        public ref int Dangerous()
        {
            int x = 1;
            return ref x;   // not allowed, x is not ref local. Can only return refs that are "safe" to return.                      
        }

    }
}
