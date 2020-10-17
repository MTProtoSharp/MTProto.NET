using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Messages
{
    [MTObject(0xe8025ca2)]
    public class TLSavedGifsNotModified : TLAbsSavedGifs
    {
        public override uint Constructor
        {
            get
            {
                return 0xe8025ca2;
            }
        }



    }
}
