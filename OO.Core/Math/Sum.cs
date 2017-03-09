using OO.Core.Types;

namespace OO.Core.Math
{
    public class Sum : Number
    {
        private readonly Number _first;
        private readonly Number _second;

        public Sum(Number first, Number second)
        {
            _first = first;
            _second = second;
        }

        protected override decimal AsReal()
        {
            return _first + _second;
        }
    }
}
