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
        }

        public void StillFirstClassObjects()
        {
            // Value Tuples are still first class objects, so we can assign them thus:
            (string, bool) result = TryGetConfig("SomeKey");
            var result2 = TryGetConfig("SomeKey");
            // deconstruct again
            var (configItem, success) = result;
            // or access items like this
            bool isSuccess = result.Item2;
        }


    }
}
