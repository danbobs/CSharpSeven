using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSeven
{
    public class ThrowExpressions
    {


        private string DoSomething(string str)
        {
            return str + "something";
        }

        public void OldSchool(string str)
        {
            // old school 
            string result;
            if (str == null)
                throw new ArgumentNullException(str);
            else
                result = DoSomething(str);
        }

        // technically posssible to throw in expression by wrapping in anonymous func, y'know, yuk.
        public void OldSchool2(string str)
        {
            var result = (str == null) ? new Func<string>(() => { throw new Exception(); })() : DoSomething(str);
        }

        public void ThrowExpression(string str)
        {
            // with throw expression
            var result = (str == null) ? throw new ArgumentNullException(str) : DoSomething(str);
            result = str ?? throw new ArgumentNullException(str);
            // not allowed though surprisingly
            //result = throw new ArgumentNullException(str); // "A throw expression is not allowed in this context"

        }

    }
}
