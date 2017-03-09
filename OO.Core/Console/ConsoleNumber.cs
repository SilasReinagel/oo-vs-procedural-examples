using OO.Core.Math;
using OO.Core.Types;

namespace OO.Core.Console
{
    public class ConsoleNumber : Number
    {
        private readonly Text _text;

        public ConsoleNumber()
        {
            _text = new ConsoleText();
        }

        protected override decimal AsReal()
        {
            return new TextAsNumber(_text);
        }
    }
}
