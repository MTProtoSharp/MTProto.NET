using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x37c1011c)]
    public class TLChatPhotoEmpty : TLAbsChatPhoto
    {
        public override uint Constructor
        {
            get
            {
                return 0x37c1011c;
            }
        }



    }
}
