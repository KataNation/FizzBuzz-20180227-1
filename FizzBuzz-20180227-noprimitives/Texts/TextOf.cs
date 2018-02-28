using System;

namespace FizzBuzz_20180227_noprimitives.Texts {
    public class TextOf : IText
    {
        private readonly Func<string> _origin;

        public TextOf(int origin) : this(origin.ToString) { }

        public TextOf(string origin) : this(() => origin) { }

        private TextOf(Func<string> origin) => _origin = origin;

        public override bool Equals(object obj) => Equals((TextOf)obj);

        public override int GetHashCode() => _origin() != null ? _origin().GetHashCode() : 0;

        public bool Equals(TextOf other) => other != null && this._origin() == other._origin();
        public string RawValue() => _origin();
    }
}