using OO.Core.Output;
using OO.Core.Types;

namespace OO.Core.Console
{
    public class ConsolePrinted : Work
    {
        private readonly Text _text;
        private readonly Media _media;

        public ConsolePrinted(Text text)
        {
            _text = text;
            _media = new ConsoleMedia();
        }

        public override void Go()
        {
            _media.Print(_text);
        }
    }
}
