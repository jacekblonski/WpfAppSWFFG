using System.Collections.Generic;

namespace WpfAppSWFFG
{
    public enum Symbols
    { 
        Success,
        Failure,
        Advantage,
        Threat,
        Triumph,
        Despair,
        LightForcePoint,
        DarkForcePoint
    }
    public abstract class Die
    {
        public abstract List<Symbols> Roll();
    }
}