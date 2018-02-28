using FizzBuzz_20180227_noprimitives.Extensions;
using FizzBuzz_20180227_noprimitives.Ints;
using FizzBuzz_20180227_noprimitives.Texts;

namespace FizzBuzz_20180227_noprimitives.Actions.Strategy
{
    public class FizzBuzzResponseAction : IResponseAction
    {
        private readonly IResponseAction _nextAction;
        private static readonly IText FizzBuzzText = new FizzBuzzText();
        private static readonly IInt Fifteen = new IntOf(15);
        public FizzBuzzResponseAction(IResponseAction nextAction) => _nextAction = nextAction;
        public IText Act(IInt value)
        {
            if (value.IsEvenlyDivisibleBy(Fifteen)) return FizzBuzzText;
            return _nextAction.Act(value);
        }
    }
}