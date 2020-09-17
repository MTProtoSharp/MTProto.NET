using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0xf385c1f6)]
    public class TLLangPackDifference : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xf385c1f6;
            }
        }

        [MTParameter(Order = 0)]
        public string LangCode { get; set; }
        [MTParameter(Order = 1)]
        public int FromVersion { get; set; }
        [MTParameter(Order = 2)]
        public int Version { get; set; }
        [MTParameter(Order = 3)]
        public TLVector<TLAbsLangPackString> Strings { get; set; }


    }
}
