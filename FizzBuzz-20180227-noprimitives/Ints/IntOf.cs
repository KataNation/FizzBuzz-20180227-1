using System;

namespace FizzBuzz_20180227_noprimitives.Ints {
    public class IntOf : IInt
    {
        private readonly Func<int> _origin;
        public IntOf(int origin) : this(() => origin) { }
        private IntOf(Func<int> origin) => _origin = origin;

        public int RawValue() => _origin();
    }
}