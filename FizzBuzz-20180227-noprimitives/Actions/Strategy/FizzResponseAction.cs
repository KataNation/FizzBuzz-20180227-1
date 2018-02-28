using FizzBuzz_20180227_noprimitives.Extensions;
using FizzBuzz_20180227_noprimitives.Ints;
using FizzBuzz_20180227_noprimitives.Texts;

namespace FizzBuzz_20180227_noprimitives.Actions.Strategy
{
    public class FizzResponseAction : IResponseAction
    {
        private readonly IResponseAction _nextAction;
        private static readonly IText FizzText = new FizzText();
        private static readonly IInt Three = new IntOf(3);
        public FizzResponseAction(IResponseAction nextAction) => _nextAction = nextAction;
        public IText Act(IInt value)
        {
            if (value.IsEvenlyDivisibleBy(Three)) return FizzText;
            return _nextAction.Act(value);
        }
    }
}