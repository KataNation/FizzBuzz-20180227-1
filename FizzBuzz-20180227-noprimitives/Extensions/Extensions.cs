using FizzBuzz_20180227_noprimitives.Bools;
using FizzBuzz_20180227_noprimitives.Ints;
using FizzBuzz_20180227_noprimitives.Texts;

namespace FizzBuzz_20180227_noprimitives.Extensions
{
    /*
     * Statics are Bad.
     * New's inlines are Bad.
     *
     * I can't find a solution for the boolean new inline.
     * I'm going with the more readable solution until I have a better solution.
     *
     * Booleans are particularly bad for this.
     */
    public static class IntExtensions
    {
        public static bool IsEvenlyDivisibleBy(this IInt dividend, IInt divisor) => new EvenlyDivisibleBy(dividend, divisor).RawValue();
    }
    public static class TextExtensions
    {
        public static bool IsEqual(this IText origin, IText other) => new EqualsText(origin, other).RawValue();
    }
}
