using FizzBuzz_20180227_noprimitives.Texts;

namespace FizzBuzz_20180227_noprimitives.Bools {
    public class EqualsText : IBool
    {
        private readonly IText _leftHandSide;
        private readonly IText _rightHandSide;

        public EqualsText(IText leftHandSide, IText rightHandSide)
        {
            _leftHandSide = leftHandSide;
            _rightHandSide = rightHandSide;
        }
        public bool RawValue() => _leftHandSide.RawValue() == _rightHandSide.RawValue();
    }
}