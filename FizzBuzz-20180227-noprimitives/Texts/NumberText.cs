using FizzBuzz_20180227_noprimitives.Ints;

namespace FizzBuzz_20180227_noprimitives.Texts {
    public class NumberText : IText
    {
        private readonly IInt _origin;

        public NumberText(IInt origin) => _origin = origin;

        public string RawValue() => _origin.ToString();
    }
}