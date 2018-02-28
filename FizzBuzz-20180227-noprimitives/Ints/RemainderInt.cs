namespace FizzBuzz_20180227_noprimitives.Ints {
    public class RemainderInt : IInt
    {
        private readonly IInt _dividend;
        private readonly IInt _divisor;

        public RemainderInt(IInt dividend, IInt divisor)
        {
            _dividend = dividend;
            _divisor = divisor;
        }

        public int RawValue() => _dividend.RawValue() % _divisor.RawValue();
    }
}