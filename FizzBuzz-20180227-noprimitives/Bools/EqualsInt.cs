using FizzBuzz_20180227_noprimitives.Ints;

namespace FizzBuzz_20180227_noprimitives.Bools {
    public class EqualsInt : IBool
    {
        private readonly IInt _leftHandSide;
        private readonly IInt _rightHandSide;

        public EqualsInt(IInt leftHandSide, IInt rightHandSide)
        {
            _leftHandSide = leftHandSide;
            _rightHandSide = rightHandSide;
        }
        public bool RawValue() => _leftHandSide.RawValue() == _rightHandSide.RawValue();
    }
}