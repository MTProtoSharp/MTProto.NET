using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Messages
{
    [MTObject(0x6a3f8d65)]
    public class TLGetAllDrafts : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x6a3f8d65;
            }
        }



    }
}
