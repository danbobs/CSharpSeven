using System.Collections.Generic;

namespace CSharpSeven
{
    public class ValueTuples
    {

        private (string, bool) TryGetConfig(string key)
        {
            // actual retrieval code here

            return ("ConfigKey", true); // return a "tuple literal"
        }

        public void Deconstruction()
        {
            // Deconstruction
            (string configItem, bool success) = TryGetConfig("SomeKey");
            var (configItem2, success2) = TryGetConfig("SomeKey");
            (var configItem3, var success3) = TryGetConfig("SomeKey");
            // re-use previous declaration
            (configItem, success) = TryGetConfig("SomeKey");
            // wildcard discards
            (_, success) = TryGetConfig("SomeKey");

        }

        public void StillFirstClassObjects()
        {
            // Value Tuples are still first class objects, so we can assign them thus:
            (string, bool) result = TryGetConfig("SomeKey");
            var result2 = TryGetConfig("SomeKey");
            // deconstruct again
            var (configItem, success) = result;
            // or access items like this
            bool isSuccess = result.Item2; // just like old System.Tuple
        }

        public void TupleTricks()
        {
            int x = 1; int y = 2;
            // swap x,y values without third var
            (x, y) = (y, x); // x  = 2, y = 1


            var queue = new List<string>() { "Tom", "Dan", "Alan" };
            // Pop first item to the back of queue
            (queue[0], queue[1], queue[2]) = (queue[1], queue[2], queue[0]); // Now "Dan", "Alan", "Tom"
        }


    }
}
