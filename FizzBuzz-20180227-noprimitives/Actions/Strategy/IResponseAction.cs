using FizzBuzz_20180227_noprimitives.Ints;
using FizzBuzz_20180227_noprimitives.Texts;

namespace FizzBuzz_20180227_noprimitives.Actions.Strategy {
    public interface IResponseAction
    {
        IText Act(IInt value);
    }
}