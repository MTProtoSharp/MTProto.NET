using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x4a8537)]
    public class TLSecurePasswordKdfAlgoUnknown : TLAbsSecurePasswordKdfAlgo
    {
        public override uint Constructor
        {
            get
            {
                return 0x4a8537;
            }
        }



    }
}
