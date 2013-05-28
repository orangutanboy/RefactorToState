using System;

namespace H2OLib
{
    public class H2O
    {
        public enum State
        {
            Gas,
            Liquid,
            Solid
        }

        private readonly IState _state;

        public H2O(State state)
        {
            var factory = new StateFactory();
            _state = factory.CreateState(state);
        }

        public int MaxTemp
        {
            get
            {
                return _state.MaxTemp;
            }
        }

        public int MinTemp
        {
            get
            {
                return _state.MinTemp;
            }
        }
    }

    public interface IState
    {
        int MinTemp { get; }
        int MaxTemp { get; }
    }

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

    public class LiquidState : IState
    {
        public int MinTemp
        {
            get { return 0; }
        }

        public int MaxTemp
        {
            get { return 100; }
        }
    }

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
