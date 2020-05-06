using System;
using System.Collections.Generic;
using System.Text;

namespace WpfAppSWFFG
{
    public class DicePool
    {
        public List<Die> dice { get; }
        private List<Symbols> result { get; set; }

        public DicePool()
        {
            dice = new List<Die>();
            result = new List<Symbols>();
        }

        public void AddDie (Die die)
        {
            dice.Add(die);
        }
        public string Roll()
        {
            foreach (Die die in dice)                
            {
                var dieResult = die.Roll();
                foreach (Symbols symbol in dieResult)
                {
                    result.Add(symbol);
                }
            }
            var numSuccess = 0;
            var numAdv = 0;
            var numTriumph = 0;
            var numDespair = 0;
            var numLightFPs = 0;
            var numDarkFPs = 0;
            foreach (Symbols symbol in result)
            {
                switch (symbol)
                {
                    case Symbols.Success:
                        numSuccess++;
                        break;
                    case Symbols.Failure:
                        numSuccess--;
                        break;
                    case Symbols.Advantage:
                        numAdv++;
                        break;
                    case Symbols.Threat:
                        numAdv--;
                        break;
                    case Symbols.Triumph:
                        numSuccess++;
                        numTriumph++;
                        break;
                    case Symbols.Despair:
                        numSuccess--;
                        numDespair++;
                        break;
                    case Symbols.LightForcePoint:
                        numLightFPs++;
                        break;
                    case Symbols.DarkForcePoint:
                        numDarkFPs++;
                        break;
                    default:
                        break;
                }
            }
            var res = "";
            if (numSuccess > 1)
            {
                res += numSuccess.ToString() + " successes ";
            }
            else if (numSuccess == 1)
            {
                res += "1 success ";
            }
            else if (numSuccess == -1)
            {
                res += "1 failure ";
            }
            else if (numSuccess < -1)
            {
                res += Math.Abs(numSuccess).ToString() + " failures ";
            }
            if (numAdv > 1)
            {
                res += numAdv.ToString() + " advantages ";
            }
            else if (numAdv == 1)
            {
                res += "1 advantage ";
            }
            else if (numAdv == -1)
            {
                res += "1 threat ";
            }
            else if (numAdv < -1)
            {
                res += Math.Abs(numAdv).ToString() + " threats ";
            }
            
            if (numTriumph > 1)
            {
                res += numTriumph.ToString() + " triumphs ";
            }
            else if (numTriumph == 1)
            {
                res += "1 triumph ";
            }

            if (numDespair > 1)
            {
                res += numDespair.ToString() + " despair ";
            }
            else if (numDespair == 1)
            {
                res += "1 despair ";
            }

            if (numLightFPs > 1)
            {
                res += numLightFPs.ToString() + " Light Side Force Points ";
            }
            else if (numLightFPs == 1)
            {
                res += "1 Light Side Force Point ";
            }

            if (numDarkFPs > 1)
            {
                res += numDarkFPs.ToString() + " Dark Side Force Points ";
            }
            else if (numDarkFPs == 1)
            {
                res += "1 Dark Side Force Point ";
            }


            return res;
        }
    }
}
