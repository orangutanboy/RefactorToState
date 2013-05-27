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

        private readonly State _state;

        public H2O(State state)
        {
            _state = state;
        }

        public int MaxTemp
        {
            get
            {
                switch (_state)
                {
                    case State.Gas:
                        return 374;
                    case State.Liquid:
                        return 100;
                    default:
                        return 0;
                }
            }
        }

        public int MinTemp
        {
            get{
            switch (_state)
            {
                case State.Gas:
                    return 100;
                case State.Liquid:
                    return 0;
                default:
                    return -230;
            }}
        }
    }
}
