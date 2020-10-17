using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
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
