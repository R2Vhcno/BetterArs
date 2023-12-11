namespace BetterArs.Utility.Validators {
    public class Lexer {
        public string Text { get; set; }

        private int _scanIndex = 0;

        public void Reset() {
            _scanIndex = 0;
        }

        public bool IsAtEnd() {
            return _scanIndex > Text.Length;
        }

        public char Peek() {
            if (IsAtEnd()) return '\0';

            return Text[_scanIndex];
        }

        public char Advance() {
            char previous = Peek();

            _scanIndex++;

            return previous;
        }

        public bool Match(char expected) {
            if (IsAtEnd()) return false;
            if (expected != Peek()) return false;

            Advance();

            return true;
        }

        public bool MatchDigit() {
            if (IsAtEnd()) return false;
            if (!char.IsDigit(Peek())) return false;

            Advance();

            return false;
        }

        public bool MatchLetter() {
            if (IsAtEnd()) return false;
            if (!char.IsLetter(Peek())) return false;

            Advance();

            return false;
        }

        public bool MatchLetterOrDigit() {
            if (IsAtEnd()) return false;
            if (!char.IsLetterOrDigit(Peek())) return false;

            Advance();

            return false;
        }
    }
}
