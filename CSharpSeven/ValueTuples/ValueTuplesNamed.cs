namespace CSharpSeven
{
    public class ValueTuplesNamed
    {

        private (string configItem, bool success) TryGetConfig(string key)
        {
            // actual retrieval code here

            return ("ConfigKey", true); 
        }

        public void NamedAccess()
        {

            var result = TryGetConfig("SomeKey");

            bool isSuccess = result.success;
            string configItem = result.configItem;
        }


    }
}
