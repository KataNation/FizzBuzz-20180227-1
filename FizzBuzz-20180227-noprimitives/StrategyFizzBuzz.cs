using FizzBuzz_20180227_noprimitives.Actions.Strategy;
using FizzBuzz_20180227_noprimitives.Ints;
using FizzBuzz_20180227_noprimitives.Texts;

namespace FizzBuzz_20180227_noprimitives
{
    public class StrategyFizzBuzz : IFizzBuzz
    {
        private readonly IInt _current;
        private readonly IResponseAction _responseAction;

        public StrategyFizzBuzz(IInt current) : this(current, new StrategyResponseAction()) { }
        public StrategyFizzBuzz(IInt current, IResponseAction responseAction)
        {
            _current = current;
            _responseAction = responseAction;
        }

        public IText Response() => _responseAction.Act(_current);
    }

    public interface IFizzBuzz
    {
        IText Response();
    }
}