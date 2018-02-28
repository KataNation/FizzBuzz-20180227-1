namespace FizzBuzz_20180227_noprimitives.Texts {
    public class BuzzText : IText
    {
        private static readonly IText Buzz = new TextOf("Buzz");
        public override bool Equals(object obj) => Buzz.Equals(obj);

        public override int GetHashCode() => Buzz.GetHashCode();
        public string RawValue() => "Buzz";
    }
}