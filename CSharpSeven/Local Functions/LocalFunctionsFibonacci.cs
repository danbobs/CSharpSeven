using System;

namespace CSharpSeven.Local_Functions
{
    public class LocalFunctionsFibonacci
    {

        // courtesy of Mads Torgeson https://blogs.msdn.microsoft.com/dotnet/2017/03/09/new-features-in-c-7-0/
        // C#7 Local Function
        public int Fibonacci(int x)
        {
            if (x < 0) throw new ArgumentException("Less negativity please!", nameof(x));
            return Fib(x).current;

            (int current, int previous) Fib(int i)
            {
                if (i == 0) return (1, 0);
                var (p, pp) = Fib(i - 1);
                return (p + pp, p);
            }
        }

        // alternative using internal helper function
        public int Fibonacci2(int x)
        {
            if (x < 0) throw new ArgumentException("Less negativity please!", nameof(x));
            return FibInternal (x).current;       
        }

        private (int current, int previous) FibInternal(int i)
        {
            if (i == 0) return (1, 0);
            var (p, pp) = FibInternal(i - 1);
            return (p + pp, p);
        }

        // alternative using anonymous lambda function 
        //public int Fibonacci(int x)
        //{

        //    Func<int, (int, int)> fib = (int i) =>
        //    {
        //        if (i == 0) return (1, 0);
        //        var (p, pp) = fib(i - 1); // nope, can recurse with an anonymous function
        //        return (p + pp, p);
        //    };

        //    if (x < 0) throw new ArgumentException("Less negativity please!", nameof(x));
        //    return fib(x).Item1;
        //}

    }
}
