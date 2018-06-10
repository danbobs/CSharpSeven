﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSeven
{
    class Program
    {
        static void Main(string[] args)
        {
            var vtExample = new ValueTuples();
            vtExample.TupleTricks();
            var cpm = new CasePatternMatching();
            cpm.PatternMatch();
            var tcac = new TypeConversionsAndChecking();
            tcac.Run();
            var rrl = new RefReturnsLocals();
            rrl.Run();
        }
    }
}
