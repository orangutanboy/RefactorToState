using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2OLib
{
    public class StateFactory
    {
        public IState CreateState(H2OLib.H2O.State state)
        {
            switch (state)
            {
                case H2O.State.Gas:
                    {
                        return new GasState();
                    }
                case H2O.State.Liquid:
                    {
                        return new LiquidState();
                    }
                case H2O.State.Solid:
                    {
                        return new SolidState();
                    }
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
