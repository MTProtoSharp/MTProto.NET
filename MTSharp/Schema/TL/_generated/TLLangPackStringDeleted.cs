using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x2979eeb2)]
    public class TLLangPackStringDeleted : TLAbsLangPackString
    {
        public override uint Constructor
        {
            get
            {
                return 0x2979eeb2;
            }
        }

        [MTParameter(Order = 0)]
        public string Key { get; set; }


    }
}
