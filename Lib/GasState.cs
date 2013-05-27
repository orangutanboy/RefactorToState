using System;

namespace H2OLib
{
    public class GasState : IState
    {
        public int MinTemp
        {
            get { return 100; }
        }

        public int MaxTemp
        {
            get { return 374; }
        }
    }
}
