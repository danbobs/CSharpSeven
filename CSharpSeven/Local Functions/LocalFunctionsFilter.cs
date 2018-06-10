using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpSeven
{
    public class LocalFunctionsFilter
    {

        // Courtesy of Mads Torgeson https://blogs.msdn.microsoft.com/dotnet/2017/03/09/new-features-in-c-7-0/
        // C#7 Local Function
        public IEnumerable<T> Filter<T>(IEnumerable<T> source, Func<T, bool> filter)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            if (filter == null) throw new ArgumentNullException(nameof(filter));
            return Iterator();

            IEnumerable<T> Iterator()
            {
                foreach (var element in source)
                {
                    if (filter(element)) { yield return element; }
                }
            }
        }

        // alternative using private helper function
        public IEnumerable<T> Filter2<T>(IEnumerable<T> source, Func<T, bool> filter)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            if (filter == null) throw new ArgumentNullException(nameof(filter));
            return FilterIterator(source, filter);
        }

        private IEnumerable<T> FilterIterator<T>(IEnumerable<T> source, Func<T, bool> filter)
        {
            foreach (var element in source)
            {
                if (filter(element)) { yield return element; }
            }
        }

        // cons: 
        // - less well encapssulated
        // - replicated generics syntax & args again on internal function
        // - users of class might use internal func unwittingly and skip the param checking


        // alternative using anonymous lambda function
        public IEnumerable<T> Filter3<T>(IEnumerable<T> source, Func<T, bool> filter)
        {
            // Nope! Yield not supported in anonymous 
            //Func<IEnumerable<T>> iterator = () =>
            //{
            //    foreach (var element in source)
            //    {
            //        if (filter(element)) { yield return element; }
            //    }
            //}

            Func<IEnumerable<T>> iterator = () => source.Where(e => filter(e)); // doesn't yield

            if (source == null) throw new ArgumentNullException(nameof(source));
            if (filter == null) throw new ArgumentNullException(nameof(filter));
            return iterator();

        }



    }
}
