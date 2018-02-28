using FizzBuzz_20180227_noprimitives.Ints;
using FizzBuzz_20180227_noprimitives.Texts;

namespace FizzBuzz_20180227_noprimitives.Actions.Strategy {
    public class StrategyResponseAction : IResponseAction
    {
        private readonly IResponseAction _nextAction;

        public StrategyResponseAction() : this(
            new FizzBuzzResponseAction(
                new BuzzResponseAction(
                    new FizzResponseAction(
                        new NumberResponseAction())))
        )
        { }
        public StrategyResponseAction(IResponseAction nextAction) => _nextAction = nextAction;

        public IText Act(IInt value) => _nextAction.Act(value);
    }
}