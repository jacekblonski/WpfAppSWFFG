using System;
using System.Collections.Generic;
using System.Text;
using WpfAppSWFFG;

namespace UnitTestProject1
{
    class SuccessTestDie : Die
    {
        public override List<Symbols> Roll()
        {
            return new List<Symbols> { Symbols.Success };
        }
    }
}
