namespace RdTips1
{
    public class ReSpeller
    {
        public readonly bool WrapsPostiveNumber;
        public readonly int Number;

        private ReSpeller(bool wrapsPostiveNumber)
        {
            WrapsPostiveNumber = wrapsPostiveNumber;
        }

        // Constructor initialzier
        public ReSpeller(string str) : this(int.TryParse(str, out var input) && input > 0)
        {
            Number = input;
        }
    }
}