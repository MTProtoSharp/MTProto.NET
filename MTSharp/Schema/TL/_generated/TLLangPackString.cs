using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0xcad181f6)]
    public class TLLangPackString : TLAbsLangPackString
    {
        public override uint Constructor
        {
            get
            {
                return 0xcad181f6;
            }
        }

        [MTParameter(Order = 0)]
        public string Key { get; set; }
        [MTParameter(Order = 1)]
        public string Value { get; set; }


    }
}
