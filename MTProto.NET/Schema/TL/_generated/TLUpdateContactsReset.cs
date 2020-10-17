using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x7084a7be)]
    public class TLUpdateContactsReset : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0x7084a7be;
            }
        }



    }
}
