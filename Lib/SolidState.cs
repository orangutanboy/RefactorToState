using System;

namespace H2OLib
{
    public class SolidState : IState
    {
        public int MinTemp
        {
            get { return -230; }
        }

        public int MaxTemp
        {
            get { return 0; }
        }
    }
}
