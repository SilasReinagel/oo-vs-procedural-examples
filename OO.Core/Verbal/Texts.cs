using OO.Core.Group;
using OO.Core.Verbal;
using System.Collections.Generic;
using System.Linq;

namespace OO.Core.Types
{
    public sealed class Texts : Group<Text>
    {
        public Texts(params string[] texts)
            : this(texts.Select(x => new StringText(x))) { }

        public Texts(params Text[] texts)
            : this ((IEnumerable<Text>)texts) { }

        public Texts(IEnumerable<Text> texts)
            : base(texts) { }
    }
}
