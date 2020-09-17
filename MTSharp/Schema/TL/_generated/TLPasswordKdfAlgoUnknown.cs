using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0xd45ab096)]
    public class TLPasswordKdfAlgoUnknown : TLAbsPasswordKdfAlgo
    {
        public override uint Constructor
        {
            get
            {
                return 0xd45ab096;
            }
        }



    }
}
