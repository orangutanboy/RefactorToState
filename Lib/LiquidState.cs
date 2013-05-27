using System;

namespace H2OLib
{
    public class LiquidState:IState
    {
        public int MinTemp
        {
            get {return 0; }
        }

        public int MaxTemp
        {
            get { return 100; }
        }
    }
}
