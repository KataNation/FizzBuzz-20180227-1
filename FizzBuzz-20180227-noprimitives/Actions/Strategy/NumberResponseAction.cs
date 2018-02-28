using FizzBuzz_20180227_noprimitives.Ints;
using FizzBuzz_20180227_noprimitives.Texts;

namespace FizzBuzz_20180227_noprimitives.Actions.Strategy {
    public class NumberResponseAction : IResponseAction
    {
        public IText Act(IInt value) => new TextOf(value.RawValue());
    }
}