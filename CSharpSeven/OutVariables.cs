using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSeven
{
    public class OutVariables
    {

        public void OldSchool()
        {
            var input = "42";
            
            // Clunkety clunk clunk
            int i;
            var success = int.TryParse(input, out i);
        }

        public void NewStyle()
        {
            var input = "42";

            // Slightly less clunk
            var success = int.TryParse(input, out int i);
        }

    }
}
