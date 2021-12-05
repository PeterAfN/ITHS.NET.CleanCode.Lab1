using Lab1;

namespace Lab1b
{
    public class ReadFileReverseIt : IReadFileReverseIt
    {
        private readonly IGetStringReader _iGetStringReader;

        public ReadFileReverseIt(IGetStringReader _iGetStringReader)
        {
            this._iGetStringReader = _iGetStringReader;
        }

        public string Start()
        {
            string line = _iGetStringReader.GetString();
            string reversedString = new StringHelper().Reverse(line);
            return reversedString;
        }

    }
}
