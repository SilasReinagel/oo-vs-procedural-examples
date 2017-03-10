using OO.Core.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OO.Core.Math
{
    public sealed class Numbers
    {
        private readonly IEnumerable<Number> _numbers;

        public Numbers(params Number[] numbers)
            : this((IEnumerable<Number>)numbers) { }

        public Numbers(IEnumerable<Number> numbers)
        {
            _numbers = numbers;
        }

        public Number Reduce(Func<IEnumerable<Number>, Number> func)
        {
            return func(_numbers);
        }

        public Number Sum()
        {
            return Reduce(x => x.Sum(n => (decimal)n));
        }

        public static implicit operator Numbers(Number[] numbers)
        {
            return new Numbers(numbers);
        }
    }
}
