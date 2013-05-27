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
}
