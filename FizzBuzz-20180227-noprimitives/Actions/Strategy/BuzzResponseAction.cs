using FizzBuzz_20180227_noprimitives.Extensions;
using FizzBuzz_20180227_noprimitives.Ints;
using FizzBuzz_20180227_noprimitives.Texts;

namespace FizzBuzz_20180227_noprimitives.Actions.Strategy
{
    public class BuzzResponseAction : IResponseAction
    {
        private readonly IResponseAction _nextAction;
        private static readonly IText BuzzText = new BuzzText();
        private static readonly IInt Five = new IntOf(5);
        public BuzzResponseAction(IResponseAction nextAction) => _nextAction = nextAction;
        public IText Act(IInt value)
        {
            if (value.IsEvenlyDivisibleBy(Five)) return BuzzText;
            return _nextAction.Act(value);
        }
    }
}