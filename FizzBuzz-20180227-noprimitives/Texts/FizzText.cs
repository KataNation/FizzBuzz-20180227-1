namespace FizzBuzz_20180227_noprimitives.Texts {
    public class FizzText : IText
    {
        private static readonly IText Fizz = new TextOf("Fizz");
        public override bool Equals(object obj) => Fizz.Equals(obj);

        public override int GetHashCode() => Fizz.GetHashCode();
        public string RawValue() => "Fizz";
    }
}