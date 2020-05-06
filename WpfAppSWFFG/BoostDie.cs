using System;
using System.Collections.Generic;
using System.Text;

namespace WpfAppSWFFG
{
    public class BoostDie : Die
    {
        public override List<Symbols> Roll()
        {
            var res = new List<Symbols>();
            Random rnd = new Random();
            int side = rnd.Next(1, 7);
            switch (side)
            {
                case 1:                    
                    break;
                case 2:                    
                    break;
                case 3:
                    res.Add(Symbols.Success);
                    break;
                case 4:
                    res.Add(Symbols.Success);
                    res.Add(Symbols.Advantage);
                    break;
                case 5:
                    res.Add(Symbols.Advantage);
                    res.Add(Symbols.Advantage);
                    break;
                case 6:
                    res.Add(Symbols.Advantage);
                    break;
                default:
                    break;
            }
            return res;
        }
    }
}
